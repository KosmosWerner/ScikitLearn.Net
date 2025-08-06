namespace ScikitLearn;

public static partial class sklearn
{
    // Classes
    [Module]
    public static class kernel_ridge
    {
        // Classes
        public class KernelRidge :
            IMultiOutputMixin,
            IRegressorMixin,
            IBaseEstimator<KernelRidge>
        {
            // Constructor
            public KernelRidge(
                [Default(1.0f)] OneOf<float, NDarray> alpha = default,
                string kernel = "linear",
                float? gamma = null,
                int degree = 3,
                int coef0 = 1,
                Dictionary<string, object>? kernel_params = null)
            { }

            // Properties
            public NDarray dual_coef_ => default!;
            public NDarray X_fit_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public KernelRidge fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public KernelRidge set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public KernelRidge set_params(params (string key, object value)[] @params) => default!;
            [Self] public KernelRidge set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}