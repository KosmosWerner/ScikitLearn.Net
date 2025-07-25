using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class decomposition
        {
            decomposition(NDarray X, int? n_components = null, string algorithm = "parallel", string whiten = "unit-variance", string fun = "logcosh", PyDict? fun_args = null, int max_iter = 200, float tol = 0.0001f, NDarray? w_init = null, string whiten_solver = "svd", int? random_state = null, bool return_X_mean = false, bool compute_sources = true, bool return_n_iter = false)
            {
            }

            public static (NDarray? , PyDict? , NDarray? , int? ) dict_learning(NDarray X, int n_components, float alpha, int max_iter = 100, float tol = 1e-08f, string method = "lars", int? n_jobs = null, NDarray? dict_init = null, NDarray? code_init = null, PyObject? callback = null, bool verbose = false, int? random_state = null, bool return_n_iter = false, bool positive_dict = false, bool positive_code = false, int method_max_iter = 1000)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , PyDict? , int? ) dict_learning_online(NDarray X, int? n_components = 2, int alpha = 1, int max_iter = 100, bool return_code = true, NDarray? dict_init = null, PyObject? callback = null, int batch_size = 256, bool verbose = false, bool shuffle = true, int? n_jobs = null, string method = "lars", int? random_state = null, bool positive_dict = false, bool positive_code = false, int method_max_iter = 1000, float tol = 0.001f, int max_no_improvement = 10)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , NDarray? , int? ) non_negative_factorization(NDarray X, NDarray? W = null, NDarray? H = null, string? n_components = "warn", PyObject? init = null, bool update_H = true, string solver = "cd", string beta_loss = "frobenius", float tol = 0.0001f, int max_iter = 200, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, int? random_state = null, int verbose = 0, bool shuffle = false)
            {
                throw new NotImplementedException();
            }

            public static NDarray sparse_encode(NDarray X, NDarray dictionary, NDarray? gram = null, NDarray? cov = null, string algorithm = "lasso_lars", int? n_nonzero_coefs = null, float? alpha = null, bool copy_cov = true, NDarray? init = null, int max_iter = 1000, int? n_jobs = null, bool check_input = true, int verbose = 0, bool positive = false)
            {
                throw new NotImplementedException();
            }

            public class DictionaryLearning
            {
                public DictionaryLearning(int? n_components = null, int alpha = 1, int max_iter = 1000, float tol = 1e-08f, string fit_algorithm = "lars", string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, int? n_jobs = null, NDarray? code_init = null, NDarray? dict_init = null, PyObject? callback = null, bool verbose = false, bool split_sign = false, int? random_state = null, bool positive_code = false, bool positive_dict = false, int transform_max_iter = 1000)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray error_ => Helpers.ToCSharpNDarray(self.GetAttr("error_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));

                public DictionaryLearning fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X)
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

                public DictionaryLearning set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public DictionaryLearning set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class FactorAnalysis
            {
                public FactorAnalysis(int? n_components = null, float tol = 0.01f, bool copy = true, int max_iter = 1000, NDarray? noise_variance_init = null, string svd_method = "randomized", int iterated_power = 3, PyObject? rotation = null, int random_state = 0)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray loglike_ => Helpers.ToCSharpNDarray(self.GetAttr("loglike_"));
                public NDarray noise_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("noise_variance_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public FactorAnalysis fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_covariance()
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public FactorAnalysis set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public FactorAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class FastICA
            {
                public FastICA(int? n_components = null, string algorithm = "parallel", string whiten = "unit-variance", string fun = "logcosh", PyDict? fun_args = null, int max_iter = 200, float tol = 0.0001f, NDarray? w_init = null, string whiten_solver = "svd", int? random_state = null)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray mixing_ => Helpers.ToCSharpNDarray(self.GetAttr("mixing_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray whitening_ => Helpers.ToCSharpNDarray(self.GetAttr("whitening_"));

                public FastICA fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X)
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

                public NDarray inverse_transform(NDarray X, bool copy = true)
                {
                    throw new NotImplementedException();
                }

                public FastICA set_inverse_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public FastICA set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public FastICA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public FastICA set_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, bool copy = true)
                {
                    throw new NotImplementedException();
                }
            }

            public class IncrementalPCA
            {
                public IncrementalPCA(int? n_components = null, bool whiten = false, bool copy = true, int? batch_size = null)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray explained_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => Helpers.ToCSharpNDarray(self.GetAttr("singular_values_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public NDarray var_ => Helpers.ToCSharpNDarray(self.GetAttr("var_"));
                public float noise_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("noise_variance_"));
                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public int n_samples_seen_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_seen_"));
                public int batch_size_ => Helpers.ToCSharpNDarray(self.GetAttr("batch_size_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public IncrementalPCA fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_covariance()
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public IncrementalPCA partial_fit(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public IncrementalPCA set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public IncrementalPCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public IncrementalPCA set_partial_fit_request(string? check_input = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class KernelPCA
            {
                public KernelPCA(int? n_components = null, string kernel = "linear", float? gamma = null, int degree = 3, int coef0 = 1, PyDict? kernel_params = null, float alpha = 1.0f, bool fit_inverse_transform = false, string eigen_solver = "auto", int tol = 0, int? max_iter = null, string iterated_power = "auto", bool remove_zero_eig = false, int? random_state = null, bool copy_X = true, int? n_jobs = null)
                {
                }

                public NDarray eigenvalues_ => Helpers.ToCSharpNDarray(self.GetAttr("eigenvalues_"));
                public NDarray eigenvectors_ => Helpers.ToCSharpNDarray(self.GetAttr("eigenvectors_"));
                public NDarray dual_coef_ => Helpers.ToCSharpNDarray(self.GetAttr("dual_coef_"));
                public NDarray X_transformed_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("X_transformed_fit_"));
                public NDarray X_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("X_fit_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public float gamma_ => Helpers.ToCSharpNDarray(self.GetAttr("gamma_"));

                public KernelPCA fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, Dictionary<string, PyObject>? @params = null)
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

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public KernelPCA set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public KernelPCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class LatentDirichletAllocation
            {
                public LatentDirichletAllocation(int n_components = 10, float? doc_topic_prior = null, float? topic_word_prior = null, string learning_method = "batch", float learning_decay = 0.7f, float learning_offset = 10.0f, int max_iter = 10, int batch_size = 128, int evaluate_every = -1, float total_samples = 1000000.0f, float perp_tol = 0.1f, float mean_change_tol = 0.001f, int max_doc_update_iter = 100, int? n_jobs = null, int verbose = 0, int? random_state = null)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray exp_dirichlet_component_ => Helpers.ToCSharpNDarray(self.GetAttr("exp_dirichlet_component_"));
                public int n_batch_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_batch_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public float bound_ => Helpers.ToCSharpNDarray(self.GetAttr("bound_"));
                public float doc_topic_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("doc_topic_prior_"));
                public PyObject random_state_ => Helpers.ToCSharpNDarray(self.GetAttr("random_state_"));
                public float topic_word_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("topic_word_prior_"));

                public LatentDirichletAllocation fit(NDarray X)
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

                public LatentDirichletAllocation partial_fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float perplexity(NDarray X, bool sub_sampling = false)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public LatentDirichletAllocation set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public LatentDirichletAllocation set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MiniBatchDictionaryLearning
            {
                public MiniBatchDictionaryLearning(int? n_components = null, int alpha = 1, int max_iter = 1000, string fit_algorithm = "lars", int? n_jobs = null, int batch_size = 256, bool shuffle = true, NDarray? dict_init = null, string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, bool verbose = false, bool split_sign = false, int? random_state = null, bool positive_code = false, bool positive_dict = false, int transform_max_iter = 1000, PyObject? callback = null, float tol = 0.001f, int max_no_improvement = 10)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_steps_ => Helpers.ToCSharpNDarray(self.GetAttr("n_steps_"));

                public MiniBatchDictionaryLearning fit(NDarray X)
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

                public MiniBatchDictionaryLearning partial_fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchDictionaryLearning set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchDictionaryLearning set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MiniBatchNMF
            {
                public MiniBatchNMF(string? n_components = "warn", PyObject? init = null, int batch_size = 1024, string beta_loss = "frobenius", float tol = 0.0001f, int max_no_improvement = 10, int max_iter = 200, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, float forget_factor = 0.7f, bool fresh_restarts = false, int fresh_restarts_max_iter = 30, int? transform_max_iter = null, int? random_state = null, int verbose = 0)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public float reconstruction_err_ => Helpers.ToCSharpNDarray(self.GetAttr("reconstruction_err_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_steps_ => Helpers.ToCSharpNDarray(self.GetAttr("n_steps_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MiniBatchNMF fit(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? W = null, NDarray? H = null)
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

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchNMF partial_fit(NDarray X, NDarray? W = null, NDarray? H = null)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchNMF set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchNMF set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MiniBatchSparsePCA
            {
                public MiniBatchSparsePCA(int? n_components = null, int alpha = 1, float ridge_alpha = 0.01f, int max_iter = 1000, PyObject? callback = null, int batch_size = 3, bool verbose = false, bool shuffle = true, int? n_jobs = null, string method = "lars", int? random_state = null, float tol = 0.001f, int? max_no_improvement = 10)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MiniBatchSparsePCA fit(NDarray X)
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

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchSparsePCA set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchSparsePCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class NMF
            {
                public NMF(string? n_components = "warn", PyObject? init = null, string solver = "cd", string beta_loss = "frobenius", float tol = 0.0001f, int max_iter = 200, int? random_state = null, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, int verbose = 0, bool shuffle = false)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public float reconstruction_err_ => Helpers.ToCSharpNDarray(self.GetAttr("reconstruction_err_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NMF fit(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? W = null, NDarray? H = null)
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

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    throw new NotImplementedException();
                }

                public NMF set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public NMF set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class PCA
            {
                public PCA(float? n_components = null, bool copy = true, bool whiten = false, string svd_solver = "auto", float tol = 0.0f, string iterated_power = "auto", int n_oversamples = 10, string power_iteration_normalizer = "auto", int? random_state = null)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray explained_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => Helpers.ToCSharpNDarray(self.GetAttr("singular_values_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public int n_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_"));
                public float noise_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("noise_variance_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public PCA fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_covariance()
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

                public NDarray get_precision()
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public PCA set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public PCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SparseCoder
            {
                public SparseCoder(NDarray dictionary, string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, bool split_sign = false, int? n_jobs = null, bool positive_code = false, int transform_max_iter = 1000)
                {
                }

                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SparseCoder fit()
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

                public SparseCoder set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SparseCoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SparsePCA
            {
                public SparsePCA(int? n_components = null, int alpha = 1, float ridge_alpha = 0.01f, int max_iter = 1000, float tol = 1e-08f, string method = "lars", int? n_jobs = null, NDarray? U_init = null, NDarray? V_init = null, bool verbose = false, int? random_state = null)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray error_ => Helpers.ToCSharpNDarray(self.GetAttr("error_"));
                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SparsePCA fit(NDarray X)
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

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SparsePCA set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SparsePCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class TruncatedSVD
            {
                public TruncatedSVD(int n_components = 2, string algorithm = "randomized", int n_iter = 5, int n_oversamples = 10, string power_iteration_normalizer = "auto", int? random_state = null, float tol = 0.0f)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray explained_variance_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_"));
                public NDarray explained_variance_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_ratio_"));
                public NDarray singular_values_ => Helpers.ToCSharpNDarray(self.GetAttr("singular_values_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public TruncatedSVD fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X)
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

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public TruncatedSVD set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public TruncatedSVD set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}