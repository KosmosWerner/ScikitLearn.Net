using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class mixture
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
                return Py.Import("sklearn.mixture");
            }

            static mixture()
            {
                ReInitializeLazySelf();
            }

            public class BayesianGaussianMixture : PythonObject
            {
                public BayesianGaussianMixture(int n_components = 1, string covariance_type = "full", float tol = 0.001f, float reg_covar = 1e-06f, int max_iter = 100, int n_init = 1, string init_params = "kmeans", string weight_concentration_prior_type = "dirichlet_process", float? weight_concentration_prior = null, float? mean_precision_prior = null, NDarray? mean_prior = null, float? degrees_of_freedom_prior = null, NDarray? covariance_prior = null, int? random_state = null, bool warm_start = false, int verbose = 0, int verbose_interval = 10)
                {
                    _ = sklearn.mixture.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 1)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (covariance_type != "full")
                        pyDict["covariance_type"] = Helpers.ToPython(covariance_type);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (reg_covar != 1e-06f)
                        pyDict["reg_covar"] = Helpers.ToPython(reg_covar);
                    if (max_iter != 100)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (n_init != 1)
                        pyDict["n_init"] = Helpers.ToPython(n_init);
                    if (init_params != "kmeans")
                        pyDict["init_params"] = Helpers.ToPython(init_params);
                    if (weight_concentration_prior_type != "dirichlet_process")
                        pyDict["weight_concentration_prior_type"] = Helpers.ToPython(weight_concentration_prior_type);
                    if (weight_concentration_prior != null)
                        pyDict["weight_concentration_prior"] = Helpers.ToPython(weight_concentration_prior);
                    if (mean_precision_prior != null)
                        pyDict["mean_precision_prior"] = Helpers.ToPython(mean_precision_prior);
                    if (mean_prior != null)
                        pyDict["mean_prior"] = Helpers.ToPython(mean_prior);
                    if (degrees_of_freedom_prior != null)
                        pyDict["degrees_of_freedom_prior"] = Helpers.ToPython(degrees_of_freedom_prior);
                    if (covariance_prior != null)
                        pyDict["covariance_prior"] = Helpers.ToPython(covariance_prior);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (verbose_interval != 10)
                        pyDict["verbose_interval"] = Helpers.ToPython(verbose_interval);
                    self = sklearn.mixture.self.InvokeMethod("BayesianGaussianMixture", args, pyDict);
                }

                internal BayesianGaussianMixture(PyObject pyObject)
                {
                    _ = sklearn.mixture.self;
                    self = pyObject;
                }

                public static BayesianGaussianMixture Encapsule(PyObject pyObject)
                {
                    return new BayesianGaussianMixture(pyObject);
                }

                public NDarray weights_ => Helpers.ToCSharpNDarray(self.GetAttr("weights_"));
                public NDarray means_ => Helpers.ToCSharpNDarray(self.GetAttr("means_"));
                public NDarray covariances_ => Helpers.ToCSharpNDarray(self.GetAttr("covariances_"));
                public NDarray precisions_ => Helpers.ToCSharpNDarray(self.GetAttr("precisions_"));
                public NDarray precisions_cholesky_ => Helpers.ToCSharpNDarray(self.GetAttr("precisions_cholesky_"));
                public bool converged_ => Helpers.ToCSharpBool(self.GetAttr("converged_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public float lower_bound_ => Helpers.ToCSharpFloat(self.GetAttr("lower_bound_"));
                public float weight_concentration_prior_ => Helpers.ToCSharpFloat(self.GetAttr("weight_concentration_prior_"));
                public NDarray weight_concentration_ => Helpers.ToCSharpNDarray(self.GetAttr("weight_concentration_"));
                public float mean_precision_prior_ => Helpers.ToCSharpFloat(self.GetAttr("mean_precision_prior_"));
                public NDarray mean_precision_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_precision_"));
                public NDarray mean_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_prior_"));
                public float degrees_of_freedom_prior_ => Helpers.ToCSharpFloat(self.GetAttr("degrees_of_freedom_prior_"));
                public NDarray degrees_of_freedom_ => Helpers.ToCSharpNDarray(self.GetAttr("degrees_of_freedom_"));
                public NDarray covariance_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_prior_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public BayesianGaussianMixture fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public (NDarray? , NDarray? ) sample(int n_samples = 1)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_samples != 1)
                        pyDict["n_samples"] = Helpers.ToPython(n_samples);
                    PyTuple result = new PyTuple(self.InvokeMethod("sample", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null);
                }

                public float score(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("score_samples", args, pyDict));
                }

                public BayesianGaussianMixture set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class GaussianMixture : PythonObject
            {
                public GaussianMixture(int n_components = 1, string covariance_type = "full", float tol = 0.001f, float reg_covar = 1e-06f, int max_iter = 100, int n_init = 1, string init_params = "kmeans", NDarray? weights_init = null, NDarray? means_init = null, NDarray? precisions_init = null, int? random_state = null, bool warm_start = false, int verbose = 0, int verbose_interval = 10)
                {
                    _ = sklearn.mixture.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 1)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (covariance_type != "full")
                        pyDict["covariance_type"] = Helpers.ToPython(covariance_type);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (reg_covar != 1e-06f)
                        pyDict["reg_covar"] = Helpers.ToPython(reg_covar);
                    if (max_iter != 100)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (n_init != 1)
                        pyDict["n_init"] = Helpers.ToPython(n_init);
                    if (init_params != "kmeans")
                        pyDict["init_params"] = Helpers.ToPython(init_params);
                    if (weights_init != null)
                        pyDict["weights_init"] = Helpers.ToPython(weights_init);
                    if (means_init != null)
                        pyDict["means_init"] = Helpers.ToPython(means_init);
                    if (precisions_init != null)
                        pyDict["precisions_init"] = Helpers.ToPython(precisions_init);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (verbose_interval != 10)
                        pyDict["verbose_interval"] = Helpers.ToPython(verbose_interval);
                    self = sklearn.mixture.self.InvokeMethod("GaussianMixture", args, pyDict);
                }

                internal GaussianMixture(PyObject pyObject)
                {
                    _ = sklearn.mixture.self;
                    self = pyObject;
                }

                public static GaussianMixture Encapsule(PyObject pyObject)
                {
                    return new GaussianMixture(pyObject);
                }

                public NDarray weights_ => Helpers.ToCSharpNDarray(self.GetAttr("weights_"));
                public NDarray means_ => Helpers.ToCSharpNDarray(self.GetAttr("means_"));
                public NDarray covariances_ => Helpers.ToCSharpNDarray(self.GetAttr("covariances_"));
                public NDarray precisions_ => Helpers.ToCSharpNDarray(self.GetAttr("precisions_"));
                public NDarray precisions_cholesky_ => Helpers.ToCSharpNDarray(self.GetAttr("precisions_cholesky_"));
                public bool converged_ => Helpers.ToCSharpBool(self.GetAttr("converged_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public float lower_bound_ => Helpers.ToCSharpFloat(self.GetAttr("lower_bound_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float aic(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("aic", args, pyDict));
                }

                public float bic(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("bic", args, pyDict));
                }

                public GaussianMixture fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public (NDarray? , NDarray? ) sample(int n_samples = 1)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_samples != 1)
                        pyDict["n_samples"] = Helpers.ToPython(n_samples);
                    PyTuple result = new PyTuple(self.InvokeMethod("sample", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null);
                }

                public float score(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("score_samples", args, pyDict));
                }

                public GaussianMixture set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }
        }
    }
}