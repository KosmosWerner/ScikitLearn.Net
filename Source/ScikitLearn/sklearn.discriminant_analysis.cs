using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class discriminant_analysis
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
                return Py.Import("sklearn.discriminant_analysis");
            }

            static discriminant_analysis()
            {
                ReInitializeLazySelf();
            }

            public class LinearDiscriminantAnalysis : PythonObject
            {
                public LinearDiscriminantAnalysis(string solver = "svd", float? shrinkage = null, NDarray? priors = null, int? n_components = null, bool store_covariance = false, float tol = 0.0001f, PyObject? covariance_estimator = null)
                {
                    _ = sklearn.discriminant_analysis.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (solver != "svd")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (shrinkage != null)
                        pyDict["shrinkage"] = Helpers.ToPython(shrinkage);
                    if (priors != null)
                        pyDict["priors"] = Helpers.ToPython(priors);
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (store_covariance != false)
                        pyDict["store_covariance"] = Helpers.ToPython(store_covariance);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (covariance_estimator != null)
                        pyDict["covariance_estimator"] = Helpers.ToPython(covariance_estimator);
                    self = sklearn.discriminant_analysis.self.InvokeMethod("LinearDiscriminantAnalysis", args, pyDict);
                }

                internal LinearDiscriminantAnalysis(PyObject pyObject)
                {
                    _ = sklearn.discriminant_analysis.self;
                    self = pyObject;
                }

                public static LinearDiscriminantAnalysis Encapsule(PyObject pyObject)
                {
                    return new LinearDiscriminantAnalysis(pyObject);
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray explained_variance_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_ratio_"));
                public NDarray means_ => Helpers.ToCSharpNDarray(self.GetAttr("means_"));
                public NDarray priors_ => Helpers.ToCSharpNDarray(self.GetAttr("priors_"));
                public NDarray scalings_ => Helpers.ToCSharpNDarray(self.GetAttr("scalings_"));
                public NDarray xbar_ => Helpers.ToCSharpNDarray(self.GetAttr("xbar_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public LinearDiscriminantAnalysis fit(NDarray X, NDarray y)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
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

                public LinearDiscriminantAnalysis set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public LinearDiscriminantAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LinearDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class QuadraticDiscriminantAnalysis : PythonObject
            {
                public QuadraticDiscriminantAnalysis(NDarray? priors = null, float reg_param = 0.0f, bool store_covariance = false, float tol = 0.0001f)
                {
                    _ = sklearn.discriminant_analysis.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (priors != null)
                        pyDict["priors"] = Helpers.ToPython(priors);
                    if (reg_param != 0.0f)
                        pyDict["reg_param"] = Helpers.ToPython(reg_param);
                    if (store_covariance != false)
                        pyDict["store_covariance"] = Helpers.ToPython(store_covariance);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    self = sklearn.discriminant_analysis.self.InvokeMethod("QuadraticDiscriminantAnalysis", args, pyDict);
                }

                internal QuadraticDiscriminantAnalysis(PyObject pyObject)
                {
                    _ = sklearn.discriminant_analysis.self;
                    self = pyObject;
                }

                public static QuadraticDiscriminantAnalysis Encapsule(PyObject pyObject)
                {
                    return new QuadraticDiscriminantAnalysis(pyObject);
                }

                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray means_ => Helpers.ToCSharpNDarray(self.GetAttr("means_"));
                public NDarray priors_ => Helpers.ToCSharpNDarray(self.GetAttr("priors_"));
                public NDarray rotations_ => Helpers.ToCSharpNDarray(self.GetAttr("rotations_"));
                public NDarray scalings_ => Helpers.ToCSharpNDarray(self.GetAttr("scalings_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public QuadraticDiscriminantAnalysis fit(NDarray X, NDarray y)
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

                public QuadraticDiscriminantAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public QuadraticDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$")
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