using HtmlAgilityPack;

namespace CodeGenerator.Core.Manager;

public class HtmlContainer
{
    public HtmlNode? ContentNode { private set; get; }
    public string? Declaration { private set; get; }
    public HtmlNode? ParamsBox { private set; get; }
    public HtmlNode? ReturnsBox { private set; get; }
    public HtmlNode? AttributesBox { private set; get; }
    public HtmlNodeCollection? MethodsBoxes { private set; get; }


    public HtmlContainer() { }

    public static HtmlContainer FromHtmlPage(string pageContent)
    {
        var document = new HtmlDocument();
        document.LoadHtml(pageContent);

        var result = new HtmlContainer();

        result.ContentNode = document.DocumentNode.SelectSingleNode("//*[contains(@class, 'bd-article')]");
        result.Declaration = result.ContentNode?.SelectSingleNode(".//*[contains(@class, 'sig sig-object py')]")?.InnerText;


        var fieldList = result.ContentNode?.SelectSingleNode(".//*[contains(@class, 'field-list') and not(ancestor::*/ancestor::*[contains(@class, 'py method')]) and not(ancestor::*/ancestor::*[contains(@class, 'py property')])]");
        if (fieldList != null)
        {
            var evenList = fieldList?.SelectNodes(".//*[contains(@class, 'field-even')]");
            var oddList = fieldList?.SelectNodes(".//*[contains(@class, 'field-odd')]");

            if (evenList != null)
            {
                string header = evenList[0].InnerText;
                if (header.Contains("Return") || header.Contains("Yield")) result.ReturnsBox = evenList[1]?.SelectSingleNode("./dl");
                else if (header.Contains("Attribute")) result.AttributesBox = evenList[1]?.SelectSingleNode("./dl");
                else if (header.Contains("Parameter")) result.ParamsBox = evenList[1]?.SelectSingleNode("./dl");
            }

            if (oddList != null)
            {
                string header = oddList[0].InnerText;
                if (header.Contains("Return") || header.Contains("Yield")) result.ReturnsBox = oddList[1]?.SelectSingleNode("./dl");
                else if (header.Contains("Attribute")) result.AttributesBox = oddList[1]?.SelectSingleNode("./dl");
                else if (header.Contains("Parameter")) result.ParamsBox = oddList[1]?.SelectSingleNode("./dl");
            }
        }

        result.MethodsBoxes = result.ContentNode?.SelectNodes(".//*[contains(@class, 'py method')]");
        return result;
    }

    public static HtmlContainer FromPyMethod(HtmlNode pymethod)
    {
        var result = new HtmlContainer();

        result.ContentNode = pymethod;

        result.Declaration = result.ContentNode?.SelectSingleNode(".//*[contains(@class, 'sig sig-object py')]")?.InnerText;

        var fieldList = result.ContentNode?.SelectSingleNode(".//*[contains(@class, 'field-list')]");
        if (fieldList != null)
        {
            var evenList = fieldList?.SelectNodes(".//*[contains(@class, 'field-even')]");
            var oddList = fieldList?.SelectNodes(".//*[contains(@class, 'field-odd')]");

            if (evenList != null)
            {
                string header = evenList[0].InnerText;
                if (header.Contains("Return") || header.Contains("Yield")) result.ReturnsBox = evenList[1]?.SelectSingleNode("./dl");
                else if (header.Contains("Parameter")) result.ParamsBox = evenList[1]?.SelectSingleNode("./dl");
            }

            if (oddList != null)
            {
                string header = oddList[0].InnerText;
                if (header.Contains("Return") || header.Contains("Yield")) result.ReturnsBox = oddList[1]?.SelectSingleNode("./dl");
                else if (header.Contains("Parameter")) result.ParamsBox = oddList[1]?.SelectSingleNode("./dl");
            }
        }

        return result;
    }
}
