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
            public class BernoulliRBM
            {
                public BernoulliRBM(int n_components = 256, float learning_rate = 0.1f, int batch_size = 10, int n_iter = 10, int verbose = 0, int? random_state = null)
                {
                }

                public NDarray intercept_hidden_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_hidden_"));
                public NDarray intercept_visible_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_visible_"));
                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray h_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("h_samples_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public BernoulliRBM fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray gibbs(NDarray v)
                {
                    throw new NotImplementedException();
                }

                public BernoulliRBM partial_fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public BernoulliRBM set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public BernoulliRBM set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MLPClassifier
            {
                public MLPClassifier(PyTuple? hidden_layer_sizes = null, string activation = "relu", string solver = "adam", float alpha = 0.0001f, string batch_size = "auto", string learning_rate = "constant", float learning_rate_init = 0.001f, float power_t = 0.5f, int max_iter = 200, bool shuffle = true, int? random_state = null, float tol = 0.0001f, bool verbose = false, bool warm_start = false, float momentum = 0.9f, bool nesterovs_momentum = true, bool early_stopping = false, float validation_fraction = 0.1f, float beta_1 = 0.9f, float beta_2 = 0.999f, float epsilon = 1e-08f, int n_iter_no_change = 10, int max_fun = 15000)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public float loss_ => Helpers.ToCSharpNDarray(self.GetAttr("loss_"));
                public float best_loss_ => Helpers.ToCSharpNDarray(self.GetAttr("best_loss_"));
                public NDarray loss_curve_ => Helpers.ToCSharpNDarray(self.GetAttr("loss_curve_"));
                public NDarray validation_scores_ => Helpers.ToCSharpNDarray(self.GetAttr("validation_scores_"));
                public float best_validation_score_ => Helpers.ToCSharpNDarray(self.GetAttr("best_validation_score_"));
                public int t_ => Helpers.ToCSharpNDarray(self.GetAttr("t_"));
                public NDarray coefs_ => Helpers.ToCSharpNDarray(self.GetAttr("coefs_"));
                public NDarray intercepts_ => Helpers.ToCSharpNDarray(self.GetAttr("intercepts_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_layers_ => Helpers.ToCSharpNDarray(self.GetAttr("n_layers_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public string out_activation_ => Helpers.ToCSharpNDarray(self.GetAttr("out_activation_"));

                public MLPClassifier fit(NDarray X, NDarray y)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public MLPClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public MLPClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public MLPClassifier set_partial_fit_request(string? classes = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public MLPClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class MLPRegressor
            {
                public MLPRegressor(PyTuple? hidden_layer_sizes = null, string activation = "relu", string solver = "adam", float alpha = 0.0001f, string batch_size = "auto", string learning_rate = "constant", float learning_rate_init = 0.001f, float power_t = 0.5f, int max_iter = 200, bool shuffle = true, int? random_state = null, float tol = 0.0001f, bool verbose = false, bool warm_start = false, float momentum = 0.9f, bool nesterovs_momentum = true, bool early_stopping = false, float validation_fraction = 0.1f, float beta_1 = 0.9f, float beta_2 = 0.999f, float epsilon = 1e-08f, int n_iter_no_change = 10, int max_fun = 15000)
                {
                }

                public float loss_ => Helpers.ToCSharpNDarray(self.GetAttr("loss_"));
                public float best_loss_ => Helpers.ToCSharpNDarray(self.GetAttr("best_loss_"));
                public NDarray loss_curve_ => Helpers.ToCSharpNDarray(self.GetAttr("loss_curve_"));
                public NDarray validation_scores_ => Helpers.ToCSharpNDarray(self.GetAttr("validation_scores_"));
                public float best_validation_score_ => Helpers.ToCSharpNDarray(self.GetAttr("best_validation_score_"));
                public int t_ => Helpers.ToCSharpNDarray(self.GetAttr("t_"));
                public NDarray coefs_ => Helpers.ToCSharpNDarray(self.GetAttr("coefs_"));
                public NDarray intercepts_ => Helpers.ToCSharpNDarray(self.GetAttr("intercepts_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_layers_ => Helpers.ToCSharpNDarray(self.GetAttr("n_layers_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public string out_activation_ => Helpers.ToCSharpNDarray(self.GetAttr("out_activation_"));

                public MLPRegressor fit(NDarray X, NDarray y)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public MLPRegressor partial_fit(NDarray X, NDarray y)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public MLPRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public MLPRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}