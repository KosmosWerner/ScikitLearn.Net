using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class svm
        {
            public static float l1_min_c(NDarray X, NDarray y, string loss = "squared_hinge", bool fit_intercept = true, float intercept_scaling = 1.0f)
            {
                throw new NotImplementedException();
            }

            public class LinearSVC
            {
                public LinearSVC(string penalty = "l2", string loss = "squared_hinge", string dual = "auto", float tol = 0.0001f, float C = 1.0f, string multi_class = "ovr", bool fit_intercept = true, int intercept_scaling = 1, PyDict? class_weight = null, int verbose = 0, int? random_state = null, int max_iter = 1000)
                {
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public LinearSVC densify()
                {
                    throw new NotImplementedException();
                }

                public LinearSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public LinearSVC set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public LinearSVC set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public LinearSVC set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public LinearSVC sparsify()
                {
                    throw new NotImplementedException();
                }
            }

            public class LinearSVR
            {
                public LinearSVR(float epsilon = 0.0f, float tol = 0.0001f, float C = 1.0f, string loss = "epsilon_insensitive", bool fit_intercept = true, float intercept_scaling = 1.0f, string dual = "auto", int verbose = 0, int? random_state = null, int max_iter = 1000)
                {
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));

                public LinearSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public LinearSVR set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public LinearSVR set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public LinearSVR set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class NuSVC
            {
                public NuSVC(float nu = 0.5f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, bool probability = false, float tol = 0.001f, int cache_size = 200, PyDict? class_weight = null, bool verbose = false, int max_iter = -1, string decision_function_shape = "ovr", bool break_ties = false, int? random_state = null)
                {
                }

                public NDarray class_weight_ => Helpers.ToCSharpNDarray(self.GetAttr("class_weight_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray dual_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_coef_"));
                public int fit_status_ => Helpers.ToCSharpNDarray(self.GetAttr("fit_status_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public NDarray support_vectors_ => Helpers.ToCSharpNDarray(self.GetAttr("support_vectors_"));
                public NDarray n_support_ => Helpers.ToCSharpNDarray(self.GetAttr("n_support_"));
                public int fit_status_ => Helpers.ToCSharpNDarray(self.GetAttr("fit_status_"));
                public NDarray probA_ => Helpers.ToCSharpNDarray(self.GetAttr("probA_"));
                public NDarray probB_ => Helpers.ToCSharpNDarray(self.GetAttr("probB_"));
                public NDarray shape_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("shape_fit_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NuSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NuSVC set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NuSVC set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NuSVC set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class NuSVR
            {
                public NuSVR(float nu = 0.5f, float C = 1.0f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, float tol = 0.001f, int cache_size = 200, bool verbose = false, int max_iter = -1)
                {
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray dual_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_coef_"));
                public int fit_status_ => Helpers.ToCSharpNDarray(self.GetAttr("fit_status_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray n_support_ => Helpers.ToCSharpNDarray(self.GetAttr("n_support_"));
                public NDarray shape_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("shape_fit_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public NDarray support_vectors_ => Helpers.ToCSharpNDarray(self.GetAttr("support_vectors_"));

                public NuSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NuSVR set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NuSVR set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NuSVR set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class OneClassSVM
            {
                public OneClassSVM(string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, float tol = 0.001f, float nu = 0.5f, bool shrinking = true, int cache_size = 200, bool verbose = false, int max_iter = -1)
                {
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray dual_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_coef_"));
                public int fit_status_ => Helpers.ToCSharpNDarray(self.GetAttr("fit_status_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray n_support_ => Helpers.ToCSharpNDarray(self.GetAttr("n_support_"));
                public float offset_ => Helpers.ToCSharpNDarray(self.GetAttr("offset_"));
                public NDarray shape_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("shape_fit_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public NDarray support_vectors_ => Helpers.ToCSharpNDarray(self.GetAttr("support_vectors_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public OneClassSVM fit(NDarray X, NDarray? sample_weight = null)
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

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public OneClassSVM set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public OneClassSVM set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class SVC
            {
                public SVC(float C = 1.0f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, bool probability = false, float tol = 0.001f, int cache_size = 200, PyDict? class_weight = null, bool verbose = false, int max_iter = -1, string decision_function_shape = "ovr", bool break_ties = false, int? random_state = null)
                {
                }

                public NDarray class_weight_ => Helpers.ToCSharpNDarray(self.GetAttr("class_weight_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray dual_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_coef_"));
                public int fit_status_ => Helpers.ToCSharpNDarray(self.GetAttr("fit_status_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public NDarray support_vectors_ => Helpers.ToCSharpNDarray(self.GetAttr("support_vectors_"));
                public NDarray n_support_ => Helpers.ToCSharpNDarray(self.GetAttr("n_support_"));
                public NDarray probA_ => Helpers.ToCSharpNDarray(self.GetAttr("probA_"));
                public NDarray probB_ => Helpers.ToCSharpNDarray(self.GetAttr("probB_"));
                public NDarray shape_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("shape_fit_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public SVC set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public SVC set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public SVC set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class SVR
            {
                public SVR(string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, float tol = 0.001f, float C = 1.0f, float epsilon = 0.1f, bool shrinking = true, int cache_size = 200, bool verbose = false, int max_iter = -1)
                {
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray dual_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_coef_"));
                public int fit_status_ => Helpers.ToCSharpNDarray(self.GetAttr("fit_status_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray n_support_ => Helpers.ToCSharpNDarray(self.GetAttr("n_support_"));
                public NDarray shape_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("shape_fit_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public NDarray support_vectors_ => Helpers.ToCSharpNDarray(self.GetAttr("support_vectors_"));

                public SVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public SVR set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public SVR set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public SVR set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}