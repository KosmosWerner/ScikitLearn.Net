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

namespace CodeGeneratorTest;

public class TestTextAnalyzer
{
    [Theory]
    [InlineData("“text”", "\"text\"")]
    [InlineData("'text'", "\"text\"")]
    [InlineData("‘text’", "\"text\"")]
    [InlineData("&lt;text&gt;", "<text>")]
    [InlineData("&quot;text&quot;", "\"text\"")]
    public static void FixRawText(string test,string expected)
    {
        string actual = TextAnalyzer.Fix.RawText(test);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("base", "@base")]
    [InlineData("static.base.out", "@static.@base.@out")]
    public static void FixReservedName(string test, string expected)
    {
        string actual = TextAnalyzer.Fix.Reserved(test);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("class1.class3.MethodName",
        "", "class1.class3.MethodName", "")]

    [InlineData("class1.class3.ClassOrMethodName()",
        "", "class1.class3.ClassOrMethodName", "")]

    [InlineData("class class1.class3.ClassName(arg1, *, arg2 = 2, arg3 = (1.0, 5.0), arg4 = \"text\")",
        "class", "class1.class3.ClassName", "arg1, *, arg2 = 2, arg3 = (1.0, 5.0), arg4 = \"text\"")]

    [InlineData("class class1.class3.ClassName((arg1, *, arg2 = 2, arg3 = (1.0, 5.0), arg4 = \"text\"))",
        "class", "class1.class3.ClassName", "(arg1, *, arg2 = 2, arg3 = (1.0, 5.0), arg4 = \"text\")")]
    public static void DivideFromDeclaration(string test, string expectedIdentifier, string expectedFullName, string expectedRawParameters)
    {
        var (actualIdentifier, actualFullName, actualRawParameters) = TextAnalyzer.Divide.FromDeclaration(test);
        Assert.Equal(expectedIdentifier, actualIdentifier);
        Assert.Equal(expectedFullName, actualFullName);
        Assert.Equal(expectedRawParameters, actualRawParameters);
    }

    [Theory]
    [InlineData("ClassOrMethodName", "ClassOrMethodName", "")]
    [InlineData("class1.class2.class3.ClassOrMethodName", "ClassOrMethodName", "class1.class2.class3")]
    public static void DivideFromFullName(string test, string expectedName, string expectedStaticClass)
    {
        var (actualName, actualStaticClass) = TextAnalyzer.Divide.FromFullName(test);
        Assert.Equal(expectedName, actualName);
        Assert.Equal(expectedStaticClass, actualStaticClass);
    }

    [Theory]
    [InlineData("self", "self", "", "")]
    [InlineData("self:object", "self", "object", "")]
    [InlineData("self:object, default=40", "self", "object", "40")]
    [InlineData("var:int, float or string, default=None", "var", "int, float or string", "None")]
    [InlineData("var:int, float or string", "var", "int, float or string", "")]
    [InlineData("(data, target):tuple", "(data, target)", "tuple", "")]
    [InlineData("(data, target) : tuple , default= (1.0, 0.3)", "(data, target)", "tuple", "(1.0, 0.3)")]
    public static void DivideFromDefinition(string test, string expectedName, string expectedRawType, string expectedRawDefault)
    {
        var (actualName, actualRawType, actualRawDefault) = TextAnalyzer.Divide.FromDefinition(test);
        Assert.Equal(expectedName, actualName);
        Assert.Equal(expectedRawType, actualRawType);
        Assert.Equal(expectedRawDefault, actualRawDefault);
    }

    [Theory]
    [InlineData("", new string[] { })]
    [InlineData("arg1, *, arg2 = 2, arg4 = \"text\"", new string[] { "arg1", "*", "arg2 = 2", "arg4 = \"text\"" })]
    [InlineData("arg1, *, arg2 = 2, arg3 = (1.0, 5.0), arg4 = None", new string[] { "arg1", "*", "arg2 = 2", "arg3 = (1.0, 5.0)", "arg4 = None" })]
    public static void DivideFromRawParameters(string test, string[] expected)
    {
        var actual = TextAnalyzer.Divide.FromRawParameters(test);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("()", new string[] { })]
    [InlineData("(42)", new string[] { "42" })]
    [InlineData("(42.123, 123.321)", new string[] { "42.123", "123.321" })]
    public static void DivideFromRawTuple(string test, string[] expected)
    {
        var actual = TextAnalyzer.Divide.FromRawTuple(test);
        Assert.Equal(expected, actual);
    }
}
