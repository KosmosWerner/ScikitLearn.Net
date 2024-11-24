using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class preprocessing
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
                return Py.Import("sklearn.preprocessing");
            }

            static preprocessing()
            {
                ReInitializeLazySelf();
            }

            public class Binarizer : PythonObject
            {
                public Binarizer(float threshold = 0.0f, bool copy = true)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (threshold != 0.0f)
                        pyDict["threshold"] = Helpers.ToPython(threshold);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self = sklearn.preprocessing.self.InvokeMethod("Binarizer", args, pyDict);
                }

                internal Binarizer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static Binarizer Encapsule(PyObject pyObject)
                {
                    return new Binarizer(pyObject);
                }

                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Binarizer fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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

                public Binarizer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public Binarizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public Binarizer set_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X, bool? copy = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (copy != null)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class FunctionTransformer : PythonObject
            {
                public FunctionTransformer(PyObject? func = null, PyObject? inverse_func = null, bool validate = false, bool accept_sparse = false, bool check_inverse = true, PyObject? feature_names_out = null, PyDict? kw_args = null, PyDict? inv_kw_args = null)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (func != null)
                        pyDict["func"] = Helpers.ToPython(func);
                    if (inverse_func != null)
                        pyDict["inverse_func"] = Helpers.ToPython(inverse_func);
                    if (validate != false)
                        pyDict["validate"] = Helpers.ToPython(validate);
                    if (accept_sparse != false)
                        pyDict["accept_sparse"] = Helpers.ToPython(accept_sparse);
                    if (check_inverse != true)
                        pyDict["check_inverse"] = Helpers.ToPython(check_inverse);
                    if (feature_names_out != null)
                        pyDict["feature_names_out"] = Helpers.ToPython(feature_names_out);
                    if (kw_args != null)
                        pyDict["kw_args"] = Helpers.ToPython(kw_args);
                    if (inv_kw_args != null)
                        pyDict["inv_kw_args"] = Helpers.ToPython(inv_kw_args);
                    self = sklearn.preprocessing.self.InvokeMethod("FunctionTransformer", args, pyDict);
                }

                internal FunctionTransformer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static FunctionTransformer Encapsule(PyObject pyObject)
                {
                    return new FunctionTransformer(pyObject);
                }

                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public FunctionTransformer fit(PyObject X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(PyObject X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public FunctionTransformer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public FunctionTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(PyObject X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class KBinsDiscretizer : PythonObject
            {
                public KBinsDiscretizer(int n_bins = 5, string encode = "onehot", string strategy = "quantile", float? dtype = null, int? subsample = 200000, int? random_state = null)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_bins != 5)
                        pyDict["n_bins"] = Helpers.ToPython(n_bins);
                    if (encode != "onehot")
                        pyDict["encode"] = Helpers.ToPython(encode);
                    if (strategy != "quantile")
                        pyDict["strategy"] = Helpers.ToPython(strategy);
                    if (dtype != null)
                        pyDict["dtype"] = Helpers.ToPython(dtype);
                    if (subsample != 200000)
                        pyDict["subsample"] = Helpers.ToPython(subsample);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.preprocessing.self.InvokeMethod("KBinsDiscretizer", args, pyDict);
                }

                internal KBinsDiscretizer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static KBinsDiscretizer Encapsule(PyObject pyObject)
                {
                    return new KBinsDiscretizer(pyObject);
                }

                public NDarray bin_edges_ => Helpers.ToCSharpNDarray(self.GetAttr("bin_edges_"));
                public NDarray<long> n_bins_ => Helpers.ToCSharpNDarray<long>(self.GetAttr("n_bins_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public KBinsDiscretizer fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = Helpers.ToPython(X);
                    if (Xt != null)
                        pyDict["Xt"] = Helpers.ToPython(Xt);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public KBinsDiscretizer set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public KBinsDiscretizer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public KBinsDiscretizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class KernelCenterer : PythonObject
            {
                public KernelCenterer()
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.preprocessing.self.InvokeMethod("KernelCenterer", args, pyDict);
                }

                internal KernelCenterer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static KernelCenterer Encapsule(PyObject pyObject)
                {
                    return new KernelCenterer(pyObject);
                }

                public NDarray K_fit_rows_ => Helpers.ToCSharpNDarray(self.GetAttr("K_fit_rows_"));
                public float K_fit_all_ => Helpers.ToCSharpFloat(self.GetAttr("K_fit_all_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public KernelCenterer fit(NDarray K, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(K)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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

                public KernelCenterer set_fit_request(string? K = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (K != "$UNCHANGED$")
                        pyDict["K"] = Helpers.ToPython(K);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public KernelCenterer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public KernelCenterer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public KernelCenterer set_transform_request(string? K = "$UNCHANGED$", string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (K != "$UNCHANGED$")
                        pyDict["K"] = Helpers.ToPython(K);
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray K, bool copy = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(K)]);
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class LabelBinarizer : PythonObject
            {
                public LabelBinarizer(int neg_label = 0, int pos_label = 1, bool sparse_output = false)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (neg_label != 0)
                        pyDict["neg_label"] = Helpers.ToPython(neg_label);
                    if (pos_label != 1)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    if (sparse_output != false)
                        pyDict["sparse_output"] = Helpers.ToPython(sparse_output);
                    self = sklearn.preprocessing.self.InvokeMethod("LabelBinarizer", args, pyDict);
                }

                internal LabelBinarizer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static LabelBinarizer Encapsule(PyObject pyObject)
                {
                    return new LabelBinarizer(pyObject);
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public string y_type_ => Helpers.ToCSharpString(self.GetAttr("y_type_"));
                public bool sparse_input_ => Helpers.ToCSharpBool(self.GetAttr("sparse_input_"));

                public LabelBinarizer fit(NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
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

                public NDarray inverse_transform(NDarray Y, float? threshold = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(Y)]);
                    PyDict pyDict = new PyDict();
                    if (threshold != null)
                        pyDict["threshold"] = Helpers.ToPython(threshold);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public LabelBinarizer set_inverse_transform_request(string? threshold = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (threshold != "$UNCHANGED$")
                        pyDict["threshold"] = Helpers.ToPython(threshold);
                    self.InvokeMethod("set_inverse_transform_request", args, pyDict);
                    return this;
                }

                public LabelBinarizer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public LabelBinarizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class LabelEncoder : PythonObject
            {
                public LabelEncoder()
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.preprocessing.self.InvokeMethod("LabelEncoder", args, pyDict);
                }

                internal LabelEncoder(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static LabelEncoder Encapsule(PyObject pyObject)
                {
                    return new LabelEncoder(pyObject);
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));

                public LabelEncoder fit(NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
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

                public NDarray inverse_transform(NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public LabelEncoder set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public LabelEncoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class MaxAbsScaler : PythonObject
            {
                public MaxAbsScaler(bool copy = true)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self = sklearn.preprocessing.self.InvokeMethod("MaxAbsScaler", args, pyDict);
                }

                internal MaxAbsScaler(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static MaxAbsScaler Encapsule(PyObject pyObject)
                {
                    return new MaxAbsScaler(pyObject);
                }

                public NDarray scale_ => Helpers.ToCSharpNDarray(self.GetAttr("scale_"));
                public NDarray max_abs_ => Helpers.ToCSharpNDarray(self.GetAttr("max_abs_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_seen_ => Helpers.ToCSharpInt(self.GetAttr("n_samples_seen_"));

                public MaxAbsScaler fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public MaxAbsScaler partial_fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public MaxAbsScaler set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MaxAbsScaler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class MinMaxScaler : PythonObject
            {
                public MinMaxScaler(PyTuple? feature_range = null, bool copy = true, bool clip = false)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (feature_range != null)
                        pyDict["feature_range"] = Helpers.ToPython(feature_range);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    if (clip != false)
                        pyDict["clip"] = Helpers.ToPython(clip);
                    self = sklearn.preprocessing.self.InvokeMethod("MinMaxScaler", args, pyDict);
                }

                internal MinMaxScaler(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static MinMaxScaler Encapsule(PyObject pyObject)
                {
                    return new MinMaxScaler(pyObject);
                }

                public NDarray min_ => Helpers.ToCSharpNDarray(self.GetAttr("min_"));
                public NDarray scale_ => Helpers.ToCSharpNDarray(self.GetAttr("scale_"));
                public NDarray data_min_ => Helpers.ToCSharpNDarray(self.GetAttr("data_min_"));
                public NDarray data_max_ => Helpers.ToCSharpNDarray(self.GetAttr("data_max_"));
                public NDarray data_range_ => Helpers.ToCSharpNDarray(self.GetAttr("data_range_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public int n_samples_seen_ => Helpers.ToCSharpInt(self.GetAttr("n_samples_seen_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MinMaxScaler fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public MinMaxScaler partial_fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public MinMaxScaler set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MinMaxScaler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class MultiLabelBinarizer : PythonObject
            {
                public MultiLabelBinarizer(NDarray? classes = null, bool sparse_output = false)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (classes != null)
                        pyDict["classes"] = Helpers.ToPython(classes);
                    if (sparse_output != false)
                        pyDict["sparse_output"] = Helpers.ToPython(sparse_output);
                    self = sklearn.preprocessing.self.InvokeMethod("MultiLabelBinarizer", args, pyDict);
                }

                internal MultiLabelBinarizer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static MultiLabelBinarizer Encapsule(PyObject pyObject)
                {
                    return new MultiLabelBinarizer(pyObject);
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));

                public MultiLabelBinarizer fit(PyObject y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(PyObject y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
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

                public PyTuple inverse_transform(NDarray yt)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(yt)]);
                    PyDict pyDict = new PyDict();
                    return new PyTuple(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public MultiLabelBinarizer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MultiLabelBinarizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(PyObject y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class Normalizer : PythonObject
            {
                public Normalizer(string norm = "l2", bool copy = true)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (norm != "l2")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self = sklearn.preprocessing.self.InvokeMethod("Normalizer", args, pyDict);
                }

                internal Normalizer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static Normalizer Encapsule(PyObject pyObject)
                {
                    return new Normalizer(pyObject);
                }

                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Normalizer fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public Normalizer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public Normalizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public Normalizer set_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X, bool? copy = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (copy != null)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class OneHotEncoder : PythonObject
            {
                public OneHotEncoder(string categories = "auto", NDarray? drop = null, bool sparse_output = true, float? dtype = null, string handle_unknown = "error", float? min_frequency = null, int? max_categories = null, string feature_name_combiner = "concat")
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (categories != "auto")
                        pyDict["categories"] = Helpers.ToPython(categories);
                    if (drop != null)
                        pyDict["drop"] = Helpers.ToPython(drop);
                    if (sparse_output != true)
                        pyDict["sparse_output"] = Helpers.ToPython(sparse_output);
                    if (dtype != null)
                        pyDict["dtype"] = Helpers.ToPython(dtype);
                    if (handle_unknown != "error")
                        pyDict["handle_unknown"] = Helpers.ToPython(handle_unknown);
                    if (min_frequency != null)
                        pyDict["min_frequency"] = Helpers.ToPython(min_frequency);
                    if (max_categories != null)
                        pyDict["max_categories"] = Helpers.ToPython(max_categories);
                    if (feature_name_combiner != "concat")
                        pyDict["feature_name_combiner"] = Helpers.ToPython(feature_name_combiner);
                    self = sklearn.preprocessing.self.InvokeMethod("OneHotEncoder", args, pyDict);
                }

                internal OneHotEncoder(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static OneHotEncoder Encapsule(PyObject pyObject)
                {
                    return new OneHotEncoder(pyObject);
                }

                public NDarray categories_ => Helpers.ToCSharpNDarray(self.GetAttr("categories_"));
                public NDarray drop_idx_ => Helpers.ToCSharpNDarray(self.GetAttr("drop_idx_"));
                public NDarray infrequent_categories_ => Helpers.ToCSharpNDarray(self.GetAttr("infrequent_categories_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public PyObject feature_name_combiner => self.GetAttr("feature_name_combiner");

                public OneHotEncoder fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public OneHotEncoder set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public OneHotEncoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class OrdinalEncoder : PythonObject
            {
                public OrdinalEncoder(string categories = "auto", float? dtype = null, string handle_unknown = "error", int? unknown_value = null, int? encoded_missing_value = null, float? min_frequency = null, int? max_categories = null)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (categories != "auto")
                        pyDict["categories"] = Helpers.ToPython(categories);
                    if (dtype != null)
                        pyDict["dtype"] = Helpers.ToPython(dtype);
                    if (handle_unknown != "error")
                        pyDict["handle_unknown"] = Helpers.ToPython(handle_unknown);
                    if (unknown_value != null)
                        pyDict["unknown_value"] = Helpers.ToPython(unknown_value);
                    if (encoded_missing_value != null)
                        pyDict["encoded_missing_value"] = Helpers.ToPython(encoded_missing_value);
                    if (min_frequency != null)
                        pyDict["min_frequency"] = Helpers.ToPython(min_frequency);
                    if (max_categories != null)
                        pyDict["max_categories"] = Helpers.ToPython(max_categories);
                    self = sklearn.preprocessing.self.InvokeMethod("OrdinalEncoder", args, pyDict);
                }

                internal OrdinalEncoder(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static OrdinalEncoder Encapsule(PyObject pyObject)
                {
                    return new OrdinalEncoder(pyObject);
                }

                public NDarray categories_ => Helpers.ToCSharpNDarray(self.GetAttr("categories_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray infrequent_categories_ => Helpers.ToCSharpNDarray(self.GetAttr("infrequent_categories_"));

                public OrdinalEncoder fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public OrdinalEncoder set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public OrdinalEncoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class PolynomialFeatures : PythonObject
            {
                public PolynomialFeatures(int degree = 2, bool interaction_only = false, bool include_bias = true, string order = "C")
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (degree != 2)
                        pyDict["degree"] = Helpers.ToPython(degree);
                    if (interaction_only != false)
                        pyDict["interaction_only"] = Helpers.ToPython(interaction_only);
                    if (include_bias != true)
                        pyDict["include_bias"] = Helpers.ToPython(include_bias);
                    if (order != "C")
                        pyDict["order"] = Helpers.ToPython(order);
                    self = sklearn.preprocessing.self.InvokeMethod("PolynomialFeatures", args, pyDict);
                }

                internal PolynomialFeatures(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static PolynomialFeatures Encapsule(PyObject pyObject)
                {
                    return new PolynomialFeatures(pyObject);
                }

                public NDarray powers_ => Helpers.ToCSharpNDarray(self.GetAttr("powers_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_output_features_ => Helpers.ToCSharpInt(self.GetAttr("n_output_features_"));

                public PolynomialFeatures fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public PolynomialFeatures set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public PolynomialFeatures set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class PowerTransformer : PythonObject
            {
                public PowerTransformer(string method = "yeo-johnson", bool standardize = true, bool copy = true)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (method != "yeo-johnson")
                        pyDict["method"] = Helpers.ToPython(method);
                    if (standardize != true)
                        pyDict["standardize"] = Helpers.ToPython(standardize);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self = sklearn.preprocessing.self.InvokeMethod("PowerTransformer", args, pyDict);
                }

                internal PowerTransformer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static PowerTransformer Encapsule(PyObject pyObject)
                {
                    return new PowerTransformer(pyObject);
                }

                public NDarray lambdas_ => Helpers.ToCSharpNDarray(self.GetAttr("lambdas_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public PowerTransformer fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public PowerTransformer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public PowerTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class QuantileTransformer : PythonObject
            {
                public QuantileTransformer(int n_quantiles = 1000, string output_distribution = "uniform", bool ignore_implicit_zeros = false, int? subsample = 10000, int? random_state = null, bool copy = true)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_quantiles != 1000)
                        pyDict["n_quantiles"] = Helpers.ToPython(n_quantiles);
                    if (output_distribution != "uniform")
                        pyDict["output_distribution"] = Helpers.ToPython(output_distribution);
                    if (ignore_implicit_zeros != false)
                        pyDict["ignore_implicit_zeros"] = Helpers.ToPython(ignore_implicit_zeros);
                    if (subsample != 10000)
                        pyDict["subsample"] = Helpers.ToPython(subsample);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self = sklearn.preprocessing.self.InvokeMethod("QuantileTransformer", args, pyDict);
                }

                internal QuantileTransformer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static QuantileTransformer Encapsule(PyObject pyObject)
                {
                    return new QuantileTransformer(pyObject);
                }

                public int n_quantiles_ => Helpers.ToCSharpInt(self.GetAttr("n_quantiles_"));
                public NDarray quantiles_ => Helpers.ToCSharpNDarray(self.GetAttr("quantiles_"));
                public NDarray references_ => Helpers.ToCSharpNDarray(self.GetAttr("references_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public QuantileTransformer fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public QuantileTransformer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public QuantileTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class RobustScaler : PythonObject
            {
                public RobustScaler(bool with_centering = true, bool with_scaling = true, PyTuple? quantile_range = null, bool copy = true, bool unit_variance = false)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (with_centering != true)
                        pyDict["with_centering"] = Helpers.ToPython(with_centering);
                    if (with_scaling != true)
                        pyDict["with_scaling"] = Helpers.ToPython(with_scaling);
                    if (quantile_range != null)
                        pyDict["quantile_range"] = Helpers.ToPython(quantile_range);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    if (unit_variance != false)
                        pyDict["unit_variance"] = Helpers.ToPython(unit_variance);
                    self = sklearn.preprocessing.self.InvokeMethod("RobustScaler", args, pyDict);
                }

                internal RobustScaler(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static RobustScaler Encapsule(PyObject pyObject)
                {
                    return new RobustScaler(pyObject);
                }

                public NDarray center_ => Helpers.ToCSharpNDarray(self.GetAttr("center_"));
                public NDarray scale_ => Helpers.ToCSharpNDarray(self.GetAttr("scale_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public RobustScaler fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public RobustScaler set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public RobustScaler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SplineTransformer : PythonObject
            {
                public SplineTransformer(int n_knots = 5, int degree = 3, string knots = "uniform", string extrapolation = "constant", bool include_bias = true, string order = "C", bool sparse_output = false)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_knots != 5)
                        pyDict["n_knots"] = Helpers.ToPython(n_knots);
                    if (degree != 3)
                        pyDict["degree"] = Helpers.ToPython(degree);
                    if (knots != "uniform")
                        pyDict["knots"] = Helpers.ToPython(knots);
                    if (extrapolation != "constant")
                        pyDict["extrapolation"] = Helpers.ToPython(extrapolation);
                    if (include_bias != true)
                        pyDict["include_bias"] = Helpers.ToPython(include_bias);
                    if (order != "C")
                        pyDict["order"] = Helpers.ToPython(order);
                    if (sparse_output != false)
                        pyDict["sparse_output"] = Helpers.ToPython(sparse_output);
                    self = sklearn.preprocessing.self.InvokeMethod("SplineTransformer", args, pyDict);
                }

                internal SplineTransformer(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static SplineTransformer Encapsule(PyObject pyObject)
                {
                    return new SplineTransformer(pyObject);
                }

                public NDarray bsplines_ => Helpers.ToCSharpNDarray(self.GetAttr("bsplines_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_features_out_ => Helpers.ToCSharpInt(self.GetAttr("n_features_out_"));

                public SplineTransformer fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

                public SplineTransformer set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public SplineTransformer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SplineTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class StandardScaler : PythonObject
            {
                public StandardScaler(bool copy = true, bool with_mean = true, bool with_std = true)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    if (with_mean != true)
                        pyDict["with_mean"] = Helpers.ToPython(with_mean);
                    if (with_std != true)
                        pyDict["with_std"] = Helpers.ToPython(with_std);
                    self = sklearn.preprocessing.self.InvokeMethod("StandardScaler", args, pyDict);
                }

                internal StandardScaler(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static StandardScaler Encapsule(PyObject pyObject)
                {
                    return new StandardScaler(pyObject);
                }

                public NDarray scale_ => Helpers.ToCSharpNDarray(self.GetAttr("scale_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public NDarray var_ => Helpers.ToCSharpNDarray(self.GetAttr("var_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray n_samples_seen_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_seen_"));

                public StandardScaler fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

                public NDarray inverse_transform(NDarray X, bool? copy = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (copy != null)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public StandardScaler partial_fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public StandardScaler set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public StandardScaler set_inverse_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self.InvokeMethod("set_inverse_transform_request", args, pyDict);
                    return this;
                }

                public StandardScaler set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public StandardScaler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public StandardScaler set_partial_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public StandardScaler set_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X, bool? copy = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (copy != null)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class TargetEncoder : PythonObject
            {
                public TargetEncoder(string categories = "auto", string target_type = "auto", string smooth = "auto", int cv = 5, bool shuffle = true, int? random_state = null)
                {
                    _ = sklearn.preprocessing.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (categories != "auto")
                        pyDict["categories"] = Helpers.ToPython(categories);
                    if (target_type != "auto")
                        pyDict["target_type"] = Helpers.ToPython(target_type);
                    if (smooth != "auto")
                        pyDict["smooth"] = Helpers.ToPython(smooth);
                    if (cv != 5)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.preprocessing.self.InvokeMethod("TargetEncoder", args, pyDict);
                }

                internal TargetEncoder(PyObject pyObject)
                {
                    _ = sklearn.preprocessing.self;
                    self = pyObject;
                }

                public static TargetEncoder Encapsule(PyObject pyObject)
                {
                    return new TargetEncoder(pyObject);
                }

                public NDarray encodings_ => Helpers.ToCSharpNDarray(self.GetAttr("encodings_"));
                public NDarray categories_ => Helpers.ToCSharpNDarray(self.GetAttr("categories_"));
                public string target_type_ => Helpers.ToCSharpString(self.GetAttr("target_type_"));
                public float target_mean_ => Helpers.ToCSharpFloat(self.GetAttr("target_mean_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));

                public TargetEncoder fit(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
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

                public TargetEncoder set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public TargetEncoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public static NDarray add_dummy_feature(NDarray X, float value = 1.0f)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (value != 1.0f)
                    pyDict["value"] = Helpers.ToPython(value);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("add_dummy_feature", args, pyDict));
            }

            public static NDarray binarize(NDarray X, float threshold = 0.0f, bool copy = true)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (threshold != 0.0f)
                    pyDict["threshold"] = Helpers.ToPython(threshold);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("binarize", args, pyDict));
            }

            public static NDarray label_binarize(NDarray y, NDarray classes, int neg_label = 0, int pos_label = 1, bool sparse_output = false)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y), Helpers.ToPython(classes)]);
                PyDict pyDict = new PyDict();
                if (neg_label != 0)
                    pyDict["neg_label"] = Helpers.ToPython(neg_label);
                if (pos_label != 1)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (sparse_output != false)
                    pyDict["sparse_output"] = Helpers.ToPython(sparse_output);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("label_binarize", args, pyDict));
            }

            public static NDarray maxabs_scale(NDarray X, int axis = 0, bool copy = true)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (axis != 0)
                    pyDict["axis"] = Helpers.ToPython(axis);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("maxabs_scale", args, pyDict));
            }

            public static NDarray minmax_scale(NDarray X, PyTuple? feature_range = null, int axis = 0, bool copy = true)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (feature_range != null)
                    pyDict["feature_range"] = Helpers.ToPython(feature_range);
                if (axis != 0)
                    pyDict["axis"] = Helpers.ToPython(axis);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("minmax_scale", args, pyDict));
            }

            public static (NDarray? , NDarray? ) normalize(NDarray X, string norm = "l2", int axis = 1, bool copy = true, bool return_norm = false)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (norm != "l2")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (axis != 1)
                    pyDict["axis"] = Helpers.ToPython(axis);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                if (return_norm != false)
                    pyDict["return_norm"] = Helpers.ToPython(return_norm);
                PyTuple result = new PyTuple(sklearn.preprocessing.self.InvokeMethod("normalize", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null);
            }

            public static NDarray power_transform(NDarray X, string method = "yeo-johnson", bool standardize = true, bool copy = true)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (method != "yeo-johnson")
                    pyDict["method"] = Helpers.ToPython(method);
                if (standardize != true)
                    pyDict["standardize"] = Helpers.ToPython(standardize);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("power_transform", args, pyDict));
            }

            public static NDarray quantile_transform(NDarray X, int axis = 0, int n_quantiles = 1000, string output_distribution = "uniform", bool ignore_implicit_zeros = false, int? subsample = 100000, int? random_state = null, bool copy = true)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (axis != 0)
                    pyDict["axis"] = Helpers.ToPython(axis);
                if (n_quantiles != 1000)
                    pyDict["n_quantiles"] = Helpers.ToPython(n_quantiles);
                if (output_distribution != "uniform")
                    pyDict["output_distribution"] = Helpers.ToPython(output_distribution);
                if (ignore_implicit_zeros != false)
                    pyDict["ignore_implicit_zeros"] = Helpers.ToPython(ignore_implicit_zeros);
                if (subsample != 100000)
                    pyDict["subsample"] = Helpers.ToPython(subsample);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("quantile_transform", args, pyDict));
            }

            public static NDarray robust_scale(NDarray X, int axis = 0, bool with_centering = true, bool with_scaling = true, PyTuple? quantile_range = null, bool copy = true, bool unit_variance = false)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (axis != 0)
                    pyDict["axis"] = Helpers.ToPython(axis);
                if (with_centering != true)
                    pyDict["with_centering"] = Helpers.ToPython(with_centering);
                if (with_scaling != true)
                    pyDict["with_scaling"] = Helpers.ToPython(with_scaling);
                if (quantile_range != null)
                    pyDict["quantile_range"] = Helpers.ToPython(quantile_range);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                if (unit_variance != false)
                    pyDict["unit_variance"] = Helpers.ToPython(unit_variance);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("robust_scale", args, pyDict));
            }

            public static NDarray scale(NDarray X, int axis = 0, bool with_mean = true, bool with_std = true, bool copy = true)
            {
                _ = sklearn.preprocessing.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (axis != 0)
                    pyDict["axis"] = Helpers.ToPython(axis);
                if (with_mean != true)
                    pyDict["with_mean"] = Helpers.ToPython(with_mean);
                if (with_std != true)
                    pyDict["with_std"] = Helpers.ToPython(with_std);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                return Helpers.ToCSharpNDarray(sklearn.preprocessing.self.InvokeMethod("scale", args, pyDict));
            }
        }
    }
}