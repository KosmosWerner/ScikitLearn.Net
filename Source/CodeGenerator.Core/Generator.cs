using CodeGenerator.Core.Manager;
using System.Text.Json;

namespace CodeGenerator.Core;

public static class Generator
{
    public static async Task CreatePreGenerated(Dictionary<string, List<Uri>> source, string baseDirectory = ".")
    {
        JsonSerializerOptions serializerOptions = new() { WriteIndented = true };

        foreach (var (fileName, urls) in source)
        {
            List<NodeContainer> nodeContainers = [];

            foreach (var url in urls)
            {
                using HttpClient httpClient = new();

                try
                {
                    string pageContent = await httpClient.GetStringAsync(url);

                    HtmlContainer htmlContainer = new(pageContent);
                    ArgumentNullException.ThrowIfNull(htmlContainer.ContentNode);

                    string? declaration = htmlContainer.Declaration;
                    if (declaration == null) continue;

                    nodeContainers.Add(new NodeContainer(htmlContainer));
                }
                catch (HttpRequestException exception)
                {
                    Console.WriteLine($"Error fetching URL: {exception.Message}");
                }
            }

            string serialized = JsonSerializer.Serialize(nodeContainers, serializerOptions);

            string outputDirectoryPath = Path.Combine(Path.GetFullPath(baseDirectory), "PreGenerated");
            Directory.CreateDirectory(outputDirectoryPath);

            string outputFilePath = Path.Combine(outputDirectoryPath, $"{fileName}.json");
            File.WriteAllText(outputFilePath, serialized);
        }
    }

    public static void CreateGenerated(string baseDirectory = ".")
    {
        string inputDirectoryPath = Path.Combine(Path.GetFullPath(baseDirectory), "PreGenerated");
        string outpuDirectoryPath = Path.Combine(Path.GetFullPath(baseDirectory), "Generated");

        string[] preGeneratedFiles = Directory.GetFiles(inputDirectoryPath, "*.json");

        foreach (var preGeneratedFile in preGeneratedFiles)
        {
            string serialized = File.ReadAllText(preGeneratedFile);

            var nodeContainers = JsonSerializer.Deserialize<List<NodeContainer>>(serialized);
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
