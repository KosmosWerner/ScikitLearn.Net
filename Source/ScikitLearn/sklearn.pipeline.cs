using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class pipeline
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
                return Py.Import("sklearn.pipeline");
            }

            static pipeline()
            {
                ReInitializeLazySelf();
            }

            public class FeatureUnion : PythonObject
            {
                public FeatureUnion(PyTuple transformer_list, int? n_jobs = null, PyDict? transformer_weights = null, bool verbose = false, bool verbose_feature_names_out = true)
                {
                    PyTuple args = ToTuple(new object[] { transformer_list });
                    PyDict pyDict = new PyDict();
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (transformer_weights != null)
                        pyDict["transformer_weights"] = ToPython(transformer_weights);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (verbose_feature_names_out != true)
                        pyDict["verbose_feature_names_out"] = ToPython(verbose_feature_names_out);
                    self = sklearn.pipeline.self.InvokeMethod("FeatureUnion", args, pyDict);
                }

                internal FeatureUnion(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static FeatureUnion Encapsule(PyObject pyObject)
                {
                    return new FeatureUnion(pyObject);
                }

                public PyDict named_transformers => new PyDict(self.GetAttr("named_transformers"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public FeatureUnion fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
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

                public string get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return ToCsharp<string>(self.InvokeMethod("get_params", args, pyDict));
                }

                public FeatureUnion set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public FeatureUnion set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class Pipeline : PythonObject
            {
                public Pipeline(PyTuple steps, PyObject? memory = null, bool verbose = false)
                {
                    PyTuple args = ToTuple(new object[] { steps });
                    PyDict pyDict = new PyDict();
                    if (memory != null)
                        pyDict["memory"] = ToPython(memory);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.pipeline.self.InvokeMethod("Pipeline", args, pyDict);
                }

                internal Pipeline(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static Pipeline Encapsule(PyObject pyObject)
                {
                    return new Pipeline(pyObject);
                }

                public PyDict named_steps => new PyDict(self.GetAttr("named_steps"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public Pipeline fit(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_predict(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_predict", args, pyDict));
                }

                public NDarray fit_transform(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
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

                public string get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return ToCsharp<string>(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (Xt != null)
                        pyDict["Xt"] = ToPython(Xt);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public NDarray predict(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_log_proba(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_log_proba", args, pyDict));
                }

                public NDarray predict_proba(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(PyObject X, PyObject? y = null, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public NDarray score_samples(PyObject X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("score_samples", args, pyDict));
                }

                public Pipeline set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public Pipeline set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public Pipeline set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray transform(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public static PyObject make_pipeline(PyObject[] steps, PyObject? memory = null, bool verbose = false)
            {
                PyTuple args = ToTuple(new object[] { steps });
                PyDict pyDict = new PyDict();
                if (memory != null)
                    pyDict["memory"] = ToPython(memory);
                if (verbose != false)
                    pyDict["verbose"] = ToPython(verbose);
                return sklearn.pipeline.self.InvokeMethod("make_pipeline", args, pyDict);
            }

            public static PyObject make_union(PyObject[] transformers, int? n_jobs = null, bool verbose = false)
            {
                PyTuple args = ToTuple(new object[] { transformers });
                PyDict pyDict = new PyDict();
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                if (verbose != false)
                    pyDict["verbose"] = ToPython(verbose);
                return sklearn.pipeline.self.InvokeMethod("make_union", args, pyDict);
            }
        }
    }
}