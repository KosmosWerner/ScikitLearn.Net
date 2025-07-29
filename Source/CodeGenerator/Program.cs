using CodeGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System.Text;

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

static void WriteArgs(BaseMethodDeclarationSyntax method_node, StringBuilder sb)
{
    var params_without_default = method_node.ParameterList.Parameters
        .Where(p => p.Default == null)
        .ToList();

    sb.Append("PyTuple args = new PyTuple(new PyObject[] {");
    sb.AppendJoin(',', params_without_default.Select(p => $"Helpers.ToPython({p.Identifier.Text})"));
    sb.AppendLine("});");
}

static void WritePyDict(BaseMethodDeclarationSyntax method_node, StringBuilder sb)
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
        WriteArgs(constructorNode, sb);
        WritePyDict(constructorNode, sb);
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
    var type = semanticModel.GetDeclaredSymbol(propertyNode)?.Type;

    if (type == null || type.SpecialType == SpecialType.System_Void)
    {
        Console.WriteLine($"Error: Failed to generate property '{pyPropertyName}': no associated return type.");
        return;
    }

    using (CodeBlock.BeginProperty(propertyNode, sb))
    {
        using (CodeBlock.BeginGet(sb))
        {
            string pyObject = "__pyObject";
            sb.AppendLine($"var {pyObject} = self.GetAttr(\"{pyPropertyName}\");");
            WriteNormalReturn(pyObject, type, sb);
        }
    }
}

static void WriteInstanceMethod(
    MethodDeclarationSyntax methodNode,
    SemanticModel semanticModel,
    StringBuilder sb)
{
    bool returnThis = methodNode.AttributeLists
        .SelectMany(a => a.Attributes)
        .Any(a => a.Name.ToString().Contains("ReturnThis"));

    bool isVariant = methodNode.AttributeLists
        .SelectMany(a => a.Attributes)
        .Any(a => a.Name.ToString().Contains("TupleVariantSelector"));

    string? conditional = null;
    if (isVariant)
    {
        var attribute = methodNode.AttributeLists
        .SelectMany(list => list.Attributes)
        .FirstOrDefault(attr => attr.Name.ToString().Contains("TupleVariantSelector"));
        if (attribute?.ArgumentList is not null)
        {
            var conditionArg = attribute.ArgumentList.Arguments
        .FirstOrDefault(arg => arg.NameEquals?.Name.Identifier.Text == "Condition");

            if (conditionArg?.Expression is LiteralExpressionSyntax literal)
            {
                conditional = literal.Token.ValueText;
            }
        }
    }

    using (CodeBlock.BeginMethod(methodNode, sb))
    {
        WriteArgs(methodNode, sb);
        WritePyDict(methodNode, sb);
        string pyMethod = methodNode.Identifier.Text.TrimStart('@');

        if (returnThis)
        {
            sb.AppendLine($"self.InvokeMethod(\"{pyMethod}\", args, pyDict);");
            sb.AppendLine("return this;");
        }
        else
        {
            WriteMethodReturn(methodNode, semanticModel, sb, conditional, pyMethod);
        }
    }
}

static void WriteStaticMethod(
    MethodDeclarationSyntax methodNode,
    SemanticModel semanticModel,
    StringBuilder sb,
    string[] lastModulePath)
{
    bool isVariant = methodNode.AttributeLists
        .SelectMany(a => a.Attributes)
        .Any(a => a.Name.ToString().Contains("TupleVariantSelector"));

    string? conditional = null;

    if (isVariant)
    {
        var attribute = methodNode.AttributeLists
        .SelectMany(list => list.Attributes)
        .FirstOrDefault(attr => attr.Name.ToString().Contains("TupleVariantSelector"));
        if (attribute?.ArgumentList is not null)
        {
            var conditionArg = attribute.ArgumentList.Arguments
        .FirstOrDefault(arg => arg.NameEquals?.Name.Identifier.Text == "Condition");

            if (conditionArg?.Expression is LiteralExpressionSyntax literal)
            {
                conditional = literal.Token.ValueText;
            }
        }
    }
    using (CodeBlock.BeginMethod(methodNode, sb))
    {
        string module = string.Join('.', lastModulePath);
        sb.AppendLine($"_ = {module}.self;");

        WriteArgs(methodNode, sb);
        WritePyDict(methodNode, sb);
        string pyMethod = methodNode.Identifier.Text.TrimStart('@');

        WriteMethodReturn(methodNode, semanticModel, sb, conditional, pyMethod);
    }
}


static bool IsNullable(ITypeSymbol type)
{
    if (type is INamedTypeSymbol named && named.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T)
        return true;

    if (type.NullableAnnotation == NullableAnnotation.Annotated)
        return true;

    return false;
}

static ITypeSymbol UnwrapNullable(ITypeSymbol type)
{
    if (type is INamedTypeSymbol named && named.OriginalDefinition.SpecialType == SpecialType.System_Nullable_T)
        return named.TypeArguments[0];

    if (type.NullableAnnotation == NullableAnnotation.Annotated)
        return type.WithNullableAnnotation(NullableAnnotation.None);

    return type;
}

static bool InheritsFrom(INamedTypeSymbol type, string baseTypeFullName)
{
    var current = type.BaseType;
    while (current != null)
    {
        if (current.ToDisplayString() == baseTypeFullName) return true;
        current = current.BaseType;
    }
    return false;
}

static string? PyObjectToCsharp(ITypeSymbol type, string pyObject, StringBuilder sb, int level = 0)
{
    switch (type.SpecialType)
    {
        case SpecialType.System_Boolean: return $"{pyObject}.As<bool>()";
        case SpecialType.System_Int32: return $"{pyObject}.As<int>()";
        case SpecialType.System_Single: return $"{pyObject}.As<float>()";
        case SpecialType.System_Double: return $"{pyObject}.As<double>()";
        case SpecialType.System_String: return $"{pyObject}.As<string>()";
    }

    if (type.TypeKind == TypeKind.Class && type is INamedTypeSymbol namedType)
    {
        string fullName = namedType.ToDisplayString();

        switch (fullName)
        {
            case "Python.Runtime.PyObject": return pyObject;
            case "Python.Runtime.PyDict": return ($"new PyDict({pyObject})");
            case "Python.Runtime.PyTuple": return ($"new PyTuple({pyObject})");
            case "Numpy.NDarray": return ($"new NDarray({pyObject})");
        }

        if (namedType.Name == "NDarray" && namedType.TypeArguments.Length == 1)
        {
            string genericArg = namedType.TypeArguments[0].ToDisplayString();
            return $"new NDarray<{genericArg}>({pyObject})";
        }

        if (InheritsFrom(namedType, "Numpy.PythonObject") &&
            namedType.ContainingNamespace.ToDisplayString().StartsWith("ScikitLearn"))
        {
            return $"{fullName}.Wrap({pyObject})";
        }
    }

    if (type is INamedTypeSymbol tupleType && tupleType.IsTupleType)
    {
        var subTuple = $"{pyObject}Tuple";
        var subTupleLength = $"{pyObject}Length";
        bool nullable = false;
        sb.AppendLine($"var {subTuple} = new PyTuple({pyObject});");
        sb.AppendLine($"var {subTupleLength} = {subTuple}.Length();");

        StringBuilder sb2 = new("(");
        for (int i = 0; i < tupleType.TupleElements.Length; i++)
        {
            if (IsNullable(tupleType.TupleElements[i].Type)) nullable = true;
            var subType = UnwrapNullable(tupleType.TupleElements[i].Type);

            string? result = PyObjectToCsharp(subType, $"{subTuple}[{i}]", sb, level + 1);

            if (i > 0) sb2.Append(",");
            if (nullable)
            {

                sb2.Append($"{subTupleLength} > {i} ? {result}:null");
            }
            else
            {
                sb2.Append($"{result}");
            }
        }
        sb2.Append(")");
        return sb2.ToString();
    }

    return null;
}



static void WriteVariantReturn(string pyObject, string condition, ITypeSymbol typeA, ITypeSymbol typeB, StringBuilder sb)
{
    sb.AppendLine($"if({condition}){{");

    string? returnValueA = PyObjectToCsharp(typeA, pyObject, sb);
    if (returnValueA is not null)
    {
        sb.AppendLine($"return ({returnValueA}, null);");
    }
    else
    {
        sb.AppendLine("throw new NotImplementedException();");
        Console.WriteLine($"Failed to convert {typeA.ToDisplayString()}");
    }

    sb.AppendLine("}else{");

    string? returnValueB = PyObjectToCsharp(typeB, pyObject, sb);
    if (returnValueB is not null)
    {
        sb.AppendLine($"return (null, {returnValueB});");
    }
    else
    {
        sb.AppendLine("throw new NotImplementedException();");
        Console.WriteLine($"Failed to convert {typeB.ToDisplayString()}");
    }

    sb.AppendLine("}");
}

static void WriteNormalReturn(string pyObject, ITypeSymbol type, StringBuilder sb)
{
    if (!IsNullable(type))
    {
        string? return_value = PyObjectToCsharp(type, pyObject, sb);

        if (return_value is not null)
        {
            sb.AppendLine($"return {return_value};");
            return;
        }
        sb.AppendLine("throw new NotImplementedException();");
        Console.WriteLine($"Failed to convert {type.ToDisplayString()}");
    }
    else
    {
        var _type = UnwrapNullable(type);
        string? return_value = PyObjectToCsharp(_type, pyObject, sb);

        if (return_value is not null)
        {
            sb.AppendLine($"return {pyObject} == Runtime.None ? null : {return_value};");
            return;
        }
        sb.AppendLine("throw new NotImplementedException();");
        Console.WriteLine($"Failed to convert {type.ToDisplayString()}");
    }

}


static void WriteMethodReturn(MethodDeclarationSyntax methodNode, SemanticModel semanticModel, StringBuilder sb, string? variantCondition, string pyMethod)
{
    var type = semanticModel.GetDeclaredSymbol(methodNode)?.ReturnType;

    if (type == null || type.SpecialType == SpecialType.System_Void)
    {
        sb.AppendLine($"self.InvokeMethod(\"{pyMethod}\", args, pyDict);");
        return;
    }

    if (variantCondition is not null)
    {
        if (type is INamedTypeSymbol tupleType && tupleType.IsTupleType && tupleType.TupleElements.Length == 2)
        {
            string pyObject = "__pyVariant";
            sb.AppendLine($"var {pyObject} = self.InvokeMethod(\"{pyMethod}\", args, pyDict);");

            var typeA = UnwrapNullable(tupleType.TupleElements[0].Type);
            var typeB = UnwrapNullable(tupleType.TupleElements[1].Type);

            WriteVariantReturn(pyObject, variantCondition, typeA, typeB, sb);
        }
        else
        {
            Console.WriteLine("Error al crear el metodo ya que el atributo no fue aplicado a una tupla");
        }
    }
    else
    {
        string pyObject = "__pyObject";
        sb.AppendLine($"var {pyObject} = self.InvokeMethod(\"{pyMethod}\", args, pyDict);");

        WriteNormalReturn(pyObject, type, sb);
    }
}