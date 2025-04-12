using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class dummy
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
                return Py.Import("sklearn.dummy");
            }

            static dummy()
            {
                ReInitializeLazySelf();
            }

            public class DummyClassifier : PythonObject
            {
                public DummyClassifier(string strategy = "prior", int? random_state = null, NDarray? constant = null)
                {
                    _ = sklearn.dummy.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (strategy != "prior")
                        pyDict["strategy"] = Helpers.ToPython(strategy);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (constant != null)
                        pyDict["constant"] = Helpers.ToPython(constant);
                    self = sklearn.dummy.self.InvokeMethod("DummyClassifier", args, pyDict);
                }

                internal DummyClassifier(PyObject pyObject)
                {
                    _ = sklearn.dummy.self;
                    self = pyObject;
                }

                public static DummyClassifier Encapsule(PyObject pyObject)
                {
                    return new DummyClassifier(pyObject);
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public PyTuple n_classes_ => new PyTuple(self.GetAttr("n_classes_"));
                public NDarray class_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_prior_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpInt(self.GetAttr("n_outputs_"));
                public bool sparse_output_ => Helpers.ToCSharpBool(self.GetAttr("sparse_output_"));

                public DummyClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
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

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_log_proba(PyObject X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_log_proba", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public DummyClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public DummyClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public DummyClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class DummyRegressor : PythonObject
            {
                public DummyRegressor(string strategy = "mean", NDarray? constant = null, float? quantile = null)
                {
                    _ = sklearn.dummy.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (strategy != "mean")
                        pyDict["strategy"] = Helpers.ToPython(strategy);
                    if (constant != null)
                        pyDict["constant"] = Helpers.ToPython(constant);
                    if (quantile != null)
                        pyDict["quantile"] = Helpers.ToPython(quantile);
                    self = sklearn.dummy.self.InvokeMethod("DummyRegressor", args, pyDict);
                }

                internal DummyRegressor(PyObject pyObject)
                {
                    _ = sklearn.dummy.self;
                    self = pyObject;
                }

                public static DummyRegressor Encapsule(PyObject pyObject)
                {
                    return new DummyRegressor(pyObject);
                }

                public NDarray constant_ => Helpers.ToCSharpNDarray(self.GetAttr("constant_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpInt(self.GetAttr("n_outputs_"));

                public DummyRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
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

                public (NDarray? , NDarray? ) predict(NDarray X, bool return_std = false)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (return_std != false)
                        pyDict["return_std"] = Helpers.ToPython(return_std);
                    PyTuple result = new PyTuple(self.InvokeMethod("predict", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null);
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public DummyRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public DummyRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public DummyRegressor set_predict_request(string? return_std = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (return_std != "$UNCHANGED$")
                        pyDict["return_std"] = Helpers.ToPython(return_std);
                    self.InvokeMethod("set_predict_request", args, pyDict);
                    return this;
                }

                public DummyRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }
        }
    }
}