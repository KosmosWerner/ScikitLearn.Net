namespace ScikitLearn;
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
                PyTuple args = new PyTuple(new PyObject[] { });
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

            public static BernoulliRBM Encapsule(PyObject pyObject) => new BernoulliRBM(pyObject);
            public NDarray intercept_hidden_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray intercept_visible_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray components_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray h_samples_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public BernoulliRBM fit(NDarray X, NDarray? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray gibbs(NDarray v)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(v) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public BernoulliRBM partial_fit(NDarray X, NDarray? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                throw new NotImplementedException();
            }

            public NDarray score_samples(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public BernoulliRBM set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public BernoulliRBM set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }

        public class MLPClassifier : PythonObject
        {
            public MLPClassifier(PyTuple? hidden_layer_sizes = null, string activation = "relu", string solver = "adam", float alpha = 0.0001f, string batch_size = "auto", string learning_rate = "constant", float learning_rate_init = 0.001f, float power_t = 0.5f, int max_iter = 200, bool shuffle = true, int? random_state = null, float tol = 0.0001f, bool verbose = false, bool warm_start = false, float momentum = 0.9f, bool nesterovs_momentum = true, bool early_stopping = false, float validation_fraction = 0.1f, float beta_1 = 0.9f, float beta_2 = 0.999f, float epsilon = 1e-08f, int n_iter_no_change = 10, int max_fun = 15000)
            {
                _ = sklearn.neural_network.self;
                PyTuple args = new PyTuple(new PyObject[] { });
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

            public static MLPClassifier Encapsule(PyObject pyObject) => new MLPClassifier(pyObject);
            public NDarray classes_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float loss_
            {
                get
                {
                    return self.GetAttr("loss_").As<float>();
                }
            }

            public float best_loss_
            {
                get
                {
                    return self.GetAttr("best_loss_").As<float>();
                }
            }

            public NDarray loss_curve_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray validation_scores_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float best_validation_score_
            {
                get
                {
                    return self.GetAttr("best_validation_score_").As<float>();
                }
            }

            public int t_
            {
                get
                {
                    return self.GetAttr("t_").As<int>();
                }
            }

            public NDarray coefs_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray intercepts_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_iter_
            {
                get
                {
                    return self.GetAttr("n_iter_").As<int>();
                }
            }

            public int n_layers_
            {
                get
                {
                    return self.GetAttr("n_layers_").As<int>();
                }
            }

            public int n_outputs_
            {
                get
                {
                    return self.GetAttr("n_outputs_").As<int>();
                }
            }

            public string out_activation_
            {
                get
                {
                    return self.GetAttr("out_activation_").As<string>();
                }
            }

            public MLPClassifier fit(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public MLPClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public MLPClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public MLPClassifier set_partial_fit_request(string? classes = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                throw new NotImplementedException();
            }

            public MLPClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }

        public class MLPRegressor : PythonObject
        {
            public MLPRegressor(PyTuple? hidden_layer_sizes = null, string activation = "relu", string solver = "adam", float alpha = 0.0001f, string batch_size = "auto", string learning_rate = "constant", float learning_rate_init = 0.001f, float power_t = 0.5f, int max_iter = 200, bool shuffle = true, int? random_state = null, float tol = 0.0001f, bool verbose = false, bool warm_start = false, float momentum = 0.9f, bool nesterovs_momentum = true, bool early_stopping = false, float validation_fraction = 0.1f, float beta_1 = 0.9f, float beta_2 = 0.999f, float epsilon = 1e-08f, int n_iter_no_change = 10, int max_fun = 15000)
            {
                _ = sklearn.neural_network.self;
                PyTuple args = new PyTuple(new PyObject[] { });
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

            public static MLPRegressor Encapsule(PyObject pyObject) => new MLPRegressor(pyObject);
            public float loss_
            {
                get
                {
                    return self.GetAttr("loss_").As<float>();
                }
            }

            public float best_loss_
            {
                get
                {
                    return self.GetAttr("best_loss_").As<float>();
                }
            }

            public NDarray loss_curve_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray validation_scores_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float best_validation_score_
            {
                get
                {
                    return self.GetAttr("best_validation_score_").As<float>();
                }
            }

            public int t_
            {
                get
                {
                    return self.GetAttr("t_").As<int>();
                }
            }

            public NDarray coefs_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray intercepts_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_iter_
            {
                get
                {
                    return self.GetAttr("n_iter_").As<int>();
                }
            }

            public int n_layers_
            {
                get
                {
                    return self.GetAttr("n_layers_").As<int>();
                }
            }

            public int n_outputs_
            {
                get
                {
                    return self.GetAttr("n_outputs_").As<int>();
                }
            }

            public string out_activation_
            {
                get
                {
                    return self.GetAttr("out_activation_").As<string>();
                }
            }

            public MLPRegressor fit(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public MLPRegressor partial_fit(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public MLPRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public MLPRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }
    }
}