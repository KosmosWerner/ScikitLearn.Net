namespace ScikitLearn.Signatures.Attributes;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class OneOfAttribute<T1, T2> : Attribute
{
    public OneOfAttribute(T1 Default = default!) { }
}
[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class NullOrOneOfAttribute<T1, T2> : Attribute
{
    public NullOrOneOfAttribute(object? Default = null) { }
}



[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class OneOfAttribute<T1, T2, T3> : Attribute
{
    public OneOfAttribute(T1? defaultValue = default!) { }
}
[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class NullOrOneOfAttribute<T1, T2, T3> : Attribute
{
    public NullOrOneOfAttribute(object? Default = null) { }
}


[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class OneOfAttribute<T1, T2, T3, T4> : Attribute
{
    public OneOfAttribute(T1 defaultValue = default!) { }
}
[AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
public class NullOrOneOfAttribute<T1, T2, T3, T4> : Attribute
{
    public NullOrOneOfAttribute(object? Default = null) { }
}
