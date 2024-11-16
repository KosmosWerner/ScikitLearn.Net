using HtmlAgilityPack;
using System.Text;
using System.Text.RegularExpressions;


namespace CodeGenerator.Core.Manager;

public class NodeMethodContainer
{
    public NodeMethodContainer() { }

    public NodeMethodContainer(HtmlContainer htmlContainer)
    {
        Declaration = htmlContainer.Declaration ?? string.Empty;
        Declaration = TextAnalyzer.Fix.PlainText(Declaration); // Fix json Format

        var parameters = htmlContainer.ParamsBox?.SelectNodes(".//dt");
        if (parameters != null)
        {
            foreach (var p in parameters)
            {
                var strong = p.SelectSingleNode("./strong")?.InnerText;
                var span = p.SelectSingleNode("./span")?.InnerText;

                if (strong == null && span == null) Parameters.Add(TextAnalyzer.Fix.PlainText(p.InnerText));
                else Parameters.Add(TextAnalyzer.Fix.PlainText($"{strong}:{span}"));
            }
        }

        var returns = htmlContainer.ReturnsBox?.SelectNodes(".//dt");
        if (returns != null)
        {
            foreach (var r in returns)
            {
                var strong = r.SelectSingleNode("./strong")?.InnerText;
                var span = r.SelectSingleNode("./span")?.InnerText;

                if (strong == null && span == null) Returns.Add(TextAnalyzer.Fix.PlainText(r.InnerText));
                else Returns.Add(TextAnalyzer.Fix.PlainText($"{strong}:{span}"));
            }
        }
    }

    public string Declaration { get; set; } = string.Empty;
    public List<string> Parameters { get; set; } = [];
    public List<string> Returns { get; set; } = [];
}