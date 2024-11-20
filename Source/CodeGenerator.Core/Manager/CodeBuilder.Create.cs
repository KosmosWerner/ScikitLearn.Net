using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CodeGenerator.Core.Manager;

public static partial class CodeBuilder
{
    public static class Create
    {
        public static CompilationUnitSyntax CompilationUnit(UsingDirectiveSyntax[] usings, NamespaceDeclarationSyntax root)
        {
            return SyntaxFactory.CompilationUnit()
                .AddUsings(usings)
                .AddMembers(root)
                .NormalizeWhitespace();
        }

        public static UsingDirectiveSyntax[] Usings()
        {
            return
            [
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("Numpy")),
                SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("Python.Runtime")),
            ];
        }

        public static NamespaceDeclarationSyntax Namespace(string name)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(name));
        }

        public static ClassDeclarationSyntax PublicStaticPartialClass(string name)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.ClassDeclaration(name).AddModifiers(
                SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.StaticKeyword),
                SyntaxFactory.Token(SyntaxKind.PartialKeyword));
        }

        public static ClassDeclarationSyntax PublicStaticClass(string name)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.ClassDeclaration(name).AddModifiers(
                SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.StaticKeyword));
        }

        public static ClassDeclarationSyntax PublicClass(string name)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.ClassDeclaration(name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName("PythonObject")));
        }

        public static ConstructorDeclarationSyntax PublicConstructor(string name, ParameterSyntax[] parameterList, StatementSyntax[] statements)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.ConstructorDeclaration(name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddParameterListParameters(parameterList)
                .WithBody(SyntaxFactory.Block(statements));
        }

        public static ConstructorDeclarationSyntax InternalConstructor(string name, ParameterSyntax[] parameterList, StatementSyntax[] statements)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.ConstructorDeclaration(name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.InternalKeyword))
                .AddParameterListParameters(parameterList)
                .WithBody(SyntaxFactory.Block(statements));
        }

        public static MethodDeclarationSyntax PublicMethod(string name, string returnType, ParameterSyntax[] parameterList, StatementSyntax[] statements)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName(returnType), name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddParameterListParameters(parameterList)
                .WithBody(SyntaxFactory.Block(statements));
        }

        public static MethodDeclarationSyntax PublicStaticMethod(string name, string returnType, ParameterSyntax[] parameterList, StatementSyntax[] statements)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName(returnType), name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .AddParameterListParameters(parameterList)
                .WithBody(SyntaxFactory.Block(statements));
        }

        public static PropertyDeclarationSyntax ArrowProperty(string type, string name, string expression)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            var arrowExpression = SyntaxFactory.ArrowExpressionClause(
                                SyntaxFactory.ParseExpression(expression));

            var propertyNode = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(type), name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .WithExpressionBody(arrowExpression)
                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
            return propertyNode;
        }

        public static PropertyDeclarationSyntax GetProperty(string type, string name, StatementSyntax[] statements)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            var getAccessor = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithBody(SyntaxFactory.Block(statements));

            var propertyNode = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(type), name)
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddAccessorListAccessors(getAccessor);
            return propertyNode;
        }

        public static StatementSyntax[] Statements(IEnumerable<string> linesOfCode)
        {
            return linesOfCode.Select(Statement).ToArray();
        }

        public static StatementSyntax Statement(string lineOfCode)
        {
            return SyntaxFactory.ParseStatement(lineOfCode);
        }

        public static MemberDeclarationSyntax Declaration(string code)
        {
            return SyntaxFactory.ParseMemberDeclaration(code);
        }

        public static ParameterSyntax Parameter(string type, string name)
        {
            name = TextAnalyzer.Fix.Reserved(name);

            return SyntaxFactory.Parameter(SyntaxFactory.Identifier(TextAnalyzer.Fix.Reserved(name)))
                        .WithType(SyntaxFactory.ParseTypeName(type));
        }
    }
}
