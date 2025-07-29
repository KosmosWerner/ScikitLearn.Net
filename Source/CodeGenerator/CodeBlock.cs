using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;

namespace CodeGenerator;

public class CodeBlock : IDisposable
{
    private readonly StringBuilder stringBuilder;

    private CodeBlock(StringBuilder sb)
    {
        stringBuilder = sb;
        stringBuilder.AppendLine("{");
    }

    public static CodeBlock BeginMethod(MethodDeclarationSyntax method, StringBuilder sb)
    {
        sb.Append($"{method.Modifiers} {method.ReturnType} {method.Identifier}(");
        sb.AppendJoin(',', method.ParameterList.Parameters);
        sb.AppendLine(")");
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginConstructor(ConstructorDeclarationSyntax constructor, StringBuilder sb)
    {
        sb.Append($"{constructor.Modifiers} {constructor.Identifier}(");
        sb.AppendJoin(',', constructor.ParameterList.Parameters);
        sb.AppendLine(")");
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginInternalConstructor(ConstructorDeclarationSyntax constructor, StringBuilder sb)
    {
        sb.Append($"internal {constructor.Identifier}(PyObject pyObject)");
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginClass(ClassDeclarationSyntax @class, StringBuilder sb)
    {
        sb.Append($"{@class.Modifiers} class {@class.Identifier}");
        if (@class.BaseList != null && @class.BaseList.Types.Count > 0)
        {
            sb.Append(':');
            sb.AppendJoin(',', @class.BaseList.Types);
        }
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginProperty(PropertyDeclarationSyntax property, StringBuilder sb)
    {
        sb.Append($"{property.Modifiers} {property.Type} {property.Identifier}");
        return new CodeBlock(sb);
    }

    public static CodeBlock BeginGet(StringBuilder sb)
    {
        sb.Append("get");
        return new CodeBlock(sb);
    }

    public void Dispose()
    {
        stringBuilder.AppendLine("}");
    }
}