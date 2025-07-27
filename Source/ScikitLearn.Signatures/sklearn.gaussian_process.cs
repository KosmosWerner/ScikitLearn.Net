using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class gaussian_process
    {
        // Classes
        public class GaussianProcessClassifier : PythonObject
        {
            // Constructor
            public GaussianProcessClassifier(PyObject? kernel = null, string? optimizer = "fmin_l_bfgs_b", int n_restarts_optimizer = 0, int max_iter_predict = 100, bool warm_start = false, bool copy_X_train = true, int? random_state = null, string multi_class = "one_vs_rest", int? n_jobs = null)
            {
            }

            // Properties
            public PyObject base_estimator_ => default!;
            public PyObject kernel_ => default!;
            public float log_marginal_likelihood_value_ => default!;
            public NDarray classes_ => default!;
            public int n_classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public GaussianProcessClassifier fit(PyObject X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (float?, NDarray?) log_marginal_likelihood(NDarray? theta = null, bool eval_gradient = false, bool clone_kernel = true) => default!;
            public NDarray predict(PyObject X) => default!;
            public NDarray predict_proba(PyObject X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public GaussianProcessClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public GaussianProcessClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class GaussianProcessRegressor : PythonObject
        {
            // Constructor
            public GaussianProcessRegressor(PyObject? kernel = null, float alpha = 1e-10f, string? optimizer = "fmin_l_bfgs_b", int n_restarts_optimizer = 0, bool normalize_y = false, bool copy_X_train = true, int? n_targets = null, int? random_state = null)
            {
            }

            // Properties
            public PyObject X_train_ => default!;
            public NDarray y_train_ => default!;
            public PyObject kernel_ => default!;
            public NDarray L_ => default!;
            public NDarray alpha_ => default!;
            public float log_marginal_likelihood_value_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public GaussianProcessRegressor fit(PyObject X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (float?, NDarray?) log_marginal_likelihood(NDarray? theta = null, bool eval_gradient = false, bool clone_kernel = true) => default!;
            public (NDarray?, NDarray?, NDarray?) predict(PyObject X, bool return_std = false, bool return_cov = false) => default!;
            public NDarray sample_y(PyObject X, int n_samples = 1, int? random_state = 0) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public GaussianProcessRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public GaussianProcessRegressor set_predict_request(string? return_cov = "$UNCHANGED$", string? return_std = "$UNCHANGED$") => default!;
            [ReturnThis]
            public GaussianProcessRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        [Module]
        public static class kernels
        {
            // Classes
            public class CompoundKernel : PythonObject
            {
                // Constructor
                public CompoundKernel(PyTuple kernels)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(PyObject X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public CompoundKernel set_params() => default!;
            }

            public class ConstantKernel : PythonObject
            {
                // Constructor
                public ConstantKernel(float constant_value = 1.0f, PyTuple? constant_value_bounds = null)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(PyObject X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public ConstantKernel set_params() => default!;
            }

            public class DotProduct : PythonObject
            {
                // Constructor
                public DotProduct(float sigma_0 = 1.0f, PyTuple? sigma_0_bounds = null)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(NDarray X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public DotProduct set_params() => default!;
            }

            public class ExpSineSquared : PythonObject
            {
                // Constructor
                public ExpSineSquared(float length_scale = 1.0f, float periodicity = 1.0f, PyTuple? length_scale_bounds = null, PyTuple? periodicity_bounds = null)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(NDarray X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public ExpSineSquared set_params() => default!;
            }

            public class Exponentiation : PythonObject
            {
                // Constructor
                public Exponentiation(PyObject kernel, float exponent)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(PyObject X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public Exponentiation set_params() => default!;
            }

            public class Hyperparameter : PythonObject
            {
                // Constructor
                public Hyperparameter(int n_elements = 1)
                {
                }

                // Properties
                public string name => default!;
                public string value_type => default!;
                public float bounds => default!;
                public int n_elements => default!;
                public bool @fixed => default!;

                // Methods
                public void count()
                {
                }

                public void index(int start = 0)
                {
                }
            }

            public class Kernel : PythonObject
            {
                // Constructor
                public Kernel()
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(NDarray X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public Kernel set_params() => default!;
            }

            public class Matern : PythonObject
            {
                // Constructor
                public Matern(float length_scale = 1.0f, PyTuple? length_scale_bounds = null, float nu = 1.5f)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(NDarray X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public Matern set_params() => default!;
            }

            public class PairwiseKernel : PythonObject
            {
                // Constructor
                public PairwiseKernel(float gamma = 1.0f, PyTuple? gamma_bounds = null, string metric = "linear", PyDict? pairwise_kernels_kwargs = null)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(NDarray X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public PairwiseKernel set_params() => default!;
            }

            public class Product : PythonObject
            {
                // Constructor
                public Product(PyObject k1, PyObject k2)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(PyObject X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public Product set_params() => default!;
            }

            public class RBF : PythonObject
            {
                // Constructor
                public RBF(float length_scale = 1.0f, PyTuple? length_scale_bounds = null)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(NDarray X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public RBF set_params() => default!;
            }

            public class RationalQuadratic : PythonObject
            {
                // Constructor
                public RationalQuadratic(float length_scale = 1.0f, float alpha = 1.0f, PyTuple? length_scale_bounds = null, PyTuple? alpha_bounds = null)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(NDarray X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public RationalQuadratic set_params() => default!;
            }

            public class Sum : PythonObject
            {
                // Constructor
                public Sum(PyObject k1, PyObject k2)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(PyObject X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public Sum set_params() => default!;
            }

            public class WhiteKernel : PythonObject
            {
                // Constructor
                public WhiteKernel(float noise_level = 1.0f, PyTuple? noise_level_bounds = null)
                {
                }

                // Methods
                public void clone_with_theta(NDarray theta)
                {
                }

                public NDarray diag(PyObject X) => default!;
                public PyDict get_params(bool deep = true) => default!;
                public void is_stationary()
                {
                }

                [ReturnThis]
                public WhiteKernel set_params() => default!;
            }
        }
    }
}