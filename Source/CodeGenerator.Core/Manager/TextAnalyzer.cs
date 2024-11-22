using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeGenerator.Core.Manager;

public static partial class TextAnalyzer
{
    public static partial class Fix
    {
        private static readonly HashSet<string> reservedNames = new(
        [
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
            "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
            "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
            "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is",
            "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override",
            "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed",
            "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw",
            "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using",
            "virtual", "void", "volatile", "while",
        ]);

        public static string RawText(string rawText)
        {
            StringBuilder stringBuilder = new(rawText);

            stringBuilder.Replace("\n", "")
              .Replace("\u201C", "\"")
              .Replace("\u201D", "\"")
              .Replace("\u0027", "\"")
              .Replace("\u2018", "\"")
              .Replace("\u2019", "\"")
              .Replace("\u0026lt;", "<")
              .Replace("\u0026gt;", ">")
              .Replace("\u0026quot;", "\"");

            string result = stringBuilder.ToString();
            result = RegexMultipleSpacing().Replace(result, " ");

            return result;
        }

        public static string Reserved(string nameOrFullName)
        {
            string[] parts = nameOrFullName.Split('.')
                .Select(x => (reservedNames.Contains(x)) ? $"@{x}" : x)
                .ToArray();

            return string.Join('.', parts);
        }

        [GeneratedRegex(@"\s+", RegexOptions.Compiled)]
        private static partial Regex RegexMultipleSpacing();
    }

    public static partial class Divide
    {
        public static (string identifier, string fullName, string rawParameters) FromDeclaration(string declaration)
        {
            Match declarationMatch = RegexDeclarationParts().Match(declaration);
            return (declarationMatch.Groups["id"].Value,
                declarationMatch.Groups["name"].Value,
                declarationMatch.Groups["params"].Value);
        }

        public static (string name, string callableStaticClass) FromFullName(string plainName)
        {
            string[] segments = plainName.Split('.',
                StringSplitOptions.RemoveEmptyEntries |
                StringSplitOptions.TrimEntries);
            string containerName = segments[^1];
            string callableStaticClass = string.Join('.', segments[..^1]);
            return (containerName, callableStaticClass);
        }

        public static (string name, string rawType, string rawDefault) FromDefinition(string rawDefinition)
        {
            Match definitionMatch = RegexDefinitionParts().Match(rawDefinition);
            return (definitionMatch.Groups["name"].Value,
                definitionMatch.Groups["raw"].Value,
                definitionMatch.Groups["default"].Value);
        }

        public static string[] FromRawParameters(string rawParameters)
        {
            var parametersMatch = RegexParametersParts().Split(rawParameters);
            return parametersMatch
                .Where(part => !string.IsNullOrWhiteSpace(part))
                .ToArray();
        }

        public static string[] FromRawTuple(string plainTuple)
        {
            plainTuple = plainTuple.TrimStart('(').TrimEnd(')');

            return plainTuple.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        }


        [GeneratedRegex(@"(?:(?<id>\w+)\s+)?(?<name>[\w\.]+)(?:\((?<params>.*)\))?", RegexOptions.Compiled)]
        private static partial Regex RegexDeclarationParts();

        [GeneratedRegex(@"(?<name>.*?)(?:\s*:\s*(?<raw>.*?)(?:\s*,\s*default=\s*(?<default>.*))?)?$", RegexOptions.Compiled)]
        private static partial Regex RegexDefinitionParts();

        [GeneratedRegex(@",\s*(?![^()\[\]{}]*[)\]}])", RegexOptions.Compiled)]
        private static partial Regex RegexParametersParts();
    }
}
