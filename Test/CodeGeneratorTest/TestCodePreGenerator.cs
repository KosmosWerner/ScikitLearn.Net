using CodeGenerator.Core;
using CodeGenerator.Core.Manager;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace CodeGeneratorTest
{
    public class TestCodePreGenerator
    {
        private readonly Lazy<Task<Dictionary<string, List<Uri>>>> _lazyUrls;

        public TestCodePreGenerator()
        {
            _lazyUrls = new(() => UriSearcher.Search("https://scikit-learn.org/stable/api/sklearn.html"));
        }

        [Fact]
        public async Task RunPreGenerator()
        {
            var source = await _lazyUrls.Value;

            await PreGenerator.Run(source);
        }

     }
}