using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class semi_supervised
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
                return Py.Import("sklearn.semi_supervised");
            }

            static semi_supervised()
            {
                ReInitializeLazySelf();
            }

            public class LabelPropagation : PythonObject
            {
                public LabelPropagation(string kernel = "rbf", int gamma = 20, int n_neighbors = 7, int max_iter = 1000, float tol = 0.001f, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (kernel != "rbf")
                        pyDict["kernel"] = ToPython(kernel);
                    if (gamma != 20)
                        pyDict["gamma"] = ToPython(gamma);
                    if (n_neighbors != 7)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.semi_supervised.self.InvokeMethod("LabelPropagation", args, pyDict);
                }

                internal LabelPropagation(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static LabelPropagation Encapsule(PyObject pyObject)
                {
                    return new LabelPropagation(pyObject);
                }

                public NDarray X_ => ToCsharp<NDarray>(self.GetAttr("X_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public NDarray label_distributions_ => ToCsharp<NDarray>(self.GetAttr("label_distributions_"));
                public NDarray transduction_ => ToCsharp<NDarray>(self.GetAttr("transduction_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));

                public LabelPropagation fit(NDarray X, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
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

                public LabelPropagation set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LabelPropagation set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class LabelSpreading : PythonObject
            {
                public LabelSpreading(string kernel = "rbf", int gamma = 20, int n_neighbors = 7, float alpha = 0.2f, int max_iter = 30, float tol = 0.001f, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (kernel != "rbf")
                        pyDict["kernel"] = ToPython(kernel);
                    if (gamma != 20)
                        pyDict["gamma"] = ToPython(gamma);
                    if (n_neighbors != 7)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (alpha != 0.2f)
                        pyDict["alpha"] = ToPython(alpha);
                    if (max_iter != 30)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.semi_supervised.self.InvokeMethod("LabelSpreading", args, pyDict);
                }

                internal LabelSpreading(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static LabelSpreading Encapsule(PyObject pyObject)
                {
                    return new LabelSpreading(pyObject);
                }

                public NDarray X_ => ToCsharp<NDarray>(self.GetAttr("X_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public NDarray label_distributions_ => ToCsharp<NDarray>(self.GetAttr("label_distributions_"));
                public NDarray transduction_ => ToCsharp<NDarray>(self.GetAttr("transduction_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));

                public LabelSpreading fit(NDarray X, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
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

                public LabelSpreading set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LabelSpreading set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class SelfTrainingClassifier : PythonObject
            {
                public SelfTrainingClassifier(PyObject base_estimator, float threshold = 0.75f, string criterion = "threshold", int k_best = 10, int? max_iter = 10, bool verbose = false)
                {
                    PyTuple args = ToTuple(new object[] { base_estimator });
                    PyDict pyDict = new PyDict();
                    if (threshold != 0.75f)
                        pyDict["threshold"] = ToPython(threshold);
                    if (criterion != "threshold")
                        pyDict["criterion"] = ToPython(criterion);
                    if (k_best != 10)
                        pyDict["k_best"] = ToPython(k_best);
                    if (max_iter != 10)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.semi_supervised.self.InvokeMethod("SelfTrainingClassifier", args, pyDict);
                }

                internal SelfTrainingClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SelfTrainingClassifier Encapsule(PyObject pyObject)
                {
                    return new SelfTrainingClassifier(pyObject);
                }

                public PyObject base_estimator_ => self.GetAttr("base_estimator_");
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public NDarray transduction_ => ToCsharp<NDarray>(self.GetAttr("transduction_"));
                public NDarray labeled_iter_ => ToCsharp<NDarray>(self.GetAttr("labeled_iter_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public PyObject termination_condition_ => self.GetAttr("termination_condition_");

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public SelfTrainingClassifier fit(NDarray X, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
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
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_log_proba", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(NDarray X, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public SelfTrainingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }
        }
    }
}