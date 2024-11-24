using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class neural_network
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
                return Py.Import("sklearn.neural_network");
            }

            static neural_network()
            {
                ReInitializeLazySelf();
            }

            public class BernoulliRBM : PythonObject
            {
                public BernoulliRBM(int n_components = 256, float learning_rate = 0.1f, int batch_size = 10, int n_iter = 10, int verbose = 0, int? random_state = null)
                {
                    _ = sklearn.neural_network.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 256)
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (learning_rate != 0.1f)
                        pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                    if (batch_size != 10)
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    if (n_iter != 10)
                        pyDict["n_iter"] = Helpers.ToPython(n_iter);
                    if (verbose != 0)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.neural_network.self.InvokeMethod("BernoulliRBM", args, pyDict);
                }

                internal BernoulliRBM(PyObject pyObject)
                {
                    _ = sklearn.neural_network.self;
                    self = pyObject;
                }

                public static BernoulliRBM Encapsule(PyObject pyObject)
                {
                    return new BernoulliRBM(pyObject);
                }

                public NDarray intercept_hidden_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_hidden_"));
                public NDarray intercept_visible_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_visible_"));
                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray h_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("h_samples_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public BernoulliRBM fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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

                public NDarray gibbs(NDarray v)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(v)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("gibbs", args, pyDict));
                }

                public BernoulliRBM partial_fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("score_samples", args, pyDict));
                }

                public BernoulliRBM set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public BernoulliRBM set_params(Dictionary<string, PyObject>? @params = null)
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

            public class MLPClassifier : PythonObject
            {
                public MLPClassifier(PyTuple? hidden_layer_sizes = null, string activation = "relu", string solver = "adam", float alpha = 0.0001f, string batch_size = "auto", string learning_rate = "constant", float learning_rate_init = 0.001f, float power_t = 0.5f, int max_iter = 200, bool shuffle = true, int? random_state = null, float tol = 0.0001f, bool verbose = false, bool warm_start = false, float momentum = 0.9f, bool nesterovs_momentum = true, bool early_stopping = false, float validation_fraction = 0.1f, float beta_1 = 0.9f, float beta_2 = 0.999f, float epsilon = 1e-08f, int n_iter_no_change = 10, int max_fun = 15000)
                {
                    _ = sklearn.neural_network.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (hidden_layer_sizes != null)
                        pyDict["hidden_layer_sizes"] = Helpers.ToPython(hidden_layer_sizes);
                    if (activation != "relu")
                        pyDict["activation"] = Helpers.ToPython(activation);
                    if (solver != "adam")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (alpha != 0.0001f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (batch_size != "auto")
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    if (learning_rate != "constant")
                        pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                    if (learning_rate_init != 0.001f)
                        pyDict["learning_rate_init"] = Helpers.ToPython(learning_rate_init);
                    if (power_t != 0.5f)
                        pyDict["power_t"] = Helpers.ToPython(power_t);
                    if (max_iter != 200)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (momentum != 0.9f)
                        pyDict["momentum"] = Helpers.ToPython(momentum);
                    if (nesterovs_momentum != true)
                        pyDict["nesterovs_momentum"] = Helpers.ToPython(nesterovs_momentum);
                    if (early_stopping != false)
                        pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                    if (beta_1 != 0.9f)
                        pyDict["beta_1"] = Helpers.ToPython(beta_1);
                    if (beta_2 != 0.999f)
                        pyDict["beta_2"] = Helpers.ToPython(beta_2);
                    if (epsilon != 1e-08f)
                        pyDict["epsilon"] = Helpers.ToPython(epsilon);
                    if (n_iter_no_change != 10)
                        pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                    if (max_fun != 15000)
                        pyDict["max_fun"] = Helpers.ToPython(max_fun);
                    self = sklearn.neural_network.self.InvokeMethod("MLPClassifier", args, pyDict);
                }

                internal MLPClassifier(PyObject pyObject)
                {
                    _ = sklearn.neural_network.self;
                    self = pyObject;
                }

                public static MLPClassifier Encapsule(PyObject pyObject)
                {
                    return new MLPClassifier(pyObject);
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public float loss_ => Helpers.ToCSharpFloat(self.GetAttr("loss_"));
                public float best_loss_ => Helpers.ToCSharpFloat(self.GetAttr("best_loss_"));
                public NDarray loss_curve_ => Helpers.ToCSharpNDarray(self.GetAttr("loss_curve_"));
                public NDarray validation_scores_ => Helpers.ToCSharpNDarray(self.GetAttr("validation_scores_"));
                public float best_validation_score_ => Helpers.ToCSharpFloat(self.GetAttr("best_validation_score_"));
                public int t_ => Helpers.ToCSharpInt(self.GetAttr("t_"));
                public NDarray coefs_ => Helpers.ToCSharpNDarray(self.GetAttr("coefs_"));
                public NDarray intercepts_ => Helpers.ToCSharpNDarray(self.GetAttr("intercepts_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_layers_ => Helpers.ToCSharpInt(self.GetAttr("n_layers_"));
                public int n_outputs_ => Helpers.ToCSharpInt(self.GetAttr("n_outputs_"));
                public string out_activation_ => Helpers.ToCSharpString(self.GetAttr("out_activation_"));

                public MLPClassifier fit(NDarray X, NDarray y)
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

                public MLPClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null)
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

                public MLPClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public MLPClassifier set_partial_fit_request(string? classes = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (classes != "$UNCHANGED$")
                        pyDict["classes"] = Helpers.ToPython(classes);
                    self.InvokeMethod("set_partial_fit_request", args, pyDict);
                    return this;
                }

                public MLPClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class MLPRegressor : PythonObject
            {
                public MLPRegressor(PyTuple? hidden_layer_sizes = null, string activation = "relu", string solver = "adam", float alpha = 0.0001f, string batch_size = "auto", string learning_rate = "constant", float learning_rate_init = 0.001f, float power_t = 0.5f, int max_iter = 200, bool shuffle = true, int? random_state = null, float tol = 0.0001f, bool verbose = false, bool warm_start = false, float momentum = 0.9f, bool nesterovs_momentum = true, bool early_stopping = false, float validation_fraction = 0.1f, float beta_1 = 0.9f, float beta_2 = 0.999f, float epsilon = 1e-08f, int n_iter_no_change = 10, int max_fun = 15000)
                {
                    _ = sklearn.neural_network.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (hidden_layer_sizes != null)
                        pyDict["hidden_layer_sizes"] = Helpers.ToPython(hidden_layer_sizes);
                    if (activation != "relu")
                        pyDict["activation"] = Helpers.ToPython(activation);
                    if (solver != "adam")
                        pyDict["solver"] = Helpers.ToPython(solver);
                    if (alpha != 0.0001f)
                        pyDict["alpha"] = Helpers.ToPython(alpha);
                    if (batch_size != "auto")
                        pyDict["batch_size"] = Helpers.ToPython(batch_size);
                    if (learning_rate != "constant")
                        pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                    if (learning_rate_init != 0.001f)
                        pyDict["learning_rate_init"] = Helpers.ToPython(learning_rate_init);
                    if (power_t != 0.5f)
                        pyDict["power_t"] = Helpers.ToPython(power_t);
                    if (max_iter != 200)
                        pyDict["max_iter"] = Helpers.ToPython(max_iter);
                    if (shuffle != true)
                        pyDict["shuffle"] = Helpers.ToPython(shuffle);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (tol != 0.0001f)
                        pyDict["tol"] = Helpers.ToPython(tol);
                    if (verbose != false)
                        pyDict["verbose"] = Helpers.ToPython(verbose);
                    if (warm_start != false)
                        pyDict["warm_start"] = Helpers.ToPython(warm_start);
                    if (momentum != 0.9f)
                        pyDict["momentum"] = Helpers.ToPython(momentum);
                    if (nesterovs_momentum != true)
                        pyDict["nesterovs_momentum"] = Helpers.ToPython(nesterovs_momentum);
                    if (early_stopping != false)
                        pyDict["early_stopping"] = Helpers.ToPython(early_stopping);
                    if (validation_fraction != 0.1f)
                        pyDict["validation_fraction"] = Helpers.ToPython(validation_fraction);
                    if (beta_1 != 0.9f)
                        pyDict["beta_1"] = Helpers.ToPython(beta_1);
                    if (beta_2 != 0.999f)
                        pyDict["beta_2"] = Helpers.ToPython(beta_2);
                    if (epsilon != 1e-08f)
                        pyDict["epsilon"] = Helpers.ToPython(epsilon);
                    if (n_iter_no_change != 10)
                        pyDict["n_iter_no_change"] = Helpers.ToPython(n_iter_no_change);
                    if (max_fun != 15000)
                        pyDict["max_fun"] = Helpers.ToPython(max_fun);
                    self = sklearn.neural_network.self.InvokeMethod("MLPRegressor", args, pyDict);
                }

                internal MLPRegressor(PyObject pyObject)
                {
                    _ = sklearn.neural_network.self;
                    self = pyObject;
                }

                public static MLPRegressor Encapsule(PyObject pyObject)
                {
                    return new MLPRegressor(pyObject);
                }

                public float loss_ => Helpers.ToCSharpFloat(self.GetAttr("loss_"));
                public float best_loss_ => Helpers.ToCSharpFloat(self.GetAttr("best_loss_"));
                public NDarray loss_curve_ => Helpers.ToCSharpNDarray(self.GetAttr("loss_curve_"));
                public NDarray validation_scores_ => Helpers.ToCSharpNDarray(self.GetAttr("validation_scores_"));
                public float best_validation_score_ => Helpers.ToCSharpFloat(self.GetAttr("best_validation_score_"));
                public int t_ => Helpers.ToCSharpInt(self.GetAttr("t_"));
                public NDarray coefs_ => Helpers.ToCSharpNDarray(self.GetAttr("coefs_"));
                public NDarray intercepts_ => Helpers.ToCSharpNDarray(self.GetAttr("intercepts_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_layers_ => Helpers.ToCSharpInt(self.GetAttr("n_layers_"));
                public int n_outputs_ => Helpers.ToCSharpInt(self.GetAttr("n_outputs_"));
                public string out_activation_ => Helpers.ToCSharpString(self.GetAttr("out_activation_"));

                public MLPRegressor fit(NDarray X, NDarray y)
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

                public MLPRegressor partial_fit(NDarray X, NDarray y)
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

                public MLPRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public MLPRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
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