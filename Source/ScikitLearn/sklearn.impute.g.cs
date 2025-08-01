namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class impute
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
            return Py.Import("sklearn.impute");
        }

        static impute() => ReInitializeLazySelf();
        public class IterativeImputer : PythonObject
        {
            public IterativeImputer(PyObject? estimator = null, int? missing_values = null, bool sample_posterior = false, int max_iter = 10, float tol = 0.001f, int? n_nearest_features = null, string initial_strategy = "mean", string? fill_value = null, string imputation_order = "ascending", bool skip_complete = false, NDarray? min_value = null, float max_value = float.PositiveInfinity, int verbose = 0, int? random_state = null, bool add_indicator = false, bool keep_empty_features = false)
            {
                _ = sklearn.impute.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (estimator != null)
                    pyDict["estimator"] = Helpers.ToPython(estimator);
                if (missing_values != null)
                    pyDict["missing_values"] = Helpers.ToPython(missing_values);
                if (sample_posterior != false)
                    pyDict["sample_posterior"] = Helpers.ToPython(sample_posterior);
                if (max_iter != 10)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (n_nearest_features != null)
                    pyDict["n_nearest_features"] = Helpers.ToPython(n_nearest_features);
                if (initial_strategy != "mean")
                    pyDict["initial_strategy"] = Helpers.ToPython(initial_strategy);
                if (fill_value != null)
                    pyDict["fill_value"] = Helpers.ToPython(fill_value);
                if (imputation_order != "ascending")
                    pyDict["imputation_order"] = Helpers.ToPython(imputation_order);
                if (skip_complete != false)
                    pyDict["skip_complete"] = Helpers.ToPython(skip_complete);
                if (min_value != null)
                    pyDict["min_value"] = Helpers.ToPython(min_value);
                if (max_value != float.PositiveInfinity)
                    pyDict["max_value"] = Helpers.ToPython(max_value);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (add_indicator != false)
                    pyDict["add_indicator"] = Helpers.ToPython(add_indicator);
                if (keep_empty_features != false)
                    pyDict["keep_empty_features"] = Helpers.ToPython(keep_empty_features);
                self = sklearn.impute.self.InvokeMethod("IterativeImputer", args, pyDict);
            }

            internal IterativeImputer(PyObject pyObject)
            {
                _ = sklearn.impute.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static IterativeImputer Encapsule(PyObject pyObject) => new IterativeImputer(pyObject);
            public static IterativeImputer Wrap(PyObject pyObject) => new IterativeImputer(pyObject);
            public PyObject initial_imputer_
            {
                get
                {
                    var __pyObject = self.GetAttr("initial_imputer_");
                    return __pyObject;
                }
            }

            public PyTuple imputation_sequence_
            {
                get
                {
                    var __pyObject = self.GetAttr("imputation_sequence_");
                    return new PyTuple(__pyObject);
                }
            }

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_features_with_missing_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_with_missing_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject indicator_
            {
                get
                {
                    var __pyObject = self.GetAttr("indicator_");
                    return __pyObject;
                }
            }

            public PyObject random_state_
            {
                get
                {
                    var __pyObject = self.GetAttr("random_state_");
                    return __pyObject;
                }
            }

            public IterativeImputer fit(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("fit_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                var __pyObject = self.InvokeMethod("get_feature_names_out", args, pyDict);
                return __pyObject;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public IterativeImputer set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public IterativeImputer set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class KNNImputer : PythonObject
        {
            public KNNImputer(string? missing_values = null, int n_neighbors = 5, string weights = "uniform", string metric = "nan_euclidean", bool copy = true, bool add_indicator = false, bool keep_empty_features = false)
            {
                _ = sklearn.impute.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (missing_values != null)
                    pyDict["missing_values"] = Helpers.ToPython(missing_values);
                if (n_neighbors != 5)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (weights != "uniform")
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (metric != "nan_euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                if (add_indicator != false)
                    pyDict["add_indicator"] = Helpers.ToPython(add_indicator);
                if (keep_empty_features != false)
                    pyDict["keep_empty_features"] = Helpers.ToPython(keep_empty_features);
                self = sklearn.impute.self.InvokeMethod("KNNImputer", args, pyDict);
            }

            internal KNNImputer(PyObject pyObject)
            {
                _ = sklearn.impute.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static KNNImputer Encapsule(PyObject pyObject) => new KNNImputer(pyObject);
            public static KNNImputer Wrap(PyObject pyObject) => new KNNImputer(pyObject);
            public PyObject indicator_
            {
                get
                {
                    var __pyObject = self.GetAttr("indicator_");
                    return __pyObject;
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public KNNImputer fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("fit_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                var __pyObject = self.InvokeMethod("get_feature_names_out", args, pyDict);
                return __pyObject;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public KNNImputer set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public KNNImputer set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class MissingIndicator : PythonObject
        {
            public MissingIndicator(string? missing_values = null, string features = "missing-only", string sparse = "auto", bool error_on_new = true)
            {
                _ = sklearn.impute.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (missing_values != null)
                    pyDict["missing_values"] = Helpers.ToPython(missing_values);
                if (features != "missing-only")
                    pyDict["features"] = Helpers.ToPython(features);
                if (sparse != "auto")
                    pyDict["sparse"] = Helpers.ToPython(sparse);
                if (error_on_new != true)
                    pyDict["error_on_new"] = Helpers.ToPython(error_on_new);
                self = sklearn.impute.self.InvokeMethod("MissingIndicator", args, pyDict);
            }

            internal MissingIndicator(PyObject pyObject)
            {
                _ = sklearn.impute.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static MissingIndicator Encapsule(PyObject pyObject) => new MissingIndicator(pyObject);
            public static MissingIndicator Wrap(PyObject pyObject) => new MissingIndicator(pyObject);
            public NDarray features_
            {
                get
                {
                    var __pyObject = self.GetAttr("features_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public MissingIndicator fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("fit_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                var __pyObject = self.InvokeMethod("get_feature_names_out", args, pyDict);
                return __pyObject;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public MissingIndicator set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public MissingIndicator set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class SimpleImputer : PythonObject
        {
            public SimpleImputer(string? missing_values = null, string strategy = "mean", string? fill_value = null, bool copy = true, bool add_indicator = false, bool keep_empty_features = false)
            {
                _ = sklearn.impute.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (missing_values != null)
                    pyDict["missing_values"] = Helpers.ToPython(missing_values);
                if (strategy != "mean")
                    pyDict["strategy"] = Helpers.ToPython(strategy);
                if (fill_value != null)
                    pyDict["fill_value"] = Helpers.ToPython(fill_value);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                if (add_indicator != false)
                    pyDict["add_indicator"] = Helpers.ToPython(add_indicator);
                if (keep_empty_features != false)
                    pyDict["keep_empty_features"] = Helpers.ToPython(keep_empty_features);
                self = sklearn.impute.self.InvokeMethod("SimpleImputer", args, pyDict);
            }

            internal SimpleImputer(PyObject pyObject)
            {
                _ = sklearn.impute.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static SimpleImputer Encapsule(PyObject pyObject) => new SimpleImputer(pyObject);
            public static SimpleImputer Wrap(PyObject pyObject) => new SimpleImputer(pyObject);
            public NDarray statistics_
            {
                get
                {
                    var __pyObject = self.GetAttr("statistics_");
                    return new NDarray(__pyObject);
                }
            }

            public PyObject indicator_
            {
                get
                {
                    var __pyObject = self.GetAttr("indicator_");
                    return __pyObject;
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public SimpleImputer fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("fit_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                var __pyObject = self.InvokeMethod("get_feature_names_out", args, pyDict);
                return __pyObject;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray inverse_transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("inverse_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public SimpleImputer set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public SimpleImputer set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }
    }
}