using System.Text;
using CodeGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;

string solution_folder = Helpers.TryGetSolutionPath() ?? string.Empty;

string source_folder = Path.Combine(solution_folder, "Source", "ScikitLearn.Signatures");
string source_project = Path.Combine(source_folder, "ScikitLearn.Signatures.csproj");

// Create workspace and load project
var workspace = MSBuildWorkspace.Create();
var project = await workspace.OpenProjectAsync(source_project);

await Parallel.ForEachAsync(
    project.Documents.Where(d => d.Name.StartsWith("sklearn")),
    new ParallelOptions() { MaxDegreeOfParallelism = 16 },
    static async (document, token) =>
{
    string file_name = Path.GetFileNameWithoutExtension(document.Name);

    // Syntax tree and semantic model
    SyntaxTree? tree = await document.GetSyntaxTreeAsync(token);
    if (tree is null) return;

    SyntaxNode root = await tree.GetRootAsync(token);
    SemanticModel? semantic_model = await document.GetSemanticModelAsync(token);
    if (semantic_model is null) return;

    // Namespace
    var namespace_node = root
        .DescendantNodes()
        .OfType<BaseNamespaceDeclarationSyntax>()
        .FirstOrDefault();

    if (namespace_node is null)
    {
        Console.WriteLine($"[Error] Namespace not found in {file_name}");
        return;
    }

    // Build all classes in the namespace
    StringBuilder sb = new();
    sb.AppendLine("namespace ScikitLearn;");
    sb.AppendLine("#nullable enable");
    var class_nodes = namespace_node.Members.OfType<ClassDeclarationSyntax>();

    foreach (var class_node in class_nodes)
        WriteClass(class_node, semantic_model, sb, [class_node.Identifier.Text], null);

    // Output Path
    string solution_folder = Helpers.TryGetSolutionPath() ?? string.Empty;
    string output_folder = Path.Combine(solution_folder, "Source", "ScikitLearn");
    string output_file_path = Path.Combine(output_folder, $"{file_name}.g.cs");

    // Formatting the generated code
    SyntaxTree output_tree = CSharpSyntaxTree.ParseText(sb.ToString(), cancellationToken: token);
    SyntaxNode output_root = output_tree.GetRoot(token);
    string formatted_code = output_root.NormalizeWhitespace().ToFullString();

    // Write formatted code to file
    File.WriteAllText(output_file_path, formatted_code);
});


static bool IsValidModule(ClassDeclarationSyntax classNode)
{
    bool hasModuleAttribute = classNode.AttributeLists
        .SelectMany(list => list.Attributes)
        .Any(attr => attr.Name.ToString().Contains("Module", StringComparison.OrdinalIgnoreCase));

    bool isStatic = classNode.Modifiers.Any(mod => mod.IsKind(SyntaxKind.StaticKeyword));

    return hasModuleAttribute && isStatic;
}

static void BuildArgs(BaseMethodDeclarationSyntax method_node, StringBuilder sb)
{
    var params_without_default = method_node.ParameterList.Parameters
        .Where(p => p.Default == null)
        .ToList();

    sb.Append("PyTuple args = new PyTuple(new PyObject[] {");
    sb.AppendJoin(',', params_without_default.Select(p => $"Helpers.ToPython({p.Identifier.Text})"));
    sb.AppendLine("});");
}

static void BuildPyDict(BaseMethodDeclarationSyntax method_node, StringBuilder sb)
{
    var params_with_default = method_node.ParameterList.Parameters
        .Where(p => p.Default != null)
        .ToList();

    sb.AppendLine("PyDict pyDict = new PyDict();");
    foreach (var p in params_with_default)
    {
        string param_name = p.Identifier.Text;
        string py_param_name = p.Identifier.Text.TrimStart('@');

        sb.AppendLine($"if ({param_name} != {p.Default?.Value})");
        sb.AppendLine($"pyDict[\"{py_param_name}\"] = Helpers.ToPython({param_name});");
    }
}

static bool InheritsFrom(INamedTypeSymbol type, string baseTypeFullName)
{
    var current = type.BaseType;
    while (current != null)
    {
        if (current.ToDisplayString() == baseTypeFullName)
            return true;
        current = current.BaseType;
    }
    return false;
}

static string? WriteReturn(ITypeSymbol type, string pyObject, StringBuilder sb)
{
    switch (type.SpecialType)
    {
        case SpecialType.System_Boolean:
            return $"{pyObject}.As<bool>()";

        case SpecialType.System_Int32:
            return $"{pyObject}.As<int>()";

        case SpecialType.System_Single:
            return $"{pyObject}.As<float>()";

        case SpecialType.System_Double:
            return $"{pyObject}.As<double>()";

        case SpecialType.System_String:
            return $"{pyObject}.As<string>()";
    }

    if (type.TypeKind == TypeKind.Class && type is INamedTypeSymbol namedType)
    {
        string fullName = namedType.ToDisplayString();

        switch (fullName)
        {
            case "Python.Runtime.PyObject":
                return pyObject;

            case "Python.Runtime.PyDict":
                return ($"new PyDict({pyObject})");

            case "Python.Runtime.PyTuple":
                return ($"new PyTuple({pyObject})");

            case "Numpy.NDarray":
                return ($"new NDarray({pyObject})");
        }

        if (namedType.Name == "NDarray" && namedType.TypeArguments.Length == 1)
        {
            string genericArg = namedType.TypeArguments[0].ToDisplayString();
            return $"new NDarray<{genericArg}>({pyObject})";
        }

        if (InheritsFrom(namedType, "Numpy.PythonObject"))
        {
            return $"{fullName}.Wrap({pyObject});";
        }
    }

    Console.WriteLine($"Failed to convert {type.ToDisplayString()}");
    return null;
}

static void WriteClass(
        ClassDeclarationSyntax classNode,
        SemanticModel semanticModel,
        StringBuilder sb,
        string[] classPath,
        string[]? lastModule)
{
    using (CodeBlock.BeginClass(classNode, sb))
    {
        // ----------------------------
        // CONSTRUCTORS
        // ----------------------------

        if (IsValidModule(classNode))
        {
            lastModule = classPath;
            WriteModuleConstructor(classNode, sb, lastModule);
        }
        else
        {
            var constructors = classNode.Members.OfType<ConstructorDeclarationSyntax>();

            foreach (var constructor in constructors)
            {
                if (lastModule is not null)
                    WriteConstructor(constructor, sb, lastModule);
                else
                    Console.WriteLine($"Error: Constructor '{constructor.Identifier.Text}' has no associated module.");
            }
        }

        // ----------------------------
        // PROPERTIES
        // ----------------------------

        var properties = classNode.Members.OfType<PropertyDeclarationSyntax>();

        foreach (var property in properties)
            WriteProperty(property, semanticModel, sb);

        // ----------------------------
        // METHODS
        // ----------------------------

        var methods = classNode.Members.OfType<MethodDeclarationSyntax>();

        // Static methods
        var staticMethods = methods.Where(m => m.Modifiers.Any(mod => mod.IsKind(SyntaxKind.StaticKeyword)));
        foreach (var staticMethod in staticMethods)
        {
            if (lastModule is not null)
                WriteStaticMethod(staticMethod, semanticModel, sb, lastModule);
            else
                Console.WriteLine($"Error: Static method '{staticMethod.Identifier.Text}' has no associated module.");
        }

        // Instance methods
        var instanceMethods = methods.Where(m => !m.Modifiers.Any(mod => mod.IsKind(SyntaxKind.StaticKeyword)));
        foreach (var instanceMethod in instanceMethods)
            WriteInstanceMethod(instanceMethod, semanticModel, sb);

        // ----------------------------
        // INNER CLASSES
        // ----------------------------

        foreach (var innerClass in classNode.Members.OfType<ClassDeclarationSyntax>())
            WriteClass(innerClass, semanticModel, sb, [.. classPath, innerClass.Identifier.Text], lastModule);
    }
}

static void WriteModuleConstructor(
    ClassDeclarationSyntax classNode,
    StringBuilder sb,
    string[] lastModulePath)
{
    // Prepare names
    var pyModule = string.Join('.', lastModulePath.Select(p => p.TrimStart('@')));

    // Generate fields and properties
    sb.AppendLine("private static Lazy<PyObject> _lazy_self;");
    sb.AppendLine("public static PyObject self { get => _lazy_self.Value; }");

    // Generate ReInitializeLazySelf method
    sb.AppendLine(@"
    private static void ReInitializeLazySelf()
    {
        _lazy_self = new Lazy<PyObject>(() =>
        {
            try
            {
                return InstallAndImport();
            }
            catch (Exception)
            {
                return InstallAndImport(true);
            }
        });
    }");

    // Generate InstallAndImport method
    sb.AppendLine($@"
    private static PyObject InstallAndImport(bool force = false)
    {{
        PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
        PythonEngine.Initialize();
        return Py.Import(""{pyModule}"");
    }}");

    // Generate static constructor
    sb.AppendLine($"static {classNode.Identifier.Text}() => ReInitializeLazySelf();");
}

static void WriteConstructor(
    ConstructorDeclarationSyntax constructorNode,
    StringBuilder sb,
    string[] lastModulePath)
{
    // Prepare names
    string csConstructorName = constructorNode.Identifier.Text;
    string pyConstructorName = constructorNode.Identifier.Text.TrimStart('@');
    string csModule = string.Join('.', lastModulePath);

    // Generate public constructor
    using (CodeBlock.BeginConstructor(constructorNode, sb))
    {
        sb.AppendLine($"_ = {csModule}.self;");
        BuildArgs(constructorNode, sb);
        BuildPyDict(constructorNode, sb);
        sb.AppendLine($"self = {csModule}.self.InvokeMethod(\"{pyConstructorName}\", args, pyDict);");
    }

    // Generate internal constructor (from pyObject)
    using (CodeBlock.BeginInternalConstructor(constructorNode, sb))
    {
        sb.AppendLine($"_ = {csModule}.self;");
        sb.AppendLine("self = pyObject;");
    }

    // Generate factory methods
    sb.AppendLine(@"[Obsolete(""Encapsule is deprecated. Use Wrap instead."")]");
    sb.AppendLine($"public static {csConstructorName} Encapsule(PyObject pyObject) => new {csConstructorName}(pyObject);");
    sb.AppendLine($"public static {csConstructorName} Wrap(PyObject pyObject) => new {csConstructorName}(pyObject);");
}

static void WriteProperty(
    PropertyDeclarationSyntax propertyNode,
    SemanticModel semanticModel,
    StringBuilder sb)
{
    // Prepare names
    string pyPropertyName = propertyNode.Identifier.Text.TrimStart('@');
    string pyObject = $"self.GetAttr(\"{pyPropertyName}\")";
    var type = semanticModel.GetDeclaredSymbol(propertyNode)?.Type;

    if (type == null || type.SpecialType == SpecialType.System_Void)
    {
        Console.WriteLine($"[ERROR] Failed to create property {pyPropertyName}");
        return;
    }
    using (CodeBlock.BeginProperty(propertyNode, sb))
    {
        using (CodeBlock.BeginGet(sb))
        {
            string? return_value = WriteReturn(type, pyObject, sb);
            if (return_value is not null)
                sb.AppendLine($"return {return_value};");
            else sb.AppendLine("throw new NotImplementedException();");
        }
    }
}

static void WriteInstanceMethod(
    MethodDeclarationSyntax method_node,
    SemanticModel semantic_model,
    StringBuilder sb)
{
    bool return_this = method_node.AttributeLists
        .SelectMany(a => a.Attributes)
        .Any(a => a.Name.ToString().Contains("ReturnThis"));

    bool is_variant = method_node.AttributeLists
        .SelectMany(a => a.Attributes)
        .Any(a => a.Name.ToString().Contains("TupleVariantSelector"));

    using (CodeBlock.BeginMethod(method_node, sb))
    {
        BuildArgs(method_node, sb);
        BuildPyDict(method_node, sb);
        string py_method_name = method_node.Identifier.Text.TrimStart('@');
        string invoke_method = $"self.InvokeMethod(\"{py_method_name}\", args, pyDict)";

        if (return_this)
        {
            sb.AppendLine($"{invoke_method};");
            sb.AppendLine("return this;");
            return;
        }

        var type = semantic_model.GetDeclaredSymbol(method_node)?.ReturnType;
        if (type == null || type.SpecialType == SpecialType.System_Void)
        {
            sb.AppendLine($"{invoke_method};");
            return;
        }

        if (is_variant)
        {
            // TODO obtener los elementos de la tupla y luego analizar cada uno
            WriteReturn(type, invoke_method, sb);
            return;
        }
        else
        {
            WriteReturn(type, invoke_method, sb);
        }
    }
}

static void WriteStaticMethod(
    MethodDeclarationSyntax method_node,
    SemanticModel semantic_model,
    StringBuilder sb,
    string[] last_module_path)
{
    using (CodeBlock.BeginMethod(method_node, sb))
    {
        string module = string.Join('.', last_module_path);
        sb.AppendLine($"_ = {module}.self;");

        BuildArgs(method_node, sb);
        BuildPyDict(method_node, sb);
        string py_method_name = method_node.Identifier.Text.TrimStart('@');
        string invoke_method = $"self.InvokeMethod(\"{py_method_name}\", args, pyDict)";

        var type = semantic_model.GetDeclaredSymbol(method_node)?.ReturnType;
        if (type == null || type.SpecialType == SpecialType.System_Void)
        {
            sb.AppendLine($"{invoke_method};");
        }
        else
        {
            WriteReturn(type, invoke_method, sb);
        }
    }
}

class CodeBlock : IDisposable
{
    private readonly StringBuilder stringBuilder;

    private CodeBlock(StringBuilder sb)
    {
        stringBuilder = sb;
        stringBuilder.AppendLine("{");
    }

    public static CodeBlock BeginMethod(MethodDeclarationSyntax method_node, StringBuilder sb)
    {
        sb.Append($"{method_node.Modifiers} {method_node.ReturnType} {method_node.Identifier}(");
        sb.AppendJoin(',', method_node.ParameterList.Parameters);
        sb.AppendLine(")");
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginConstructor(ConstructorDeclarationSyntax constructor_node, StringBuilder sb)
    {
        sb.Append($"{constructor_node.Modifiers} {constructor_node.Identifier}(");
        sb.AppendJoin(',', constructor_node.ParameterList.Parameters);
        sb.AppendLine(")");
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginInternalConstructor(ConstructorDeclarationSyntax constructor_node, StringBuilder sb)
    {
        sb.Append($"internal {constructor_node.Identifier}(PyObject pyObject)");
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginClass(ClassDeclarationSyntax class_node, StringBuilder sb)
    {
        sb.Append($"{class_node.Modifiers} class {class_node.Identifier}");
        if (class_node.BaseList != null && class_node.BaseList.Types.Count > 0)
        {
            sb.Append(':');
            sb.AppendJoin(',', class_node.BaseList.Types);
        }
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginProperty(PropertyDeclarationSyntax propertyNode, StringBuilder sb)
    {
        sb.Append($"{propertyNode.Modifiers} {propertyNode.Type} {propertyNode.Identifier}");
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginGet(StringBuilder sb)
    {
        sb.Append("get");
        return new CodeBlock(sb);
    }

    public void Dispose()
    {
        stringBuilder.AppendLine("}");
    }
}