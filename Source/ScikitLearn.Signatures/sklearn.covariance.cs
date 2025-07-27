using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class covariance
    {
        // Methods
        public static NDarray empirical_covariance(NDarray X, bool assume_centered = false) => default!;
        public static (NDarray?, NDarray?, PyObject?, int?) graphical_lasso(NDarray emp_cov, float alpha, string mode = "cd", float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, bool verbose = false, bool return_costs = false, float eps = float.Epsilon, bool return_n_iter = false) => default!;
        public static (NDarray?, float?) ledoit_wolf(NDarray X, bool assume_centered = false, int block_size = 1000) => default!;
        public static float ledoit_wolf_shrinkage(NDarray X, bool assume_centered = false, int block_size = 1000) => default!;
        public static (NDarray?, float?) oas(NDarray X, bool assume_centered = false) => default!;
        public static NDarray shrunk_covariance(NDarray emp_cov, float shrinkage = 0.1f) => default!;
        // Classes
        public class EllipticEnvelope : PythonObject
        {
            // Constructor
            public EllipticEnvelope(bool store_precision = true, bool assume_centered = false, float? support_fraction = null, float contamination = 0.1f, int? random_state = null)
            {
            }

            // Properties
            public NDarray location_ => default!;
            public NDarray covariance_ => default!;
            public NDarray precision_ => default!;
            public NDarray support_ => default!;
            public float offset_ => default!;
            public NDarray raw_location_ => default!;
            public NDarray raw_covariance_ => default!;
            public NDarray raw_support_ => default!;
            public NDarray dist_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray correct_covariance(NDarray data) => default!;
            public NDarray decision_function(NDarray X) => default!;
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [ReturnThis]
            public EllipticEnvelope fit(NDarray X) => default!;
            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public NDarray predict(NDarray X) => default!;
            public (NDarray?, NDarray?, NDarray?) reweight_covariance(NDarray data) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [ReturnThis]
            public EllipticEnvelope set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public EllipticEnvelope set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class EmpiricalCovariance : PythonObject
        {
            // Constructor
            public EmpiricalCovariance(bool store_precision = true, bool assume_centered = false)
            {
            }

            // Properties
            public NDarray location_ => default!;
            public NDarray covariance_ => default!;
            public NDarray precision_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [ReturnThis]
            public EmpiricalCovariance fit(NDarray X) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X_test) => default!;
            [ReturnThis]
            public EmpiricalCovariance set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public EmpiricalCovariance set_score_request(string? X_test = "$UNCHANGED$") => default!;
        }

        public class GraphicalLasso : PythonObject
        {
            // Constructor
            public GraphicalLasso(float alpha = 0.01f, string mode = "cd", PyObject? covariance = null, float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, bool verbose = false, float eps = float.Epsilon, bool assume_centered = false)
            {
            }

            // Properties
            public NDarray location_ => default!;
            public NDarray covariance_ => default!;
            public NDarray precision_ => default!;
            public int n_iter_ => default!;
            public PyObject costs_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [ReturnThis]
            public GraphicalLasso fit(NDarray X) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X_test) => default!;
            [ReturnThis]
            public GraphicalLasso set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public GraphicalLasso set_score_request(string? X_test = "$UNCHANGED$") => default!;
        }

        public class GraphicalLassoCV : PythonObject
        {
            // Constructor
            public GraphicalLassoCV(int alphas = 4, int n_refinements = 4, int? cv = null, float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, string mode = "cd", int? n_jobs = null, bool verbose = false, float eps = float.Epsilon, bool assume_centered = false)
            {
            }

            // Properties
            public NDarray location_ => default!;
            public NDarray covariance_ => default!;
            public NDarray precision_ => default!;
            public PyObject costs_ => default!;
            public float alpha_ => default!;
            public PyDict cv_results_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [ReturnThis]
            public GraphicalLassoCV fit(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X_test) => default!;
            [ReturnThis]
            public GraphicalLassoCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public GraphicalLassoCV set_score_request(string? X_test = "$UNCHANGED$") => default!;
        }

        public class LedoitWolf : PythonObject
        {
            // Constructor
            public LedoitWolf(bool store_precision = true, bool assume_centered = false, int block_size = 1000)
            {
            }

            // Properties
            public NDarray covariance_ => default!;
            public NDarray location_ => default!;
            public NDarray precision_ => default!;
            public float shrinkage_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [ReturnThis]
            public LedoitWolf fit(NDarray X) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X_test) => default!;
            [ReturnThis]
            public LedoitWolf set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LedoitWolf set_score_request(string? X_test = "$UNCHANGED$") => default!;
        }

        public class MinCovDet : PythonObject
        {
            // Constructor
            public MinCovDet(bool store_precision = true, bool assume_centered = false, float? support_fraction = null, int? random_state = null)
            {
            }

            // Properties
            public NDarray raw_location_ => default!;
            public NDarray raw_covariance_ => default!;
            public NDarray raw_support_ => default!;
            public NDarray location_ => default!;
            public NDarray covariance_ => default!;
            public NDarray precision_ => default!;
            public NDarray support_ => default!;
            public NDarray dist_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray correct_covariance(NDarray data) => default!;
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [ReturnThis]
            public MinCovDet fit(NDarray X) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public (NDarray?, NDarray?, NDarray?) reweight_covariance(NDarray data) => default!;
            public float score(NDarray X_test) => default!;
            [ReturnThis]
            public MinCovDet set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public MinCovDet set_score_request(string? X_test = "$UNCHANGED$") => default!;
        }

        public class OAS : PythonObject
        {
            // Constructor
            public OAS(bool store_precision = true, bool assume_centered = false)
            {
            }

            // Properties
            public NDarray covariance_ => default!;
            public NDarray location_ => default!;
            public NDarray precision_ => default!;
            public float shrinkage_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [ReturnThis]
            public OAS fit(NDarray X) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X_test) => default!;
            [ReturnThis]
            public OAS set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public OAS set_score_request(string? X_test = "$UNCHANGED$") => default!;
        }

        public class ShrunkCovariance : PythonObject
        {
            // Constructor
            public ShrunkCovariance(bool store_precision = true, bool assume_centered = false, float shrinkage = 0.1f)
            {
            }

            // Properties
            public NDarray covariance_ => default!;
            public NDarray location_ => default!;
            public NDarray precision_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [ReturnThis]
            public ShrunkCovariance fit(NDarray X) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X_test) => default!;
            [ReturnThis]
            public ShrunkCovariance set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ShrunkCovariance set_score_request(string? X_test = "$UNCHANGED$") => default!;
        }
    }
}