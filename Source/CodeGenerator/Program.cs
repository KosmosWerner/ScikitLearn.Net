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
        BuildClass(class_node, semantic_model, sb, [class_node.Identifier.Text], null);

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


static bool IsModule(ClassDeclarationSyntax class_node)
{
    return class_node.AttributeLists
        .SelectMany(a => a.Attributes)
        .Any(a => a.Name.ToString().Contains("Module"));
}


static void BuildClass(
        ClassDeclarationSyntax class_declaration,
        SemanticModel semantic_model,
        StringBuilder sb,
        string[] class_path,
        string[]? last_module)
{
    using (CodeBlock.Class(class_declaration, sb))
    {
        if (IsModule(class_declaration))
        {
            last_module = class_path;

            var py_last_module_path = string.Join('.', last_module.Select(p => p.TrimStart('@')));
            sb.AppendLine("private static Lazy<PyObject> _lazy_self;");
            sb.AppendLine("public static PyObject self { get => _lazy_self.Value; }");

            sb.AppendLine("""
            private static void ReInitializeLazySelf()
            {
                _lazy_self = new Lazy<PyObject>(() =>
                {
                    try { return InstallAndImport(); }
                    catch (Exception) { return InstallAndImport(true); }
                });
            }
            """);

            sb.AppendLine("private static PyObject InstallAndImport(bool force = false){");
            sb.AppendLine("PythonEngine.AddShutdownHandler(ReInitializeLazySelf);");
            sb.AppendLine("PythonEngine.Initialize();");
            sb.AppendLine($"return Py.Import(\"{py_last_module_path}\");}}");

            sb.AppendLine($"static {class_declaration.Identifier.Text}() {{ ReInitializeLazySelf(); }}");
        }

        // Constructor
        var constructor_nodes = class_declaration
            .Members
            .OfType<ConstructorDeclarationSyntax>();

        foreach (var constructor_node in constructor_nodes)
            BuildConstructor(constructor_node, semantic_model, sb, last_module);

        // Properties
        var property_nodes = class_declaration
            .Members
            .OfType<PropertyDeclarationSyntax>();

        foreach (var property_node in property_nodes)
            BuildProperty(property_node, semantic_model, sb);

        // Methods
        var method_nodes = class_declaration
            .Members
            .OfType<MethodDeclarationSyntax>();

        foreach (var method_node in method_nodes.Where(m => m.Modifiers.Any(m => m.Text.Contains("static"))))
        {
            if (last_module != null)
                AnalizeStaticMethodNode(method_node, semantic_model, sb, last_module);
            else
                Console.WriteLine($"Error {method_node.Identifier.Text} static methods");
        }

        foreach (var method_node in method_nodes.Where(m => !m.Modifiers.Any(m => m.Text.Contains("static"))))
            AnalizeMethodNode(method_node, semantic_model, sb);

        var class_nodes = class_declaration
            .Members
            .OfType<ClassDeclarationSyntax>();

        foreach (var item in class_nodes)
            BuildClass(item, semantic_model, sb, [.. class_path, item.Identifier.Text], last_module);
    }
}


static void BuildArgsTuple(BaseMethodDeclarationSyntax method_node, StringBuilder sb)
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

static string PyObjectToCSharp(ITypeSymbol type, string py_object)
{
    if (type.SpecialType == SpecialType.System_Boolean)
        return $"{py_object}.As<bool>()";
    else if (type.SpecialType == SpecialType.System_Int32)
        return $"{py_object}.As<int>()";
    else if (type.SpecialType == SpecialType.System_Single)
        return $"{py_object}.As<float>()";
    else if (type.SpecialType == SpecialType.System_Double)
        return $"{py_object}.As<double>()";
    else if (type.SpecialType == SpecialType.System_String)
        return $"{py_object}.As<string>()";
    else
    {
        return "new NotImplementedException();";
    }
}

static void BuildConstructor(
    ConstructorDeclarationSyntax constructor_node,
    SemanticModel semantic_model,
    StringBuilder sb,
    string[]? last_module_path)
{
    string method_name = constructor_node.Identifier.Text;
    string py_method_name = constructor_node.Identifier.Text.TrimStart('@');

    if (last_module_path == null)
    {
        Console.WriteLine($"[Error] Constructor : {method_name}");
        return;
    }

    string module_class = string.Join('.', last_module_path);

    using (CodeBlock.Constructor(constructor_node, sb))
    {
        sb.AppendLine($"_ = {module_class}.self;");
        BuildArgsTuple(constructor_node, sb);
        BuildPyDict(constructor_node, sb);
        sb.AppendLine($"self = {module_class}.self.InvokeMethod(\"{py_method_name}\", args, pyDict);");
    }

    using (CodeBlock.InternalConstructor(constructor_node, sb))
    {
        sb.AppendLine($"_ = {module_class}.self;");
        sb.AppendLine("self = pyObject;");
    }

    sb.AppendLine("[Obsolete(\"Encapsule is deprecated. Please use Wrap for future implementations.\")]");
    sb.AppendLine($"public static {method_name} Encapsule(PyObject pyObject) => new {method_name}(pyObject);");
    sb.AppendLine($"public static {method_name} Wrap(PyObject pyObject) => new {method_name}(pyObject);");
}

static void BuildProperty(
    PropertyDeclarationSyntax prop_node,
    SemanticModel semantic_model,
    StringBuilder sb)
{
    string py_property_name = prop_node.Identifier.Text.TrimStart('@');
    string py_object = $"self.GetAttr(\"{py_property_name}\")";
    var type = semantic_model.GetDeclaredSymbol(prop_node)?.Type;

    if (type == null)
    {
        Console.WriteLine($"[ERROR] Failed to create property {py_property_name}");
        return;
    }

    sb.Append($"{prop_node.Modifiers} {prop_node.Type} {prop_node.Identifier} => ");
    sb.AppendLine(PyObjectToCSharp(type, py_object));
}

static void AnalizeMethodNode(
    MethodDeclarationSyntax method_node,
    SemanticModel semantic_model,
    StringBuilder sb)
{
    bool return_this = method_node.AttributeLists
        .SelectMany(a => a.Attributes)
        .Any(a => a.Name.ToString().Contains("ReturnThis"));

    string py_method_name = method_node.Identifier.Text.TrimStart('@');
    string invoke_method = $"self.InvokeMethod(\"{py_method_name}\", args, pyDict)";
    var type = semantic_model.GetDeclaredSymbol(method_node)?.ReturnType;

    using (CodeBlock.Method(method_node, sb))
    {
        BuildArgsTuple(method_node, sb);
        BuildPyDict(method_node, sb);

        if (return_this)
        {
            sb.AppendLine($"{invoke_method};");
            sb.AppendLine("return this;");
        }
        else if (type == null || type.SpecialType == SpecialType.System_Boolean)
        {
            sb.AppendLine($"{invoke_method};");
        }
        else
        {
            sb.AppendLine($"return {PyObjectToCSharp(type, invoke_method)}");
        }
    }
}

static void AnalizeStaticMethodNode(
    MethodDeclarationSyntax method_node,
    SemanticModel semantic_model,
    StringBuilder sb,
    string[] last_module_path)
{
    string py_method_name = method_node.Identifier.Text.TrimStart('@');
    string invoke_method = $"self.InvokeMethod(\"{py_method_name}\", args, pyDict)";
    var type = semantic_model.GetDeclaredSymbol(method_node)?.ReturnType;

    using (CodeBlock.Method(method_node, sb))
    {
        // Initialize
        string module = string.Join('.', last_module_path);
        sb.AppendLine($"_ = {module}.self;");

        BuildArgsTuple(method_node, sb);
        BuildPyDict(method_node, sb);

        if (type == null || type.SpecialType == SpecialType.System_Boolean)
        {
            sb.AppendLine($"{invoke_method};");
        }
        else
        {
            sb.AppendLine($"return {PyObjectToCSharp(type, invoke_method)}");
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

    public static CodeBlock Method(MethodDeclarationSyntax method_node, StringBuilder sb)
    {
        sb.Append($"{method_node.Modifiers} {method_node.ReturnType} {method_node.Identifier}(");
        sb.AppendJoin(',', method_node.ParameterList.Parameters);
        sb.AppendLine(")");
        return new CodeBlock(sb);
    }

    public static CodeBlock Constructor(ConstructorDeclarationSyntax constructor_node, StringBuilder sb)
    {
        sb.Append($"{constructor_node.Modifiers} {constructor_node.Identifier}(");
        sb.AppendJoin(',', constructor_node.ParameterList.Parameters);
        sb.AppendLine(")");
        return new CodeBlock(sb);
    }

    public static CodeBlock InternalConstructor(ConstructorDeclarationSyntax constructor_node, StringBuilder sb)
    {
        sb.Append($"internal {constructor_node.Identifier}(PyObject pyObject)");
        return new CodeBlock(sb);
    }

    public static CodeBlock Class(ClassDeclarationSyntax class_node, StringBuilder sb)
    {
        sb.Append($"{class_node.Modifiers} class {class_node.Identifier}");
        if (class_node.BaseList != null && class_node.BaseList.Types.Count > 0)
        {
            sb.Append(':');
            sb.AppendJoin(',', class_node.BaseList.Types);
        }
        return new CodeBlock(sb);
    }

    public void Dispose()
    {
        stringBuilder.AppendLine("}");
    }
}