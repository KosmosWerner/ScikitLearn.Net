namespace ScikitLearn.Signatures.Attributes;

/// <summary>
/// Indicates that the method may return one of the specified types.  
/// This attribute can only be applied to methods returning <see cref="object"/>.  
/// Conditions must be provided for all but the last type, which is used as the fallback (else) case.
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
public class VariantReturnAttribute : Attribute
{
    /// <summary>
    /// Gets or sets the condition that determines when <typeparamref name="T1"/> is returned.
    /// </summary>
    public string FirstIf { get; set; } = "";
}

/// <summary>
/// Indicates that the method may return one of the specified types.  
/// This attribute can only be applied to methods returning <see cref="object"/>.  
/// Conditions must be provided for all but the last type, which is used as the fallback (else) case.
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
public class AllowedReturnsAttribute : Attribute
{
    /// <summary>
    /// Gets or sets the condition that determines when <typeparamref name="T1"/> is returned.
    /// </summary>
    public string FirstIf { get; set; } = "";

    /// <summary>
    /// Gets or sets the condition that determines when <typeparamref name="T2"/> is returned.
    /// </summary>
    public string SecondIf { get; set; } = "";
}