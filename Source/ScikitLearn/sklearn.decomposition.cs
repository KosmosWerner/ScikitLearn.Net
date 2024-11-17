using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class decomposition
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
                return Py.Import("sklearn.decomposition");
            }

            static decomposition()
            {
                ReInitializeLazySelf();
            }

            public class DictionaryLearning : PythonObject
            {
                public DictionaryLearning(int? n_components = null, int alpha = 1, int max_iter = 1000, float tol = 1e-08f, string fit_algorithm = "lars", string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, int? n_jobs = null, NDarray? code_init = null, NDarray? dict_init = null, PyObject? callback = null, bool verbose = false, bool split_sign = false, int? random_state = null, bool positive_code = false, bool positive_dict = false, int transform_max_iter = 1000)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (alpha != 1)
                        pyDict["alpha"] = ToPython(alpha);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (tol != 1e-08f)
                        pyDict["tol"] = ToPython(tol);
                    if (fit_algorithm != "lars")
                        pyDict["fit_algorithm"] = ToPython(fit_algorithm);
                    if (transform_algorithm != "omp")
                        pyDict["transform_algorithm"] = ToPython(transform_algorithm);
                    if (transform_n_nonzero_coefs != null)
                        pyDict["transform_n_nonzero_coefs"] = ToPython(transform_n_nonzero_coefs);
                    if (transform_alpha != null)
                        pyDict["transform_alpha"] = ToPython(transform_alpha);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (code_init != null)
                        pyDict["code_init"] = ToPython(code_init);
                    if (dict_init != null)
                        pyDict["dict_init"] = ToPython(dict_init);
                    if (callback != null)
                        pyDict["callback"] = ToPython(callback);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (split_sign != false)
                        pyDict["split_sign"] = ToPython(split_sign);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (positive_code != false)
                        pyDict["positive_code"] = ToPython(positive_code);
                    if (positive_dict != false)
                        pyDict["positive_dict"] = ToPython(positive_dict);
                    if (transform_max_iter != 1000)
                        pyDict["transform_max_iter"] = ToPython(transform_max_iter);
                    self = sklearn.decomposition.self.InvokeMethod("DictionaryLearning", args, pyDict);
                }

                internal DictionaryLearning(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static DictionaryLearning Encapsule(PyObject pyObject)
                {
                    return new DictionaryLearning(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray error_ => ToCsharp<NDarray>(self.GetAttr("error_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));

                public DictionaryLearning fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public DictionaryLearning set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public DictionaryLearning set_params(Dictionary<string, PyObject>? @params = null)
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

            public class FactorAnalysis : PythonObject
            {
                public FactorAnalysis(int? n_components = null, float tol = 0.01f, bool copy = true, int max_iter = 1000, NDarray? noise_variance_init = null, string svd_method = "randomized", int iterated_power = 3, PyObject? rotation = null, int random_state = 0)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (tol != 0.01f)
                        pyDict["tol"] = ToPython(tol);
                    if (copy != true)
                        pyDict["copy"] = ToPython(copy);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (noise_variance_init != null)
                        pyDict["noise_variance_init"] = ToPython(noise_variance_init);
                    if (svd_method != "randomized")
                        pyDict["svd_method"] = ToPython(svd_method);
                    if (iterated_power != 3)
                        pyDict["iterated_power"] = ToPython(iterated_power);
                    if (rotation != null)
                        pyDict["rotation"] = ToPython(rotation);
                    if (random_state != 0)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("FactorAnalysis", args, pyDict);
                }

                internal FactorAnalysis(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static FactorAnalysis Encapsule(PyObject pyObject)
                {
                    return new FactorAnalysis(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray loglike_ => ToCsharp<NDarray>(self.GetAttr("loglike_"));
                public NDarray noise_variance_ => ToCsharp<NDarray>(self.GetAttr("noise_variance_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public NDarray mean_ => ToCsharp<NDarray>(self.GetAttr("mean_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public FactorAnalysis fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public NDarray get_covariance()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("get_covariance", args, pyDict));
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

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("get_precision", args, pyDict));
                }

                public float score(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("score_samples", args, pyDict));
                }

                public FactorAnalysis set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public FactorAnalysis set_params(Dictionary<string, PyObject>? @params = null)
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

            public class FastICA : PythonObject
            {
                public FastICA(int? n_components = null, string algorithm = "parallel", string whiten = "unit-variance", string fun = "logcosh", PyDict? fun_args = null, int max_iter = 200, float tol = 0.0001f, NDarray? w_init = null, string whiten_solver = "svd", int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (algorithm != "parallel")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (whiten != "unit-variance")
                        pyDict["whiten"] = ToPython(whiten);
                    if (fun != "logcosh")
                        pyDict["fun"] = ToPython(fun);
                    if (fun_args != null)
                        pyDict["fun_args"] = ToPython(fun_args);
                    if (max_iter != 200)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    if (w_init != null)
                        pyDict["w_init"] = ToPython(w_init);
                    if (whiten_solver != "svd")
                        pyDict["whiten_solver"] = ToPython(whiten_solver);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("FastICA", args, pyDict);
                }

                internal FastICA(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static FastICA Encapsule(PyObject pyObject)
                {
                    return new FastICA(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray mixing_ => ToCsharp<NDarray>(self.GetAttr("mixing_"));
                public NDarray mean_ => ToCsharp<NDarray>(self.GetAttr("mean_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public NDarray whitening_ => ToCsharp<NDarray>(self.GetAttr("whitening_"));

                public FastICA fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X, bool copy = true)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = ToPython(copy);
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public FastICA set_inverse_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = ToPython(copy);
                    self.InvokeMethod("set_inverse_transform_request", args, pyDict);
                    return this;
                }

                public FastICA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public FastICA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public FastICA set_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = ToPython(copy);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X, bool copy = true)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = ToPython(copy);
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class IncrementalPCA : PythonObject
            {
                public IncrementalPCA(int? n_components = null, bool whiten = false, bool copy = true, int? batch_size = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (whiten != false)
                        pyDict["whiten"] = ToPython(whiten);
                    if (copy != true)
                        pyDict["copy"] = ToPython(copy);
                    if (batch_size != null)
                        pyDict["batch_size"] = ToPython(batch_size);
                    self = sklearn.decomposition.self.InvokeMethod("IncrementalPCA", args, pyDict);
                }

                internal IncrementalPCA(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static IncrementalPCA Encapsule(PyObject pyObject)
                {
                    return new IncrementalPCA(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray explained_variance_ => ToCsharp<NDarray>(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => ToCsharp<NDarray>(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => ToCsharp<NDarray>(self.GetAttr("singular_values_"));
                public NDarray mean_ => ToCsharp<NDarray>(self.GetAttr("mean_"));
                public NDarray var_ => ToCsharp<NDarray>(self.GetAttr("var_"));
                public float noise_variance_ => ToCsharp<float>(self.GetAttr("noise_variance_"));
                public int n_components_ => ToCsharp<int>(self.GetAttr("n_components_"));
                public int n_samples_seen_ => ToCsharp<int>(self.GetAttr("n_samples_seen_"));
                public int batch_size_ => ToCsharp<int>(self.GetAttr("batch_size_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public IncrementalPCA fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public NDarray get_covariance()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("get_covariance", args, pyDict));
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

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public IncrementalPCA partial_fit(NDarray X, bool check_input = true)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (check_input != true)
                        pyDict["check_input"] = ToPython(check_input);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public IncrementalPCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public IncrementalPCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public IncrementalPCA set_partial_fit_request(string? check_input = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (check_input != "$UNCHANGED$")
                        pyDict["check_input"] = ToPython(check_input);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class KernelPCA : PythonObject
            {
                public KernelPCA(int? n_components = null, string kernel = "linear", float? gamma = null, int degree = 3, int coef0 = 1, PyDict? kernel_params = null, float alpha = 1.0f, bool fit_inverse_transform = false, string eigen_solver = "auto", int tol = 0, int? max_iter = null, string iterated_power = "auto", bool remove_zero_eig = false, int? random_state = null, bool copy_X = true, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (kernel != "linear")
                        pyDict["kernel"] = ToPython(kernel);
                    if (gamma != null)
                        pyDict["gamma"] = ToPython(gamma);
                    if (degree != 3)
                        pyDict["degree"] = ToPython(degree);
                    if (coef0 != 1)
                        pyDict["coef0"] = ToPython(coef0);
                    if (kernel_params != null)
                        pyDict["kernel_params"] = ToPython(kernel_params);
                    if (alpha != 1.0f)
                        pyDict["alpha"] = ToPython(alpha);
                    if (fit_inverse_transform != false)
                        pyDict["fit_inverse_transform"] = ToPython(fit_inverse_transform);
                    if (eigen_solver != "auto")
                        pyDict["eigen_solver"] = ToPython(eigen_solver);
                    if (tol != 0)
                        pyDict["tol"] = ToPython(tol);
                    if (max_iter != null)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (iterated_power != "auto")
                        pyDict["iterated_power"] = ToPython(iterated_power);
                    if (remove_zero_eig != false)
                        pyDict["remove_zero_eig"] = ToPython(remove_zero_eig);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (copy_X != true)
                        pyDict["copy_X"] = ToPython(copy_X);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.decomposition.self.InvokeMethod("KernelPCA", args, pyDict);
                }

                internal KernelPCA(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static KernelPCA Encapsule(PyObject pyObject)
                {
                    return new KernelPCA(pyObject);
                }

                public NDarray eigenvalues_ => ToCsharp<NDarray>(self.GetAttr("eigenvalues_"));
                public NDarray eigenvectors_ => ToCsharp<NDarray>(self.GetAttr("eigenvectors_"));
                public NDarray dual_coef_ => ToCsharp<NDarray>(self.GetAttr("dual_coef_"));
                public NDarray X_transformed_fit_ => ToCsharp<NDarray>(self.GetAttr("X_transformed_fit_"));
                public NDarray X_fit_ => ToCsharp<NDarray>(self.GetAttr("X_fit_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public float gamma_ => ToCsharp<float>(self.GetAttr("gamma_"));

                public KernelPCA fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public KernelPCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public KernelPCA set_params(Dictionary<string, PyObject>? @params = null)
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

            public class LatentDirichletAllocation : PythonObject
            {
                public LatentDirichletAllocation(int n_components = 10, float? doc_topic_prior = null, float? topic_word_prior = null, string learning_method = "batch", float learning_decay = 0.7f, float learning_offset = 10.0f, int max_iter = 10, int batch_size = 128, int evaluate_every = -1, float total_samples = 1000000.0f, float perp_tol = 0.1f, float mean_change_tol = 0.001f, int max_doc_update_iter = 100, int? n_jobs = null, int verbose = 0, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 10)
                        pyDict["n_components"] = ToPython(n_components);
                    if (doc_topic_prior != null)
                        pyDict["doc_topic_prior"] = ToPython(doc_topic_prior);
                    if (topic_word_prior != null)
                        pyDict["topic_word_prior"] = ToPython(topic_word_prior);
                    if (learning_method != "batch")
                        pyDict["learning_method"] = ToPython(learning_method);
                    if (learning_decay != 0.7f)
                        pyDict["learning_decay"] = ToPython(learning_decay);
                    if (learning_offset != 10.0f)
                        pyDict["learning_offset"] = ToPython(learning_offset);
                    if (max_iter != 10)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (batch_size != 128)
                        pyDict["batch_size"] = ToPython(batch_size);
                    if (evaluate_every != -1)
                        pyDict["evaluate_every"] = ToPython(evaluate_every);
                    if (total_samples != 1000000.0f)
                        pyDict["total_samples"] = ToPython(total_samples);
                    if (perp_tol != 0.1f)
                        pyDict["perp_tol"] = ToPython(perp_tol);
                    if (mean_change_tol != 0.001f)
                        pyDict["mean_change_tol"] = ToPython(mean_change_tol);
                    if (max_doc_update_iter != 100)
                        pyDict["max_doc_update_iter"] = ToPython(max_doc_update_iter);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("LatentDirichletAllocation", args, pyDict);
                }

                internal LatentDirichletAllocation(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static LatentDirichletAllocation Encapsule(PyObject pyObject)
                {
                    return new LatentDirichletAllocation(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray exp_dirichlet_component_ => ToCsharp<NDarray>(self.GetAttr("exp_dirichlet_component_"));
                public int n_batch_iter_ => ToCsharp<int>(self.GetAttr("n_batch_iter_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public float bound_ => ToCsharp<float>(self.GetAttr("bound_"));
                public float doc_topic_prior_ => ToCsharp<float>(self.GetAttr("doc_topic_prior_"));
                public PyObject random_state_ => self.GetAttr("random_state_");
                public float topic_word_prior_ => ToCsharp<float>(self.GetAttr("topic_word_prior_"));

                public LatentDirichletAllocation fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public LatentDirichletAllocation partial_fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public float perplexity(NDarray X, bool sub_sampling = false)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (sub_sampling != false)
                        pyDict["sub_sampling"] = ToPython(sub_sampling);
                    return ToCsharp<float>(self.InvokeMethod("perplexity", args, pyDict));
                }

                public float score(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public LatentDirichletAllocation set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public LatentDirichletAllocation set_params(Dictionary<string, PyObject>? @params = null)
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

            public class MiniBatchDictionaryLearning : PythonObject
            {
                public MiniBatchDictionaryLearning(int? n_components = null, int alpha = 1, int max_iter = 1000, string fit_algorithm = "lars", int? n_jobs = null, int batch_size = 256, bool shuffle = true, NDarray? dict_init = null, string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, bool verbose = false, bool split_sign = false, int? random_state = null, bool positive_code = false, bool positive_dict = false, int transform_max_iter = 1000, PyObject? callback = null, float tol = 0.001f, int max_no_improvement = 10)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (alpha != 1)
                        pyDict["alpha"] = ToPython(alpha);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (fit_algorithm != "lars")
                        pyDict["fit_algorithm"] = ToPython(fit_algorithm);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (batch_size != 256)
                        pyDict["batch_size"] = ToPython(batch_size);
                    if (shuffle != true)
                        pyDict["shuffle"] = ToPython(shuffle);
                    if (dict_init != null)
                        pyDict["dict_init"] = ToPython(dict_init);
                    if (transform_algorithm != "omp")
                        pyDict["transform_algorithm"] = ToPython(transform_algorithm);
                    if (transform_n_nonzero_coefs != null)
                        pyDict["transform_n_nonzero_coefs"] = ToPython(transform_n_nonzero_coefs);
                    if (transform_alpha != null)
                        pyDict["transform_alpha"] = ToPython(transform_alpha);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (split_sign != false)
                        pyDict["split_sign"] = ToPython(split_sign);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (positive_code != false)
                        pyDict["positive_code"] = ToPython(positive_code);
                    if (positive_dict != false)
                        pyDict["positive_dict"] = ToPython(positive_dict);
                    if (transform_max_iter != 1000)
                        pyDict["transform_max_iter"] = ToPython(transform_max_iter);
                    if (callback != null)
                        pyDict["callback"] = ToPython(callback);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (max_no_improvement != 10)
                        pyDict["max_no_improvement"] = ToPython(max_no_improvement);
                    self = sklearn.decomposition.self.InvokeMethod("MiniBatchDictionaryLearning", args, pyDict);
                }

                internal MiniBatchDictionaryLearning(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static MiniBatchDictionaryLearning Encapsule(PyObject pyObject)
                {
                    return new MiniBatchDictionaryLearning(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public int n_steps_ => ToCsharp<int>(self.GetAttr("n_steps_"));

                public MiniBatchDictionaryLearning fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public MiniBatchDictionaryLearning partial_fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public MiniBatchDictionaryLearning set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MiniBatchDictionaryLearning set_params(Dictionary<string, PyObject>? @params = null)
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

            public class MiniBatchNMF : PythonObject
            {
                public MiniBatchNMF(string? n_components = "warn", PyObject? init = null, int batch_size = 1024, string beta_loss = "frobenius", float tol = 0.0001f, int max_no_improvement = 10, int max_iter = 200, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, float forget_factor = 0.7f, bool fresh_restarts = false, int fresh_restarts_max_iter = 30, int? transform_max_iter = null, int? random_state = null, int verbose = 0)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != "warn")
                        pyDict["n_components"] = ToPython(n_components);
                    if (init != null)
                        pyDict["init"] = ToPython(init);
                    if (batch_size != 1024)
                        pyDict["batch_size"] = ToPython(batch_size);
                    if (beta_loss != "frobenius")
                        pyDict["beta_loss"] = ToPython(beta_loss);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    if (max_no_improvement != 10)
                        pyDict["max_no_improvement"] = ToPython(max_no_improvement);
                    if (max_iter != 200)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (alpha_W != 0.0f)
                        pyDict["alpha_W"] = ToPython(alpha_W);
                    if (alpha_H != "same")
                        pyDict["alpha_H"] = ToPython(alpha_H);
                    if (l1_ratio != 0.0f)
                        pyDict["l1_ratio"] = ToPython(l1_ratio);
                    if (forget_factor != 0.7f)
                        pyDict["forget_factor"] = ToPython(forget_factor);
                    if (fresh_restarts != false)
                        pyDict["fresh_restarts"] = ToPython(fresh_restarts);
                    if (fresh_restarts_max_iter != 30)
                        pyDict["fresh_restarts_max_iter"] = ToPython(fresh_restarts_max_iter);
                    if (transform_max_iter != null)
                        pyDict["transform_max_iter"] = ToPython(transform_max_iter);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    self = sklearn.decomposition.self.InvokeMethod("MiniBatchNMF", args, pyDict);
                }

                internal MiniBatchNMF(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static MiniBatchNMF Encapsule(PyObject pyObject)
                {
                    return new MiniBatchNMF(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public int n_components_ => ToCsharp<int>(self.GetAttr("n_components_"));
                public string reconstruction_err_ => ToCsharp<string>(self.GetAttr("reconstruction_err_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public int n_steps_ => ToCsharp<int>(self.GetAttr("n_steps_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public MiniBatchNMF fit(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? W = null, NDarray? H = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (W != null)
                        pyDict["W"] = ToPython(W);
                    if (H != null)
                        pyDict["H"] = ToPython(H);
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

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (Xt != null)
                        pyDict["Xt"] = ToPython(Xt);
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public MiniBatchNMF partial_fit(NDarray X, NDarray? W = null, NDarray? H = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (W != null)
                        pyDict["W"] = ToPython(W);
                    if (H != null)
                        pyDict["H"] = ToPython(H);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public MiniBatchNMF set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MiniBatchNMF set_params(Dictionary<string, PyObject>? @params = null)
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

            public class MiniBatchSparsePCA : PythonObject
            {
                public MiniBatchSparsePCA(int? n_components = null, int alpha = 1, float ridge_alpha = 0.01f, int max_iter = 1000, PyObject? callback = null, int batch_size = 3, bool verbose = false, bool shuffle = true, int? n_jobs = null, string method = "lars", int? random_state = null, float tol = 0.001f, int? max_no_improvement = 10)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (alpha != 1)
                        pyDict["alpha"] = ToPython(alpha);
                    if (ridge_alpha != 0.01f)
                        pyDict["ridge_alpha"] = ToPython(ridge_alpha);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (callback != null)
                        pyDict["callback"] = ToPython(callback);
                    if (batch_size != 3)
                        pyDict["batch_size"] = ToPython(batch_size);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (shuffle != true)
                        pyDict["shuffle"] = ToPython(shuffle);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (method != "lars")
                        pyDict["method"] = ToPython(method);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (max_no_improvement != 10)
                        pyDict["max_no_improvement"] = ToPython(max_no_improvement);
                    self = sklearn.decomposition.self.InvokeMethod("MiniBatchSparsePCA", args, pyDict);
                }

                internal MiniBatchSparsePCA(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static MiniBatchSparsePCA Encapsule(PyObject pyObject)
                {
                    return new MiniBatchSparsePCA(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public int n_components_ => ToCsharp<int>(self.GetAttr("n_components_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public NDarray mean_ => ToCsharp<NDarray>(self.GetAttr("mean_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public MiniBatchSparsePCA fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public MiniBatchSparsePCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MiniBatchSparsePCA set_params(Dictionary<string, PyObject>? @params = null)
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

            public class NMF : PythonObject
            {
                public NMF(string? n_components = "warn", PyObject? init = null, string solver = "cd", string beta_loss = "frobenius", float tol = 0.0001f, int max_iter = 200, int? random_state = null, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, int verbose = 0, bool shuffle = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != "warn")
                        pyDict["n_components"] = ToPython(n_components);
                    if (init != null)
                        pyDict["init"] = ToPython(init);
                    if (solver != "cd")
                        pyDict["solver"] = ToPython(solver);
                    if (beta_loss != "frobenius")
                        pyDict["beta_loss"] = ToPython(beta_loss);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    if (max_iter != 200)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (alpha_W != 0.0f)
                        pyDict["alpha_W"] = ToPython(alpha_W);
                    if (alpha_H != "same")
                        pyDict["alpha_H"] = ToPython(alpha_H);
                    if (l1_ratio != 0.0f)
                        pyDict["l1_ratio"] = ToPython(l1_ratio);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (shuffle != false)
                        pyDict["shuffle"] = ToPython(shuffle);
                    self = sklearn.decomposition.self.InvokeMethod("NMF", args, pyDict);
                }

                internal NMF(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static NMF Encapsule(PyObject pyObject)
                {
                    return new NMF(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public int n_components_ => ToCsharp<int>(self.GetAttr("n_components_"));
                public string reconstruction_err_ => ToCsharp<string>(self.GetAttr("reconstruction_err_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NMF fit(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? W = null, NDarray? H = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (W != null)
                        pyDict["W"] = ToPython(W);
                    if (H != null)
                        pyDict["H"] = ToPython(H);
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

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (Xt != null)
                        pyDict["Xt"] = ToPython(Xt);
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public NMF set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public NMF set_params(Dictionary<string, PyObject>? @params = null)
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

            public class PCA : PythonObject
            {
                public PCA(float? n_components = null, bool copy = true, bool whiten = false, string svd_solver = "auto", float tol = 0.0f, string iterated_power = "auto", int n_oversamples = 10, string power_iteration_normalizer = "auto", int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (copy != true)
                        pyDict["copy"] = ToPython(copy);
                    if (whiten != false)
                        pyDict["whiten"] = ToPython(whiten);
                    if (svd_solver != "auto")
                        pyDict["svd_solver"] = ToPython(svd_solver);
                    if (tol != 0.0f)
                        pyDict["tol"] = ToPython(tol);
                    if (iterated_power != "auto")
                        pyDict["iterated_power"] = ToPython(iterated_power);
                    if (n_oversamples != 10)
                        pyDict["n_oversamples"] = ToPython(n_oversamples);
                    if (power_iteration_normalizer != "auto")
                        pyDict["power_iteration_normalizer"] = ToPython(power_iteration_normalizer);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("PCA", args, pyDict);
                }

                internal PCA(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static PCA Encapsule(PyObject pyObject)
                {
                    return new PCA(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray explained_variance_ => ToCsharp<NDarray>(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => ToCsharp<NDarray>(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => ToCsharp<NDarray>(self.GetAttr("singular_values_"));
                public NDarray mean_ => ToCsharp<NDarray>(self.GetAttr("mean_"));
                public int n_components_ => ToCsharp<int>(self.GetAttr("n_components_"));
                public int n_samples_ => ToCsharp<int>(self.GetAttr("n_samples_"));
                public float noise_variance_ => ToCsharp<float>(self.GetAttr("noise_variance_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public PCA fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public NDarray get_covariance()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("get_covariance", args, pyDict));
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

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public float score(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("score_samples", args, pyDict));
                }

                public PCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public PCA set_params(Dictionary<string, PyObject>? @params = null)
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

            public class SparseCoder : PythonObject
            {
                public SparseCoder(NDarray dictionary, string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, bool split_sign = false, int? n_jobs = null, bool positive_code = false, int transform_max_iter = 1000)
                {
                    PyTuple args = ToTuple(new object[] { dictionary });
                    PyDict pyDict = new PyDict();
                    if (transform_algorithm != "omp")
                        pyDict["transform_algorithm"] = ToPython(transform_algorithm);
                    if (transform_n_nonzero_coefs != null)
                        pyDict["transform_n_nonzero_coefs"] = ToPython(transform_n_nonzero_coefs);
                    if (transform_alpha != null)
                        pyDict["transform_alpha"] = ToPython(transform_alpha);
                    if (split_sign != false)
                        pyDict["split_sign"] = ToPython(split_sign);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (positive_code != false)
                        pyDict["positive_code"] = ToPython(positive_code);
                    if (transform_max_iter != 1000)
                        pyDict["transform_max_iter"] = ToPython(transform_max_iter);
                    self = sklearn.decomposition.self.InvokeMethod("SparseCoder", args, pyDict);
                }

                internal SparseCoder(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SparseCoder Encapsule(PyObject pyObject)
                {
                    return new SparseCoder(pyObject);
                }

                public int n_components_ => ToCsharp<int>(self.GetAttr("n_components_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SparseCoder fit()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
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

                public SparseCoder set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SparseCoder set_params(Dictionary<string, PyObject>? @params = null)
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

            public class SparsePCA : PythonObject
            {
                public SparsePCA(int? n_components = null, int alpha = 1, float ridge_alpha = 0.01f, int max_iter = 1000, float tol = 1e-08f, string method = "lars", int? n_jobs = null, NDarray? U_init = null, NDarray? V_init = null, bool verbose = false, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (alpha != 1)
                        pyDict["alpha"] = ToPython(alpha);
                    if (ridge_alpha != 0.01f)
                        pyDict["ridge_alpha"] = ToPython(ridge_alpha);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (tol != 1e-08f)
                        pyDict["tol"] = ToPython(tol);
                    if (method != "lars")
                        pyDict["method"] = ToPython(method);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (U_init != null)
                        pyDict["U_init"] = ToPython(U_init);
                    if (V_init != null)
                        pyDict["V_init"] = ToPython(V_init);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("SparsePCA", args, pyDict);
                }

                internal SparsePCA(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SparsePCA Encapsule(PyObject pyObject)
                {
                    return new SparsePCA(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray error_ => ToCsharp<NDarray>(self.GetAttr("error_"));
                public int n_components_ => ToCsharp<int>(self.GetAttr("n_components_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public NDarray mean_ => ToCsharp<NDarray>(self.GetAttr("mean_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SparsePCA fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SparsePCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SparsePCA set_params(Dictionary<string, PyObject>? @params = null)
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

            public class TruncatedSVD : PythonObject
            {
                public TruncatedSVD(int n_components = 2, string algorithm = "randomized", int n_iter = 5, int n_oversamples = 10, string power_iteration_normalizer = "auto", int? random_state = null, float tol = 0.0f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 2)
                        pyDict["n_components"] = ToPython(n_components);
                    if (algorithm != "randomized")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (n_iter != 5)
                        pyDict["n_iter"] = ToPython(n_iter);
                    if (n_oversamples != 10)
                        pyDict["n_oversamples"] = ToPython(n_oversamples);
                    if (power_iteration_normalizer != "auto")
                        pyDict["power_iteration_normalizer"] = ToPython(power_iteration_normalizer);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (tol != 0.0f)
                        pyDict["tol"] = ToPython(tol);
                    self = sklearn.decomposition.self.InvokeMethod("TruncatedSVD", args, pyDict);
                }

                internal TruncatedSVD(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static TruncatedSVD Encapsule(PyObject pyObject)
                {
                    return new TruncatedSVD(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray explained_variance_ => ToCsharp<NDarray>(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => ToCsharp<NDarray>(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => ToCsharp<NDarray>(self.GetAttr("singular_values_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public TruncatedSVD fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public TruncatedSVD set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public TruncatedSVD set_params(Dictionary<string, PyObject>? @params = null)
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

            public static (NDarray, PyDict, NDarray, int) dict_learning(NDarray X, int n_components, float alpha, int max_iter = 100, float tol = 1e-08f, string method = "lars", int? n_jobs = null, NDarray? dict_init = null, NDarray? code_init = null, PyObject? callback = null, bool verbose = false, int? random_state = null, bool return_n_iter = false, bool positive_dict = false, bool positive_code = false, int method_max_iter = 1000)
            {
                PyTuple args = ToTuple(new object[] { X, n_components, alpha });
                PyDict pyDict = new PyDict();
                if (max_iter != 100)
                    pyDict["max_iter"] = ToPython(max_iter);
                if (tol != 1e-08f)
                    pyDict["tol"] = ToPython(tol);
                if (method != "lars")
                    pyDict["method"] = ToPython(method);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                if (dict_init != null)
                    pyDict["dict_init"] = ToPython(dict_init);
                if (code_init != null)
                    pyDict["code_init"] = ToPython(code_init);
                if (callback != null)
                    pyDict["callback"] = ToPython(callback);
                if (verbose != false)
                    pyDict["verbose"] = ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = ToPython(return_n_iter);
                if (positive_dict != false)
                    pyDict["positive_dict"] = ToPython(positive_dict);
                if (positive_code != false)
                    pyDict["positive_code"] = ToPython(positive_code);
                if (method_max_iter != 1000)
                    pyDict["method_max_iter"] = ToPython(method_max_iter);
                PyTuple result = new PyTuple(sklearn.decomposition.self.InvokeMethod("dict_learning", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<PyDict>(result[1]), ToCsharp<NDarray>(result[2]), ToCsharp<int>(result[3]));
            }

            public static (NDarray, PyDict, int) dict_learning_online(NDarray X, int? n_components = 2, int alpha = 1, int max_iter = 100, bool return_code = true, NDarray? dict_init = null, PyObject? callback = null, int batch_size = 256, bool verbose = false, bool shuffle = true, int? n_jobs = null, string method = "lars", int? random_state = null, bool positive_dict = false, bool positive_code = false, int method_max_iter = 1000, float tol = 0.001f, int max_no_improvement = 10)
            {
                PyTuple args = ToTuple(new object[] { X });
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = ToPython(n_components);
                if (alpha != 1)
                    pyDict["alpha"] = ToPython(alpha);
                if (max_iter != 100)
                    pyDict["max_iter"] = ToPython(max_iter);
                if (return_code != true)
                    pyDict["return_code"] = ToPython(return_code);
                if (dict_init != null)
                    pyDict["dict_init"] = ToPython(dict_init);
                if (callback != null)
                    pyDict["callback"] = ToPython(callback);
                if (batch_size != 256)
                    pyDict["batch_size"] = ToPython(batch_size);
                if (verbose != false)
                    pyDict["verbose"] = ToPython(verbose);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                if (method != "lars")
                    pyDict["method"] = ToPython(method);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (positive_dict != false)
                    pyDict["positive_dict"] = ToPython(positive_dict);
                if (positive_code != false)
                    pyDict["positive_code"] = ToPython(positive_code);
                if (method_max_iter != 1000)
                    pyDict["method_max_iter"] = ToPython(method_max_iter);
                if (tol != 0.001f)
                    pyDict["tol"] = ToPython(tol);
                if (max_no_improvement != 10)
                    pyDict["max_no_improvement"] = ToPython(max_no_improvement);
                PyTuple result = new PyTuple(sklearn.decomposition.self.InvokeMethod("dict_learning_online", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<PyDict>(result[1]), ToCsharp<int>(result[2]));
            }

            public static (NDarray? , NDarray, NDarray? , NDarray, int) fastica(NDarray X, int? n_components = null, string algorithm = "parallel", string whiten = "unit-variance", string fun = "logcosh", PyDict? fun_args = null, int max_iter = 200, float tol = 0.0001f, NDarray? w_init = null, string whiten_solver = "svd", int? random_state = null, bool return_X_mean = false, bool compute_sources = true, bool return_n_iter = false)
            {
                PyTuple args = ToTuple(new object[] { X });
                PyDict pyDict = new PyDict();
                if (n_components != null)
                    pyDict["n_components"] = ToPython(n_components);
                if (algorithm != "parallel")
                    pyDict["algorithm"] = ToPython(algorithm);
                if (whiten != "unit-variance")
                    pyDict["whiten"] = ToPython(whiten);
                if (fun != "logcosh")
                    pyDict["fun"] = ToPython(fun);
                if (fun_args != null)
                    pyDict["fun_args"] = ToPython(fun_args);
                if (max_iter != 200)
                    pyDict["max_iter"] = ToPython(max_iter);
                if (tol != 0.0001f)
                    pyDict["tol"] = ToPython(tol);
                if (w_init != null)
                    pyDict["w_init"] = ToPython(w_init);
                if (whiten_solver != "svd")
                    pyDict["whiten_solver"] = ToPython(whiten_solver);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (return_X_mean != false)
                    pyDict["return_X_mean"] = ToPython(return_X_mean);
                if (compute_sources != true)
                    pyDict["compute_sources"] = ToPython(compute_sources);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = ToPython(return_n_iter);
                PyTuple result = new PyTuple(sklearn.decomposition.self.InvokeMethod("fastica", args, pyDict));
                return (ToCsharp<NDarray?>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray?>(result[2]), ToCsharp<NDarray>(result[3]), ToCsharp<int>(result[4]));
            }

            public static (NDarray, NDarray, int) non_negative_factorization(NDarray X, NDarray? W = null, NDarray? H = null, string? n_components = "warn", PyObject? init = null, bool update_H = true, string solver = "cd", string beta_loss = "frobenius", float tol = 0.0001f, int max_iter = 200, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, int? random_state = null, int verbose = 0, bool shuffle = false)
            {
                PyTuple args = ToTuple(new object[] { X });
                PyDict pyDict = new PyDict();
                if (W != null)
                    pyDict["W"] = ToPython(W);
                if (H != null)
                    pyDict["H"] = ToPython(H);
                if (n_components != "warn")
                    pyDict["n_components"] = ToPython(n_components);
                if (init != null)
                    pyDict["init"] = ToPython(init);
                if (update_H != true)
                    pyDict["update_H"] = ToPython(update_H);
                if (solver != "cd")
                    pyDict["solver"] = ToPython(solver);
                if (beta_loss != "frobenius")
                    pyDict["beta_loss"] = ToPython(beta_loss);
                if (tol != 0.0001f)
                    pyDict["tol"] = ToPython(tol);
                if (max_iter != 200)
                    pyDict["max_iter"] = ToPython(max_iter);
                if (alpha_W != 0.0f)
                    pyDict["alpha_W"] = ToPython(alpha_W);
                if (alpha_H != "same")
                    pyDict["alpha_H"] = ToPython(alpha_H);
                if (l1_ratio != 0.0f)
                    pyDict["l1_ratio"] = ToPython(l1_ratio);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = ToPython(verbose);
                if (shuffle != false)
                    pyDict["shuffle"] = ToPython(shuffle);
                PyTuple result = new PyTuple(sklearn.decomposition.self.InvokeMethod("non_negative_factorization", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<int>(result[2]));
            }

            public static NDarray sparse_encode(NDarray X, NDarray dictionary, NDarray? gram = null, NDarray? cov = null, string algorithm = "lasso_lars", int? n_nonzero_coefs = null, float? alpha = null, bool copy_cov = true, NDarray? init = null, int max_iter = 1000, int? n_jobs = null, bool check_input = true, int verbose = 0, bool positive = false)
            {
                PyTuple args = ToTuple(new object[] { X, dictionary });
                PyDict pyDict = new PyDict();
                if (gram != null)
                    pyDict["gram"] = ToPython(gram);
                if (cov != null)
                    pyDict["cov"] = ToPython(cov);
                if (algorithm != "lasso_lars")
                    pyDict["algorithm"] = ToPython(algorithm);
                if (n_nonzero_coefs != null)
                    pyDict["n_nonzero_coefs"] = ToPython(n_nonzero_coefs);
                if (alpha != null)
                    pyDict["alpha"] = ToPython(alpha);
                if (copy_cov != true)
                    pyDict["copy_cov"] = ToPython(copy_cov);
                if (init != null)
                    pyDict["init"] = ToPython(init);
                if (max_iter != 1000)
                    pyDict["max_iter"] = ToPython(max_iter);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                if (check_input != true)
                    pyDict["check_input"] = ToPython(check_input);
                if (verbose != 0)
                    pyDict["verbose"] = ToPython(verbose);
                if (positive != false)
                    pyDict["positive"] = ToPython(positive);
                return ToCsharp<NDarray>(sklearn.decomposition.self.InvokeMethod("sparse_encode", args, pyDict));
            }
        }
    }
}