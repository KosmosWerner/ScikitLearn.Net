using CodeGenerator.Core;
using CodeGenerator.Core.Manager;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace CodeGeneratorTest
{
    public class TestCodePreGeneration
    {
        private readonly Lazy<Task<Dictionary<string, List<Uri>>>> _lazyUrls;

        public TestCodePreGeneration()
        {
            _lazyUrls = new(() => UriSearcher.Search("https://scikit-learn.org/stable/api/sklearn.html"));
        }

        [Fact]
        public async Task PreGenerate()
        {
            var source = await _lazyUrls.Value;

            await Generator.CreatePreGenerated(source);
        }

        [Fact]
        public async Task NameClassification()
        {
            var source = await _lazyUrls.Value;

            foreach (var (current_namespace, urls) in source)
            {
                foreach (var url in urls)
                {
                    using HttpClient client = new();

                    try
                    {
                        string pageContent = await client.GetStringAsync(url);
                        AnalyzePageContent(pageContent);

                    }
                    catch (HttpRequestException e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }
            }
        }

        private static void AnalyzePageContent(string pageContent)
        {
            HtmlContainer page = new(pageContent);
            ArgumentNullException.ThrowIfNull(page.ContentNode);

            var declaration = page.Declaration;
            if (declaration == null)
            {
                // sklearn.experimental
                // https://scikit-learn.org/stable/modules/generated/sklearn.experimental.enable_halving_search_cv.html
                // https://scikit-learn.org/stable/modules/generated/sklearn.experimental.enable_iterative_imputer.html
                return;
            }

            #region NewMethod
            EntityType expectedValue = Associator.GetEntityType(page);
            #endregion

            #region OldMethod

            EntityType obtainedValue = EntityType.None;
            var (identifier, _, _) = RegexAnalyzer.DivideDeclaration(declaration);

            var nodeIdentifier = page.ContentNode.SelectSingleNode(".//*[contains(@class, 'property')]");
            if (nodeIdentifier == null)
            {
                obtainedValue = EntityType.Method;
            }
            else
            {
                // check false positive
                var nodeParamsAndAttributes = page.ContentNode.SelectSingleNode(".//*[contains(@class, 'field-list') and not(ancestor::*/ancestor::*[contains(@class, 'py method')]) and not(ancestor::*/ancestor::*[contains(@class, 'py property')])]");
                var _attributes_section = nodeParamsAndAttributes?.SelectNodes(".//*[contains(@class, 'field-even')]");

                if (_attributes_section?[0]?.InnerText?.Contains("Return") ?? false) // Unusual, but exists
                {
                    // https://scikit-learn.org/stable/modules/generated/sklearn.compose.make_column_selector.html
                    // https://scikit-learn.org/stable/modules/generated/sklearn.compose.make_column_transformer.html
                    obtainedValue = EntityType.Method;
                }
                else
                {
                    if (identifier.Contains("exception"))
                        obtainedValue = EntityType.Exception;
                    else
                        obtainedValue = EntityType.Class;
                }
            }

            #endregion

            Console.WriteLine($"{expectedValue.ToString()} - {obtainedValue.ToString():-15}\tReturn: {page.ReturnsBox != null:-8}\tParams: {page.ParamsBox != null:-8}\tAttributes: {page.AttributesBox != null:-8} {page.Declaration}");
            Assert.Equal(expectedValue, obtainedValue);
        }
    }
}