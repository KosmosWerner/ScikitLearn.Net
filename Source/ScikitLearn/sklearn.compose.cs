using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class compose
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
                return Py.Import("sklearn.compose");
            }

            static compose()
            {
                ReInitializeLazySelf();
            }

            public class ColumnTransformer : PythonObject
            {
                public ColumnTransformer(PyTuple transformers, string remainder = "drop", float sparse_threshold = 0.3f, int? n_jobs = null, PyDict? transformer_weights = null, bool verbose = false, bool verbose_feature_names_out = true, bool force_int_remainder_cols = true)
                {
                    _ = sklearn.compose.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(transformers)]);
                    PyDict pyDict = new PyDict();
                    if (remainder != "drop")
                        pyDict["remainder"] = Helpers.ToPython(remainder);
                    if (sparse_threshold != 0.3f)
                        pyDict["sparse_threshold"] = Helpers.ToPython(sparse_threshold);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (transformer_weights != null)
                        pyDict["transformer_weights"] = Helpers.ToPython(transformer_weights);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (verbose_feature_names_out != true)
                        pyDict["verbose_feature_names_out"] = Helpers.ToPython(verbose_feature_names_out);
                    if (force_int_remainder_cols != true)
                        pyDict["force_int_remainder_cols"] = Helpers.ToPython(force_int_remainder_cols);
                    self = sklearn.compose.self.InvokeMethod("ColumnTransformer", args, pyDict);
                }

                internal ColumnTransformer(PyObject pyObject)
                {
                    _ = sklearn.compose.self;
                    self = pyObject;
                }

                public static ColumnTransformer Encapsule(PyObject pyObject)
                {
                    return new ColumnTransformer(pyObject);
                }

                public PyObject transformers_ => self.GetAttr("transformers_");
                public PyDict named_transformers_ => new PyDict(self.GetAttr("named_transformers_"));
                public bool sparse_output_ => Helpers.ToCSharpBool(self.GetAttr("sparse_output_"));
                public PyDict output_indices_ => new PyDict(self.GetAttr("output_indices_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public ColumnTransformer fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public ColumnTransformer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public ColumnTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class TransformedTargetRegressor : PythonObject
            {
                public TransformedTargetRegressor(PyObject? regressor = null, PyObject? transformer = null, PyObject? func = null, PyObject? inverse_func = null, bool check_inverse = true)
                {
                    _ = sklearn.compose.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (regressor != null)
                        pyDict["regressor"] = Helpers.ToPython(regressor);
                    if (transformer != null)
                        pyDict["transformer"] = Helpers.ToPython(transformer);
                    if (func != null)
                        pyDict["func"] = Helpers.ToPython(func);
                    if (inverse_func != null)
                        pyDict["inverse_func"] = Helpers.ToPython(inverse_func);
                    if (check_inverse != true)
                        pyDict["check_inverse"] = Helpers.ToPython(check_inverse);
                    self = sklearn.compose.self.InvokeMethod("TransformedTargetRegressor", args, pyDict);
                }

                internal TransformedTargetRegressor(PyObject pyObject)
                {
                    _ = sklearn.compose.self;
                    self = pyObject;
                }

                public static TransformedTargetRegressor Encapsule(PyObject pyObject)
                {
                    return new TransformedTargetRegressor(pyObject);
                }

                public PyObject regressor_ => self.GetAttr("regressor_");
                public PyObject transformer_ => self.GetAttr("transformer_");
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public TransformedTargetRegressor fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public void get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public TransformedTargetRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public TransformedTargetRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public static PyObject make_column_selector(string? pattern = null, PyTuple? dtype_include = null, PyTuple? dtype_exclude = null)
            {
                _ = sklearn.compose.self;
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (pattern != null)
                    pyDict["pattern"] = Helpers.ToPython(pattern);
                if (dtype_include != null)
                    pyDict["dtype_include"] = Helpers.ToPython(dtype_include);
                if (dtype_exclude != null)
                    pyDict["dtype_exclude"] = Helpers.ToPython(dtype_exclude);
                return sklearn.compose.self.InvokeMethod("make_column_selector", args, pyDict);
            }

            public static PyObject make_column_transformer(PyObject[] transformers, string remainder = "drop", float sparse_threshold = 0.3f, int? n_jobs = null, bool verbose = false, bool verbose_feature_names_out = true, bool force_int_remainder_cols = true)
            {
                _ = sklearn.compose.self;
                PyTuple args = new PyTuple([Helpers.ToPython(transformers)]);
                PyDict pyDict = new PyDict();
                if (remainder != "drop")
                    pyDict["remainder"] = Helpers.ToPython(remainder);
                if (sparse_threshold != 0.3f)
                    pyDict["sparse_threshold"] = Helpers.ToPython(sparse_threshold);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (verbose_feature_names_out != true)
                    pyDict["verbose_feature_names_out"] = Helpers.ToPython(verbose_feature_names_out);
                if (force_int_remainder_cols != true)
                    pyDict["force_int_remainder_cols"] = Helpers.ToPython(force_int_remainder_cols);
                return sklearn.compose.self.InvokeMethod("make_column_transformer", args, pyDict);
            }
        }
    }
}