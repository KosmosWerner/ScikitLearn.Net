namespace ScikitLearn.Signatures.Attributes;

/// <summary>
/// Indicates that the method to which this attribute is applied returns the current instance of the object.
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
public sealed class SelfAttribute : Attribute { }