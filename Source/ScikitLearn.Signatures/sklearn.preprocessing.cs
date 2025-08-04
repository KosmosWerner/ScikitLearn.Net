using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class preprocessing
    {
        // Methods
        public static NDarray add_dummy_feature(NDarray X, float value = 1.0f) => default!;
        public static NDarray binarize(NDarray X, float threshold = 0.0f, bool copy = true) => default!;
        public static NDarray label_binarize(NDarray y, NDarray classes, int neg_label = 0, int pos_label = 1, bool sparse_output = false) => default!;
        public static NDarray maxabs_scale(NDarray X, int axis = 0, bool copy = true) => default!;
        public static NDarray minmax_scale(NDarray X, PyTuple? feature_range = null, int axis = 0, bool copy = true) => default!;
        public static (NDarray?, NDarray?) normalize(NDarray X, string norm = "l2", int axis = 1, bool copy = true, bool return_norm = false) => default!;
        public static NDarray power_transform(NDarray X, string method = "yeo-johnson", bool standardize = true, bool copy = true) => default!;
        public static NDarray quantile_transform(NDarray X, int axis = 0, int n_quantiles = 1000, string output_distribution = "uniform", bool ignore_implicit_zeros = false, int? subsample = 100000, int? random_state = null, bool copy = true) => default!;
        public static NDarray robust_scale(NDarray X, int axis = 0, bool with_centering = true, bool with_scaling = true, PyTuple? quantile_range = null, bool copy = true, bool unit_variance = false) => default!;
        public static NDarray scale(NDarray X, int axis = 0, bool with_mean = true, bool with_std = true, bool copy = true) => default!;
        // Classes
        public class Binarizer : PythonObject
        {
            // Constructor
            public Binarizer(float threshold = 0.0f, bool copy = true)
            {
            }

            // Properties
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public Binarizer fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public Binarizer set_output(string? transform = null) => default!;
            [Self]
            public Binarizer set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public Binarizer set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, bool? copy = null) => default!;
        }

        public class FunctionTransformer : PythonObject
        {
            // Constructor
            public FunctionTransformer(PyObject? func = null, PyObject? inverse_func = null, bool validate = false, bool accept_sparse = false, bool check_inverse = true, PyObject? feature_names_out = null, PyDict? kw_args = null, PyDict? inv_kw_args = null)
            {
            }

            // Properties
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public FunctionTransformer fit(PyObject X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(PyObject X) => default!;
            [Self]
            public FunctionTransformer set_output(string? transform = null) => default!;
            [Self]
            public FunctionTransformer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(PyObject X) => default!;
        }

        public class KBinsDiscretizer : PythonObject
        {
            // Constructor
            public KBinsDiscretizer(int n_bins = 5, string encode = "onehot", string strategy = "quantile", float? dtype = null, int? subsample = 200000, int? random_state = null)
            {
            }

            // Properties
            public NDarray bin_edges_ => default!;
            public NDarray<long> n_bins_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public KBinsDiscretizer fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null) => default!;
            [Self]
            public KBinsDiscretizer set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public KBinsDiscretizer set_output(string? transform = null) => default!;
            [Self]
            public KBinsDiscretizer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class KernelCenterer : PythonObject
        {
            // Constructor
            public KernelCenterer()
            {
            }

            // Properties
            public NDarray K_fit_rows_ => default!;
            public float K_fit_all_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public KernelCenterer fit(NDarray K, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public KernelCenterer set_fit_request(string? K = "$UNCHANGED$") => default!;
            [Self]
            public KernelCenterer set_output(string? transform = null) => default!;
            [Self]
            public KernelCenterer set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public KernelCenterer set_transform_request(string? K = "$UNCHANGED$", string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray K, bool copy = true) => default!;
        }

        public class LabelBinarizer : PythonObject
        {
            // Constructor
            public LabelBinarizer(int neg_label = 0, int pos_label = 1, bool sparse_output = false)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public string y_type_ => default!;
            public bool sparse_input_ => default!;

            // Methods
            [Self]
            public LabelBinarizer fit(NDarray y) => default!;
            public NDarray fit_transform(NDarray y) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray Y, float? threshold = null) => default!;
            [Self]
            public LabelBinarizer set_inverse_transform_request(string? threshold = "$UNCHANGED$") => default!;
            [Self]
            public LabelBinarizer set_output(string? transform = null) => default!;
            [Self]
            public LabelBinarizer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray y) => default!;
        }

        public class LabelEncoder : PythonObject
        {
            // Constructor
            public LabelEncoder()
            {
            }

            // Properties
            public NDarray classes_ => default!;

            // Methods
            [Self]
            public LabelEncoder fit(NDarray y) => default!;
            public NDarray fit_transform(NDarray y) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray y) => default!;
            [Self]
            public LabelEncoder set_output(string? transform = null) => default!;
            [Self]
            public LabelEncoder set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray y) => default!;
        }

        public class MaxAbsScaler : PythonObject
        {
            // Constructor
            public MaxAbsScaler(bool copy = true)
            {
            }

            // Properties
            public NDarray scale_ => default!;
            public NDarray max_abs_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_samples_seen_ => default!;

            // Methods
            [Self]
            public MaxAbsScaler fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public MaxAbsScaler partial_fit(NDarray X, PyObject? y = null) => default!;
            [Self]
            public MaxAbsScaler set_output(string? transform = null) => default!;
            [Self]
            public MaxAbsScaler set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class MinMaxScaler : PythonObject
        {
            // Constructor
            public MinMaxScaler(PyTuple? feature_range = null, bool copy = true, bool clip = false)
            {
            }

            // Properties
            public NDarray min_ => default!;
            public NDarray scale_ => default!;
            public NDarray data_min_ => default!;
            public NDarray data_max_ => default!;
            public NDarray data_range_ => default!;
            public int n_features_in_ => default!;
            public int n_samples_seen_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public MinMaxScaler fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public MinMaxScaler partial_fit(NDarray X, PyObject? y = null) => default!;
            [Self]
            public MinMaxScaler set_output(string? transform = null) => default!;
            [Self]
            public MinMaxScaler set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class MultiLabelBinarizer : PythonObject
        {
            // Constructor
            public MultiLabelBinarizer(NDarray? classes = null, bool sparse_output = false)
            {
            }

            // Properties
            public NDarray classes_ => default!;

            // Methods
            [Self]
            public MultiLabelBinarizer fit(PyObject y) => default!;
            public NDarray fit_transform(PyObject y) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public PyTuple inverse_transform(NDarray yt) => default!;
            [Self]
            public MultiLabelBinarizer set_output(string? transform = null) => default!;
            [Self]
            public MultiLabelBinarizer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(PyObject y) => default!;
        }

        public class Normalizer : PythonObject
        {
            // Constructor
            public Normalizer(string norm = "l2", bool copy = true)
            {
            }

            // Properties
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public Normalizer fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public Normalizer set_output(string? transform = null) => default!;
            [Self]
            public Normalizer set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public Normalizer set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, bool? copy = null) => default!;
        }

        public class OneHotEncoder : PythonObject
        {
            // Constructor
            public OneHotEncoder(string categories = "auto", NDarray? drop = null, bool sparse_output = true, float? dtype = null, string handle_unknown = "error", float? min_frequency = null, int? max_categories = null, string feature_name_combiner = "concat")
            {
            }

            // Properties
            public NDarray categories_ => default!;
            public NDarray drop_idx_ => default!;
            public NDarray infrequent_categories_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public PyObject feature_name_combiner => default!;

            // Methods
            [Self]
            public OneHotEncoder fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public OneHotEncoder set_output(string? transform = null) => default!;
            [Self]
            public OneHotEncoder set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class OrdinalEncoder : PythonObject
        {
            // Constructor
            public OrdinalEncoder(string categories = "auto", float? dtype = null, string handle_unknown = "error", int? unknown_value = null, int? encoded_missing_value = null, float? min_frequency = null, int? max_categories = null)
            {
            }

            // Properties
            public NDarray categories_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray infrequent_categories_ => default!;

            // Methods
            [Self]
            public OrdinalEncoder fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public OrdinalEncoder set_output(string? transform = null) => default!;
            [Self]
            public OrdinalEncoder set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class PolynomialFeatures : PythonObject
        {
            // Constructor
            public PolynomialFeatures(int degree = 2, bool interaction_only = false, bool include_bias = true, string order = "C")
            {
            }

            // Properties
            public NDarray powers_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_output_features_ => default!;

            // Methods
            [Self]
            public PolynomialFeatures fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public PolynomialFeatures set_output(string? transform = null) => default!;
            [Self]
            public PolynomialFeatures set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class PowerTransformer : PythonObject
        {
            // Constructor
            public PowerTransformer(string method = "yeo-johnson", bool standardize = true, bool copy = true)
            {
            }

            // Properties
            public NDarray lambdas_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public PowerTransformer fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public PowerTransformer set_output(string? transform = null) => default!;
            [Self]
            public PowerTransformer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class QuantileTransformer : PythonObject
        {
            // Constructor
            public QuantileTransformer(int n_quantiles = 1000, string output_distribution = "uniform", bool ignore_implicit_zeros = false, int? subsample = 10000, int? random_state = null, bool copy = true)
            {
            }

            // Properties
            public int n_quantiles_ => default!;
            public NDarray quantiles_ => default!;
            public NDarray references_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public QuantileTransformer fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public QuantileTransformer set_output(string? transform = null) => default!;
            [Self]
            public QuantileTransformer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class RobustScaler : PythonObject
        {
            // Constructor
            public RobustScaler(bool with_centering = true, bool with_scaling = true, PyTuple? quantile_range = null, bool copy = true, bool unit_variance = false)
            {
            }

            // Properties
            public NDarray center_ => default!;
            public NDarray scale_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public RobustScaler fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public RobustScaler set_output(string? transform = null) => default!;
            [Self]
            public RobustScaler set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SplineTransformer : PythonObject
        {
            // Constructor
            public SplineTransformer(int n_knots = 5, int degree = 3, string knots = "uniform", string extrapolation = "constant", bool include_bias = true, string order = "C", bool sparse_output = false)
            {
            }

            // Properties
            public NDarray bsplines_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_features_out_ => default!;

            // Methods
            [Self]
            public SplineTransformer fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public SplineTransformer set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public SplineTransformer set_output(string? transform = null) => default!;
            [Self]
            public SplineTransformer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class StandardScaler : PythonObject
        {
            // Constructor
            public StandardScaler(bool copy = true, bool with_mean = true, bool with_std = true)
            {
            }

            // Properties
            public NDarray scale_ => default!;
            public NDarray mean_ => default!;
            public NDarray var_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray n_samples_seen_ => default!;

            // Methods
            [Self]
            public StandardScaler fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X, bool? copy = null) => default!;
            [Self]
            public StandardScaler partial_fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null) => default!;
            [Self]
            public StandardScaler set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public StandardScaler set_inverse_transform_request(string? copy = "$UNCHANGED$") => default!;
            [Self]
            public StandardScaler set_output(string? transform = null) => default!;
            [Self]
            public StandardScaler set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public StandardScaler set_partial_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public StandardScaler set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, bool? copy = null) => default!;
        }

        public class TargetEncoder : PythonObject
        {
            // Constructor
            public TargetEncoder(string categories = "auto", string target_type = "auto", string smooth = "auto", int cv = 5, bool shuffle = true, int? random_state = null)
            {
            }

            // Properties
            public NDarray encodings_ => default!;
            public NDarray categories_ => default!;
            public string target_type_ => default!;
            public float target_mean_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray classes_ => default!;

            // Methods
            [Self]
            public TargetEncoder fit(NDarray X, NDarray y) => default!;
            public NDarray fit_transform(NDarray X, NDarray y) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public TargetEncoder set_output(string? transform = null) => default!;
            [Self]
            public TargetEncoder set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }
    }
}