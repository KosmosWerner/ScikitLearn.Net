namespace ScikitLearn;

/// <summary>
/// Maximum likelihood covariance estimator
/// </summary>
/// <typeparam name="Self"></typeparam>
public interface IEmpiricalCovariance<Self> :
    IBaseEstimator<Self>
{
    NDarray location_ { get; }
    NDarray covariance_ { get; }
    NDarray precision_ { get; }
    int n_features_in_ { get; }
    NDarray feature_names_in_ { get; }

    NDarray get_precision();
    Self fit(NDarray X, NDarray? y = null);
    float score(NDarray X, NDarray? y = null);
    float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true);
    NDarray mahalanobis(NDarray X);
}

public interface IMinCovDet<Self> :
    IEmpiricalCovariance<Self>
{
    NDarray raw_location_ { get; }
    NDarray raw_covariance_ { get; }
    NDarray raw_support_ { get; }
    NDarray support_ { get; }
    NDarray dist_ { get; }

    NDarray correct_covariance(NDarray data);
    (NDarray location_reweighted, NDarray covariance_reweighted, NDarray support_reweighted) reweight_covariance(NDarray data);
}

public interface IBaseGraphicalLasso<Self> :
    IEmpiricalCovariance<Self>
{ }

public static partial class sklearn
{
    // Classes
    [Module]
    public static class covariance
    {
        // Methods
        public static NDarray empirical_covariance(
            NDarray X,
            bool assume_centered = false) => default!;

        [EnableItem(Item: "n_iter", If: "return_n_iter")]
        public static (NDarray covariance, NDarray precision, PyObject costs, int? n_iter) graphical_lasso(
            NDarray emp_cov,
            float alpha,
            string mode = "cd",
            float tol = 0.0001f,
            float enet_tol = 0.0001f,
            int max_iter = 100,
            bool verbose = false,
            bool return_costs = false,
            float eps = float.Epsilon,
            bool return_n_iter = false) => default!;

        public static (NDarray shrunk_cov, float shrinkage) ledoit_wolf(
            NDarray X,
            bool assume_centered = false,
            int block_size = 1000) => default!;

        public static float ledoit_wolf_shrinkage(
            NDarray X,
            bool assume_centered = false,
            int block_size = 1000) => default!;

        public static (NDarray shrunk_cov, float shrinkage) oas(
            NDarray X,
            bool assume_centered = false) => default!;

        public static NDarray shrunk_covariance(
            NDarray emp_cov,
            float shrinkage = 0.1f) => default!;

        // Classes
        public class EllipticEnvelope :
            IOutlierMixin,
            IMinCovDet<EllipticEnvelope>
        {
            // Constructor
            public EllipticEnvelope(
                bool store_precision = true,
                bool assume_centered = false,
                float? support_fraction = null,
                float contamination = 0.1f,
                int? random_state = null)
            { }

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
            [Self] public EllipticEnvelope fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_predict(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public NDarray predict(NDarray X) => default!;
            public (NDarray location_reweighted, NDarray covariance_reweighted, NDarray support_reweighted) reweight_covariance(NDarray data) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public float score(NDarray X, NDarray? y = null) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [Self] public EllipticEnvelope set_params(params (string key, object value)[] @params) => default!;
        }

        public class EmpiricalCovariance :
            IBaseEstimator<EmpiricalCovariance>,
            IEmpiricalCovariance<EmpiricalCovariance>
        {
            // Constructor
            public EmpiricalCovariance(
                bool store_precision = true,
                bool assume_centered = false)
            { }

            // Properties
            public NDarray location_ => default!;
            public NDarray covariance_ => default!;
            public NDarray precision_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [Self] public EmpiricalCovariance fit(NDarray X, NDarray? y = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X, NDarray? y = null) => default!;
            [Self] public EmpiricalCovariance set_params(params (string key, object value)[] @params) => default!;
        }

        public class GraphicalLasso :
            IBaseGraphicalLasso<GraphicalLasso>
        {
            // Constructor
            public GraphicalLasso(
                float alpha = 0.01f,
                string mode = "cd",
                string? covariance = null,
                float tol = 0.0001f,
                float enet_tol = 0.0001f,
                int max_iter = 100,
                bool verbose = false,
                float eps = float.Epsilon,
                bool assume_centered = false)
            { }

            // Properties
            public NDarray location_ => default!;
            public NDarray covariance_ => default!;
            public NDarray precision_ => default!;
            public int n_iter_ => default!;
            [NeedsRevision]
            public PyObject costs_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [Self] public GraphicalLasso fit(NDarray X, NDarray? y = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X, NDarray? y = null) => default!;
            [Self] public GraphicalLasso set_params(params (string key, object value)[] @params) => default!;
        }

        public class GraphicalLassoCV :
            IBaseGraphicalLasso<GraphicalLassoCV>
        {
            // Constructor
            public GraphicalLassoCV(
                [OneOf<int, NDarray>(Default: 4)] object alphas = default!,
                int n_refinements = 4,
                [NullOrOneOf<int, BaseCrossValidator>(Default: null)] object cv = default!,
                float tol = 0.0001f,
                float enet_tol = 0.0001f,
                int max_iter = 100,
                string mode = "cd",
                int? n_jobs = null,
                bool verbose = false,
                float eps = float.Epsilon,
                bool assume_centered = false)
            { }

            // Properties
            public NDarray location_ => default!;
            public NDarray covariance_ => default!;
            public NDarray precision_ => default!;
            [NeedsRevision]
            public PyObject costs_ => default!;
            public float alpha_ => default!;
            public Dictionary<string, NDarray> cv_results_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [Self] public GraphicalLassoCV fit(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            [Self] public GraphicalLassoCV fit(NDarray X, NDarray? y = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X, NDarray? y = null) => default!;
            [Self] public GraphicalLassoCV set_params(params (string key, object value)[] @params) => default!;
        }

        public class LedoitWolf :
            IEmpiricalCovariance<LedoitWolf>
        {
            // Constructor
            public LedoitWolf(
                bool store_precision = true,
                bool assume_centered = false,
                int block_size = 1000)
            { }

            // Properties
            public NDarray covariance_ => default!;
            public NDarray location_ => default!;
            public NDarray precision_ => default!;
            public float shrinkage_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [Self] public LedoitWolf fit(NDarray X, NDarray? y = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X, NDarray? y = null) => default!;
            [Self] public LedoitWolf set_params(params (string key, object value)[] @params) => default!;
        }

        public class MinCovDet :
            IMinCovDet<MinCovDet>
        {
            // Constructor
            public MinCovDet(
                bool store_precision = true,
                bool assume_centered = false,
                float? support_fraction = null,
                int? random_state = null)
            { }

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
            [Self] public MinCovDet fit(NDarray X, NDarray? y = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public (NDarray location_reweighted, NDarray covariance_reweighted, NDarray support_reweighted) reweight_covariance(NDarray data) => default!;
            public float score(NDarray X, NDarray? y = null) => default!;
            [Self] public MinCovDet set_params(params (string key, object value)[] @params) => default!;
        }

        public class OAS :
            IEmpiricalCovariance<OAS>
        {
            // Constructor
            public OAS(
                bool store_precision = true,
                bool assume_centered = false)
            { }

            // Properties
            public NDarray covariance_ => default!;
            public NDarray location_ => default!;
            public NDarray precision_ => default!;
            public float shrinkage_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [Self] public OAS fit(NDarray X, NDarray? y = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X, NDarray? y = null) => default!;
            [Self] public OAS set_params(params (string key, object value)[] @params) => default!;
        }

        public class ShrunkCovariance :
            IEmpiricalCovariance<ShrunkCovariance>
        {
            // Constructor
            public ShrunkCovariance(
                bool store_precision = true,
                bool assume_centered = false,
                float shrinkage = 0.1f)
            { }

            // Properties
            public NDarray covariance_ => default!;
            public NDarray location_ => default!;
            public NDarray precision_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true) => default!;
            [Self] public ShrunkCovariance fit(NDarray X, NDarray? y = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_precision() => default!;
            public NDarray mahalanobis(NDarray X) => default!;
            public float score(NDarray X, NDarray? y = null) => default!;
            [Self] public ShrunkCovariance set_params(params (string key, object value)[] @params) => default!;
        }
    }
}