namespace CodeGenerator.Core.Manager;

public static class Tokenizer
{
    public static EntityType GetEntityType(HtmlContainer entity)
    {
        if (entity.Declaration == null) return EntityType.None;

        var (identifier, _, _) = TextAnalyzer.Divide.FromDeclaration(entity.Declaration);

        if (identifier.Contains("exception")) return EntityType.Exception;
        else
        {
            if (identifier.Contains("class"))
            {
                if (entity.ReturnsBox != null) return EntityType.Method; // classes do not return in C#
                else return EntityType.Class; // there are functions that do not return anything
            }
            else return EntityType.Method;
        }
    }

    // Value = string.empty : No default
    // Value = null : default Null
    // Value != null : default any
    public static List<(string Type, string Name, string? Value)>[] GetParameters(string[] declarationParameters, string[] documentedParameters)
    {
        // bool is_arg = true;
        Dictionary<string, string> method_args = [];
        Dictionary<string, string?> method_kw = [];
        Dictionary<string, string> param_types = [];

        List<(string Type, string Name, string? Value)> result = [];

        foreach (var declarationParameter in declarationParameters)
        {
            if (declarationParameter == "*") { continue; }
            if (declarationParameter.StartsWith("**")) { method_kw["params"] = null; continue; }
            if (declarationParameter.StartsWith("*ys")) { method_args["ys"] = string.Empty; continue; }
            if (declarationParameter.StartsWith("*arrays")) { method_args["arrays"] = string.Empty; continue; }
            if (declarationParameter.StartsWith("*steps")) { method_args["steps"] = string.Empty; continue; }
            if (declarationParameter.StartsWith("*iterables")) { method_args["iterables"] = string.Empty; continue; }
            if (declarationParameter.StartsWith("*transformers")) { method_args["transformers"] = string.Empty; continue; }

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

                var value = TypeAnalyzer.TryGetDefaultValue(paramDefault, out string type);
                method_kw[paramName] = value;

                // Save reservedNames with nullableType deducible type
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

            if (parameterName.StartsWith("**")) { param_types["params"] = "Dictionary<string, PyObject>?"; continue; }
            if (parameterName.StartsWith("*ys")) { param_types["ys"] = "NDarray[]"; continue; }
            if (parameterName.StartsWith("*arrays")) { param_types["arrays"] = "NDarray[]"; continue; }
            if (parameterName.StartsWith("*iterables")) { param_types["iterables"] = "PyObject[]"; continue; }
            if (parameterName.StartsWith("*steps")) { param_types["steps"] = "PyObject[]"; continue; }
            if (parameterName.StartsWith("*transformers")) { param_types["transformers"] = "PyObject[]"; continue; }

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
                    param_types[parameterName] = TypeAnalyzer.ParamTypeFromNonDeducible(parameterContent, value_arg == null);
                }
                else if (method_kw.TryGetValue(parameterName, out string? value_kw))
                {
                    param_types[parameterName] = TypeAnalyzer.ParamTypeFromNonDeducible(parameterContent, value_arg == null);
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

        return [result];
    }

    public static List<(string Type, string Name)> GetAttributes(List<string> plainAttributes)
    {
        List<(string Type, string Name)> result = [];

        plainAttributes = plainAttributes.Where(x => !x.StartsWith(':')).ToList();
        foreach (var item in plainAttributes)
        {
            var (name, rawType, _) = TextAnalyzer.Divide.FromDefinition(item);

            if (TypeAnalyzer.TryGetReturnType(rawType, out string? type))
            {
                result.Add((type, name));
            }
            else
            {
                result.Add(("PyObject", name));
            }
        }

        return result;
    }

    // string.empty = void
    public static string GetReturn(List<string> plainReturns)
    {
        plainReturns = plainReturns.Where(x => !x.StartsWith(':')).ToList();

        if (plainReturns.Count == 0) return string.Empty;
        if (plainReturns.Count == 1)
        {

            return GetType(plainReturns[0]);
        }
        else
        {
            var items = plainReturns.Select(x => $"{GetType(x)}?").ToArray();
            return $"({string.Join(',', items)})";
        }
    }

    private static string GetType(string plainReturn)
    {
        if (plainReturn.Contains("tuple if")) return $"PyTuple";
        if (plainReturn.Contains("self", StringComparison.OrdinalIgnoreCase)) return "this";
        if (plainReturn.Contains("None", StringComparison.OrdinalIgnoreCase))
        {
            if (TypeAnalyzer.TryGetReturnType(plainReturn, out string? nullableType))
                return nullableType + "?";
            else return string.Empty;
        }

        if (TypeAnalyzer.TryGetReturnType(plainReturn, out string? type))
            return type;
        else return "PyObject";
    }
}

