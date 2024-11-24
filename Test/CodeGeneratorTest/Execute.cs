using CodeGenerator.Core;
using CodeGenerator.Core.Manager;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace CodeGeneratorTest
{
    public class Execute
    {
        private readonly Lazy<Task<Dictionary<string, List<Uri>>>> _lazyUrls;

        public Execute()
        {
            _lazyUrls = new(() => UriSearcher.Search("https://scikit-learn.org/stable/api/sklearn.html"));
        }

        [Fact]
        public async Task RunPreGenerator()
        {
            var source = await _lazyUrls.Value;

            await PreGenerator.Run(source);
        }

        [Fact]
        public static void RunGenerator()
        {
            Generator.Run();
        }

        [Fact]
        public void LogAll()
        {
            HashSet<string> attributes = [];
            HashSet<string> returns = [];

            string inputDirectoryPath = Path.Combine(Path.GetFullPath("."), "PreGenerated");
            string outpuDirectoryPath = Path.Combine(Path.GetFullPath("."), "Logs");
            Directory.CreateDirectory(outpuDirectoryPath);

            string[] preGeneratedFiles = Directory.GetFiles(inputDirectoryPath, "*.json");
            foreach (var preGeneratedFile in preGeneratedFiles)
            {
                string serialized = File.ReadAllText(preGeneratedFile);

                var nodeContainers = JsonSerializer.Deserialize<List<EntityContainer>>(serialized);
                if (nodeContainers == null) continue;

                var sortedContainers = nodeContainers.OrderBy(container =>
                {
                    var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(container.Declaration);
                    var (_, callableStaticClass) = TextAnalyzer.Divide.FromFullName(fullName);
                    return callableStaticClass;
                });

                foreach (var container in sortedContainers)
                {
                    switch (container.NodeType)
                    {
                        case EntityType.Class:
                            foreach (var item in container.Attributes)
                            {
                                var (name, rawType, rawDefault) = TextAnalyzer.Divide.FromDefinition(item);
                                string nullable = rawType.Contains("None", StringComparison.OrdinalIgnoreCase) ? "?" : "";
                                if (rawType.Contains("array of shape") || rawType.Contains("array, shape") || rawType == "array" || rawType == "ndarray")
                                {
                                    attributes.Add($"NDarray{nullable}: {name}\t\t\t{rawType}");
                                }
                                else if (rawType.Contains("array of float") || rawType.Contains("sparse matrix of shape") || rawType.Contains("{ndarray, sparse matrix} of shape"))
                                {
                                    attributes.Add($"NDarray{nullable}: {name}\t\t\t{rawType}");
                                }
                                else if (rawType.Contains("array-like"))
                                {
                                    attributes.Add($"_ARRAYLIKE{nullable}: {name}\t\t\t{rawType}");
                                }
                                else if (rawType.Contains("list"))
                                {
                                    attributes.Add($"_LIST{nullable}: {name}\t\t\t{rawType}");
                                }
                                else if (rawType.Contains("str")) // ok
                                {
                                    attributes.Add($"string{nullable}: {name}\t\t\t{rawType}");
                                }
                                else if (rawType.Contains("pair of"))
                                {
                                    if (rawType.Contains("float"))
                                        attributes.Add($"Tuple<float, float>{nullable}: {name}\t\t\t{rawType}");
                                    else if (rawType.Contains("int"))
                                        attributes.Add($"Tuple<int, int>{nullable}: {name}\t\t\t{rawType}");
                                    else
                                        attributes.Add($"PyTuple{nullable}: {name}\t\t\t{rawType}");
                                }
                                else if (rawType.Contains("tuple"))
                                {
                                   
                                        attributes.Add($"TUPLE{nullable}: {name}\t\t\t{rawType}");
                                }
                                else if (rawType.Contains("float"))
                                {
                                    attributes.Add($"float{nullable}: {name}\t\t\t{rawType}");
                                }
                                else if (rawType.Contains("int"))
                                {
                                    attributes.Add($"int{nullable}: {name}\t\t\t{rawType}");

                                }
                                else if (rawType.Contains("bool")) // ok
                                {
                                    attributes.Add($"bool{nullable}: {name}\t\t\t{rawType}");
                                }
                                else
                                {
                                    attributes.Add($"PyObject{nullable}: {name}\t\t\t{rawType}");
                                }
                            }

                            //foreach (var method in container.Methods)
                            //{
                            //    foreach (var item in method.Returns)
                            //    {
                            //        if (item.Contains("self") || item.Contains("None")) continue;
                            //        var (name, rawType, rawDefault) = TextAnalyzer.Divide.FromDefinition(item);
                            //        returns.Add(rawType);
                            //    }
                            //}

                            break;
                        case EntityType.Method:
                            //foreach (var item in container.Returns)
                            //{
                            //    if (item.Contains("self") || item.Contains("None")) continue;
                            //    var (name, rawType, rawDefault) = TextAnalyzer.Divide.FromDefinition(item);
                            //    returns.Add(rawType);
                            //}

                            break;
                        case EntityType.Exception:
                        case EntityType.None:
                        default: break;
                    }
                }
            }

            File.WriteAllLines(Path.Combine(outpuDirectoryPath, "attributes.txt"), attributes.OrderBy(x => x));

        }
    }
}
