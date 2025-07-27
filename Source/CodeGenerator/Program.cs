using System.Text;
using CodeGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;

string solution_folder = Helpers.TryGetSolutionPath() ?? string.Empty;

string source_folder = Path.Combine(solution_folder, "Source", "ScikitLearn.Signatures");

string source_project = Path.Combine(source_folder, "ScikitLearn.Signatures.csproj");
string output_project = Path.Combine(source_folder, "ScikitLearn.csproj");

var workspace = MSBuildWorkspace.Create();
var proyecto = await workspace.OpenProjectAsync(source_project);

await Parallel.ForEachAsync(
    proyecto.Documents.Where(d => d.Name.StartsWith("sklearn")),
    static async (document, token) =>
{
    string file_name = Path.GetFileNameWithoutExtension(document.Name);

    SyntaxTree? tree = await document.GetSyntaxTreeAsync(token);
    if (tree is null) return;

    SyntaxNode root = await tree.GetRootAsync(token);
    SemanticModel? semantic_model = await document.GetSemanticModelAsync(token);
    if (semantic_model is null) return;

    // Code Analisys
    var namespace_node = root
        .DescendantNodes()
        .OfType<BaseNamespaceDeclarationSyntax>()
        .FirstOrDefault();

    if (namespace_node == null)
    {
        Console.WriteLine($"Error: {file_name}");
        return;
    }

    StringBuilder sb = new("namespace ScikitLearn;");

    var class_nodes = namespace_node
        .Members
        .OfType<ClassDeclarationSyntax>();

    foreach (var class_node in class_nodes)
        AnalizeClassNode(class_node, semantic_model, sb, [], null);

    // Paths
    string solution_folder = Helpers.TryGetSolutionPath() ?? string.Empty;
    string output_folder = Path.Combine(solution_folder, "Source", "ScikitLearn");
    string output_file = Path.Combine(output_folder, $"{file_name}.g.cs");

    // Code formatting

    SyntaxTree output_tree = CSharpSyntaxTree.ParseText(sb.ToString(), cancellationToken: token);
    SyntaxNode output_root = output_tree.GetRoot(token);
    string output_formatted = output_root.NormalizeWhitespace().ToFullString();

    // Write file

    File.WriteAllText(output_file, output_formatted);
});

static void AnalizeClassNode(
        ClassDeclarationSyntax class_node,
        SemanticModel semantic_model,
        StringBuilder sb,
        string[] root,
        string[]? last_module_path)
{
    root = [.. root, class_node.Identifier.Text];
    bool is_module = class_node.AttributeLists
        .SelectMany(a => a.Attributes)
        .Any(a => a.Name.ToString().Contains("Module"));

    if (is_module) last_module_path = root;


    using (CodeBlock.Class(class_node, sb))
    {
        if (is_module)
        {
            var py_last_module_path = string.Join('.', last_module_path.Select(p => p.TrimStart('@')));
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

            sb.AppendLine($"static {class_node.Identifier.Text}() {{ ReInitializeLazySelf(); }}");
        }

        // Constructor
        var constructor_nodes = class_node
            .Members
            .OfType<ConstructorDeclarationSyntax>();

        foreach (var constructor_node in constructor_nodes)
            BuildConstructor(constructor_node, semantic_model, sb, last_module_path);

        // Properties
        var property_nodes = class_node
            .Members
            .OfType<PropertyDeclarationSyntax>();

        foreach (var property_node in property_nodes)
            BuildProperty(property_node, semantic_model, sb);

        // Methods
        var method_nodes = class_node
            .Members
            .OfType<MethodDeclarationSyntax>();

        foreach (var method_node in method_nodes.Where(m => m.Modifiers.Any(m => m.Text.Contains("static"))))
        {
            if (last_module_path != null)
                AnalizeStaticMethodNode(method_node, semantic_model, sb, last_module_path);
            else
                Console.WriteLine($"Error {method_node.Identifier.Text} static methods");
        }

        foreach (var method_node in method_nodes.Where(m => !m.Modifiers.Any(m => m.Text.Contains("static"))))
            AnalizeMethodNode(method_node, semantic_model, sb);

        var class_nodes = class_node
            .Members
            .OfType<ClassDeclarationSyntax>();

        foreach (var item in class_nodes)
            AnalizeClassNode(item, semantic_model, sb, root, last_module_path);
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

static void BuildReturn(ITypeSymbol? type, string invoke_method, StringBuilder sb)
{
    if (type != null)
    {
        if (type.SpecialType == SpecialType.System_Void)
        {
            sb.AppendLine($"{invoke_method};");
        }
        else if (type.SpecialType == SpecialType.System_Boolean)
        {
            sb.AppendLine($"return {invoke_method}.As<bool>();");
        }
        else if (type.SpecialType == SpecialType.System_Int32)
        {
            sb.AppendLine($"return {invoke_method}.As<int>();");
        }
        else if (type.SpecialType == SpecialType.System_Single)
        {
            sb.AppendLine($"return {invoke_method}.As<float>();");
        }
        else if (type.SpecialType == SpecialType.System_Double)
        {
            sb.AppendLine($"return {invoke_method}.As<double>();");
        }
        else if (type.SpecialType == SpecialType.System_String)
        {
            sb.AppendLine($"return {invoke_method}.As<string>();");
        }
        else
        {

            sb.AppendLine("throw new NotImplementedException();");
        }
    }
    else
    {
        sb.AppendLine($"{invoke_method};");
        return;
    }
}



static void BuildConstructor(
    ConstructorDeclarationSyntax constructor_node,
    SemanticModel semantic_model,
    StringBuilder sb,
    string[]? last_module_path)
{
    if (last_module_path == null)
    {
        Console.WriteLine($"[Error] Constructor : {constructor_node.Identifier.Text}");
        return;
    }

    string method_name = constructor_node.Identifier.Text;
    string py_method_name = constructor_node.Identifier.Text.TrimStart('@');
    string module = string.Join('.', last_module_path);

    using (CodeBlock.Constructor(constructor_node, sb))
    {
        sb.AppendLine($"_ = {module}.self;");

        BuildArgsTuple(constructor_node, sb);
        BuildPyDict(constructor_node, sb);

        sb.AppendLine($"self = {module}.self.InvokeMethod(\"{py_method_name}\", args, pyDict);");
    }

    using (CodeBlock.InternalConstructor(constructor_node, sb))
    {
        sb.AppendLine($"_ = {module}.self;");
        sb.AppendLine("self = pyObject;");
    }

    sb.AppendLine($"public static {method_name} Encapsule(PyObject pyObject) => new {method_name}(pyObject);");
}

static void BuildProperty(
    PropertyDeclarationSyntax property_node,
    SemanticModel semantic_model,
    StringBuilder sb)
{
    using (CodeBlock.Property(property_node, sb))
    {
        string py_parameter_name = property_node.Identifier.ToString().TrimStart('@');
        string invoke_method = $"self.GetAttr(\"{py_parameter_name}\")";
        sb.AppendLine("get{");

        var type = semantic_model.GetDeclaredSymbol(property_node)?.Type;
        BuildReturn(type, invoke_method, sb);
        sb.AppendLine("}");

    }
}

static void AnalizeMethodNode(
    MethodDeclarationSyntax method_node,
    SemanticModel semantic_model,
    StringBuilder sb)
{
    using (CodeBlock.Method(method_node, sb))
    {
        BuildArgsTuple(method_node, sb);
        BuildPyDict(method_node, sb);

        string py_method_name = method_node.Identifier.Text.TrimStart('@');
        string invoke_method = $"self.InvokeMethod(\"{py_method_name}\", args, pyDict)";

        var type = semantic_model.GetDeclaredSymbol(method_node)?.ReturnType;
        BuildReturn(type, invoke_method, sb);
    }
}

static void AnalizeStaticMethodNode(
    MethodDeclarationSyntax method_node,
    SemanticModel semantic_model,
    StringBuilder sb,
    string[] last_module_path)
{
    using (CodeBlock.Method(method_node, sb))
    {
        // Initialize
        string module = string.Join('.', last_module_path);
        sb.AppendLine($"_ = {module}.self;");

        BuildArgsTuple(method_node, sb);
        BuildPyDict(method_node, sb);

        // Return
        string real_method_name = method_node.Identifier.Text.TrimStart('@');
        string invoke_method = $"self.InvokeMethod(\"{real_method_name}\", args, pyDict)";

        var type = semantic_model.GetDeclaredSymbol(method_node)?.ReturnType;
        BuildReturn(type, invoke_method, sb);
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

    public static CodeBlock Property(PropertyDeclarationSyntax property_node, StringBuilder sb)
    {
        sb.Append($"{property_node.Modifiers} {property_node.Type} {property_node.Identifier}");
        return new CodeBlock(sb);
    }

    public void Dispose()
    {
        stringBuilder.AppendLine("}");
    }
}