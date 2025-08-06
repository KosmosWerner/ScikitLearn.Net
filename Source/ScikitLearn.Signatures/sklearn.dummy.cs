namespace ScikitLearn;



public static partial class sklearn
{
    // Classes
    [Module]
    public static class dummy
    {
        // Classes
        public class DummyClassifier :
            IMultiOutputMixin,
            IClassifierMixin,
            IBaseEstimator<DummyClassifier>
        {
            // Constructor
            public DummyClassifier(
                string strategy = "prior",
                int? random_state = null,
                [Default(null)] NullOrOneOf<int, float, NDarray> constant = default)
            { }

            // Properties
            public NDarray classes_ => default!;
            public NDarray n_classes_ => default!;
            public NDarray class_prior_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public bool sparse_output_ => default!;

            // Methods
            [Self] public DummyClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(PyObject X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public DummyClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public DummyClassifier set_params(params (string key, object value)[] @params) => default!;
            [Self] public DummyClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class DummyRegressor :
            IMultiOutputMixin,
            IRegressorMixin,
            IBaseEstimator<DummyRegressor>
        {
            // Constructor
            public DummyRegressor(
                string strategy = "mean",
                [Default(null)] NullOrOneOf<int, float, NDarray> constant = default,
                float? quantile = null)
            { }

            // Properties
            public NDarray constant_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;

            // Methods
            [Self] public DummyRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public (NDarray y, NDarray y_std) predict(NDarray X, bool return_std = false) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public DummyRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public DummyRegressor set_params(params (string key, object value)[] @params) => default!;
            [Self] public DummyRegressor set_predict_request(string? return_std = "$UNCHANGED$") => default!;
            [Self] public DummyRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}