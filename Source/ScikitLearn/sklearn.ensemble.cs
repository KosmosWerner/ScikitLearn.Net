using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (estimator != null)
                        pyDict["estimator"] = ToPython(estimator);
                    if (n_estimators != 50)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (learning_rate != 1.0f)
                        pyDict["learning_rate"] = ToPython(learning_rate);
                    if (algorithm != "SAMME.R")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.ensemble.self.InvokeMethod("AdaBoostClassifier", args, pyDict);
                }

                internal AdaBoostClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static AdaBoostClassifier Encapsule(PyObject pyObject)
                {
                    return new AdaBoostClassifier(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_classes_ => ToCsharp<int>(self.GetAttr("n_classes_"));
                public NDarray estimator_weights_ => ToCsharp<NDarray>(self.GetAttr("estimator_weights_"));
                public NDarray estimator_errors_ => ToCsharp<NDarray>(self.GetAttr("estimator_errors_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public AdaBoostClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public AdaBoostClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public AdaBoostClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public AdaBoostClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray staged_decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_decision_function", args, pyDict));
                }

                public NDarray staged_predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict", args, pyDict));
                }

                public NDarray staged_predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict_proba", args, pyDict));
                }

                public float staged_score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("staged_score", args, pyDict));
                }
            }

            public class AdaBoostRegressor : PythonObject
            {
                public AdaBoostRegressor(PyObject? estimator = null, int n_estimators = 50, float learning_rate = 1.0f, string loss = "linear", int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (estimator != null)
                        pyDict["estimator"] = ToPython(estimator);
                    if (n_estimators != 50)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (learning_rate != 1.0f)
                        pyDict["learning_rate"] = ToPython(learning_rate);
                    if (loss != "linear")
                        pyDict["loss"] = ToPython(loss);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.ensemble.self.InvokeMethod("AdaBoostRegressor", args, pyDict);
                }

                internal AdaBoostRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static AdaBoostRegressor Encapsule(PyObject pyObject)
                {
                    return new AdaBoostRegressor(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray estimator_weights_ => ToCsharp<NDarray>(self.GetAttr("estimator_weights_"));
                public NDarray estimator_errors_ => ToCsharp<NDarray>(self.GetAttr("estimator_errors_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public AdaBoostRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public AdaBoostRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public AdaBoostRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public AdaBoostRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray staged_predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict", args, pyDict));
                }

                public float staged_score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("staged_score", args, pyDict));
                }
            }

            public class BaggingClassifier : PythonObject
            {
                public BaggingClassifier(PyObject? estimator = null, int n_estimators = 10, float max_samples = 1.0f, float max_features = 1.0f, bool bootstrap = true, bool bootstrap_features = false, bool oob_score = false, bool warm_start = false, int? n_jobs = null, int? random_state = null, int verbose = 0)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (estimator != null)
                        pyDict["estimator"] = ToPython(estimator);
                    if (n_estimators != 10)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (max_samples != 1.0f)
                        pyDict["max_samples"] = ToPython(max_samples);
                    if (max_features != 1.0f)
                        pyDict["max_features"] = ToPython(max_features);
                    if (bootstrap != true)
                        pyDict["bootstrap"] = ToPython(bootstrap);
                    if (bootstrap_features != false)
                        pyDict["bootstrap_features"] = ToPython(bootstrap_features);
                    if (oob_score != false)
                        pyDict["oob_score"] = ToPython(oob_score);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.ensemble.self.InvokeMethod("BaggingClassifier", args, pyDict);
                }

                internal BaggingClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static BaggingClassifier Encapsule(PyObject pyObject)
                {
                    return new BaggingClassifier(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray estimators_samples_ => ToCsharp<NDarray>(self.GetAttr("estimators_samples_"));
                public NDarray estimators_features_ => ToCsharp<NDarray>(self.GetAttr("estimators_features_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_classes_ => ToCsharp<int>(self.GetAttr("n_classes_"));
                public float oob_score_ => ToCsharp<float>(self.GetAttr("oob_score_"));
                public NDarray oob_decision_function_ => ToCsharp<NDarray>(self.GetAttr("oob_decision_function_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public BaggingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public BaggingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public BaggingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public BaggingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class BaggingRegressor : PythonObject
            {
                public BaggingRegressor(PyObject? estimator = null, int n_estimators = 10, float max_samples = 1.0f, float max_features = 1.0f, bool bootstrap = true, bool bootstrap_features = false, bool oob_score = false, bool warm_start = false, int? n_jobs = null, int? random_state = null, int verbose = 0)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (estimator != null)
                        pyDict["estimator"] = ToPython(estimator);
                    if (n_estimators != 10)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (max_samples != 1.0f)
                        pyDict["max_samples"] = ToPython(max_samples);
                    if (max_features != 1.0f)
                        pyDict["max_features"] = ToPython(max_features);
                    if (bootstrap != true)
                        pyDict["bootstrap"] = ToPython(bootstrap);
                    if (bootstrap_features != false)
                        pyDict["bootstrap_features"] = ToPython(bootstrap_features);
                    if (oob_score != false)
                        pyDict["oob_score"] = ToPython(oob_score);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.ensemble.self.InvokeMethod("BaggingRegressor", args, pyDict);
                }

                internal BaggingRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static BaggingRegressor Encapsule(PyObject pyObject)
                {
                    return new BaggingRegressor(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray estimators_samples_ => ToCsharp<NDarray>(self.GetAttr("estimators_samples_"));
                public NDarray estimators_features_ => ToCsharp<NDarray>(self.GetAttr("estimators_features_"));
                public float oob_score_ => ToCsharp<float>(self.GetAttr("oob_score_"));
                public PyDict oob_prediction_ => new PyDict(self.GetAttr("oob_prediction_"));

                public BaggingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public BaggingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public BaggingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public BaggingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class ExtraTreesClassifier : PythonObject
            {
                public ExtraTreesClassifier(int n_estimators = 100, string criterion = "gini", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = false, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, PyDict? class_weight = null, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_estimators != 100)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (criterion != "gini")
                        pyDict["criterion"] = ToPython(criterion);
                    if (max_depth != null)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_samples_split != 2)
                        pyDict["min_samples_split"] = ToPython(min_samples_split);
                    if (min_samples_leaf != 1)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (min_weight_fraction_leaf != 0.0f)
                        pyDict["min_weight_fraction_leaf"] = ToPython(min_weight_fraction_leaf);
                    if (max_features != "sqrt")
                        pyDict["max_features"] = ToPython(max_features);
                    if (max_leaf_nodes != null)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (min_impurity_decrease != 0.0f)
                        pyDict["min_impurity_decrease"] = ToPython(min_impurity_decrease);
                    if (bootstrap != false)
                        pyDict["bootstrap"] = ToPython(bootstrap);
                    if (oob_score != false)
                        pyDict["oob_score"] = ToPython(oob_score);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (class_weight != null)
                        pyDict["class_weight"] = ToPython(class_weight);
                    if (ccp_alpha != 0.0f)
                        pyDict["ccp_alpha"] = ToPython(ccp_alpha);
                    if (max_samples != null)
                        pyDict["max_samples"] = ToPython(max_samples);
                    if (monotonic_cst != null)
                        pyDict["monotonic_cst"] = ToPython(monotonic_cst);
                    self = sklearn.ensemble.self.InvokeMethod("ExtraTreesClassifier", args, pyDict);
                }

                internal ExtraTreesClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static ExtraTreesClassifier Encapsule(PyObject pyObject)
                {
                    return new ExtraTreesClassifier(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_classes_ => ToCsharp<int>(self.GetAttr("n_classes_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => ToCsharp<int>(self.GetAttr("n_outputs_"));
                public float oob_score_ => ToCsharp<float>(self.GetAttr("oob_score_"));
                public NDarray oob_decision_function_ => ToCsharp<NDarray>(self.GetAttr("oob_decision_function_"));
                public NDarray estimators_samples_ => ToCsharp<NDarray>(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("apply", args, pyDict));
                }

                public (NDarray, NDarray) decision_path(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("decision_path", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public ExtraTreesClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public ExtraTreesClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public ExtraTreesClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public ExtraTreesClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class ExtraTreesRegressor : PythonObject
            {
                public ExtraTreesRegressor(int n_estimators = 100, string criterion = "squared_error", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = false, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_estimators != 100)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (criterion != "squared_error")
                        pyDict["criterion"] = ToPython(criterion);
                    if (max_depth != null)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_samples_split != 2)
                        pyDict["min_samples_split"] = ToPython(min_samples_split);
                    if (min_samples_leaf != 1)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (min_weight_fraction_leaf != 0.0f)
                        pyDict["min_weight_fraction_leaf"] = ToPython(min_weight_fraction_leaf);
                    if (max_features != 1.0f)
                        pyDict["max_features"] = ToPython(max_features);
                    if (max_leaf_nodes != null)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (min_impurity_decrease != 0.0f)
                        pyDict["min_impurity_decrease"] = ToPython(min_impurity_decrease);
                    if (bootstrap != false)
                        pyDict["bootstrap"] = ToPython(bootstrap);
                    if (oob_score != false)
                        pyDict["oob_score"] = ToPython(oob_score);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (ccp_alpha != 0.0f)
                        pyDict["ccp_alpha"] = ToPython(ccp_alpha);
                    if (max_samples != null)
                        pyDict["max_samples"] = ToPython(max_samples);
                    if (monotonic_cst != null)
                        pyDict["monotonic_cst"] = ToPython(monotonic_cst);
                    self = sklearn.ensemble.self.InvokeMethod("ExtraTreesRegressor", args, pyDict);
                }

                internal ExtraTreesRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static ExtraTreesRegressor Encapsule(PyObject pyObject)
                {
                    return new ExtraTreesRegressor(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => ToCsharp<int>(self.GetAttr("n_outputs_"));
                public float oob_score_ => ToCsharp<float>(self.GetAttr("oob_score_"));
                public PyDict oob_prediction_ => new PyDict(self.GetAttr("oob_prediction_"));
                public NDarray estimators_samples_ => ToCsharp<NDarray>(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("apply", args, pyDict));
                }

                public (NDarray, NDarray) decision_path(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("decision_path", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public ExtraTreesRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public ExtraTreesRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public ExtraTreesRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public ExtraTreesRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class GradientBoostingClassifier : PythonObject
            {
                public GradientBoostingClassifier(string loss = "log_loss", float learning_rate = 0.1f, int n_estimators = 100, float subsample = 1.0f, string criterion = "friedman_mse", int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_depth = 3, float min_impurity_decrease = 0.0f, PyObject? init = null, int? random_state = null, float? max_features = null, int verbose = 0, int? max_leaf_nodes = null, bool warm_start = false, float validation_fraction = 0.1f, int? n_iter_no_change = null, float tol = 0.0001f, float ccp_alpha = 0.0f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (loss != "log_loss")
                        pyDict["loss"] = ToPython(loss);
                    if (learning_rate != 0.1f)
                        pyDict["learning_rate"] = ToPython(learning_rate);
                    if (n_estimators != 100)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (subsample != 1.0f)
                        pyDict["subsample"] = ToPython(subsample);
                    if (criterion != "friedman_mse")
                        pyDict["criterion"] = ToPython(criterion);
                    if (min_samples_split != 2)
                        pyDict["min_samples_split"] = ToPython(min_samples_split);
                    if (min_samples_leaf != 1)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (min_weight_fraction_leaf != 0.0f)
                        pyDict["min_weight_fraction_leaf"] = ToPython(min_weight_fraction_leaf);
                    if (max_depth != 3)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_impurity_decrease != 0.0f)
                        pyDict["min_impurity_decrease"] = ToPython(min_impurity_decrease);
                    if (init != null)
                        pyDict["init"] = ToPython(init);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (max_features != null)
                        pyDict["max_features"] = ToPython(max_features);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (max_leaf_nodes != null)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = ToPython(validation_fraction);
                    if (n_iter_no_change != null)
                        pyDict["n_iter_no_change"] = ToPython(n_iter_no_change);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    if (ccp_alpha != 0.0f)
                        pyDict["ccp_alpha"] = ToPython(ccp_alpha);
                    self = sklearn.ensemble.self.InvokeMethod("GradientBoostingClassifier", args, pyDict);
                }

                internal GradientBoostingClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static GradientBoostingClassifier Encapsule(PyObject pyObject)
                {
                    return new GradientBoostingClassifier(pyObject);
                }

                public int n_estimators_ => ToCsharp<int>(self.GetAttr("n_estimators_"));
                public int n_trees_per_iteration_ => ToCsharp<int>(self.GetAttr("n_trees_per_iteration_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public NDarray oob_improvement_ => ToCsharp<NDarray>(self.GetAttr("oob_improvement_"));
                public NDarray oob_scores_ => ToCsharp<NDarray>(self.GetAttr("oob_scores_"));
                public float oob_score_ => ToCsharp<float>(self.GetAttr("oob_score_"));
                public NDarray train_score_ => ToCsharp<NDarray>(self.GetAttr("train_score_"));
                public PyObject init_ => self.GetAttr("init_");
                public NDarray estimators_ => ToCsharp<NDarray>(self.GetAttr("estimators_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_classes_ => ToCsharp<int>(self.GetAttr("n_classes_"));
                public int max_features_ => ToCsharp<int>(self.GetAttr("max_features_"));

                public NDarray apply(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("apply", args, pyDict));
                }

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public GradientBoostingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, PyObject? monitor = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    if (monitor != null)
                        pyDict["monitor"] = ToPython(monitor);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public GradientBoostingClassifier set_fit_request(string? monitor = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (monitor != "$UNCHANGED$")
                        pyDict["monitor"] = ToPython(monitor);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public GradientBoostingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public GradientBoostingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray staged_decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_decision_function", args, pyDict));
                }

                public NDarray staged_predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict", args, pyDict));
                }

                public NDarray staged_predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict_proba", args, pyDict));
                }
            }

            public class GradientBoostingRegressor : PythonObject
            {
                public GradientBoostingRegressor(string loss = "squared_error", float learning_rate = 0.1f, int n_estimators = 100, float subsample = 1.0f, string criterion = "friedman_mse", int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_depth = 3, float min_impurity_decrease = 0.0f, PyObject? init = null, int? random_state = null, float? max_features = null, float alpha = 0.9f, int verbose = 0, int? max_leaf_nodes = null, bool warm_start = false, float validation_fraction = 0.1f, int? n_iter_no_change = null, float tol = 0.0001f, float ccp_alpha = 0.0f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (loss != "squared_error")
                        pyDict["loss"] = ToPython(loss);
                    if (learning_rate != 0.1f)
                        pyDict["learning_rate"] = ToPython(learning_rate);
                    if (n_estimators != 100)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (subsample != 1.0f)
                        pyDict["subsample"] = ToPython(subsample);
                    if (criterion != "friedman_mse")
                        pyDict["criterion"] = ToPython(criterion);
                    if (min_samples_split != 2)
                        pyDict["min_samples_split"] = ToPython(min_samples_split);
                    if (min_samples_leaf != 1)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (min_weight_fraction_leaf != 0.0f)
                        pyDict["min_weight_fraction_leaf"] = ToPython(min_weight_fraction_leaf);
                    if (max_depth != 3)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_impurity_decrease != 0.0f)
                        pyDict["min_impurity_decrease"] = ToPython(min_impurity_decrease);
                    if (init != null)
                        pyDict["init"] = ToPython(init);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (max_features != null)
                        pyDict["max_features"] = ToPython(max_features);
                    if (alpha != 0.9f)
                        pyDict["alpha"] = ToPython(alpha);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (max_leaf_nodes != null)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = ToPython(validation_fraction);
                    if (n_iter_no_change != null)
                        pyDict["n_iter_no_change"] = ToPython(n_iter_no_change);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    if (ccp_alpha != 0.0f)
                        pyDict["ccp_alpha"] = ToPython(ccp_alpha);
                    self = sklearn.ensemble.self.InvokeMethod("GradientBoostingRegressor", args, pyDict);
                }

                internal GradientBoostingRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static GradientBoostingRegressor Encapsule(PyObject pyObject)
                {
                    return new GradientBoostingRegressor(pyObject);
                }

                public int n_estimators_ => ToCsharp<int>(self.GetAttr("n_estimators_"));
                public int n_trees_per_iteration_ => ToCsharp<int>(self.GetAttr("n_trees_per_iteration_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public NDarray oob_improvement_ => ToCsharp<NDarray>(self.GetAttr("oob_improvement_"));
                public NDarray oob_scores_ => ToCsharp<NDarray>(self.GetAttr("oob_scores_"));
                public float oob_score_ => ToCsharp<float>(self.GetAttr("oob_score_"));
                public NDarray train_score_ => ToCsharp<NDarray>(self.GetAttr("train_score_"));
                public PyObject init_ => self.GetAttr("init_");
                public NDarray estimators_ => ToCsharp<NDarray>(self.GetAttr("estimators_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int max_features_ => ToCsharp<int>(self.GetAttr("max_features_"));

                public NDarray apply(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("apply", args, pyDict));
                }

                public GradientBoostingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, PyObject? monitor = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    if (monitor != null)
                        pyDict["monitor"] = ToPython(monitor);
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

                public GradientBoostingRegressor set_fit_request(string? monitor = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (monitor != "$UNCHANGED$")
                        pyDict["monitor"] = ToPython(monitor);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public GradientBoostingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public GradientBoostingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray staged_predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict", args, pyDict));
                }
            }

            public class HistGradientBoostingClassifier : PythonObject
            {
                public HistGradientBoostingClassifier(string loss = "log_loss", float learning_rate = 0.1f, int max_iter = 100, int? max_leaf_nodes = 31, int? max_depth = null, int min_samples_leaf = 20, float l2_regularization = 0.0f, float max_features = 1.0f, int max_bins = 255, string? categorical_features = "warn", PyDict? monotonic_cst = null, int? interaction_cst = null, bool warm_start = false, string early_stopping = "auto", string? scoring = "loss", float? validation_fraction = 0.1f, int n_iter_no_change = 10, float tol = 1e-07f, int verbose = 0, int? random_state = null, PyDict? class_weight = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (loss != "log_loss")
                        pyDict["loss"] = ToPython(loss);
                    if (learning_rate != 0.1f)
                        pyDict["learning_rate"] = ToPython(learning_rate);
                    if (max_iter != 100)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (max_leaf_nodes != 31)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (max_depth != null)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_samples_leaf != 20)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (l2_regularization != 0.0f)
                        pyDict["l2_regularization"] = ToPython(l2_regularization);
                    if (max_features != 1.0f)
                        pyDict["max_features"] = ToPython(max_features);
                    if (max_bins != 255)
                        pyDict["max_bins"] = ToPython(max_bins);
                    if (categorical_features != "warn")
                        pyDict["categorical_features"] = ToPython(categorical_features);
                    if (monotonic_cst != null)
                        pyDict["monotonic_cst"] = ToPython(monotonic_cst);
                    if (interaction_cst != null)
                        pyDict["interaction_cst"] = ToPython(interaction_cst);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (early_stopping != "auto")
                        pyDict["early_stopping"] = ToPython(early_stopping);
                    if (scoring != "loss")
                        pyDict["scoring"] = ToPython(scoring);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = ToPython(validation_fraction);
                    if (n_iter_no_change != 10)
                        pyDict["n_iter_no_change"] = ToPython(n_iter_no_change);
                    if (tol != 1e-07f)
                        pyDict["tol"] = ToPython(tol);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (class_weight != null)
                        pyDict["class_weight"] = ToPython(class_weight);
                    self = sklearn.ensemble.self.InvokeMethod("HistGradientBoostingClassifier", args, pyDict);
                }

                internal HistGradientBoostingClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static HistGradientBoostingClassifier Encapsule(PyObject pyObject)
                {
                    return new HistGradientBoostingClassifier(pyObject);
                }

                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public bool do_early_stopping_ => ToCsharp<bool>(self.GetAttr("do_early_stopping_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public int n_trees_per_iteration_ => ToCsharp<int>(self.GetAttr("n_trees_per_iteration_"));
                public NDarray train_score_ => ToCsharp<NDarray>(self.GetAttr("train_score_"));
                public NDarray validation_score_ => ToCsharp<NDarray>(self.GetAttr("validation_score_"));
                public NDarray is_categorical_ => ToCsharp<NDarray>(self.GetAttr("is_categorical_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public HistGradientBoostingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public HistGradientBoostingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public HistGradientBoostingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public HistGradientBoostingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray staged_decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_decision_function", args, pyDict));
                }

                public NDarray staged_predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict", args, pyDict));
                }

                public NDarray staged_predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict_proba", args, pyDict));
                }
            }

            public class HistGradientBoostingRegressor : PythonObject
            {
                public HistGradientBoostingRegressor(string loss = "squared_error", float? quantile = null, float learning_rate = 0.1f, int max_iter = 100, int? max_leaf_nodes = 31, int? max_depth = null, int min_samples_leaf = 20, float l2_regularization = 0.0f, float max_features = 1.0f, int max_bins = 255, string? categorical_features = "warn", PyDict? monotonic_cst = null, int? interaction_cst = null, bool warm_start = false, string early_stopping = "auto", string? scoring = "loss", float? validation_fraction = 0.1f, int n_iter_no_change = 10, float tol = 1e-07f, int verbose = 0, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (loss != "squared_error")
                        pyDict["loss"] = ToPython(loss);
                    if (quantile != null)
                        pyDict["quantile"] = ToPython(quantile);
                    if (learning_rate != 0.1f)
                        pyDict["learning_rate"] = ToPython(learning_rate);
                    if (max_iter != 100)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (max_leaf_nodes != 31)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (max_depth != null)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_samples_leaf != 20)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (l2_regularization != 0.0f)
                        pyDict["l2_regularization"] = ToPython(l2_regularization);
                    if (max_features != 1.0f)
                        pyDict["max_features"] = ToPython(max_features);
                    if (max_bins != 255)
                        pyDict["max_bins"] = ToPython(max_bins);
                    if (categorical_features != "warn")
                        pyDict["categorical_features"] = ToPython(categorical_features);
                    if (monotonic_cst != null)
                        pyDict["monotonic_cst"] = ToPython(monotonic_cst);
                    if (interaction_cst != null)
                        pyDict["interaction_cst"] = ToPython(interaction_cst);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (early_stopping != "auto")
                        pyDict["early_stopping"] = ToPython(early_stopping);
                    if (scoring != "loss")
                        pyDict["scoring"] = ToPython(scoring);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = ToPython(validation_fraction);
                    if (n_iter_no_change != 10)
                        pyDict["n_iter_no_change"] = ToPython(n_iter_no_change);
                    if (tol != 1e-07f)
                        pyDict["tol"] = ToPython(tol);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.ensemble.self.InvokeMethod("HistGradientBoostingRegressor", args, pyDict);
                }

                internal HistGradientBoostingRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static HistGradientBoostingRegressor Encapsule(PyObject pyObject)
                {
                    return new HistGradientBoostingRegressor(pyObject);
                }

                public bool do_early_stopping_ => ToCsharp<bool>(self.GetAttr("do_early_stopping_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public int n_trees_per_iteration_ => ToCsharp<int>(self.GetAttr("n_trees_per_iteration_"));
                public NDarray train_score_ => ToCsharp<NDarray>(self.GetAttr("train_score_"));
                public NDarray validation_score_ => ToCsharp<NDarray>(self.GetAttr("validation_score_"));
                public NDarray is_categorical_ => ToCsharp<NDarray>(self.GetAttr("is_categorical_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public HistGradientBoostingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public HistGradientBoostingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public HistGradientBoostingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public HistGradientBoostingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray staged_predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("staged_predict", args, pyDict));
                }
            }

            public class IsolationForest : PythonObject
            {
                public IsolationForest(int n_estimators = 100, string max_samples = "auto", string contamination = "auto", float max_features = 1.0f, bool bootstrap = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_estimators != 100)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (max_samples != "auto")
                        pyDict["max_samples"] = ToPython(max_samples);
                    if (contamination != "auto")
                        pyDict["contamination"] = ToPython(contamination);
                    if (max_features != 1.0f)
                        pyDict["max_features"] = ToPython(max_features);
                    if (bootstrap != false)
                        pyDict["bootstrap"] = ToPython(bootstrap);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    self = sklearn.ensemble.self.InvokeMethod("IsolationForest", args, pyDict);
                }

                internal IsolationForest(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static IsolationForest Encapsule(PyObject pyObject)
                {
                    return new IsolationForest(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray estimators_features_ => ToCsharp<NDarray>(self.GetAttr("estimators_features_"));
                public NDarray estimators_samples_ => ToCsharp<NDarray>(self.GetAttr("estimators_samples_"));
                public int max_samples_ => ToCsharp<int>(self.GetAttr("max_samples_"));
                public float offset_ => ToCsharp<float>(self.GetAttr("offset_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public IsolationForest fit(NDarray X, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_predict", args, pyDict));
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

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("score_samples", args, pyDict));
                }

                public IsolationForest set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public IsolationForest set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class RandomForestClassifier : PythonObject
            {
                public RandomForestClassifier(int n_estimators = 100, string criterion = "gini", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = true, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, PyDict? class_weight = null, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_estimators != 100)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (criterion != "gini")
                        pyDict["criterion"] = ToPython(criterion);
                    if (max_depth != null)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_samples_split != 2)
                        pyDict["min_samples_split"] = ToPython(min_samples_split);
                    if (min_samples_leaf != 1)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (min_weight_fraction_leaf != 0.0f)
                        pyDict["min_weight_fraction_leaf"] = ToPython(min_weight_fraction_leaf);
                    if (max_features != "sqrt")
                        pyDict["max_features"] = ToPython(max_features);
                    if (max_leaf_nodes != null)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (min_impurity_decrease != 0.0f)
                        pyDict["min_impurity_decrease"] = ToPython(min_impurity_decrease);
                    if (bootstrap != true)
                        pyDict["bootstrap"] = ToPython(bootstrap);
                    if (oob_score != false)
                        pyDict["oob_score"] = ToPython(oob_score);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (class_weight != null)
                        pyDict["class_weight"] = ToPython(class_weight);
                    if (ccp_alpha != 0.0f)
                        pyDict["ccp_alpha"] = ToPython(ccp_alpha);
                    if (max_samples != null)
                        pyDict["max_samples"] = ToPython(max_samples);
                    if (monotonic_cst != null)
                        pyDict["monotonic_cst"] = ToPython(monotonic_cst);
                    self = sklearn.ensemble.self.InvokeMethod("RandomForestClassifier", args, pyDict);
                }

                internal RandomForestClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RandomForestClassifier Encapsule(PyObject pyObject)
                {
                    return new RandomForestClassifier(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_classes_ => ToCsharp<int>(self.GetAttr("n_classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => ToCsharp<int>(self.GetAttr("n_outputs_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public float oob_score_ => ToCsharp<float>(self.GetAttr("oob_score_"));
                public NDarray oob_decision_function_ => ToCsharp<NDarray>(self.GetAttr("oob_decision_function_"));
                public NDarray estimators_samples_ => ToCsharp<NDarray>(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("apply", args, pyDict));
                }

                public (NDarray, NDarray) decision_path(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("decision_path", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public RandomForestClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public RandomForestClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public RandomForestClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public RandomForestClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class RandomForestRegressor : PythonObject
            {
                public RandomForestRegressor(int n_estimators = 100, string criterion = "squared_error", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = true, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_estimators != 100)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (criterion != "squared_error")
                        pyDict["criterion"] = ToPython(criterion);
                    if (max_depth != null)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_samples_split != 2)
                        pyDict["min_samples_split"] = ToPython(min_samples_split);
                    if (min_samples_leaf != 1)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (min_weight_fraction_leaf != 0.0f)
                        pyDict["min_weight_fraction_leaf"] = ToPython(min_weight_fraction_leaf);
                    if (max_features != 1.0f)
                        pyDict["max_features"] = ToPython(max_features);
                    if (max_leaf_nodes != null)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (min_impurity_decrease != 0.0f)
                        pyDict["min_impurity_decrease"] = ToPython(min_impurity_decrease);
                    if (bootstrap != true)
                        pyDict["bootstrap"] = ToPython(bootstrap);
                    if (oob_score != false)
                        pyDict["oob_score"] = ToPython(oob_score);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (ccp_alpha != 0.0f)
                        pyDict["ccp_alpha"] = ToPython(ccp_alpha);
                    if (max_samples != null)
                        pyDict["max_samples"] = ToPython(max_samples);
                    if (monotonic_cst != null)
                        pyDict["monotonic_cst"] = ToPython(monotonic_cst);
                    self = sklearn.ensemble.self.InvokeMethod("RandomForestRegressor", args, pyDict);
                }

                internal RandomForestRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RandomForestRegressor Encapsule(PyObject pyObject)
                {
                    return new RandomForestRegressor(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => ToCsharp<int>(self.GetAttr("n_outputs_"));
                public float oob_score_ => ToCsharp<float>(self.GetAttr("oob_score_"));
                public PyDict oob_prediction_ => new PyDict(self.GetAttr("oob_prediction_"));
                public NDarray estimators_samples_ => ToCsharp<NDarray>(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("apply", args, pyDict));
                }

                public (NDarray, NDarray) decision_path(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("decision_path", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public RandomForestRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public RandomForestRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public RandomForestRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public RandomForestRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class RandomTreesEmbedding : PythonObject
            {
                public RandomTreesEmbedding(int n_estimators = 100, int max_depth = 5, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool sparse_output = true, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_estimators != 100)
                        pyDict["n_estimators"] = ToPython(n_estimators);
                    if (max_depth != 5)
                        pyDict["max_depth"] = ToPython(max_depth);
                    if (min_samples_split != 2)
                        pyDict["min_samples_split"] = ToPython(min_samples_split);
                    if (min_samples_leaf != 1)
                        pyDict["min_samples_leaf"] = ToPython(min_samples_leaf);
                    if (min_weight_fraction_leaf != 0.0f)
                        pyDict["min_weight_fraction_leaf"] = ToPython(min_weight_fraction_leaf);
                    if (max_leaf_nodes != null)
                        pyDict["max_leaf_nodes"] = ToPython(max_leaf_nodes);
                    if (min_impurity_decrease != 0.0f)
                        pyDict["min_impurity_decrease"] = ToPython(min_impurity_decrease);
                    if (sparse_output != true)
                        pyDict["sparse_output"] = ToPython(sparse_output);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    self = sklearn.ensemble.self.InvokeMethod("RandomTreesEmbedding", args, pyDict);
                }

                internal RandomTreesEmbedding(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RandomTreesEmbedding Encapsule(PyObject pyObject)
                {
                    return new RandomTreesEmbedding(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public NDarray feature_importances_ => ToCsharp<NDarray>(self.GetAttr("feature_importances_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => ToCsharp<int>(self.GetAttr("n_outputs_"));
                public PyObject one_hot_encoder_ => self.GetAttr("one_hot_encoder_");
                public NDarray estimators_samples_ => ToCsharp<NDarray>(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("apply", args, pyDict));
                }

                public (NDarray, NDarray) decision_path(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("decision_path", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public RandomTreesEmbedding fit(NDarray X, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public RandomTreesEmbedding set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public RandomTreesEmbedding set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public RandomTreesEmbedding set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class StackingClassifier : PythonObject
            {
                public StackingClassifier(PyTuple estimators, PyObject? final_estimator = null, int? cv = null, string stack_method = "auto", int? n_jobs = null, bool passthrough = false, int verbose = 0)
                {
                    PyTuple args = ToTuple(new object[] { estimators });
                    PyDict pyDict = new PyDict();
                    if (final_estimator != null)
                        pyDict["final_estimator"] = ToPython(final_estimator);
                    if (cv != null)
                        pyDict["cv"] = ToPython(cv);
                    if (stack_method != "auto")
                        pyDict["stack_method"] = ToPython(stack_method);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (passthrough != false)
                        pyDict["passthrough"] = ToPython(passthrough);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.ensemble.self.InvokeMethod("StackingClassifier", args, pyDict);
                }

                internal StackingClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static StackingClassifier Encapsule(PyObject pyObject)
                {
                    return new StackingClassifier(pyObject);
                }

                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public PyDict named_estimators_ => new PyDict(self.GetAttr("named_estimators_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public PyObject final_estimator_ => self.GetAttr("final_estimator_");
                public PyTuple stack_method_ => new PyTuple(self.GetAttr("stack_method_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public StackingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
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

                public StackingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public StackingClassifier set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public StackingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public StackingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class StackingRegressor : PythonObject
            {
                public StackingRegressor(PyTuple estimators, PyObject? final_estimator = null, int? cv = null, int? n_jobs = null, bool passthrough = false, int verbose = 0)
                {
                    PyTuple args = ToTuple(new object[] { estimators });
                    PyDict pyDict = new PyDict();
                    if (final_estimator != null)
                        pyDict["final_estimator"] = ToPython(final_estimator);
                    if (cv != null)
                        pyDict["cv"] = ToPython(cv);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (passthrough != false)
                        pyDict["passthrough"] = ToPython(passthrough);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.ensemble.self.InvokeMethod("StackingRegressor", args, pyDict);
                }

                internal StackingRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static StackingRegressor Encapsule(PyObject pyObject)
                {
                    return new StackingRegressor(pyObject);
                }

                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public PyDict named_estimators_ => new PyDict(self.GetAttr("named_estimators_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public PyObject final_estimator_ => self.GetAttr("final_estimator_");
                public PyTuple stack_method_ => new PyTuple(self.GetAttr("stack_method_"));

                public StackingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
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

                public StackingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public StackingRegressor set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public StackingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public StackingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class VotingClassifier : PythonObject
            {
                public VotingClassifier(PyTuple estimators, string voting = "hard", NDarray? weights = null, int? n_jobs = null, bool flatten_transform = true, bool verbose = false)
                {
                    PyTuple args = ToTuple(new object[] { estimators });
                    PyDict pyDict = new PyDict();
                    if (voting != "hard")
                        pyDict["voting"] = ToPython(voting);
                    if (weights != null)
                        pyDict["weights"] = ToPython(weights);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (flatten_transform != true)
                        pyDict["flatten_transform"] = ToPython(flatten_transform);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.ensemble.self.InvokeMethod("VotingClassifier", args, pyDict);
                }

                internal VotingClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static VotingClassifier Encapsule(PyObject pyObject)
                {
                    return new VotingClassifier(pyObject);
                }

                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public PyDict named_estimators_ => new PyDict(self.GetAttr("named_estimators_"));
                public PyObject le_ => self.GetAttr("le_");
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public VotingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public VotingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public VotingClassifier set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public VotingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public VotingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public (PyObject, bool, bool, PyObject) transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("transform", args, pyDict));
                    return (ToCsharp<PyObject>(result[0]), ToCsharp<bool>(result[1]), ToCsharp<bool>(result[2]), ToCsharp<PyObject>(result[3]));
                }
            }

            public class VotingRegressor : PythonObject
            {
                public VotingRegressor(PyTuple estimators, NDarray? weights = null, int? n_jobs = null, bool verbose = false)
                {
                    PyTuple args = ToTuple(new object[] { estimators });
                    PyDict pyDict = new PyDict();
                    if (weights != null)
                        pyDict["weights"] = ToPython(weights);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.ensemble.self.InvokeMethod("VotingRegressor", args, pyDict);
                }

                internal VotingRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static VotingRegressor Encapsule(PyObject pyObject)
                {
                    return new VotingRegressor(pyObject);
                }

                public PyTuple estimators_ => new PyTuple(self.GetAttr("estimators_"));
                public PyDict named_estimators_ => new PyDict(self.GetAttr("named_estimators_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public VotingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public VotingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public VotingRegressor set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public VotingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public VotingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public PyDict transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return new PyDict(self.InvokeMethod("transform", args, pyDict));
                }
            }
        }
    }
}