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
