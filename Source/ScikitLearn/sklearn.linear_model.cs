using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class linear_model
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
                return Py.Import("sklearn.linear_model");
            }

            static linear_model()
            {
                ReInitializeLazySelf();
            }

            public class LogisticRegression : PythonObject
            {
                public LogisticRegression(string? penalty = "l2", bool dual = false, float tol = 0.0001f, float C = 1.0f, bool fit_intercept = true, int intercept_scaling = 1, PyDict? class_weight = null, int? random_state = null, string solver = "lbfgs", int max_iter = 100, string multi_class = "deprecated", int verbose = 0, bool warm_start = false, int? n_jobs = null, float? l1_ratio = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (penalty != "l2")
                        pyDict["penalty"] = Helpers.ToPython(penalty);
                    if (dual != false)
                        pyDict["dual"] = Helpers.ToPython(dual);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (C != 1.0f)
                        pyDict["C"] = Helpers.ToPython(C);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (intercept_scaling != 1)
                        pyDict["intercept_scaling"] = Helpers.ToPython(intercept_scaling);
                    if (class_weight != null)
                        pyDict["class_weight"] = Helpers.ToPython(class_weight);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (solver != "lbfgs")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (max_iter != 100)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (multi_class != "deprecated")
                        pyDict["multi_class"] = Helpers.ToPython(multi_class);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (l1_ratio != null)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    self = sklearn.linear_model.self.InvokeMethod("LogisticRegression", args, pyDict);
                }

                internal LogisticRegression(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static LogisticRegression Encapsule(PyObject pyObject)
                {
                    return new LogisticRegression(pyObject);
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public LogisticRegression densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public LogisticRegression fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict_log_proba(NDarray X)
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

                public LogisticRegression set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LogisticRegression set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LogisticRegression set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public LogisticRegression sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public class LogisticRegressionCV : PythonObject
            {
                public LogisticRegressionCV(int Cs = 10, bool fit_intercept = true, int? cv = null, bool dual = false, string penalty = "l2", string? scoring = null, string solver = "lbfgs", float tol = 0.0001f, int max_iter = 100, PyDict? class_weight = null, int? n_jobs = null, int verbose = 0, bool refit = true, float intercept_scaling = 1.0f, string multi_class = "deprecated", int? random_state = null, PyTuple? l1_ratios = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (Cs != 10)
                        pyDict["Cs"] = Helpers.ToPython(Cs);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (dual != false)
                        pyDict["dual"] = Helpers.ToPython(dual);
                    if (penalty != "l2")
                        pyDict["penalty"] = Helpers.ToPython(penalty);
                    if (scoring != null)
                        pyDict["scoring"] = Helpers.ToPython(scoring);
                    if (solver != "lbfgs")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (max_iter != 100)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (class_weight != null)
                        pyDict["class_weight"] = Helpers.ToPython(class_weight);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (refit != true)
                        pyDict["refit"] = Helpers.ToPython(refit);
                    if (intercept_scaling != 1.0f)
                        pyDict["intercept_scaling"] = Helpers.ToPython(intercept_scaling);
                    if (multi_class != "deprecated")
                        pyDict["multi_class"] = Helpers.ToPython(multi_class);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (l1_ratios != null)
                        pyDict["l1_ratios"] = Helpers.ToPython(l1_ratios);
                    self = sklearn.linear_model.self.InvokeMethod("LogisticRegressionCV", args, pyDict);
                }

                internal LogisticRegressionCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static LogisticRegressionCV Encapsule(PyObject pyObject)
                {
                    return new LogisticRegressionCV(pyObject);
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray Cs_ => Helpers.ToCSharpNDarray(self.GetAttr("Cs_"));
                public NDarray l1_ratios_ => Helpers.ToCSharpNDarray(self.GetAttr("l1_ratios_"));
                public NDarray coefs_paths_ => Helpers.ToCSharpNDarray(self.GetAttr("coefs_paths_"));
                public PyDict scores_ => new PyDict(self.GetAttr("scores_"));
                public NDarray C_ => Helpers.ToCSharpNDarray(self.GetAttr("C_"));
                public NDarray l1_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("l1_ratio_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public LogisticRegressionCV densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public LogisticRegressionCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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

                public NDarray predict_log_proba(NDarray X)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LogisticRegressionCV set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LogisticRegressionCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LogisticRegressionCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public LogisticRegressionCV sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public class PassiveAggressiveClassifier : PythonObject
            {
                public PassiveAggressiveClassifier(float C = 1.0f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, bool shuffle = true, int verbose = 0, string loss = "hinge", int? n_jobs = null, int? random_state = null, bool warm_start = false, PyDict? class_weight = null, bool average = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (C != 1.0f)
                        pyDict["C"] = Helpers.ToPython(C);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (early_stopping != false)
                        pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                    if (n_iter_no_change != 5)
                        pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (loss != "hinge")
                        pyDict["loss"] = Helpers.ToPython(loss);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (class_weight != null)
                        pyDict["class_weight"] = Helpers.ToPython(class_weight);
                    if (average != false)
                        pyDict["average"] = Helpers.ToPython(average);
                    self = sklearn.linear_model.self.InvokeMethod("PassiveAggressiveClassifier", args, pyDict);
                }

                internal PassiveAggressiveClassifier(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static PassiveAggressiveClassifier Encapsule(PyObject pyObject)
                {
                    return new PassiveAggressiveClassifier(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int t_ => Helpers.ToCSharpInt(self.GetAttr("t_"));
                public PyObject loss_function_ => self.GetAttr("loss_function_");

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public PassiveAggressiveClassifier densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public PassiveAggressiveClassifier fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != null)
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
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

                public PassiveAggressiveClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (classes != null)
                        pyDict["classes"] = Helpers.ToPython(classes);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public PassiveAggressiveClassifier set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (coef_init != "$UNCHANGED$")
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != "$UNCHANGED$")
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public PassiveAggressiveClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public PassiveAggressiveClassifier set_partial_fit_request(string? classes = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (classes != "$UNCHANGED$")
                        pyDict["classes"] = Helpers.ToPython(classes);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public PassiveAggressiveClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public PassiveAggressiveClassifier sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public class Perceptron : PythonObject
            {
                public Perceptron(PyObject? penalty = null, float alpha = 0.0001f, float l1_ratio = 0.15f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool shuffle = true, int verbose = 0, float eta0 = 1.0f, int? n_jobs = null, int? random_state = 0, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, PyDict? class_weight = null, bool warm_start = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (penalty != null)
                        pyDict["penalty"] = Helpers.ToPython(penalty);
                    if (alpha != 0.0001f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (l1_ratio != 0.15f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (eta0 != 1.0f)
                        pyDict["eta0"] = Helpers.ToPython(eta0);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (random_state != 0)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (early_stopping != false)
                        pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                    if (n_iter_no_change != 5)
                        pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                    if (class_weight != null)
                        pyDict["class_weight"] = Helpers.ToPython(class_weight);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    self = sklearn.linear_model.self.InvokeMethod("Perceptron", args, pyDict);
                }

                internal Perceptron(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static Perceptron Encapsule(PyObject pyObject)
                {
                    return new Perceptron(pyObject);
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public PyObject loss_function_ => self.GetAttr("loss_function_");
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int t_ => Helpers.ToCSharpInt(self.GetAttr("t_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public Perceptron densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public Perceptron fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != null)
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
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

                public Perceptron partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (classes != null)
                        pyDict["classes"] = Helpers.ToPython(classes);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public Perceptron set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (coef_init != "$UNCHANGED$")
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != "$UNCHANGED$")
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public Perceptron set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public Perceptron set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (classes != "$UNCHANGED$")
                        pyDict["classes"] = Helpers.ToPython(classes);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public Perceptron set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public Perceptron sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public class RidgeClassifier : PythonObject
            {
                public RidgeClassifier(float alpha = 1.0f, bool fit_intercept = true, bool copy_X = true, int? max_iter = null, float tol = 0.0001f, PyDict? class_weight = null, string solver = "auto", bool positive = false, int? random_state = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (max_iter != null)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (class_weight != null)
                        pyDict["class_weight"] = Helpers.ToPython(class_weight);
                    if (solver != "auto")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.linear_model.self.InvokeMethod("RidgeClassifier", args, pyDict);
                }

                internal RidgeClassifier(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static RidgeClassifier Encapsule(PyObject pyObject)
                {
                    return new RidgeClassifier(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public string solver_ => Helpers.ToCSharpString(self.GetAttr("solver_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public RidgeClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public RidgeClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public RidgeClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public RidgeClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class RidgeClassifierCV : PythonObject
            {
                public RidgeClassifierCV(PyTuple? alphas = null, bool fit_intercept = true, string? scoring = null, int? cv = null, PyDict? class_weight = null, bool? store_cv_results = null, string store_cv_values = "deprecated")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (scoring != null)
                        pyDict["scoring"] = Helpers.ToPython(scoring);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (class_weight != null)
                        pyDict["class_weight"] = Helpers.ToPython(class_weight);
                    if (store_cv_results != null)
                        pyDict["store_cv_results"] = Helpers.ToPython(store_cv_results);
                    if (store_cv_values != "deprecated")
                        pyDict["store_cv_values"] = Helpers.ToPython(store_cv_values);
                    self = sklearn.linear_model.self.InvokeMethod("RidgeClassifierCV", args, pyDict);
                }

                internal RidgeClassifierCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static RidgeClassifierCV Encapsule(PyObject pyObject)
                {
                    return new RidgeClassifierCV(pyObject);
                }

                public NDarray cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public float best_score_ => Helpers.ToCSharpFloat(self.GetAttr("best_score_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public RidgeClassifierCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public RidgeClassifierCV set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public RidgeClassifierCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public RidgeClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class SGDClassifier : PythonObject
            {
                public SGDClassifier(string loss = "hinge", string? penalty = "l2", float alpha = 0.0001f, float l1_ratio = 0.15f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool shuffle = true, int verbose = 0, float epsilon = 0.1f, int? n_jobs = null, int? random_state = null, string learning_rate = "optimal", float eta0 = 0.0f, float power_t = 0.5f, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, PyDict? class_weight = null, bool warm_start = false, bool average = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (loss != "hinge")
                        pyDict["loss"] = Helpers.ToPython(loss);
                    if (penalty != "l2")
                        pyDict["penalty"] = Helpers.ToPython(penalty);
                    if (alpha != 0.0001f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (l1_ratio != 0.15f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (epsilon != 0.1f)
                        pyDict["epsilon"] = Helpers.ToPython(epsilon);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (learning_rate != "optimal")
                        pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                    if (eta0 != 0.0f)
                        pyDict["eta0"] = Helpers.ToPython(eta0);
                    if (power_t != 0.5f)
                        pyDict["power_t"] = Helpers.ToPython(power_t);
                    if (early_stopping != false)
                        pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                    if (n_iter_no_change != 5)
                        pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                    if (class_weight != null)
                        pyDict["class_weight"] = Helpers.ToPython(class_weight);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (average != false)
                        pyDict["average"] = Helpers.ToPython(average);
                    self = sklearn.linear_model.self.InvokeMethod("SGDClassifier", args, pyDict);
                }

                internal SGDClassifier(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static SGDClassifier Encapsule(PyObject pyObject)
                {
                    return new SGDClassifier(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public PyObject loss_function_ => self.GetAttr("loss_function_");
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int t_ => Helpers.ToCSharpInt(self.GetAttr("t_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public SGDClassifier densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public SGDClassifier fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != null)
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
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

                public SGDClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (classes != null)
                        pyDict["classes"] = Helpers.ToPython(classes);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_log_proba(NDarray X)
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

                public SGDClassifier set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (coef_init != "$UNCHANGED$")
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != "$UNCHANGED$")
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public SGDClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public SGDClassifier set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (classes != "$UNCHANGED$")
                        pyDict["classes"] = Helpers.ToPython(classes);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public SGDClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public SGDClassifier sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public class SGDOneClassSVM : PythonObject
            {
                public SGDOneClassSVM(float nu = 0.5f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool shuffle = true, int verbose = 0, int? random_state = null, string learning_rate = "optimal", float eta0 = 0.0f, float power_t = 0.5f, bool warm_start = false, bool average = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (nu != 0.5f)
                        pyDict["nu"] = Helpers.ToPython(nu);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (learning_rate != "optimal")
                        pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                    if (eta0 != 0.0f)
                        pyDict["eta0"] = Helpers.ToPython(eta0);
                    if (power_t != 0.5f)
                        pyDict["power_t"] = Helpers.ToPython(power_t);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (average != false)
                        pyDict["average"] = Helpers.ToPython(average);
                    self = sklearn.linear_model.self.InvokeMethod("SGDOneClassSVM", args, pyDict);
                }

                internal SGDOneClassSVM(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static SGDOneClassSVM Encapsule(PyObject pyObject)
                {
                    return new SGDOneClassSVM(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray offset_ => Helpers.ToCSharpNDarray(self.GetAttr("offset_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int t_ => Helpers.ToCSharpInt(self.GetAttr("t_"));
                public PyObject loss_function_ => self.GetAttr("loss_function_");
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public SGDOneClassSVM densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public SGDOneClassSVM fit(NDarray X, NDarray? coef_init = null, NDarray? offset_init = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (offset_init != null)
                        pyDict["offset_init"] = Helpers.ToPython(offset_init);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_predict", args, pyDict));
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

                public SGDOneClassSVM partial_fit(NDarray X, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("score_samples", args, pyDict));
                }

                public SGDOneClassSVM set_fit_request(string? coef_init = "$UNCHANGED$", string? offset_init = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (coef_init != "$UNCHANGED$")
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (offset_init != "$UNCHANGED$")
                        pyDict["offset_init"] = Helpers.ToPython(offset_init);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public SGDOneClassSVM set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public SGDOneClassSVM set_partial_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public SGDOneClassSVM sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public class LinearRegression : PythonObject
            {
                public LinearRegression(bool fit_intercept = true, bool copy_X = true, int? n_jobs = null, bool positive = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    self = sklearn.linear_model.self.InvokeMethod("LinearRegression", args, pyDict);
                }

                internal LinearRegression(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static LinearRegression Encapsule(PyObject pyObject)
                {
                    return new LinearRegression(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public int rank_ => Helpers.ToCSharpInt(self.GetAttr("rank_"));
                public NDarray singular_ => Helpers.ToCSharpNDarray(self.GetAttr("singular_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public LinearRegression fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LinearRegression set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LinearRegression set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LinearRegression set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class Ridge : PythonObject
            {
                public Ridge(float alpha = 1.0f, bool fit_intercept = true, bool copy_X = true, int? max_iter = null, float tol = 0.0001f, string solver = "auto", bool positive = false, int? random_state = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (max_iter != null)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (solver != "auto")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.linear_model.self.InvokeMethod("Ridge", args, pyDict);
                }

                internal Ridge(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static Ridge Encapsule(PyObject pyObject)
                {
                    return new Ridge(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public string solver_ => Helpers.ToCSharpString(self.GetAttr("solver_"));

                public Ridge fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public Ridge set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public Ridge set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public Ridge set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class RidgeCV : PythonObject
            {
                public RidgeCV(PyTuple? alphas = null, bool fit_intercept = true, string? scoring = null, int? cv = null, PyObject? gcv_mode = null, bool? store_cv_results = null, bool alpha_per_target = false, string store_cv_values = "deprecated")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (scoring != null)
                        pyDict["scoring"] = Helpers.ToPython(scoring);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (gcv_mode != null)
                        pyDict["gcv_mode"] = Helpers.ToPython(gcv_mode);
                    if (store_cv_results != null)
                        pyDict["store_cv_results"] = Helpers.ToPython(store_cv_results);
                    if (alpha_per_target != false)
                        pyDict["alpha_per_target"] = Helpers.ToPython(alpha_per_target);
                    if (store_cv_values != "deprecated")
                        pyDict["store_cv_values"] = Helpers.ToPython(store_cv_values);
                    self = sklearn.linear_model.self.InvokeMethod("RidgeCV", args, pyDict);
                }

                internal RidgeCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static RidgeCV Encapsule(PyObject pyObject)
                {
                    return new RidgeCV(pyObject);
                }

                public NDarray cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray alpha_ => Helpers.ToCSharpNDarray(self.GetAttr("alpha_"));
                public NDarray best_score_ => Helpers.ToCSharpNDarray(self.GetAttr("best_score_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public RidgeCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public RidgeCV set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public RidgeCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public RidgeCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class SGDRegressor : PythonObject
            {
                public SGDRegressor(string loss = "squared_error", string? penalty = "l2", float alpha = 0.0001f, float l1_ratio = 0.15f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool shuffle = true, int verbose = 0, float epsilon = 0.1f, int? random_state = null, string learning_rate = "invscaling", float eta0 = 0.01f, float power_t = 0.25f, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, bool warm_start = false, bool average = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (loss != "squared_error")
                        pyDict["loss"] = Helpers.ToPython(loss);
                    if (penalty != "l2")
                        pyDict["penalty"] = Helpers.ToPython(penalty);
                    if (alpha != 0.0001f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (l1_ratio != 0.15f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (epsilon != 0.1f)
                        pyDict["epsilon"] = Helpers.ToPython(epsilon);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (learning_rate != "invscaling")
                        pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                    if (eta0 != 0.01f)
                        pyDict["eta0"] = Helpers.ToPython(eta0);
                    if (power_t != 0.25f)
                        pyDict["power_t"] = Helpers.ToPython(power_t);
                    if (early_stopping != false)
                        pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                    if (n_iter_no_change != 5)
                        pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (average != false)
                        pyDict["average"] = Helpers.ToPython(average);
                    self = sklearn.linear_model.self.InvokeMethod("SGDRegressor", args, pyDict);
                }

                internal SGDRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static SGDRegressor Encapsule(PyObject pyObject)
                {
                    return new SGDRegressor(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int t_ => Helpers.ToCSharpInt(self.GetAttr("t_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SGDRegressor densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public SGDRegressor fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != null)
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
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

                public SGDRegressor partial_fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public SGDRegressor set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (coef_init != "$UNCHANGED$")
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != "$UNCHANGED$")
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public SGDRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public SGDRegressor set_partial_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public SGDRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public SGDRegressor sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public class ElasticNet : PythonObject
            {
                public ElasticNet(float alpha = 1.0f, float l1_ratio = 0.5f, bool fit_intercept = true, bool precompute = false, int max_iter = 1000, bool copy_X = true, float tol = 0.0001f, bool warm_start = false, bool positive = false, int? random_state = null, string selection = "cyclic")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (precompute != false)
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (selection != "cyclic")
                        pyDict["selection"] = Helpers.ToPython(selection);
                    self = sklearn.linear_model.self.InvokeMethod("ElasticNet", args, pyDict);
                }

                internal ElasticNet(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static ElasticNet Encapsule(PyObject pyObject)
                {
                    return new ElasticNet(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray sparse_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("sparse_coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public PyTuple n_iter_ => new PyTuple(self.GetAttr("n_iter_"));
                public NDarray dual_gap_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_gap_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public ElasticNet fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
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

                public (NDarray? , NDarray? , NDarray? , PyTuple? ) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (return_n_iter != false)
                        pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    PyTuple result = new PyTuple(self.InvokeMethod("path", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public ElasticNet set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (check_input != "$UNCHANGED$")
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public ElasticNet set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public ElasticNet set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class ElasticNetCV : PythonObject
            {
                public ElasticNetCV(float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, bool fit_intercept = true, string precompute = "auto", int max_iter = 1000, float tol = 0.0001f, int? cv = null, bool copy_X = true, int verbose = 0, int? n_jobs = null, bool positive = false, int? random_state = null, string selection = "cyclic")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (selection != "cyclic")
                        pyDict["selection"] = Helpers.ToPython(selection);
                    self = sklearn.linear_model.self.InvokeMethod("ElasticNetCV", args, pyDict);
                }

                internal ElasticNetCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static ElasticNetCV Encapsule(PyObject pyObject)
                {
                    return new ElasticNetCV(pyObject);
                }

                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public float l1_ratio_ => Helpers.ToCSharpFloat(self.GetAttr("l1_ratio_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray mse_path_ => Helpers.ToCSharpNDarray(self.GetAttr("mse_path_"));
                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public float dual_gap_ => Helpers.ToCSharpFloat(self.GetAttr("dual_gap_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public ElasticNetCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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

                public (NDarray? , NDarray? , NDarray? , PyTuple? ) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (return_n_iter != false)
                        pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    PyTuple result = new PyTuple(self.InvokeMethod("path", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public ElasticNetCV set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public ElasticNetCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public ElasticNetCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class Lars : PythonObject
            {
                public Lars(bool fit_intercept = true, bool verbose = false, string precompute = "auto", int n_nonzero_coefs = 500, float eps = float.Epsilon, bool copy_X = true, bool fit_path = true, float? jitter = null, int? random_state = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (n_nonzero_coefs != 500)
                        pyDict["n_nonzero_coefs"] = Helpers.ToPython(n_nonzero_coefs);
                    if (eps != float.Epsilon)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (fit_path != true)
                        pyDict["fit_path"] = Helpers.ToPython(fit_path);
                    if (jitter != null)
                        pyDict["jitter"] = Helpers.ToPython(jitter);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.linear_model.self.InvokeMethod("Lars", args, pyDict);
                }

                internal Lars(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static Lars Encapsule(PyObject pyObject)
                {
                    return new Lars(pyObject);
                }

                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public NDarray active_ => Helpers.ToCSharpNDarray(self.GetAttr("active_"));
                public NDarray coef_path_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_path_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Lars fit(NDarray X, NDarray y, NDarray? Xy = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public Lars set_fit_request(string? Xy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (Xy != "$UNCHANGED$")
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public Lars set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public Lars set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class LarsCV : PythonObject
            {
                public LarsCV(bool fit_intercept = true, bool verbose = false, int max_iter = 500, string precompute = "auto", int? cv = null, int max_n_alphas = 1000, int? n_jobs = null, float eps = float.Epsilon, bool copy_X = true)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (max_iter != 500)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (max_n_alphas != 1000)
                        pyDict["max_n_alphas"] = Helpers.ToPython(max_n_alphas);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (eps != float.Epsilon)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    self = sklearn.linear_model.self.InvokeMethod("LarsCV", args, pyDict);
                }

                internal LarsCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static LarsCV Encapsule(PyObject pyObject)
                {
                    return new LarsCV(pyObject);
                }

                public PyTuple active_ => new PyTuple(self.GetAttr("active_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public NDarray coef_path_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_path_"));
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public NDarray cv_alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_alphas_"));
                public NDarray mse_path_ => Helpers.ToCSharpNDarray(self.GetAttr("mse_path_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public LarsCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LarsCV set_fit_request(string? Xy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (Xy != "$UNCHANGED$")
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LarsCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LarsCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class Lasso : PythonObject
            {
                public Lasso(float alpha = 1.0f, bool fit_intercept = true, bool precompute = false, bool copy_X = true, int max_iter = 1000, float tol = 0.0001f, bool warm_start = false, bool positive = false, int? random_state = null, string selection = "cyclic")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (precompute != false)
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (selection != "cyclic")
                        pyDict["selection"] = Helpers.ToPython(selection);
                    self = sklearn.linear_model.self.InvokeMethod("Lasso", args, pyDict);
                }

                internal Lasso(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static Lasso Encapsule(PyObject pyObject)
                {
                    return new Lasso(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray dual_gap_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_gap_"));
                public NDarray sparse_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("sparse_coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public PyTuple n_iter_ => new PyTuple(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Lasso fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
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

                public (NDarray? , NDarray? , NDarray? , PyTuple? ) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (return_n_iter != false)
                        pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    PyTuple result = new PyTuple(self.InvokeMethod("path", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public Lasso set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (check_input != "$UNCHANGED$")
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public Lasso set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public Lasso set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class LassoCV : PythonObject
            {
                public LassoCV(float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, bool fit_intercept = true, string precompute = "auto", int max_iter = 1000, float tol = 0.0001f, bool copy_X = true, int? cv = null, bool verbose = false, int? n_jobs = null, bool positive = false, int? random_state = null, string selection = "cyclic")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (selection != "cyclic")
                        pyDict["selection"] = Helpers.ToPython(selection);
                    self = sklearn.linear_model.self.InvokeMethod("LassoCV", args, pyDict);
                }

                internal LassoCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static LassoCV Encapsule(PyObject pyObject)
                {
                    return new LassoCV(pyObject);
                }

                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray mse_path_ => Helpers.ToCSharpNDarray(self.GetAttr("mse_path_"));
                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public NDarray dual_gap_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_gap_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public LassoCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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

                public (NDarray? , NDarray? , NDarray? , PyTuple? ) path(NDarray X, NDarray y, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (return_n_iter != false)
                        pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    PyTuple result = new PyTuple(self.InvokeMethod("path", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LassoCV set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LassoCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LassoCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class LassoLars : PythonObject
            {
                public LassoLars(float alpha = 1.0f, bool fit_intercept = true, bool verbose = false, string precompute = "auto", int max_iter = 500, float eps = float.Epsilon, bool copy_X = true, bool fit_path = true, bool positive = false, float? jitter = null, int? random_state = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (max_iter != 500)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (eps != float.Epsilon)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (fit_path != true)
                        pyDict["fit_path"] = Helpers.ToPython(fit_path);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (jitter != null)
                        pyDict["jitter"] = Helpers.ToPython(jitter);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.linear_model.self.InvokeMethod("LassoLars", args, pyDict);
                }

                internal LassoLars(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static LassoLars Encapsule(PyObject pyObject)
                {
                    return new LassoLars(pyObject);
                }

                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public PyTuple active_ => new PyTuple(self.GetAttr("active_"));
                public NDarray coef_path_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_path_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public LassoLars fit(NDarray X, NDarray y, NDarray? Xy = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LassoLars set_fit_request(string? Xy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (Xy != "$UNCHANGED$")
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LassoLars set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LassoLars set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class LassoLarsCV : PythonObject
            {
                public LassoLarsCV(bool fit_intercept = true, bool verbose = false, int max_iter = 500, string precompute = "auto", int? cv = null, int max_n_alphas = 1000, int? n_jobs = null, float eps = float.Epsilon, bool copy_X = true, bool positive = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (max_iter != 500)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (max_n_alphas != 1000)
                        pyDict["max_n_alphas"] = Helpers.ToPython(max_n_alphas);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (eps != float.Epsilon)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    self = sklearn.linear_model.self.InvokeMethod("LassoLarsCV", args, pyDict);
                }

                internal LassoLarsCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static LassoLarsCV Encapsule(PyObject pyObject)
                {
                    return new LassoLarsCV(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public NDarray coef_path_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_path_"));
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public NDarray cv_alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_alphas_"));
                public NDarray mse_path_ => Helpers.ToCSharpNDarray(self.GetAttr("mse_path_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public PyTuple active_ => new PyTuple(self.GetAttr("active_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public LassoLarsCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LassoLarsCV set_fit_request(string? Xy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (Xy != "$UNCHANGED$")
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LassoLarsCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LassoLarsCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class LassoLarsIC : PythonObject
            {
                public LassoLarsIC(string criterion = "aic", bool fit_intercept = true, bool verbose = false, string precompute = "auto", int max_iter = 500, float eps = float.Epsilon, bool copy_X = true, bool positive = false, float? noise_variance = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (criterion != "aic")
                        pyDict["criterion"] = Helpers.ToPython(criterion);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (max_iter != 500)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (eps != float.Epsilon)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (noise_variance != null)
                        pyDict["noise_variance"] = Helpers.ToPython(noise_variance);
                    self = sklearn.linear_model.self.InvokeMethod("LassoLarsIC", args, pyDict);
                }

                internal LassoLarsIC(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static LassoLarsIC Encapsule(PyObject pyObject)
                {
                    return new LassoLarsIC(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray criterion_ => Helpers.ToCSharpNDarray(self.GetAttr("criterion_"));
                public float noise_variance_ => Helpers.ToCSharpFloat(self.GetAttr("noise_variance_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public LassoLarsIC fit(NDarray X, NDarray y, bool? copy_X = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (copy_X != null)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LassoLarsIC set_fit_request(string? copy_X = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy_X != "$UNCHANGED$")
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LassoLarsIC set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LassoLarsIC set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class OrthogonalMatchingPursuit : PythonObject
            {
                public OrthogonalMatchingPursuit(int? n_nonzero_coefs = null, float? tol = null, bool fit_intercept = true, string precompute = "auto")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_nonzero_coefs != null)
                        pyDict["n_nonzero_coefs"] = Helpers.ToPython(n_nonzero_coefs);
                    if (tol != null)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    self = sklearn.linear_model.self.InvokeMethod("OrthogonalMatchingPursuit", args, pyDict);
                }

                internal OrthogonalMatchingPursuit(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static OrthogonalMatchingPursuit Encapsule(PyObject pyObject)
                {
                    return new OrthogonalMatchingPursuit(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_nonzero_coefs_ => Helpers.ToCSharpInt(self.GetAttr("n_nonzero_coefs_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public OrthogonalMatchingPursuit fit(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public OrthogonalMatchingPursuit set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public OrthogonalMatchingPursuit set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class OrthogonalMatchingPursuitCV : PythonObject
            {
                public OrthogonalMatchingPursuitCV(bool copy = true, bool fit_intercept = true, int? max_iter = null, int? cv = null, int? n_jobs = null, bool verbose = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != null)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    self = sklearn.linear_model.self.InvokeMethod("OrthogonalMatchingPursuitCV", args, pyDict);
                }

                internal OrthogonalMatchingPursuitCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static OrthogonalMatchingPursuitCV Encapsule(PyObject pyObject)
                {
                    return new OrthogonalMatchingPursuitCV(pyObject);
                }

                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public int n_nonzero_coefs_ => Helpers.ToCSharpInt(self.GetAttr("n_nonzero_coefs_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public OrthogonalMatchingPursuitCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public OrthogonalMatchingPursuitCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public OrthogonalMatchingPursuitCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class ARDRegression : PythonObject
            {
                public ARDRegression(int max_iter = 300, float tol = 0.001f, float alpha_1 = 1e-06f, float alpha_2 = 1e-06f, float lambda_1 = 1e-06f, float lambda_2 = 1e-06f, bool compute_score = false, float threshold_lambda = 10000.0f, bool fit_intercept = true, bool copy_X = true, bool verbose = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (max_iter != 300)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (alpha_1 != 1e-06f)
                        pyDict["alpha_1"] = Helpers.ToPython(alpha_1);
                    if (alpha_2 != 1e-06f)
                        pyDict["alpha_2"] = Helpers.ToPython(alpha_2);
                    if (lambda_1 != 1e-06f)
                        pyDict["lambda_1"] = Helpers.ToPython(lambda_1);
                    if (lambda_2 != 1e-06f)
                        pyDict["lambda_2"] = Helpers.ToPython(lambda_2);
                    if (compute_score != false)
                        pyDict["compute_score"] = Helpers.ToPython(compute_score);
                    if (threshold_lambda != 10000.0f)
                        pyDict["threshold_lambda"] = Helpers.ToPython(threshold_lambda);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    self = sklearn.linear_model.self.InvokeMethod("ARDRegression", args, pyDict);
                }

                internal ARDRegression(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static ARDRegression Encapsule(PyObject pyObject)
                {
                    return new ARDRegression(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public NDarray lambda_ => Helpers.ToCSharpNDarray(self.GetAttr("lambda_"));
                public NDarray sigma_ => Helpers.ToCSharpNDarray(self.GetAttr("sigma_"));
                public float scores_ => Helpers.ToCSharpFloat(self.GetAttr("scores_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public float X_offset_ => Helpers.ToCSharpFloat(self.GetAttr("X_offset_"));
                public float X_scale_ => Helpers.ToCSharpFloat(self.GetAttr("X_scale_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public ARDRegression fit(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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

                public ARDRegression set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public ARDRegression set_predict_request(string? return_std = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (return_std != "$UNCHANGED$")
                        pyDict["return_std"] = Helpers.ToPython(return_std);
                    self.InvokeMethod("set_predict_request", args, pyDict);
                    return this;
                }

                public ARDRegression set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class BayesianRidge : PythonObject
            {
                public BayesianRidge(int max_iter = 300, float tol = 0.001f, float alpha_1 = 1e-06f, float alpha_2 = 1e-06f, float lambda_1 = 1e-06f, float lambda_2 = 1e-06f, float? alpha_init = null, float? lambda_init = null, bool compute_score = false, bool fit_intercept = true, bool copy_X = true, bool verbose = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (max_iter != 300)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (alpha_1 != 1e-06f)
                        pyDict["alpha_1"] = Helpers.ToPython(alpha_1);
                    if (alpha_2 != 1e-06f)
                        pyDict["alpha_2"] = Helpers.ToPython(alpha_2);
                    if (lambda_1 != 1e-06f)
                        pyDict["lambda_1"] = Helpers.ToPython(lambda_1);
                    if (lambda_2 != 1e-06f)
                        pyDict["lambda_2"] = Helpers.ToPython(lambda_2);
                    if (alpha_init != null)
                        pyDict["alpha_init"] = Helpers.ToPython(alpha_init);
                    if (lambda_init != null)
                        pyDict["lambda_init"] = Helpers.ToPython(lambda_init);
                    if (compute_score != false)
                        pyDict["compute_score"] = Helpers.ToPython(compute_score);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    self = sklearn.linear_model.self.InvokeMethod("BayesianRidge", args, pyDict);
                }

                internal BayesianRidge(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static BayesianRidge Encapsule(PyObject pyObject)
                {
                    return new BayesianRidge(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public float lambda_ => Helpers.ToCSharpFloat(self.GetAttr("lambda_"));
                public NDarray sigma_ => Helpers.ToCSharpNDarray(self.GetAttr("sigma_"));
                public NDarray scores_ => Helpers.ToCSharpNDarray(self.GetAttr("scores_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray X_offset_ => Helpers.ToCSharpNDarray(self.GetAttr("X_offset_"));
                public NDarray X_scale_ => Helpers.ToCSharpNDarray(self.GetAttr("X_scale_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public BayesianRidge fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public BayesianRidge set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public BayesianRidge set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public BayesianRidge set_predict_request(string? return_std = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (return_std != "$UNCHANGED$")
                        pyDict["return_std"] = Helpers.ToPython(return_std);
                    self.InvokeMethod("set_predict_request", args, pyDict);
                    return this;
                }

                public BayesianRidge set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class MultiTaskElasticNet : PythonObject
            {
                public MultiTaskElasticNet(float alpha = 1.0f, float l1_ratio = 0.5f, bool fit_intercept = true, bool copy_X = true, int max_iter = 1000, float tol = 0.0001f, bool warm_start = false, int? random_state = null, string selection = "cyclic")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (selection != "cyclic")
                        pyDict["selection"] = Helpers.ToPython(selection);
                    self = sklearn.linear_model.self.InvokeMethod("MultiTaskElasticNet", args, pyDict);
                }

                internal MultiTaskElasticNet(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static MultiTaskElasticNet Encapsule(PyObject pyObject)
                {
                    return new MultiTaskElasticNet(pyObject);
                }

                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public float dual_gap_ => Helpers.ToCSharpFloat(self.GetAttr("dual_gap_"));
                public float eps_ => Helpers.ToCSharpFloat(self.GetAttr("eps_"));
                public NDarray sparse_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("sparse_coef_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MultiTaskElasticNet fit(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public (NDarray? , NDarray? , NDarray? , PyTuple? ) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (return_n_iter != false)
                        pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    PyTuple result = new PyTuple(self.InvokeMethod("path", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public MultiTaskElasticNet set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (check_input != "$UNCHANGED$")
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public MultiTaskElasticNet set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public MultiTaskElasticNet set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class MultiTaskElasticNetCV : PythonObject
            {
                public MultiTaskElasticNetCV(float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, bool fit_intercept = true, int max_iter = 1000, float tol = 0.0001f, int? cv = null, bool copy_X = true, int verbose = 0, int? n_jobs = null, int? random_state = null, string selection = "cyclic")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (selection != "cyclic")
                        pyDict["selection"] = Helpers.ToPython(selection);
                    self = sklearn.linear_model.self.InvokeMethod("MultiTaskElasticNetCV", args, pyDict);
                }

                internal MultiTaskElasticNetCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static MultiTaskElasticNetCV Encapsule(PyObject pyObject)
                {
                    return new MultiTaskElasticNetCV(pyObject);
                }

                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public NDarray mse_path_ => Helpers.ToCSharpNDarray(self.GetAttr("mse_path_"));
                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public float l1_ratio_ => Helpers.ToCSharpFloat(self.GetAttr("l1_ratio_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public float dual_gap_ => Helpers.ToCSharpFloat(self.GetAttr("dual_gap_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MultiTaskElasticNetCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
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

                public (NDarray? , NDarray? , NDarray? , PyTuple? ) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (return_n_iter != false)
                        pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    PyTuple result = new PyTuple(self.InvokeMethod("path", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public MultiTaskElasticNetCV set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public MultiTaskElasticNetCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public MultiTaskElasticNetCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class MultiTaskLasso : PythonObject
            {
                public MultiTaskLasso(float alpha = 1.0f, bool fit_intercept = true, bool copy_X = true, int max_iter = 1000, float tol = 0.0001f, bool warm_start = false, int? random_state = null, string selection = "cyclic")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (selection != "cyclic")
                        pyDict["selection"] = Helpers.ToPython(selection);
                    self = sklearn.linear_model.self.InvokeMethod("MultiTaskLasso", args, pyDict);
                }

                internal MultiTaskLasso(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static MultiTaskLasso Encapsule(PyObject pyObject)
                {
                    return new MultiTaskLasso(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray dual_gap_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_gap_"));
                public float eps_ => Helpers.ToCSharpFloat(self.GetAttr("eps_"));
                public NDarray sparse_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("sparse_coef_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MultiTaskLasso fit(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public (NDarray? , NDarray? , NDarray? , PyTuple? ) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (l1_ratio != 0.5f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (return_n_iter != false)
                        pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    PyTuple result = new PyTuple(self.InvokeMethod("path", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public MultiTaskLasso set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (check_input != "$UNCHANGED$")
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public MultiTaskLasso set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public MultiTaskLasso set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class MultiTaskLassoCV : PythonObject
            {
                public MultiTaskLassoCV(float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, bool fit_intercept = true, int max_iter = 1000, float tol = 0.0001f, bool copy_X = true, int? cv = null, bool verbose = false, int? n_jobs = null, int? random_state = null, string selection = "cyclic")
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (cv != null)
                        pyDict["cv"] = Helpers.ToPython(cv);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (selection != "cyclic")
                        pyDict["selection"] = Helpers.ToPython(selection);
                    self = sklearn.linear_model.self.InvokeMethod("MultiTaskLassoCV", args, pyDict);
                }

                internal MultiTaskLassoCV(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static MultiTaskLassoCV Encapsule(PyObject pyObject)
                {
                    return new MultiTaskLassoCV(pyObject);
                }

                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public NDarray mse_path_ => Helpers.ToCSharpNDarray(self.GetAttr("mse_path_"));
                public NDarray alphas_ => Helpers.ToCSharpNDarray(self.GetAttr("alphas_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public float dual_gap_ => Helpers.ToCSharpFloat(self.GetAttr("dual_gap_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MultiTaskLassoCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
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

                public (NDarray? , NDarray? , NDarray? , PyTuple? ) path(NDarray X, NDarray y, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (eps != 0.001f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (n_alphas != 100)
                        pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                    if (alphas != null)
                        pyDict["alphas"] = Helpers.ToPython(alphas);
                    if (precompute != "auto")
                        pyDict["precompute"] = Helpers.ToPython(precompute);
                    if (Xy != null)
                        pyDict["Xy"] = Helpers.ToPython(Xy);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (return_n_iter != false)
                        pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                    if (positive != false)
                        pyDict["positive"] = Helpers.ToPython(positive);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    PyTuple result = new PyTuple(self.InvokeMethod("path", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public MultiTaskLassoCV set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public MultiTaskLassoCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public MultiTaskLassoCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class HuberRegressor : PythonObject
            {
                public HuberRegressor(float epsilon = 1.35f, int max_iter = 100, float alpha = 0.0001f, bool warm_start = false, bool fit_intercept = true, float tol = 1e-05f)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (epsilon != 1.35f)
                        pyDict["epsilon"] = Helpers.ToPython(epsilon);
                    if (max_iter != 100)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (alpha != 0.0001f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (tol != 1e-05f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    self = sklearn.linear_model.self.InvokeMethod("HuberRegressor", args, pyDict);
                }

                internal HuberRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static HuberRegressor Encapsule(PyObject pyObject)
                {
                    return new HuberRegressor(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public float scale_ => Helpers.ToCSharpFloat(self.GetAttr("scale_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray outliers_ => Helpers.ToCSharpNDarray(self.GetAttr("outliers_"));

                public HuberRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public HuberRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public HuberRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public HuberRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class QuantileRegressor : PythonObject
            {
                public QuantileRegressor(float quantile = 0.5f, float alpha = 1.0f, bool fit_intercept = true, string solver = "highs", PyDict? solver_options = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (quantile != 0.5f)
                        pyDict["quantile"] = Helpers.ToPython(quantile);
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (solver != "highs")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (solver_options != null)
                        pyDict["solver_options"] = Helpers.ToPython(solver_options);
                    self = sklearn.linear_model.self.InvokeMethod("QuantileRegressor", args, pyDict);
                }

                internal QuantileRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static QuantileRegressor Encapsule(PyObject pyObject)
                {
                    return new QuantileRegressor(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));

                public QuantileRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public QuantileRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public QuantileRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public QuantileRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class RANSACRegressor : PythonObject
            {
                public RANSACRegressor(PyObject? estimator = null, float? min_samples = null, float? residual_threshold = null, PyObject? is_data_valid = null, PyObject? is_model_valid = null, int max_trials = 100, float max_skips = float.PositiveInfinity, float stop_n_inliers = float.PositiveInfinity, float stop_score = float.PositiveInfinity, float stop_probability = 0.99f, string loss = "absolute_error", int? random_state = null)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (estimator != null)
                        pyDict["estimator"] = Helpers.ToPython(estimator);
                    if (min_samples != null)
                        pyDict["min_samples"] = Helpers.ToPython(min_samples);
                    if (residual_threshold != null)
                        pyDict["residual_threshold"] = Helpers.ToPython(residual_threshold);
                    if (is_data_valid != null)
                        pyDict["is_data_valid"] = Helpers.ToPython(is_data_valid);
                    if (is_model_valid != null)
                        pyDict["is_model_valid"] = Helpers.ToPython(is_model_valid);
                    if (max_trials != 100)
                        pyDict["max_trials"] = Helpers.ToPython(max_trials);
                    if (max_skips != float.PositiveInfinity)
                        pyDict["max_skips"] = Helpers.ToPython(max_skips);
                    if (stop_n_inliers != float.PositiveInfinity)
                        pyDict["stop_n_inliers"] = Helpers.ToPython(stop_n_inliers);
                    if (stop_score != float.PositiveInfinity)
                        pyDict["stop_score"] = Helpers.ToPython(stop_score);
                    if (stop_probability != 0.99f)
                        pyDict["stop_probability"] = Helpers.ToPython(stop_probability);
                    if (loss != "absolute_error")
                        pyDict["loss"] = Helpers.ToPython(loss);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.linear_model.self.InvokeMethod("RANSACRegressor", args, pyDict);
                }

                internal RANSACRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static RANSACRegressor Encapsule(PyObject pyObject)
                {
                    return new RANSACRegressor(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public int n_trials_ => Helpers.ToCSharpInt(self.GetAttr("n_trials_"));
                public NDarray inlier_mask_ => Helpers.ToCSharpNDarray(self.GetAttr("inlier_mask_"));
                public int n_skips_no_inliers_ => Helpers.ToCSharpInt(self.GetAttr("n_skips_no_inliers_"));
                public int n_skips_invalid_data_ => Helpers.ToCSharpInt(self.GetAttr("n_skips_invalid_data_"));
                public int n_skips_invalid_model_ => Helpers.ToCSharpInt(self.GetAttr("n_skips_invalid_model_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public RANSACRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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

                public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public RANSACRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public RANSACRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class TheilSenRegressor : PythonObject
            {
                public TheilSenRegressor(bool fit_intercept = true, bool copy_X = true, float max_subpopulation = 10000.0f, int? n_subsamples = null, int max_iter = 300, float tol = 0.001f, int? random_state = null, int? n_jobs = null, bool verbose = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (max_subpopulation != 10000.0f)
                        pyDict["max_subpopulation"] = Helpers.ToPython(max_subpopulation);
                    if (n_subsamples != null)
                        pyDict["n_subsamples"] = Helpers.ToPython(n_subsamples);
                    if (max_iter != 300)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    self = sklearn.linear_model.self.InvokeMethod("TheilSenRegressor", args, pyDict);
                }

                internal TheilSenRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static TheilSenRegressor Encapsule(PyObject pyObject)
                {
                    return new TheilSenRegressor(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public float breakdown_ => Helpers.ToCSharpFloat(self.GetAttr("breakdown_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_subpopulation_ => Helpers.ToCSharpInt(self.GetAttr("n_subpopulation_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public TheilSenRegressor fit(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public TheilSenRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public TheilSenRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class GammaRegressor : PythonObject
            {
                public GammaRegressor(float alpha = 1.0f, bool fit_intercept = true, string solver = "lbfgs", int max_iter = 100, float tol = 0.0001f, bool warm_start = false, int verbose = 0)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (solver != "lbfgs")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (max_iter != 100)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    self = sklearn.linear_model.self.InvokeMethod("GammaRegressor", args, pyDict);
                }

                internal GammaRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static GammaRegressor Encapsule(PyObject pyObject)
                {
                    return new GammaRegressor(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public GammaRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public GammaRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public GammaRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public GammaRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class PoissonRegressor : PythonObject
            {
                public PoissonRegressor(float alpha = 1.0f, bool fit_intercept = true, string solver = "lbfgs", int max_iter = 100, float tol = 0.0001f, bool warm_start = false, int verbose = 0)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (solver != "lbfgs")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (max_iter != 100)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    self = sklearn.linear_model.self.InvokeMethod("PoissonRegressor", args, pyDict);
                }

                internal PoissonRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static PoissonRegressor Encapsule(PyObject pyObject)
                {
                    return new PoissonRegressor(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));

                public PoissonRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public PoissonRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public PoissonRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public PoissonRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class TweedieRegressor : PythonObject
            {
                public TweedieRegressor(float power = 0.0f, float alpha = 1.0f, bool fit_intercept = true, string link = "auto", string solver = "lbfgs", int max_iter = 100, float tol = 0.0001f, bool warm_start = false, int verbose = 0)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (power != 0.0f)
                        pyDict["power"] = Helpers.ToPython(power);
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (link != "auto")
                        pyDict["link"] = Helpers.ToPython(link);
                    if (solver != "lbfgs")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (max_iter != 100)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    self = sklearn.linear_model.self.InvokeMethod("TweedieRegressor", args, pyDict);
                }

                internal TweedieRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static TweedieRegressor Encapsule(PyObject pyObject)
                {
                    return new TweedieRegressor(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public float intercept_ => Helpers.ToCSharpFloat(self.GetAttr("intercept_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public TweedieRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public TweedieRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public TweedieRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public TweedieRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class PassiveAggressiveRegressor : PythonObject
            {
                public PassiveAggressiveRegressor(float C = 1.0f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, bool shuffle = true, int verbose = 0, string loss = "epsilon_insensitive", float epsilon = 0.1f, int? random_state = null, bool warm_start = false, bool average = false)
                {
                    _ = sklearn.linear_model.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (C != 1.0f)
                        pyDict["C"] = Helpers.ToPython(C);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (early_stopping != false)
                        pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                    if (n_iter_no_change != 5)
                        pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (loss != "epsilon_insensitive")
                        pyDict["loss"] = Helpers.ToPython(loss);
                    if (epsilon != 0.1f)
                        pyDict["epsilon"] = Helpers.ToPython(epsilon);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (average != false)
                        pyDict["average"] = Helpers.ToPython(average);
                    self = sklearn.linear_model.self.InvokeMethod("PassiveAggressiveRegressor", args, pyDict);
                }

                internal PassiveAggressiveRegressor(PyObject pyObject)
                {
                    _ = sklearn.linear_model.self;
                    self = pyObject;
                }

                public static PassiveAggressiveRegressor Encapsule(PyObject pyObject)
                {
                    return new PassiveAggressiveRegressor(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int t_ => Helpers.ToCSharpInt(self.GetAttr("t_"));

                public PassiveAggressiveRegressor densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public PassiveAggressiveRegressor fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (coef_init != null)
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != null)
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
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

                public PassiveAggressiveRegressor partial_fit(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public PassiveAggressiveRegressor set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (coef_init != "$UNCHANGED$")
                        pyDict["coef_init"] = Helpers.ToPython(coef_init);
                    if (intercept_init != "$UNCHANGED$")
                        pyDict["intercept_init"] = Helpers.ToPython(intercept_init);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public PassiveAggressiveRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public PassiveAggressiveRegressor set_partial_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public PassiveAggressiveRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public PassiveAggressiveRegressor sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public static (NDarray? , NDarray? , NDarray? , PyTuple? ) enet_path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null)
            {
                _ = sklearn.linear_model.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                PyDict pyDict = new PyDict();
                if (l1_ratio != 0.5f)
                    pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                if (eps != 0.001f)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (n_alphas != 100)
                    pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                if (alphas != null)
                    pyDict["alphas"] = Helpers.ToPython(alphas);
                if (precompute != "auto")
                    pyDict["precompute"] = Helpers.ToPython(precompute);
                if (Xy != null)
                    pyDict["Xy"] = Helpers.ToPython(Xy);
                if (copy_X != true)
                    pyDict["copy_X"] = Helpers.ToPython(copy_X);
                if (coef_init != null)
                    pyDict["coef_init"] = Helpers.ToPython(coef_init);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                if (positive != false)
                    pyDict["positive"] = Helpers.ToPython(positive);
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                PyTuple result = new PyTuple(sklearn.linear_model.self.InvokeMethod("enet_path", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
            }

            public static (NDarray? , NDarray? , NDarray? , int? ) lars_path(NDarray X, NDarray y, NDarray? Xy = null, NDarray? Gram = null, int max_iter = 500, int alpha_min = 0, string method = "lar", bool copy_X = true, float eps = float.Epsilon, bool copy_Gram = true, int verbose = 0, bool return_path = true, bool return_n_iter = false, bool positive = false)
            {
                _ = sklearn.linear_model.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                PyDict pyDict = new PyDict();
                if (Xy != null)
                    pyDict["Xy"] = Helpers.ToPython(Xy);
                if (Gram != null)
                    pyDict["Gram"] = Helpers.ToPython(Gram);
                if (max_iter != 500)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (alpha_min != 0)
                    pyDict["alpha_min"] = Helpers.ToPython(alpha_min);
                if (method != "lar")
                    pyDict["method"] = Helpers.ToPython(method);
                if (copy_X != true)
                    pyDict["copy_X"] = Helpers.ToPython(copy_X);
                if (eps != float.Epsilon)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (copy_Gram != true)
                    pyDict["copy_Gram"] = Helpers.ToPython(copy_Gram);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (return_path != true)
                    pyDict["return_path"] = Helpers.ToPython(return_path);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                if (positive != false)
                    pyDict["positive"] = Helpers.ToPython(positive);
                PyTuple result = new PyTuple(sklearn.linear_model.self.InvokeMethod("lars_path", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpInt(result[3]) : null);
            }

            public static (NDarray? , NDarray? , NDarray? , int? ) lars_path_gram(NDarray Xy, NDarray Gram, int n_samples, int max_iter = 500, int alpha_min = 0, string method = "lar", bool copy_X = true, float eps = float.Epsilon, bool copy_Gram = true, int verbose = 0, bool return_path = true, bool return_n_iter = false, bool positive = false)
            {
                _ = sklearn.linear_model.self;
                PyTuple args = new PyTuple([Helpers.ToPython(Xy), Helpers.ToPython(Gram), Helpers.ToPython(n_samples)]);
                PyDict pyDict = new PyDict();
                if (max_iter != 500)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (alpha_min != 0)
                    pyDict["alpha_min"] = Helpers.ToPython(alpha_min);
                if (method != "lar")
                    pyDict["method"] = Helpers.ToPython(method);
                if (copy_X != true)
                    pyDict["copy_X"] = Helpers.ToPython(copy_X);
                if (eps != float.Epsilon)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (copy_Gram != true)
                    pyDict["copy_Gram"] = Helpers.ToPython(copy_Gram);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (return_path != true)
                    pyDict["return_path"] = Helpers.ToPython(return_path);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                if (positive != false)
                    pyDict["positive"] = Helpers.ToPython(positive);
                PyTuple result = new PyTuple(sklearn.linear_model.self.InvokeMethod("lars_path_gram", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpInt(result[3]) : null);
            }

            public static (NDarray? , NDarray? , NDarray? , PyTuple? ) lasso_path(NDarray X, NDarray y, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, Dictionary<string, PyObject>? @params = null)
            {
                _ = sklearn.linear_model.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                PyDict pyDict = new PyDict();
                if (eps != 0.001f)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (n_alphas != 100)
                    pyDict["n_alphas"] = Helpers.ToPython(n_alphas);
                if (alphas != null)
                    pyDict["alphas"] = Helpers.ToPython(alphas);
                if (precompute != "auto")
                    pyDict["precompute"] = Helpers.ToPython(precompute);
                if (Xy != null)
                    pyDict["Xy"] = Helpers.ToPython(Xy);
                if (copy_X != true)
                    pyDict["copy_X"] = Helpers.ToPython(copy_X);
                if (coef_init != null)
                    pyDict["coef_init"] = Helpers.ToPython(coef_init);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                if (positive != false)
                    pyDict["positive"] = Helpers.ToPython(positive);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                PyTuple result = new PyTuple(sklearn.linear_model.self.InvokeMethod("lasso_path", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpPyTuple(result[3]) : null);
            }

            public static (NDarray? , NDarray? ) orthogonal_mp(NDarray X, NDarray y, int? n_nonzero_coefs = null, float? tol = null, bool precompute = false, bool copy_X = true, bool return_path = false, bool return_n_iter = false)
            {
                _ = sklearn.linear_model.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                PyDict pyDict = new PyDict();
                if (n_nonzero_coefs != null)
                    pyDict["n_nonzero_coefs"] = Helpers.ToPython(n_nonzero_coefs);
                if (tol != null)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (precompute != false)
                    pyDict["precompute"] = Helpers.ToPython(precompute);
                if (copy_X != true)
                    pyDict["copy_X"] = Helpers.ToPython(copy_X);
                if (return_path != false)
                    pyDict["return_path"] = Helpers.ToPython(return_path);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                PyTuple result = new PyTuple(sklearn.linear_model.self.InvokeMethod("orthogonal_mp", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null);
            }

            public static (NDarray? , int? ) orthogonal_mp_gram(NDarray Gram, NDarray Xy, int? n_nonzero_coefs = null, float? tol = null, NDarray? norms_squared = null, bool copy_Gram = true, bool copy_Xy = true, bool return_path = false, bool return_n_iter = false)
            {
                _ = sklearn.linear_model.self;
                PyTuple args = new PyTuple([Helpers.ToPython(Gram), Helpers.ToPython(Xy)]);
                PyDict pyDict = new PyDict();
                if (n_nonzero_coefs != null)
                    pyDict["n_nonzero_coefs"] = Helpers.ToPython(n_nonzero_coefs);
                if (tol != null)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (norms_squared != null)
                    pyDict["norms_squared"] = Helpers.ToPython(norms_squared);
                if (copy_Gram != true)
                    pyDict["copy_Gram"] = Helpers.ToPython(copy_Gram);
                if (copy_Xy != true)
                    pyDict["copy_Xy"] = Helpers.ToPython(copy_Xy);
                if (return_path != false)
                    pyDict["return_path"] = Helpers.ToPython(return_path);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                PyTuple result = new PyTuple(sklearn.linear_model.self.InvokeMethod("orthogonal_mp_gram", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpInt(result[1]) : null);
            }

            public static (NDarray? , int? , NDarray? ) ridge_regression(NDarray X, NDarray y, NDarray alpha, NDarray? sample_weight = null, string solver = "auto", int? max_iter = null, float tol = 0.0001f, int verbose = 0, bool positive = false, int? random_state = null, bool return_n_iter = false, bool return_intercept = false, bool check_input = true)
            {
                _ = sklearn.linear_model.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y), Helpers.ToPython(alpha)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (solver != "auto")
                    pyDict["solver"] = Helpers.ToPython(solver);
                if (max_iter != null)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (positive != false)
                    pyDict["positive"] = Helpers.ToPython(positive);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                if (return_intercept != false)
                    pyDict["return_intercept"] = Helpers.ToPython(return_intercept);
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                PyTuple result = new PyTuple(sklearn.linear_model.self.InvokeMethod("ridge_regression", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpInt(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null);
            }
        }
    }
}