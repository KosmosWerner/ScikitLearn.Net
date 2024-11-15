using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGenerator.Core.Manager;

public static partial class RegexAnalyzer
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
    }


    public static List<string> Parameters(string parameters)
    {
        return [];///////////////////////
    }

    [GeneratedRegex(@"(\w+\s+)?([\w\.]+)(\((.*)\))?")]
    private static partial Regex RegexDeclaration();


    [GeneratedRegex(@"\s+")]
    private static partial Regex ReplaceSpacing();
}
