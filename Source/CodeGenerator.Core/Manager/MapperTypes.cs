using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeGenerator.Core.Manager;

public static class MapperTypes
{
    public static NodeType GetEntityType(HtmlContainer entity)
    {
        if (entity.Declaration == null) return NodeType.None;

        var (identifier, _, _) = TextAnalyzer.Divide.Declaration(entity.Declaration);

        if (identifier.Contains("exception")) return NodeType.Exception;
        else
        {
            if (identifier.Contains("class"))
            {
                if (entity.ReturnsBox != null) return NodeType.Method; // classes do not return in C#
                else return NodeType.Class; // there are functions that do not return anything
            }
            else return NodeType.Method;
        }
    }

    // Value = string.empty : No default
    // Value = null : default Null
    // Value != null : default any
    public static List<(string Type, string Name, string? Value)> GetParameters(string[] declarationParameters, string[] documentedParameters)
    {
        // bool is_arg = true;
        Dictionary<string, string> method_args = [];
        Dictionary<string, string?> method_kw = [];
        Dictionary<string, string> param_types = [];

        List<(string Type, string Name, string? Value)> result = [];

        foreach (var declarationParameter in declarationParameters)
        {
            if (declarationParameter == "*") { continue; }
            if (declarationParameter.StartsWith("**")) { method_kw["@params"] = null; continue; }

            string[] parts = declarationParameter.Split('=', 2, StringSplitOptions.TrimEntries);

            if (parts.Length == 1)
            {
                // Only args
                string paramName = parts[0].Split(':', StringSplitOptions.TrimEntries)[0]; //sample_weight: bool | None | str = '$UNCHANGED$'
                method_args[paramName] = string.Empty;
            }
            else if (parts.Length == 2)
            {
                // Only keywords
                string paramName = parts[0].Split(':', StringSplitOptions.TrimEntries)[0]; //sample_weight: bool | None | str = '$UNCHANGED$'
                string paramDefault = parts[1];

                var (value, type) = TextAnalyzer.Fix.TryDeduceDefaultValue(paramDefault);
                method_kw[paramName] = value;

                // Save names with a deducible type
                if (type != string.Empty) param_types[paramName] = type;
            }
            else
            {
                throw new ArgumentException($"Invalid format in parts '{declarationParameter}': expected at most one equal sign ('='). Number of tokens found: {declarationParameter.Length}");
            }
        }

        foreach (var documentedParameter in documentedParameters)
        {
            string[] parts = documentedParameter.Split(':', 2, StringSplitOptions.TrimEntries);
            string parameterName = parts[0];
            if (parts.Length < 2) continue;
            string parameterContent = parts[1];

            if (parameterName.StartsWith("**")) { param_types["@params"] = "Dictionary<string, PyObject>?"; continue; }

            if (parameterContent.Contains("Ignored"))
            {
                method_args.Remove(parameterName);
                method_kw.Remove(parameterName);
                continue;
            }

            if (param_types.TryGetValue(parameterName, out string? type))
            {
                if (documentedParameter.Contains("None")) param_types[parameterName] = type + "?";
            }
            else
            {
                if (method_args.TryGetValue(parameterName, out string? value_arg))
                {
                    param_types[parameterName] = TextAnalyzer.Fix.ParamTypeFromNonDeducible(parameterContent);
                }
                else if (method_kw.TryGetValue(parameterName, out string? value_kw))
                {
                    param_types[parameterName] = TextAnalyzer.Fix.ParamTypeFromNonDeducible(parameterContent);
                }
            }
        }

        foreach (var item in method_args)
        {
            if (param_types.TryGetValue(item.Key, out string? type))
            {
                result.Add((type, item.Key, item.Value));
            }
        }

        foreach (var item in method_kw)
        {
            if (param_types.TryGetValue(item.Key, out string? type))
            {
                result.Add((type, item.Key, item.Value));
            }
        }

        return result;
    }

    public static List<(string Type, string Name)> GetAttributes(List<string> plainAttributes)
    {
        List<(string Type, string Name)> result = [];

        result.Add(("(int,string)", "get_tuple"));
        result.Add(("NDarray", "get_array"));
        result.Add(("PyObject", "get_ob"));
        result.Add(("PyTuple", "get_t"));
        result.Add(("string", "get_name"));

        return result;
    }

    public static string GetReturn(List<string> plainReturns)
    {


        return "(int,NDarray)";
    }


}

