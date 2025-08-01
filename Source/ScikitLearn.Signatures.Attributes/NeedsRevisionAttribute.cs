namespace ScikitLearn.Signatures.Attributes;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public class NeedsRevisionAttribute : Attribute
{
}