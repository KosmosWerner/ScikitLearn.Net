namespace ScikitLearn;

public interface _PLS<Self> :
            IClassNamePrefixFeaturesOutMixin,
            ITransformerMixin<Self>,
            IRegressorMixin,
            IMultiOutputMixin,
            IBaseEstimator<Self>
{
    Self fit(NDarray X, NDarray? y = null);
    NDarray transform(NDarray X, NDarray? y = null, bool copy = true);
}

public static partial class sklearn
{
    // Classes
    [Module]
    public static class cross_decomposition
    {
        // Classes
        public class CCA :
            _PLS<CCA>
        {
            // Constructor
            public CCA(
                int n_components = 2,
                bool scale = true,
                int max_iter = 500,
                float tol = 1e-06f,
                bool copy = true)
            { }

            // Properties
            public NDarray x_weights_ => default!;
            public NDarray y_weights_ => default!;
            public NDarray x_loadings_ => default!;
            public NDarray y_loadings_ => default!;
            public NDarray x_rotations_ => default!;
            public NDarray y_rotations_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public CCA fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [EnableItem(Item: "y", If: "y != null")]
            public (NDarray X, NDarray? y) inverse_transform(NDarray X, NDarray? y = null) => default!;
            public NDarray predict(NDarray X, bool copy = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public CCA set_output(string? transform = null) => default!;
            [Self] public CCA set_params(params (string key, object value)[] @params) => default!;
            [Self] public CCA set_predict_request(string? copy = "$UNCHANGED$") => default!;
            [Self] public CCA set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public CCA set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, NDarray? y = null, bool copy = true) => default!;
        }

        public class PLSCanonical :
            _PLS<PLSCanonical>
        {
            // Constructor
            public PLSCanonical(
                int n_components = 2,
                bool scale = true,
                string algorithm = "nipals",
                int max_iter = 500,
                float tol = 1e-06f,
                bool copy = true)
            { }

            // Properties
            public NDarray x_weights_ => default!;
            public NDarray y_weights_ => default!;
            public NDarray x_loadings_ => default!;
            public NDarray y_loadings_ => default!;
            public NDarray x_rotations_ => default!;
            public NDarray y_rotations_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public PLSCanonical fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public (NDarray X, NDarray? y) inverse_transform(NDarray X, NDarray? y = null) => default!;
            public NDarray predict(NDarray X, bool copy = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public PLSCanonical set_output(string? transform = null) => default!;
            [Self] public PLSCanonical set_params(params (string key, object value)[] @params) => default!;
            [Self] public PLSCanonical set_predict_request(string? copy = "$UNCHANGED$") => default!;
            [Self] public PLSCanonical set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public PLSCanonical set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, NDarray? y = null, bool copy = true) => default!;
        }

        public class PLSRegression :
            _PLS<PLSRegression>
        {
            // Constructor
            public PLSRegression(
                int n_components = 2,
                bool scale = true,
                int max_iter = 500,
                float tol = 1e-06f,
                bool copy = true)
            { }

            // Properties
            public NDarray x_weights_ => default!;
            public NDarray y_weights_ => default!;
            public NDarray x_loadings_ => default!;
            public NDarray y_loadings_ => default!;
            public NDarray x_scores_ => default!;
            public NDarray y_scores_ => default!;
            public NDarray x_rotations_ => default!;
            public NDarray y_rotations_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public PLSRegression fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
            public NDarray predict(NDarray X, bool copy = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self] public PLSRegression set_output(string? transform = null) => default!;
            [Self] public PLSRegression set_params(params (string key, object value)[] @params) => default!;
            [Self] public PLSRegression set_predict_request(string? copy = "$UNCHANGED$") => default!;
            [Self] public PLSRegression set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public PLSRegression set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, NDarray? y = null, bool copy = true) => default!;
        }

        public class PLSSVD :
            IClassNamePrefixFeaturesOutMixin,
            ITransformerMixin<PLSSVD>,
            IBaseEstimator<PLSSVD>
        {
            // Constructor
            public PLSSVD(
                int n_components = 2,
                bool scale = true,
                bool copy = true)
            { }

            // Properties
            public NDarray x_weights_ => default!;
            public NDarray y_weights_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public PLSSVD fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public PLSSVD set_output(string? transform = null) => default!;
            [Self]
            public PLSSVD set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X, NDarray? y = null) => default!;
        }
    }
}