namespace ScikitLearn.Signatures.Attributes;

/// <summary>
/// Indicates that the parameter is ignored by design, as specified in the official documentation.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
public sealed class IgnoredAttribute : Attribute { }