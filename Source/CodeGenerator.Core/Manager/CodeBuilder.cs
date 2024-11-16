using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace CodeGenerator.Core.Manager;

public static class CodeBuilder
{
    public static CompilationUnitSyntax CreateCompilationUnit(UsingDirectiveSyntax[] usings, NamespaceDeclarationSyntax root)
    {
        return SyntaxFactory
            .CompilationUnit()
            .AddUsings(usings)
            .AddMembers(root)
            .NormalizeWhitespace();
    }

    public static UsingDirectiveSyntax[] CreateUsings()
    {
        return
        [
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("Numpy")),
            SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("Python.Runtime")),
        ];
    }

    public static NamespaceDeclarationSyntax CreateNamespace(string name)
    {
        return SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName(name));
    }

    public static ClassDeclarationSyntax CreatePublicStaticPartialClass(string name)
    {
        return SyntaxFactory.ClassDeclaration(name).AddModifiers(
            SyntaxFactory.Token(SyntaxKind.PublicKeyword),
            SyntaxFactory.Token(SyntaxKind.StaticKeyword),
            SyntaxFactory.Token(SyntaxKind.PartialKeyword));
    }

    public static ClassDeclarationSyntax CreatePublicStaticClass(string name)
    {
        return SyntaxFactory.ClassDeclaration(name).AddModifiers(
            SyntaxFactory.Token(SyntaxKind.PublicKeyword),
            SyntaxFactory.Token(SyntaxKind.StaticKeyword));
    }

    public static ClassDeclarationSyntax CreatePublicClass(string name)
    {
        return SyntaxFactory.ClassDeclaration(name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddBaseListTypes(SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName("PythonObject"))
    );
    }

    public static ConstructorDeclarationSyntax CreatePublicConstructor(string name, ParameterSyntax[] parameterList, StatementSyntax[] statements)
    {
        return SyntaxFactory.ConstructorDeclaration(name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddParameterListParameters(parameterList)
            .WithBody(SyntaxFactory.Block(statements));
    }

    public static PropertyDeclarationSyntax CreateArrowProperty(string type, string name, string expression)
    {
        var arrowExpression = SyntaxFactory.ArrowExpressionClause(
                            SyntaxFactory.ParseExpression(expression));

        var propertyNode = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(type), name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .WithExpressionBody(arrowExpression)
            .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));
        return propertyNode;
    }

    public static PropertyDeclarationSyntax CreateGetProperty(string type, string name, StatementSyntax[] statements)
    {
        var getAccessor = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                            .WithBody(SyntaxFactory.Block(statements));

        var propertyNode = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName(type), name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddAccessorListAccessors(getAccessor);
        return propertyNode;
    }

    public static MethodDeclarationSyntax CreatePublicMethod(string name, string returnType, ParameterSyntax[] parameterList, StatementSyntax[] statements)
    {
        return SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName(returnType), name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
            .AddParameterListParameters(parameterList)
            .WithBody(SyntaxFactory.Block(statements));
    }

    public static MethodDeclarationSyntax CreatePublicStaticMethod(string name, string returnType, ParameterSyntax[] parameterList, StatementSyntax[] statements)
    {
        return SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName(returnType), name)
            .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword), SyntaxFactory.Token(SyntaxKind.StaticKeyword))
            .AddParameterListParameters(parameterList)
            .WithBody(SyntaxFactory.Block(statements));
    }


    public static void Build(string outputDirectoryPath, string fileName, IOrderedEnumerable<NodeContainer> sortedNodeContainers)
    {
        var uniqueStaticClasses = sortedNodeContainers
            .Select(container =>
            {
                var (_, fullName, _) = TextAnalyzer.Divide.Declaration(container.Declaration);
                var namespaceParts = fullName.Split('.');
                return string.Join(".", namespaceParts[..^1]);
            })
            .Distinct()
            .ToList();

        var usings = CreateUsings();
        var ScikitLearn = CreateNamespace("ScikitLearn");

        var sklearn = CreatePublicStaticPartialClass("sklearn");

        BuildImports(ref sklearn, "sklearn");

        foreach (var container in sortedNodeContainers)
        {
            switch (container.NodeType)
            {
                case NodeType.Class: BuildClass(ref sklearn, container); break;
                case NodeType.Method: BuildStaticMethod(ref sklearn, container); break;
                case NodeType.Exception: BuildException(ref sklearn, container); break;
                case NodeType.None:
                default: break;
            }
        }

        ScikitLearn = ScikitLearn.AddMembers(sklearn);

        var compilationUnit = CreateCompilationUnit(usings, ScikitLearn);
        var code = compilationUnit.ToFullString();

        Directory.CreateDirectory(outputDirectoryPath);

        string outputFile = Path.Combine(outputDirectoryPath, $"{fileName}.cs");
        File.WriteAllText(outputFile, code);
    }

    private static void BuildImports(ref ClassDeclarationSyntax currentStaticClass, string staticCallable)
    {
        var staticClassName = staticCallable.Split('.')[^1];

        // Hardcode but it works
        var lazySelfField = SyntaxFactory.ParseMemberDeclaration(@"private static Lazy<PyObject> _lazy_self;");

        var selfProperty = SyntaxFactory.ParseMemberDeclaration(@"
        public static PyObject self
        {
            get => _lazy_self.Value;
        }");

        var reInitializeLazySelfMethod = SyntaxFactory.ParseMemberDeclaration(@"
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

        var installAndImportMethod = SyntaxFactory.ParseMemberDeclaration($@"
        private static PyObject InstallAndImport(bool force = false)
        {{
            PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
            PythonEngine.Initialize();
            return Py.Import(""{staticCallable}"");
        }}");

        var staticConstructor = SyntaxFactory.ParseMemberDeclaration($@"
        static {staticClassName}()
        {{
            ReInitializeLazySelf();
        }}");

        // Agregar miembros a la clase estática
        currentStaticClass = currentStaticClass.AddMembers(
            lazySelfField,
            selfProperty,
            reInitializeLazySelfMethod,
            installAndImportMethod,
            staticConstructor
        );
    }


    private static void BuildClass(ref ClassDeclarationSyntax currentStaticClass, NodeContainer container)
    {
        var (_, plainName, _) = TextAnalyzer.Divide.Declaration(container.Declaration);
        var (name, _) = TextAnalyzer.Divide.PlainName(plainName);

        var classNode = CreatePublicClass(name);

        BuildConstructor(ref classNode, container);
        BuildAttributes(ref classNode, container);

        foreach (NodeMethodContainer methodContainer in container.Methods)
            BuildMethod(ref classNode, methodContainer, name);

        currentStaticClass = currentStaticClass.AddMembers(classNode);
    }


    public static void BuildConstructor(ref ClassDeclarationSyntax currentClass, NodeContainer container)
    {
        var (_, plainName, plainParameters) = TextAnalyzer.Divide.Declaration(container.Declaration);
        var (name, callableStaticClass) = TextAnalyzer.Divide.PlainName(plainName);

        string[] constructorParameters = TextAnalyzer.Divide.PlainParameters(plainParameters);
        string[] documentedParameters = [.. container.Parameters];

        var mappedParameters = MapperTypes.GetParameters(constructorParameters, documentedParameters);

        var parameterList = Helpers.CreateListParameters(mappedParameters);
        var statements = Helpers.CreateConstructorStatements(mappedParameters, name, callableStaticClass);

        var constructorNode = CreatePublicConstructor(name, parameterList, statements);

        currentClass = currentClass.AddMembers(constructorNode);
    }

    private static void BuildAttributes(ref ClassDeclarationSyntax classNode, NodeContainer container)
    {
        List<(string Type, string Name)> mappedAttributes = MapperTypes.GetAttributes(container.Attributes);

        foreach (var attribute in mappedAttributes)
        {
            if (attribute.Type.StartsWith('(') && attribute.Type.EndsWith(')'))
            {
                string[] types = TextAnalyzer.Divide.Tuple(attribute.Type);

                var statements = Helpers.TupleGetStatements(attribute.Name, types);
                PropertyDeclarationSyntax propertyNode = CreateGetProperty(attribute.Type, attribute.Name, statements);

                classNode = classNode.AddMembers(propertyNode);
            }
            else
            {
                string? expression;
                if (attribute.Type.StartsWith("PyObject")) expression = $"self.GetAttr(\"{attribute.Name}\")";
                else
                {
                    if (attribute.Type.StartsWith("Py")) expression = $"new {attribute.Type}(self.GetAttr(\"{attribute.Name}\"))";
                    else expression = $"ToCsharp<{attribute.Type}>(self.GetAttr(\"{attribute.Name}\"))";
                }

                var propertyNode = CreateArrowProperty(attribute.Type, attribute.Name, expression);

                classNode = classNode.AddMembers(propertyNode);
            }
        }
    }

    private static void BuildMethod(ref ClassDeclarationSyntax currentClass, NodeMethodContainer container, string className)
    {
        var (_, name, plainParameters) = TextAnalyzer.Divide.Declaration(container.Declaration);

        string[] methodParameters = TextAnalyzer.Divide.PlainParameters(plainParameters);
        string[] documentedParameters = [.. container.Parameters];

        var mappedParameters = MapperTypes.GetParameters(methodParameters, documentedParameters);
        string returnType = MapperTypes.GetReturn(container.Returns);

        var parameterList = Helpers.CreateListParameters(mappedParameters);
        var statements = Helpers.CreateMethodStatements(mappedParameters, name, returnType);
        MethodDeclarationSyntax? methodNode;

        if (returnType == "this") methodNode = CreatePublicMethod(name, className, parameterList, statements);
        else if (returnType == string.Empty) methodNode = CreatePublicMethod(name, "void", parameterList, statements);
        else methodNode = CreatePublicMethod(name, returnType, parameterList, statements);

        currentClass = currentClass.AddMembers(methodNode);
    }



    private static void BuildStaticMethod(ref ClassDeclarationSyntax currentStaticClass, NodeContainer container)
    {
        var (_, plainName, plainParameters) = TextAnalyzer.Divide.Declaration(container.Declaration);
        var (name, callableStaticClass) = TextAnalyzer.Divide.PlainName(plainName);

        string[] methodParameters = TextAnalyzer.Divide.PlainParameters(plainParameters);
        string[] documentedParameters = [.. container.Parameters];

        var mappedParameters = MapperTypes.GetParameters(methodParameters, documentedParameters);
        string returnType = MapperTypes.GetReturn(container.Returns);

        var parameterList = Helpers.CreateListParameters(mappedParameters);
        var statements = Helpers.CreateMethodStatements(mappedParameters, name, returnType, callableStaticClass);

        MethodDeclarationSyntax? methodNode;
        if (returnType == string.Empty) methodNode = CreatePublicStaticMethod(name, "void", parameterList, statements);
        else methodNode = CreatePublicStaticMethod(name, returnType, parameterList, statements);

        currentStaticClass = currentStaticClass.AddMembers(methodNode);
    }

    private static void BuildException(ref ClassDeclarationSyntax currentStaticClass, NodeContainer dummy)
    {
        // Not Implemented yet...
    }


    private static class Helpers
    {
        public static StatementSyntax[] TupleGetStatements(
            string name,
            string[] types)
        {
            int count = 0;

            List<StatementSyntax> result = [];
            result.Add(SyntaxFactory.ParseStatement($"PyTuple result = new PyTuple(self.GetAttr(\"{name}\"));"));
            var x = types.Select(x => $"ToCsharp<{x}>(result[{count++}])").ToArray();

            result.Add(SyntaxFactory.ParseStatement($"return ({string.Join(',', x)});"));

            return result.ToArray();
        }

        public static StatementSyntax[] CreateConstructorStatements(
            List<(string Type, string Name, string? Value)> parameters,
            string className,
            string callableStaticClass)
        {
            List<StatementSyntax> result = [];
            var args = parameters
                .Where(x => x.Value == string.Empty)
                .Select(x => x.Name);

            if (args.Any())
                result.Add(SyntaxFactory.ParseStatement($"PyTuple args = ToTuple(new object[] {{{string.Join(", ", args)}}});"));
            else
                result.Add(SyntaxFactory.ParseStatement("PyTuple args = new PyTuple();"));

            result.Add(SyntaxFactory.ParseStatement("PyDict pyDict = new PyDict();"));

            var kw = parameters.Where(x => x.Value != string.Empty);

            foreach (var k in kw)
            {
                if (k.Type.EndsWith('?'))
                    result.Add(SyntaxFactory.ParseStatement($"if ({k.Name} != null) pyDict[\"{k.Name}\"] = ToPython({k.Name});"));
                else
                    result.Add(SyntaxFactory.ParseStatement($"pyDict[\"{k.Name}\"] = ToPython({k.Name});"));
            }

            result.Add(SyntaxFactory.ParseStatement($"self = {callableStaticClass}.self.InvokeMethod(\"{className}\", args, pyDict);"));
            return result.ToArray();
        }

        public static StatementSyntax[] CreateMethodStatements(
            List<(string Type, string Name, string? Value)> parameters,
            string methodName,
            string returnType,
            string? callableStaticClass = null)
        {
            List<StatementSyntax> result = [];
            var args = parameters
                .Where(x => x.Value == string.Empty)
                .Select(x => TextAnalyzer.Fix.Reserved(x.Name));

            if (args.Any())
                result.Add(SyntaxFactory.ParseStatement($"PyTuple args = ToTuple(new object[] {{{string.Join(", ", args)}}});"));
            else
                result.Add(SyntaxFactory.ParseStatement("PyTuple args = new PyTuple();"));

            result.Add(SyntaxFactory.ParseStatement("PyDict pyDict = new PyDict();"));

            var kw = parameters.Where(x => x.Value != string.Empty);

            foreach (var k in kw)
            {
                if (k.Type.EndsWith('?'))
                    result.Add(SyntaxFactory.ParseStatement($"if ({TextAnalyzer.Fix.Reserved(k.Name)} != null) pyDict[\"{k.Name}\"] = ToPython({TextAnalyzer.Fix.Reserved(k.Name)});"));
                else
                    result.Add(SyntaxFactory.ParseStatement($"pyDict[\"{k.Name}\"] = ToPython({TextAnalyzer.Fix.Reserved(k.Name)});"));
            }

            if (callableStaticClass == null)
            {
                if (returnType == string.Empty)
                {
                    result.Add(SyntaxFactory.ParseStatement($"self.InvokeMethod(\"{methodName}\", args, pyDict);"));
                }
                else if (returnType == "this")
                {
                    result.Add(SyntaxFactory.ParseStatement($"self.InvokeMethod(\"{methodName}\", args, pyDict);"));
                    result.Add(SyntaxFactory.ParseStatement($"return this;"));
                }
                else
                {
                    if (returnType.StartsWith('(') && returnType.EndsWith(')'))
                    {
                        int count = 0;
                        string[] types = TextAnalyzer.Divide.Tuple(returnType);
                        result.Add(SyntaxFactory.ParseStatement($"PyTuple result = new PyTuple(self.InvokeMethod(\"{methodName}\", args, pyDict));"));
                        var x = types.Select(x => $"ToCsharp<{x}>(result[{count++}])").ToArray();

                        result.Add(SyntaxFactory.ParseStatement($"return ({string.Join(',', x)});"));
                    }
                    else
                    {
                        string? expression;
                        if (returnType.StartsWith("PyObject")) expression = $"return self.InvokeMethod(\"{methodName}\", args, pyDict);";
                        else
                        {
                            if (returnType.StartsWith("Py")) expression = $"return new {returnType}(self.InvokeMethod(\"{methodName}\", args, pyDict))";
                            else expression = $"return ToCsharp<{returnType}>(self.InvokeMethod(\"{methodName}\", args, pyDict)))";
                        }
                    }
                }
            }
            else
            {
                if (returnType == string.Empty)
                    result.Add(SyntaxFactory.ParseStatement($"{callableStaticClass}.self.InvokeMethod(\"{methodName}\", args, pyDict);"));

                else
                {
                    if (returnType.StartsWith('(') && returnType.EndsWith(')'))
                    {
                        int count = 0;
                        string[] types = TextAnalyzer.Divide.Tuple(returnType);
                        result.Add(SyntaxFactory.ParseStatement($"PyTuple result = new PyTuple({callableStaticClass}.self.InvokeMethod(\"{methodName}\", args, pyDict));"));
                        var x = types.Select(x => $"ToCsharp<{x}>(result[{count++}])").ToArray();

                        result.Add(SyntaxFactory.ParseStatement($"return ({string.Join(',', x)});"));
                    }
                    else
                    {
                        string? expression;
                        if (returnType.StartsWith("PyObject")) expression = $"return {callableStaticClass}.self.InvokeMethod(\"{methodName}\", args, pyDict);";
                        else
                        {
                            if (returnType.StartsWith("Py")) expression = $"return new {returnType}({callableStaticClass}.self.InvokeMethod(\"{methodName}\", args, pyDict))";
                            else expression = $"return ToCsharp<{returnType}>({callableStaticClass}.self.InvokeMethod(\"{methodName}\", args, pyDict)))";
                        }
                    }
                }
            }
            return result.ToArray();
        }

        public static ParameterSyntax[] CreateListParameters(List<(string Type, string Name, string? Value)> list)
        {
            List<ParameterSyntax> result = [];

            foreach (var x in list)
            {
                if (x.Value == string.Empty)
                {
                    result.Add(SyntaxFactory.Parameter(SyntaxFactory.Identifier(TextAnalyzer.Fix.Reserved(x.Name)))
                        .WithType(SyntaxFactory.ParseTypeName(x.Type)));
                }
                else if (x.Value == null)
                {
                    result.Add(SyntaxFactory.Parameter(SyntaxFactory.Identifier(TextAnalyzer.Fix.Reserved(x.Name)))
                        .WithType(SyntaxFactory.ParseTypeName(x.Type))
                        .WithDefault(SyntaxFactory.EqualsValueClause(
                            SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression))));
                }
                else
                {
                    result.Add(SyntaxFactory.Parameter(SyntaxFactory.Identifier(TextAnalyzer.Fix.Reserved(x.Name)))
                        .WithType(SyntaxFactory.ParseTypeName(x.Type))
                        .WithDefault(SyntaxFactory.EqualsValueClause(
                            SyntaxFactory.ParseExpression(x.Value))));
                }
            }
            return result.ToArray();
        }
    }
}
