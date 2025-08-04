using Numpy;
using Python.Runtime;
using System;
using System.Collections.Generic;

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
        public class LinearSVC : PythonObject,
            @base.LinearClassifierMixin,
            @base.SparseCoefMixin<LinearSVC>,
            @base.BaseEstimator<LinearSVC>
        {
            // Constructor
            public LinearSVC(
                string penalty = "l2",
                string loss = "squared_hinge",
                string dual = "auto",
                float tol = 0.0001f,
                float C = 1.0f,
                string multi_class = "ovr",
                bool fit_intercept = true,
                int intercept_scaling = 1,
                OneOf<Dictionary<string, float>, string>? class_weight = null,
                int verbose = 0,
                int? random_state = null,
                int max_iter = 1000)
            { }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [Self]
            public LinearSVC densify() => default!;
            [Self]
            public LinearSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public LinearSVC set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public LinearSVC set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public LinearSVC set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public LinearSVC sparsify() => default!;
        }

        public class LinearSVR : PythonObject,
            @base.RegressorMixin,
            @base.LinearModel<LinearSVR>
        {
            // Constructor
            public LinearSVR(
                float epsilon = 0.0f,
                float tol = 0.0001f,
                float C = 1.0f,
                string loss = "epsilon_insensitive",
                bool fit_intercept = true,
                float intercept_scaling = 1.0f,
                [NeedsRevision] string dual = "auto",
                int verbose = 0,
                int? random_state = null,
                int max_iter = 1000)
            { }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [Self]
            public LinearSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public LinearSVR set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public LinearSVR set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public LinearSVR set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class NuSVC : PythonObject,
            @base.BaseSVC<NuSVC>
        {
            // Constructor
            public NuSVC(
                float nu = 0.5f,
                string kernel = "rbf",
                int degree = 3,
                [NeedsRevision] string gamma = "scale",
                float coef0 = 0.0f,
                bool shrinking = true,
                bool probability = false,
                float tol = 0.001f,
                int cache_size = 200,
               [NeedsRevision] PyDict? class_weight = null,
                bool verbose = false,
                int max_iter = -1,
                string decision_function_shape = "ovr",
                bool break_ties = false,
                int? random_state = null)
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
            [Self]
            public NuSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public NuSVC set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public NuSVC set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public NuSVC set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class NuSVR : PythonObject
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
            [Self]
            public NuSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public NuSVR set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public NuSVR set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public NuSVR set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class OneClassSVM : PythonObject
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
            [Self]
            public OneClassSVM fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray fit_predict(NDarray X, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [Self]
            public OneClassSVM set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public OneClassSVM set_params(params (string key, object value)[] @params) => default!;
        }

        public class SVC : PythonObject
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
            [Self]
            public SVC fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public SVC set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public SVC set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public SVC set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class SVR : PythonObject
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
            [Self]
            public SVR fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public SVR set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public SVR set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public SVR set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}