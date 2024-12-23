﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Linq;

namespace CodeGenerator.Core.Manager;

public static partial class CodeBuilder
{
    public static void Build(string outputDirectoryPath, string fileName, IOrderedEnumerable<EntityContainer> sortedNodeContainers)
    {
        Dictionary<string, ClassDeclarationSyntax> repository = [];

        var usings = Create.Usings();
        var ScikitLearn = Create.Namespace("ScikitLearn");

        repository["sklearn"] = Create.PublicStaticPartialClass("sklearn");

        foreach (var container in sortedNodeContainers)
        {
            //      sklearn.cluster.Class1
            var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(container.Declaration);
            //   Class1       | sklearn.cluster
            var (_, parentStaticClasses) = TextAnalyzer.Divide.FromFullName(fullName);

            if (repository.TryGetValue(parentStaticClasses, out ClassDeclarationSyntax? aux))
            {
                // recuperamos el objeto
                var current = aux;

                switch (container.NodeType)
                {
                    case EntityType.Class: BuildClass(ref current, container); break;
                    case EntityType.Method: BuildStaticMethod(ref current, container); break;
                    case EntityType.Exception: BuildException(ref current, container); break;
                    case EntityType.None:
                    default: break;
                }

                // reasignamos el objeto
                repository[parentStaticClasses] = current;
            }
            else
            {
                //   cluster                                       sklearn.cluster
                var (name, _) = TextAnalyzer.Divide.FromFullName(parentStaticClasses);

                var current = Create.PublicStaticClass(name);
                BuildImports(ref current, parentStaticClasses); // solo por una vez

                switch (container.NodeType)
                {
                    case EntityType.Class: BuildClass(ref current, container); break;
                    case EntityType.Method: BuildStaticMethod(ref current, container); break;
                    case EntityType.Exception: BuildException(ref current, container); break;
                    case EntityType.None:
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

        var lazySelfField = Create.Declaration(@"private static Lazy<PyObject> _lazy_self;");

        var selfProperty = Create.Declaration(@"
        public static PyObject self
        {
            get => _lazy_self.Value;
        }");

        var reInitializeLazySelfMethod = Create.Declaration(@"
        private static void ReInitializeLazySelf()
        {
            _lazy_self = new Lazy<PyObject>(() =>
            {
                try { return InstallAndImport(); }
                catch (Exception) { return InstallAndImport(true); }
            });
        }");

        var installAndImportMethod = Create.Declaration($@"
        private static PyObject InstallAndImport(bool force = false)
        {{
            PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
            PythonEngine.Initialize();
            return Py.Import(""{staticCallable}"");
        }}");

        var staticConstructor = Create.Declaration($@"
        static {TextAnalyzer.Fix.Reserved(staticClassName)}()
        {{
            ReInitializeLazySelf();
        }}");

        currentStaticClass = currentStaticClass.AddMembers(
            lazySelfField,
            selfProperty,
            reInitializeLazySelfMethod,
            installAndImportMethod,
            staticConstructor
        );
    }

    private static void BuildClass(ref ClassDeclarationSyntax currentStaticClass, EntityContainer entity)
    {
        var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(entity.Declaration);
        var (className, _) = TextAnalyzer.Divide.FromFullName(fullName);

        var @class = Create.PublicClass(className);

        InsertConstructor(ref @class, entity);
        InsertProperties(ref @class, entity);

        foreach (EntityMethodContainer methodContainer in entity.Methods)
            InsertMethod(ref @class, methodContainer, className);

        currentStaticClass = currentStaticClass.AddMembers(@class);
    }


    public static void InsertConstructor(ref ClassDeclarationSyntax @class, EntityContainer entity)
    {
        var (_, fullName, rawParameters) = TextAnalyzer.Divide.FromDeclaration(entity.Declaration);
        var (className, callableStaticClass) = TextAnalyzer.Divide.FromFullName(fullName);

        string[] declaredParams = TextAnalyzer.Divide.FromRawParameters(rawParameters);
        string[] documentedParams = [.. entity.Parameters];

        // Principal constructor
        {
            List<(string Type, string Name, string? Value)>[] mappedParameters = Tokenizer.GetParameters(declaredParams, documentedParams);
            foreach (var parameters in mappedParameters)
            {
                var parameterList = Helpers.ParametersList(parameters);
                // El constructor funciona como un metodo que no retorna nada
                var statements = Helpers.MethodStatements(parameters, className, callableStaticClass);

                var constructorNode = Create.PublicConstructor(className, parameterList, statements);
                @class = @class.AddMembers(constructorNode);
            }
        }

        var pyObjectParam = Create.Parameter("PyObject", "pyObject");

        // Internal Constructor
        {
            var statement = Create.Statements([$"_ = {TextAnalyzer.Fix.Reserved(callableStaticClass)}.self;", "self = pyObject;"]);

            var constructor = Create.InternalConstructor(className, [pyObjectParam], statement);
            @class = @class.AddMembers(constructor);
        }

        // Encapsule
        {
            var statement = Create.Statement($"return new {className}(pyObject);");

            var encapsule = Create.PublicStaticMethod("Encapsule", className, [pyObjectParam], [statement]);
            @class = @class.AddMembers(encapsule);
        }
    }

    private static void InsertProperties(ref ClassDeclarationSyntax classNode, EntityContainer entity)
    {
        List<(string Type, string Name)> mappedAttributes = Tokenizer.GetAttributes(entity.Attributes);

        foreach (var prop in mappedAttributes)
        {
            if (prop.Type.StartsWith('(') && prop.Type.EndsWith(')'))
            {
                string[] types = TextAnalyzer.Divide.FromRawTuple(prop.Type);

                var statements = Helpers.TupleGetStatements(prop.Name, types);
                var propertyNode = Create.GetProperty(prop.Type, prop.Name, statements);

                classNode = classNode.AddMembers(propertyNode);
            }
            else
            {
                string? expression;
                if (prop.Type.StartsWith("PyObject")) expression = $"self.GetAttr(\"{prop.Name}\")";
                else
                {
                    if (prop.Type.StartsWith("Py")) expression = $"new {prop.Type}(self.GetAttr(\"{prop.Name}\"))";
                    else expression = $"Helpers.ToCSharp{ToUpperName(prop.Type)}(self.GetAttr(\"{prop.Name}\"))";
                }

                var propertyNode = Create.ArrowProperty(prop.Type, prop.Name, expression);

                classNode = classNode.AddMembers(propertyNode);
            }
        }
    }

    public static string ToUpperName(string str)
    {
        if (str.Length > 1) return char.ToUpper(str[0]) + str.Substring(1);
        return str.ToUpper();
    }

    private static void InsertMethod(ref ClassDeclarationSyntax currentClass, EntityMethodContainer methodEntity, string className)
    {
        var (_, methodName, rawParameters) = TextAnalyzer.Divide.FromDeclaration(methodEntity.Declaration);
        if (methodName.StartsWith("__")) return; // Omitir __call__ o similares

        string[] declaredParams = TextAnalyzer.Divide.FromRawParameters(rawParameters);
        string[] documentedParams = [.. methodEntity.Parameters];

        List<(string Type, string Name, string? Value)>[] mappedParameters = Tokenizer.GetParameters(declaredParams, documentedParams);
        string returnType = Tokenizer.GetReturn(methodEntity.Returns);

        foreach (var parameters in mappedParameters)
        {
            var parameterList = Helpers.ParametersList(parameters);
            var statements = Helpers.MethodStatements(parameters, methodName, null, returnType);

            switch (GetReturnCase(returnType))
            {
                case ReturnCase.Void:
                    var voidMethod = Create.PublicMethod(methodName, "void", parameterList, statements);
                    currentClass = currentClass.AddMembers(voidMethod);
                    break;

                case ReturnCase.Self:
                    var selfMethod = Create.PublicMethod(methodName, className, parameterList, statements);
                    currentClass = currentClass.AddMembers(selfMethod);
                    break;

                case ReturnCase.Other:
                    var method = Create.PublicMethod(methodName, returnType, parameterList, statements);
                    currentClass = currentClass.AddMembers(method);
                    break;
            }
        }
    }

    public static ReturnCase GetReturnCase(string returnType)
    {
        if (returnType == "this") return ReturnCase.Self;
        else if (returnType == string.Empty) return ReturnCase.Void;
        else return ReturnCase.Other;
    }

    public enum ReturnCase
    {
        Void,
        Self,
        Other
    }

    private static void BuildStaticMethod(ref ClassDeclarationSyntax currentStaticClass, EntityContainer entity)
    {
        var (_, fullName, rawParameters) = TextAnalyzer.Divide.FromDeclaration(entity.Declaration);
        var (methodName, callableStaticClass) = TextAnalyzer.Divide.FromFullName(fullName);

        string[] declaredParams = TextAnalyzer.Divide.FromRawParameters(rawParameters);
        string[] documentedParams = [.. entity.Parameters];

        List<(string Type, string Name, string? Value)>[] mappedParameters = Tokenizer.GetParameters(declaredParams, documentedParams);
        string returnType = Tokenizer.GetReturn(entity.Returns);

        foreach (var parameters in mappedParameters)
        {
            var parameterList = Helpers.ParametersList(parameters);
            var statements = Helpers.MethodStatements(parameters, methodName, callableStaticClass, returnType);

            switch (GetReturnCase(returnType))
            {
                case ReturnCase.Void:
                    var voidMethod = Create.PublicStaticMethod(methodName, "void", parameterList, statements);
                    currentStaticClass = currentStaticClass.AddMembers(voidMethod);
                    break;

                case ReturnCase.Self:
                    break;

                case ReturnCase.Other:
                    var method = Create.PublicStaticMethod(methodName, returnType, parameterList, statements);
                    currentStaticClass = currentStaticClass.AddMembers(method);
                    break;
            }
        }
    }

    private static void BuildException(ref ClassDeclarationSyntax currentStaticClass, EntityContainer dummy)
    {
        // Not Implemented yet...
    }


    private static class Helpers
    {
        public static StatementSyntax[] TupleGetStatements(string name, string[] types)
        {
            int index = 0;

            List<string> statements = [];
            statements.Add($"PyTuple result = new PyTuple(self.GetAttr(\"{name}\"));");
            var items = types.Select(type => $"Helpers.ToCSharp{ToUpperName(type)}(result[{index++}])");

            statements.Add($"return ({string.Join(',', items)});");

            return Create.Statements(statements);
        }

        public static StatementSyntax[] MethodStatements(
            List<(string Type, string Name, string? Value)> parameters,
            string name,
            string? callableStaticClass,
            string? returnType = null)
        {
            List<string> statements = [];

            if (callableStaticClass != null)
            {
                statements.Add($"_ = {TextAnalyzer.Fix.Reserved(callableStaticClass)}.self;");
            }

            // Argumentos sin valor por defecto
            {
                var args = parameters.Where(x => x.Value == string.Empty)
                    .Select(x => $"Helpers.ToPython({TextAnalyzer.Fix.Reserved(x.Name)})");

                string statement = args.Any()
                    ? $"PyTuple args = new PyTuple([{string.Join(", ", args)}]);"
                    : "PyTuple args = new PyTuple();";

                statements.Add(statement);
            }

            // Argumentos con valor por defecto
            {
                var kw = parameters.Where(x => x.Value != string.Empty);
                statements.Add("PyDict pyDict = new PyDict();");

                foreach ((string Type, string Name, string? Value) in kw)
                {
                    string fixedName = TextAnalyzer.Fix.Reserved(Name);
                    statements.Add($"if ({fixedName} != {(Value ?? "null")}) pyDict[\"{Name}\"] = Helpers.ToPython({fixedName});");
                }
            }

            // Invocar a la clase estatica para crear la clase
            if (returnType == null)
            {
                if (callableStaticClass != null)
                {
                    statements.Add($"self = {TextAnalyzer.Fix.Reserved(callableStaticClass)}.self.InvokeMethod(\"{name}\", args, pyDict);");
                }
            }
            else
            {
                string callable = callableStaticClass == null
                           ? "self" : $"{TextAnalyzer.Fix.Reserved(callableStaticClass)}.self";

                switch (GetReturnCase(returnType))
                {
                    case ReturnCase.Void:
                        statements.Add($"{callable}.InvokeMethod(\"{name}\", args, pyDict);");
                        break;

                    case ReturnCase.Self:
                        statements.Add($"self.InvokeMethod(\"{name}\", args, pyDict);");
                        statements.Add($"return this;");
                        break;

                    case ReturnCase.Other:
                        if (returnType.StartsWith('(') && returnType.EndsWith(')'))
                        {
                            int index = 0;
                            string[] types = TextAnalyzer.Divide.FromRawTuple(returnType);
                            statements.Add($"PyTuple result = new PyTuple({callable}.InvokeMethod(\"{name}\", args, pyDict));");
                            statements.Add("var __length = result.Length();");
                            var items = types.Select(type => $"__length > {index} ? Helpers.ToCSharp{ToUpperName(type).TrimEnd('?')}(result[{index++}]) : null");
                            statements.Add($"return ({string.Join(',', items)});");
                        }
                        else
                        {
                            if (returnType.StartsWith("PyObject"))
                            {
                                statements.Add($"return {callable}.InvokeMethod(\"{name}\", args, pyDict);");
                            }
                            else
                            {
                                if (returnType.StartsWith("Py"))
                                    statements.Add($"return new {returnType}({callable}.InvokeMethod(\"{name}\", args, pyDict));");
                                else
                                    statements.Add($"return Helpers.ToCSharp{ToUpperName(returnType).TrimEnd('?')}({callable}.InvokeMethod(\"{name}\", args, pyDict));");
                            }
                        }
                        break;
                }
            }

            return Create.Statements(statements);
        }

        public static ParameterSyntax[] ParametersList(List<(string Type, string Name, string? Value)> list)
        {
            List<ParameterSyntax> result = [];

            foreach (var x in list)
            {
                string fixedName = TextAnalyzer.Fix.Reserved(x.Name);

                if (x.Value == string.Empty)
                {
                    result.Add(SyntaxFactory.Parameter(SyntaxFactory.Identifier(fixedName))
                        .WithType(SyntaxFactory.ParseTypeName(x.Type)));
                }
                else if (x.Value == null)
                {
                    result.Add(SyntaxFactory.Parameter(SyntaxFactory.Identifier(fixedName))
                        .WithType(SyntaxFactory.ParseTypeName(x.Type))
                        .WithDefault(SyntaxFactory.EqualsValueClause(
                            SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression))));
                }
                else
                {
                    result.Add(SyntaxFactory.Parameter(SyntaxFactory.Identifier(fixedName))
                        .WithType(SyntaxFactory.ParseTypeName(x.Type))
                        .WithDefault(SyntaxFactory.EqualsValueClause(
                            SyntaxFactory.ParseExpression(x.Value))));
                }
            }
            return [.. result];
        }
    }
}
