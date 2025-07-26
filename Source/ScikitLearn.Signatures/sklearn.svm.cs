using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class svm
    {
        // Methods
        public static float l1_min_c(NDarray X, NDarray y, string loss = "squared_hinge", bool fit_intercept = true, float intercept_scaling = 1.0f) => default!;
        // Classes
        public class LinearSVC
        {
            // Constructor
            public LinearSVC(string penalty = "l2", string loss = "squared_hinge", string dual = "auto", float tol = 0.0001f, float C = 1.0f, string multi_class = "ovr", bool fit_intercept = true, int intercept_scaling = 1, PyDict? class_weight = null, int verbose = 0, int? random_state = null, int max_iter = 1000)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public LinearSVC densify() => default!;
            [ReturnThis]
            public LinearSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LinearSVC set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LinearSVC set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LinearSVC set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LinearSVC sparsify() => default!;
        }

        public class LinearSVR
        {
            // Constructor
            public LinearSVR(float epsilon = 0.0f, float tol = 0.0001f, float C = 1.0f, string loss = "epsilon_insensitive", bool fit_intercept = true, float intercept_scaling = 1.0f, string dual = "auto", int verbose = 0, int? random_state = null, int max_iter = 1000)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [ReturnThis]
            public LinearSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LinearSVR set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public LinearSVR set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LinearSVR set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class NuSVC
        {
            // Constructor
            public NuSVC(float nu = 0.5f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, bool probability = false, float tol = 0.001f, int cache_size = 200, PyDict? class_weight = null, bool verbose = false, int max_iter = -1, string decision_function_shape = "ovr", bool break_ties = false, int? random_state = null)
            {
            }

            // Properties
            public NDarray class_weight_ => default!;
            public NDarray classes_ => default!;
            public NDarray coef_ => default!;
            public NDarray dual_coef_ => default!;
            public int fit_status_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray n_iter_ => default!;
            public NDarray support_ => default!;
            public NDarray support_vectors_ => default!;
            public NDarray n_support_ => default!;
            public NDarray probA_ => default!;
            public NDarray probB_ => default!;
            public NDarray shape_fit_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public NuSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public NuSVC set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public NuSVC set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public NuSVC set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class NuSVR
        {
            // Constructor
            public NuSVR(float nu = 0.5f, float C = 1.0f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, float tol = 0.001f, int cache_size = 200, bool verbose = false, int max_iter = -1)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray dual_coef_ => default!;
            public int fit_status_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public NDarray n_support_ => default!;
            public NDarray shape_fit_ => default!;
            public NDarray support_ => default!;
            public NDarray support_vectors_ => default!;

            // Methods
            [ReturnThis]
            public NuSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public NuSVR set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public NuSVR set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public NuSVR set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class OneClassSVM
        {
            // Constructor
            public OneClassSVM(string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, float tol = 0.001f, float nu = 0.5f, bool shrinking = true, int cache_size = 200, bool verbose = false, int max_iter = -1)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray dual_coef_ => default!;
            public int fit_status_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public NDarray n_support_ => default!;
            public float offset_ => default!;
            public NDarray shape_fit_ => default!;
            public NDarray support_ => default!;
            public NDarray support_vectors_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public OneClassSVM fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [ReturnThis]
            public OneClassSVM set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public OneClassSVM set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class SVC
        {
            // Constructor
            public SVC(float C = 1.0f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, bool probability = false, float tol = 0.001f, int cache_size = 200, PyDict? class_weight = null, bool verbose = false, int max_iter = -1, string decision_function_shape = "ovr", bool break_ties = false, int? random_state = null)
            {
            }

            // Properties
            public NDarray class_weight_ => default!;
            public NDarray classes_ => default!;
            public NDarray coef_ => default!;
            public NDarray dual_coef_ => default!;
            public int fit_status_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray n_iter_ => default!;
            public NDarray support_ => default!;
            public NDarray support_vectors_ => default!;
            public NDarray n_support_ => default!;
            public NDarray probA_ => default!;
            public NDarray probB_ => default!;
            public NDarray shape_fit_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public SVC fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public SVC set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SVC set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public SVC set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class SVR
        {
            // Constructor
            public SVR(string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, float tol = 0.001f, float C = 1.0f, float epsilon = 0.1f, bool shrinking = true, int cache_size = 200, bool verbose = false, int max_iter = -1)
            {
            }

            // Properties
            public NDarray coef_ => default!;
            public NDarray dual_coef_ => default!;
            public int fit_status_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public NDarray n_support_ => default!;
            public NDarray shape_fit_ => default!;
            public NDarray support_ => default!;
            public NDarray support_vectors_ => default!;

            // Methods
            [ReturnThis]
            public SVR fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public SVR set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public SVR set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public SVR set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}