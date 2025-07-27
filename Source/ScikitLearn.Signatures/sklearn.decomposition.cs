using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class decomposition
    {
        // Methods
        public static (NDarray?, PyDict?, NDarray?, int?) dict_learning(NDarray X, int n_components, float alpha, int max_iter = 100, float tol = 1e-08f, string method = "lars", int? n_jobs = null, NDarray? dict_init = null, NDarray? code_init = null, PyObject? callback = null, bool verbose = false, int? random_state = null, bool return_n_iter = false, bool positive_dict = false, bool positive_code = false, int method_max_iter = 1000) => default!;
        public static (NDarray?, PyDict?, int?) dict_learning_online(NDarray X, int? n_components = 2, int alpha = 1, int max_iter = 100, bool return_code = true, NDarray? dict_init = null, PyObject? callback = null, int batch_size = 256, bool verbose = false, bool shuffle = true, int? n_jobs = null, string method = "lars", int? random_state = null, bool positive_dict = false, bool positive_code = false, int method_max_iter = 1000, float tol = 0.001f, int max_no_improvement = 10) => default!;
        public static (NDarray?, NDarray?, NDarray?, NDarray?, int?) fastica(NDarray X, int? n_components = null, string algorithm = "parallel", string whiten = "unit-variance", string fun = "logcosh", PyDict? fun_args = null, int max_iter = 200, float tol = 0.0001f, NDarray? w_init = null, string whiten_solver = "svd", int? random_state = null, bool return_X_mean = false, bool compute_sources = true, bool return_n_iter = false) => default!;
        public static (NDarray?, NDarray?, int?) non_negative_factorization(NDarray X, NDarray? W = null, NDarray? H = null, string? n_components = "warn", PyObject? init = null, bool update_H = true, string solver = "cd", string beta_loss = "frobenius", float tol = 0.0001f, int max_iter = 200, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, int? random_state = null, int verbose = 0, bool shuffle = false) => default!;
        public static NDarray sparse_encode(NDarray X, NDarray dictionary, NDarray? gram = null, NDarray? cov = null, string algorithm = "lasso_lars", int? n_nonzero_coefs = null, float? alpha = null, bool copy_cov = true, NDarray? init = null, int max_iter = 1000, int? n_jobs = null, bool check_input = true, int verbose = 0, bool positive = false) => default!;
        // Classes
        public class DictionaryLearning : PythonObject
        {
            // Constructor
            public DictionaryLearning(int? n_components = null, int alpha = 1, int max_iter = 1000, float tol = 1e-08f, string fit_algorithm = "lars", string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, int? n_jobs = null, NDarray? code_init = null, NDarray? dict_init = null, PyObject? callback = null, bool verbose = false, bool split_sign = false, int? random_state = null, bool positive_code = false, bool positive_dict = false, int transform_max_iter = 1000)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray error_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [ReturnThis]
            public DictionaryLearning fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public DictionaryLearning set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public DictionaryLearning set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class FactorAnalysis : PythonObject
        {
            // Constructor
            public FactorAnalysis(int? n_components = null, float tol = 0.01f, bool copy = true, int max_iter = 1000, NDarray? noise_variance_init = null, string svd_method = "randomized", int iterated_power = 3, PyObject? rotation = null, int random_state = 0)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray loglike_ => default!;
            public NDarray noise_variance_ => default!;
            public int n_iter_ => default!;
            public NDarray mean_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public FactorAnalysis fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray get_covariance() => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public float score(NDarray X) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [ReturnThis]
            public FactorAnalysis set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public FactorAnalysis set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class FastICA : PythonObject
        {
            // Constructor
            public FastICA(int? n_components = null, string algorithm = "parallel", string whiten = "unit-variance", string fun = "logcosh", PyDict? fun_args = null, int max_iter = 200, float tol = 0.0001f, NDarray? w_init = null, string whiten_solver = "svd", int? random_state = null)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray mixing_ => default!;
            public NDarray mean_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public NDarray whitening_ => default!;

            // Methods
            [ReturnThis]
            public FastICA fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X, bool copy = true) => default!;
            [ReturnThis]
            public FastICA set_inverse_transform_request(string? copy = "$UNCHANGED$") => default!;
            [ReturnThis]
            public FastICA set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public FastICA set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public FastICA set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, bool copy = true) => default!;
        }

        public class IncrementalPCA : PythonObject
        {
            // Constructor
            public IncrementalPCA(int? n_components = null, bool whiten = false, bool copy = true, int? batch_size = null)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray explained_variance_ => default!;
            public NDarray explained_variance_ratio_ => default!;
            public NDarray singular_values_ => default!;
            public NDarray mean_ => default!;
            public NDarray var_ => default!;
            public float noise_variance_ => default!;
            public int n_components_ => default!;
            public int n_samples_seen_ => default!;
            public int batch_size_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public IncrementalPCA fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray get_covariance() => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [ReturnThis]
            public IncrementalPCA partial_fit(NDarray X, bool check_input = true) => default!;
            [ReturnThis]
            public IncrementalPCA set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public IncrementalPCA set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public IncrementalPCA set_partial_fit_request(string? check_input = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class KernelPCA : PythonObject
        {
            // Constructor
            public KernelPCA(int? n_components = null, string kernel = "linear", float? gamma = null, int degree = 3, int coef0 = 1, PyDict? kernel_params = null, float alpha = 1.0f, bool fit_inverse_transform = false, string eigen_solver = "auto", int tol = 0, int? max_iter = null, string iterated_power = "auto", bool remove_zero_eig = false, int? random_state = null, bool copy_X = true, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray eigenvalues_ => default!;
            public NDarray eigenvectors_ => default!;
            public NDarray dual_coef_ => default!;
            public NDarray X_transformed_fit_ => default!;
            public NDarray X_fit_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public float gamma_ => default!;

            // Methods
            [ReturnThis]
            public KernelPCA fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [ReturnThis]
            public KernelPCA set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public KernelPCA set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class LatentDirichletAllocation : PythonObject
        {
            // Constructor
            public LatentDirichletAllocation(int n_components = 10, float? doc_topic_prior = null, float? topic_word_prior = null, string learning_method = "batch", float learning_decay = 0.7f, float learning_offset = 10.0f, int max_iter = 10, int batch_size = 128, int evaluate_every = -1, float total_samples = 1000000.0f, float perp_tol = 0.1f, float mean_change_tol = 0.001f, int max_doc_update_iter = 100, int? n_jobs = null, int verbose = 0, int? random_state = null)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray exp_dirichlet_component_ => default!;
            public int n_batch_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public float bound_ => default!;
            public float doc_topic_prior_ => default!;
            public PyObject random_state_ => default!;
            public float topic_word_prior_ => default!;

            // Methods
            [ReturnThis]
            public LatentDirichletAllocation fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public LatentDirichletAllocation partial_fit(NDarray X) => default!;
            public float perplexity(NDarray X, bool sub_sampling = false) => default!;
            public float score(NDarray X) => default!;
            [ReturnThis]
            public LatentDirichletAllocation set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public LatentDirichletAllocation set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class MiniBatchDictionaryLearning : PythonObject
        {
            // Constructor
            public MiniBatchDictionaryLearning(int? n_components = null, int alpha = 1, int max_iter = 1000, string fit_algorithm = "lars", int? n_jobs = null, int batch_size = 256, bool shuffle = true, NDarray? dict_init = null, string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, bool verbose = false, bool split_sign = false, int? random_state = null, bool positive_code = false, bool positive_dict = false, int transform_max_iter = 1000, PyObject? callback = null, float tol = 0.001f, int max_no_improvement = 10)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public int n_steps_ => default!;

            // Methods
            [ReturnThis]
            public MiniBatchDictionaryLearning fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public MiniBatchDictionaryLearning partial_fit(NDarray X) => default!;
            [ReturnThis]
            public MiniBatchDictionaryLearning set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public MiniBatchDictionaryLearning set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class MiniBatchNMF : PythonObject
        {
            // Constructor
            public MiniBatchNMF(string? n_components = "warn", PyObject? init = null, int batch_size = 1024, string beta_loss = "frobenius", float tol = 0.0001f, int max_no_improvement = 10, int max_iter = 200, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, float forget_factor = 0.7f, bool fresh_restarts = false, int fresh_restarts_max_iter = 30, int? transform_max_iter = null, int? random_state = null, int verbose = 0)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public int n_components_ => default!;
            public float reconstruction_err_ => default!;
            public int n_iter_ => default!;
            public int n_steps_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MiniBatchNMF fit(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? W = null, NDarray? H = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null) => default!;
            [ReturnThis]
            public MiniBatchNMF partial_fit(NDarray X, NDarray? W = null, NDarray? H = null) => default!;
            [ReturnThis]
            public MiniBatchNMF set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public MiniBatchNMF set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class MiniBatchSparsePCA : PythonObject
        {
            // Constructor
            public MiniBatchSparsePCA(int? n_components = null, int alpha = 1, float ridge_alpha = 0.01f, int max_iter = 1000, PyObject? callback = null, int batch_size = 3, bool verbose = false, bool shuffle = true, int? n_jobs = null, string method = "lars", int? random_state = null, float tol = 0.001f, int? max_no_improvement = 10)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public int n_components_ => default!;
            public int n_iter_ => default!;
            public NDarray mean_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MiniBatchSparsePCA fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [ReturnThis]
            public MiniBatchSparsePCA set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public MiniBatchSparsePCA set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class NMF : PythonObject
        {
            // Constructor
            public NMF(string? n_components = "warn", PyObject? init = null, string solver = "cd", string beta_loss = "frobenius", float tol = 0.0001f, int max_iter = 200, int? random_state = null, float alpha_W = 0.0f, string alpha_H = "same", float l1_ratio = 0.0f, int verbose = 0, bool shuffle = false)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public int n_components_ => default!;
            public float reconstruction_err_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public NMF fit(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? W = null, NDarray? H = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null) => default!;
            [ReturnThis]
            public NMF set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public NMF set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class PCA : PythonObject
        {
            // Constructor
            public PCA(float? n_components = null, bool copy = true, bool whiten = false, string svd_solver = "auto", float tol = 0.0f, string iterated_power = "auto", int n_oversamples = 10, string power_iteration_normalizer = "auto", int? random_state = null)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray explained_variance_ => default!;
            public NDarray explained_variance_ratio_ => default!;
            public NDarray singular_values_ => default!;
            public NDarray mean_ => default!;
            public int n_components_ => default!;
            public int n_samples_ => default!;
            public float noise_variance_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public PCA fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public NDarray get_covariance() => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            public float score(NDarray X) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [ReturnThis]
            public PCA set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public PCA set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SparseCoder : PythonObject
        {
            // Constructor
            public SparseCoder(NDarray dictionary, string transform_algorithm = "omp", int? transform_n_nonzero_coefs = null, float? transform_alpha = null, bool split_sign = false, int? n_jobs = null, bool positive_code = false, int transform_max_iter = 1000)
            {
            }

            // Properties
            public int n_components_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public SparseCoder fit() => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public SparseCoder set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public SparseCoder set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SparsePCA : PythonObject
        {
            // Constructor
            public SparsePCA(int? n_components = null, int alpha = 1, float ridge_alpha = 0.01f, int max_iter = 1000, float tol = 1e-08f, string method = "lars", int? n_jobs = null, NDarray? U_init = null, NDarray? V_init = null, bool verbose = false, int? random_state = null)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray error_ => default!;
            public int n_components_ => default!;
            public int n_iter_ => default!;
            public NDarray mean_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public SparsePCA fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [ReturnThis]
            public SparsePCA set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public SparsePCA set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class TruncatedSVD : PythonObject
        {
            // Constructor
            public TruncatedSVD(int n_components = 2, string algorithm = "randomized", int n_iter = 5, int n_oversamples = 10, string power_iteration_normalizer = "auto", int? random_state = null, float tol = 0.0f)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray explained_variance_ => default!;
            public NDarray explained_variance_ratio_ => default!;
            public NDarray singular_values_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public TruncatedSVD fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [ReturnThis]
            public TruncatedSVD set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public TruncatedSVD set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }
    }
}