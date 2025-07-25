using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class mixture
        {
            public class BayesianGaussianMixture
            {
                public BayesianGaussianMixture(int n_components = 1, string covariance_type = "full", float tol = 0.001f, float reg_covar = 1e-06f, int max_iter = 100, int n_init = 1, string init_params = "kmeans", string weight_concentration_prior_type = "dirichlet_process", float? weight_concentration_prior = null, float? mean_precision_prior = null, NDarray? mean_prior = null, float? degrees_of_freedom_prior = null, NDarray? covariance_prior = null, int? random_state = null, bool warm_start = false, int verbose = 0, int verbose_interval = 10)
                {
                }

                public NDarray weights_ => Helpers.ToCSharpNDarray(self.GetAttr("weights_"));
                public NDarray means_ => Helpers.ToCSharpNDarray(self.GetAttr("means_"));
                public NDarray covariances_ => Helpers.ToCSharpNDarray(self.GetAttr("covariances_"));
                public NDarray precisions_ => Helpers.ToCSharpNDarray(self.GetAttr("precisions_"));
                public NDarray precisions_cholesky_ => Helpers.ToCSharpNDarray(self.GetAttr("precisions_cholesky_"));
                public bool converged_ => Helpers.ToCSharpNDarray(self.GetAttr("converged_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public float lower_bound_ => Helpers.ToCSharpNDarray(self.GetAttr("lower_bound_"));
                public float weight_concentration_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("weight_concentration_prior_"));
                public NDarray weight_concentration_ => Helpers.ToCSharpNDarray(self.GetAttr("weight_concentration_"));
                public float mean_precision_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_precision_prior_"));
                public NDarray mean_precision_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_precision_"));
                public NDarray mean_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_prior_"));
                public float degrees_of_freedom_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("degrees_of_freedom_prior_"));
                public NDarray degrees_of_freedom_ => Helpers.ToCSharpNDarray(self.GetAttr("degrees_of_freedom_"));
                public NDarray covariance_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_prior_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public BayesianGaussianMixture fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X)
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

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) sample(int n_samples = 1)
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

                public BayesianGaussianMixture set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class GaussianMixture
            {
                public GaussianMixture(int n_components = 1, string covariance_type = "full", float tol = 0.001f, float reg_covar = 1e-06f, int max_iter = 100, int n_init = 1, string init_params = "kmeans", NDarray? weights_init = null, NDarray? means_init = null, NDarray? precisions_init = null, int? random_state = null, bool warm_start = false, int verbose = 0, int verbose_interval = 10)
                {
                }

                public NDarray weights_ => Helpers.ToCSharpNDarray(self.GetAttr("weights_"));
                public NDarray means_ => Helpers.ToCSharpNDarray(self.GetAttr("means_"));
                public NDarray covariances_ => Helpers.ToCSharpNDarray(self.GetAttr("covariances_"));
                public NDarray precisions_ => Helpers.ToCSharpNDarray(self.GetAttr("precisions_"));
                public NDarray precisions_cholesky_ => Helpers.ToCSharpNDarray(self.GetAttr("precisions_cholesky_"));
                public bool converged_ => Helpers.ToCSharpNDarray(self.GetAttr("converged_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public float lower_bound_ => Helpers.ToCSharpNDarray(self.GetAttr("lower_bound_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float aic(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float bic(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public GaussianMixture fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X)
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

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) sample(int n_samples = 1)
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

                public GaussianMixture set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}