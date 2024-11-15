using HtmlAgilityPack;
using CodeGenerator.Core.Utils;
using System.Diagnostics;
using System.Text.RegularExpressions;
using CodeGenerator.Core.Manager;
using System.Text.Json;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CodeGenerator.Core;

public static class Generator
{
    public static async Task CreatePreGenerated(Dictionary<string, List<Uri>> source, string baseDirectory = ".")
    {
        var serializerOptions = new JsonSerializerOptions { WriteIndented = true };

        foreach (var (namespaceName, urls) in source)
        {
            var dummyContainers = new List<DummyContainer>();
            foreach (var url in urls)
            {
                using var httpClient = new HttpClient();

                try
                {
                    var pageContent = await httpClient.GetStringAsync(url);
                    var htmlContainer = new HtmlContainer(pageContent);
                    ArgumentNullException.ThrowIfNull(htmlContainer.ContentNode);

                    var declaration = htmlContainer.Declaration;
                    if (declaration == null)
                        continue;

                    dummyContainers.Add(new DummyContainer(htmlContainer));
                }
                catch (HttpRequestException exception)
                {
                    Console.WriteLine($"Error fetching URL: {exception.Message}");
                }
            }

            var serializedData = JsonSerializer.Serialize(dummyContainers, serializerOptions);
            var preGeneratedDirectory = Path.Combine(Path.GetFullPath(baseDirectory), "PreGenerated");
            var outputFilePath = Path.Combine(preGeneratedDirectory, $"{namespaceName}.json");

            Directory.CreateDirectory(preGeneratedDirectory);
            File.WriteAllText(outputFilePath, serializedData);
        }
    }

    public static void CreateGenerated(string baseDirectory = ".")
    {
        var preGeneratedDirectory = Path.Combine(Path.GetFullPath(baseDirectory), "PreGenerated");
        var generatedDirectory = Path.Combine(Path.GetFullPath(baseDirectory), "Generated");

        var preGeneratedFilePaths = Directory.GetFiles(preGeneratedDirectory, "*.json");

        foreach (var preGeneratedFilePath in preGeneratedFilePaths)
        {
            var serializedData = File.ReadAllText(preGeneratedFilePath);

            var dummyContainers = JsonSerializer.Deserialize<List<DummyContainer>>(serializedData);
            if (dummyContainers == null)
                continue;

            var sortedContainers = dummyContainers.OrderBy(dummy =>
            {
                var (_, fullName, _) = RegexAnalyzer.DivideDeclaration(dummy.Declaration);
                var namespaceParts = fullName.Split('.');
                return string.Join(".", namespaceParts[..^1]);
            });

            var fileName = Path.GetFileNameWithoutExtension(preGeneratedFilePath);
            CodeBuilder.Build(generatedDirectory, fileName, sortedContainers);
        }
    }

    private static void GenerateClass(GeneratorWriter generatorWriter, HtmlNode nodeContent, HtmlNode nodeDescription)
    {
        Trace.WriteLine("->Class");
        var className = nodeDescription.SelectSingleNode(".//*[contains(@class, 'sig-name descname')]")?.InnerText;
        ArgumentNullException.ThrowIfNull(className);

        var nodeParamsAndAttributes = nodeContent.SelectSingleNode(".//*[contains(@class, 'field-list') and not(ancestor::*/ancestor::*[contains(@class, 'py method')])]");
        var nodeMethodCollection = nodeContent.SelectNodes(".//*[contains(@class, 'py method')]");

        generatorWriter.PrintStartClass(className);

        #region Constructor

        #region DefaultParams
        Dictionary<string, string> ctor_args = [];
        Dictionary<string, string> ctor_kw = [];
        Dictionary<string, string> ctor_types = [];
        bool ctor_is_arg = true;

        var nodeCtorParams = nodeDescription.SelectNodes(".//*[contains(@class, 'sig-param')]");
        if (nodeCtorParams != null)
        {
            foreach (var nodeParam in nodeCtorParams)
            {
                GeneratorMapper.MethodParams
                    .AssignDefaultValues(nodeParam.InnerText, ref ctor_is_arg, ctor_args, ctor_kw);
            }
        }
        #endregion

        #region MatchParamsTypes
        if (nodeParamsAndAttributes == null)
        {
            generatorWriter.PrintConstructor(className, ctor_args, ctor_kw, ctor_types);
        }
        else
        {
            var nodeTypesSection = nodeParamsAndAttributes.SelectNodes(".//*[contains(@class, 'field-odd')]");
            if (nodeTypesSection != null)
            {
                // Check Header
                if (nodeTypesSection[0].InnerText.Contains("Parameter"))
                {
                    // Iterate ContentNode
                    var _param_types = nodeTypesSection[1].SelectNodes(".//dt");
                    if (_param_types != null)
                    {
                        foreach (var item in _param_types)
                        {
                            var param_name = item.SelectSingleNode(".//strong")?.InnerText;
                            var param_type = item.SelectSingleNode(".//span")?.InnerText;

                            GeneratorMapper.MethodParams.AssignTypes(
                                param_name,
                                param_type,
                                ctor_args,
                                ctor_kw,
                                ctor_types);
                        }
                    }

                    generatorWriter.PrintConstructor(className, ctor_args, ctor_kw, ctor_types);
                }
                else
                {
                    throw new ArgumentException($"Constructor: field-odd isn't Parameters: {nodeTypesSection[0].InnerText}\");");
                }
            }
        }
        #endregion

        #endregion

        #region Attributes
        if (nodeParamsAndAttributes != null)
        {
            var _attributes_section = nodeParamsAndAttributes.SelectNodes(".//*[contains(@class, 'field-even')]");
            if (_attributes_section != null)
            {
                Dictionary<string, string[]> class_attributes = [];
                // Check Header
                if (_attributes_section[0].InnerText.Contains("Attribute"))
                {
                    // Iterate ContentNode
                    var _attribute = _attributes_section[1].SelectNodes(".//dt");
                    if (_attribute != null)
                    {
                        foreach (var _property in _attribute)
                        {
                            var property_name = _property.SelectSingleNode(".//strong")?.InnerText;
                            var property_type = _property.SelectSingleNode(".//span")?.InnerText;

                            GeneratorMapper.Attributes
                                .AssignTypes(class_attributes, property_name, property_type);
                        }
                    }

                    generatorWriter.PrintAttributes(class_attributes);
                }
                else
                {
                    throw new ArgumentException($"Class: field-even isn't Attribute: {_attributes_section[0].InnerText}\");");
                }
            }
        }
        #endregion

        #region Methods
        if (nodeMethodCollection != null)
        {
            foreach (var _method_container in nodeMethodCollection)
            {
                var _declaration = _method_container.SelectSingleNode(".//*[contains(@class, 'sig sig-object py')]") ??
                    throw new ArgumentException("Documentation: Method without declaration");

                var method_name = (_declaration.SelectSingleNode(".//*[contains(@class, 'sig-name descname')]")?.InnerText) ??
                    throw new ArgumentException("Documentation: Method without name");

                if (method_name.Contains("__")) throw new Exception("fsdafsadfasdfsadfasdfasdf");

                #region DefaultParams
                Dictionary<string, string> method_args = [];
                Dictionary<string, string> method_kw = [];
                Dictionary<string, string> method_types = [];
                bool method_is_arg = true;

                var _method_params = _declaration.SelectNodes(".//*[contains(@class, 'sig-param')]");
                if (_method_params != null)
                {
                    foreach (var _param in _method_params)
                    {
                        GeneratorMapper.MethodParams
                            .AssignDefaultValues(_param.InnerText, ref method_is_arg, method_args, method_kw);
                    }
                }
                #endregion

                //// Args Types ////
                var _odd_section = _method_container.SelectNodes(".//*[contains(@class, 'field-odd')]");
                var _even_section = _method_container.SelectNodes(".//*[contains(@class, 'field-even')]");

                if (_odd_section == null && _even_section == null)
                {
                    continue;  // Method with NotImplementedException
                }

                #region OnlyReturn
                HtmlNodeCollection? _params_section = null;
                HtmlNodeCollection? _return_section = null;

                if (_odd_section != null && _even_section == null)
                {
                    if (_odd_section[0].InnerText.Contains("Return"))
                        _return_section = _odd_section;
                    else throw new ArgumentException("Method: no return");
                }
                else
                {
                    _params_section = _odd_section;
                    _return_section = _even_section;
                }
                #endregion

                #region MatchParamsTypes
                if (_params_section != null)
                {
                    if (!_params_section[0].InnerText.Contains("Parameter"))
                        throw new ArgumentException($"Method field-odd isn't Parameters: {_params_section[0].InnerText}");

                    var _param_info_types = _params_section[1].SelectNodes(".//dt");
                    if (_param_info_types != null)
                    {
                        foreach (var item in _param_info_types)
                        {
                            var param_name = item.SelectSingleNode(".//strong")?.InnerText;
                            var param_type = item.SelectSingleNode(".//span")?.InnerText;

                            GeneratorMapper.MethodParams.AssignTypes(
                                param_name,
                                param_type,
                                method_args,
                                method_kw,
                                method_types);
                        }
                    }
                }
                #endregion



                //// Return Type ////
                if (_return_section == null)
                    throw new ArgumentException("Method has no return type section.");

                var _return_info_type = _return_section[1].SelectSingleNode(".//dt");
                if (_return_info_type != null)
                {
                    var return_name = _return_info_type.SelectSingleNode(".//strong")?.InnerText;
                    var return_type = _return_info_type.SelectSingleNode(".//span")?.InnerText;

                    if (return_name == null && return_type == null)
                    {
                        // only _return_info_type.InnerText

                        if (_return_info_type.InnerText.Contains("self"))
                        {
                            generatorWriter.PrintMethods(method_name, method_args, method_kw, method_types, className, self: true);
                        }
                        else if (_return_info_type.InnerText.Contains('_'))
                        {
                            generatorWriter.PrintMethods(method_name, method_args, method_kw, method_types, GeneratorMapper.FixParamType(_return_info_type.InnerText));
                        }
                        else
                            throw new ArgumentException($"Unknown return type: {_return_info_type.InnerText}");
                    }
                    else
                    {
                        if (return_name == "self")
                        {
                            generatorWriter.PrintMethods(method_name, method_args, method_kw, method_types, className, self: true);
                        }
                        else if (return_type != null)
                        {
                            generatorWriter.PrintMethods(method_name, method_args, method_kw, method_types, GeneratorMapper.FixParamType(return_type));
                        }
                        else
                        {
                            throw new ArgumentException("Unknown return type with name.");
                        }
                    }

                }
            }
        }
        #endregion

        generatorWriter.PrintEndClass();
    }
}
