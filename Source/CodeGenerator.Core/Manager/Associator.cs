using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeGenerator.Core.Manager;

public static class Associator
{
    public static EntityType GetEntityType(HtmlContainer entity)
    {
        if (entity.Declaration == null) return EntityType.None;

        var (identifier, _, _) = RegexAnalyzer.Divide.Declaration(entity.Declaration);

        if (identifier.Contains("exception")) return EntityType.Exception;
        else
        {
            if (identifier.Contains("class"))
            {
                if (entity.ReturnsBox != null) return EntityType.Method; // classes do not return in C#
                else return EntityType.Class; // there are functions that do not return anything
            }
            else return EntityType.Method;
        }
    }

    public static string GetTypeFromPlainText()
    {
        return string.Empty;
    }
}
