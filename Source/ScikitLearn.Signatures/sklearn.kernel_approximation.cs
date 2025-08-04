namespace ScikitLearn;

public static partial class sklearn
{
    // Classes
    [Module]
    public static class kernel_approximation
    {
        // Classes
        public class AdditiveChi2Sampler :
            @base.TransformerMixin<AdditiveChi2Sampler>,
            @base.BaseEstimator<AdditiveChi2Sampler>
        {
            // Constructor
            public AdditiveChi2Sampler(
                int sample_steps = 2,
                float? sample_interval = null)
            { }

            // Properties
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public AdditiveChi2Sampler fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public AdditiveChi2Sampler set_output(string? transform = null) => default!;
            [Self] public AdditiveChi2Sampler set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class Nystroem :
            @base.ClassNamePrefixFeaturesOutMixin,
            @base.TransformerMixin<Nystroem>,
            @base.BaseEstimator<Nystroem>
        {
            // Constructor
            public Nystroem(
                string kernel = "rbf",
                float? gamma = null,
                float? coef0 = null,
                float? degree = null,
                Dictionary<string, object>? kernel_params = null,
                int n_components = 100,
                int? random_state = null,
                int? n_jobs = null)
            { }

            // Properties
            public NDarray components_ => default!;
            public NDarray component_indices_ => default!;
            public NDarray normalization_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public Nystroem fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public Nystroem set_output(string? transform = null) => default!;
            [Self] public Nystroem set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class PolynomialCountSketch :
            @base.ClassNamePrefixFeaturesOutMixin,
            @base.TransformerMixin<PolynomialCountSketch>,
            @base.BaseEstimator<PolynomialCountSketch>
        {
            // Constructor
            public PolynomialCountSketch(
                float gamma = 1.0f,
                int degree = 2,
                int coef0 = 0,
                int n_components = 100,
                int? random_state = null)
            { }

            // Properties
            public NDarray indexHash_ => default!;
            public NDarray bitHash_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public PolynomialCountSketch fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public PolynomialCountSketch set_output(string? transform = null) => default!;
            [Self] public PolynomialCountSketch set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class RBFSampler :
            @base.ClassNamePrefixFeaturesOutMixin,
            @base.TransformerMixin<RBFSampler>,
            @base.BaseEstimator<RBFSampler>
        {
            // Constructor
            public RBFSampler(
                [OneOf<float, string>(Default: 1.0f)] object gamma = default!,
                int n_components = 100,
                int? random_state = null)
            { }

            // Properties
            public NDarray random_offset_ => default!;
            public NDarray random_weights_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public RBFSampler fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public RBFSampler set_output(string? transform = null) => default!;
            [Self] public RBFSampler set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SkewedChi2Sampler :
            @base.ClassNamePrefixFeaturesOutMixin,
            @base.TransformerMixin<SkewedChi2Sampler>,
            @base.BaseEstimator<SkewedChi2Sampler>
        {
            // Constructor
            public SkewedChi2Sampler(
                float skewedness = 1.0f,
                int n_components = 100,
                int? random_state = null)
            { }

            // Properties
            public NDarray random_weights_ => default!;
            public NDarray random_offset_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public SkewedChi2Sampler fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public SkewedChi2Sampler set_output(string? transform = null) => default!;
            [Self] public SkewedChi2Sampler set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }
    }
}