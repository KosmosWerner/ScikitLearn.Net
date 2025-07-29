namespace ScikitLearn;
#nullable enable
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

        static mixture() => ReInitializeLazySelf();
        public class BayesianGaussianMixture : PythonObject
        {
            public BayesianGaussianMixture(int n_components = 1, string covariance_type = "full", float tol = 0.001f, float reg_covar = 1e-06f, int max_iter = 100, int n_init = 1, string init_params = "kmeans", string weight_concentration_prior_type = "dirichlet_process", float? weight_concentration_prior = null, float? mean_precision_prior = null, NDarray? mean_prior = null, float? degrees_of_freedom_prior = null, NDarray? covariance_prior = null, int? random_state = null, bool warm_start = false, int verbose = 0, int verbose_interval = 10)
            {
                _ = sklearn.mixture.self;
                PyTuple args = new PyTuple(new PyObject[] { });
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

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static BayesianGaussianMixture Encapsule(PyObject pyObject) => new BayesianGaussianMixture(pyObject);
            public static BayesianGaussianMixture Wrap(PyObject pyObject) => new BayesianGaussianMixture(pyObject);
            public NDarray weights_
            {
                get
                {
                    var __pyObject = self.GetAttr("weights_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray means_
            {
                get
                {
                    var __pyObject = self.GetAttr("means_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray covariances_
            {
                get
                {
                    var __pyObject = self.GetAttr("covariances_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray precisions_
            {
                get
                {
                    var __pyObject = self.GetAttr("precisions_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray precisions_cholesky_
            {
                get
                {
                    var __pyObject = self.GetAttr("precisions_cholesky_");
                    return new NDarray(__pyObject);
                }
            }

            public bool converged_
            {
                get
                {
                    var __pyObject = self.GetAttr("converged_");
                    return __pyObject.As<bool>();
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

            public float lower_bound_
            {
                get
                {
                    var __pyObject = self.GetAttr("lower_bound_");
                    return __pyObject.As<float>();
                }
            }

            public float weight_concentration_prior_
            {
                get
                {
                    var __pyObject = self.GetAttr("weight_concentration_prior_");
                    return __pyObject.As<float>();
                }
            }

            public NDarray weight_concentration_
            {
                get
                {
                    var __pyObject = self.GetAttr("weight_concentration_");
                    return new NDarray(__pyObject);
                }
            }

            public float mean_precision_prior_
            {
                get
                {
                    var __pyObject = self.GetAttr("mean_precision_prior_");
                    return __pyObject.As<float>();
                }
            }

            public NDarray mean_precision_
            {
                get
                {
                    var __pyObject = self.GetAttr("mean_precision_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray mean_prior_
            {
                get
                {
                    var __pyObject = self.GetAttr("mean_prior_");
                    return new NDarray(__pyObject);
                }
            }

            public float degrees_of_freedom_prior_
            {
                get
                {
                    var __pyObject = self.GetAttr("degrees_of_freedom_prior_");
                    return __pyObject.As<float>();
                }
            }

            public NDarray degrees_of_freedom_
            {
                get
                {
                    var __pyObject = self.GetAttr("degrees_of_freedom_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray covariance_prior_
            {
                get
                {
                    var __pyObject = self.GetAttr("covariance_prior_");
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

            public BayesianGaussianMixture fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("fit_predict", args, pyDict);
                return new NDarray(__pyObject);
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

            public (NDarray? , NDarray? ) sample(int n_samples = 1)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_samples != 1)
                    pyDict["n_samples"] = Helpers.ToPython(n_samples);
                var __pyObject = self.InvokeMethod("sample", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public float score(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public NDarray score_samples(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score_samples", args, pyDict);
                return new NDarray(__pyObject);
            }

            public BayesianGaussianMixture set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
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
                PyTuple args = new PyTuple(new PyObject[] { });
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

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static GaussianMixture Encapsule(PyObject pyObject) => new GaussianMixture(pyObject);
            public static GaussianMixture Wrap(PyObject pyObject) => new GaussianMixture(pyObject);
            public NDarray weights_
            {
                get
                {
                    var __pyObject = self.GetAttr("weights_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray means_
            {
                get
                {
                    var __pyObject = self.GetAttr("means_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray covariances_
            {
                get
                {
                    var __pyObject = self.GetAttr("covariances_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray precisions_
            {
                get
                {
                    var __pyObject = self.GetAttr("precisions_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray precisions_cholesky_
            {
                get
                {
                    var __pyObject = self.GetAttr("precisions_cholesky_");
                    return new NDarray(__pyObject);
                }
            }

            public bool converged_
            {
                get
                {
                    var __pyObject = self.GetAttr("converged_");
                    return __pyObject.As<bool>();
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

            public float lower_bound_
            {
                get
                {
                    var __pyObject = self.GetAttr("lower_bound_");
                    return __pyObject.As<float>();
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

            public float aic(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("aic", args, pyDict);
                return __pyObject.As<float>();
            }

            public float bic(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("bic", args, pyDict);
                return __pyObject.As<float>();
            }

            public GaussianMixture fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("fit_predict", args, pyDict);
                return new NDarray(__pyObject);
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

            public (NDarray? , NDarray? ) sample(int n_samples = 1)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_samples != 1)
                    pyDict["n_samples"] = Helpers.ToPython(n_samples);
                var __pyObject = self.InvokeMethod("sample", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public float score(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public NDarray score_samples(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score_samples", args, pyDict);
                return new NDarray(__pyObject);
            }

            public GaussianMixture set_params(Dictionary<string, PyObject>? @params = null)
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