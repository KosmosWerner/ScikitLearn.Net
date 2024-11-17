using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class utils
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
                return Py.Import("sklearn.utils");
            }

            static utils()
            {
                ReInitializeLazySelf();
            }

            public class Bunch : PythonObject
            {
                public Bunch()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.utils.self.InvokeMethod("Bunch", args, pyDict);
                }

                internal Bunch(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static Bunch Encapsule(PyObject pyObject)
                {
                    return new Bunch(pyObject);
                }

                public void clear()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clear", args, pyDict);
                }

                public void copy()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("copy", args, pyDict);
                }

                public void fromkeys()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fromkeys", args, pyDict);
                }

                public void get()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("get", args, pyDict);
                }

                public void items()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("items", args, pyDict);
                }

                public void keys()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("keys", args, pyDict);
                }

                public void pop()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("pop", args, pyDict);
                }

                public void popitem()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("popitem", args, pyDict);
                }

                public void setdefault()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("setdefault", args, pyDict);
                }

                public void update()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("update", args, pyDict);
                }

                public void values()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("values", args, pyDict);
                }
            }

            public static PyObject _safe_indexing(NDarray X, NDarray indices, int axis = 0)
            {
                PyTuple args = ToTuple(new object[] { X, indices });
                PyDict pyDict = new PyDict();
                if (axis != 0)
                    pyDict["axis"] = ToPython(axis);
                return sklearn.utils.self.InvokeMethod("_safe_indexing", args, pyDict);
            }

            public static NDarray as_float_array(NDarray X, bool copy = true, bool force_all_finite = true)
            {
                PyTuple args = ToTuple(new object[] { X });
                PyDict pyDict = new PyDict();
                if (copy != true)
                    pyDict["copy"] = ToPython(copy);
                if (force_all_finite != true)
                    pyDict["force_all_finite"] = ToPython(force_all_finite);
                return ToCsharp<NDarray>(sklearn.utils.self.InvokeMethod("as_float_array", args, pyDict));
            }

            public static void assert_all_finite(NDarray X, bool allow_nan = false, string? estimator_name = null, string input_name = "")
            {
                PyTuple args = ToTuple(new object[] { X });
                PyDict pyDict = new PyDict();
                if (allow_nan != false)
                    pyDict["allow_nan"] = ToPython(allow_nan);
                if (estimator_name != null)
                    pyDict["estimator_name"] = ToPython(estimator_name);
                if (input_name != "")
                    pyDict["input_name"] = ToPython(input_name);
                sklearn.utils.self.InvokeMethod("assert_all_finite", args, pyDict);
            }

            public class deprecated : PythonObject
            {
                public deprecated(string extra = "")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (extra != "")
                        pyDict["extra"] = ToPython(extra);
                    self = sklearn.utils.self.InvokeMethod("deprecated", args, pyDict);
                }

                internal deprecated(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static deprecated Encapsule(PyObject pyObject)
                {
                    return new deprecated(pyObject);
                }
            }

            public static string estimator_html_repr(PyObject estimator)
            {
                PyTuple args = ToTuple(new object[] { estimator });
                PyDict pyDict = new PyDict();
                return ToCsharp<string>(sklearn.utils.self.InvokeMethod("estimator_html_repr", args, pyDict));
            }

            public static PyObject gen_batches(int n, int batch_size, int min_batch_size = 0)
            {
                PyTuple args = ToTuple(new object[] { n, batch_size });
                PyDict pyDict = new PyDict();
                if (min_batch_size != 0)
                    pyDict["min_batch_size"] = ToPython(min_batch_size);
                return sklearn.utils.self.InvokeMethod("gen_batches", args, pyDict);
            }

            public static PyObject gen_even_slices(int n, int n_packs, int? n_samples = null)
            {
                PyTuple args = ToTuple(new object[] { n, n_packs });
                PyDict pyDict = new PyDict();
                if (n_samples != null)
                    pyDict["n_samples"] = ToPython(n_samples);
                return sklearn.utils.self.InvokeMethod("gen_even_slices", args, pyDict);
            }

            public static NDarray? indexable(PyObject[] iterables)
            {
                PyTuple args = ToTuple(new object[] { iterables });
                PyDict pyDict = new PyDict();
                return ToCsharp<NDarray?>(sklearn.utils.self.InvokeMethod("indexable", args, pyDict));
            }

            public static void murmurhash3_32(NDarray key, int seed = 0, bool positive = false)
            {
                PyTuple args = ToTuple(new object[] { key });
                PyDict pyDict = new PyDict();
                if (seed != 0)
                    pyDict["seed"] = ToPython(seed);
                if (positive != false)
                    pyDict["positive"] = ToPython(positive);
                sklearn.utils.self.InvokeMethod("murmurhash3_32", args, pyDict);
            }

            public static NDarray resample(NDarray[] arrays, bool replace = true, int? n_samples = null, int? random_state = null, NDarray? stratify = null)
            {
                PyTuple args = ToTuple(new object[] { arrays });
                PyDict pyDict = new PyDict();
                if (replace != true)
                    pyDict["replace"] = ToPython(replace);
                if (n_samples != null)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (stratify != null)
                    pyDict["stratify"] = ToPython(stratify);
                return ToCsharp<NDarray>(sklearn.utils.self.InvokeMethod("resample", args, pyDict));
            }

            public static NDarray safe_mask(NDarray X, NDarray mask)
            {
                PyTuple args = ToTuple(new object[] { X, mask });
                PyDict pyDict = new PyDict();
                return ToCsharp<NDarray>(sklearn.utils.self.InvokeMethod("safe_mask", args, pyDict));
            }

            public static PyObject safe_sqr(NDarray X, bool copy = true)
            {
                PyTuple args = ToTuple(new object[] { X });
                PyDict pyDict = new PyDict();
                if (copy != true)
                    pyDict["copy"] = ToPython(copy);
                return sklearn.utils.self.InvokeMethod("safe_sqr", args, pyDict);
            }

            public static NDarray shuffle(NDarray[] arrays, int? random_state = null, int? n_samples = null)
            {
                PyTuple args = ToTuple(new object[] { arrays });
                PyDict pyDict = new PyDict();
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (n_samples != null)
                    pyDict["n_samples"] = ToPython(n_samples);
                return ToCsharp<NDarray>(sklearn.utils.self.InvokeMethod("shuffle", args, pyDict));
            }

            public static (PyObject, PyObject) check_X_y(NDarray X, NDarray y, bool accept_sparse = false, bool accept_large_sparse = true, string? dtype = "numeric", PyObject? order = null, bool copy = false, bool force_writeable = false, bool force_all_finite = true, bool ensure_2d = true, bool allow_nd = false, bool multi_output = false, int ensure_min_samples = 1, int ensure_min_features = 1, bool y_numeric = false, string? estimator = null)
            {
                PyTuple args = ToTuple(new object[] { X, y });
                PyDict pyDict = new PyDict();
                if (accept_sparse != false)
                    pyDict["accept_sparse"] = ToPython(accept_sparse);
                if (accept_large_sparse != true)
                    pyDict["accept_large_sparse"] = ToPython(accept_large_sparse);
                if (dtype != "numeric")
                    pyDict["dtype"] = ToPython(dtype);
                if (order != null)
                    pyDict["order"] = ToPython(order);
                if (copy != false)
                    pyDict["copy"] = ToPython(copy);
                if (force_writeable != false)
                    pyDict["force_writeable"] = ToPython(force_writeable);
                if (force_all_finite != true)
                    pyDict["force_all_finite"] = ToPython(force_all_finite);
                if (ensure_2d != true)
                    pyDict["ensure_2d"] = ToPython(ensure_2d);
                if (allow_nd != false)
                    pyDict["allow_nd"] = ToPython(allow_nd);
                if (multi_output != false)
                    pyDict["multi_output"] = ToPython(multi_output);
                if (ensure_min_samples != 1)
                    pyDict["ensure_min_samples"] = ToPython(ensure_min_samples);
                if (ensure_min_features != 1)
                    pyDict["ensure_min_features"] = ToPython(ensure_min_features);
                if (y_numeric != false)
                    pyDict["y_numeric"] = ToPython(y_numeric);
                if (estimator != null)
                    pyDict["estimator"] = ToPython(estimator);
                PyTuple result = new PyTuple(sklearn.utils.self.InvokeMethod("check_X_y", args, pyDict));
                return (ToCsharp<PyObject>(result[0]), ToCsharp<PyObject>(result[1]));
            }

            public static PyObject check_array(PyObject array, bool accept_sparse = false, bool accept_large_sparse = true, string? dtype = "numeric", PyObject? order = null, bool copy = false, bool force_writeable = false, bool force_all_finite = true, bool ensure_2d = true, bool allow_nd = false, int ensure_min_samples = 1, int ensure_min_features = 1, string? estimator = null, string input_name = "")
            {
                PyTuple args = ToTuple(new object[] { array });
                PyDict pyDict = new PyDict();
                if (accept_sparse != false)
                    pyDict["accept_sparse"] = ToPython(accept_sparse);
                if (accept_large_sparse != true)
                    pyDict["accept_large_sparse"] = ToPython(accept_large_sparse);
                if (dtype != "numeric")
                    pyDict["dtype"] = ToPython(dtype);
                if (order != null)
                    pyDict["order"] = ToPython(order);
                if (copy != false)
                    pyDict["copy"] = ToPython(copy);
                if (force_writeable != false)
                    pyDict["force_writeable"] = ToPython(force_writeable);
                if (force_all_finite != true)
                    pyDict["force_all_finite"] = ToPython(force_all_finite);
                if (ensure_2d != true)
                    pyDict["ensure_2d"] = ToPython(ensure_2d);
                if (allow_nd != false)
                    pyDict["allow_nd"] = ToPython(allow_nd);
                if (ensure_min_samples != 1)
                    pyDict["ensure_min_samples"] = ToPython(ensure_min_samples);
                if (ensure_min_features != 1)
                    pyDict["ensure_min_features"] = ToPython(ensure_min_features);
                if (estimator != null)
                    pyDict["estimator"] = ToPython(estimator);
                if (input_name != "")
                    pyDict["input_name"] = ToPython(input_name);
                return sklearn.utils.self.InvokeMethod("check_array", args, pyDict);
            }

            public static void check_consistent_length(NDarray[] arrays)
            {
                PyTuple args = ToTuple(new object[] { arrays });
                PyDict pyDict = new PyDict();
                sklearn.utils.self.InvokeMethod("check_consistent_length", args, pyDict);
            }

            public static PyObject check_random_state(int seed)
            {
                PyTuple args = ToTuple(new object[] { seed });
                PyDict pyDict = new PyDict();
                return sklearn.utils.self.InvokeMethod("check_random_state", args, pyDict);
            }

            public static PyObject check_scalar(PyObject x, string name, PyTuple target_type, float? min_val = null, float? max_val = null, string include_boundaries = "both")
            {
                PyTuple args = ToTuple(new object[] { x, name, target_type });
                PyDict pyDict = new PyDict();
                if (min_val != null)
                    pyDict["min_val"] = ToPython(min_val);
                if (max_val != null)
                    pyDict["max_val"] = ToPython(max_val);
                if (include_boundaries != "both")
                    pyDict["include_boundaries"] = ToPython(include_boundaries);
                return sklearn.utils.self.InvokeMethod("check_scalar", args, pyDict);
            }

            public static class arrayfuncs
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
                    return Py.Import("sklearn.utils.arrayfuncs");
                }

                static arrayfuncs()
                {
                    ReInitializeLazySelf();
                }

                public static (float, NDarray) min_pos(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(sklearn.utils.arrayfuncs.self.InvokeMethod("min_pos", args, pyDict));
                    return (ToCsharp<float>(result[0]), ToCsharp<NDarray>(result[1]));
                }
            }

            public static class class_weight
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
                    return Py.Import("sklearn.utils.class_weight");
                }

                static class_weight()
                {
                    ReInitializeLazySelf();
                }

                public static NDarray compute_class_weight(PyDict class_weight, NDarray classes, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { class_weight, classes, y });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(sklearn.utils.class_weight.self.InvokeMethod("compute_class_weight", args, pyDict));
                }

                public static NDarray compute_sample_weight(PyDict class_weight, NDarray y, NDarray? indices = null)
                {
                    PyTuple args = ToTuple(new object[] { class_weight, y });
                    PyDict pyDict = new PyDict();
                    if (indices != null)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(sklearn.utils.class_weight.self.InvokeMethod("compute_sample_weight", args, pyDict));
                }
            }

            public static class discovery
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
                    return Py.Import("sklearn.utils.discovery");
                }

                static discovery()
                {
                    ReInitializeLazySelf();
                }

                public static PyTuple all_displays()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return new PyTuple(sklearn.utils.discovery.self.InvokeMethod("all_displays", args, pyDict));
                }

                public static PyTuple all_estimators(PyTuple? type_filter = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (type_filter != null)
                        pyDict["type_filter"] = ToPython(type_filter);
                    return new PyTuple(sklearn.utils.discovery.self.InvokeMethod("all_estimators", args, pyDict));
                }

                public static PyTuple all_functions()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return new PyTuple(sklearn.utils.discovery.self.InvokeMethod("all_functions", args, pyDict));
                }
            }

            public static class estimator_checks
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
                    return Py.Import("sklearn.utils.estimator_checks");
                }

                static estimator_checks()
                {
                    ReInitializeLazySelf();
                }

                public static PyObject check_estimator(PyObject? estimator = null, bool generate_only = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (estimator != null)
                        pyDict["estimator"] = ToPython(estimator);
                    if (generate_only != false)
                        pyDict["generate_only"] = ToPython(generate_only);
                    return sklearn.utils.estimator_checks.self.InvokeMethod("check_estimator", args, pyDict);
                }

                public static PyObject parametrize_with_checks(PyTuple estimators)
                {
                    PyTuple args = ToTuple(new object[] { estimators });
                    PyDict pyDict = new PyDict();
                    return sklearn.utils.estimator_checks.self.InvokeMethod("parametrize_with_checks", args, pyDict);
                }
            }

            public static class extmath
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
                    return Py.Import("sklearn.utils.extmath");
                }

                static extmath()
                {
                    ReInitializeLazySelf();
                }

                public static float density(NDarray w)
                {
                    PyTuple args = ToTuple(new object[] { w });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<float>(sklearn.utils.extmath.self.InvokeMethod("density", args, pyDict));
                }

                public static float fast_logdet(NDarray A)
                {
                    PyTuple args = ToTuple(new object[] { A });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<float>(sklearn.utils.extmath.self.InvokeMethod("fast_logdet", args, pyDict));
                }

                public static NDarray randomized_range_finder(NDarray A, int size, int n_iter, string power_iteration_normalizer = "auto", int? random_state = null)
                {
                    PyTuple args = ToTuple(new object[] { A, size, n_iter });
                    PyDict pyDict = new PyDict();
                    if (power_iteration_normalizer != "auto")
                        pyDict["power_iteration_normalizer"] = ToPython(power_iteration_normalizer);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    return ToCsharp<NDarray>(sklearn.utils.extmath.self.InvokeMethod("randomized_range_finder", args, pyDict));
                }

                public static (NDarray, NDarray, NDarray) randomized_svd(NDarray M, int n_components, int n_oversamples = 10, string n_iter = "auto", string power_iteration_normalizer = "auto", string transpose = "auto", bool flip_sign = true, int? random_state = null, string svd_lapack_driver = "gesdd")
                {
                    PyTuple args = ToTuple(new object[] { M, n_components });
                    PyDict pyDict = new PyDict();
                    if (n_oversamples != 10)
                        pyDict["n_oversamples"] = ToPython(n_oversamples);
                    if (n_iter != "auto")
                        pyDict["n_iter"] = ToPython(n_iter);
                    if (power_iteration_normalizer != "auto")
                        pyDict["power_iteration_normalizer"] = ToPython(power_iteration_normalizer);
                    if (transpose != "auto")
                        pyDict["transpose"] = ToPython(transpose);
                    if (flip_sign != true)
                        pyDict["flip_sign"] = ToPython(flip_sign);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (svd_lapack_driver != "gesdd")
                        pyDict["svd_lapack_driver"] = ToPython(svd_lapack_driver);
                    PyTuple result = new PyTuple(sklearn.utils.extmath.self.InvokeMethod("randomized_svd", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
                }

                public static NDarray safe_sparse_dot(NDarray a, NDarray b, bool dense_output = false)
                {
                    PyTuple args = ToTuple(new object[] { a, b });
                    PyDict pyDict = new PyDict();
                    if (dense_output != false)
                        pyDict["dense_output"] = ToPython(dense_output);
                    return ToCsharp<NDarray>(sklearn.utils.extmath.self.InvokeMethod("safe_sparse_dot", args, pyDict));
                }

                public static (NDarray, NDarray) weighted_mode(NDarray a, NDarray w, int axis = 0)
                {
                    PyTuple args = ToTuple(new object[] { a, w });
                    PyDict pyDict = new PyDict();
                    if (axis != 0)
                        pyDict["axis"] = ToPython(axis);
                    PyTuple result = new PyTuple(sklearn.utils.extmath.self.InvokeMethod("weighted_mode", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }
            }

            public static class graph
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
                    return Py.Import("sklearn.utils.graph");
                }

                static graph()
                {
                    ReInitializeLazySelf();
                }

                public static PyDict single_source_shortest_path_length(NDarray graph, int source, int? cutoff = null)
                {
                    PyTuple args = ToTuple(new object[] { graph, source });
                    PyDict pyDict = new PyDict();
                    if (cutoff != null)
                        pyDict["cutoff"] = ToPython(cutoff);
                    return new PyDict(sklearn.utils.graph.self.InvokeMethod("single_source_shortest_path_length", args, pyDict));
                }
            }

            public static class metadata_routing
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
                    return Py.Import("sklearn.utils.metadata_routing");
                }

                static metadata_routing()
                {
                    ReInitializeLazySelf();
                }

                public class MetadataRequest : PythonObject
                {
                    public MetadataRequest(string owner)
                    {
                        PyTuple args = ToTuple(new object[] { owner });
                        PyDict pyDict = new PyDict();
                        self = sklearn.utils.metadata_routing.self.InvokeMethod("MetadataRequest", args, pyDict);
                    }

                    internal MetadataRequest(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static MetadataRequest Encapsule(PyObject pyObject)
                    {
                        return new MetadataRequest(pyObject);
                    }

                    public string consumes(string method, string @params)
                    {
                        PyTuple args = ToTuple(new object[] { method, @params });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<string>(self.InvokeMethod("consumes", args, pyDict));
                    }
                }

                public class MetadataRouter : PythonObject
                {
                    public MetadataRouter(string owner)
                    {
                        PyTuple args = ToTuple(new object[] { owner });
                        PyDict pyDict = new PyDict();
                        self = sklearn.utils.metadata_routing.self.InvokeMethod("MetadataRouter", args, pyDict);
                    }

                    internal MetadataRouter(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static MetadataRouter Encapsule(PyObject pyObject)
                    {
                        return new MetadataRouter(pyObject);
                    }

                    public MetadataRouter add(PyObject method_mapping, Dictionary<string, PyObject>? @params = null)
                    {
                        PyTuple args = ToTuple(new object[] { method_mapping });
                        PyDict pyDict = new PyDict();
                        if (@params != null)
                            pyDict["params"] = ToPython(@params);
                        self.InvokeMethod("add", args, pyDict);
                        return this;
                    }

                    public MetadataRouter add_self_request(PyObject obj)
                    {
                        PyTuple args = ToTuple(new object[] { obj });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("add_self_request", args, pyDict);
                        return this;
                    }

                    public string consumes(string method, string @params)
                    {
                        PyTuple args = ToTuple(new object[] { method, @params });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<string>(self.InvokeMethod("consumes", args, pyDict));
                    }

                    public PyDict route_params(string caller, PyDict @params)
                    {
                        PyTuple args = ToTuple(new object[] { caller, @params });
                        PyDict pyDict = new PyDict();
                        return new PyDict(self.InvokeMethod("route_params", args, pyDict));
                    }

                    public void validate_metadata(string method, PyDict @params)
                    {
                        PyTuple args = ToTuple(new object[] { method, @params });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("validate_metadata", args, pyDict);
                    }
                }

                public class MethodMapping : PythonObject
                {
                    public MethodMapping()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self = sklearn.utils.metadata_routing.self.InvokeMethod("MethodMapping", args, pyDict);
                    }

                    internal MethodMapping(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static MethodMapping Encapsule(PyObject pyObject)
                    {
                        return new MethodMapping(pyObject);
                    }

                    public MethodMapping add(string caller, string callee)
                    {
                        PyTuple args = ToTuple(new object[] { caller, callee });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("add", args, pyDict);
                        return this;
                    }
                }

                public static PyObject get_routing_for_object(PyObject? obj = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (obj != null)
                        pyDict["obj"] = ToPython(obj);
                    return sklearn.utils.metadata_routing.self.InvokeMethod("get_routing_for_object", args, pyDict);
                }

                public static PyDict process_routing(PyObject _obj, string _method, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { _obj, _method });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return new PyDict(sklearn.utils.metadata_routing.self.InvokeMethod("process_routing", args, pyDict));
                }
            }

            public static class metaestimators
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
                    return Py.Import("sklearn.utils.metaestimators");
                }

                static metaestimators()
                {
                    ReInitializeLazySelf();
                }

                public static PyObject available_if(PyObject check)
                {
                    PyTuple args = ToTuple(new object[] { check });
                    PyDict pyDict = new PyDict();
                    return sklearn.utils.metaestimators.self.InvokeMethod("available_if", args, pyDict);
                }
            }

            public static class multiclass
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
                    return Py.Import("sklearn.utils.multiclass");
                }

                static multiclass()
                {
                    ReInitializeLazySelf();
                }

                public static bool is_multilabel(NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { y });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<bool>(sklearn.utils.multiclass.self.InvokeMethod("is_multilabel", args, pyDict));
                }

                public static string type_of_target(NDarray y, string input_name = "")
                {
                    PyTuple args = ToTuple(new object[] { y });
                    PyDict pyDict = new PyDict();
                    if (input_name != "")
                        pyDict["input_name"] = ToPython(input_name);
                    return ToCsharp<string>(sklearn.utils.multiclass.self.InvokeMethod("type_of_target", args, pyDict));
                }

                public static NDarray unique_labels(NDarray[] ys)
                {
                    PyTuple args = ToTuple(new object[] { ys });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(sklearn.utils.multiclass.self.InvokeMethod("unique_labels", args, pyDict));
                }
            }

            public static class parallel
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
                    return Py.Import("sklearn.utils.parallel");
                }

                static parallel()
                {
                    ReInitializeLazySelf();
                }

                public class Parallel : PythonObject
                {
                    public Parallel(string return_as = "list", string pre_dispatch = "2 * n_jobs", string batch_size = "auto")
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (return_as != "list")
                            pyDict["return_as"] = ToPython(return_as);
                        if (pre_dispatch != "2 * n_jobs")
                            pyDict["pre_dispatch"] = ToPython(pre_dispatch);
                        if (batch_size != "auto")
                            pyDict["batch_size"] = ToPython(batch_size);
                        self = sklearn.utils.parallel.self.InvokeMethod("Parallel", args, pyDict);
                    }

                    internal Parallel(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static Parallel Encapsule(PyObject pyObject)
                    {
                        return new Parallel(pyObject);
                    }

                    public void dispatch_next()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("dispatch_next", args, pyDict);
                    }

                    public void dispatch_one_batch()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("dispatch_one_batch", args, pyDict);
                    }

                    public void format(int indent = 0)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (indent != 0)
                            pyDict["indent"] = ToPython(indent);
                        self.InvokeMethod("format", args, pyDict);
                    }

                    public void print_progress()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("print_progress", args, pyDict);
                    }
                }

                public static PyTuple delayed(PyObject function)
                {
                    PyTuple args = ToTuple(new object[] { function });
                    PyDict pyDict = new PyDict();
                    return new PyTuple(sklearn.utils.parallel.self.InvokeMethod("delayed", args, pyDict));
                }
            }

            public static class random
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
                    return Py.Import("sklearn.utils.random");
                }

                static random()
                {
                    ReInitializeLazySelf();
                }

                public static NDarray sample_without_replacement(int n_population, int n_samples, string method = "auto", int? random_state = null)
                {
                    PyTuple args = ToTuple(new object[] { n_population, n_samples });
                    PyDict pyDict = new PyDict();
                    if (method != "auto")
                        pyDict["method"] = ToPython(method);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    return ToCsharp<NDarray>(sklearn.utils.random.self.InvokeMethod("sample_without_replacement", args, pyDict));
                }
            }

            public static class sparsefuncs
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
                    return Py.Import("sklearn.utils.sparsefuncs");
                }

                static sparsefuncs()
                {
                    ReInitializeLazySelf();
                }

                public static (NDarray, NDarray, NDarray) incr_mean_variance_axis(NDarray X, PyObject axis, NDarray last_mean, NDarray last_var, NDarray last_n, NDarray? weights = null)
                {
                    PyTuple args = ToTuple(new object[] { X, axis, last_mean, last_var, last_n });
                    PyDict pyDict = new PyDict();
                    if (weights != null)
                        pyDict["weights"] = ToPython(weights);
                    PyTuple result = new PyTuple(sklearn.utils.sparsefuncs.self.InvokeMethod("incr_mean_variance_axis", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
                }

                public static void inplace_column_scale(NDarray X, NDarray scale)
                {
                    PyTuple args = ToTuple(new object[] { X, scale });
                    PyDict pyDict = new PyDict();
                    sklearn.utils.sparsefuncs.self.InvokeMethod("inplace_column_scale", args, pyDict);
                }

                public static void inplace_csr_column_scale(NDarray X, NDarray scale)
                {
                    PyTuple args = ToTuple(new object[] { X, scale });
                    PyDict pyDict = new PyDict();
                    sklearn.utils.sparsefuncs.self.InvokeMethod("inplace_csr_column_scale", args, pyDict);
                }

                public static void inplace_row_scale(NDarray X, NDarray scale)
                {
                    PyTuple args = ToTuple(new object[] { X, scale });
                    PyDict pyDict = new PyDict();
                    sklearn.utils.sparsefuncs.self.InvokeMethod("inplace_row_scale", args, pyDict);
                }

                public static void inplace_swap_column(NDarray X, int m, int n)
                {
                    PyTuple args = ToTuple(new object[] { X, m, n });
                    PyDict pyDict = new PyDict();
                    sklearn.utils.sparsefuncs.self.InvokeMethod("inplace_swap_column", args, pyDict);
                }

                public static void inplace_swap_row(NDarray X, int m, int n)
                {
                    PyTuple args = ToTuple(new object[] { X, m, n });
                    PyDict pyDict = new PyDict();
                    sklearn.utils.sparsefuncs.self.InvokeMethod("inplace_swap_row", args, pyDict);
                }

                public static (NDarray, NDarray, NDarray) mean_variance_axis(NDarray X, PyObject axis, NDarray? weights = null, bool return_sum_weights = false)
                {
                    PyTuple args = ToTuple(new object[] { X, axis });
                    PyDict pyDict = new PyDict();
                    if (weights != null)
                        pyDict["weights"] = ToPython(weights);
                    if (return_sum_weights != false)
                        pyDict["return_sum_weights"] = ToPython(return_sum_weights);
                    PyTuple result = new PyTuple(sklearn.utils.sparsefuncs.self.InvokeMethod("mean_variance_axis", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
                }
            }

            public static class sparsefuncs_fast
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
                    return Py.Import("sklearn.utils.sparsefuncs_fast");
                }

                static sparsefuncs_fast()
                {
                    ReInitializeLazySelf();
                }

                public static void inplace_csr_row_normalize_l1(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    sklearn.utils.sparsefuncs_fast.self.InvokeMethod("inplace_csr_row_normalize_l1", args, pyDict);
                }

                public static void inplace_csr_row_normalize_l2(PyObject X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    sklearn.utils.sparsefuncs_fast.self.InvokeMethod("inplace_csr_row_normalize_l2", args, pyDict);
                }
            }

            public static class validation
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
                    return Py.Import("sklearn.utils.validation");
                }

                static validation()
                {
                    ReInitializeLazySelf();
                }

                public static void check_is_fitted(PyObject estimator, string? attributes = null, string? msg = null, PyObject? all_or_any = null)
                {
                    PyTuple args = ToTuple(new object[] { estimator });
                    PyDict pyDict = new PyDict();
                    if (attributes != null)
                        pyDict["attributes"] = ToPython(attributes);
                    if (msg != null)
                        pyDict["msg"] = ToPython(msg);
                    if (all_or_any != null)
                        pyDict["all_or_any"] = ToPython(all_or_any);
                    sklearn.utils.validation.self.InvokeMethod("check_is_fitted", args, pyDict);
                }

                public static PyObject check_memory(PyObject memory)
                {
                    PyTuple args = ToTuple(new object[] { memory });
                    PyDict pyDict = new PyDict();
                    return sklearn.utils.validation.self.InvokeMethod("check_memory", args, pyDict);
                }

                public static NDarray check_symmetric(NDarray array, float tol = 1e-10f, bool raise_warning = true, bool raise_exception = false)
                {
                    PyTuple args = ToTuple(new object[] { array });
                    PyDict pyDict = new PyDict();
                    if (tol != 1e-10f)
                        pyDict["tol"] = ToPython(tol);
                    if (raise_warning != true)
                        pyDict["raise_warning"] = ToPython(raise_warning);
                    if (raise_exception != false)
                        pyDict["raise_exception"] = ToPython(raise_exception);
                    return ToCsharp<NDarray>(sklearn.utils.validation.self.InvokeMethod("check_symmetric", args, pyDict));
                }

                public static NDarray column_or_1d(NDarray y, PyObject? dtype = null, bool warn = false)
                {
                    PyTuple args = ToTuple(new object[] { y });
                    PyDict pyDict = new PyDict();
                    if (dtype != null)
                        pyDict["dtype"] = ToPython(dtype);
                    if (warn != false)
                        pyDict["warn"] = ToPython(warn);
                    return ToCsharp<NDarray>(sklearn.utils.validation.self.InvokeMethod("column_or_1d", args, pyDict));
                }

                public static bool has_fit_parameter(PyObject estimator, string parameter)
                {
                    PyTuple args = ToTuple(new object[] { estimator, parameter });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<bool>(sklearn.utils.validation.self.InvokeMethod("has_fit_parameter", args, pyDict));
                }
            }
        }
    }
}