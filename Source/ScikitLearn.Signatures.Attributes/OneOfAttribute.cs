namespace ScikitLearn.Signatures.Attributes;

/// <summary>
/// Indicates that the parameter, which must be of type <see cref="object"/> or <see cref="object?"/>,  
/// can accept values of the two specified types.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class OneOfAttribute<T1, T2> : Attribute
{
    public OneOfAttribute(T1 Default = default!) { }
}

/// <summary>
/// Indicates that the parameter, which must be of type <see cref="object"/> or <see cref="object?"/>,  
/// can accept values of the three specified types.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class OneOfAttribute<T1, T2, T3> : Attribute
{
    public OneOfAttribute(T1 defaultValue = default!) { }
}

/// <summary>
/// Indicates that the parameter, which must be of type <see cref="object"/> or <see cref="object?"/>,  
/// can accept values of the four specified types.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class OneOfAttribute<T1, T2, T3, T4> : Attribute
{
    public OneOfAttribute(T1 defaultValue = default!) { }
}