using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScikitLearn.Signatures.Annotations;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Constructor, Inherited = false, AllowMultiple = false)]
internal class CheckedAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Constructor, Inherited = false, AllowMultiple = false)]
internal class GenerateAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
internal class TupleMemberConditionAttribute : Attribute
{
    public string Condition { get; set; } = "";
    public string Member { get; set; } = "";
}

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
internal class TupleVariantSelectorAttribute : Attribute
{
    public string Condition { get; set; } = "";
    public string WhenTrue { get; set; } = "";
    public string WhenFalse { get; set; } = "";
}