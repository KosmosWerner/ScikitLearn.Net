namespace ScikitLearn;

public interface _BaseNB<Self> :
    IClassifierMixin,
    IBaseEstimator<Self>
{
    NDarray predict(NDarray X);
    NDarray predict_proba(NDarray X);
    NDarray predict_log_proba(NDarray X);
    NDarray predict_joint_log_proba(NDarray X);
}

public interface _BaseDiscreteNB<Self> :
    _BaseNB<Self>
{
    [Self] Self fit(NDarray X, NDarray y, NDarray? sample_weight = null);
    [Self] Self partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null);
}

public static partial class sklearn
{
    // Classes
    [Module]
    public static class naive_bayes
    {
        // Classes
        public class BernoulliNB :
            _BaseDiscreteNB<BernoulliNB>
        {
            // Constructor
            public BernoulliNB(
                [Default(1.0f)] OneOf<float, NDarray> alpha = default,
                bool force_alpha = true,
                float? binarize = 0.0f,
                bool fit_prior = true,
                NDarray? class_prior = null)
            { }

            // Properties
            public NDarray class_count_ => default!;
            public NDarray class_log_prior_ => default!;
            public NDarray classes_ => default!;
            public NDarray feature_count_ => default!;
            public NDarray feature_log_prob_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public BernoulliNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public BernoulliNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public BernoulliNB set_params(params (string key, object value)[] @params) => default!;
            [Self] public BernoulliNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public BernoulliNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public BernoulliNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class CategoricalNB :
            _BaseDiscreteNB<CategoricalNB>
        {
            // Constructor
            public CategoricalNB(
                float alpha = 1.0f,
                bool force_alpha = true,
                bool fit_prior = true,
                NDarray? class_prior = null,
                [Default(null)] NullOrOneOf<int, NDarray> min_categories = default)
            { }

            // Properties
            public NDarray category_count_ => default!;
            public NDarray class_count_ => default!;
            public NDarray class_log_prior_ => default!;
            public NDarray classes_ => default!;
            public NDarray feature_log_prob_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray<long> n_categories_ => default!;

            // Methods
            [Self] public CategoricalNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public CategoricalNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public CategoricalNB set_params(params (string key, object value)[] @params) => default!;
            [Self] public CategoricalNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public CategoricalNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public CategoricalNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class ComplementNB :
            _BaseDiscreteNB<ComplementNB>

        {
            // Constructor
            public ComplementNB(
                [Default(1.0f)] OneOf<float, NDarray> alpha = default,
                bool force_alpha = true,
                bool fit_prior = true,
                NDarray? class_prior = null,
                bool norm = false)
            { }

            // Properties
            public NDarray class_count_ => default!;
            public NDarray class_log_prior_ => default!;
            public NDarray classes_ => default!;
            public NDarray feature_all_ => default!;
            public NDarray feature_count_ => default!;
            public NDarray feature_log_prob_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public ComplementNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public ComplementNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public ComplementNB set_params(params (string key, object value)[] @params) => default!;
            [Self] public ComplementNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public ComplementNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public ComplementNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class GaussianNB :
            _BaseDiscreteNB<GaussianNB>  // _BaseNB
        {
            // Constructor
            public GaussianNB(
                NDarray? priors = null,
                float var_smoothing = 1e-09f)
            { }

            // Properties
            public NDarray class_count_ => default!;
            public NDarray class_prior_ => default!;
            public NDarray classes_ => default!;
            public float epsilon_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray var_ => default!;
            public NDarray theta_ => default!;

            // Methods
            [Self] public GaussianNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public GaussianNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public GaussianNB set_params(params (string key, object value)[] @params) => default!;
            [Self] public GaussianNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public GaussianNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public GaussianNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultinomialNB :
            _BaseDiscreteNB<MultinomialNB>
        {
            // Constructor
            public MultinomialNB(
                [Default(1.0f)] OneOf<float, NDarray> alpha = default,
                bool force_alpha = true,
                bool fit_prior = true,
                NDarray? class_prior = null)
            { }

            // Properties
            public NDarray class_count_ => default!;
            public NDarray class_log_prior_ => default!;
            public NDarray classes_ => default!;
            public NDarray feature_count_ => default!;
            public NDarray feature_log_prob_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public MultinomialNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public MultinomialNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public MultinomialNB set_params(params (string key, object value)[] @params) => default!;
            [Self] public MultinomialNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public MultinomialNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public MultinomialNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}