using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;

namespace CodeGenerator;

internal class Program
{
    static void Main(string[] args)
    {
        string solution_folder = Helpers.TryGetSolutionPath() ?? string.Empty;

        string source_folder = Path.Combine(solution_folder, "Source", "ScikitLearn.Signatures");
        string output_folder = Path.Combine(solution_folder, "Source", "ScikitLearn");

        var paths = Directory.GetFiles(source_folder, "*.cs", SearchOption.TopDirectoryOnly);

        Parallel.ForEach(paths, new ParallelOptions() { MaxDegreeOfParallelism = 10 }, path =>
        {
            string source_code = File.ReadAllText(path);
            var parseOptions = new CSharpParseOptions(LanguageVersion.CSharp13);
            SyntaxTree tree = CSharpSyntaxTree.ParseText(source_code, parseOptions);
            SyntaxNode root = tree.GetRoot();

            var namespace_node = root
                .DescendantNodes()
                .OfType<BaseNamespaceDeclarationSyntax>()
                .FirstOrDefault();

            if (namespace_node == null)
            {
                Console.WriteLine($"Error: {path}");
                return;
            }

            StringBuilder sb = new();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using Numpy;");
            sb.AppendLine("using Python.Runtime;");
            sb.AppendLine($"namespace {namespace_node.Name}");
            sb.AppendLine("{");

            var class_nodes = namespace_node
                .Members
                .OfType<ClassDeclarationSyntax>();

            foreach (var class_node in class_nodes)
                AnalizeClassNode(class_node, sb);

            sb.AppendLine("}");

            SyntaxTree output_tree = CSharpSyntaxTree.ParseText(sb.ToString());
            SyntaxNode output_root = output_tree.GetRoot();
            string output_formatted = output_root.NormalizeWhitespace().ToFullString();

            string output_path = Path.Combine(output_folder, $"{Path.GetFileNameWithoutExtension(path)}.generated.cs");
            File.WriteAllText(output_path, output_formatted);
        });
    }

    private static void AnalizeClassNode(
        ClassDeclarationSyntax class_node,
        StringBuilder sb)
    {
        sb.Append($"{class_node.Modifiers} class {class_node.Identifier}");
        sb.AppendLine("{");


        var constructor_nodes = class_node
            .Members
            .OfType<ConstructorDeclarationSyntax>();

        foreach (var constructor_node in constructor_nodes)
            AnalizeConstructorNode(constructor_node, sb, class_node.Identifier.Text);


        var property_nodes = class_node
            .Members
            .OfType<PropertyDeclarationSyntax>();

        foreach (var property_node in property_nodes)
            AnalizePropertyNode(property_node, sb);


        var method_nodes = class_node
            .Members
            .OfType<MethodDeclarationSyntax>();

        foreach (var method_node in method_nodes)
            AnalizeMethodNode(method_node, sb);


        var class_nodes = class_node
            .Members
            .OfType<ClassDeclarationSyntax>();

        foreach (var item in class_nodes)
            AnalizeClassNode(item, sb);

        sb.AppendLine("}");
    }

    private static void AnalizeConstructorNode(
        ConstructorDeclarationSyntax constructor_node,
        StringBuilder sb,
        string name)
    {
        sb.AppendLine($"{constructor_node.Modifiers} {constructor_node.Identifier}(");
        sb.AppendJoin(',', constructor_node.ParameterList.Parameters);
        sb.AppendLine(")");

        sb.AppendLine("{");

        foreach (var parameter in constructor_node.ParameterList.Parameters)
        {
            
        }

        sb.AppendLine("}");
    }

    private static void AnalizePropertyNode(
        PropertyDeclarationSyntax property_node,
        StringBuilder sb)
    {
        sb.Append($"{property_node.Modifiers} {property_node.Type} {property_node.Identifier} =>");

        string py_identifier = property_node.Identifier.ToString().TrimStart('@');
        string py_object = $"self.GetAttr(\"{py_identifier}\")";

        sb.AppendLine($"Helpers.ToCSharpNDarray({py_object});");

    }

    private static void AnalizeMethodNode(
        MethodDeclarationSyntax method_node,
        StringBuilder sb)
    {
        sb.AppendLine($"{method_node.Modifiers} {method_node.ReturnType} {method_node.Identifier}(");
        sb.AppendJoin(',', method_node.ParameterList.Parameters);
        sb.AppendLine(")");

        sb.AppendLine("{");

        // codigo
        sb.AppendLine("throw new NotImplementedException();");

        sb.AppendLine("}");
    }
}