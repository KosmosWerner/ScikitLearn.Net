namespace ScikitLearn.Signatures.Attributes;

/// <summary>
/// Indicates that this element has not been fully reviewed and may exhibit unexpected behavior.
/// </summary>
[AttributeUsage(
    AttributeTargets.Method |
    AttributeTargets.Property |
    AttributeTargets.Parameter |
    AttributeTargets.Class,
    Inherited = false, AllowMultiple = true)]
public class NeedsRevisionAttribute : Attribute { }