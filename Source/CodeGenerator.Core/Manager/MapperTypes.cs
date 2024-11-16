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
        bool isArgument = true;
        Dictionary<string, string> method_args = [];
        Dictionary<string, string> method_kw = [];

        List<(string Type, string Name, string? Value)> result = [];

        result.Add(("int", "x", string.Empty));
        result.Add(("float", "y", string.Empty));
        result.Add(("double?", "a", null));
        result.Add(("Raw", "b", "\"text\""));

        return result;
    }

    public static List<(string Type, string Name)> GetAttributes(List<string> plainAttributes)
    {
        List<(string Type, string Name)> result = [];

        result.Add(("(int,string)", "get_tuple"));
        result.Add(("ndarray", "get_array"));
        result.Add(("PyObject", "get_ob"));
        result.Add(("PyTuple", "get_t"));
        result.Add(("string", "get_name"));

        return result;
    }

    public static string GetReturn(List<string> returns)
    {
        return "string";
    }

    //public static void AssignDefaultValues(
    //       string? param_text,
    //       ref bool is_arg,
    //       Dictionary<string, string> method_args,
    //       Dictionary<string, string> method_kw)
    //{
    //    ArgumentNullException.ThrowIfNull(param_text);

    //    if (param_text == "*")
    //    {
    //        is_arg = false;
    //        return;
    //    }

    //    if (param_text.StartsWith("**"))
    //    {
    //        method_kw["@params"] = PythonDefaultValueToCSharp("None");
    //        is_arg = false;
    //        return;
    //    }

    //    //string[] parameters = param_text.Split('=');
    //    // a = 'b' -> 2
    //    // a = 'b=c' -> 2
    //    // a = 'b' = c -> 3
    //    string[] parameters = param_text.Split('=', 2);

    //    if (parameters.Length == 1)
    //    {
    //        string param_name = parameters[0].Trim();

    //        method_args[param_name] = string.Empty;
    //    }
    //    else if (parameters.Length == 2)
    //    {
    //        //for this case ->  sample_weight: bool | None | str = '$UNCHANGED$'
    //        string param_name = parameters[0].Split(':')[0].Trim();
    //        string param_value = parameters[1].Trim();

    //        method_kw[param_name] = PythonDefaultValueToCSharp(param_value);

    //        // ????
    //        // if (is_arg) method_args[param_name] = PythonDefaultValueToCSharp(param_value);
    //        // else method_kw[param_name] = PythonDefaultValueToCSharp(param_value);
    //    }
    //    else
    //    {
    //        throw new ArgumentException($"Invalid format in parameter '{param_text}': expected at most one equal sign ('='). Number of tokens found: {parameters.Length}");
    //    }
    //    }
}

