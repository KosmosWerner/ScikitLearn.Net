using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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

            static gaussian_process()
            {
                ReInitializeLazySelf();
            }

            public class GaussianProcessClassifier : PythonObject
            {
                public GaussianProcessClassifier(PyObject? kernel = null, string? optimizer = "fmin_l_bfgs_b", int n_restarts_optimizer = 0, int max_iter_predict = 100, bool warm_start = false, bool copy_X_train = true, int? random_state = null, string multi_class = "one_vs_rest", int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (kernel != null)
                        pyDict["kernel"] = ToPython(kernel);
                    if (optimizer != "fmin_l_bfgs_b")
                        pyDict["optimizer"] = ToPython(optimizer);
                    if (n_restarts_optimizer != 0)
                        pyDict["n_restarts_optimizer"] = ToPython(n_restarts_optimizer);
                    if (max_iter_predict != 100)
                        pyDict["max_iter_predict"] = ToPython(max_iter_predict);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (copy_X_train != true)
                        pyDict["copy_X_train"] = ToPython(copy_X_train);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (multi_class != "one_vs_rest")
                        pyDict["multi_class"] = ToPython(multi_class);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.gaussian_process.self.InvokeMethod("GaussianProcessClassifier", args, pyDict);
                }

                internal GaussianProcessClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static GaussianProcessClassifier Encapsule(PyObject pyObject)
                {
                    return new GaussianProcessClassifier(pyObject);
                }

                public PyObject base_estimator_ => self.GetAttr("base_estimator_");
                public PyObject kernel_ => self.GetAttr("kernel_");
                public float log_marginal_likelihood_value_ => ToCsharp<float>(self.GetAttr("log_marginal_likelihood_value_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_classes_ => ToCsharp<int>(self.GetAttr("n_classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public GaussianProcessClassifier fit(PyObject X, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
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
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public (float, NDarray) log_marginal_likelihood(NDarray? theta = null, bool eval_gradient = false, bool clone_kernel = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (theta != null)
                        pyDict["theta"] = ToPython(theta);
                    if (eval_gradient != false)
                        pyDict["eval_gradient"] = ToPython(eval_gradient);
                    if (clone_kernel != true)
                        pyDict["clone_kernel"] = ToPython(clone_kernel);
                    PyTuple result = new PyTuple(self.InvokeMethod("log_marginal_likelihood", args, pyDict));
                    return (ToCsharp<float>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray predict(PyObject X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_proba(PyObject X)
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

                public GaussianProcessClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public GaussianProcessClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class GaussianProcessRegressor : PythonObject
            {
                public GaussianProcessRegressor(PyObject? kernel = null, float alpha = 1e-10f, string? optimizer = "fmin_l_bfgs_b", int n_restarts_optimizer = 0, bool normalize_y = false, bool copy_X_train = true, int? n_targets = null, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (kernel != null)
                        pyDict["kernel"] = ToPython(kernel);
                    if (alpha != 1e-10f)
                        pyDict["alpha"] = ToPython(alpha);
                    if (optimizer != "fmin_l_bfgs_b")
                        pyDict["optimizer"] = ToPython(optimizer);
                    if (n_restarts_optimizer != 0)
                        pyDict["n_restarts_optimizer"] = ToPython(n_restarts_optimizer);
                    if (normalize_y != false)
                        pyDict["normalize_y"] = ToPython(normalize_y);
                    if (copy_X_train != true)
                        pyDict["copy_X_train"] = ToPython(copy_X_train);
                    if (n_targets != null)
                        pyDict["n_targets"] = ToPython(n_targets);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.gaussian_process.self.InvokeMethod("GaussianProcessRegressor", args, pyDict);
                }

                internal GaussianProcessRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static GaussianProcessRegressor Encapsule(PyObject pyObject)
                {
                    return new GaussianProcessRegressor(pyObject);
                }

                public PyObject X_train_ => self.GetAttr("X_train_");
                public NDarray y_train_ => ToCsharp<NDarray>(self.GetAttr("y_train_"));
                public PyObject kernel_ => self.GetAttr("kernel_");
                public NDarray L_ => ToCsharp<NDarray>(self.GetAttr("L_"));
                public NDarray alpha_ => ToCsharp<NDarray>(self.GetAttr("alpha_"));
                public float log_marginal_likelihood_value_ => ToCsharp<float>(self.GetAttr("log_marginal_likelihood_value_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public GaussianProcessRegressor fit(PyObject X, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
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
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public (float, NDarray) log_marginal_likelihood(NDarray? theta = null, bool eval_gradient = false, bool clone_kernel = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (theta != null)
                        pyDict["theta"] = ToPython(theta);
                    if (eval_gradient != false)
                        pyDict["eval_gradient"] = ToPython(eval_gradient);
                    if (clone_kernel != true)
                        pyDict["clone_kernel"] = ToPython(clone_kernel);
                    PyTuple result = new PyTuple(self.InvokeMethod("log_marginal_likelihood", args, pyDict));
                    return (ToCsharp<float>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public (NDarray, NDarray, NDarray) predict(PyObject X, bool return_std = false, bool return_cov = false)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (return_std != false)
                        pyDict["return_std"] = ToPython(return_std);
                    if (return_cov != false)
                        pyDict["return_cov"] = ToPython(return_cov);
                    PyTuple result = new PyTuple(self.InvokeMethod("predict", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
                }

                public NDarray sample_y(PyObject X, int n_samples = 1, int? random_state = 0)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (n_samples != 1)
                        pyDict["n_samples"] = ToPython(n_samples);
                    if (random_state != 0)
                        pyDict["random_state"] = ToPython(random_state);
                    return ToCsharp<NDarray>(self.InvokeMethod("sample_y", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public GaussianProcessRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public GaussianProcessRegressor set_predict_request(string? return_cov = "$UNCHANGED$", string? return_std = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (return_cov != "$UNCHANGED$")
                        pyDict["return_cov"] = ToPython(return_cov);
                    if (return_std != "$UNCHANGED$")
                        pyDict["return_std"] = ToPython(return_std);
                    self.InvokeMethod("set_predict_request", args, pyDict);
                    return this;
                }

                public GaussianProcessRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                static kernels()
                {
                    ReInitializeLazySelf();
                }

                public class CompoundKernel : PythonObject
                {
                    public CompoundKernel(PyTuple kernels)
                    {
                        PyTuple args = ToTuple(new object[] { kernels });
                        PyDict pyDict = new PyDict();
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("CompoundKernel", args, pyDict);
                    }

                    internal CompoundKernel(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static CompoundKernel Encapsule(PyObject pyObject)
                    {
                        return new CompoundKernel(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(PyObject X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public CompoundKernel set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class ConstantKernel : PythonObject
                {
                    public ConstantKernel(float constant_value = 1.0f, float? constant_value_bounds = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (constant_value != 1.0f)
                            pyDict["constant_value"] = ToPython(constant_value);
                        if (constant_value_bounds != null)
                            pyDict["constant_value_bounds"] = ToPython(constant_value_bounds);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("ConstantKernel", args, pyDict);
                    }

                    internal ConstantKernel(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static ConstantKernel Encapsule(PyObject pyObject)
                    {
                        return new ConstantKernel(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(PyObject X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public ConstantKernel set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class DotProduct : PythonObject
                {
                    public DotProduct(float sigma_0 = 1.0f, float? sigma_0_bounds = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (sigma_0 != 1.0f)
                            pyDict["sigma_0"] = ToPython(sigma_0);
                        if (sigma_0_bounds != null)
                            pyDict["sigma_0_bounds"] = ToPython(sigma_0_bounds);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("DotProduct", args, pyDict);
                    }

                    internal DotProduct(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static DotProduct Encapsule(PyObject pyObject)
                    {
                        return new DotProduct(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public DotProduct set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class ExpSineSquared : PythonObject
                {
                    public ExpSineSquared(float length_scale = 1.0f, float periodicity = 1.0f, float? length_scale_bounds = null, float? periodicity_bounds = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (length_scale != 1.0f)
                            pyDict["length_scale"] = ToPython(length_scale);
                        if (periodicity != 1.0f)
                            pyDict["periodicity"] = ToPython(periodicity);
                        if (length_scale_bounds != null)
                            pyDict["length_scale_bounds"] = ToPython(length_scale_bounds);
                        if (periodicity_bounds != null)
                            pyDict["periodicity_bounds"] = ToPython(periodicity_bounds);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("ExpSineSquared", args, pyDict);
                    }

                    internal ExpSineSquared(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static ExpSineSquared Encapsule(PyObject pyObject)
                    {
                        return new ExpSineSquared(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public ExpSineSquared set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class Exponentiation : PythonObject
                {
                    public Exponentiation(PyObject kernel, float exponent)
                    {
                        PyTuple args = ToTuple(new object[] { kernel, exponent });
                        PyDict pyDict = new PyDict();
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("Exponentiation", args, pyDict);
                    }

                    internal Exponentiation(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static Exponentiation Encapsule(PyObject pyObject)
                    {
                        return new Exponentiation(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(PyObject X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public Exponentiation set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class Hyperparameter : PythonObject
                {
                    public Hyperparameter(int n_elements = 1)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (n_elements != 1)
                            pyDict["n_elements"] = ToPython(n_elements);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("Hyperparameter", args, pyDict);
                    }

                    internal Hyperparameter(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static Hyperparameter Encapsule(PyObject pyObject)
                    {
                        return new Hyperparameter(pyObject);
                    }

                    public string name => ToCsharp<string>(self.GetAttr("name"));
                    public string value_type => ToCsharp<string>(self.GetAttr("value_type"));
                    public float bounds => ToCsharp<float>(self.GetAttr("bounds"));
                    public int n_elements => ToCsharp<int>(self.GetAttr("n_elements"));
                    public bool @fixed => ToCsharp<bool>(self.GetAttr("fixed"));

                    public void count()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("count", args, pyDict);
                    }

                    public void index(int start = 0)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (start != 0)
                            pyDict["start"] = ToPython(start);
                        self.InvokeMethod("index", args, pyDict);
                    }
                }

                public class Kernel : PythonObject
                {
                    public Kernel()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("Kernel", args, pyDict);
                    }

                    internal Kernel(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static Kernel Encapsule(PyObject pyObject)
                    {
                        return new Kernel(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public Kernel set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class Matern : PythonObject
                {
                    public Matern(float length_scale = 1.0f, float? length_scale_bounds = null, float nu = 1.5f)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (length_scale != 1.0f)
                            pyDict["length_scale"] = ToPython(length_scale);
                        if (length_scale_bounds != null)
                            pyDict["length_scale_bounds"] = ToPython(length_scale_bounds);
                        if (nu != 1.5f)
                            pyDict["nu"] = ToPython(nu);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("Matern", args, pyDict);
                    }

                    internal Matern(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static Matern Encapsule(PyObject pyObject)
                    {
                        return new Matern(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public Matern set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class PairwiseKernel : PythonObject
                {
                    public PairwiseKernel(float gamma = 1.0f, float? gamma_bounds = null, string metric = "linear", PyDict? pairwise_kernels_kwargs = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (gamma != 1.0f)
                            pyDict["gamma"] = ToPython(gamma);
                        if (gamma_bounds != null)
                            pyDict["gamma_bounds"] = ToPython(gamma_bounds);
                        if (metric != "linear")
                            pyDict["metric"] = ToPython(metric);
                        if (pairwise_kernels_kwargs != null)
                            pyDict["pairwise_kernels_kwargs"] = ToPython(pairwise_kernels_kwargs);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("PairwiseKernel", args, pyDict);
                    }

                    internal PairwiseKernel(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static PairwiseKernel Encapsule(PyObject pyObject)
                    {
                        return new PairwiseKernel(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public PairwiseKernel set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class Product : PythonObject
                {
                    public Product(PyObject k1, PyObject k2)
                    {
                        PyTuple args = ToTuple(new object[] { k1, k2 });
                        PyDict pyDict = new PyDict();
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("Product", args, pyDict);
                    }

                    internal Product(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static Product Encapsule(PyObject pyObject)
                    {
                        return new Product(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(PyObject X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public Product set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class RBF : PythonObject
                {
                    public RBF(float length_scale = 1.0f, float? length_scale_bounds = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (length_scale != 1.0f)
                            pyDict["length_scale"] = ToPython(length_scale);
                        if (length_scale_bounds != null)
                            pyDict["length_scale_bounds"] = ToPython(length_scale_bounds);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("RBF", args, pyDict);
                    }

                    internal RBF(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static RBF Encapsule(PyObject pyObject)
                    {
                        return new RBF(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public RBF set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class RationalQuadratic : PythonObject
                {
                    public RationalQuadratic(float length_scale = 1.0f, float alpha = 1.0f, float? length_scale_bounds = null, float? alpha_bounds = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (length_scale != 1.0f)
                            pyDict["length_scale"] = ToPython(length_scale);
                        if (alpha != 1.0f)
                            pyDict["alpha"] = ToPython(alpha);
                        if (length_scale_bounds != null)
                            pyDict["length_scale_bounds"] = ToPython(length_scale_bounds);
                        if (alpha_bounds != null)
                            pyDict["alpha_bounds"] = ToPython(alpha_bounds);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("RationalQuadratic", args, pyDict);
                    }

                    internal RationalQuadratic(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static RationalQuadratic Encapsule(PyObject pyObject)
                    {
                        return new RationalQuadratic(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public RationalQuadratic set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class Sum : PythonObject
                {
                    public Sum(PyObject k1, PyObject k2)
                    {
                        PyTuple args = ToTuple(new object[] { k1, k2 });
                        PyDict pyDict = new PyDict();
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("Sum", args, pyDict);
                    }

                    internal Sum(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static Sum Encapsule(PyObject pyObject)
                    {
                        return new Sum(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(PyObject X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public Sum set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }

                public class WhiteKernel : PythonObject
                {
                    public WhiteKernel(float noise_level = 1.0f, float? noise_level_bounds = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (noise_level != 1.0f)
                            pyDict["noise_level"] = ToPython(noise_level);
                        if (noise_level_bounds != null)
                            pyDict["noise_level_bounds"] = ToPython(noise_level_bounds);
                        self = sklearn.gaussian_process.kernels.self.InvokeMethod("WhiteKernel", args, pyDict);
                    }

                    internal WhiteKernel(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static WhiteKernel Encapsule(PyObject pyObject)
                    {
                        return new WhiteKernel(pyObject);
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        PyTuple args = ToTuple(new object[] { theta });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("clone_with_theta", args, pyDict);
                    }

                    public NDarray diag(PyObject X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("diag", args, pyDict));
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (deep != true)
                            pyDict["deep"] = ToPython(deep);
                        return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                    }

                    public void is_stationary()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("is_stationary", args, pyDict);
                    }

                    public WhiteKernel set_params()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }
                }
            }
        }
    }
}