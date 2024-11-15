using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGenerator.Core.Manager;

public class DummyContainer
{
    public DummyContainer() { }

    public DummyContainer(HtmlContainer htmlContainer)
    {
        EntityType = Associator.GetEntityType(htmlContainer);

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

        var attributes = htmlContainer.AttributesBox?.SelectNodes(".//dt");
        if (attributes != null)
        {
            foreach (var a in attributes)
            {
                var strong = a.SelectSingleNode(".//strong")?.InnerText;
                var span = a.SelectSingleNode(".//span")?.InnerText;

                if (strong == null && span == null) Attributes.Add(RegexAnalyzer.Fix.PlainText(a.InnerText));
                else Attributes.Add(RegexAnalyzer.Fix.PlainText($"{strong}:{span}"));
            }
        }

        if (htmlContainer.MethodsBoxes != null)
        {
            foreach (var box in htmlContainer.MethodsBoxes)
            {
                var methodContainer = new HtmlContainer(box);
                Methods.Add(new DummyMethodContainer(methodContainer));
            }
        }
    }

    public EntityType EntityType { get; set; } = EntityType.None;
    public string Declaration { get; set; } = string.Empty;
    public List<string> Parameters { get; set; } = [];
    public List<string> Returns { get; set; } = [];
    public List<string> Attributes { get; set; } = [];
    public List<DummyMethodContainer> Methods { get; set; } = [];
}
