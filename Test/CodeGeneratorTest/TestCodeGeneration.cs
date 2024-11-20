using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using CodeGenerator.Core.Manager;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CSharp;
using System.Text.Json;
using System.Linq;
using CodeGenerator.Core;

namespace CodeGeneratorTest
{


    public class TestCodeGeneration
    {
        [Fact]
        public void Entry()
        {
            Generator.CreateGenerated();
        }


        public static void AddMethod(ref ClassDeclarationSyntax @class, string name)
        {
            var method = SyntaxFactory.MethodDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .WithBody(SyntaxFactory.Block());

            @class = @class.AddMembers(method);
        }

        [Fact]
        public void ValidateNamespacesInPreGeneratedFiles()
        {
            var preGeneratedPath = Path.Combine(Path.GetFullPath("."), "PreGenerated");
            var preGeneratedFiles = Directory.GetFiles(preGeneratedPath, "*.json");

            foreach (var filePath in preGeneratedFiles)
            {
                var jsonContent = File.ReadAllText(filePath);
                var dummyContainers = JsonSerializer.Deserialize<List<NodeContainer>>(jsonContent);

                if (dummyContainers == null)
                    continue;

                var sortedDummyContainers = dummyContainers.OrderBy(dummy =>
                {
                    var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(dummy.Declaration);
                    var nameSegments = fullName.Split('.');
                    var namespaceOnly = string.Join(".", nameSegments[..^1]);
                    return namespaceOnly;
                });

                Console.WriteLine($">> {filePath}");

                foreach (var dummy in sortedDummyContainers)
                {
                    var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(dummy.Declaration);

                    var nameSegments = fullName.Split('.');
                    var namespaceOnly = string.Join(".", nameSegments[..^1]);

                    Console.WriteLine(namespaceOnly);
                }
            }
        }

        [Fact]
        public void ValidateUniqueNamespacesInPreGeneratedFiles()
        {
            var preGeneratedPath = Path.Combine(Path.GetFullPath("."), "PreGenerated");
            var preGeneratedFiles = Directory.GetFiles(preGeneratedPath, "*.json");

            foreach (var filePath in preGeneratedFiles)
            {
                var jsonContent = File.ReadAllText(filePath);
                var dummyContainers = JsonSerializer.Deserialize<List<NodeContainer>>(jsonContent);

                if (dummyContainers == null)
                    continue;

                var sortedDummyContainers = dummyContainers.OrderBy(dummy =>
                {
                    var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(dummy.Declaration);
                    var nameSegments = fullName.Split('.');
                    var namespaceOnly = string.Join(".", nameSegments[..^1]);
                    return namespaceOnly;
                });

                var uniqueStaticClasses = sortedDummyContainers
                    .Select(dummy =>
                    {
                        var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(dummy.Declaration);
                        var namespaceParts = fullName.Split('.');
                        return string.Join(".", namespaceParts[..^1]);
                    })
                    .Distinct();

                Console.WriteLine($">> {filePath}");

                foreach (var uniqueNamespace in uniqueStaticClasses)
                {
                    Console.WriteLine(uniqueNamespace);
                }
            }
        }

        [Fact]
        public void DOM()
        {
            UsingDirectiveSyntax[] usings =
            [
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("Numpy")),
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("Python.Runtime")),
            ];

            string text = "class1.class2.Class";
            string[] levels = text.Split('.');

            var namespaceDeclaration = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName("ScikitLearn"))
            .NormalizeWhitespace();

            var innerMostClass = SyntaxFactory.ClassDeclaration(levels[^1]).AddModifiers(
                SyntaxFactory.Token(SyntaxKind.PublicKeyword));

            AddMethod(ref innerMostClass, "m1");
            AddMethod(ref innerMostClass, "m2");
            AddMethod(ref innerMostClass, "m3");
            AddMethod(ref innerMostClass, "m4");


            // Crear la jerarquía de clases de manera anidada desde el interior hacia el exterior
            ClassDeclarationSyntax currentClass = innerMostClass;
            for (int i = levels.Length - 2; i >= 0; i--)
            {
                var outerClass = SyntaxFactory.ClassDeclaration(levels[i]).AddModifiers(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.StaticKeyword));

                // Agregar la clase actual como miembro de la clase exterior
                outerClass = outerClass.AddMembers(currentClass);

                // Actualizar la referencia para la próxima iteración
                currentClass = outerClass;
            }

            // Añadir la clase raíz completa al namespace
            namespaceDeclaration = namespaceDeclaration.AddMembers(currentClass);

            // Compilation unit
            var compilationUnit = SyntaxFactory.CompilationUnit()
                .AddUsings(usings)
                .AddMembers(namespaceDeclaration)
                .NormalizeWhitespace();

            // Generar el código
            var code = compilationUnit.ToFullString();
            Console.WriteLine(code);
        }
    }
}
