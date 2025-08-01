namespace ScikitLearn.Signatures.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
public class TupleVariantSelectorAttribute : Attribute
{
    public string Condition { get; set; } = "";
}