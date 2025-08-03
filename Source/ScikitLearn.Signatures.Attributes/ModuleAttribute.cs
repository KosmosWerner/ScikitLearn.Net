namespace ScikitLearn.Signatures.Attributes;

/// <summary>
/// Indicates that the static class represents a Python module.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class ModuleAttribute : Attribute { }