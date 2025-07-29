namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class multioutput
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
            return Py.Import("sklearn.multioutput");
        }

        static multioutput() => ReInitializeLazySelf();
        public class ClassifierChain : PythonObject
        {
            public ClassifierChain(PyObject base_estimator, NDarray? order = null, int? cv = null, string chain_method = "predict", int? random_state = null, bool verbose = false)
            {
                _ = sklearn.multioutput.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(base_estimator) });
                PyDict pyDict = new PyDict();
                if (order != null)
                    pyDict["order"] = Helpers.ToPython(order);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (chain_method != "predict")
                    pyDict["chain_method"] = Helpers.ToPython(chain_method);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.multioutput.self.InvokeMethod("ClassifierChain", args, pyDict);
            }

            internal ClassifierChain(PyObject pyObject)
            {
                _ = sklearn.multioutput.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ClassifierChain Encapsule(PyObject pyObject) => new ClassifierChain(pyObject);
            public static ClassifierChain Wrap(PyObject pyObject) => new ClassifierChain(pyObject);
            public PyObject classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return __pyObject;
                }
            }

            public PyObject estimators_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimators_");
                    return __pyObject;
                }
            }

            public PyObject order_
            {
                get
                {
                    var __pyObject = self.GetAttr("order_");
                    return __pyObject;
                }
            }

            public string chain_method_
            {
                get
                {
                    var __pyObject = self.GetAttr("chain_method_");
                    return __pyObject.As<string>();
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

            public ClassifierChain fit(NDarray X, NDarray Y, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(Y) });
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

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public ClassifierChain set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public ClassifierChain set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class MultiOutputClassifier : PythonObject
        {
            public MultiOutputClassifier(PyObject estimator, int? n_jobs = null)
            {
                _ = sklearn.multioutput.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
                PyDict pyDict = new PyDict();
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.multioutput.self.InvokeMethod("MultiOutputClassifier", args, pyDict);
            }

            internal MultiOutputClassifier(PyObject pyObject)
            {
                _ = sklearn.multioutput.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static MultiOutputClassifier Encapsule(PyObject pyObject) => new MultiOutputClassifier(pyObject);
            public static MultiOutputClassifier Wrap(PyObject pyObject) => new MultiOutputClassifier(pyObject);
            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimators_");
                    return new PyTuple(__pyObject);
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

            public MultiOutputClassifier fit(NDarray X, NDarray Y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(Y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public MultiOutputClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public float score(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public MultiOutputClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public MultiOutputClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public MultiOutputClassifier set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }
        }

        public class MultiOutputRegressor : PythonObject
        {
            public MultiOutputRegressor(PyObject estimator, int? n_jobs = null)
            {
                _ = sklearn.multioutput.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
                PyDict pyDict = new PyDict();
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.multioutput.self.InvokeMethod("MultiOutputRegressor", args, pyDict);
            }

            internal MultiOutputRegressor(PyObject pyObject)
            {
                _ = sklearn.multioutput.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static MultiOutputRegressor Encapsule(PyObject pyObject) => new MultiOutputRegressor(pyObject);
            public static MultiOutputRegressor Wrap(PyObject pyObject) => new MultiOutputRegressor(pyObject);
            public PyTuple estimators_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimators_");
                    return new PyTuple(__pyObject);
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

            public MultiOutputRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public MultiOutputRegressor partial_fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public MultiOutputRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public MultiOutputRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public MultiOutputRegressor set_partial_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public MultiOutputRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class RegressorChain : PythonObject
        {
            public RegressorChain(PyObject base_estimator, NDarray? order = null, int? cv = null, int? random_state = null, bool verbose = false)
            {
                _ = sklearn.multioutput.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(base_estimator) });
                PyDict pyDict = new PyDict();
                if (order != null)
                    pyDict["order"] = Helpers.ToPython(order);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.multioutput.self.InvokeMethod("RegressorChain", args, pyDict);
            }

            internal RegressorChain(PyObject pyObject)
            {
                _ = sklearn.multioutput.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static RegressorChain Encapsule(PyObject pyObject) => new RegressorChain(pyObject);
            public static RegressorChain Wrap(PyObject pyObject) => new RegressorChain(pyObject);
            public PyObject estimators_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimators_");
                    return __pyObject;
                }
            }

            public PyObject order_
            {
                get
                {
                    var __pyObject = self.GetAttr("order_");
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

            public RegressorChain fit(NDarray X, NDarray Y, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(Y) });
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

            public RegressorChain set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public RegressorChain set_score_request(string? sample_weight = "$UNCHANGED$")
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