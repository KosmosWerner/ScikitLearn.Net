namespace ScikitLearn;

public static class Helpers
{
    public static PyObject ToPython(bool? value) => value != null ? value.Value.ToPython() : Runtime.None;
    public static PyObject ToPython(int? value) => value != null ? new PyInt(value.Value) : Runtime.None;
    public static PyObject ToPython(long? value) => value != null ? new PyInt(value.Value) : Runtime.None;
    public static PyObject ToPython(float? value) => value != null ? new PyFloat(value.Value) : Runtime.None;
    public static PyObject ToPython(double? value) => value != null ? new PyFloat(value.Value) : Runtime.None;
    public static PyObject ToPython(string? value) => value != null ? new PyString(value) : Runtime.None;
    public static PyObject ToPython(PyObject value) => value;
    public static PyObject ToPython(PythonObject value) => value.self;
    public static PyObject ToPython(PyObject[] iterables) => new PyTuple(iterables);

    public static PyTuple ToPython(string[] value)
    {
        PyObject[] objs = new PyObject[value.Length];
        for (int i = 0; i < value.Length; i++) objs[i] = ToPython(value[i]);
        return new PyTuple(objs);
    }
    public static PyTuple ToPython(PythonObject[] value)
    {
        PyObject[] objs = new PyObject[value.Length];
        for (int i = 0; i < value.Length; i++) objs[i] = ToPython(value[i]);
        return new PyTuple(objs);
    }
    public static PyTuple ToPython(Shape shape)
    {
        PyObject[] array = new PyObject[shape.Dimensions.Length];
        for (int i = 0; i < shape.Dimensions.Length; i++)
            array[i] = ToPython(shape.Dimensions[i]);
        return new PyTuple(array);
    }

    public static PyDict ToPython(Dictionary<string, bool> value)
    {
        PyDict dict = new PyDict();
        foreach (var item in value) dict[ToPython(item.Key)] = ToPython(item.Value);
        return dict;
    }
    public static PyDict ToPython(Dictionary<string, int> value)
    {
        PyDict dict = new PyDict();
        foreach (var item in value) dict[ToPython(item.Key)] = ToPython(item.Value);
        return dict;
    }
    public static PyDict ToPython(Dictionary<string, long> value)
    {
        PyDict dict = new PyDict();
        foreach (var item in value) dict[ToPython(item.Key)] = ToPython(item.Value);
        return dict;
    }
    public static PyDict ToPython(Dictionary<string, float> value)
    {
        PyDict dict = new PyDict();
        foreach (var item in value) dict[ToPython(item.Key)] = ToPython(item.Value);
        return dict;
    }
    public static PyDict ToPython(Dictionary<string, double> value)
    {
        PyDict dict = new PyDict();
        foreach (var item in value) dict[ToPython(item.Key)] = ToPython(item.Value);
        return dict;
    }
    public static PyDict ToPython(Dictionary<string, string> value)
    {
        PyDict dict = new PyDict();
        foreach (var item in value) dict[ToPython(item.Key)] = ToPython(item.Value);
        return dict;
    }
    public static PyDict ToPython(Dictionary<string, PyObject> value)
    {
        PyDict dict = new PyDict();
        foreach (var item in value) dict[ToPython(item.Key)] = ToPython(item.Value);
        return dict;
    }
    public static PyDict ToPython(Dictionary<string, PythonObject> value)
    {
        PyDict dict = new PyDict();
        foreach (var item in value) dict[ToPython(item.Key)] = ToPython(item.Value.self);
        return dict;
    }

    public static bool ToCSharpBool(PyObject pyObject) => pyObject.As<bool>();

    public static int ToCSharpInt(PyObject pyObject) => pyObject.As<int>();

    public static long ToCSharpLong(PyObject pyObject) => pyObject.As<long>();

    public static float ToCSharpFloat(PyObject pyObject) => pyObject.As<float>();

    public static double ToCSharpDouble(PyObject pyObject) => pyObject.As<double>();

    public static string ToCSharpString(PyObject pyObject) => pyObject.As<string>();

    public static NDarray ToCSharpNDarray(PyObject pyObject) => new NDarray(pyObject);

    public static NDarray<T> ToCSharpNDarray<T>(PyObject pyObject) => new NDarray<T>(pyObject);

    public static PyObject ToCSharpPyObject(PyObject pyObject) => pyObject;

    public static PyDict ToCSharpPyDict(PyObject pyObject) => new PyDict(pyObject);

    public static PyTuple ToCSharpPyTuple(PyObject pyObject) => new PyTuple(pyObject);
}
