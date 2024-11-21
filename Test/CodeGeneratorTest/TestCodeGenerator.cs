using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using CodeGenerator.Core.Manager;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CSharp;
using System.Text.Json;
using System.Linq;
using CodeGenerator.Core;

namespace CodeGeneratorTest
{
    public class TestCodeGenerator
    {
        [Fact(Skip = "Manually")]
        public void RunGenerator()
        {
            Generator.Run();
        }

        [Theory]
        [InlineData("base", "@base")]
        [InlineData("static.base.out", "@static.@base.@out")]
        public static void FixReservedName(string test, string expected)
        {
            string obtained = TextAnalyzer.Fix.Reserved(test);
            Assert.Equal(expected, obtained);
        }

        [Theory]
        [InlineData("class1.class3.MethodName",
            "", "class1.class3.MethodName", "")]

        [InlineData("class1.class3.ClassOrMethodName()",
            "", "class1.class3.ClassOrMethodName", "")]

        [InlineData("class class1.class3.ClassName(arg1, *, arg2 = 2, arg3 = (1.0, 5.0), arg4 = \"text\")",
            "class", "class1.class3.ClassName", "arg1, *, arg2 = 2, arg3 = (1.0, 5.0), arg4 = \"text\"")]
        public static void DivideFromDeclaration(string test, string expectedIdentifier, string expectedFullName, string expectedRawParameters)
        {
            var (obtainedIdentifier, obtainedFullName, obtainedRawParameters) = TextAnalyzer.Divide.FromDeclaration(test);
            Assert.Equal(expectedIdentifier, obtainedIdentifier);
            Assert.Equal(expectedFullName, obtainedFullName);
            Assert.Equal(expectedRawParameters, obtainedRawParameters);
        }

        [Theory]
        [InlineData("ClassOrMethodName", "ClassOrMethodName", "")]
        [InlineData("class1.class2.class3.ClassOrMethodName", "ClassOrMethodName", "class1.class2.class3")]
        public static void DivideFromFullName(string test, string expectedName, string expectedStaticClass)
        {
            (string obtainedName, string obtainedStaticClass) = TextAnalyzer.Divide.FromFullName(test);
            Assert.Equal(expectedName, obtainedName);
            Assert.Equal(expectedStaticClass, obtainedStaticClass);
        }

        [Theory]
        [InlineData("self", "self", "", "")]
        [InlineData("self:object", "self", "object", "")]
        [InlineData("self:object, default=40", "self", "object", "40")]
        [InlineData("var:int, float or string, default=None", "var", "int, float or string", "None")]
        [InlineData("var:int, float or string", "var", "int, float or string", "")]
        public static void DivideFromDefinition(string test, string expectedName, string expectedRawType, string expectedRawDefault)
        {
            var (actualName, actualRawType, actualRawDefault) = TextAnalyzer.Divide.FromDefinition(test);
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedRawType, actualRawType);
            Assert.Equal(expectedRawDefault, actualRawDefault);
        }
    }
}
