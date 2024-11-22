using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGenerator.Core.Manager
{
    public static partial class TypeAnalyzer
    {
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

        // (null, string.Empty) null and not determinated
        public static string? TryGetDefaultValue(string paramDefault, out string type)
        {
            type = string.Empty;

            if (valueEquivalences.TryGetValue(paramDefault, out string? csharpValue))
            {
                if (csharpValue == "true" || csharpValue == "false")
                { type = "bool"; return csharpValue; }

                if (csharpValue.Contains("float"))
                { type = "float"; return csharpValue; }

                if (csharpValue.Contains("null"))
                { type = string.Empty; return null; }
            }

            if (RegexIsInteger().IsMatch(paramDefault))
            { type = "int"; return paramDefault; }

            if (RegexIsFloat().IsMatch(paramDefault))
            { type = "float"; return $"{paramDefault}f"; }

            if (paramDefault.StartsWith('\"') && paramDefault.EndsWith('\"') && paramDefault.Length > 1)
            { type = "string"; return paramDefault; }

            if (paramDefault.StartsWith('(') && paramDefault.EndsWith(')'))
            { type = "PyTuple?"; return null; }

            if (paramDefault.StartsWith('<') && paramDefault.EndsWith('>'))
            { type = string.Empty; return null; }

            return null;

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

        [GeneratedRegex(@"^[+-]?\d+(\.\d+)?(e[+-]?\d+)?$", RegexOptions.IgnoreCase | RegexOptions.Compiled)]
        private static partial Regex RegexIsFloat();
    }
}
