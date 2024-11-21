using CodeGenerator.Core.Manager;
using System.Text.Json;

namespace CodeGenerator.Core;

public static class Generator
{
    public static void Run(string baseDirectory = ".")
    {
        string inputDirectoryPath = Path.Combine(Path.GetFullPath(baseDirectory), "PreGenerated");
        string outpuDirectoryPath = Path.Combine(Path.GetFullPath(baseDirectory), "Generated");

        string[] preGeneratedFiles = Directory.GetFiles(inputDirectoryPath, "*.json");

        foreach (var preGeneratedFile in preGeneratedFiles)
        {
            string serialized = File.ReadAllText(preGeneratedFile);

            var nodeContainers = JsonSerializer.Deserialize<List<EntityContainer>>(serialized);
            if (nodeContainers == null) continue;

            var sortedContainers = nodeContainers.OrderBy(container =>
            {
                var (_, fullName, _) = TextAnalyzer.Divide.FromDeclaration(container.Declaration);
                var namespaceParts = fullName.Split('.');
                return string.Join(".", namespaceParts[..^1]);
            });

            string fileName = Path.GetFileNameWithoutExtension(preGeneratedFile);
            CodeBuilder.Build(outpuDirectoryPath, fileName, sortedContainers);
        }
    }
}
