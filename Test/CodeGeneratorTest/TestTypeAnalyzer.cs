using CodeGenerator.Core.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneratorTest
{
    public class TestTypeAnalyzer
    {
        [Theory]
        [InlineData("null", null, "")]
        [InlineData("True", "true", "bool")]
        [InlineData("False", "false", "bool")]
        [InlineData("12", "12", "int")]
        [InlineData("12.34", "12.34f", "float")]
        [InlineData("np.float64(2.220446049250313e-16)", "float.Epsilon", "float")]
        [InlineData("inf", "float.PositiveInfinity", "float")]
        [InlineData("\"text\"", "\"text\"", "string")]
        //[InlineData("(12, 12)", null, "IEnumerable<int>?")] // C# limitations
        //[InlineData("(12.0, 12.0)", null, "IEnumerable<float>?")] // C# limitations
        //[InlineData("(12, 12.0)", null, "IEnumerable<float>?")] // C# limitations
        [InlineData("(12, 12.0)", null, "PyTuple?")] 
        public static void TestTryGetDefaultValue(string test, string? expectedValue, string expectedType)
        {
            string? actualValue = TypeAnalyzer.TryGetDefaultValue(test, out string actualType);
            Assert.Equal(expectedValue, actualValue);
            Assert.Equal(expectedType, actualType);
        }
    }
}
