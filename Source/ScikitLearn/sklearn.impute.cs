using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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

            static impute()
            {
                ReInitializeLazySelf();
            }

            public class IterativeImputer : PythonObject
            {
                public IterativeImputer(PyObject? estimator = null, int? missing_values = null, bool sample_posterior = false, int max_iter = 10, float tol = 0.001f, int? n_nearest_features = null, string initial_strategy = "mean", string? fill_value = null, string imputation_order = "ascending", bool skip_complete = false, NDarray? min_value = null, float max_value = float.PositiveInfinity, int verbose = 0, int? random_state = null, bool add_indicator = false, bool keep_empty_features = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (estimator != null)
                        pyDict["estimator"] = ToPython(estimator);
                    if (missing_values != null)
                        pyDict["missing_values"] = ToPython(missing_values);
                    if (sample_posterior != false)
                        pyDict["sample_posterior"] = ToPython(sample_posterior);
                    if (max_iter != 10)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (n_nearest_features != null)
                        pyDict["n_nearest_features"] = ToPython(n_nearest_features);
                    if (initial_strategy != "mean")
                        pyDict["initial_strategy"] = ToPython(initial_strategy);
                    if (fill_value != null)
                        pyDict["fill_value"] = ToPython(fill_value);
                    if (imputation_order != "ascending")
                        pyDict["imputation_order"] = ToPython(imputation_order);
                    if (skip_complete != false)
                        pyDict["skip_complete"] = ToPython(skip_complete);
                    if (min_value != null)
                        pyDict["min_value"] = ToPython(min_value);
                    if (max_value != float.PositiveInfinity)
                        pyDict["max_value"] = ToPython(max_value);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (add_indicator != false)
                        pyDict["add_indicator"] = ToPython(add_indicator);
                    if (keep_empty_features != false)
                        pyDict["keep_empty_features"] = ToPython(keep_empty_features);
                    self = sklearn.impute.self.InvokeMethod("IterativeImputer", args, pyDict);
                }

                internal IterativeImputer(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static IterativeImputer Encapsule(PyObject pyObject)
                {
                    return new IterativeImputer(pyObject);
                }

                public PyObject initial_imputer_ => self.GetAttr("initial_imputer_");
                public PyTuple imputation_sequence_ => new PyTuple(self.GetAttr("imputation_sequence_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_features_with_missing_ => ToCsharp<int>(self.GetAttr("n_features_with_missing_"));
                public PyObject indicator_ => self.GetAttr("indicator_");
                public PyObject random_state_ => self.GetAttr("random_state_");

                public IterativeImputer fit(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public IterativeImputer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public IterativeImputer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class KNNImputer : PythonObject
            {
                public KNNImputer(string? missing_values = null, int n_neighbors = 5, string weights = "uniform", string metric = "nan_euclidean", bool copy = true, bool add_indicator = false, bool keep_empty_features = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (missing_values != null)
                        pyDict["missing_values"] = ToPython(missing_values);
                    if (n_neighbors != 5)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (weights != "uniform")
                        pyDict["weights"] = ToPython(weights);
                    if (metric != "nan_euclidean")
                        pyDict["metric"] = ToPython(metric);
                    if (copy != true)
                        pyDict["copy"] = ToPython(copy);
                    if (add_indicator != false)
                        pyDict["add_indicator"] = ToPython(add_indicator);
                    if (keep_empty_features != false)
                        pyDict["keep_empty_features"] = ToPython(keep_empty_features);
                    self = sklearn.impute.self.InvokeMethod("KNNImputer", args, pyDict);
                }

                internal KNNImputer(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static KNNImputer Encapsule(PyObject pyObject)
                {
                    return new KNNImputer(pyObject);
                }

                public PyObject indicator_ => self.GetAttr("indicator_");
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public KNNImputer fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public KNNImputer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public KNNImputer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class MissingIndicator : PythonObject
            {
                public MissingIndicator(string? missing_values = null, string features = "missing-only", string sparse = "auto", bool error_on_new = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (missing_values != null)
                        pyDict["missing_values"] = ToPython(missing_values);
                    if (features != "missing-only")
                        pyDict["features"] = ToPython(features);
                    if (sparse != "auto")
                        pyDict["sparse"] = ToPython(sparse);
                    if (error_on_new != true)
                        pyDict["error_on_new"] = ToPython(error_on_new);
                    self = sklearn.impute.self.InvokeMethod("MissingIndicator", args, pyDict);
                }

                internal MissingIndicator(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static MissingIndicator Encapsule(PyObject pyObject)
                {
                    return new MissingIndicator(pyObject);
                }

                public NDarray features_ => ToCsharp<NDarray>(self.GetAttr("features_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public MissingIndicator fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public MissingIndicator set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MissingIndicator set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SimpleImputer : PythonObject
            {
                public SimpleImputer(string? missing_values = null, string strategy = "mean", string? fill_value = null, bool copy = true, bool add_indicator = false, bool keep_empty_features = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (missing_values != null)
                        pyDict["missing_values"] = ToPython(missing_values);
                    if (strategy != "mean")
                        pyDict["strategy"] = ToPython(strategy);
                    if (fill_value != null)
                        pyDict["fill_value"] = ToPython(fill_value);
                    if (copy != true)
                        pyDict["copy"] = ToPython(copy);
                    if (add_indicator != false)
                        pyDict["add_indicator"] = ToPython(add_indicator);
                    if (keep_empty_features != false)
                        pyDict["keep_empty_features"] = ToPython(keep_empty_features);
                    self = sklearn.impute.self.InvokeMethod("SimpleImputer", args, pyDict);
                }

                internal SimpleImputer(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SimpleImputer Encapsule(PyObject pyObject)
                {
                    return new SimpleImputer(pyObject);
                }

                public NDarray statistics_ => ToCsharp<NDarray>(self.GetAttr("statistics_"));
                public PyObject indicator_ => self.GetAttr("indicator_");
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SimpleImputer fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SimpleImputer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SimpleImputer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }
        }
    }
}