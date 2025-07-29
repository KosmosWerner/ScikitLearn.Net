namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class gaussian_process
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
            return Py.Import("sklearn.gaussian_process");
        }

        static gaussian_process() => ReInitializeLazySelf();
        public class GaussianProcessClassifier : PythonObject
        {
            public GaussianProcessClassifier(PyObject? kernel = null, string? optimizer = "fmin_l_bfgs_b", int n_restarts_optimizer = 0, int max_iter_predict = 100, bool warm_start = false, bool copy_X_train = true, int? random_state = null, string multi_class = "one_vs_rest", int? n_jobs = null)
            {
                _ = sklearn.gaussian_process.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (kernel != null)
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (optimizer != "fmin_l_bfgs_b")
                    pyDict["optimizer"] = Helpers.ToPython(optimizer);
                if (n_restarts_optimizer != 0)
                    pyDict["n_restarts_optimizer"] = Helpers.ToPython(n_restarts_optimizer);
                if (max_iter_predict != 100)
                    pyDict["max_iter_predict"] = Helpers.ToPython(max_iter_predict);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (copy_X_train != true)
                    pyDict["copy_X_train"] = Helpers.ToPython(copy_X_train);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (multi_class != "one_vs_rest")
                    pyDict["multi_class"] = Helpers.ToPython(multi_class);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.gaussian_process.self.InvokeMethod("GaussianProcessClassifier", args, pyDict);
            }

            internal GaussianProcessClassifier(PyObject pyObject)
            {
                _ = sklearn.gaussian_process.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static GaussianProcessClassifier Encapsule(PyObject pyObject) => new GaussianProcessClassifier(pyObject);
            public static GaussianProcessClassifier Wrap(PyObject pyObject) => new GaussianProcessClassifier(pyObject);
            public PyObject base_estimator_
            {
                get
                {
                    var __pyObject = self.GetAttr("base_estimator_");
                    return __pyObject;
                }
            }

            public PyObject kernel_
            {
                get
                {
                    var __pyObject = self.GetAttr("kernel_");
                    return __pyObject;
                }
            }

            public float log_marginal_likelihood_value_
            {
                get
                {
                    var __pyObject = self.GetAttr("log_marginal_likelihood_value_");
                    return __pyObject.As<float>();
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

            public GaussianProcessClassifier fit(PyObject X, NDarray y)
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

            public (float? , NDarray? ) log_marginal_likelihood(NDarray? theta = null, bool eval_gradient = false, bool clone_kernel = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (theta != null)
                    pyDict["theta"] = Helpers.ToPython(theta);
                if (eval_gradient != false)
                    pyDict["eval_gradient"] = Helpers.ToPython(eval_gradient);
                if (clone_kernel != true)
                    pyDict["clone_kernel"] = Helpers.ToPython(clone_kernel);
                var __pyObject = self.InvokeMethod("log_marginal_likelihood", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? __pyObjectTuple[0].As<float>() : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray predict(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(PyObject X)
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

            public GaussianProcessClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public GaussianProcessClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class GaussianProcessRegressor : PythonObject
        {
            public GaussianProcessRegressor(PyObject? kernel = null, float alpha = 1e-10f, string? optimizer = "fmin_l_bfgs_b", int n_restarts_optimizer = 0, bool normalize_y = false, bool copy_X_train = true, int? n_targets = null, int? random_state = null)
            {
                _ = sklearn.gaussian_process.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (kernel != null)
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (alpha != 1e-10f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (optimizer != "fmin_l_bfgs_b")
                    pyDict["optimizer"] = Helpers.ToPython(optimizer);
                if (n_restarts_optimizer != 0)
                    pyDict["n_restarts_optimizer"] = Helpers.ToPython(n_restarts_optimizer);
                if (normalize_y != false)
                    pyDict["normalize_y"] = Helpers.ToPython(normalize_y);
                if (copy_X_train != true)
                    pyDict["copy_X_train"] = Helpers.ToPython(copy_X_train);
                if (n_targets != null)
                    pyDict["n_targets"] = Helpers.ToPython(n_targets);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.gaussian_process.self.InvokeMethod("GaussianProcessRegressor", args, pyDict);
            }

            internal GaussianProcessRegressor(PyObject pyObject)
            {
                _ = sklearn.gaussian_process.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static GaussianProcessRegressor Encapsule(PyObject pyObject) => new GaussianProcessRegressor(pyObject);
            public static GaussianProcessRegressor Wrap(PyObject pyObject) => new GaussianProcessRegressor(pyObject);
            public PyObject X_train_
            {
                get
                {
                    var __pyObject = self.GetAttr("X_train_");
                    return __pyObject;
                }
            }

            public NDarray y_train_
            {
                get
                {
                    var __pyObject = self.GetAttr("y_train_");
                    return new NDarray(__pyObject);
                }
            }

            public PyObject kernel_
            {
                get
                {
                    var __pyObject = self.GetAttr("kernel_");
                    return __pyObject;
                }
            }

            public NDarray L_
            {
                get
                {
                    var __pyObject = self.GetAttr("L_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray alpha_
            {
                get
                {
                    var __pyObject = self.GetAttr("alpha_");
                    return new NDarray(__pyObject);
                }
            }

            public float log_marginal_likelihood_value_
            {
                get
                {
                    var __pyObject = self.GetAttr("log_marginal_likelihood_value_");
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

            public GaussianProcessRegressor fit(PyObject X, NDarray y)
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

            public (float? , NDarray? ) log_marginal_likelihood(NDarray? theta = null, bool eval_gradient = false, bool clone_kernel = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (theta != null)
                    pyDict["theta"] = Helpers.ToPython(theta);
                if (eval_gradient != false)
                    pyDict["eval_gradient"] = Helpers.ToPython(eval_gradient);
                if (clone_kernel != true)
                    pyDict["clone_kernel"] = Helpers.ToPython(clone_kernel);
                var __pyObject = self.InvokeMethod("log_marginal_likelihood", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? __pyObjectTuple[0].As<float>() : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public (NDarray? , NDarray? , NDarray? ) predict(PyObject X, bool return_std = false, bool return_cov = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (return_std != false)
                    pyDict["return_std"] = Helpers.ToPython(return_std);
                if (return_cov != false)
                    pyDict["return_cov"] = Helpers.ToPython(return_cov);
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null, __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null);
            }

            public NDarray sample_y(PyObject X, int n_samples = 1, int? random_state = 0)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (n_samples != 1)
                    pyDict["n_samples"] = Helpers.ToPython(n_samples);
                if (random_state != 0)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                var __pyObject = self.InvokeMethod("sample_y", args, pyDict);
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

            public GaussianProcessRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public GaussianProcessRegressor set_predict_request(string? return_cov = "$UNCHANGED$", string? return_std = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (return_cov != "$UNCHANGED$")
                    pyDict["return_cov"] = Helpers.ToPython(return_cov);
                if (return_std != "$UNCHANGED$")
                    pyDict["return_std"] = Helpers.ToPython(return_std);
                self.InvokeMethod("set_predict_request", args, pyDict);
                return this;
            }

            public GaussianProcessRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public static class kernels
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
                return Py.Import("sklearn.gaussian_process.kernels");
            }

            static kernels() => ReInitializeLazySelf();
            public class CompoundKernel : PythonObject
            {
                public CompoundKernel(PyTuple kernels)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(kernels) });
                    PyDict pyDict = new PyDict();
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("CompoundKernel", args, pyDict);
                }

                internal CompoundKernel(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static CompoundKernel Encapsule(PyObject pyObject) => new CompoundKernel(pyObject);
                public static CompoundKernel Wrap(PyObject pyObject) => new CompoundKernel(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(PyObject X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public CompoundKernel set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class ConstantKernel : PythonObject
            {
                public ConstantKernel(float constant_value = 1.0f, PyTuple? constant_value_bounds = null)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (constant_value != 1.0f)
                        pyDict["constant_value"] = Helpers.ToPython(constant_value);
                    if (constant_value_bounds != null)
                        pyDict["constant_value_bounds"] = Helpers.ToPython(constant_value_bounds);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("ConstantKernel", args, pyDict);
                }

                internal ConstantKernel(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static ConstantKernel Encapsule(PyObject pyObject) => new ConstantKernel(pyObject);
                public static ConstantKernel Wrap(PyObject pyObject) => new ConstantKernel(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(PyObject X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public ConstantKernel set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class DotProduct : PythonObject
            {
                public DotProduct(float sigma_0 = 1.0f, PyTuple? sigma_0_bounds = null)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (sigma_0 != 1.0f)
                        pyDict["sigma_0"] = Helpers.ToPython(sigma_0);
                    if (sigma_0_bounds != null)
                        pyDict["sigma_0_bounds"] = Helpers.ToPython(sigma_0_bounds);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("DotProduct", args, pyDict);
                }

                internal DotProduct(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static DotProduct Encapsule(PyObject pyObject) => new DotProduct(pyObject);
                public static DotProduct Wrap(PyObject pyObject) => new DotProduct(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public DotProduct set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class ExpSineSquared : PythonObject
            {
                public ExpSineSquared(float length_scale = 1.0f, float periodicity = 1.0f, PyTuple? length_scale_bounds = null, PyTuple? periodicity_bounds = null)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (length_scale != 1.0f)
                        pyDict["length_scale"] = Helpers.ToPython(length_scale);
                    if (periodicity != 1.0f)
                        pyDict["periodicity"] = Helpers.ToPython(periodicity);
                    if (length_scale_bounds != null)
                        pyDict["length_scale_bounds"] = Helpers.ToPython(length_scale_bounds);
                    if (periodicity_bounds != null)
                        pyDict["periodicity_bounds"] = Helpers.ToPython(periodicity_bounds);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("ExpSineSquared", args, pyDict);
                }

                internal ExpSineSquared(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static ExpSineSquared Encapsule(PyObject pyObject) => new ExpSineSquared(pyObject);
                public static ExpSineSquared Wrap(PyObject pyObject) => new ExpSineSquared(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public ExpSineSquared set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class Exponentiation : PythonObject
            {
                public Exponentiation(PyObject kernel, float exponent)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(kernel), Helpers.ToPython(exponent) });
                    PyDict pyDict = new PyDict();
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("Exponentiation", args, pyDict);
                }

                internal Exponentiation(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static Exponentiation Encapsule(PyObject pyObject) => new Exponentiation(pyObject);
                public static Exponentiation Wrap(PyObject pyObject) => new Exponentiation(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(PyObject X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public Exponentiation set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class Hyperparameter : PythonObject
            {
                public Hyperparameter(int n_elements = 1)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (n_elements != 1)
                        pyDict["n_elements"] = Helpers.ToPython(n_elements);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("Hyperparameter", args, pyDict);
                }

                internal Hyperparameter(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static Hyperparameter Encapsule(PyObject pyObject) => new Hyperparameter(pyObject);
                public static Hyperparameter Wrap(PyObject pyObject) => new Hyperparameter(pyObject);
                public string name
                {
                    get
                    {
                        var __pyObject = self.GetAttr("name");
                        return __pyObject.As<string>();
                    }
                }

                public string value_type
                {
                    get
                    {
                        var __pyObject = self.GetAttr("value_type");
                        return __pyObject.As<string>();
                    }
                }

                public float bounds
                {
                    get
                    {
                        var __pyObject = self.GetAttr("bounds");
                        return __pyObject.As<float>();
                    }
                }

                public int n_elements
                {
                    get
                    {
                        var __pyObject = self.GetAttr("n_elements");
                        return __pyObject.As<int>();
                    }
                }

                public bool @fixed
                {
                    get
                    {
                        var __pyObject = self.GetAttr("fixed");
                        return __pyObject.As<bool>();
                    }
                }

                public void count()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("count", args, pyDict);
                }

                public void index(int start = 0)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (start != 0)
                        pyDict["start"] = Helpers.ToPython(start);
                    self.InvokeMethod("index", args, pyDict);
                }
            }

            public class Kernel : PythonObject
            {
                public Kernel()
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("Kernel", args, pyDict);
                }

                internal Kernel(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static Kernel Encapsule(PyObject pyObject) => new Kernel(pyObject);
                public static Kernel Wrap(PyObject pyObject) => new Kernel(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public Kernel set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class Matern : PythonObject
            {
                public Matern(float length_scale = 1.0f, PyTuple? length_scale_bounds = null, float nu = 1.5f)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (length_scale != 1.0f)
                        pyDict["length_scale"] = Helpers.ToPython(length_scale);
                    if (length_scale_bounds != null)
                        pyDict["length_scale_bounds"] = Helpers.ToPython(length_scale_bounds);
                    if (nu != 1.5f)
                        pyDict["nu"] = Helpers.ToPython(nu);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("Matern", args, pyDict);
                }

                internal Matern(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static Matern Encapsule(PyObject pyObject) => new Matern(pyObject);
                public static Matern Wrap(PyObject pyObject) => new Matern(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public Matern set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class PairwiseKernel : PythonObject
            {
                public PairwiseKernel(float gamma = 1.0f, PyTuple? gamma_bounds = null, string metric = "linear", PyDict? pairwise_kernels_kwargs = null)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (gamma != 1.0f)
                        pyDict["gamma"] = Helpers.ToPython(gamma);
                    if (gamma_bounds != null)
                        pyDict["gamma_bounds"] = Helpers.ToPython(gamma_bounds);
                    if (metric != "linear")
                        pyDict["metric"] = Helpers.ToPython(metric);
                    if (pairwise_kernels_kwargs != null)
                        pyDict["pairwise_kernels_kwargs"] = Helpers.ToPython(pairwise_kernels_kwargs);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("PairwiseKernel", args, pyDict);
                }

                internal PairwiseKernel(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static PairwiseKernel Encapsule(PyObject pyObject) => new PairwiseKernel(pyObject);
                public static PairwiseKernel Wrap(PyObject pyObject) => new PairwiseKernel(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public PairwiseKernel set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class Product : PythonObject
            {
                public Product(PyObject k1, PyObject k2)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(k1), Helpers.ToPython(k2) });
                    PyDict pyDict = new PyDict();
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("Product", args, pyDict);
                }

                internal Product(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static Product Encapsule(PyObject pyObject) => new Product(pyObject);
                public static Product Wrap(PyObject pyObject) => new Product(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(PyObject X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public Product set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class RBF : PythonObject
            {
                public RBF(float length_scale = 1.0f, PyTuple? length_scale_bounds = null)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (length_scale != 1.0f)
                        pyDict["length_scale"] = Helpers.ToPython(length_scale);
                    if (length_scale_bounds != null)
                        pyDict["length_scale_bounds"] = Helpers.ToPython(length_scale_bounds);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("RBF", args, pyDict);
                }

                internal RBF(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static RBF Encapsule(PyObject pyObject) => new RBF(pyObject);
                public static RBF Wrap(PyObject pyObject) => new RBF(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public RBF set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class RationalQuadratic : PythonObject
            {
                public RationalQuadratic(float length_scale = 1.0f, float alpha = 1.0f, PyTuple? length_scale_bounds = null, PyTuple? alpha_bounds = null)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (length_scale != 1.0f)
                        pyDict["length_scale"] = Helpers.ToPython(length_scale);
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (length_scale_bounds != null)
                        pyDict["length_scale_bounds"] = Helpers.ToPython(length_scale_bounds);
                    if (alpha_bounds != null)
                        pyDict["alpha_bounds"] = Helpers.ToPython(alpha_bounds);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("RationalQuadratic", args, pyDict);
                }

                internal RationalQuadratic(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static RationalQuadratic Encapsule(PyObject pyObject) => new RationalQuadratic(pyObject);
                public static RationalQuadratic Wrap(PyObject pyObject) => new RationalQuadratic(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public RationalQuadratic set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class Sum : PythonObject
            {
                public Sum(PyObject k1, PyObject k2)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(k1), Helpers.ToPython(k2) });
                    PyDict pyDict = new PyDict();
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("Sum", args, pyDict);
                }

                internal Sum(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static Sum Encapsule(PyObject pyObject) => new Sum(pyObject);
                public static Sum Wrap(PyObject pyObject) => new Sum(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(PyObject X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public Sum set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class WhiteKernel : PythonObject
            {
                public WhiteKernel(float noise_level = 1.0f, PyTuple? noise_level_bounds = null)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (noise_level != 1.0f)
                        pyDict["noise_level"] = Helpers.ToPython(noise_level);
                    if (noise_level_bounds != null)
                        pyDict["noise_level_bounds"] = Helpers.ToPython(noise_level_bounds);
                    self = sklearn.gaussian_process.kernels.self.InvokeMethod("WhiteKernel", args, pyDict);
                }

                internal WhiteKernel(PyObject pyObject)
                {
                    _ = sklearn.gaussian_process.kernels.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
                public static WhiteKernel Encapsule(PyObject pyObject) => new WhiteKernel(pyObject);
                public static WhiteKernel Wrap(PyObject pyObject) => new WhiteKernel(pyObject);
                public void clone_with_theta(NDarray theta)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(theta) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("clone_with_theta", args, pyDict);
                }

                public NDarray diag(PyObject X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    var __pyObject = self.InvokeMethod("diag", args, pyDict);
                    return new NDarray(__pyObject);
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

                public void is_stationary()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("is_stationary", args, pyDict);
                }

                public WhiteKernel set_params()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }
        }
    }
}