using CodeGenerator.Core.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeGenerator.Core;

public static partial class PreGenerator
{
    private static readonly JsonSerializerOptions serializerOptions = new() { WriteIndented = true };

    public static async Task Run(Dictionary<string, List<Uri>> urlsSource, string baseDirectory = ".")
    {
        foreach (var (fileName, urls) in urlsSource)
        {
            List<EntityContainer> entityList = [];

            await BuildEntities(urls, entityList);

            Serialize(baseDirectory, fileName, entityList);
        }
    }

    private static async Task BuildEntities(List<Uri> uris, List<EntityContainer> entityList)
    {
        foreach (var uri in uris)
        {
            using HttpClient httpClient = new();

            try
            {
                string pageContent = await httpClient.GetStringAsync(uri);

                HtmlContainer htmlContainer = HtmlContainer.FromHtmlPage(pageContent);
                ArgumentNullException.ThrowIfNull(htmlContainer.ContentNode);

                string? declaration = htmlContainer.Declaration;
                if (declaration == null) continue;

                entityList.Add(new EntityContainer(htmlContainer));
            }
            catch (HttpRequestException exception)
            {
                Console.WriteLine($"Error fetching URL: {exception.Message}");
            }
        }
    }

    public static void Serialize(string baseDirectory, string fileName, List<EntityContainer> entityList)
    {
        string serialized = JsonSerializer.Serialize(entityList, serializerOptions);

        string outputDirectoryPath = Path.Combine(Path.GetFullPath(baseDirectory), "PreGenerated");
        Directory.CreateDirectory(outputDirectoryPath);

        string outputFilePath = Path.Combine(outputDirectoryPath, $"{fileName}.json");
        File.WriteAllText(outputFilePath, serialized);
    }
}
