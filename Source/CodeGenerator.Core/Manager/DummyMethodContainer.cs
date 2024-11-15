using HtmlAgilityPack;
using System.Text;
using System.Text.RegularExpressions;


namespace CodeGenerator.Core.Manager;

public class DummyMethodContainer
{
    public DummyMethodContainer() { }

    public DummyMethodContainer(HtmlContainer htmlContainer)
    {
        Declaration = htmlContainer.Declaration ?? string.Empty;
        Declaration = RegexAnalyzer.Fix.PlainText(Declaration); // Fix json Format

        var parameters = htmlContainer.ParamsBox?.SelectNodes(".//dt");
        if (parameters != null)
        {
            foreach (var p in parameters)
            {
                var strong = p.SelectSingleNode(".//strong")?.InnerText;
                var span = p.SelectSingleNode(".//span")?.InnerText;

                if (strong == null && span == null) Parameters.Add(RegexAnalyzer.Fix.PlainText(p.InnerText));
                else Parameters.Add(RegexAnalyzer.Fix.PlainText($"{strong}:{span}"));
            }
        }

        var returns = htmlContainer.ReturnsBox?.SelectNodes(".//dt");
        if (returns != null)
        {
            foreach (var r in returns)
            {
                var strong = r.SelectSingleNode(".//strong")?.InnerText;
                var span = r.SelectSingleNode(".//span")?.InnerText;

                if (strong == null && span == null) Returns.Add(RegexAnalyzer.Fix.PlainText(r.InnerText));
                else Returns.Add(RegexAnalyzer.Fix.PlainText($"{strong}:{span}"));
            }
        }
    }

    public string Declaration { get; set; } = string.Empty;
    public List<string> Parameters { get; set; } = [];
    public List<string> Returns { get; set; } = [];
}