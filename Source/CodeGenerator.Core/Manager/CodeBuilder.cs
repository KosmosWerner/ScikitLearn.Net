using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CodeGenerator.Core.Manager;

public static partial class CodeBuilder
{
    public static void Build(string outputDirectoryPath, string fileName, IOrderedEnumerable<NodeContainer> sortedNodeContainers)
    {
        Dictionary<string, ClassDeclarationSyntax> repository = [];

        var usings = Create.Usings();
        var ScikitLearn = Create.Namespace("ScikitLearn");

        repository["sklearn"] = Create.PublicStaticPartialClass("sklearn");

        foreach (var container in sortedNodeContainers)
        {
            //      sklearn.cluster.Class1
            var (_, fullName, _) = TextAnalyzer.Divide.Declaration(container.Declaration);
            //   Class1       | sklearn.cluster
            var (containerName, parentStaticClasses) = TextAnalyzer.Divide.FullName(fullName);

            if (repository.TryGetValue(parentStaticClasses, out ClassDeclarationSyntax? aux))
            {
                // recuperamos el objeto
                var current = aux;

                switch (container.NodeType)
                {
                    case NodeType.Class: BuildClass(ref current, container); break;
                    case NodeType.Method: BuildStaticMethod(ref current, container); break;
                    case NodeType.Exception: BuildException(ref current, container); break;
                    case NodeType.None:
                    default: break;
                }

                // reasignamos el objeto
                repository[parentStaticClasses] = current;
            }
            else
            {
                //   cluster                                       sklearn.cluster
                var (className, _) = TextAnalyzer.Divide.FullName(parentStaticClasses);

                var current = Create.PublicStaticClass(className);
                BuildImports(ref current, parentStaticClasses); // solo por una vez

                switch (container.NodeType)
                {
                    case NodeType.Class: BuildClass(ref current, container); break;
                    case NodeType.Method: BuildStaticMethod(ref current, container); break;
                    case NodeType.Exception: BuildException(ref current, container); break;
                    case NodeType.None:
                    default: break;
                }

                // reasignamos el objeto
                repository[parentStaticClasses] = current;
            }
        }

        var maxDeep = repository
            .Select(x => x.Key)
            .Select(x => x.Split('.').Length)
            .Max(); // max 3 

        List<List<ClassDeclarationSyntax>> list = [];
        for (int i = 0; i < maxDeep; i++) list.Add([]);

        foreach (var item in repository)
        {
            int level = item.Key.Split('.').Length - 1;
            list[level].Add(item.Value);
        }

        for (int i = maxDeep - 1; i > 0; i--)
        {
            foreach (var item in list[i]) // id= 2
            {
                // obtener el primero de la lista de menor nivel
                var current = list[i - 1][0];

                current = current.AddMembers(item);

                // reasignar
                list[i - 1][0] = current;
            }
        }

        ScikitLearn = ScikitLearn.AddMembers(list[0][0]);

        var compilationUnit = Create.CompilationUnit(usings, ScikitLearn);
        var code = compilationUnit.ToFullString();

        Directory.CreateDirectory(outputDirectoryPath);

        string outputFile = Path.Combine(outputDirectoryPath, $"{fileName}.cs");
        File.WriteAllText(outputFile, code);
    }

    private static void BuildImports(ref ClassDeclarationSyntax currentStaticClass, string staticCallable)
    {
        var staticClassName = staticCallable.Split('.')[^1];

        // Hardcode, but it works
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
        static {TextAnalyzer.Fix.Reserved(staticClassName)}()
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
        var (name, _) = TextAnalyzer.Divide.FullName(plainName);

        var classNode = Create.PublicClass(name);

        BuildConstructor(ref classNode, container);
        BuildAttributes(ref classNode, container);

        foreach (NodeMethodContainer methodContainer in container.Methods)
            BuildMethod(ref classNode, methodContainer, name);

        currentStaticClass = currentStaticClass.AddMembers(classNode);
    }


    public static void BuildConstructor(ref ClassDeclarationSyntax currentClass, NodeContainer container)
    {
        var (_, plainName, plainParameters) = TextAnalyzer.Divide.Declaration(container.Declaration);
        var (name, callableStaticClass) = TextAnalyzer.Divide.FullName(plainName);

        string[] constructorParameters = TextAnalyzer.Divide.PlainParameters(plainParameters);
        string[] documentedParameters = [.. container.Parameters];

        var mappedParameters = MapperTypes.GetParameters(constructorParameters, documentedParameters);

        var parameterList = Helpers.CreateListParameters(mappedParameters);
        var statements = Helpers.CreateConstructorStatements(mappedParameters, name, callableStaticClass);

        var constructorNode = Create.PublicConstructor(name, parameterList, statements);

        currentClass = currentClass.AddMembers(constructorNode);

        // Auxiliar constructor
        var pyobjParam = Helpers.CreateListParameters();

        var defaultNode = Create.InternalConstructor(name, [pyobjParam], [Helpers.CreateConstructorStatements()]);
        currentClass = currentClass.AddMembers(defaultNode);

        // Encapsulation
        var method = Create.PublicStaticMethod("Encapsule", name, [pyobjParam], [Helpers.CreateMethodStatements(name)]);
        currentClass = currentClass.AddMembers(method);
    }

    private static void BuildAttributes(ref ClassDeclarationSyntax classNode, NodeContainer container)
    {
        List<(string Type, string Name)> mappedAttributes = MapperTypes.GetAttributes(container.Attributes);

        foreach (var attribute in mappedAttributes)
        {
            if (attribute.Type.StartsWith('(') && attribute.Type.EndsWith(')'))
            {
                string[] types = TextAnalyzer.Divide.PlainTuple(attribute.Type);

                var statements = Helpers.TupleGetStatements(attribute.Name, types);
                PropertyDeclarationSyntax propertyNode = Create.GetProperty(attribute.Type, attribute.Name, statements);

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

                var propertyNode = Create.ArrowProperty(attribute.Type, attribute.Name, expression);

                classNode = classNode.AddMembers(propertyNode);
            }
        }
    }

    private static void BuildMethod(ref ClassDeclarationSyntax currentClass, NodeMethodContainer container, string className)
    {
        var (_, name, plainParameters) = TextAnalyzer.Divide.Declaration(container.Declaration);
        // skip callables
        if (name.StartsWith("__")) return;

        string[] methodParameters = TextAnalyzer.Divide.PlainParameters(plainParameters);
        string[] documentedParameters = [.. container.Parameters];

        var mappedParameters = MapperTypes.GetParameters(methodParameters, documentedParameters);
        string returnType = MapperTypes.GetReturn(container.Returns);

        var parameterList = Helpers.CreateListParameters(mappedParameters);
        var statements = Helpers.CreateMethodStatements(mappedParameters, name, returnType);
        MethodDeclarationSyntax? methodNode;

        if (returnType == "this") methodNode = Create.PublicMethod(name, className, parameterList, statements);
        else if (returnType == string.Empty) methodNode = Create.PublicMethod(name, "void", parameterList, statements);
        else methodNode = Create.PublicMethod(name, returnType, parameterList, statements);

        currentClass = currentClass.AddMembers(methodNode);
    }



    private static void BuildStaticMethod(ref ClassDeclarationSyntax currentStaticClass, NodeContainer container)
    {
        var (_, plainName, plainParameters) = TextAnalyzer.Divide.Declaration(container.Declaration);
        var (name, callableStaticClass) = TextAnalyzer.Divide.FullName(plainName);

        string[] methodParameters = TextAnalyzer.Divide.PlainParameters(plainParameters);
        string[] documentedParameters = [.. container.Parameters];

        var mappedParameters = MapperTypes.GetParameters(methodParameters, documentedParameters);
        string returnType = MapperTypes.GetReturn(container.Returns);

        var parameterList = Helpers.CreateListParameters(mappedParameters);
        var statements = Helpers.CreateMethodStatements(mappedParameters, name, returnType, callableStaticClass);

        MethodDeclarationSyntax? methodNode;
        if (returnType == string.Empty) methodNode = Create.PublicStaticMethod(name, "void", parameterList, statements);
        else methodNode = Create.PublicStaticMethod(name, returnType, parameterList, statements);

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
                result.Add(SyntaxFactory.ParseStatement($"if ({TextAnalyzer.Fix.Reserved(k.Name)} != {(k.Value ?? "null")}) pyDict[\"{k.Name}\"] = ToPython({TextAnalyzer.Fix.Reserved(k.Name)});"));
            }

            result.Add(SyntaxFactory.ParseStatement($"self = {TextAnalyzer.Fix.Reserved(callableStaticClass)}.self.InvokeMethod(\"{className}\", args, pyDict);"));
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
                result.Add(SyntaxFactory.ParseStatement($"if ({TextAnalyzer.Fix.Reserved(k.Name)} != {(k.Value ?? "null")}) pyDict[\"{k.Name}\"] = ToPython({TextAnalyzer.Fix.Reserved(k.Name)});"));
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
                        string[] types = TextAnalyzer.Divide.PlainTuple(returnType);
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
                            if (returnType.StartsWith("Py")) expression = $"return new {returnType}(self.InvokeMethod(\"{methodName}\", args, pyDict));";
                            else expression = $"return ToCsharp<{returnType}>(self.InvokeMethod(\"{methodName}\", args, pyDict));";
                        }

                        result.Add(SyntaxFactory.ParseStatement(expression));
                    }
                }
            }
            else
            {
                if (returnType == string.Empty)
                    result.Add(SyntaxFactory.ParseStatement($"{TextAnalyzer.Fix.Reserved(callableStaticClass)}.self.InvokeMethod(\"{methodName}\", args, pyDict);"));

                else
                {
                    if (returnType.StartsWith('(') && returnType.EndsWith(')'))
                    {
                        int count = 0;
                        string[] types = TextAnalyzer.Divide.PlainTuple(returnType);
                        result.Add(SyntaxFactory.ParseStatement($"PyTuple result = new PyTuple({TextAnalyzer.Fix.Reserved(callableStaticClass)}.self.InvokeMethod(\"{methodName}\", args, pyDict));"));
                        var x = types.Select(x => $"ToCsharp<{x}>(result[{count++}])").ToArray();

                        result.Add(SyntaxFactory.ParseStatement($"return ({string.Join(',', x)});"));
                    }
                    else
                    {
                        string? expression;
                        if (returnType.StartsWith("PyObject")) expression = $"return {TextAnalyzer.Fix.Reserved(callableStaticClass)}.self.InvokeMethod(\"{methodName}\", args, pyDict);";
                        else
                        {
                            if (returnType.StartsWith("Py")) expression = $"return new {returnType}({TextAnalyzer.Fix.Reserved(callableStaticClass)}.self.InvokeMethod(\"{methodName}\", args, pyDict));";
                            else expression = $"return ToCsharp<{returnType}>({TextAnalyzer.Fix.Reserved(callableStaticClass)}.self.InvokeMethod(\"{methodName}\", args, pyDict));";

                        }
                        result.Add(SyntaxFactory.ParseStatement(expression));
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


        public static ParameterSyntax CreateListParameters()
        {
            return SyntaxFactory.Parameter(SyntaxFactory.Identifier(TextAnalyzer.Fix.Reserved("pyObject")))
                        .WithType(SyntaxFactory.ParseTypeName("PyObject"));
        }

        public static StatementSyntax CreateConstructorStatements()
        {
            return SyntaxFactory.ParseStatement($"self = pyObject;");
        }

        public static StatementSyntax CreateMethodStatements(string className)
        {
            return SyntaxFactory.ParseStatement($"return new {className}(pyObject);");
        }
    }
}
