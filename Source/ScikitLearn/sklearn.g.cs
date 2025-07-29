namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    private static Lazy<PyObject> _lazy_self;
    public static PyObject self { get => _lazy_self.Value; }

    private static void ReInitializeLazySelf()
    {
        _lazy_self = new Lazy<PyObject>(() =>
        {
            try
            {
                return InstallAndImport();
            }
            catch (Exception)
            {
                return InstallAndImport(true);
            }
        });
    }

    private static PyObject InstallAndImport(bool force = false)
    {
        PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
        PythonEngine.Initialize();
        return Py.Import("sklearn");
    }

    static sklearn() => ReInitializeLazySelf();
    public static void config_context(bool? assume_finite = null, int? working_memory = null, bool? print_changed_only = null, string? display = null, int? pairwise_dist_chunk_size = null, bool? enable_cython_pairwise_dist = null, bool? array_api_dispatch = null, string? transform_output = null, bool? enable_metadata_routing = null, bool? skip_parameter_validation = null)
    {
        _ = sklearn.self;
        PyTuple args = new PyTuple(new PyObject[] { });
        PyDict pyDict = new PyDict();
        if (assume_finite != null)
            pyDict["assume_finite"] = Helpers.ToPython(assume_finite);
        if (working_memory != null)
            pyDict["working_memory"] = Helpers.ToPython(working_memory);
        if (print_changed_only != null)
            pyDict["print_changed_only"] = Helpers.ToPython(print_changed_only);
        if (display != null)
            pyDict["display"] = Helpers.ToPython(display);
        if (pairwise_dist_chunk_size != null)
            pyDict["pairwise_dist_chunk_size"] = Helpers.ToPython(pairwise_dist_chunk_size);
        if (enable_cython_pairwise_dist != null)
            pyDict["enable_cython_pairwise_dist"] = Helpers.ToPython(enable_cython_pairwise_dist);
        if (array_api_dispatch != null)
            pyDict["array_api_dispatch"] = Helpers.ToPython(array_api_dispatch);
        if (transform_output != null)
            pyDict["transform_output"] = Helpers.ToPython(transform_output);
        if (enable_metadata_routing != null)
            pyDict["enable_metadata_routing"] = Helpers.ToPython(enable_metadata_routing);
        if (skip_parameter_validation != null)
            pyDict["skip_parameter_validation"] = Helpers.ToPython(skip_parameter_validation);
        self.InvokeMethod("config_context", args, pyDict);
    }

    public static PyDict get_config()
    {
        _ = sklearn.self;
        PyTuple args = new PyTuple(new PyObject[] { });
        PyDict pyDict = new PyDict();
        var __pyObject = self.InvokeMethod("get_config", args, pyDict);
        return new PyDict(__pyObject);
    }

    public static void set_config(bool? assume_finite = null, int? working_memory = null, bool? print_changed_only = null, string? display = null, int? pairwise_dist_chunk_size = null, bool? enable_cython_pairwise_dist = null, bool? array_api_dispatch = null, string? transform_output = null, bool? enable_metadata_routing = null, bool? skip_parameter_validation = null)
    {
        _ = sklearn.self;
        PyTuple args = new PyTuple(new PyObject[] { });
        PyDict pyDict = new PyDict();
        if (assume_finite != null)
            pyDict["assume_finite"] = Helpers.ToPython(assume_finite);
        if (working_memory != null)
            pyDict["working_memory"] = Helpers.ToPython(working_memory);
        if (print_changed_only != null)
            pyDict["print_changed_only"] = Helpers.ToPython(print_changed_only);
        if (display != null)
            pyDict["display"] = Helpers.ToPython(display);
        if (pairwise_dist_chunk_size != null)
            pyDict["pairwise_dist_chunk_size"] = Helpers.ToPython(pairwise_dist_chunk_size);
        if (enable_cython_pairwise_dist != null)
            pyDict["enable_cython_pairwise_dist"] = Helpers.ToPython(enable_cython_pairwise_dist);
        if (array_api_dispatch != null)
            pyDict["array_api_dispatch"] = Helpers.ToPython(array_api_dispatch);
        if (transform_output != null)
            pyDict["transform_output"] = Helpers.ToPython(transform_output);
        if (enable_metadata_routing != null)
            pyDict["enable_metadata_routing"] = Helpers.ToPython(enable_metadata_routing);
        if (skip_parameter_validation != null)
            pyDict["skip_parameter_validation"] = Helpers.ToPython(skip_parameter_validation);
        self.InvokeMethod("set_config", args, pyDict);
    }

    public static void show_versions()
    {
        _ = sklearn.self;
        PyTuple args = new PyTuple(new PyObject[] { });
        PyDict pyDict = new PyDict();
        self.InvokeMethod("show_versions", args, pyDict);
    }
}