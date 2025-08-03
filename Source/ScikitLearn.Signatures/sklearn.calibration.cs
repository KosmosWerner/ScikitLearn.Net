namespace ScikitLearn;

public static partial class sklearn
{
    // Classes
    [Module]
    public static class calibration
    {
        // Methods
        public static (NDarray prob_true, NDarray prob_pred) calibration_curve(
            NDarray y_true,
            NDarray y_prob,
            [OneOf<int, float, bool, string>] object? pos_label = null,
            int n_bins = 5,
            string strategy = "uniform") => default!;

        // Classes
        public class CalibratedClassifierCV :
            @base.ClassifierMixin,
            @base.MetaEstimatorMixin,
            @base.BaseEstimator<CalibratedClassifierCV>
        {
            // Constructor
            public CalibratedClassifierCV(
                @base.BaseEstimator? estimator = null,
                string method = "sigmoid",
                [NeedsRevision]
                [OneOf<int, IPythonWrapper, PyObject>] object? cv = null,
                int? n_jobs = null,
                [NeedsRevision]
                [OneOf<int, string>(Default:"auto")] object ensemble = default!)
            { }

            // Properties
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray calibrated_classifiers_ => default!;

            // Methods
            [Self] public CalibratedClassifierCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, params (string key, object value)[] @params) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public CalibratedClassifierCV set_params(params (string key, object value)[] @params) => default!;
            [Self] public CalibratedClassifierCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public CalibratedClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class CalibrationDisplay :
            @base._BinaryClassifierCurveDisplayMixin
        {
            // Constructor
            public CalibrationDisplay(
                NDarray prob_true,
                NDarray prob_pred,
                NDarray y_prob,
                string? estimator_name = null,
                [OneOf<int, float, bool, string>] object? pos_label = null)
            { }

            // Properties
            public PyObject line_ => default!;
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;

            // Methods

            public static CalibrationDisplay from_estimator(
                @base.BaseEstimator estimator,
                NDarray X,
                NDarray y,
                int n_bins = 5,
                string strategy = "uniform",
                [OneOf<int, float, bool, string>] object? pos_label = null,
                string? name = null,
                PyObject? ax = null,
                bool ref_line = true,
                params (string key, object value)[] @params) => default!;

            public static CalibrationDisplay from_predictions(
                NDarray y_true,
                NDarray y_prob,
                int n_bins = 5,
                string strategy = "uniform",
                [OneOf<int, float, bool, string>] object? pos_label = null,
                string? name = null,
                bool ref_line = true,
                PyObject? ax = null,
                params (string key, object value)[] @params) => default!;

            [Self]
            public CalibrationDisplay plot(
                 PyObject? ax = null,
                 string? name = null,
                 bool ref_line = true,
                 params (string key, object value)[] @params) => default!;
        }
    }
}