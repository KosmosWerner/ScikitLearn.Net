namespace ScikitLearn;

public interface BaseLabelPropagation<Self> :
    sklearn.@base.ClassifierMixin,
    sklearn.@base.BaseEstimator<Self>
{
    [Self] Self fit(NDarray X, NDarray y);
    NDarray predict(NDarray X);
    NDarray predict_proba(NDarray X);
}

public static partial class sklearn
{
    // Classes
    [Module]
    public static class semi_supervised
    {
        // Classes
        public class LabelPropagation :
            BaseLabelPropagation<LabelPropagation>
        {
            // Constructor
            public LabelPropagation(
                string kernel = "rbf",
                int gamma = 20,
                int n_neighbors = 7,
                int max_iter = 1000,
                float tol = 1e-3f,
                int? n_jobs = null)
            { }

            // Properties
            public NDarray X_ => default!;
            public NDarray classes_ => default!;
            public NDarray label_distributions_ => default!;
            public NDarray transduction_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [Self] public LabelPropagation fit(NDarray X, NDarray y) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public LabelPropagation set_params(params (string key, object value)[] @params) => default!;
            [Self] public LabelPropagation set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LabelSpreading :
            BaseLabelPropagation<LabelSpreading>
        {
            // Constructor
            public LabelSpreading(
                string kernel = "rbf",
                int gamma = 20,
                int n_neighbors = 7,
                float alpha = 0.2f,
                int max_iter = 30,
                float tol = 1e-3f,
                int? n_jobs = null)
            { }

            // Properties
            public NDarray X_ => default!;
            public NDarray classes_ => default!;
            public NDarray label_distributions_ => default!;
            public NDarray transduction_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [Self] public LabelSpreading fit(NDarray X, NDarray y) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public LabelSpreading set_params(params (string key, object value)[] @params) => default!;
            [Self] public LabelSpreading set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        [NeedsRevision]
        public class SelfTrainingClassifier :
            @base.ClassifierMixin,
            @base.MetaEstimatorMixin,
            @base.BaseEstimator<SelfTrainingClassifier>
        {
            // Constructor
            public SelfTrainingClassifier(
                @base.BaseEstimator estimator,
                float threshold = 0.75f,
                string criterion = "threshold",
                int k_best = 10,
                int? max_iter = 10,
                bool verbose = false)
            { }

            // Properties
            [NeedsRevision]
            public PyObject estimator_ => default!;
            public NDarray classes_ => default!;
            public NDarray transduction_ => default!;
            public NDarray labeled_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public string termination_condition_ => default!;

            // Methods
            public NDarray decision_function(NDarray X, params (string key, object value)[] @params) => default!;
            [Self] public SelfTrainingClassifier fit(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, params (string key, object value)[] @params) => default!;
            public NDarray predict_log_proba(NDarray X, params (string key, object value)[] @params) => default!;
            public NDarray predict_proba(NDarray X, params (string key, object value)[] @params) => default!;
            public float score(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            [Manual]
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) =>
                sample_weight != null ? score(X, y, (nameof(sample_weight), sample_weight)) : score(X, y, Array.Empty<(string key, object value)>());
            [Self] public SelfTrainingClassifier set_params(params (string key, object value)[] @params) => default!;
        }
    }
}