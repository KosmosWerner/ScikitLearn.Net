using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using CodeGenerator.Core.Manager;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CSharp;
using System.Text.Json;
using System.Linq;
using CodeGenerator.Core;

namespace CodeGeneratorTest
{
    public class TestCodeGenerator
    {
        [Fact]
        public void RunGenerator()
        {
            Generator.Run();
        }

        [Fact]
        public void ValidateNamespacesInPreGeneratedFiles()
        {
            var preGeneratedPath = Path.Combine(Path.GetFullPath("."), "PreGenerated");
            var preGeneratedFiles = Directory.GetFiles(preGeneratedPath, "*.json");

            foreach (var filePath in preGeneratedFiles)
            {
                var jsonContent = File.ReadAllText(filePath);
                var dummyContainers = JsonSerializer.Deserialize<List<EntityContainer>>(jsonContent);

                if (dummyContainers == null)
                    continue;

                var sortedDummyContainers = dummyContainers.OrderBy(dummy =>
                {
                    var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(dummy.Declaration);
                    var nameSegments = fullName.Split('.');
                    var namespaceOnly = string.Join(".", nameSegments[..^1]);
                    return namespaceOnly;
                });

                Console.WriteLine($">> {filePath}");

                foreach (var dummy in sortedDummyContainers)
                {
                    var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(dummy.Declaration);

                    var nameSegments = fullName.Split('.');
                    var namespaceOnly = string.Join(".", nameSegments[..^1]);

                    Console.WriteLine(namespaceOnly);
                }
            }
        }

        [Fact]
        public void ValidateUniqueNamespacesInPreGeneratedFiles()
        {
            var preGeneratedPath = Path.Combine(Path.GetFullPath("."), "PreGenerated");
            var preGeneratedFiles = Directory.GetFiles(preGeneratedPath, "*.json");

            foreach (var filePath in preGeneratedFiles)
            {
                var jsonContent = File.ReadAllText(filePath);
                var dummyContainers = JsonSerializer.Deserialize<List<EntityContainer>>(jsonContent);

                if (dummyContainers == null)
                    continue;

                var sortedDummyContainers = dummyContainers.OrderBy(dummy =>
                {
                    var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(dummy.Declaration);
                    var nameSegments = fullName.Split('.');
                    var namespaceOnly = string.Join(".", nameSegments[..^1]);
                    return namespaceOnly;
                });

                var uniqueStaticClasses = sortedDummyContainers
                    .Select(dummy =>
                    {
                        var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(dummy.Declaration);
                        var namespaceParts = fullName.Split('.');
                        return string.Join(".", namespaceParts[..^1]);
                    })
                    .Distinct();

                Console.WriteLine($">> {filePath}");

                foreach (var uniqueNamespace in uniqueStaticClasses)
                {
                    Console.WriteLine(uniqueNamespace);
                }
            }
        }
    }
}
