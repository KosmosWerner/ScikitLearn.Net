using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Xml.Linq;

namespace CodeGenerator.Core.Manager
{
    public static class CodeBuilder
    {
        public static void Build(string outputDirectory, string fileName, IOrderedEnumerable<DummyContainer> sortedDummyContainers)
        {
            string filePath = Path.Combine(outputDirectory, $"{fileName}.cs");

            var uniqueStaticClasses = sortedDummyContainers
                .Select(dummy =>
                {
                    var (_, fullName, _) = RegexAnalyzer.Divide.Declaration(dummy.Declaration);
                    var namespaceParts = fullName.Split('.');
                    return string.Join(".", namespaceParts[..^1]);
                })
                .Distinct();

            UsingDirectiveSyntax[] usings =
            [
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("Numpy")),
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("Python.Runtime")),
            ];

            var ScikitLearn = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName("ScikitLearn"));

            var sklearn = SyntaxFactory.ClassDeclaration("sklearn").AddModifiers(
                SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.StaticKeyword),
                SyntaxFactory.Token(SyntaxKind.PartialKeyword));

            foreach (DummyContainer dummyContainer in sortedDummyContainers)
            {
                switch (dummyContainer.EntityType)
                {
                    case EntityType.Class:
                        BuildClass(ref sklearn, dummyContainer);
                        break;
                    case EntityType.Method:
                        BuildStaticMethod(ref sklearn, dummyContainer);
                        break;
                    case EntityType.Exception:
                        BuildException(ref sklearn, dummyContainer);
                        break;
                    case EntityType.None:
                    default: break;
                }
            }

            ScikitLearn = ScikitLearn.AddMembers(sklearn);

            var compilationUnit = SyntaxFactory.CompilationUnit()
                .AddUsings(usings)
                .AddMembers(ScikitLearn)
                .NormalizeWhitespace();

            var code = compilationUnit.ToFullString();

            Directory.CreateDirectory(outputDirectory);
            File.WriteAllText(filePath, code);
        }



        private static void BuildClass(ref ClassDeclarationSyntax currentStaticClass, DummyContainer dummy)
        {
            var (_, plainName, plainParameters) = RegexAnalyzer.Divide.Declaration(dummy.Declaration);
            string className = plainName.Split('.')[^1];

            var classNode = SyntaxFactory.ClassDeclaration(className).AddModifiers(
                SyntaxFactory.Token(SyntaxKind.PublicKeyword));

            BuildConstructor(ref classNode, dummy);

            foreach (DummyMethodContainer method in dummy.Methods)
            {
                BuildMethod(ref classNode, method);
            }

            currentStaticClass = currentStaticClass.AddMembers(classNode);
        }

        public static void BuildConstructor(ref ClassDeclarationSyntax currentClass, DummyContainer dummy)
        {
            var (_, plainName, plainParameters) = RegexAnalyzer.Divide.Declaration(dummy.Declaration);
            string className = plainName.Split('.')[^1];

            var constructorNode = SyntaxFactory.ConstructorDeclaration(className)
                .AddParameterListParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier("myParameter"))
                .WithType(SyntaxFactory.ParseTypeName("string")))
                .WithBody(SyntaxFactory.Block(SyntaxFactory.ParseStatement($"_myField = myParameter;")))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

            currentClass = currentClass.AddMembers(constructorNode);
        }

        private static void BuildMethod(ref ClassDeclarationSyntax currentClass, DummyMethodContainer dummy)
        {
            var (_, plainName, plainParameters) = RegexAnalyzer.Divide.Declaration(dummy.Declaration);
            string methodName = plainName.Split('.')[^1];

            var methodNode = SyntaxFactory.MethodDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), methodName)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .WithBody(SyntaxFactory.Block());

            currentClass = currentClass.AddMembers(methodNode);
        }

        private static void BuildStaticMethod(ref ClassDeclarationSyntax currentStaticClass, DummyContainer dummy)
        {
            var (_, plainName, plainParameters) = RegexAnalyzer.Divide.Declaration(dummy.Declaration);
            string methodName = plainName.Split('.')[^1];

            var methodNode = SyntaxFactory.MethodDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)), methodName)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .WithBody(SyntaxFactory.Block());

            currentStaticClass = currentStaticClass.AddMembers(methodNode);
        }

        private static void BuildException(ref ClassDeclarationSyntax currentStaticClass, DummyContainer dummy)
        {
            // Not Implemented yet...
        }
    }
}
