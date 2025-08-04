namespace ScikitLearn;

public interface BaseMixture<Self> :
    sklearn.@base.DensityMixin,
    sklearn.@base.BaseEstimator<Self>
{
    [Self] Self fit(NDarray X);
    NDarray fit_predict(NDarray X);
    NDarray predict(NDarray X);
    NDarray predict_proba(NDarray X);
    (NDarray X, NDarray y) sample(int n_samples = 1);
    NDarray score_samples(NDarray X);

}

public static partial class sklearn
{
    // Classes
    [Module]
    public static class mixture
    {
        // Classes
        public class BayesianGaussianMixture : PythonObject,
            BaseMixture<BayesianGaussianMixture>
        {
            // Constructor
            public BayesianGaussianMixture(
                int n_components = 1,
                string covariance_type = "full",
                float tol = 1e-3f,
                float reg_covar = 1e-6f,
                int max_iter = 100,
                int n_init = 1,
                string init_params = "kmeans",
                string weight_concentration_prior_type = "dirichlet_process",
                float? weight_concentration_prior = null,
                float? mean_precision_prior = null,
                NDarray? mean_prior = null,
                float? degrees_of_freedom_prior = null,
                [OneOf<float, NDarray>] object? covariance_prior = null,
                int? random_state = null,
                bool warm_start = false,
                int verbose = 0,
                int verbose_interval = 10)
            { }

            // Properties
            public NDarray weights_ => default!;
            public NDarray means_ => default!;
            public NDarray covariances_ => default!;
            public NDarray precisions_ => default!;
            public NDarray precisions_cholesky_ => default!;
            public bool converged_ => default!;
            public int n_iter_ => default!;
            public float lower_bound_ => default!;
            [NeedsRevision]
            public NDarray weight_concentration_prior_ => default!;
            public NDarray weight_concentration_ => default!;
            public float mean_precision_prior_ => default!;
            public NDarray mean_precision_ => default!;
            public NDarray mean_prior_ => default!;
            public float degrees_of_freedom_prior_ => default!;
            public NDarray degrees_of_freedom_ => default!;
            [NeedsRevision]
            public NDarray covariance_prior_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public BayesianGaussianMixture fit(NDarray X) => default!;
            public NDarray fit_predict(NDarray X) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public (NDarray X, NDarray y) sample(int n_samples = 1) => default!;
            public float score(NDarray X, NDarray? y) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [Self]
            public BayesianGaussianMixture set_params(params (string key, object value)[] @params) => default!;
        }

        public class GaussianMixture : PythonObject,
            BaseMixture<GaussianMixture>
        {
            // Constructor
            public GaussianMixture(
                int n_components = 1,
                string covariance_type = "full",
                float tol = 1e-3f,
                float reg_covar = 1e-6f,
                int max_iter = 100,
                int n_init = 1,
                string init_params = "kmeans",
                NDarray? weights_init = null,
                NDarray? means_init = null,
                NDarray? precisions_init = null,
                int? random_state = null,
                bool warm_start = false,
                int verbose = 0,
                int verbose_interval = 10)
            { }

            // Properties
            public NDarray weights_ => default!;
            public NDarray means_ => default!;
            public NDarray covariances_ => default!;
            public NDarray precisions_ => default!;
            public NDarray precisions_cholesky_ => default!;
            public bool converged_ => default!;
            public int n_iter_ => default!;
            public float lower_bound_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float aic(NDarray X) => default!;
            public float bic(NDarray X) => default!;
            [Self]
            public GaussianMixture fit(NDarray X) => default!;
            public NDarray fit_predict(NDarray X) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public (NDarray X, NDarray y) sample(int n_samples = 1) => default!;
            public float score(NDarray X, NDarray? y) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [Self]
            public GaussianMixture set_params(params (string key, object value)[] @params) => default!;
        }
    }
}