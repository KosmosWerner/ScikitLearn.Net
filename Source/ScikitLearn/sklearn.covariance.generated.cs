using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class covariance
        {
            public static NDarray empirical_covariance(NDarray X, bool assume_centered = false)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , NDarray? , PyObject? , int? ) graphical_lasso(NDarray emp_cov, float alpha, string mode = "cd", float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, bool verbose = false, bool return_costs = false, float eps = float.Epsilon, bool return_n_iter = false)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , float? ) ledoit_wolf(NDarray X, bool assume_centered = false, int block_size = 1000)
            {
                throw new NotImplementedException();
            }

            public static float ledoit_wolf_shrinkage(NDarray X, bool assume_centered = false, int block_size = 1000)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , float? ) oas(NDarray X, bool assume_centered = false)
            {
                throw new NotImplementedException();
            }

            public static NDarray shrunk_covariance(NDarray emp_cov, float shrinkage = 0.1f)
            {
                throw new NotImplementedException();
            }

            public class EllipticEnvelope
            {
                public EllipticEnvelope(bool store_precision = true, bool assume_centered = false, float? support_fraction = null, float contamination = 0.1f, int? random_state = null)
                {
                }

                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public float offset_ => Helpers.ToCSharpNDarray(self.GetAttr("offset_"));
                public NDarray raw_location_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_location_"));
                public NDarray raw_covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_covariance_"));
                public NDarray raw_support_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_support_"));
                public NDarray dist_ => Helpers.ToCSharpNDarray(self.GetAttr("dist_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray correct_covariance(NDarray data)
                {
                    throw new NotImplementedException();
                }

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    throw new NotImplementedException();
                }

                public EllipticEnvelope fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray mahalanobis(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? , NDarray? ) reweight_covariance(NDarray data)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public EllipticEnvelope set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public EllipticEnvelope set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class EmpiricalCovariance
            {
                public EmpiricalCovariance(bool store_precision = true, bool assume_centered = false)
                {
                }

                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    throw new NotImplementedException();
                }

                public EmpiricalCovariance fit(NDarray X)
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray mahalanobis(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X_test)
                {
                    throw new NotImplementedException();
                }

                public EmpiricalCovariance set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public EmpiricalCovariance set_score_request(string? X_test = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class GraphicalLasso
            {
                public GraphicalLasso(float alpha = 0.01f, string mode = "cd", PyObject? covariance = null, float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, bool verbose = false, float eps = float.Epsilon, bool assume_centered = false)
                {
                }

                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public PyObject costs_ => Helpers.ToCSharpNDarray(self.GetAttr("costs_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    throw new NotImplementedException();
                }

                public GraphicalLasso fit(NDarray X)
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray mahalanobis(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X_test)
                {
                    throw new NotImplementedException();
                }

                public GraphicalLasso set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public GraphicalLasso set_score_request(string? X_test = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class GraphicalLassoCV
            {
                public GraphicalLassoCV(int alphas = 4, int n_refinements = 4, int? cv = null, float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, string mode = "cd", int? n_jobs = null, bool verbose = false, float eps = float.Epsilon, bool assume_centered = false)
                {
                }

                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public PyObject costs_ => Helpers.ToCSharpNDarray(self.GetAttr("costs_"));
                public float alpha_ => Helpers.ToCSharpNDarray(self.GetAttr("alpha_"));
                public PyDict cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    throw new NotImplementedException();
                }

                public GraphicalLassoCV fit(NDarray X, Dictionary<string, PyObject>? @params = null)
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray mahalanobis(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X_test)
                {
                    throw new NotImplementedException();
                }

                public GraphicalLassoCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public GraphicalLassoCV set_score_request(string? X_test = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class LedoitWolf
            {
                public LedoitWolf(bool store_precision = true, bool assume_centered = false, int block_size = 1000)
                {
                }

                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public float shrinkage_ => Helpers.ToCSharpNDarray(self.GetAttr("shrinkage_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    throw new NotImplementedException();
                }

                public LedoitWolf fit(NDarray X)
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray mahalanobis(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X_test)
                {
                    throw new NotImplementedException();
                }

                public LedoitWolf set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public LedoitWolf set_score_request(string? X_test = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class MinCovDet
            {
                public MinCovDet(bool store_precision = true, bool assume_centered = false, float? support_fraction = null, int? random_state = null)
                {
                }

                public NDarray raw_location_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_location_"));
                public NDarray raw_covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_covariance_"));
                public NDarray raw_support_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_support_"));
                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public NDarray dist_ => Helpers.ToCSharpNDarray(self.GetAttr("dist_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray correct_covariance(NDarray data)
                {
                    throw new NotImplementedException();
                }

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    throw new NotImplementedException();
                }

                public MinCovDet fit(NDarray X)
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray mahalanobis(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? , NDarray? ) reweight_covariance(NDarray data)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X_test)
                {
                    throw new NotImplementedException();
                }

                public MinCovDet set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public MinCovDet set_score_request(string? X_test = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class OAS
            {
                public OAS(bool store_precision = true, bool assume_centered = false)
                {
                }

                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public float shrinkage_ => Helpers.ToCSharpNDarray(self.GetAttr("shrinkage_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    throw new NotImplementedException();
                }

                public OAS fit(NDarray X)
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray mahalanobis(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X_test)
                {
                    throw new NotImplementedException();
                }

                public OAS set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public OAS set_score_request(string? X_test = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class ShrunkCovariance
            {
                public ShrunkCovariance(bool store_precision = true, bool assume_centered = false, float shrinkage = 0.1f)
                {
                }

                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    throw new NotImplementedException();
                }

                public ShrunkCovariance fit(NDarray X)
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray mahalanobis(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X_test)
                {
                    throw new NotImplementedException();
                }

                public ShrunkCovariance set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public ShrunkCovariance set_score_request(string? X_test = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}