using Numpy;
using Numpy.Models;
using Python.Runtime;

namespace ScikitLearn;

public static partial class sklearn
{
    private static Lazy<PyObject> _lazy_self;

    public static PyObject self => _lazy_self.Value;

    static sklearn() => ReInitializeLazySelf();

    private static void ReInitializeLazySelf()
    {
        _lazy_self = new Lazy<PyObject>(delegate
        {
            try { return InstallAndImport(); }
            catch (Exception) { return InstallAndImport(force: true); }
        });
    }

    private static PyObject InstallAndImport(bool force = false)
    {
        PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
        PythonEngine.Initialize();
        return Py.Import("sklearn");
    }

    public static void config_context(bool? assume_finite = null, int? working_memory = null, bool? print_changed_only = null, PyObject? display = null, int? pairwise_dist_chunk_size = null, bool? enable_cython_pairwise_dist = null, bool? array_api_dispatch = null, string? transform_output = null, bool? enable_metadata_routing = null, bool? skip_parameter_validation = null)
    {
        PyTuple args = new PyTuple();
        PyDict pyDict = new PyDict();
        if (assume_finite != null)
            pyDict["assume_finite"] = ToPython(assume_finite);
        if (working_memory != null)
            pyDict["working_memory"] = ToPython(working_memory);
        if (print_changed_only != null)
            pyDict["print_changed_only"] = ToPython(print_changed_only);
        if (display != null)
            pyDict["display"] = ToPython(display);
        if (pairwise_dist_chunk_size != null)
            pyDict["pairwise_dist_chunk_size"] = ToPython(pairwise_dist_chunk_size);
        if (enable_cython_pairwise_dist != null)
            pyDict["enable_cython_pairwise_dist"] = ToPython(enable_cython_pairwise_dist);
        if (array_api_dispatch != null)
            pyDict["array_api_dispatch"] = ToPython(array_api_dispatch);
        if (transform_output != null)
            pyDict["transform_output"] = ToPython(transform_output);
        if (enable_metadata_routing != null)
            pyDict["enable_metadata_routing"] = ToPython(enable_metadata_routing);
        if (skip_parameter_validation != null)
            pyDict["skip_parameter_validation"] = ToPython(skip_parameter_validation);
        sklearn.self.InvokeMethod("config_context", args, pyDict);
    }

    public static PyDict get_config()
    {
        PyTuple args = new PyTuple();
        PyDict pyDict = new PyDict();
        return new PyDict(sklearn.self.InvokeMethod("get_config", args, pyDict));
    }


    public static void set_config(bool? assume_finite = null, int? working_memory = null, bool? print_changed_only = null, PyObject? display = null, int? pairwise_dist_chunk_size = null, bool? enable_cython_pairwise_dist = null, bool? array_api_dispatch = null, string? transform_output = null, bool? enable_metadata_routing = null, bool? skip_parameter_validation = null)
    {
        PyTuple args = new PyTuple();
        PyDict pyDict = new PyDict();
        if (assume_finite != null)
            pyDict["assume_finite"] = ToPython(assume_finite);
        if (working_memory != null)
            pyDict["working_memory"] = ToPython(working_memory);
        if (print_changed_only != null)
            pyDict["print_changed_only"] = ToPython(print_changed_only);
        if (display != null)
            pyDict["display"] = ToPython(display);
        if (pairwise_dist_chunk_size != null)
            pyDict["pairwise_dist_chunk_size"] = ToPython(pairwise_dist_chunk_size);
        if (enable_cython_pairwise_dist != null)
            pyDict["enable_cython_pairwise_dist"] = ToPython(enable_cython_pairwise_dist);
        if (array_api_dispatch != null)
            pyDict["array_api_dispatch"] = ToPython(array_api_dispatch);
        if (transform_output != null)
            pyDict["transform_output"] = ToPython(transform_output);
        if (enable_metadata_routing != null)
            pyDict["enable_metadata_routing"] = ToPython(enable_metadata_routing);
        if (skip_parameter_validation != null)
            pyDict["skip_parameter_validation"] = ToPython(skip_parameter_validation);
        sklearn.self.InvokeMethod("set_config", args, pyDict);
    }

    public static void show_versions()
    {
        PyTuple args = new PyTuple();
        PyDict pyDict = new PyDict();
        sklearn.self.InvokeMethod("show_versions", args, pyDict);
    }


    public static PyTuple ToTuple(Array input)
    {
        PyObject[] array = new PyObject[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            array[i] = ToPython(input.GetValue(i));
        }

        return new PyTuple(array);
    }

    public static PyObject ToPython(object obj) => obj switch
    {
        null => Runtime.None,
        int value => new PyInt(value),
        long value => new PyInt(value),
        float num => new PyFloat(num),
        double value => new PyFloat(value),
        string s => new PyString(s),
        bool flag => flag.ToPython(),
        PyObject result => result,
        Array input => ToTuple(input),
        Axis axis when axis.Axes != null => ToTuple(axis.Axes),
        Axis => Runtime.None, // return null
        Shape shape => ToTuple(shape.Dimensions),
        Slice slice => slice.ToPython(),
        PythonObject pythonObject => pythonObject.PyObject,
        Dictionary<string, NDarray> d => ToDict(d),
        _ => throw new NotImplementedException(
            $"Type is not yet supported: {obj.GetType().Name}. Add it to 'ToPythonConversions'")
    };


    private static PyDict ToDict(Dictionary<string, NDarray> d)
    {
        PyDict pyDict = new PyDict();
        foreach (KeyValuePair<string, NDarray> item in d)
        {
            pyDict[new PyString(item.Key)] = item.Value.self;
        }

        return pyDict;
    }

    public static T ToCsharp<T>(dynamic pyobj)
    {
        switch (typeof(T).Name)
        {
            case "Dtype":
                return (T)(object)new Dtype(pyobj);
            case "NDarray":
                return (T)(object)new NDarray(pyobj);
            case "NDarray`1":
                return typeof(T).GenericTypeArguments[0].Name switch
                {
                    "Byte" => (T)(object)new NDarray<byte>(pyobj),
                    "Short" => (T)(object)new NDarray<short>(pyobj),
                    "Boolean" => (T)(object)new NDarray<bool>(pyobj),
                    "Int32" => (T)(object)new NDarray<int>(pyobj),
                    "Int64" => (T)(object)new NDarray<long>(pyobj),
                    "Single" => (T)(object)new NDarray<float>(pyobj),
                    "Double" => (T)(object)new NDarray<double>(pyobj),
                    _ => throw new NotImplementedException("Type NDarray<" + typeof(T).GenericTypeArguments[0].Name + "> missing. Add it to 'ToCsharpConversions'"),
                };
            case "NDarray[]":
                {
                    PyObject pyObject = pyobj as PyObject;
                    long num = pyObject.Length();
                    NDarray[] array = new NDarray[num];
                    for (int i = 0; i < num; i++)
                    {
                        array[i] = ToCsharp<NDarray>(pyObject[i]);
                    }

                    return (T)(object)array;
                }
            case "Matrix":
                return (T)(object)new Matrix(pyobj);
            default:
                {
                    string text = $"{(object?)pyobj.__class__}";
                    if (text == "<class 'str'>")
                    {
                        return (T)pyobj.ToString();
                    }

                    if (text.StartsWith("<class 'numpy"))
                    {
                        return (pyobj.item() as PyObject).As<T>();
                    }

                    try
                    {
                        return pyobj.As<T>();
                    }
                    catch (Exception inner)
                    {
                        throw new NotImplementedException($"conversion from {(object?)pyobj.__class__} to {typeof(T).Name} not implemented", inner);
                    }
                }
        }
    }

}
