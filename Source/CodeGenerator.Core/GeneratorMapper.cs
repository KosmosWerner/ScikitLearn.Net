using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGenerator.Core;

internal class GeneratorMapper
{
    private static readonly Dictionary<string, string> nativeTypes = new()
    {
        ["True"] = "true",
        ["False"] = "false",
        ["np.float64(2.220446049250313e-16)"] = "float.Epsilon",
        ["None"] = "null",
        ["inf"] = "float.PositiveInfinity",
    };

    public static string PythonDefaultValueToCSharp(string default_param)
    {
        if (nativeTypes.TryGetValue(default_param, out string? nativeType))
            return nativeType; // value

        if (Regex.IsMatch(default_param, @"^[+-]?\d+$", RegexOptions.Compiled))
            return default_param; // int

        if (Regex.IsMatch(default_param, @"^[+-]?\d+(\.\d+)?(e[+-]?\d+)?$", RegexOptions.IgnoreCase | RegexOptions.Compiled))
            return $"{default_param}f"; // float

        if (default_param.StartsWith('\'') && default_param.EndsWith('\'') && default_param.Length > 1)
            return default_param.Replace('\'', '"'); // string

        if (default_param.StartsWith('(') && default_param.EndsWith(')') && default_param.Contains(','))
            return default_param.Replace('\'', '"'); // tuple

        if (default_param.StartsWith("&lt;") && default_param.EndsWith("&gt;"))
            return "null";
        //throw new ArgumentException($"The value \"{default_param}\" contains text wrapped in &lt; and &gt;");

        throw new ArgumentException($"The value \"{default_param}\" does not match contents of the expected formats (bool,float, etc)");
    }




    private static string[] FixReturnType(string raw_type)
    {
        bool nullable = raw_type.Contains("None", StringComparison.OrdinalIgnoreCase) ||
                        raw_type.Contains("Ignored", StringComparison.OrdinalIgnoreCase);

        var typePatterns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "True", "bool" },
            { "False", "bool" },
            { "bool", "bool" },
            { "int", "int" },
            { "float", "float" },
            { "str", "string" },
            { "{‘", "string" },
            { "{'", "string" },
            { "{\"", "string" },
            { "ndarray", "NDarray" },
            { "array", "NDarray" },
            { "shape", "NDarray" },
            { "sparce", "NDarray" },
            { "PyDict", "dict" }
        };

        var result = typePatterns
            .Where(kv => raw_type.Contains(kv.Key))
            .Select(kv => kv.Value)
            .Distinct()
            .ToList();

        if (nullable && result.Count > 1)
            throw new ArgumentException("RETORNO NULLABLE EN ATRIBUTO DE MULTIPLE TIPO");
        if (nullable && result.Count == 1) result[0] += "?";
        if (result.Count == 0) result.Add("PyObject");

        return result.ToArray();
    }

    public static string FixParamType(string raw_type, string default_value = "")
    {
        bool is_arg = string.IsNullOrEmpty(default_value);

        if (is_arg)
        {

        }
        else
        {

        }

        string clear_raw_type = Regex.Replace(raw_type, @"\(([^()]*)\)", m =>
        {
            return m.Value.Replace(",", ""); // Elimina las comas dentro de cada paréntesis
        });

        // Paso 2: Divide en base a comas o "or" fuera de los paréntesis
        var parts = Regex.Split(clear_raw_type, @"\s*,\s*|\s+or\s+");

        //Debug.WriteLine(string.Join(" ||||||| ", parts));

        if (raw_type.Contains("Ignored", StringComparison.OrdinalIgnoreCase)) return "PyObject?";

        bool nullable = raw_type.Contains("None", StringComparison.OrdinalIgnoreCase);

        bool multiple = raw_type.Contains(" or ", StringComparison.OrdinalIgnoreCase);

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
            .Where(kv => raw_type.Contains(kv.Key))
            .Select(kv => kv.Value)
            .Distinct()
            .Reverse()
            .ToList();

        if (result.Count > 1)
            if (!multiple)
                result = [result[0]];


        if (result.Count > 1)
        {
            if (nullable)
            {
                if (default_value == null)
                    throw new ArgumentException("RETORNO NULLABLE EN ATRIBUTO DE MULTIPLE TIPO");
                else
                {
                    if (result.Contains("string"))
                        if (default_value.Contains("\"") || default_value.Contains("‘") || default_value.Contains("“") || default_value.Contains("'"))
                            return "string?";
                    if (result.Contains("float"))
                        if (float.TryParse(default_value, out _))
                            return "float?";
                    if (result.Contains("int"))
                        if (int.TryParse(default_value, out _))
                            return "int?";
                    if (result.Contains("bool"))
                        if (default_value == "true" || default_value == "false")
                            return "bool?";

                    //Console.WriteLine(string.Join(", ",result));
                    return result[^1] + "?";

                }
            }
            else
            {
                if (default_value == null)
                    throw new ArgumentException($"PARAMETRO MULTITIPLO SIN EJEMPLO {string.Join(",", result)}");
                else
                {
                    if (result.Contains("string"))
                        if (default_value.Contains("\"") || default_value.Contains("‘") || default_value.Contains("'"))
                            return "string";
                    if (result.Contains("float"))
                        if (float.TryParse(default_value, out _))
                            return "float";
                    if (result.Contains("int"))
                        if (int.TryParse(default_value, out _))
                            return "int";
                    if (result.Contains("bool"))
                        if (default_value == "true" || default_value == "false")
                            return "bool";
                    //Console.WriteLine(string.Join(", ", result));

                    return result[^1];
                }

            }
        }
        if (result.Count == 1)
            if (nullable) result[0] += "?";
        if (result.Count == 0) result.Add("PyObject");

        return result[0];
    }



    public static class Attributes
    {
        public static void AssignTypes(Dictionary<string, string[]> properties, string? name, string? type)
        {
            if (name == null || type == null) return;

            properties[name] = FixReturnType(type);
        }
    }

    public static class MethodParams
    {
        public static void AssignDefaultValues(
            string? param_text,
            ref bool is_arg,
            Dictionary<string, string> method_args,
            Dictionary<string, string> method_kw)
        {
            ArgumentNullException.ThrowIfNull(param_text);

            if (param_text == "*")
            {
                is_arg = false;
                return;
            }

            if (param_text.StartsWith("**"))
            {
                method_kw["@params"] = PythonDefaultValueToCSharp("None");
                is_arg = false;
                return;
            }

            //string[] parameters = param_text.Split('=');
            // a = 'b' -> 2
            // a = 'b=c' -> 2
            // a = 'b' = c -> 3
            string[] parameters = param_text.Split('=', 2);

            if (parameters.Length == 1)
            {
                string param_name = parameters[0].Trim();

                method_args[param_name] = string.Empty;
            }
            else if (parameters.Length == 2)
            {
                //for this case ->  sample_weight: bool | None | str = '$UNCHANGED$'
                string param_name = parameters[0].Split(':')[0].Trim();
                string param_value = parameters[1].Trim();

                method_kw[param_name] = PythonDefaultValueToCSharp(param_value);

                // ????
                // if (is_arg) method_args[param_name] = PythonDefaultValueToCSharp(param_value);
                // else method_kw[param_name] = PythonDefaultValueToCSharp(param_value);
            }
            else
            {
                throw new ArgumentException($"Invalid format in parameter '{param_text}': expected at most one equal sign ('='). Number of tokens found: {parameters.Length}");
            }
        }

        public static void AssignTypes(
            string? param_name,
            string? param_content,
            Dictionary<string, string> param_args,
            Dictionary<string, string> param_kw,
            Dictionary<string, string> param_types)
        {
            if (param_name == null || param_content == null) return;

            if (param_name.StartsWith("**"))
            {
                param_types["@params"] = "PyDict?";
                return;
            }

            if (param_content.Contains("Ignored"))
            {
                param_args.Remove(param_name);
                param_kw.Remove(param_name);
                return;
            }

            if (param_args.TryGetValue(param_name, out string? value_arg))
            {
                param_types[param_name] = FixParamType(param_content, value_arg);
            }
            else if (param_kw.TryGetValue(param_name, out string? value_kw))
            {
                param_types[param_name] = FixParamType(param_content, value_kw);
            }
        }
    }
}
