using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class neural_network
    {
        // Classes
        public class BernoulliRBM
        {
            // Constructor
            public BernoulliRBM(int n_components = 256, float learning_rate = 0.1f, int batch_size = 10, int n_iter = 10, int verbose = 0, int? random_state = null)
            {
            }

            // Properties
            public NDarray intercept_hidden_ => default !;
            public NDarray intercept_visible_ => default !;
            public NDarray components_ => default !;
            public NDarray h_samples_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            [ReturnThis]
            public BernoulliRBM fit(NDarray X, NDarray? y = null) => default !;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public NDarray gibbs(NDarray v) => default !;
            [ReturnThis]
            public BernoulliRBM partial_fit(NDarray X, NDarray? y = null) => default !;
            public NDarray score_samples(NDarray X) => default !;
            [ReturnThis]
            public BernoulliRBM set_output(PyObject? transform = null) => default !;
            [ReturnThis]
            public BernoulliRBM set_params(Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray transform(NDarray X) => default !;
        }

        public class MLPClassifier
        {
            // Constructor
            public MLPClassifier(PyTuple? hidden_layer_sizes = null, string activation = "relu", string solver = "adam", float alpha = 0.0001f, string batch_size = "auto", string learning_rate = "constant", float learning_rate_init = 0.001f, float power_t = 0.5f, int max_iter = 200, bool shuffle = true, int? random_state = null, float tol = 0.0001f, bool verbose = false, bool warm_start = false, float momentum = 0.9f, bool nesterovs_momentum = true, bool early_stopping = false, float validation_fraction = 0.1f, float beta_1 = 0.9f, float beta_2 = 0.999f, float epsilon = 1e-08f, int n_iter_no_change = 10, int max_fun = 15000)
            {
            }

            // Properties
            public NDarray classes_ => default !;
            public float loss_ => default !;
            public float best_loss_ => default !;
            public NDarray loss_curve_ => default !;
            public NDarray validation_scores_ => default !;
            public float best_validation_score_ => default !;
            public int t_ => default !;
            public NDarray coefs_ => default !;
            public NDarray intercepts_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_iter_ => default !;
            public int n_layers_ => default !;
            public int n_outputs_ => default !;
            public string out_activation_ => default !;

            // Methods
            [ReturnThis]
            public MLPClassifier fit(NDarray X, NDarray y) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            [ReturnThis]
            public MLPClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null) => default !;
            public NDarray predict(NDarray X) => default !;
            public NDarray predict_log_proba(NDarray X) => default !;
            public NDarray predict_proba(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public MLPClassifier set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public MLPClassifier set_partial_fit_request(string? classes = "$UNCHANGED$") => default !;
            [ReturnThis]
            public MLPClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class MLPRegressor
        {
            // Constructor
            public MLPRegressor(PyTuple? hidden_layer_sizes = null, string activation = "relu", string solver = "adam", float alpha = 0.0001f, string batch_size = "auto", string learning_rate = "constant", float learning_rate_init = 0.001f, float power_t = 0.5f, int max_iter = 200, bool shuffle = true, int? random_state = null, float tol = 0.0001f, bool verbose = false, bool warm_start = false, float momentum = 0.9f, bool nesterovs_momentum = true, bool early_stopping = false, float validation_fraction = 0.1f, float beta_1 = 0.9f, float beta_2 = 0.999f, float epsilon = 1e-08f, int n_iter_no_change = 10, int max_fun = 15000)
            {
            }

            // Properties
            public float loss_ => default !;
            public float best_loss_ => default !;
            public NDarray loss_curve_ => default !;
            public NDarray validation_scores_ => default !;
            public float best_validation_score_ => default !;
            public int t_ => default !;
            public NDarray coefs_ => default !;
            public NDarray intercepts_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_iter_ => default !;
            public int n_layers_ => default !;
            public int n_outputs_ => default !;
            public string out_activation_ => default !;

            // Methods
            [ReturnThis]
            public MLPRegressor fit(NDarray X, NDarray y) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            [ReturnThis]
            public MLPRegressor partial_fit(NDarray X, NDarray y) => default !;
            public NDarray predict(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public MLPRegressor set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public MLPRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }
    }
}