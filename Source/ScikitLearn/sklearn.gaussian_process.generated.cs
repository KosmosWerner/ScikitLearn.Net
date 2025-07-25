using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class gaussian_process
        {
            public class GaussianProcessClassifier
            {
                public GaussianProcessClassifier(PyObject? kernel = null, string? optimizer = "fmin_l_bfgs_b", int n_restarts_optimizer = 0, int max_iter_predict = 100, bool warm_start = false, bool copy_X_train = true, int? random_state = null, string multi_class = "one_vs_rest", int? n_jobs = null)
                {
                }

                public PyObject base_estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("base_estimator_"));
                public PyObject kernel_ => Helpers.ToCSharpNDarray(self.GetAttr("kernel_"));
                public float log_marginal_likelihood_value_ => Helpers.ToCSharpNDarray(self.GetAttr("log_marginal_likelihood_value_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public GaussianProcessClassifier fit(PyObject X, NDarray y)
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

                public (float? , NDarray? ) log_marginal_likelihood(NDarray? theta = null, bool eval_gradient = false, bool clone_kernel = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public GaussianProcessClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public GaussianProcessClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class GaussianProcessRegressor
            {
                public GaussianProcessRegressor(PyObject? kernel = null, float alpha = 1e-10f, string? optimizer = "fmin_l_bfgs_b", int n_restarts_optimizer = 0, bool normalize_y = false, bool copy_X_train = true, int? n_targets = null, int? random_state = null)
                {
                }

                public PyObject X_train_ => Helpers.ToCSharpNDarray(self.GetAttr("X_train_"));
                public NDarray y_train_ => Helpers.ToCSharpNDarray(self.GetAttr("y_train_"));
                public PyObject kernel_ => Helpers.ToCSharpNDarray(self.GetAttr("kernel_"));
                public NDarray L_ => Helpers.ToCSharpNDarray(self.GetAttr("L_"));
                public NDarray alpha_ => Helpers.ToCSharpNDarray(self.GetAttr("alpha_"));
                public float log_marginal_likelihood_value_ => Helpers.ToCSharpNDarray(self.GetAttr("log_marginal_likelihood_value_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public GaussianProcessRegressor fit(PyObject X, NDarray y)
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

                public (float? , NDarray? ) log_marginal_likelihood(NDarray? theta = null, bool eval_gradient = false, bool clone_kernel = true)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? , NDarray? ) predict(PyObject X, bool return_std = false, bool return_cov = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray sample_y(PyObject X, int n_samples = 1, int? random_state = 0)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public GaussianProcessRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public GaussianProcessRegressor set_predict_request(string? return_cov = "$UNCHANGED$", string? return_std = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public GaussianProcessRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public static class kernels
            {
                public class CompoundKernel
                {
                    public CompoundKernel(PyTuple kernels)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(PyObject X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public CompoundKernel set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class ConstantKernel
                {
                    public ConstantKernel(float constant_value = 1.0f, PyTuple? constant_value_bounds = null)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(PyObject X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public ConstantKernel set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class DotProduct
                {
                    public DotProduct(float sigma_0 = 1.0f, PyTuple? sigma_0_bounds = null)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(NDarray X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public DotProduct set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class ExpSineSquared
                {
                    public ExpSineSquared(float length_scale = 1.0f, float periodicity = 1.0f, PyTuple? length_scale_bounds = null, PyTuple? periodicity_bounds = null)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(NDarray X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public ExpSineSquared set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class Exponentiation
                {
                    public Exponentiation(PyObject kernel, float exponent)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(PyObject X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public Exponentiation set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class Hyperparameter
                {
                    public Hyperparameter(int n_elements = 1)
                    {
                    }

                    public string name => Helpers.ToCSharpNDarray(self.GetAttr("name"));
                    public string value_type => Helpers.ToCSharpNDarray(self.GetAttr("value_type"));
                    public float bounds => Helpers.ToCSharpNDarray(self.GetAttr("bounds"));
                    public int n_elements => Helpers.ToCSharpNDarray(self.GetAttr("n_elements"));
                    public bool @fixed => Helpers.ToCSharpNDarray(self.GetAttr("fixed"));

                    public void count()
                    {
                        throw new NotImplementedException();
                    }

                    public void index(int start = 0)
                    {
                        throw new NotImplementedException();
                    }
                }

                public class Kernel
                {
                    public Kernel()
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(NDarray X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public Kernel set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class Matern
                {
                    public Matern(float length_scale = 1.0f, PyTuple? length_scale_bounds = null, float nu = 1.5f)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(NDarray X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public Matern set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class PairwiseKernel
                {
                    public PairwiseKernel(float gamma = 1.0f, PyTuple? gamma_bounds = null, string metric = "linear", PyDict? pairwise_kernels_kwargs = null)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(NDarray X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public PairwiseKernel set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class Product
                {
                    public Product(PyObject k1, PyObject k2)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(PyObject X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public Product set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class RBF
                {
                    public RBF(float length_scale = 1.0f, PyTuple? length_scale_bounds = null)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(NDarray X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public RBF set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class RationalQuadratic
                {
                    public RationalQuadratic(float length_scale = 1.0f, float alpha = 1.0f, PyTuple? length_scale_bounds = null, PyTuple? alpha_bounds = null)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(NDarray X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public RationalQuadratic set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class Sum
                {
                    public Sum(PyObject k1, PyObject k2)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(PyObject X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public Sum set_params()
                    {
                        throw new NotImplementedException();
                    }
                }

                public class WhiteKernel
                {
                    public WhiteKernel(float noise_level = 1.0f, PyTuple? noise_level_bounds = null)
                    {
                    }

                    public void clone_with_theta(NDarray theta)
                    {
                        throw new NotImplementedException();
                    }

                    public NDarray diag(PyObject X)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict get_params(bool deep = true)
                    {
                        throw new NotImplementedException();
                    }

                    public void is_stationary()
                    {
                        throw new NotImplementedException();
                    }

                    public WhiteKernel set_params()
                    {
                        throw new NotImplementedException();
                    }
                }
            }
        }
    }
}