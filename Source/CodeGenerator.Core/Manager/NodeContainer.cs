using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeGenerator.Core.Manager;

public class NodeContainer
{
    public NodeContainer() { }

    public NodeContainer(HtmlContainer htmlContainer)
    {
        NodeType = MapperTypes.GetEntityType(htmlContainer);

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

        var attributes = htmlContainer.AttributesBox?.SelectNodes(".//dt");
        if (attributes != null)
        {
            foreach (var a in attributes)
            {
                var strong = a.SelectSingleNode("./strong|./a")?.InnerText;
                var span = a.SelectSingleNode("./span")?.InnerText;

                if (strong == null && span == null) Attributes.Add(TextAnalyzer.Fix.PlainText(a.InnerText));
                else Attributes.Add(TextAnalyzer.Fix.PlainText($"{strong}:{span}"));
            }
        }

        if (htmlContainer.MethodsBoxes != null)
        {
            foreach (var box in htmlContainer.MethodsBoxes)
            {
                var methodContainer = new HtmlContainer(box);
                Methods.Add(new NodeMethodContainer(methodContainer));
            }
        }
    }

    public NodeType NodeType { get; set; } = NodeType.None;
    public string Declaration { get; set; } = string.Empty;
    public List<string> Parameters { get; set; } = [];
    public List<string> Returns { get; set; } = [];
    public List<string> Attributes { get; set; } = [];
    public List<NodeMethodContainer> Methods { get; set; } = [];
}
