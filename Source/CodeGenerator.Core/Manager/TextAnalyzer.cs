using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGenerator.Core.Manager;

public static partial class TextAnalyzer
{
    public static class Fix
    {
        private static readonly Dictionary<string, string> nativeTypes = new()
        {
            ["True"] = "true",
            ["False"] = "false",
            ["np.float64(2.220446049250313e-16)"] = "float.Epsilon",
            ["inf"] = "float.PositiveInfinity",
            ["None"] = "null",
        };

        public static string PlainText(string toFix)
        {
            var sb = new StringBuilder(toFix);

            sb.Replace("\n", "")
              .Replace("\u201C", "\"")
              .Replace("\u201D", "\"")
              .Replace("\u0027", "\"")
              .Replace("\u2018", "\"")
              .Replace("\u2019", "\"")
              .Replace("\u0026lt;", "<")
              .Replace("\u0026gt;", ">")
              .Replace("\u0026quot;", "\"");

            string result = sb.ToString();
            result = ReplaceSpacing().Replace(result, " ");

            return result;
        }

        // (null, string.Empty) null and not determinated
        // (null, string.Empty) null and not determinated
        public static (string? value, string type) TryDeduceDefaultValue(string paramDefault)
        {
            if (nativeTypes.TryGetValue(paramDefault, out string? nativeType))
            {
                if (nativeType == "true" || nativeType == "false") return (nativeType, "bool"); // value
                if (nativeType.Contains("float")) return (nativeType, "float"); // value
                if (nativeType.Contains("null")) return (null, string.Empty); // value
            }

            if (Regex.IsMatch(paramDefault, @"^[+-]?\d+$", RegexOptions.Compiled))
                return (paramDefault, "int"); // int

            if (Regex.IsMatch(paramDefault, @"^[+-]?\d+(\.\d+)?(e[+-]?\d+)?$", RegexOptions.IgnoreCase | RegexOptions.Compiled))
                return ($"{paramDefault}f", "float"); // float

            if (paramDefault.StartsWith('\"') && paramDefault.EndsWith('\"') && paramDefault.Length > 1)
                return (paramDefault, "string"); // string

            if (paramDefault.StartsWith('(') && paramDefault.EndsWith(')'))
                return (null, "PyTuple");

            if (paramDefault.StartsWith('<') && paramDefault.EndsWith('>'))
                return (null, string.Empty);

            return (null, string.Empty);

            throw new ArgumentException($"The value \"{paramDefault}\" does not match contents of the expected formats (bool,float, etc)");
        }


        public static string ParamTypeFromNonDeducible(string textFromDocumentation)
        {
            bool nullable = textFromDocumentation.Contains("None", StringComparison.OrdinalIgnoreCase);

            string content = textFromDocumentation.Split("default=", 2, StringSplitOptions.TrimEntries)[0];

            string clear_raw_type = Regex.Replace(content, @"[\(\{]([^()\{\}]*)[\)\}]", m => //delete commas in {,,} or (,,)
            {
                return m.Value.Replace(",", "").Replace(" or ", "");
            });

            var parts = Regex.Split(clear_raw_type, @"\s*,\s*|\s+or\s+");

            bool multiple = textFromDocumentation.Contains(" or ", StringComparison.OrdinalIgnoreCase);

            var typePatterns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "True", "bool" },
            { "False", "bool" },
            { "bool", "bool" },
            { "int", "int" },
            { "float", "float" },
            { "str", "string" },
            { "‘", "string" },
            { "“", "string" },
            { "{‘", "string" },
            { "{'", "string" },
            { "{\"", "string" },
            { "\"", "string" },
            { "ndarray", "NDarray" },
            { "array", "NDarray" },
            { "shape", "NDarray" },
            { "sparce", "NDarray" },
            { "PyDict", "dict" },
            { "Bunch", "dict" },
        };

            var result = typePatterns
                .Where(kv => textFromDocumentation.Contains(kv.Key))
                .Select(kv => kv.Value)
                .Distinct()
                .Reverse()
                .ToList();

            string? output;

            if (result.Count == 0) output = "PyObject";
            else if (result.Count == 1) output = result[0] += "?";
            else output = result[0] += "?";

            return output;
        }
    }

    public static class Divide
    {
        public static (string identifier, string plainName, string plainParameters) Declaration(string declaration)
        {
            Match declarationMatch = RegexDeclaration().Match(declaration);
            return (declarationMatch.Groups[1].Value,
                declarationMatch.Groups[2].Value,
                declarationMatch.Groups[3].Value);
        }

        public static (string name, string callableStaticClass) PlainName(string plainName)
        {
            string[] segments = plainName.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            string containerName = segments[^1];
            string callableStaticClass = string.Join('.', segments[..^1]);
            return (containerName, callableStaticClass);
        }

        public static string[] PlainParameters(string plainParameters)
        {
            plainParameters = plainParameters.TrimStart('(').TrimEnd(')');

            return plainParameters.Split(", ",
                StringSplitOptions.RemoveEmptyEntries |
                StringSplitOptions.TrimEntries);
        }

        public static string[] Tuple(string plainTuple)
        {
            return plainTuple.TrimStart('(').TrimEnd(')').Split(',', StringSplitOptions.TrimEntries);
        }
    }

    [GeneratedRegex(@"(\w+\s+)?([\w\.]+)(\((.*)\))?")]
    private static partial Regex RegexDeclaration();


    [GeneratedRegex(@"\s+")]
    private static partial Regex ReplaceSpacing();
}
