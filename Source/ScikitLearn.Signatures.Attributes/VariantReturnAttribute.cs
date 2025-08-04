namespace ScikitLearn.Signatures.Attributes;

/// <summary>
/// Indicates that the method may return one of the specified types.  
/// This attribute can only be applied to methods returning <see cref="object"/>.  
/// Conditions must be provided for all but the last type, which is used as the fallback (else) case.
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
public class VariantReturnAttribute : Attribute
{
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
    public string FirstIf { get; set; } = "";
    public string SecondIf { get; set; } = "";
}


[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
public class EnableItemAttribute : Attribute
{
    public EnableItemAttribute(string Item = "", string If = "")
    {

    }
}