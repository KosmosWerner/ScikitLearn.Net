namespace ScikitLearn;
public static partial class sklearn
{
    public static class ensemble
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
            return Py.Import("sklearn.ensemble");
        }

        static ensemble()
        {
            ReInitializeLazySelf();
        }

        public class AdaBoostClassifier : PythonObject
        {
            public AdaBoostClassifier(PyObject? estimator = null, int n_estimators = 50, float learning_rate = 1.0f, string algorithm = "SAMME.R", int? random_state = null)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (estimator != null)
                    pyDict["estimator"] = Helpers.ToPython(estimator);
                if (n_estimators != 50)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (learning_rate != 1.0f)
                    pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                if (algorithm != "SAMME.R")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.ensemble.self.InvokeMethod("AdaBoostClassifier", args, pyDict);
            }

            internal AdaBoostClassifier(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static AdaBoostClassifier Encapsule(PyObject pyObject) => new AdaBoostClassifier(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_classes_
            {
                get
                {
                    return self.GetAttr("n_classes_").As<int>();
                }
            }

            public NDarray estimator_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimator_errors_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public AdaBoostClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public AdaBoostClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public AdaBoostClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public AdaBoostClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray staged_decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray staged_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray staged_predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float staged_score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("staged_score", args, pyDict).As<float>();
            }
        }

        public class AdaBoostRegressor : PythonObject
        {
            public AdaBoostRegressor(PyObject? estimator = null, int n_estimators = 50, float learning_rate = 1.0f, string loss = "linear", int? random_state = null)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (estimator != null)
                    pyDict["estimator"] = Helpers.ToPython(estimator);
                if (n_estimators != 50)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (learning_rate != 1.0f)
                    pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                if (loss != "linear")
                    pyDict["loss"] = Helpers.ToPython(loss);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.ensemble.self.InvokeMethod("AdaBoostRegressor", args, pyDict);
            }

            internal AdaBoostRegressor(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static AdaBoostRegressor Encapsule(PyObject pyObject) => new AdaBoostRegressor(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimator_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimator_errors_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public AdaBoostRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public AdaBoostRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public AdaBoostRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public AdaBoostRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray staged_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float staged_score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("staged_score", args, pyDict).As<float>();
            }
        }

        public class BaggingClassifier : PythonObject
        {
            public BaggingClassifier(PyObject? estimator = null, int n_estimators = 10, float max_samples = 1.0f, float max_features = 1.0f, bool bootstrap = true, bool bootstrap_features = false, bool oob_score = false, bool warm_start = false, int? n_jobs = null, int? random_state = null, int verbose = 0)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (estimator != null)
                    pyDict["estimator"] = Helpers.ToPython(estimator);
                if (n_estimators != 10)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (max_samples != 1.0f)
                    pyDict["max_samples"] = Helpers.ToPython(max_samples);
                if (max_features != 1.0f)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (bootstrap != true)
                    pyDict["bootstrap"] = Helpers.ToPython(bootstrap);
                if (bootstrap_features != false)
                    pyDict["bootstrap_features"] = Helpers.ToPython(bootstrap_features);
                if (oob_score != false)
                    pyDict["oob_score"] = Helpers.ToPython(oob_score);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.ensemble.self.InvokeMethod("BaggingClassifier", args, pyDict);
            }

            internal BaggingClassifier(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static BaggingClassifier Encapsule(PyObject pyObject) => new BaggingClassifier(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_features_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_classes_
            {
                get
                {
                    return self.GetAttr("n_classes_").As<int>();
                }
            }

            public float oob_score_
            {
                get
                {
                    return self.GetAttr("oob_score_").As<float>();
                }
            }

            public NDarray oob_decision_function_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public BaggingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public BaggingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public BaggingClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public BaggingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }

        public class BaggingRegressor : PythonObject
        {
            public BaggingRegressor(PyObject? estimator = null, int n_estimators = 10, float max_samples = 1.0f, float max_features = 1.0f, bool bootstrap = true, bool bootstrap_features = false, bool oob_score = false, bool warm_start = false, int? n_jobs = null, int? random_state = null, int verbose = 0)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (estimator != null)
                    pyDict["estimator"] = Helpers.ToPython(estimator);
                if (n_estimators != 10)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (max_samples != 1.0f)
                    pyDict["max_samples"] = Helpers.ToPython(max_samples);
                if (max_features != 1.0f)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (bootstrap != true)
                    pyDict["bootstrap"] = Helpers.ToPython(bootstrap);
                if (bootstrap_features != false)
                    pyDict["bootstrap_features"] = Helpers.ToPython(bootstrap_features);
                if (oob_score != false)
                    pyDict["oob_score"] = Helpers.ToPython(oob_score);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.ensemble.self.InvokeMethod("BaggingRegressor", args, pyDict);
            }

            internal BaggingRegressor(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static BaggingRegressor Encapsule(PyObject pyObject) => new BaggingRegressor(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_features_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float oob_score_
            {
                get
                {
                    return self.GetAttr("oob_score_").As<float>();
                }
            }

            public NDarray oob_prediction_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public BaggingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public BaggingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public BaggingRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public BaggingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }

        public class ExtraTreesClassifier : PythonObject
        {
            public ExtraTreesClassifier(int n_estimators = 100, string criterion = "gini", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = false, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, PyDict? class_weight = null, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_estimators != 100)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (criterion != "gini")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_features != "sqrt")
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (bootstrap != false)
                    pyDict["bootstrap"] = Helpers.ToPython(bootstrap);
                if (oob_score != false)
                    pyDict["oob_score"] = Helpers.ToPython(oob_score);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (class_weight != null)
                    pyDict["class_weight"] = Helpers.ToPython(class_weight);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                if (max_samples != null)
                    pyDict["max_samples"] = Helpers.ToPython(max_samples);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                self = sklearn.ensemble.self.InvokeMethod("ExtraTreesClassifier", args, pyDict);
            }

            internal ExtraTreesClassifier(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static ExtraTreesClassifier Encapsule(PyObject pyObject) => new ExtraTreesClassifier(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_classes_
            {
                get
                {
                    return self.GetAttr("n_classes_").As<int>();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_outputs_
            {
                get
                {
                    return self.GetAttr("n_outputs_").As<int>();
                }
            }

            public float oob_score_
            {
                get
                {
                    return self.GetAttr("oob_score_").As<float>();
                }
            }

            public NDarray oob_decision_function_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray apply(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public (NDarray? , NDarray? ) decision_path(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public ExtraTreesClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public ExtraTreesClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public ExtraTreesClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public ExtraTreesClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }

        public class ExtraTreesRegressor : PythonObject
        {
            public ExtraTreesRegressor(int n_estimators = 100, string criterion = "squared_error", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = false, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_estimators != 100)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (criterion != "squared_error")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_features != 1.0f)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (bootstrap != false)
                    pyDict["bootstrap"] = Helpers.ToPython(bootstrap);
                if (oob_score != false)
                    pyDict["oob_score"] = Helpers.ToPython(oob_score);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                if (max_samples != null)
                    pyDict["max_samples"] = Helpers.ToPython(max_samples);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                self = sklearn.ensemble.self.InvokeMethod("ExtraTreesRegressor", args, pyDict);
            }

            internal ExtraTreesRegressor(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static ExtraTreesRegressor Encapsule(PyObject pyObject) => new ExtraTreesRegressor(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_outputs_
            {
                get
                {
                    return self.GetAttr("n_outputs_").As<int>();
                }
            }

            public float oob_score_
            {
                get
                {
                    return self.GetAttr("oob_score_").As<float>();
                }
            }

            public NDarray oob_prediction_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray apply(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public (NDarray? , NDarray? ) decision_path(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public ExtraTreesRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public ExtraTreesRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public ExtraTreesRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public ExtraTreesRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }

        public class GradientBoostingClassifier : PythonObject
        {
            public GradientBoostingClassifier(string loss = "log_loss", float learning_rate = 0.1f, int n_estimators = 100, float subsample = 1.0f, string criterion = "friedman_mse", int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_depth = 3, float min_impurity_decrease = 0.0f, PyObject? init = null, int? random_state = null, float? max_features = null, int verbose = 0, int? max_leaf_nodes = null, bool warm_start = false, float validation_fraction = 0.1f, int? n_iter_no_change = null, float tol = 0.0001f, float ccp_alpha = 0.0f)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (loss != "log_loss")
                    pyDict["loss"] = Helpers.ToPython(loss);
                if (learning_rate != 0.1f)
                    pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                if (n_estimators != 100)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (subsample != 1.0f)
                    pyDict["subsample"] = Helpers.ToPython(subsample);
                if (criterion != "friedman_mse")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_depth != 3)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (init != null)
                    pyDict["init"] = Helpers.ToPython(init);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (max_features != null)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (validation_fraction != 0.1f)
                    pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                if (n_iter_no_change != null)
                    pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                self = sklearn.ensemble.self.InvokeMethod("GradientBoostingClassifier", args, pyDict);
            }

            internal GradientBoostingClassifier(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static GradientBoostingClassifier Encapsule(PyObject pyObject) => new GradientBoostingClassifier(pyObject);
            public int n_estimators_
            {
                get
                {
                    return self.GetAttr("n_estimators_").As<int>();
                }
            }

            public int n_trees_per_iteration_
            {
                get
                {
                    return self.GetAttr("n_trees_per_iteration_").As<int>();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray oob_improvement_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray oob_scores_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float oob_score_
            {
                get
                {
                    return self.GetAttr("oob_score_").As<float>();
                }
            }

            public NDarray train_score_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyObject init_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_classes_
            {
                get
                {
                    return self.GetAttr("n_classes_").As<int>();
                }
            }

            public int max_features_
            {
                get
                {
                    return self.GetAttr("max_features_").As<int>();
                }
            }

            public NDarray apply(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public GradientBoostingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, PyObject? monitor = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (monitor != null)
                    pyDict["monitor"] = Helpers.ToPython(monitor);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public GradientBoostingClassifier set_fit_request(string? monitor = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (monitor != "$UNCHANGED$")
                    pyDict["monitor"] = Helpers.ToPython(monitor);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public GradientBoostingClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public GradientBoostingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray staged_decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray staged_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray staged_predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class GradientBoostingRegressor : PythonObject
        {
            public GradientBoostingRegressor(string loss = "squared_error", float learning_rate = 0.1f, int n_estimators = 100, float subsample = 1.0f, string criterion = "friedman_mse", int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_depth = 3, float min_impurity_decrease = 0.0f, PyObject? init = null, int? random_state = null, float? max_features = null, float alpha = 0.9f, int verbose = 0, int? max_leaf_nodes = null, bool warm_start = false, float validation_fraction = 0.1f, int? n_iter_no_change = null, float tol = 0.0001f, float ccp_alpha = 0.0f)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (loss != "squared_error")
                    pyDict["loss"] = Helpers.ToPython(loss);
                if (learning_rate != 0.1f)
                    pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                if (n_estimators != 100)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (subsample != 1.0f)
                    pyDict["subsample"] = Helpers.ToPython(subsample);
                if (criterion != "friedman_mse")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_depth != 3)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (init != null)
                    pyDict["init"] = Helpers.ToPython(init);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (max_features != null)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (alpha != 0.9f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (validation_fraction != 0.1f)
                    pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                if (n_iter_no_change != null)
                    pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                self = sklearn.ensemble.self.InvokeMethod("GradientBoostingRegressor", args, pyDict);
            }

            internal GradientBoostingRegressor(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static GradientBoostingRegressor Encapsule(PyObject pyObject) => new GradientBoostingRegressor(pyObject);
            public int n_estimators_
            {
                get
                {
                    return self.GetAttr("n_estimators_").As<int>();
                }
            }

            public int n_trees_per_iteration_
            {
                get
                {
                    return self.GetAttr("n_trees_per_iteration_").As<int>();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray oob_improvement_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray oob_scores_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float oob_score_
            {
                get
                {
                    return self.GetAttr("oob_score_").As<float>();
                }
            }

            public NDarray train_score_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyObject init_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int max_features_
            {
                get
                {
                    return self.GetAttr("max_features_").As<int>();
                }
            }

            public NDarray apply(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public GradientBoostingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, PyObject? monitor = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (monitor != null)
                    pyDict["monitor"] = Helpers.ToPython(monitor);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public GradientBoostingRegressor set_fit_request(string? monitor = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (monitor != "$UNCHANGED$")
                    pyDict["monitor"] = Helpers.ToPython(monitor);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public GradientBoostingRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public GradientBoostingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray staged_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class HistGradientBoostingClassifier : PythonObject
        {
            public HistGradientBoostingClassifier(string loss = "log_loss", float learning_rate = 0.1f, int max_iter = 100, int? max_leaf_nodes = 31, int? max_depth = null, int min_samples_leaf = 20, float l2_regularization = 0.0f, float max_features = 1.0f, int max_bins = 255, string? categorical_features = "warn", PyDict? monotonic_cst = null, int? interaction_cst = null, bool warm_start = false, string early_stopping = "auto", string? scoring = "loss", float? validation_fraction = 0.1f, int n_iter_no_change = 10, float tol = 1e-07f, int verbose = 0, int? random_state = null, PyDict? class_weight = null)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (loss != "log_loss")
                    pyDict["loss"] = Helpers.ToPython(loss);
                if (learning_rate != 0.1f)
                    pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                if (max_iter != 100)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (max_leaf_nodes != 31)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_leaf != 20)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (l2_regularization != 0.0f)
                    pyDict["l2_regularization"] = Helpers.ToPython(l2_regularization);
                if (max_features != 1.0f)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (max_bins != 255)
                    pyDict["max_bins"] = Helpers.ToPython(max_bins);
                if (categorical_features != "warn")
                    pyDict["categorical_features"] = Helpers.ToPython(categorical_features);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                if (interaction_cst != null)
                    pyDict["interaction_cst"] = Helpers.ToPython(interaction_cst);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (early_stopping != "auto")
                    pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                if (scoring != "loss")
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (validation_fraction != 0.1f)
                    pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                if (n_iter_no_change != 10)
                    pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                if (tol != 1e-07f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (class_weight != null)
                    pyDict["class_weight"] = Helpers.ToPython(class_weight);
                self = sklearn.ensemble.self.InvokeMethod("HistGradientBoostingClassifier", args, pyDict);
            }

            internal HistGradientBoostingClassifier(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static HistGradientBoostingClassifier Encapsule(PyObject pyObject) => new HistGradientBoostingClassifier(pyObject);
            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public bool do_early_stopping_
            {
                get
                {
                    return self.GetAttr("do_early_stopping_").As<bool>();
                }
            }

            public int n_iter_
            {
                get
                {
                    return self.GetAttr("n_iter_").As<int>();
                }
            }

            public int n_trees_per_iteration_
            {
                get
                {
                    return self.GetAttr("n_trees_per_iteration_").As<int>();
                }
            }

            public NDarray train_score_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray validation_score_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray is_categorical_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public HistGradientBoostingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public HistGradientBoostingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public HistGradientBoostingClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public HistGradientBoostingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray staged_decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray staged_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray staged_predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class HistGradientBoostingRegressor : PythonObject
        {
            public HistGradientBoostingRegressor(string loss = "squared_error", float? quantile = null, float learning_rate = 0.1f, int max_iter = 100, int? max_leaf_nodes = 31, int? max_depth = null, int min_samples_leaf = 20, float l2_regularization = 0.0f, float max_features = 1.0f, int max_bins = 255, string? categorical_features = "warn", PyDict? monotonic_cst = null, int? interaction_cst = null, bool warm_start = false, string early_stopping = "auto", string? scoring = "loss", float? validation_fraction = 0.1f, int n_iter_no_change = 10, float tol = 1e-07f, int verbose = 0, int? random_state = null)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (loss != "squared_error")
                    pyDict["loss"] = Helpers.ToPython(loss);
                if (quantile != null)
                    pyDict["quantile"] = Helpers.ToPython(quantile);
                if (learning_rate != 0.1f)
                    pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                if (max_iter != 100)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (max_leaf_nodes != 31)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_leaf != 20)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (l2_regularization != 0.0f)
                    pyDict["l2_regularization"] = Helpers.ToPython(l2_regularization);
                if (max_features != 1.0f)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (max_bins != 255)
                    pyDict["max_bins"] = Helpers.ToPython(max_bins);
                if (categorical_features != "warn")
                    pyDict["categorical_features"] = Helpers.ToPython(categorical_features);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                if (interaction_cst != null)
                    pyDict["interaction_cst"] = Helpers.ToPython(interaction_cst);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (early_stopping != "auto")
                    pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                if (scoring != "loss")
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (validation_fraction != 0.1f)
                    pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                if (n_iter_no_change != 10)
                    pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                if (tol != 1e-07f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.ensemble.self.InvokeMethod("HistGradientBoostingRegressor", args, pyDict);
            }

            internal HistGradientBoostingRegressor(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static HistGradientBoostingRegressor Encapsule(PyObject pyObject) => new HistGradientBoostingRegressor(pyObject);
            public bool do_early_stopping_
            {
                get
                {
                    return self.GetAttr("do_early_stopping_").As<bool>();
                }
            }

            public int n_iter_
            {
                get
                {
                    return self.GetAttr("n_iter_").As<int>();
                }
            }

            public int n_trees_per_iteration_
            {
                get
                {
                    return self.GetAttr("n_trees_per_iteration_").As<int>();
                }
            }

            public NDarray train_score_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray validation_score_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray is_categorical_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public HistGradientBoostingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public HistGradientBoostingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public HistGradientBoostingRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public HistGradientBoostingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray staged_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class IsolationForest : PythonObject
        {
            public IsolationForest(int n_estimators = 100, string max_samples = "auto", string contamination = "auto", float max_features = 1.0f, bool bootstrap = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_estimators != 100)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (max_samples != "auto")
                    pyDict["max_samples"] = Helpers.ToPython(max_samples);
                if (contamination != "auto")
                    pyDict["contamination"] = Helpers.ToPython(contamination);
                if (max_features != 1.0f)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (bootstrap != false)
                    pyDict["bootstrap"] = Helpers.ToPython(bootstrap);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                self = sklearn.ensemble.self.InvokeMethod("IsolationForest", args, pyDict);
            }

            internal IsolationForest(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static IsolationForest Encapsule(PyObject pyObject) => new IsolationForest(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_features_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int max_samples_
            {
                get
                {
                    return self.GetAttr("max_samples_").As<int>();
                }
            }

            public float offset_
            {
                get
                {
                    return self.GetAttr("offset_").As<float>();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public IsolationForest fit(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray score_samples(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public IsolationForest set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public IsolationForest set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }
        }

        public class RandomForestClassifier : PythonObject
        {
            public RandomForestClassifier(int n_estimators = 100, string criterion = "gini", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = true, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, PyDict? class_weight = null, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_estimators != 100)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (criterion != "gini")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_features != "sqrt")
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (bootstrap != true)
                    pyDict["bootstrap"] = Helpers.ToPython(bootstrap);
                if (oob_score != false)
                    pyDict["oob_score"] = Helpers.ToPython(oob_score);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (class_weight != null)
                    pyDict["class_weight"] = Helpers.ToPython(class_weight);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                if (max_samples != null)
                    pyDict["max_samples"] = Helpers.ToPython(max_samples);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                self = sklearn.ensemble.self.InvokeMethod("RandomForestClassifier", args, pyDict);
            }

            internal RandomForestClassifier(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static RandomForestClassifier Encapsule(PyObject pyObject) => new RandomForestClassifier(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_classes_
            {
                get
                {
                    return self.GetAttr("n_classes_").As<int>();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_outputs_
            {
                get
                {
                    return self.GetAttr("n_outputs_").As<int>();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float oob_score_
            {
                get
                {
                    return self.GetAttr("oob_score_").As<float>();
                }
            }

            public NDarray oob_decision_function_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray apply(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public (NDarray? , NDarray? ) decision_path(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public RandomForestClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public RandomForestClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public RandomForestClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public RandomForestClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }

        public class RandomForestRegressor : PythonObject
        {
            public RandomForestRegressor(int n_estimators = 100, string criterion = "squared_error", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = true, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_estimators != 100)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (criterion != "squared_error")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_features != 1.0f)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (bootstrap != true)
                    pyDict["bootstrap"] = Helpers.ToPython(bootstrap);
                if (oob_score != false)
                    pyDict["oob_score"] = Helpers.ToPython(oob_score);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                if (max_samples != null)
                    pyDict["max_samples"] = Helpers.ToPython(max_samples);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                self = sklearn.ensemble.self.InvokeMethod("RandomForestRegressor", args, pyDict);
            }

            internal RandomForestRegressor(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static RandomForestRegressor Encapsule(PyObject pyObject) => new RandomForestRegressor(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_outputs_
            {
                get
                {
                    return self.GetAttr("n_outputs_").As<int>();
                }
            }

            public float oob_score_
            {
                get
                {
                    return self.GetAttr("oob_score_").As<float>();
                }
            }

            public NDarray oob_prediction_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray apply(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public (NDarray? , NDarray? ) decision_path(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public RandomForestRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public RandomForestRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public RandomForestRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public RandomForestRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }

        public class RandomTreesEmbedding : PythonObject
        {
            public RandomTreesEmbedding(int n_estimators = 100, int max_depth = 5, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool sparse_output = true, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_estimators != 100)
                    pyDict["n_estimators"] = Helpers.ToPython(n_estimators);
                if (max_depth != 5)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (sparse_output != true)
                    pyDict["sparse_output"] = Helpers.ToPython(sparse_output);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                self = sklearn.ensemble.self.InvokeMethod("RandomTreesEmbedding", args, pyDict);
            }

            internal RandomTreesEmbedding(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static RandomTreesEmbedding Encapsule(PyObject pyObject) => new RandomTreesEmbedding(pyObject);
            public PyObject estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_outputs_
            {
                get
                {
                    return self.GetAttr("n_outputs_").As<int>();
                }
            }

            public PyObject one_hot_encoder_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray estimators_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray apply(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public (NDarray? , NDarray? ) decision_path(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public RandomTreesEmbedding fit(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public RandomTreesEmbedding set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public RandomTreesEmbedding set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public RandomTreesEmbedding set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class StackingClassifier : PythonObject
        {
            public StackingClassifier(PyTuple estimators, PyObject? final_estimator = null, int? cv = null, string stack_method = "auto", int? n_jobs = null, bool passthrough = false, int verbose = 0)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimators) });
                PyDict pyDict = new PyDict();
                if (final_estimator != null)
                    pyDict["final_estimator"] = Helpers.ToPython(final_estimator);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (stack_method != "auto")
                    pyDict["stack_method"] = Helpers.ToPython(stack_method);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (passthrough != false)
                    pyDict["passthrough"] = Helpers.ToPython(passthrough);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.ensemble.self.InvokeMethod("StackingClassifier", args, pyDict);
            }

            internal StackingClassifier(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static StackingClassifier Encapsule(PyObject pyObject) => new StackingClassifier(pyObject);
            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyDict named_estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyObject final_estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple stack_method_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public StackingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public StackingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public StackingClassifier set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public StackingClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public StackingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class StackingRegressor : PythonObject
        {
            public StackingRegressor(PyTuple estimators, PyObject? final_estimator = null, int? cv = null, int? n_jobs = null, bool passthrough = false, int verbose = 0)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimators) });
                PyDict pyDict = new PyDict();
                if (final_estimator != null)
                    pyDict["final_estimator"] = Helpers.ToPython(final_estimator);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (passthrough != false)
                    pyDict["passthrough"] = Helpers.ToPython(passthrough);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.ensemble.self.InvokeMethod("StackingRegressor", args, pyDict);
            }

            internal StackingRegressor(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static StackingRegressor Encapsule(PyObject pyObject) => new StackingRegressor(pyObject);
            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyDict named_estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyObject final_estimator_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyTuple stack_method_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public StackingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public StackingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public StackingRegressor set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public StackingRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public StackingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class VotingClassifier : PythonObject
        {
            public VotingClassifier(PyTuple estimators, string voting = "hard", NDarray? weights = null, int? n_jobs = null, bool flatten_transform = true, bool verbose = false)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimators) });
                PyDict pyDict = new PyDict();
                if (voting != "hard")
                    pyDict["voting"] = Helpers.ToPython(voting);
                if (weights != null)
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (flatten_transform != true)
                    pyDict["flatten_transform"] = Helpers.ToPython(flatten_transform);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.ensemble.self.InvokeMethod("VotingClassifier", args, pyDict);
            }

            internal VotingClassifier(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static VotingClassifier Encapsule(PyObject pyObject) => new VotingClassifier(pyObject);
            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyDict named_estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyObject le_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public VotingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public VotingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public VotingClassifier set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public VotingClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public VotingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyObject transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class VotingRegressor : PythonObject
        {
            public VotingRegressor(PyTuple estimators, NDarray? weights = null, int? n_jobs = null, bool verbose = false)
            {
                _ = sklearn.ensemble.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimators) });
                PyDict pyDict = new PyDict();
                if (weights != null)
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.ensemble.self.InvokeMethod("VotingRegressor", args, pyDict);
            }

            internal VotingRegressor(PyObject pyObject)
            {
                _ = sklearn.ensemble.self;
                self = pyObject;
            }

            public static VotingRegressor Encapsule(PyObject pyObject) => new VotingRegressor(pyObject);
            public PyTuple estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyDict named_estimators_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public VotingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public VotingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public VotingRegressor set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public VotingRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public VotingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PyDict transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }
    }
}