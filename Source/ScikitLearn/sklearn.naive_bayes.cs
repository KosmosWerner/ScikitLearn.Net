using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class naive_bayes
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
                return Py.Import("sklearn.naive_bayes");
            }

            static naive_bayes()
            {
                ReInitializeLazySelf();
            }

            public class BernoulliNB : PythonObject
            {
                public BernoulliNB(float alpha = 1.0f, bool force_alpha = true, float? binarize = 0.0f, bool fit_prior = true, NDarray? class_prior = null)
                {
                    _ = sklearn.naive_bayes.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (force_alpha != true)
                        pyDict["force_alpha"] = Helpers.ToPython(force_alpha);
                    if (binarize != 0.0f)
                        pyDict["binarize"] = Helpers.ToPython(binarize);
                    if (fit_prior != true)
                        pyDict["fit_prior"] = Helpers.ToPython(fit_prior);
                    if (class_prior != null)
                        pyDict["class_prior"] = Helpers.ToPython(class_prior);
                    self = sklearn.naive_bayes.self.InvokeMethod("BernoulliNB", args, pyDict);
                }

                internal BernoulliNB(PyObject pyObject)
                {
                    _ = sklearn.naive_bayes.self;
                    self = pyObject;
                }

                public static BernoulliNB Encapsule(PyObject pyObject)
                {
                    return new BernoulliNB(pyObject);
                }

                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_log_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_log_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_count_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_count_"));
                public NDarray feature_log_prob_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_log_prob_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public BernoulliNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public BernoulliNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
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

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_joint_log_proba", args, pyDict));
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

                public BernoulliNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public BernoulliNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public BernoulliNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
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

                public BernoulliNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class CategoricalNB : PythonObject
            {
                public CategoricalNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null, NDarray? min_categories = null)
                {
                    _ = sklearn.naive_bayes.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (force_alpha != true)
                        pyDict["force_alpha"] = Helpers.ToPython(force_alpha);
                    if (fit_prior != true)
                        pyDict["fit_prior"] = Helpers.ToPython(fit_prior);
                    if (class_prior != null)
                        pyDict["class_prior"] = Helpers.ToPython(class_prior);
                    if (min_categories != null)
                        pyDict["min_categories"] = Helpers.ToPython(min_categories);
                    self = sklearn.naive_bayes.self.InvokeMethod("CategoricalNB", args, pyDict);
                }

                internal CategoricalNB(PyObject pyObject)
                {
                    _ = sklearn.naive_bayes.self;
                    self = pyObject;
                }

                public static CategoricalNB Encapsule(PyObject pyObject)
                {
                    return new CategoricalNB(pyObject);
                }

                public NDarray category_count_ => Helpers.ToCSharpNDarray(self.GetAttr("category_count_"));
                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_log_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_log_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_log_prob_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_log_prob_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray<long> n_categories_ => Helpers.ToCSharpNDarray<long>(self.GetAttr("n_categories_"));

                public CategoricalNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public CategoricalNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
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

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_joint_log_proba", args, pyDict));
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

                public CategoricalNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public CategoricalNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public CategoricalNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
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

                public CategoricalNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class ComplementNB : PythonObject
            {
                public ComplementNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null, bool norm = false)
                {
                    _ = sklearn.naive_bayes.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (force_alpha != true)
                        pyDict["force_alpha"] = Helpers.ToPython(force_alpha);
                    if (fit_prior != true)
                        pyDict["fit_prior"] = Helpers.ToPython(fit_prior);
                    if (class_prior != null)
                        pyDict["class_prior"] = Helpers.ToPython(class_prior);
                    if (norm != false)
                        pyDict["norm"] = Helpers.ToPython(norm);
                    self = sklearn.naive_bayes.self.InvokeMethod("ComplementNB", args, pyDict);
                }

                internal ComplementNB(PyObject pyObject)
                {
                    _ = sklearn.naive_bayes.self;
                    self = pyObject;
                }

                public static ComplementNB Encapsule(PyObject pyObject)
                {
                    return new ComplementNB(pyObject);
                }

                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_log_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_log_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_all_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_all_"));
                public NDarray feature_count_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_count_"));
                public NDarray feature_log_prob_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_log_prob_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public ComplementNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public ComplementNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
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

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_joint_log_proba", args, pyDict));
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

                public ComplementNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public ComplementNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public ComplementNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
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

                public ComplementNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class GaussianNB : PythonObject
            {
                public GaussianNB(NDarray? priors = null, float var_smoothing = 1e-09f)
                {
                    _ = sklearn.naive_bayes.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (priors != null)
                        pyDict["priors"] = Helpers.ToPython(priors);
                    if (var_smoothing != 1e-09f)
                        pyDict["var_smoothing"] = Helpers.ToPython(var_smoothing);
                    self = sklearn.naive_bayes.self.InvokeMethod("GaussianNB", args, pyDict);
                }

                internal GaussianNB(PyObject pyObject)
                {
                    _ = sklearn.naive_bayes.self;
                    self = pyObject;
                }

                public static GaussianNB Encapsule(PyObject pyObject)
                {
                    return new GaussianNB(pyObject);
                }

                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public float epsilon_ => Helpers.ToCSharpFloat(self.GetAttr("epsilon_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray var_ => Helpers.ToCSharpNDarray(self.GetAttr("var_"));
                public NDarray theta_ => Helpers.ToCSharpNDarray(self.GetAttr("theta_"));

                public GaussianNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public GaussianNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
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

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_joint_log_proba", args, pyDict));
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

                public GaussianNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public GaussianNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public GaussianNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
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

                public GaussianNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class MultinomialNB : PythonObject
            {
                public MultinomialNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null)
                {
                    _ = sklearn.naive_bayes.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (force_alpha != true)
                        pyDict["force_alpha"] = Helpers.ToPython(force_alpha);
                    if (fit_prior != true)
                        pyDict["fit_prior"] = Helpers.ToPython(fit_prior);
                    if (class_prior != null)
                        pyDict["class_prior"] = Helpers.ToPython(class_prior);
                    self = sklearn.naive_bayes.self.InvokeMethod("MultinomialNB", args, pyDict);
                }

                internal MultinomialNB(PyObject pyObject)
                {
                    _ = sklearn.naive_bayes.self;
                    self = pyObject;
                }

                public static MultinomialNB Encapsule(PyObject pyObject)
                {
                    return new MultinomialNB(pyObject);
                }

                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_log_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_log_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_count_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_count_"));
                public NDarray feature_log_prob_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_log_prob_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MultinomialNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public MultinomialNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
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

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_joint_log_proba", args, pyDict));
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

                public MultinomialNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public MultinomialNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public MultinomialNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
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

                public MultinomialNB set_score_request(string? sample_weight = "$UNCHANGED$")
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