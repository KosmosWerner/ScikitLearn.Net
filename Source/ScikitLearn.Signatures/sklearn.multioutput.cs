namespace ScikitLearn;

public interface _BaseChain<Self>
    : IBaseEstimator<Self>
{
    Self fit(NDarray X, NDarray Y, params (string key, object value)[] @params);
    NDarray predict(NDarray X);

}

public interface _MultiOutputEstimator<Self> :
    IMetaEstimatorMixin,
    IBaseEstimator<Self>
{
    Self partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null, params (string key, object value)[] @params);
    Self fit(NDarray X, NDarray y, NDarray? sample_weight = null, params (string key, object value)[] @params);
    NDarray predict(NDarray X);
}

public static partial class sklearn
{
    // Classes
    [Module]
    public static class multioutput
    {
        // Classes
        public class ClassifierChain :
            IMetaEstimatorMixin,
            IClassifierMixin,
            _BaseChain<ClassifierChain>
        {
            // Constructor
            public ClassifierChain(
                IBaseEstimator base_estimator,
                [Default(null)] NullOrOneOf<string, NDarray> order = default,
                [Default(null)] NullOrOneOf<int, IBaseCrossValidator, PyIterable> cv = default,
                [Default("predict")] OneOf<string, string[]> chain_method = default,
                int? random_state = null,
                bool verbose = false)
            { }

            // Properties
            [NeedsRevision] public PyObject classes_ => default!;
            [NeedsRevision] public PyObject estimators_ => default!;
            [NeedsRevision] public PyObject order_ => default!;
            public string chain_method_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [Self] public ClassifierChain fit(NDarray X, NDarray Y, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public ClassifierChain set_params(params (string key, object value)[] @params) => default!;
            [Self] public ClassifierChain set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultiOutputClassifier :
            IClassifierMixin,
            _MultiOutputEstimator<MultiOutputClassifier>
        {
            // Constructor
            public MultiOutputClassifier(
                IBaseEstimator estimator,
                int? n_jobs = null)
            { }

            // Properties
            public NDarray classes_ => default!;
            [NeedsRevision] public PyTuple estimators_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public MultiOutputClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public MultiOutputClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null, params (string key, object value)[] @params) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, [Ignored] NDarray? sample_weight = null) => default!;
            [Self] public MultiOutputClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public MultiOutputClassifier set_params(params (string key, object value)[] @params) => default!;
            [Self] public MultiOutputClassifier set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultiOutputRegressor :
            IRegressorMixin,
            _MultiOutputEstimator<MultiOutputRegressor>
        {
            // Constructor
            public MultiOutputRegressor(
                IBaseEstimator estimator,
                int? n_jobs = null)
            { }

            // Properties
            [NeedsRevision] public PyTuple estimators_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public MultiOutputRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public MultiOutputRegressor partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null, params (string key, object value)[] @params) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public MultiOutputRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public MultiOutputRegressor set_params(params (string key, object value)[] @params) => default!;
            [Self] public MultiOutputRegressor set_partial_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public MultiOutputRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class RegressorChain :
            IMetaEstimatorMixin,
            IRegressorMixin,
            _BaseChain<RegressorChain>
        {
            // Constructor
            public RegressorChain(
                IBaseEstimator base_estimator,
                [NullOrOneOf<string, NDarray>(null)] object? order = null,
                [NullOrOneOf<int, IBaseCrossValidator, PyIterable>(null)] object cv = null,
                int? random_state = null,
                bool verbose = false)
            { }

            // Properties
            [NeedsRevision] public PyObject estimators_ => default!;
            [NeedsRevision] public PyObject order_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public RegressorChain fit(NDarray X, NDarray Y, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public RegressorChain set_params(params (string key, object value)[] @params) => default!;
            [Self] public RegressorChain set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}