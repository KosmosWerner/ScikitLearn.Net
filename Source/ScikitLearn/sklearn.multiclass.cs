using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
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
                return Py.Import("sklearn.multiclass");
            }

            static multiclass()
            {
                ReInitializeLazySelf();
            }

            public class OneVsOneClassifier : PythonObject
            {
                public OneVsOneClassifier(PyObject estimator, int? n_jobs = null)
                {
                    PyTuple args = ToTuple(new object[] { estimator });
                    PyDict pyDict = new PyDict();
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.multiclass.self.InvokeMethod("OneVsOneClassifier", args, pyDict);
                }

                internal OneVsOneClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static OneVsOneClassifier Encapsule(PyObject pyObject)
                {
                    return new OneVsOneClassifier(pyObject);
                }

                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_classes_ => ToCsharp<int>(self.GetAttr("n_classes_"));
                public PyObject pairwise_indices_ => self.GetAttr("pairwise_indices_");
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public OneVsOneClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
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
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public OneVsOneClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (classes != null)
                        pyDict["classes"] = ToPython(classes);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public OneVsOneClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public OneVsOneClassifier set_partial_fit_request(string? classes = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (classes != "$UNCHANGED$")
                        pyDict["classes"] = ToPython(classes);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public OneVsOneClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class OneVsRestClassifier : PythonObject
            {
                public OneVsRestClassifier(PyObject estimator, int? n_jobs = null, int verbose = 0)
                {
                    PyTuple args = ToTuple(new object[] { estimator });
                    PyDict pyDict = new PyDict();
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.multiclass.self.InvokeMethod("OneVsRestClassifier", args, pyDict);
                }

                internal OneVsRestClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static OneVsRestClassifier Encapsule(PyObject pyObject)
                {
                    return new OneVsRestClassifier(pyObject);
                }

                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_classes_ => ToCsharp<int>(self.GetAttr("n_classes_"));
                public PyObject label_binarizer_ => self.GetAttr("label_binarizer_");
                public bool multilabel_ => ToCsharp<bool>(self.GetAttr("multilabel_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public OneVsRestClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
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
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public OneVsRestClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (classes != null)
                        pyDict["classes"] = ToPython(classes);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public OneVsRestClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public OneVsRestClassifier set_partial_fit_request(string? classes = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (classes != "$UNCHANGED$")
                        pyDict["classes"] = ToPython(classes);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public OneVsRestClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class OutputCodeClassifier : PythonObject
            {
                public OutputCodeClassifier(PyObject estimator, float code_size = 1.5f, int? random_state = null, int? n_jobs = null)
                {
                    PyTuple args = ToTuple(new object[] { estimator });
                    PyDict pyDict = new PyDict();
                    if (code_size != 1.5f)
                        pyDict["code_size"] = ToPython(code_size);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.multiclass.self.InvokeMethod("OutputCodeClassifier", args, pyDict);
                }

                internal OutputCodeClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static OutputCodeClassifier Encapsule(PyObject pyObject)
                {
                    return new OutputCodeClassifier(pyObject);
                }

                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public NDarray code_book_ => ToCsharp<NDarray>(self.GetAttr("code_book_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public OutputCodeClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
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
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public OutputCodeClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public OutputCodeClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }
        }
    }
}