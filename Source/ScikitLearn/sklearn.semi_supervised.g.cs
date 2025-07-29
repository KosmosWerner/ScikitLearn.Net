namespace ScikitLearn;
#nullable enable
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

        static semi_supervised() => ReInitializeLazySelf();
        public class LabelPropagation : PythonObject
        {
            public LabelPropagation(string kernel = "rbf", int gamma = 20, int n_neighbors = 7, int max_iter = 1000, float tol = 0.001f, int? n_jobs = null)
            {
                _ = sklearn.semi_supervised.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (kernel != "rbf")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (gamma != 20)
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (n_neighbors != 7)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (max_iter != 1000)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.semi_supervised.self.InvokeMethod("LabelPropagation", args, pyDict);
            }

            internal LabelPropagation(PyObject pyObject)
            {
                _ = sklearn.semi_supervised.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LabelPropagation Encapsule(PyObject pyObject) => new LabelPropagation(pyObject);
            public static LabelPropagation Wrap(PyObject pyObject) => new LabelPropagation(pyObject);
            public NDarray X_
            {
                get
                {
                    var __pyObject = self.GetAttr("X_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray label_distributions_
            {
                get
                {
                    var __pyObject = self.GetAttr("label_distributions_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray transduction_
            {
                get
                {
                    var __pyObject = self.GetAttr("transduction_");
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public LabelPropagation fit(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public LabelPropagation set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public LabelPropagation set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class LabelSpreading : PythonObject
        {
            public LabelSpreading(string kernel = "rbf", int gamma = 20, int n_neighbors = 7, float alpha = 0.2f, int max_iter = 30, float tol = 0.001f, int? n_jobs = null)
            {
                _ = sklearn.semi_supervised.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (kernel != "rbf")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (gamma != 20)
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (n_neighbors != 7)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (alpha != 0.2f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (max_iter != 30)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.semi_supervised.self.InvokeMethod("LabelSpreading", args, pyDict);
            }

            internal LabelSpreading(PyObject pyObject)
            {
                _ = sklearn.semi_supervised.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LabelSpreading Encapsule(PyObject pyObject) => new LabelSpreading(pyObject);
            public static LabelSpreading Wrap(PyObject pyObject) => new LabelSpreading(pyObject);
            public NDarray X_
            {
                get
                {
                    var __pyObject = self.GetAttr("X_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray label_distributions_
            {
                get
                {
                    var __pyObject = self.GetAttr("label_distributions_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray transduction_
            {
                get
                {
                    var __pyObject = self.GetAttr("transduction_");
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public LabelSpreading fit(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public LabelSpreading set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public LabelSpreading set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class SelfTrainingClassifier : PythonObject
        {
            public SelfTrainingClassifier(PyObject base_estimator, float threshold = 0.75f, string criterion = "threshold", int k_best = 10, int? max_iter = 10, bool verbose = false)
            {
                _ = sklearn.semi_supervised.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(base_estimator) });
                PyDict pyDict = new PyDict();
                if (threshold != 0.75f)
                    pyDict["threshold"] = Helpers.ToPython(threshold);
                if (criterion != "threshold")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (k_best != 10)
                    pyDict["k_best"] = Helpers.ToPython(k_best);
                if (max_iter != 10)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.semi_supervised.self.InvokeMethod("SelfTrainingClassifier", args, pyDict);
            }

            internal SelfTrainingClassifier(PyObject pyObject)
            {
                _ = sklearn.semi_supervised.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static SelfTrainingClassifier Encapsule(PyObject pyObject) => new SelfTrainingClassifier(pyObject);
            public static SelfTrainingClassifier Wrap(PyObject pyObject) => new SelfTrainingClassifier(pyObject);
            public PyObject base_estimator_
            {
                get
                {
                    var __pyObject = self.GetAttr("base_estimator_");
                    return __pyObject;
                }
            }

            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray transduction_
            {
                get
                {
                    var __pyObject = self.GetAttr("transduction_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray labeled_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("labeled_iter_");
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject termination_condition_
            {
                get
                {
                    var __pyObject = self.GetAttr("termination_condition_");
                    return __pyObject;
                }
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public SelfTrainingClassifier fit(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public void get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_metadata_routing", args, pyDict);
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

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public SelfTrainingClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }
    }
}