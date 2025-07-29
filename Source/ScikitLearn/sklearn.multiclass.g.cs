namespace ScikitLearn;
#nullable enable
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

        static multiclass() => ReInitializeLazySelf();
        public class OneVsOneClassifier : PythonObject
        {
            public OneVsOneClassifier(PyObject estimator, int? n_jobs = null)
            {
                _ = sklearn.multiclass.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
                PyDict pyDict = new PyDict();
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.multiclass.self.InvokeMethod("OneVsOneClassifier", args, pyDict);
            }

            internal OneVsOneClassifier(PyObject pyObject)
            {
                _ = sklearn.multiclass.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static OneVsOneClassifier Encapsule(PyObject pyObject) => new OneVsOneClassifier(pyObject);
            public static OneVsOneClassifier Wrap(PyObject pyObject) => new OneVsOneClassifier(pyObject);
            public PyTuple estimators_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimators_");
                    return new PyTuple(__pyObject);
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

            public int n_classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_classes_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject pairwise_indices_
            {
                get
                {
                    var __pyObject = self.GetAttr("pairwise_indices_");
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

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public OneVsOneClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public OneVsOneClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("partial_fit", args, pyDict);
                return this;
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
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

            public OneVsOneClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public OneVsOneClassifier set_partial_fit_request(string? classes = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public OneVsOneClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class OneVsRestClassifier : PythonObject
        {
            public OneVsRestClassifier(PyObject estimator, int? n_jobs = null, int verbose = 0)
            {
                _ = sklearn.multiclass.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
                PyDict pyDict = new PyDict();
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.multiclass.self.InvokeMethod("OneVsRestClassifier", args, pyDict);
            }

            internal OneVsRestClassifier(PyObject pyObject)
            {
                _ = sklearn.multiclass.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static OneVsRestClassifier Encapsule(PyObject pyObject) => new OneVsRestClassifier(pyObject);
            public static OneVsRestClassifier Wrap(PyObject pyObject) => new OneVsRestClassifier(pyObject);
            public PyTuple estimators_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimators_");
                    return new PyTuple(__pyObject);
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

            public int n_classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_classes_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject label_binarizer_
            {
                get
                {
                    var __pyObject = self.GetAttr("label_binarizer_");
                    return __pyObject;
                }
            }

            public bool multilabel_
            {
                get
                {
                    var __pyObject = self.GetAttr("multilabel_");
                    return __pyObject.As<bool>();
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

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public OneVsRestClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public OneVsRestClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("partial_fit", args, pyDict);
                return this;
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

            public OneVsRestClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public OneVsRestClassifier set_partial_fit_request(string? classes = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public OneVsRestClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class OutputCodeClassifier : PythonObject
        {
            public OutputCodeClassifier(PyObject estimator, float code_size = 1.5f, int? random_state = null, int? n_jobs = null)
            {
                _ = sklearn.multiclass.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
                PyDict pyDict = new PyDict();
                if (code_size != 1.5f)
                    pyDict["code_size"] = Helpers.ToPython(code_size);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.multiclass.self.InvokeMethod("OutputCodeClassifier", args, pyDict);
            }

            internal OutputCodeClassifier(PyObject pyObject)
            {
                _ = sklearn.multiclass.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static OutputCodeClassifier Encapsule(PyObject pyObject) => new OutputCodeClassifier(pyObject);
            public static OutputCodeClassifier Wrap(PyObject pyObject) => new OutputCodeClassifier(pyObject);
            public PyTuple estimators_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimators_");
                    return new PyTuple(__pyObject);
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

            public NDarray code_book_
            {
                get
                {
                    var __pyObject = self.GetAttr("code_book_");
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

            public OutputCodeClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public OutputCodeClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public OutputCodeClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }
    }
}