using System;
using System.Collections.Generic;
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
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (alpha != 1)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 1e-08f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (fit_algorithm != "lars")
                        pyDict["fit_algorithm"] = Helpers.ToPython(fit_algorithm);
                    if (transform_algorithm != "omp")
                        pyDict["transform_algorithm"] = Helpers.ToPython(transform_algorithm);
                    if (transform_n_nonzero_coefs != null)
                        pyDict["transform_n_nonzero_coefs"] = Helpers.ToPython(transform_n_nonzero_coefs);
                    if (transform_alpha != null)
                        pyDict["transform_alpha"] = Helpers.ToPython(transform_alpha);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (code_init != null)
                        pyDict["code_init"] = Helpers.ToPython(code_init);
                    if (dict_init != null)
                        pyDict["dict_init"] = Helpers.ToPython(dict_init);
                    if (callback != null)
                        pyDict["callback"] = Helpers.ToPython(callback);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (split_sign != false)
                        pyDict["split_sign"] = Helpers.ToPython(split_sign);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (positive_code != false)
                        pyDict["positive_code"] = Helpers.ToPython(positive_code);
                    if (positive_dict != false)
                        pyDict["positive_dict"] = Helpers.ToPython(positive_dict);
                    if (transform_max_iter != 1000)
                        pyDict["transform_max_iter"] = Helpers.ToPython(transform_max_iter);
                    self = sklearn.decomposition.self.InvokeMethod("DictionaryLearning", args, pyDict);
                }

                internal DictionaryLearning(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static DictionaryLearning Encapsule(PyObject pyObject)
                {
                    return new DictionaryLearning(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray error_ => Helpers.ToCSharpNDarray(self.GetAttr("error_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));

                public DictionaryLearning fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public DictionaryLearning set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public DictionaryLearning set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class FactorAnalysis : PythonObject
            {
                public FactorAnalysis(int? n_components = null, float tol = 0.01f, bool copy = true, int max_iter = 1000, NDarray? noise_variance_init = null, string svd_method = "randomized", int iterated_power = 3, PyObject? rotation = null, int random_state = 0)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (tol != 0.01f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (noise_variance_init != null)
                        pyDict["noise_variance_init"] = Helpers.ToPython(noise_variance_init);
                    if (svd_method != "randomized")
                        pyDict["svd_method"] = Helpers.ToPython(svd_method);
                    if (iterated_power != 3)
                        pyDict["iterated_power"] = Helpers.ToPython(iterated_power);
                    if (rotation != null)
                        pyDict["rotation"] = Helpers.ToPython(rotation);
                    if (random_state != 0)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("FactorAnalysis", args, pyDict);
                }

                internal FactorAnalysis(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static FactorAnalysis Encapsule(PyObject pyObject)
                {
                    return new FactorAnalysis(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray loglike_ => Helpers.ToCSharpNDarray(self.GetAttr("loglike_"));
                public NDarray noise_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("noise_variance_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public FactorAnalysis fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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

                public NDarray get_covariance()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_covariance", args, pyDict));
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

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
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

                public FactorAnalysis set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public FactorAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class FastICA : PythonObject
            {
                public FastICA(int? n_components = null, string algorithm = "parallel", string whiten = "unit-variance", string fun = "logcosh", PyDict? fun_args = null, int max_iter = 200, float tol = 0.0001f, NDarray? w_init = null, string whiten_solver = "svd", int? random_state = null)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (algorithm != "parallel")
                        pyDict["algorithm"] = Helpers.ToPython(algorithm);
                    if (whiten != "unit-variance")
                        pyDict["whiten"] = Helpers.ToPython(whiten);
                    if (fun != "logcosh")
                        pyDict["fun"] = Helpers.ToPython(fun);
                    if (fun_args != null)
                        pyDict["fun_args"] = Helpers.ToPython(fun_args);
                    if (max_iter != 200)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (w_init != null)
                        pyDict["w_init"] = Helpers.ToPython(w_init);
                    if (whiten_solver != "svd")
                        pyDict["whiten_solver"] = Helpers.ToPython(whiten_solver);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("FastICA", args, pyDict);
                }

                internal FastICA(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static FastICA Encapsule(PyObject pyObject)
                {
                    return new FastICA(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray mixing_ => Helpers.ToCSharpNDarray(self.GetAttr("mixing_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray whitening_ => Helpers.ToCSharpNDarray(self.GetAttr("whitening_"));

                public FastICA fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X, bool copy = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public FastICA set_inverse_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self.InvokeMethod("set_inverse_transform_request", args, pyDict);
                    return this;
                }

                public FastICA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public FastICA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public FastICA set_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X, bool copy = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class IncrementalPCA : PythonObject
            {
                public IncrementalPCA(int? n_components = null, bool whiten = false, bool copy = true, int? batch_size = null)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (whiten != false)
                        pyDict["whiten"] = Helpers.ToPython(whiten);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    if (batch_size != null)
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    self = sklearn.decomposition.self.InvokeMethod("IncrementalPCA", args, pyDict);
                }

                internal IncrementalPCA(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static IncrementalPCA Encapsule(PyObject pyObject)
                {
                    return new IncrementalPCA(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray explained_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => Helpers.ToCSharpNDarray(self.GetAttr("singular_values_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public NDarray var_ => Helpers.ToCSharpNDarray(self.GetAttr("var_"));
                public float noise_variance_ => Helpers.ToCSharpFloat(self.GetAttr("noise_variance_"));
                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public int n_samples_seen_ => Helpers.ToCSharpInt(self.GetAttr("n_samples_seen_"));
                public int batch_size_ => Helpers.ToCSharpInt(self.GetAttr("batch_size_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public IncrementalPCA fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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

                public NDarray get_covariance()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_covariance", args, pyDict));
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

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public IncrementalPCA partial_fit(NDarray X, bool check_input = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (check_input != true)
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public IncrementalPCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public IncrementalPCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public IncrementalPCA set_partial_fit_request(string? check_input = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (check_input != "$UNCHANGED$")
                        pyDict["check_input"] = Helpers.ToPython(check_input);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class KernelPCA : PythonObject
            {
                public KernelPCA(int? n_components = null, string kernel = "linear", float? gamma = null, int degree = 3, int coef0 = 1, PyDict? kernel_params = null, float alpha = 1.0f, bool fit_inverse_transform = false, string eigen_solver = "auto", int tol = 0, int? max_iter = null, string iterated_power = "auto", bool remove_zero_eig = false, int? random_state = null, bool copy_X = true, int? n_jobs = null)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (kernel != "linear")
                        pyDict["kernel"] = Helpers.ToPython(kernel);
                    if (gamma != null)
                        pyDict["gamma"] = Helpers.ToPython(gamma);
                    if (degree != 3)
                        pyDict["degree"] = Helpers.ToPython(degree);
                    if (coef0 != 1)
                        pyDict["coef0"] = Helpers.ToPython(coef0);
                    if (kernel_params != null)
                        pyDict["kernel_params"] = Helpers.ToPython(kernel_params);
                    if (alpha != 1.0f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (fit_inverse_transform != false)
                        pyDict["fit_inverse_transform"] = Helpers.ToPython(fit_inverse_transform);
                    if (eigen_solver != "auto")
                        pyDict["eigen_solver"] = Helpers.ToPython(eigen_solver);
                    if (tol != 0)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (max_iter != null)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (iterated_power != "auto")
                        pyDict["iterated_power"] = Helpers.ToPython(iterated_power);
                    if (remove_zero_eig != false)
                        pyDict["remove_zero_eig"] = Helpers.ToPython(remove_zero_eig);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (copy_X != true)
                        pyDict["copy_X"] = Helpers.ToPython(copy_X);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    self = sklearn.decomposition.self.InvokeMethod("KernelPCA", args, pyDict);
                }

                internal KernelPCA(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static KernelPCA Encapsule(PyObject pyObject)
                {
                    return new KernelPCA(pyObject);
                }

                public NDarray eigenvalues_ => Helpers.ToCSharpNDarray(self.GetAttr("eigenvalues_"));
                public NDarray eigenvectors_ => Helpers.ToCSharpNDarray(self.GetAttr("eigenvectors_"));
                public NDarray dual_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_coef_"));
                public NDarray X_transformed_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("X_transformed_fit_"));
                public NDarray X_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("X_fit_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public float gamma_ => Helpers.ToCSharpFloat(self.GetAttr("gamma_"));

                public KernelPCA fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public KernelPCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public KernelPCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class LatentDirichletAllocation : PythonObject
            {
                public LatentDirichletAllocation(int n_components = 10, float? doc_topic_prior = null, float? topic_word_prior = null, string learning_method = "batch", float learning_decay = 0.7f, float learning_offset = 10.0f, int max_iter = 10, int batch_size = 128, int evaluate_every = -1, float total_samples = 1000000.0f, float perp_tol = 0.1f, float mean_change_tol = 0.001f, int max_doc_update_iter = 100, int? n_jobs = null, int verbose = 0, int? random_state = null)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 10)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (doc_topic_prior != null)
                        pyDict["doc_topic_prior"] = Helpers.ToPython(doc_topic_prior);
                    if (topic_word_prior != null)
                        pyDict["topic_word_prior"] = Helpers.ToPython(topic_word_prior);
                    if (learning_method != "batch")
                        pyDict["learning_method"] = Helpers.ToPython(learning_method);
                    if (learning_decay != 0.7f)
                        pyDict["learning_decay"] = Helpers.ToPython(learning_decay);
                    if (learning_offset != 10.0f)
                        pyDict["learning_offset"] = Helpers.ToPython(learning_offset);
                    if (max_iter != 10)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (batch_size != 128)
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    if (evaluate_every != -1)
                        pyDict["evaluate_every"] = Helpers.ToPython(evaluate_every);
                    if (total_samples != 1000000.0f)
                        pyDict["total_samples"] = Helpers.ToPython(total_samples);
                    if (perp_tol != 0.1f)
                        pyDict["perp_tol"] = Helpers.ToPython(perp_tol);
                    if (mean_change_tol != 0.001f)
                        pyDict["mean_change_tol"] = Helpers.ToPython(mean_change_tol);
                    if (max_doc_update_iter != 100)
                        pyDict["max_doc_update_iter"] = Helpers.ToPython(max_doc_update_iter);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("LatentDirichletAllocation", args, pyDict);
                }

                internal LatentDirichletAllocation(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static LatentDirichletAllocation Encapsule(PyObject pyObject)
                {
                    return new LatentDirichletAllocation(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray exp_dirichlet_component_ => Helpers.ToCSharpNDarray(self.GetAttr("exp_dirichlet_component_"));
                public int n_batch_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_batch_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public float bound_ => Helpers.ToCSharpFloat(self.GetAttr("bound_"));
                public float doc_topic_prior_ => Helpers.ToCSharpFloat(self.GetAttr("doc_topic_prior_"));
                public PyObject random_state_ => self.GetAttr("random_state_");
                public float topic_word_prior_ => Helpers.ToCSharpFloat(self.GetAttr("topic_word_prior_"));

                public LatentDirichletAllocation fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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

                public LatentDirichletAllocation partial_fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public float perplexity(NDarray X, bool sub_sampling = false)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (sub_sampling != false)
                        pyDict["sub_sampling"] = Helpers.ToPython(sub_sampling);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("perplexity", args, pyDict));
                }

                public float score(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LatentDirichletAllocation set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public LatentDirichletAllocation set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class MiniBatchDictionaryLearning : PythonObject
            {
                public MiniBatchDictionaryLearning(int? n_components = null, int alpha = 1, int max_iter = 1000, string fit_algorithm = "lars", int? n_jobs = null, int batch_size = 256, bool shuffle = true, NDarray? dict_init = null, string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, bool verbose = false, bool split_sign = false, int? random_state = null, bool positive_code = false, bool positive_dict = false, int transform_max_iter = 1000, PyObject? callback = null, float tol = 0.001f, int max_no_improvement = 10)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (alpha != 1)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (fit_algorithm != "lars")
                        pyDict["fit_algorithm"] = Helpers.ToPython(fit_algorithm);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (batch_size != 256)
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (dict_init != null)
                        pyDict["dict_init"] = Helpers.ToPython(dict_init);
                    if (transform_algorithm != "omp")
                        pyDict["transform_algorithm"] = Helpers.ToPython(transform_algorithm);
                    if (transform_n_nonzero_coefs != null)
                        pyDict["transform_n_nonzero_coefs"] = Helpers.ToPython(transform_n_nonzero_coefs);
                    if (transform_alpha != null)
                        pyDict["transform_alpha"] = Helpers.ToPython(transform_alpha);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (split_sign != false)
                        pyDict["split_sign"] = Helpers.ToPython(split_sign);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (positive_code != false)
                        pyDict["positive_code"] = Helpers.ToPython(positive_code);
                    if (positive_dict != false)
                        pyDict["positive_dict"] = Helpers.ToPython(positive_dict);
                    if (transform_max_iter != 1000)
                        pyDict["transform_max_iter"] = Helpers.ToPython(transform_max_iter);
                    if (callback != null)
                        pyDict["callback"] = Helpers.ToPython(callback);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (max_no_improvement != 10)
                        pyDict["max_no_improvement"] = Helpers.ToPython(max_no_improvement);
                    self = sklearn.decomposition.self.InvokeMethod("MiniBatchDictionaryLearning", args, pyDict);
                }

                internal MiniBatchDictionaryLearning(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static MiniBatchDictionaryLearning Encapsule(PyObject pyObject)
                {
                    return new MiniBatchDictionaryLearning(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_steps_ => Helpers.ToCSharpInt(self.GetAttr("n_steps_"));

                public MiniBatchDictionaryLearning fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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

                public MiniBatchDictionaryLearning partial_fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public MiniBatchDictionaryLearning set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MiniBatchDictionaryLearning set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class MiniBatchNMF : PythonObject
            {
                public MiniBatchNMF(string? n_components = "warn", PyObject? init = null, int batch_size = 1024, string beta_loss = "frobenius", float tol = 0.0001f, int max_no_improvement = 10, int max_iter = 200, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, float forget_factor = 0.7f, bool fresh_restarts = false, int fresh_restarts_max_iter = 30, int? transform_max_iter = null, int? random_state = null, int verbose = 0)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != "warn")
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (init != null)
                        pyDict["init"] = Helpers.ToPython(init);
                    if (batch_size != 1024)
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    if (beta_loss != "frobenius")
                        pyDict["beta_loss"] = Helpers.ToPython(beta_loss);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (max_no_improvement != 10)
                        pyDict["max_no_improvement"] = Helpers.ToPython(max_no_improvement);
                    if (max_iter != 200)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (alpha_W != 0.0f)
                        pyDict["alpha_W"] = Helpers.ToPython(alpha_W);
                    if (alpha_H != "same")
                        pyDict["alpha_H"] = Helpers.ToPython(alpha_H);
                    if (l1_ratio != 0.0f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (forget_factor != 0.7f)
                        pyDict["forget_factor"] = Helpers.ToPython(forget_factor);
                    if (fresh_restarts != false)
                        pyDict["fresh_restarts"] = Helpers.ToPython(fresh_restarts);
                    if (fresh_restarts_max_iter != 30)
                        pyDict["fresh_restarts_max_iter"] = Helpers.ToPython(fresh_restarts_max_iter);
                    if (transform_max_iter != null)
                        pyDict["transform_max_iter"] = Helpers.ToPython(transform_max_iter);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    self = sklearn.decomposition.self.InvokeMethod("MiniBatchNMF", args, pyDict);
                }

                internal MiniBatchNMF(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static MiniBatchNMF Encapsule(PyObject pyObject)
                {
                    return new MiniBatchNMF(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public float reconstruction_err_ => Helpers.ToCSharpFloat(self.GetAttr("reconstruction_err_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_steps_ => Helpers.ToCSharpInt(self.GetAttr("n_steps_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MiniBatchNMF fit(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? W = null, NDarray? H = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (W != null)
                        pyDict["W"] = Helpers.ToPython(W);
                    if (H != null)
                        pyDict["H"] = Helpers.ToPython(H);
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

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = Helpers.ToPython(X);
                    if (Xt != null)
                        pyDict["Xt"] = Helpers.ToPython(Xt);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public MiniBatchNMF partial_fit(NDarray X, NDarray? W = null, NDarray? H = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (W != null)
                        pyDict["W"] = Helpers.ToPython(W);
                    if (H != null)
                        pyDict["H"] = Helpers.ToPython(H);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public MiniBatchNMF set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MiniBatchNMF set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class MiniBatchSparsePCA : PythonObject
            {
                public MiniBatchSparsePCA(int? n_components = null, int alpha = 1, float ridge_alpha = 0.01f, int max_iter = 1000, PyObject? callback = null, int batch_size = 3, bool verbose = false, bool shuffle = true, int? n_jobs = null, string method = "lars", int? random_state = null, float tol = 0.001f, int? max_no_improvement = 10)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (alpha != 1)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (ridge_alpha != 0.01f)
                        pyDict["ridge_alpha"] = Helpers.ToPython(ridge_alpha);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (callback != null)
                        pyDict["callback"] = Helpers.ToPython(callback);
                    if (batch_size != 3)
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (method != "lars")
                        pyDict["method"] = Helpers.ToPython(method);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (tol != 0.001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (max_no_improvement != 10)
                        pyDict["max_no_improvement"] = Helpers.ToPython(max_no_improvement);
                    self = sklearn.decomposition.self.InvokeMethod("MiniBatchSparsePCA", args, pyDict);
                }

                internal MiniBatchSparsePCA(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static MiniBatchSparsePCA Encapsule(PyObject pyObject)
                {
                    return new MiniBatchSparsePCA(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MiniBatchSparsePCA fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public MiniBatchSparsePCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public MiniBatchSparsePCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class NMF : PythonObject
            {
                public NMF(string? n_components = "warn", PyObject? init = null, string solver = "cd", string beta_loss = "frobenius", float tol = 0.0001f, int max_iter = 200, int? random_state = null, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, int verbose = 0, bool shuffle = false)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != "warn")
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (init != null)
                        pyDict["init"] = Helpers.ToPython(init);
                    if (solver != "cd")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (beta_loss != "frobenius")
                        pyDict["beta_loss"] = Helpers.ToPython(beta_loss);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (max_iter != 200)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (alpha_W != 0.0f)
                        pyDict["alpha_W"] = Helpers.ToPython(alpha_W);
                    if (alpha_H != "same")
                        pyDict["alpha_H"] = Helpers.ToPython(alpha_H);
                    if (l1_ratio != 0.0f)
                        pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (shuffle != false)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    self = sklearn.decomposition.self.InvokeMethod("NMF", args, pyDict);
                }

                internal NMF(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static NMF Encapsule(PyObject pyObject)
                {
                    return new NMF(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public float reconstruction_err_ => Helpers.ToCSharpFloat(self.GetAttr("reconstruction_err_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NMF fit(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? W = null, NDarray? H = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (W != null)
                        pyDict["W"] = Helpers.ToPython(W);
                    if (H != null)
                        pyDict["H"] = Helpers.ToPython(H);
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

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = Helpers.ToPython(X);
                    if (Xt != null)
                        pyDict["Xt"] = Helpers.ToPython(Xt);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public NMF set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public NMF set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class PCA : PythonObject
            {
                public PCA(float? n_components = null, bool copy = true, bool whiten = false, string svd_solver = "auto", float tol = 0.0f, string iterated_power = "auto", int n_oversamples = 10, string power_iteration_normalizer = "auto", int? random_state = null)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    if (whiten != false)
                        pyDict["whiten"] = Helpers.ToPython(whiten);
                    if (svd_solver != "auto")
                        pyDict["svd_solver"] = Helpers.ToPython(svd_solver);
                    if (tol != 0.0f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (iterated_power != "auto")
                        pyDict["iterated_power"] = Helpers.ToPython(iterated_power);
                    if (n_oversamples != 10)
                        pyDict["n_oversamples"] = Helpers.ToPython(n_oversamples);
                    if (power_iteration_normalizer != "auto")
                        pyDict["power_iteration_normalizer"] = Helpers.ToPython(power_iteration_normalizer);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("PCA", args, pyDict);
                }

                internal PCA(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static PCA Encapsule(PyObject pyObject)
                {
                    return new PCA(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray explained_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => Helpers.ToCSharpNDarray(self.GetAttr("singular_values_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public int n_samples_ => Helpers.ToCSharpInt(self.GetAttr("n_samples_"));
                public float noise_variance_ => Helpers.ToCSharpFloat(self.GetAttr("noise_variance_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public PCA fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public NDarray get_covariance()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_covariance", args, pyDict));
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

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
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

                public PCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public PCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SparseCoder : PythonObject
            {
                public SparseCoder(NDarray dictionary, string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, bool split_sign = false, int? n_jobs = null, bool positive_code = false, int transform_max_iter = 1000)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(dictionary)]);
                    PyDict pyDict = new PyDict();
                    if (transform_algorithm != "omp")
                        pyDict["transform_algorithm"] = Helpers.ToPython(transform_algorithm);
                    if (transform_n_nonzero_coefs != null)
                        pyDict["transform_n_nonzero_coefs"] = Helpers.ToPython(transform_n_nonzero_coefs);
                    if (transform_alpha != null)
                        pyDict["transform_alpha"] = Helpers.ToPython(transform_alpha);
                    if (split_sign != false)
                        pyDict["split_sign"] = Helpers.ToPython(split_sign);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (positive_code != false)
                        pyDict["positive_code"] = Helpers.ToPython(positive_code);
                    if (transform_max_iter != 1000)
                        pyDict["transform_max_iter"] = Helpers.ToPython(transform_max_iter);
                    self = sklearn.decomposition.self.InvokeMethod("SparseCoder", args, pyDict);
                }

                internal SparseCoder(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static SparseCoder Encapsule(PyObject pyObject)
                {
                    return new SparseCoder(pyObject);
                }

                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SparseCoder fit()
                {
                    PyTuple args = new PyTuple();
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

                public SparseCoder set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SparseCoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SparsePCA : PythonObject
            {
                public SparsePCA(int? n_components = null, int alpha = 1, float ridge_alpha = 0.01f, int max_iter = 1000, float tol = 1e-08f, string method = "lars", int? n_jobs = null, NDarray? U_init = null, NDarray? V_init = null, bool verbose = false, int? random_state = null)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (alpha != 1)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (ridge_alpha != 0.01f)
                        pyDict["ridge_alpha"] = Helpers.ToPython(ridge_alpha);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (tol != 1e-08f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (method != "lars")
                        pyDict["method"] = Helpers.ToPython(method);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (U_init != null)
                        pyDict["U_init"] = Helpers.ToPython(U_init);
                    if (V_init != null)
                        pyDict["V_init"] = Helpers.ToPython(V_init);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.decomposition.self.InvokeMethod("SparsePCA", args, pyDict);
                }

                internal SparsePCA(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static SparsePCA Encapsule(PyObject pyObject)
                {
                    return new SparsePCA(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray error_ => Helpers.ToCSharpNDarray(self.GetAttr("error_"));
                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SparsePCA fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SparsePCA set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SparsePCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class TruncatedSVD : PythonObject
            {
                public TruncatedSVD(int n_components = 2, string algorithm = "randomized", int n_iter = 5, int n_oversamples = 10, string power_iteration_normalizer = "auto", int? random_state = null, float tol = 0.0f)
                {
                    _ = sklearn.decomposition.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 2)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (algorithm != "randomized")
                        pyDict["algorithm"] = Helpers.ToPython(algorithm);
                    if (n_iter != 5)
                        pyDict["n_iter"] = Helpers.ToPython(n_iter);
                    if (n_oversamples != 10)
                        pyDict["n_oversamples"] = Helpers.ToPython(n_oversamples);
                    if (power_iteration_normalizer != "auto")
                        pyDict["power_iteration_normalizer"] = Helpers.ToPython(power_iteration_normalizer);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (tol != 0.0f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    self = sklearn.decomposition.self.InvokeMethod("TruncatedSVD", args, pyDict);
                }

                internal TruncatedSVD(PyObject pyObject)
                {
                    _ = sklearn.decomposition.self;
                    self = pyObject;
                }

                public static TruncatedSVD Encapsule(PyObject pyObject)
                {
                    return new TruncatedSVD(pyObject);
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray explained_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => Helpers.ToCSharpNDarray(self.GetAttr("singular_values_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public TruncatedSVD fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
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

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public TruncatedSVD set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public TruncatedSVD set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public static (NDarray? , PyDict? , NDarray? , int? ) dict_learning(NDarray X, int n_components, float alpha, int max_iter = 100, float tol = 1e-08f, string method = "lars", int? n_jobs = null, NDarray? dict_init = null, NDarray? code_init = null, PyObject? callback = null, bool verbose = false, int? random_state = null, bool return_n_iter = false, bool positive_dict = false, bool positive_code = false, int method_max_iter = 1000)
            {
                _ = sklearn.decomposition.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(n_components), Helpers.ToPython(alpha)]);
                PyDict pyDict = new PyDict();
                if (max_iter != 100)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 1e-08f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (method != "lars")
                    pyDict["method"] = Helpers.ToPython(method);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (dict_init != null)
                    pyDict["dict_init"] = Helpers.ToPython(dict_init);
                if (code_init != null)
                    pyDict["code_init"] = Helpers.ToPython(code_init);
                if (callback != null)
                    pyDict["callback"] = Helpers.ToPython(callback);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                if (positive_dict != false)
                    pyDict["positive_dict"] = Helpers.ToPython(positive_dict);
                if (positive_code != false)
                    pyDict["positive_code"] = Helpers.ToPython(positive_code);
                if (method_max_iter != 1000)
                    pyDict["method_max_iter"] = Helpers.ToPython(method_max_iter);
                PyTuple result = new PyTuple(sklearn.decomposition.self.InvokeMethod("dict_learning", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpPyDict(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpInt(result[3]) : null);
            }

            public static (NDarray? , PyDict? , int? ) dict_learning_online(NDarray X, int? n_components = 2, int alpha = 1, int max_iter = 100, bool return_code = true, NDarray? dict_init = null, PyObject? callback = null, int batch_size = 256, bool verbose = false, bool shuffle = true, int? n_jobs = null, string method = "lars", int? random_state = null, bool positive_dict = false, bool positive_code = false, int method_max_iter = 1000, float tol = 0.001f, int max_no_improvement = 10)
            {
                _ = sklearn.decomposition.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (alpha != 1)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (max_iter != 100)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (return_code != true)
                    pyDict["return_code"] = Helpers.ToPython(return_code);
                if (dict_init != null)
                    pyDict["dict_init"] = Helpers.ToPython(dict_init);
                if (callback != null)
                    pyDict["callback"] = Helpers.ToPython(callback);
                if (batch_size != 256)
                    pyDict["batch_size"] = Helpers.ToPython(batch_size);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (shuffle != true)
                    pyDict["shuffle"] = Helpers.ToPython(shuffle);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (method != "lars")
                    pyDict["method"] = Helpers.ToPython(method);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (positive_dict != false)
                    pyDict["positive_dict"] = Helpers.ToPython(positive_dict);
                if (positive_code != false)
                    pyDict["positive_code"] = Helpers.ToPython(positive_code);
                if (method_max_iter != 1000)
                    pyDict["method_max_iter"] = Helpers.ToPython(method_max_iter);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (max_no_improvement != 10)
                    pyDict["max_no_improvement"] = Helpers.ToPython(max_no_improvement);
                PyTuple result = new PyTuple(sklearn.decomposition.self.InvokeMethod("dict_learning_online", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpPyDict(result[1]) : null, __length > 2 ? Helpers.ToCSharpInt(result[2]) : null);
            }

            public static (NDarray ?? ,  NDarray ? ,  NDarray ?? ,  NDarray ? ,  int ? )fastica(NDarray X, int? n_components = null, string algorithm = "parallel", string whiten = "unit-variance", string fun = "logcosh", PyDict? fun_args = null, int max_iter = 200, float tol = 0.0001f, NDarray? w_init = null, string whiten_solver = "svd", int? random_state = null, bool return_X_mean = false, bool compute_sources = true, bool return_n_iter = false)
            {
                _ = sklearn.decomposition.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (n_components != null)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (algorithm != "parallel")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (whiten != "unit-variance")
                    pyDict["whiten"] = Helpers.ToPython(whiten);
                if (fun != "logcosh")
                    pyDict["fun"] = Helpers.ToPython(fun);
                if (fun_args != null)
                    pyDict["fun_args"] = Helpers.ToPython(fun_args);
                if (max_iter != 200)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (w_init != null)
                    pyDict["w_init"] = Helpers.ToPython(w_init);
                if (whiten_solver != "svd")
                    pyDict["whiten_solver"] = Helpers.ToPython(whiten_solver);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (return_X_mean != false)
                    pyDict["return_X_mean"] = Helpers.ToPython(return_X_mean);
                if (compute_sources != true)
                    pyDict["compute_sources"] = Helpers.ToPython(compute_sources);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
                PyTuple result = new PyTuple(sklearn.decomposition.self.InvokeMethod("fastica", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpNDarray(result[3]) : null, __length > 4 ? Helpers.ToCSharpInt(result[4]) : null);
            }

            public static (NDarray? , NDarray? , int? ) non_negative_factorization(NDarray X, NDarray? W = null, NDarray? H = null, string? n_components = "warn", PyObject? init = null, bool update_H = true, string solver = "cd", string beta_loss = "frobenius", float tol = 0.0001f, int max_iter = 200, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, int? random_state = null, int verbose = 0, bool shuffle = false)
            {
                _ = sklearn.decomposition.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (W != null)
                    pyDict["W"] = Helpers.ToPython(W);
                if (H != null)
                    pyDict["H"] = Helpers.ToPython(H);
                if (n_components != "warn")
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (init != null)
                    pyDict["init"] = Helpers.ToPython(init);
                if (update_H != true)
                    pyDict["update_H"] = Helpers.ToPython(update_H);
                if (solver != "cd")
                    pyDict["solver"] = Helpers.ToPython(solver);
                if (beta_loss != "frobenius")
                    pyDict["beta_loss"] = Helpers.ToPython(beta_loss);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (max_iter != 200)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (alpha_W != 0.0f)
                    pyDict["alpha_W"] = Helpers.ToPython(alpha_W);
                if (alpha_H != "same")
                    pyDict["alpha_H"] = Helpers.ToPython(alpha_H);
                if (l1_ratio != 0.0f)
                    pyDict["l1_ratio"] = Helpers.ToPython(l1_ratio);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (shuffle != false)
                    pyDict["shuffle"] = Helpers.ToPython(shuffle);
                PyTuple result = new PyTuple(sklearn.decomposition.self.InvokeMethod("non_negative_factorization", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpInt(result[2]) : null);
            }

            public static NDarray sparse_encode(NDarray X, NDarray dictionary, NDarray? gram = null, NDarray? cov = null, string algorithm = "lasso_lars", int? n_nonzero_coefs = null, float? alpha = null, bool copy_cov = true, NDarray? init = null, int max_iter = 1000, int? n_jobs = null, bool check_input = true, int verbose = 0, bool positive = false)
            {
                _ = sklearn.decomposition.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(dictionary)]);
                PyDict pyDict = new PyDict();
                if (gram != null)
                    pyDict["gram"] = Helpers.ToPython(gram);
                if (cov != null)
                    pyDict["cov"] = Helpers.ToPython(cov);
                if (algorithm != "lasso_lars")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (n_nonzero_coefs != null)
                    pyDict["n_nonzero_coefs"] = Helpers.ToPython(n_nonzero_coefs);
                if (alpha != null)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (copy_cov != true)
                    pyDict["copy_cov"] = Helpers.ToPython(copy_cov);
                if (init != null)
                    pyDict["init"] = Helpers.ToPython(init);
                if (max_iter != 1000)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (positive != false)
                    pyDict["positive"] = Helpers.ToPython(positive);
                return Helpers.ToCSharpNDarray(sklearn.decomposition.self.InvokeMethod("sparse_encode", args, pyDict));
            }
        }
    }
}