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

        private static readonly Dictionary<string, string> valueEquivalences = new()
        {
            ["True"] = "true",
            ["False"] = "false",
            ["None"] = "null",
            ["np.float64(2.220446049250313e-16)"] = "float.Epsilon",
            ["inf"] = "float.PositiveInfinity",
        };

        public static readonly Dictionary<string, string> typeEquivalences = new()
        {
            ["object"] = "PyObject",
            ["Bunch"] = "PyDict",
            ["dict"] = "PyDict",
            ["ndarray"] = "NDarray",
            ["list of shape"] = "NDarray",
            ["of shape"] = "NDarray",
            ["array"] = "NDarray",
            ["list of"] = "PyTuple",
            ["str"] = "string",
            ["float"] = "float",
            ["int"] = "int",
            ["bool"] = "bool",
            ["True"] = "bool",
            ["False"] = "bool",
            ["tuple"] = "PyTuple",
        };

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

        // (null, string.Empty) null and not determinated
        public static (string? value, string type) TryGetDefaultValue(string paramDefault)
        {
            if (valueEquivalences.TryGetValue(paramDefault, out string? nativeType))
            {
                if (nativeType == "true" || nativeType == "false") return (nativeType, "bool"); // value
                if (nativeType.Contains("float")) return (nativeType, "float"); // value
                if (nativeType.Contains("null")) return (null, string.Empty); // value
            }

            if (RegexIsInteger().IsMatch(paramDefault))
                return (paramDefault, "int");

            if (RegexIsFloat().IsMatch(paramDefault))
                return ($"{paramDefault}f", "float");

            if (paramDefault.StartsWith('\"') && paramDefault.EndsWith('\"') && paramDefault.Length > 1)
                return (paramDefault, "string"); // string

            if (paramDefault.StartsWith('(') && paramDefault.EndsWith(')'))
                return (null, "PyTuple?");

            if (paramDefault.StartsWith('<') && paramDefault.EndsWith('>'))
                return (null, string.Empty);

            return (null, string.Empty);

            throw new ArgumentException($"The value \"{paramDefault}\" does not match contents of the expected formats (bool,float, etc)");
        }


        public static string ParamTypeFromNonDeducible(string textFromDocumentation, bool storesIsNull)
        {
            bool nullable = textFromDocumentation.Contains("None", StringComparison.OrdinalIgnoreCase);
            nullable = storesIsNull;

            string content = textFromDocumentation.Split("default=", 2, StringSplitOptions.TrimEntries)[0];

            string clear_raw_type = Regex.Replace(content, @"[\(\{]([^()\{\}]*)[\)\}]", m => //delete commas in {,,} or (,,)
            {
                return m.Value.Replace(",", "").Replace(" or ", "");
            });

            var parts = Regex.Split(clear_raw_type, @"\s*,\s*|\s+or\s+");

            bool multiple = textFromDocumentation.Contains(" or ", StringComparison.OrdinalIgnoreCase);

            var result = typeEquivalences
                .Where(kv => textFromDocumentation.Contains(kv.Key))
                .Select(kv => kv.Value)
                .Distinct()
                .ToList();

            string? output;

            if (result.Count == 0) output = nullable ? "PyObject?" : "PyObject";
            else if (result.Count == 1) output = nullable ? result[0] += "?" : result[0];
            else output = nullable ? result[0] += "?" : result[0];

            return output;
        }

        public static string Reserved(string name)
        {
            string[] parts = name.Split('.')
                .Select(x => (reservedNames.Contains(x)) ? $"@{x}" : x)
                .ToArray();

            return string.Join('.', parts);
        }

        public static bool TryGetReturnType(string plainReturn, out string? type)
        {
            var match = typeEquivalences
                .FirstOrDefault(kv => plainReturn.Contains(kv.Key, StringComparison.OrdinalIgnoreCase));

            if (string.IsNullOrEmpty(match.Key))
            {
                type = null;
                return false;
            }

            if (match.Key.Equals("ndarray", StringComparison.OrdinalIgnoreCase))
            {
                type = "NDarray";
                if (plainReturn.Contains("dtype=np.int64"))
                {
                    type = "NDarray<long>";
                }
                else if (plainReturn.Contains("dtype=np.intp"))
                {
                    type = IntPtr.Size == 8 ? "NDarray<long>" : "NDarray<int>";
                }
                return true;
            }

            type = match.Value;
            return true;
        }

        [GeneratedRegex(@"^[+-]?\d+$", RegexOptions.Compiled)]
        private static partial Regex RegexIsInteger();

        [GeneratedRegex(@"^[+-]?\d+(\.\d+)?(e[+-]?\d+)?$", RegexOptions.IgnoreCase | RegexOptions.Compiled, "es-PE")]
        private static partial Regex RegexIsFloat();

        [GeneratedRegex(@"\s+", RegexOptions.Compiled)]
        private static partial Regex RegexMultipleSpacing();
    }


    public static partial class Divide
    {
        public static (string identifier, string plainName, string plainParameters) Declaration(string declaration)
        {
            Match declarationMatch = RegexDeclarationParts().Match(declaration);
            return (declarationMatch.Groups[1].Value,
                declarationMatch.Groups[2].Value,
                declarationMatch.Groups[3].Value);
        }

        public static (string name, string callableStaticClass) FullName(string plainName)
        {
            string[] segments = plainName.Split('.',
                StringSplitOptions.RemoveEmptyEntries |
                StringSplitOptions.TrimEntries);
            string containerName = segments[^1];
            string callableStaticClass = string.Join('.', segments[..^1]);
            return (containerName, callableStaticClass);
        }

        public static (string name, string rawType, string rawDefault) Definition(string rawDefinition)
        {
            string[] segments = rawDefinition.Split(':', 2,
                StringSplitOptions.RemoveEmptyEntries |
                StringSplitOptions.TrimEntries);

            string[] segmentsType = rawDefinition.Split(", default=", 2,
                StringSplitOptions.RemoveEmptyEntries |
                StringSplitOptions.TrimEntries);

            return (segments[0], segmentsType[0], segmentsType.Length > 1 ? segmentsType[0] : string.Empty);
        }

        public static string[] PlainParameters(string plainParameters)
        {
            plainParameters = plainParameters.TrimStart('(').TrimEnd(')');

            return plainParameters.Split(", ",
                StringSplitOptions.RemoveEmptyEntries |
                StringSplitOptions.TrimEntries);
        }

        public static string[] PlainTuple(string plainTuple)
        {
            plainTuple = plainTuple.TrimStart('(').TrimEnd(')');

            return plainTuple.Split(',',
                StringSplitOptions.TrimEntries);
        }



        [GeneratedRegex(@"(\w+\s+)?([\w\.]+)(\((.*)\))?", RegexOptions.Compiled)]
        private static partial Regex RegexDeclarationParts();
    }
}
