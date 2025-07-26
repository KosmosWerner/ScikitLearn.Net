using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class linear_model
    {
        // Methods
        public static (NDarray?, NDarray?, NDarray?, PyTuple?) enet_path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null) => default!;
        public static (NDarray?, NDarray?, NDarray?, int?) lars_path(NDarray X, NDarray y, NDarray? Xy = null, NDarray? Gram = null, int max_iter = 500, int alpha_min = 0, string method = "lar", bool copy_X = true, float eps = float.Epsilon, bool copy_Gram = true, int verbose = 0, bool return_path = true, bool return_n_iter = false, bool positive = false) => default!;
        public static (NDarray?, NDarray?, NDarray?, int?) lars_path_gram(NDarray Xy, NDarray Gram, int n_samples, int max_iter = 500, int alpha_min = 0, string method = "lar", bool copy_X = true, float eps = float.Epsilon, bool copy_Gram = true, int verbose = 0, bool return_path = true, bool return_n_iter = false, bool positive = false) => default!;
        public static (NDarray?, NDarray?, NDarray?, PyTuple?) lasso_path(NDarray X, NDarray y, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, Dictionary<string, PyObject>? @params = null) => default!;
        public static (NDarray?, NDarray?) orthogonal_mp(NDarray X, NDarray y, int? n_nonzero_coefs = null, float? tol = null, bool precompute = false, bool copy_X = true, bool return_path = false, bool return_n_iter = false) => default!;
        public static (NDarray?, int?) orthogonal_mp_gram(NDarray Gram, NDarray Xy, int? n_nonzero_coefs = null, float? tol = null, NDarray? norms_squared = null, bool copy_Gram = true, bool copy_Xy = true, bool return_path = false, bool return_n_iter = false) => default!;
        public static (NDarray?, int?, NDarray?) ridge_regression(NDarray X, NDarray y, NDarray alpha, NDarray? sample_weight = null, string solver = "auto", int? max_iter = null, float tol = 0.0001f, int verbose = 0, bool positive = false, int? random_state = null, bool return_n_iter = false, bool return_intercept = false, bool check_input = true) => default!;
        // Classes
        public class LogisticRegression
        {
            // Constructor
            public LogisticRegression(string? penalty = "l2", bool dual = false, float tol = 0.0001f, float C = 1.0f, bool fit_intercept = true, int intercept_scaling = 1, PyDict? class_weight = null, int? random_state = null, string solver = "lbfgs", int max_iter = 100, string multi_class = "deprecated", int verbose = 0, bool warm_start = false, int? n_jobs = null, float? l1_ratio = null)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray n_iter_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public LogisticRegression densify() => default!;
            [ReturnThis]
            public LogisticRegression fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LogisticRegression set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LogisticRegression set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LogisticRegression set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LogisticRegression sparsify() => default!;
        }

        public class LogisticRegressionCV
        {
            // Constructor
            public LogisticRegressionCV(int Cs = 10, bool fit_intercept = true, int? cv = null, bool dual = false, string penalty = "l2", string? scoring = null, string solver = "lbfgs", float tol = 0.0001f, int max_iter = 100, PyDict? class_weight = null, int? n_jobs = null, int verbose = 0, bool refit = true, float intercept_scaling = 1.0f, string multi_class = "deprecated", int? random_state = null, PyTuple? l1_ratios = null)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray Cs_ => default!;
            public NDarray l1_ratios_ => default!;
            public NDarray coefs_paths_ => default!;
            public PyDict scores_ => default!;
            public NDarray C_ => default!;
            public NDarray l1_ratio_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public LogisticRegressionCV densify() => default!;
            [ReturnThis]
            public LogisticRegressionCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LogisticRegressionCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LogisticRegressionCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LogisticRegressionCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LogisticRegressionCV sparsify() => default!;
        }

        public class PassiveAggressiveClassifier
        {
            // Constructor
            public PassiveAggressiveClassifier(float C = 1.0f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, bool shuffle = true, int verbose = 0, string loss = "hinge", int? n_jobs = null, int? random_state = null, bool warm_start = false, PyDict? class_weight = null, bool average = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public NDarray classes_ => default!;
            public int t_ => default!;
            public PyObject loss_function_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public PassiveAggressiveClassifier densify() => default!;
            [ReturnThis]
            public PassiveAggressiveClassifier fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public PassiveAggressiveClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public PassiveAggressiveClassifier set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PassiveAggressiveClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public PassiveAggressiveClassifier set_partial_fit_request(string? classes = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PassiveAggressiveClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PassiveAggressiveClassifier sparsify() => default!;
        }

        public class Perceptron
        {
            // Constructor
            public Perceptron(PyObject? penalty = null, float alpha = 0.0001f, float l1_ratio = 0.15f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool shuffle = true, int verbose = 0, float eta0 = 1.0f, int? n_jobs = null, int? random_state = 0, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, PyDict? class_weight = null, bool warm_start = false)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public PyObject loss_function_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public int t_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public Perceptron densify() => default!;
            [ReturnThis]
            public Perceptron fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public Perceptron partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public Perceptron set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public Perceptron set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public Perceptron set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public Perceptron set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public Perceptron sparsify() => default!;
        }

        public class RidgeClassifier
        {
            // Constructor
            public RidgeClassifier(float alpha = 1.0f, bool fit_intercept = true, bool copy_X = true, int? max_iter = null, float tol = 0.0001f, PyDict? class_weight = null, string solver = "auto", bool positive = false, int? random_state = null)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public string solver_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public RidgeClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public RidgeClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public RidgeClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public RidgeClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class RidgeClassifierCV
        {
            // Constructor
            public RidgeClassifierCV(PyTuple? alphas = null, bool fit_intercept = true, string? scoring = null, int? cv = null, PyDict? class_weight = null, bool? store_cv_results = null, string store_cv_values = "deprecated")
            {
            }

            // Properties
            public NDarray cv_results_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public float alpha_ => default!;
            public float best_score_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public RidgeClassifierCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public RidgeClassifierCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public RidgeClassifierCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public RidgeClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class SGDClassifier
        {
            // Constructor
            public SGDClassifier(string loss = "hinge", string? penalty = "l2", float alpha = 0.0001f, float l1_ratio = 0.15f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool shuffle = true, int verbose = 0, float epsilon = 0.1f, int? n_jobs = null, int? random_state = null, string learning_rate = "optimal", float eta0 = 0.0f, float power_t = 0.5f, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, PyDict? class_weight = null, bool warm_start = false, bool average = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public int n_iter_ => default!;
            public PyObject loss_function_ => default!;
            public NDarray classes_ => default!;
            public int t_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public SGDClassifier densify() => default!;
            [ReturnThis]
            public SGDClassifier fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public SGDClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public SGDClassifier set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SGDClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public SGDClassifier set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SGDClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SGDClassifier sparsify() => default!;
        }

        public class SGDOneClassSVM
        {
            // Constructor
            public SGDOneClassSVM(float nu = 0.5f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool shuffle = true, int verbose = 0, int? random_state = null, string learning_rate = "optimal", float eta0 = 0.0f, float power_t = 0.5f, bool warm_start = false, bool average = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray offset_ => default!;
            public int n_iter_ => default!;
            public int t_ => default!;
            public PyObject loss_function_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public SGDOneClassSVM densify() => default!;
            [ReturnThis]
            public SGDOneClassSVM fit(NDarray X, NDarray? coef_init = null, NDarray? offset_init = null, NDarray? sample_weight = null) => default!;
            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public SGDOneClassSVM partial_fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [ReturnThis]
            public SGDOneClassSVM set_fit_request(string? coef_init = "$UNCHANGED$", string? offset_init = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SGDOneClassSVM set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public SGDOneClassSVM set_partial_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SGDOneClassSVM sparsify() => default!;
        }

        public class LinearRegression
        {
            // Constructor
            public LinearRegression(bool fit_intercept = true, bool copy_X = true, int? n_jobs = null, bool positive = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public int rank_ => default!;
            public NDarray singular_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public LinearRegression fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LinearRegression set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LinearRegression set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LinearRegression set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class Ridge
        {
            // Constructor
            public Ridge(float alpha = 1.0f, bool fit_intercept = true, bool copy_X = true, int? max_iter = null, float tol = 0.0001f, string solver = "auto", bool positive = false, int? random_state = null)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public string solver_ => default!;

            // Methods
            [ReturnThis]
            public Ridge fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public Ridge set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public Ridge set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public Ridge set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class RidgeCV
        {
            // Constructor
            public RidgeCV(PyTuple? alphas = null, bool fit_intercept = true, string? scoring = null, int? cv = null, PyObject? gcv_mode = null, bool? store_cv_results = null, bool alpha_per_target = false, string store_cv_values = "deprecated")
            {
            }

            // Properties
            public NDarray cv_results_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray alpha_ => default!;
            public NDarray best_score_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public RidgeCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public RidgeCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public RidgeCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public RidgeCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class SGDRegressor
        {
            // Constructor
            public SGDRegressor(string loss = "squared_error", string? penalty = "l2", float alpha = 0.0001f, float l1_ratio = 0.15f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool shuffle = true, int verbose = 0, float epsilon = 0.1f, int? random_state = null, string learning_rate = "invscaling", float eta0 = 0.01f, float power_t = 0.25f, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, bool warm_start = false, bool average = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public int n_iter_ => default!;
            public int t_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public SGDRegressor densify() => default!;
            [ReturnThis]
            public SGDRegressor fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public SGDRegressor partial_fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public SGDRegressor set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SGDRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public SGDRegressor set_partial_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SGDRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SGDRegressor sparsify() => default!;
        }

        public class ElasticNet
        {
            // Constructor
            public ElasticNet(float alpha = 1.0f, float l1_ratio = 0.5f, bool fit_intercept = true, bool precompute = false, int max_iter = 1000, bool copy_X = true, float tol = 0.0001f, bool warm_start = false, bool positive = false, int? random_state = null, string selection = "cyclic")
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray sparse_coef_ => default!;
            public NDarray intercept_ => default!;
            public PyTuple n_iter_ => default!;
            public NDarray dual_gap_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public ElasticNet fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?, NDarray?, PyTuple?) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ElasticNet set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ElasticNet set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ElasticNet set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class ElasticNetCV
        {
            // Constructor
            public ElasticNetCV(float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, bool fit_intercept = true, string precompute = "auto", int max_iter = 1000, float tol = 0.0001f, int? cv = null, bool copy_X = true, int verbose = 0, int? n_jobs = null, bool positive = false, int? random_state = null, string selection = "cyclic")
            {
            }

            // Properties
            public float alpha_ => default!;
            public float l1_ratio_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray mse_path_ => default!;
            public NDarray alphas_ => default!;
            public float dual_gap_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public ElasticNetCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?, NDarray?, PyTuple?) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ElasticNetCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ElasticNetCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ElasticNetCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class Lars
        {
            // Constructor
            public Lars(bool fit_intercept = true, bool verbose = false, string precompute = "auto", int n_nonzero_coefs = 500, float eps = float.Epsilon, bool copy_X = true, bool fit_path = true, float? jitter = null, int? random_state = null)
            {
            }

            // Properties
            public NDarray alphas_ => default!;
            public NDarray active_ => default!;
            public NDarray coef_path_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public Lars fit(NDarray X, NDarray y, NDarray? Xy = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public Lars set_fit_request(string? Xy = "$UNCHANGED$") => default!;
            [ReturnThis]
            public Lars set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public Lars set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LarsCV
        {
            // Constructor
            public LarsCV(bool fit_intercept = true, bool verbose = false, int max_iter = 500, string precompute = "auto", int? cv = null, int max_n_alphas = 1000, int? n_jobs = null, float eps = float.Epsilon, bool copy_X = true)
            {
            }

            // Properties
            public PyTuple active_ => default!;
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public NDarray coef_path_ => default!;
            public float alpha_ => default!;
            public NDarray alphas_ => default!;
            public NDarray cv_alphas_ => default!;
            public NDarray mse_path_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public LarsCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LarsCV set_fit_request(string? Xy = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LarsCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LarsCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class Lasso
        {
            // Constructor
            public Lasso(float alpha = 1.0f, bool fit_intercept = true, bool precompute = false, bool copy_X = true, int max_iter = 1000, float tol = 0.0001f, bool warm_start = false, bool positive = false, int? random_state = null, string selection = "cyclic")
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray dual_gap_ => default!;
            public NDarray sparse_coef_ => default!;
            public NDarray intercept_ => default!;
            public PyTuple n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public Lasso fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?, NDarray?, PyTuple?) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public Lasso set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public Lasso set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public Lasso set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LassoCV
        {
            // Constructor
            public LassoCV(float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, bool fit_intercept = true, string precompute = "auto", int max_iter = 1000, float tol = 0.0001f, bool copy_X = true, int? cv = null, bool verbose = false, int? n_jobs = null, bool positive = false, int? random_state = null, string selection = "cyclic")
            {
            }

            // Properties
            public float alpha_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray mse_path_ => default!;
            public NDarray alphas_ => default!;
            public NDarray dual_gap_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public LassoCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?, NDarray?, PyTuple?) path(NDarray X, NDarray y, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LassoCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LassoCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LassoCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LassoLars
        {
            // Constructor
            public LassoLars(float alpha = 1.0f, bool fit_intercept = true, bool verbose = false, string precompute = "auto", int max_iter = 500, float eps = float.Epsilon, bool copy_X = true, bool fit_path = true, bool positive = false, float? jitter = null, int? random_state = null)
            {
            }

            // Properties
            public NDarray alphas_ => default!;
            public PyTuple active_ => default!;
            public NDarray coef_path_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public LassoLars fit(NDarray X, NDarray y, NDarray? Xy = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LassoLars set_fit_request(string? Xy = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LassoLars set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LassoLars set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LassoLarsCV
        {
            // Constructor
            public LassoLarsCV(bool fit_intercept = true, bool verbose = false, int max_iter = 500, string precompute = "auto", int? cv = null, int max_n_alphas = 1000, int? n_jobs = null, float eps = float.Epsilon, bool copy_X = true, bool positive = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public NDarray coef_path_ => default!;
            public float alpha_ => default!;
            public NDarray alphas_ => default!;
            public NDarray cv_alphas_ => default!;
            public NDarray mse_path_ => default!;
            public NDarray n_iter_ => default!;
            public PyTuple active_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public LassoLarsCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LassoLarsCV set_fit_request(string? Xy = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LassoLarsCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LassoLarsCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LassoLarsIC
        {
            // Constructor
            public LassoLarsIC(string criterion = "aic", bool fit_intercept = true, bool verbose = false, string precompute = "auto", int max_iter = 500, float eps = float.Epsilon, bool copy_X = true, bool positive = false, float? noise_variance = null)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public float alpha_ => default!;
            public NDarray alphas_ => default!;
            public int n_iter_ => default!;
            public NDarray criterion_ => default!;
            public float noise_variance_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public LassoLarsIC fit(NDarray X, NDarray y, bool? copy_X = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LassoLarsIC set_fit_request(string? copy_X = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LassoLarsIC set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LassoLarsIC set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class OrthogonalMatchingPursuit
        {
            // Constructor
            public OrthogonalMatchingPursuit(int? n_nonzero_coefs = null, float? tol = null, bool fit_intercept = true, string precompute = "auto")
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_nonzero_coefs_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public OrthogonalMatchingPursuit fit(NDarray X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public OrthogonalMatchingPursuit set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public OrthogonalMatchingPursuit set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class OrthogonalMatchingPursuitCV
        {
            // Constructor
            public OrthogonalMatchingPursuitCV(bool copy = true, bool fit_intercept = true, int? max_iter = null, int? cv = null, int? n_jobs = null, bool verbose = false)
            {
            }

            // Properties
            public NDarray intercept_ => default!;
            public NDarray coef_ => default!;
            public int n_nonzero_coefs_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public OrthogonalMatchingPursuitCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public OrthogonalMatchingPursuitCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public OrthogonalMatchingPursuitCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class ARDRegression
        {
            // Constructor
            public ARDRegression(int max_iter = 300, float tol = 0.001f, float alpha_1 = 1e-06f, float alpha_2 = 1e-06f, float lambda_1 = 1e-06f, float lambda_2 = 1e-06f, bool compute_score = false, float threshold_lambda = 10000.0f, bool fit_intercept = true, bool copy_X = true, bool verbose = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float alpha_ => default!;
            public NDarray lambda_ => default!;
            public NDarray sigma_ => default!;
            public float scores_ => default!;
            public int n_iter_ => default!;
            public float intercept_ => default!;
            public float X_offset_ => default!;
            public float X_scale_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public ARDRegression fit(NDarray X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?) predict(NDarray X, bool return_std = false) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ARDRegression set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ARDRegression set_predict_request(string? return_std = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ARDRegression set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class BayesianRidge
        {
            // Constructor
            public BayesianRidge(int max_iter = 300, float tol = 0.001f, float alpha_1 = 1e-06f, float alpha_2 = 1e-06f, float lambda_1 = 1e-06f, float lambda_2 = 1e-06f, float? alpha_init = null, float? lambda_init = null, bool compute_score = false, bool fit_intercept = true, bool copy_X = true, bool verbose = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public float alpha_ => default!;
            public float lambda_ => default!;
            public NDarray sigma_ => default!;
            public NDarray scores_ => default!;
            public int n_iter_ => default!;
            public NDarray X_offset_ => default!;
            public NDarray X_scale_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public BayesianRidge fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?) predict(NDarray X, bool return_std = false) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public BayesianRidge set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public BayesianRidge set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public BayesianRidge set_predict_request(string? return_std = "$UNCHANGED$") => default!;
            [ReturnThis]
            public BayesianRidge set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultiTaskElasticNet
        {
            // Constructor
            public MultiTaskElasticNet(float alpha = 1.0f, float l1_ratio = 0.5f, bool fit_intercept = true, bool copy_X = true, int max_iter = 1000, float tol = 0.0001f, bool warm_start = false, int? random_state = null, string selection = "cyclic")
            {
            }

            // Properties
            public NDarray intercept_ => default!;
            public NDarray coef_ => default!;
            public int n_iter_ => default!;
            public float dual_gap_ => default!;
            public float eps_ => default!;
            public NDarray sparse_coef_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MultiTaskElasticNet fit(NDarray X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?, NDarray?, PyTuple?) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public MultiTaskElasticNet set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultiTaskElasticNet set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public MultiTaskElasticNet set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultiTaskElasticNetCV
        {
            // Constructor
            public MultiTaskElasticNetCV(float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, bool fit_intercept = true, int max_iter = 1000, float tol = 0.0001f, int? cv = null, bool copy_X = true, int verbose = 0, int? n_jobs = null, int? random_state = null, string selection = "cyclic")
            {
            }

            // Properties
            public NDarray intercept_ => default!;
            public NDarray coef_ => default!;
            public float alpha_ => default!;
            public NDarray mse_path_ => default!;
            public NDarray alphas_ => default!;
            public float l1_ratio_ => default!;
            public int n_iter_ => default!;
            public float dual_gap_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MultiTaskElasticNetCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?, NDarray?, PyTuple?) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public MultiTaskElasticNetCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultiTaskElasticNetCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public MultiTaskElasticNetCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultiTaskLasso
        {
            // Constructor
            public MultiTaskLasso(float alpha = 1.0f, bool fit_intercept = true, bool copy_X = true, int max_iter = 1000, float tol = 0.0001f, bool warm_start = false, int? random_state = null, string selection = "cyclic")
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public int n_iter_ => default!;
            public NDarray dual_gap_ => default!;
            public float eps_ => default!;
            public NDarray sparse_coef_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MultiTaskLasso fit(NDarray X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?, NDarray?, PyTuple?) path(NDarray X, NDarray y, float l1_ratio = 0.5f, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, bool check_input = true, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public MultiTaskLasso set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultiTaskLasso set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public MultiTaskLasso set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultiTaskLassoCV
        {
            // Constructor
            public MultiTaskLassoCV(float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, bool fit_intercept = true, int max_iter = 1000, float tol = 0.0001f, bool copy_X = true, int? cv = null, bool verbose = false, int? n_jobs = null, int? random_state = null, string selection = "cyclic")
            {
            }

            // Properties
            public NDarray intercept_ => default!;
            public NDarray coef_ => default!;
            public float alpha_ => default!;
            public NDarray mse_path_ => default!;
            public NDarray alphas_ => default!;
            public int n_iter_ => default!;
            public float dual_gap_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MultiTaskLassoCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?, NDarray?, PyTuple?) path(NDarray X, NDarray y, float eps = 0.001f, int n_alphas = 100, NDarray? alphas = null, string precompute = "auto", NDarray? Xy = null, bool copy_X = true, NDarray? coef_init = null, bool verbose = false, bool return_n_iter = false, bool positive = false, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public MultiTaskLassoCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultiTaskLassoCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public MultiTaskLassoCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class HuberRegressor
        {
            // Constructor
            public HuberRegressor(float epsilon = 1.35f, int max_iter = 100, float alpha = 0.0001f, bool warm_start = false, bool fit_intercept = true, float tol = 1e-05f)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public float scale_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public NDarray outliers_ => default!;

            // Methods
            [ReturnThis]
            public HuberRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public HuberRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public HuberRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public HuberRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class QuantileRegressor
        {
            // Constructor
            public QuantileRegressor(float quantile = 0.5f, float alpha = 1.0f, bool fit_intercept = true, string solver = "highs", PyDict? solver_options = null)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [ReturnThis]
            public QuantileRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public QuantileRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public QuantileRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public QuantileRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class RANSACRegressor
        {
            // Constructor
            public RANSACRegressor(PyObject? estimator = null, float? min_samples = null, float? residual_threshold = null, PyObject? is_data_valid = null, PyObject? is_model_valid = null, int max_trials = 100, float max_skips = float.PositiveInfinity, float stop_n_inliers = float.PositiveInfinity, float stop_score = float.PositiveInfinity, float stop_probability = 0.99f, string loss = "absolute_error", int? random_state = null)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public int n_trials_ => default!;
            public NDarray inlier_mask_ => default!;
            public int n_skips_no_inliers_ => default!;
            public int n_skips_invalid_data_ => default!;
            public int n_skips_invalid_model_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public RANSACRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public float score(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public RANSACRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public RANSACRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class TheilSenRegressor
        {
            // Constructor
            public TheilSenRegressor(bool fit_intercept = true, bool copy_X = true, float max_subpopulation = 10000.0f, int? n_subsamples = null, int max_iter = 300, float tol = 0.001f, int? random_state = null, int? n_jobs = null, bool verbose = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public float breakdown_ => default!;
            public int n_iter_ => default!;
            public int n_subpopulation_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public TheilSenRegressor fit(NDarray X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public TheilSenRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public TheilSenRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class GammaRegressor
        {
            // Constructor
            public GammaRegressor(float alpha = 1.0f, bool fit_intercept = true, string solver = "lbfgs", int max_iter = 100, float tol = 0.0001f, bool warm_start = false, int verbose = 0)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public int n_features_in_ => default!;
            public int n_iter_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public GammaRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public GammaRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public GammaRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public GammaRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class PoissonRegressor
        {
            // Constructor
            public PoissonRegressor(float alpha = 1.0f, bool fit_intercept = true, string solver = "lbfgs", int max_iter = 100, float tol = 0.0001f, bool warm_start = false, int verbose = 0)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [ReturnThis]
            public PoissonRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public PoissonRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PoissonRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public PoissonRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class TweedieRegressor
        {
            // Constructor
            public TweedieRegressor(float power = 0.0f, float alpha = 1.0f, bool fit_intercept = true, string link = "auto", string solver = "lbfgs", int max_iter = 100, float tol = 0.0001f, bool warm_start = false, int verbose = 0)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public float intercept_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public TweedieRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public TweedieRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public TweedieRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public TweedieRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class PassiveAggressiveRegressor
        {
            // Constructor
            public PassiveAggressiveRegressor(float C = 1.0f, bool fit_intercept = true, int max_iter = 1000, float? tol = 0.001f, bool early_stopping = false, float validation_fraction = 0.1f, int n_iter_no_change = 5, bool shuffle = true, int verbose = 0, string loss = "epsilon_insensitive", float epsilon = 0.1f, int? random_state = null, bool warm_start = false, bool average = false)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public int t_ => default!;

            // Methods
            [ReturnThis]
            public PassiveAggressiveRegressor densify() => default!;
            [ReturnThis]
            public PassiveAggressiveRegressor fit(NDarray X, NDarray y, NDarray? coef_init = null, NDarray? intercept_init = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public PassiveAggressiveRegressor partial_fit(NDarray X, NDarray y) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public PassiveAggressiveRegressor set_fit_request(string? coef_init = "$UNCHANGED$", string? intercept_init = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PassiveAggressiveRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public PassiveAggressiveRegressor set_partial_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PassiveAggressiveRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PassiveAggressiveRegressor sparsify() => default!;
        }
    }
}