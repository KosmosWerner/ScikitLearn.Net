using System;

namespace ScikitLearn;

[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
internal sealed class ReturnThisAttribute : Attribute
{
}

