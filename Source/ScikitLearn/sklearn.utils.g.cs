namespace ScikitLearn;
#nullable enable
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

        public static PyObject _safe_indexing(NDarray X, NDarray indices, int axis = 0)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(indices) });
            PyDict pyDict = new PyDict();
            if (axis != 0)
                pyDict["axis"] = Helpers.ToPython(axis);
            return new NotImplementedException();
        }

        public static NDarray as_float_array(NDarray X, bool copy = true, bool force_all_finite = true)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (copy != true)
                pyDict["copy"] = Helpers.ToPython(copy);
            if (force_all_finite != true)
                pyDict["force_all_finite"] = Helpers.ToPython(force_all_finite);
            return new NotImplementedException();
        }

        public static void assert_all_finite(NDarray X, bool allow_nan = false, string? estimator_name = null, string input_name = "")
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (allow_nan != false)
                pyDict["allow_nan"] = Helpers.ToPython(allow_nan);
            if (estimator_name != null)
                pyDict["estimator_name"] = Helpers.ToPython(estimator_name);
            if (input_name != "")
                pyDict["input_name"] = Helpers.ToPython(input_name);
            return new NotImplementedException();
        }

        public static string estimator_html_repr(PyObject estimator)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
            PyDict pyDict = new PyDict();
            return self.InvokeMethod("estimator_html_repr", args, pyDict).As<string>()}

        public static PyObject gen_batches(int n, int batch_size, int min_batch_size = 0)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n), Helpers.ToPython(batch_size) });
            PyDict pyDict = new PyDict();
            if (min_batch_size != 0)
                pyDict["min_batch_size"] = Helpers.ToPython(min_batch_size);
            return new NotImplementedException();
        }

        public static PyObject gen_even_slices(int n, int n_packs, int? n_samples = null)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n), Helpers.ToPython(n_packs) });
            PyDict pyDict = new PyDict();
            if (n_samples != null)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            return new NotImplementedException();
        }

        public static NDarray? indexable(PyObject[] iterables)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(iterables) });
            PyDict pyDict = new PyDict();
            return new NotImplementedException();
        }

        public static void murmurhash3_32(NDarray key, int seed = 0, bool positive = false)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(key) });
            PyDict pyDict = new PyDict();
            if (seed != 0)
                pyDict["seed"] = Helpers.ToPython(seed);
            if (positive != false)
                pyDict["positive"] = Helpers.ToPython(positive);
            return new NotImplementedException();
        }

        public static NDarray resample(NDarray[] arrays, bool replace = true, int? n_samples = null, int? random_state = null, NDarray? stratify = null)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(arrays) });
            PyDict pyDict = new PyDict();
            if (replace != true)
                pyDict["replace"] = Helpers.ToPython(replace);
            if (n_samples != null)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (stratify != null)
                pyDict["stratify"] = Helpers.ToPython(stratify);
            return new NotImplementedException();
        }

        public static NDarray safe_mask(NDarray X, NDarray mask)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(mask) });
            PyDict pyDict = new PyDict();
            return new NotImplementedException();
        }

        public static PyObject safe_sqr(NDarray X, bool copy = true)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (copy != true)
                pyDict["copy"] = Helpers.ToPython(copy);
            return new NotImplementedException();
        }

        public static NDarray shuffle(NDarray[] arrays, int? random_state = null, int? n_samples = null)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(arrays) });
            PyDict pyDict = new PyDict();
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (n_samples != null)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            return new NotImplementedException();
        }

        public static (PyObject? , PyObject? ) check_X_y(NDarray X, NDarray y, bool accept_sparse = false, bool accept_large_sparse = true, string? dtype = "numeric", PyObject? order = null, bool copy = false, bool force_writeable = false, bool force_all_finite = true, bool ensure_2d = true, bool allow_nd = false, bool multi_output = false, int ensure_min_samples = 1, int ensure_min_features = 1, bool y_numeric = false, string? estimator = null)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
            PyDict pyDict = new PyDict();
            if (accept_sparse != false)
                pyDict["accept_sparse"] = Helpers.ToPython(accept_sparse);
            if (accept_large_sparse != true)
                pyDict["accept_large_sparse"] = Helpers.ToPython(accept_large_sparse);
            if (dtype != "numeric")
                pyDict["dtype"] = Helpers.ToPython(dtype);
            if (order != null)
                pyDict["order"] = Helpers.ToPython(order);
            if (copy != false)
                pyDict["copy"] = Helpers.ToPython(copy);
            if (force_writeable != false)
                pyDict["force_writeable"] = Helpers.ToPython(force_writeable);
            if (force_all_finite != true)
                pyDict["force_all_finite"] = Helpers.ToPython(force_all_finite);
            if (ensure_2d != true)
                pyDict["ensure_2d"] = Helpers.ToPython(ensure_2d);
            if (allow_nd != false)
                pyDict["allow_nd"] = Helpers.ToPython(allow_nd);
            if (multi_output != false)
                pyDict["multi_output"] = Helpers.ToPython(multi_output);
            if (ensure_min_samples != 1)
                pyDict["ensure_min_samples"] = Helpers.ToPython(ensure_min_samples);
            if (ensure_min_features != 1)
                pyDict["ensure_min_features"] = Helpers.ToPython(ensure_min_features);
            if (y_numeric != false)
                pyDict["y_numeric"] = Helpers.ToPython(y_numeric);
            if (estimator != null)
                pyDict["estimator"] = Helpers.ToPython(estimator);
            return new NotImplementedException();
        }

        public static PyObject check_array(PyObject array, bool accept_sparse = false, bool accept_large_sparse = true, string? dtype = "numeric", PyObject? order = null, bool copy = false, bool force_writeable = false, bool force_all_finite = true, bool ensure_2d = true, bool allow_nd = false, int ensure_min_samples = 1, int ensure_min_features = 1, string? estimator = null, string input_name = "")
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(array) });
            PyDict pyDict = new PyDict();
            if (accept_sparse != false)
                pyDict["accept_sparse"] = Helpers.ToPython(accept_sparse);
            if (accept_large_sparse != true)
                pyDict["accept_large_sparse"] = Helpers.ToPython(accept_large_sparse);
            if (dtype != "numeric")
                pyDict["dtype"] = Helpers.ToPython(dtype);
            if (order != null)
                pyDict["order"] = Helpers.ToPython(order);
            if (copy != false)
                pyDict["copy"] = Helpers.ToPython(copy);
            if (force_writeable != false)
                pyDict["force_writeable"] = Helpers.ToPython(force_writeable);
            if (force_all_finite != true)
                pyDict["force_all_finite"] = Helpers.ToPython(force_all_finite);
            if (ensure_2d != true)
                pyDict["ensure_2d"] = Helpers.ToPython(ensure_2d);
            if (allow_nd != false)
                pyDict["allow_nd"] = Helpers.ToPython(allow_nd);
            if (ensure_min_samples != 1)
                pyDict["ensure_min_samples"] = Helpers.ToPython(ensure_min_samples);
            if (ensure_min_features != 1)
                pyDict["ensure_min_features"] = Helpers.ToPython(ensure_min_features);
            if (estimator != null)
                pyDict["estimator"] = Helpers.ToPython(estimator);
            if (input_name != "")
                pyDict["input_name"] = Helpers.ToPython(input_name);
            return new NotImplementedException();
        }

        public static void check_consistent_length(NDarray[] arrays)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(arrays) });
            PyDict pyDict = new PyDict();
            return new NotImplementedException();
        }

        public static PyObject check_random_state(int seed)
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(seed) });
            PyDict pyDict = new PyDict();
            return new NotImplementedException();
        }

        public static PyObject check_scalar(PyObject x, string name, PyTuple target_type, float? min_val = null, float? max_val = null, string include_boundaries = "both")
        {
            _ = sklearn.utils.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(x), Helpers.ToPython(name), Helpers.ToPython(target_type) });
            PyDict pyDict = new PyDict();
            if (min_val != null)
                pyDict["min_val"] = Helpers.ToPython(min_val);
            if (max_val != null)
                pyDict["max_val"] = Helpers.ToPython(max_val);
            if (include_boundaries != "both")
                pyDict["include_boundaries"] = Helpers.ToPython(include_boundaries);
            return new NotImplementedException();
        }

        public class Bunch : PythonObject
        {
            public Bunch()
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.utils.self.InvokeMethod("Bunch", args, pyDict);
            }

            internal Bunch(PyObject pyObject)
            {
                _ = sklearn.utils.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static Bunch Encapsule(PyObject pyObject) => new Bunch(pyObject);
            public static Bunch Wrap(PyObject pyObject) => new Bunch(pyObject);
            public void clear()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void copy()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void fromkeys()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void get()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void items()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void keys()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void pop()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void popitem()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void setdefault()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void update()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public void values()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }
        }

        public class deprecated : PythonObject
        {
            public deprecated(string extra = "")
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (extra != "")
                    pyDict["extra"] = Helpers.ToPython(extra);
                self = sklearn.utils.self.InvokeMethod("deprecated", args, pyDict);
            }

            internal deprecated(PyObject pyObject)
            {
                _ = sklearn.utils.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static deprecated Encapsule(PyObject pyObject) => new deprecated(pyObject);
            public static deprecated Wrap(PyObject pyObject) => new deprecated(pyObject);
        }

        public static class arrayfuncs
        {
            public static float min_pos(NDarray X)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("min_pos", args, pyDict).As<float>()}
        }

        public static class class_weight
        {
            public static NDarray compute_class_weight(PyDict class_weight, NDarray classes, NDarray y)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(class_weight), Helpers.ToPython(classes), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static NDarray compute_sample_weight(PyDict class_weight, NDarray y, NDarray? indices = null)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(class_weight), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (indices != null)
                    pyDict["indices"] = Helpers.ToPython(indices);
                return new NotImplementedException();
            }
        }

        public static class discovery
        {
            public static PyTuple all_displays()
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static PyTuple all_estimators(PyTuple? type_filter = null)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (type_filter != null)
                    pyDict["type_filter"] = Helpers.ToPython(type_filter);
                return new NotImplementedException();
            }

            public static PyTuple all_functions()
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }
        }

        public static class estimator_checks
        {
            public static PyObject check_estimator(PyObject? estimator = null, bool generate_only = false)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (estimator != null)
                    pyDict["estimator"] = Helpers.ToPython(estimator);
                if (generate_only != false)
                    pyDict["generate_only"] = Helpers.ToPython(generate_only);
                return new NotImplementedException();
            }

            public static PyObject parametrize_with_checks(PyTuple estimators)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimators) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }
        }

        public static class extmath
        {
            public static float density(NDarray w)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(w) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("density", args, pyDict).As<float>()}

            public static float fast_logdet(NDarray A)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(A) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("fast_logdet", args, pyDict).As<float>()}

            public static NDarray randomized_range_finder(NDarray A, int size, int n_iter, string power_iteration_normalizer = "auto", int? random_state = null)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(A), Helpers.ToPython(size), Helpers.ToPython(n_iter) });
                PyDict pyDict = new PyDict();
                if (power_iteration_normalizer != "auto")
                    pyDict["power_iteration_normalizer"] = Helpers.ToPython(power_iteration_normalizer);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                return new NotImplementedException();
            }

            public static (NDarray? , NDarray? , NDarray? ) randomized_svd(NDarray M, int n_components, int n_oversamples = 10, string n_iter = "auto", string power_iteration_normalizer = "auto", string transpose = "auto", bool flip_sign = true, int? random_state = null, string svd_lapack_driver = "gesdd")
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(M), Helpers.ToPython(n_components) });
                PyDict pyDict = new PyDict();
                if (n_oversamples != 10)
                    pyDict["n_oversamples"] = Helpers.ToPython(n_oversamples);
                if (n_iter != "auto")
                    pyDict["n_iter"] = Helpers.ToPython(n_iter);
                if (power_iteration_normalizer != "auto")
                    pyDict["power_iteration_normalizer"] = Helpers.ToPython(power_iteration_normalizer);
                if (transpose != "auto")
                    pyDict["transpose"] = Helpers.ToPython(transpose);
                if (flip_sign != true)
                    pyDict["flip_sign"] = Helpers.ToPython(flip_sign);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (svd_lapack_driver != "gesdd")
                    pyDict["svd_lapack_driver"] = Helpers.ToPython(svd_lapack_driver);
                return new NotImplementedException();
            }

            public static NDarray safe_sparse_dot(NDarray a, NDarray b, bool dense_output = false)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(a), Helpers.ToPython(b) });
                PyDict pyDict = new PyDict();
                if (dense_output != false)
                    pyDict["dense_output"] = Helpers.ToPython(dense_output);
                return new NotImplementedException();
            }

            public static (NDarray? , NDarray? ) weighted_mode(NDarray a, NDarray w, int axis = 0)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(a), Helpers.ToPython(w) });
                PyDict pyDict = new PyDict();
                if (axis != 0)
                    pyDict["axis"] = Helpers.ToPython(axis);
                return new NotImplementedException();
            }
        }

        public static class graph
        {
            public static PyDict single_source_shortest_path_length(NDarray graph, int source, int? cutoff = null)
            {
                _ = sklearn.utils.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(graph), Helpers.ToPython(source) });
                PyDict pyDict = new PyDict();
                if (cutoff != null)
                    pyDict["cutoff"] = Helpers.ToPython(cutoff);
                return new NotImplementedException();
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

            public static PyObject get_routing_for_object(PyObject? obj = null)
            {
                _ = sklearn.utils.metadata_routing.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (obj != null)
                    pyDict["obj"] = Helpers.ToPython(obj);
                return new NotImplementedException();
            }

            public static PyDict process_routing(PyObject _obj, string _method, Dictionary<string, PyObject>? @params = null)
            {
                _ = sklearn.utils.metadata_routing.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(_obj), Helpers.ToPython(_method) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return new NotImplementedException();
            }

            public class MetadataRequest : PythonObject
            {
                public MetadataRequest(string owner)
                {
                    _ = sklearn.utils.metadata_routing.self;
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(owner) });
                    PyDict pyDict = new PyDict();
                    self = sklearn.utils.metadata_routing.self.InvokeMethod("MetadataRequest", args, pyDict);
                }

                internal MetadataRequest(PyObject pyObject)
                {
                    _ = sklearn.utils.metadata_routing.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static MetadataRequest Encapsule(PyObject pyObject) => new MetadataRequest(pyObject);
                public static MetadataRequest Wrap(PyObject pyObject) => new MetadataRequest(pyObject);
                public string consumes(string method, string @params)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(method), Helpers.ToPython(@params) });
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("consumes", args, pyDict).As<string>()}
            }

            public class MetadataRouter : PythonObject
            {
                public MetadataRouter(string owner)
                {
                    _ = sklearn.utils.metadata_routing.self;
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(owner) });
                    PyDict pyDict = new PyDict();
                    self = sklearn.utils.metadata_routing.self.InvokeMethod("MetadataRouter", args, pyDict);
                }

                internal MetadataRouter(PyObject pyObject)
                {
                    _ = sklearn.utils.metadata_routing.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static MetadataRouter Encapsule(PyObject pyObject) => new MetadataRouter(pyObject);
                public static MetadataRouter Wrap(PyObject pyObject) => new MetadataRouter(pyObject);
                public MetadataRouter add(PyObject method_mapping, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(method_mapping) });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("add", args, pyDict);
                    return this;
                }

                public MetadataRouter add_self_request(PyObject obj)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(obj) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("add_self_request", args, pyDict);
                    return this;
                }

                public string consumes(string method, string @params)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(method), Helpers.ToPython(@params) });
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("consumes", args, pyDict).As<string>()}

                public PyDict route_params(string caller, PyDict @params)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(caller), Helpers.ToPython(@params) });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public void validate_metadata(string method, PyDict @params)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(method), Helpers.ToPython(@params) });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }
            }

            public class MethodMapping : PythonObject
            {
                public MethodMapping()
                {
                    _ = sklearn.utils.metadata_routing.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self = sklearn.utils.metadata_routing.self.InvokeMethod("MethodMapping", args, pyDict);
                }

                internal MethodMapping(PyObject pyObject)
                {
                    _ = sklearn.utils.metadata_routing.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static MethodMapping Encapsule(PyObject pyObject) => new MethodMapping(pyObject);
                public static MethodMapping Wrap(PyObject pyObject) => new MethodMapping(pyObject);
                public MethodMapping add(string caller, string callee)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(caller), Helpers.ToPython(callee) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("add", args, pyDict);
                    return this;
                }
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
                _ = sklearn.utils.metaestimators.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(check) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
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
                _ = sklearn.utils.multiclass.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("is_multilabel", args, pyDict);
            }

            public static string type_of_target(NDarray y, string input_name = "")
            {
                _ = sklearn.utils.multiclass.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (input_name != "")
                    pyDict["input_name"] = Helpers.ToPython(input_name);
                return self.InvokeMethod("type_of_target", args, pyDict).As<string>()}

            public static NDarray unique_labels(NDarray[] ys)
            {
                _ = sklearn.utils.multiclass.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(ys) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
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

            public static PyTuple delayed(PyObject function)
            {
                _ = sklearn.utils.parallel.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(function) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public class Parallel : PythonObject
            {
                public Parallel(string return_as = "list", string pre_dispatch = "2 * n_jobs", string batch_size = "auto")
                {
                    _ = sklearn.utils.parallel.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (return_as != "list")
                        pyDict["return_as"] = Helpers.ToPython(return_as);
                    if (pre_dispatch != "2 * n_jobs")
                        pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
                    if (batch_size != "auto")
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    self = sklearn.utils.parallel.self.InvokeMethod("Parallel", args, pyDict);
                }

                internal Parallel(PyObject pyObject)
                {
                    _ = sklearn.utils.parallel.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static Parallel Encapsule(PyObject pyObject) => new Parallel(pyObject);
                public static Parallel Wrap(PyObject pyObject) => new Parallel(pyObject);
                public void dispatch_next()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public void dispatch_one_batch()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public void format(int indent = 0)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (indent != 0)
                        pyDict["indent"] = Helpers.ToPython(indent);
                    return new NotImplementedException();
                }

                public void print_progress()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }
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
                _ = sklearn.utils.random.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_population), Helpers.ToPython(n_samples) });
                PyDict pyDict = new PyDict();
                if (method != "auto")
                    pyDict["method"] = Helpers.ToPython(method);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                return new NotImplementedException();
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

            public static (NDarray? , NDarray? , NDarray? ) incr_mean_variance_axis(NDarray X, PyObject axis, NDarray last_mean, NDarray last_var, NDarray last_n, NDarray? weights = null)
            {
                _ = sklearn.utils.sparsefuncs.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(axis), Helpers.ToPython(last_mean), Helpers.ToPython(last_var), Helpers.ToPython(last_n) });
                PyDict pyDict = new PyDict();
                if (weights != null)
                    pyDict["weights"] = Helpers.ToPython(weights);
                return new NotImplementedException();
            }

            public static void inplace_column_scale(NDarray X, NDarray scale)
            {
                _ = sklearn.utils.sparsefuncs.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(scale) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static void inplace_csr_column_scale(NDarray X, NDarray scale)
            {
                _ = sklearn.utils.sparsefuncs.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(scale) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static void inplace_row_scale(NDarray X, NDarray scale)
            {
                _ = sklearn.utils.sparsefuncs.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(scale) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static void inplace_swap_column(NDarray X, int m, int n)
            {
                _ = sklearn.utils.sparsefuncs.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(m), Helpers.ToPython(n) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static void inplace_swap_row(NDarray X, int m, int n)
            {
                _ = sklearn.utils.sparsefuncs.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(m), Helpers.ToPython(n) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static (NDarray? , NDarray? , NDarray? ) mean_variance_axis(NDarray X, PyObject axis, NDarray? weights = null, bool return_sum_weights = false)
            {
                _ = sklearn.utils.sparsefuncs.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(axis) });
                PyDict pyDict = new PyDict();
                if (weights != null)
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (return_sum_weights != false)
                    pyDict["return_sum_weights"] = Helpers.ToPython(return_sum_weights);
                return new NotImplementedException();
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
                _ = sklearn.utils.sparsefuncs_fast.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static void inplace_csr_row_normalize_l2(PyObject X)
            {
                _ = sklearn.utils.sparsefuncs_fast.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
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
                _ = sklearn.utils.validation.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
                PyDict pyDict = new PyDict();
                if (attributes != null)
                    pyDict["attributes"] = Helpers.ToPython(attributes);
                if (msg != null)
                    pyDict["msg"] = Helpers.ToPython(msg);
                if (all_or_any != null)
                    pyDict["all_or_any"] = Helpers.ToPython(all_or_any);
                return new NotImplementedException();
            }

            public static PyObject check_memory(PyObject memory)
            {
                _ = sklearn.utils.validation.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(memory) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public static NDarray check_symmetric(NDarray array, float tol = 1e-10f, bool raise_warning = true, bool raise_exception = false)
            {
                _ = sklearn.utils.validation.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(array) });
                PyDict pyDict = new PyDict();
                if (tol != 1e-10f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (raise_warning != true)
                    pyDict["raise_warning"] = Helpers.ToPython(raise_warning);
                if (raise_exception != false)
                    pyDict["raise_exception"] = Helpers.ToPython(raise_exception);
                return new NotImplementedException();
            }

            public static NDarray column_or_1d(NDarray y, PyObject? dtype = null, bool warn = false)
            {
                _ = sklearn.utils.validation.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (dtype != null)
                    pyDict["dtype"] = Helpers.ToPython(dtype);
                if (warn != false)
                    pyDict["warn"] = Helpers.ToPython(warn);
                return new NotImplementedException();
            }

            public static bool has_fit_parameter(PyObject estimator, string parameter)
            {
                _ = sklearn.utils.validation.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(parameter) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("has_fit_parameter", args, pyDict);
            }
        }
    }
}