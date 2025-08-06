namespace ScikitLearn;

public static partial class sklearn
{
    // Classes
    [Module]
    public static class isotonic
    {
        // Methods
        public static bool check_increasing(NDarray x, NDarray y) => default!;
        public static NDarray isotonic_regression(NDarray y, NDarray? sample_weight = null, float? y_min = null, float? y_max = null, bool increasing = true) => default!;
        // Classes
        public class IsotonicRegression :
            IRegressorMixin,
            ITransformerMixin<IsotonicRegression>,
            IBaseEstimator<IsotonicRegression>
        {
            // Constructor
            public IsotonicRegression(
                float? y_min = null,
                float? y_max = null,
                [Default(true)]OneOf<bool, string> increasing = default,
                string out_of_bounds = "nan")
            { }

            // Properties
            public float X_min_ => default!;
            public float X_max_ => default!;
            public NDarray X_thresholds_ => default!;
            public NDarray y_thresholds_ => default!;
            [NeedsRevision]
            public PyObject f_ => default!;
            public bool increasing_ => default!;

            // Methods
            [Self] public IsotonicRegression fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray T) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public IsotonicRegression set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public IsotonicRegression set_output(string? transform = null) => default!;
            [Self] public IsotonicRegression set_params(params (string key, object value)[] @params) => default!;
            [Self] public IsotonicRegression set_predict_request(string? T = "$UNCHANGED$") => default!;
            [Self] public IsotonicRegression set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public IsotonicRegression set_transform_request(string? T = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray T) => default!;
        }
    }
}