using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class preprocessing
        {
            public static NDarray add_dummy_feature(NDarray X, float value = 1.0f)
            {
                throw new NotImplementedException();
            }

            public static NDarray binarize(NDarray X, float threshold = 0.0f, bool copy = true)
            {
                throw new NotImplementedException();
            }

            public static NDarray label_binarize(NDarray y, NDarray classes, int neg_label = 0, int pos_label = 1, bool sparse_output = false)
            {
                throw new NotImplementedException();
            }

            public static NDarray maxabs_scale(NDarray X, int axis = 0, bool copy = true)
            {
                throw new NotImplementedException();
            }

            public static NDarray minmax_scale(NDarray X, PyTuple? feature_range = null, int axis = 0, bool copy = true)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , NDarray? ) normalize(NDarray X, string norm = "l2", int axis = 1, bool copy = true, bool return_norm = false)
            {
                throw new NotImplementedException();
            }

            public static NDarray power_transform(NDarray X, string method = "yeo-johnson", bool standardize = true, bool copy = true)
            {
                throw new NotImplementedException();
            }

            public static NDarray quantile_transform(NDarray X, int axis = 0, int n_quantiles = 1000, string output_distribution = "uniform", bool ignore_implicit_zeros = false, int? subsample = 100000, int? random_state = null, bool copy = true)
            {
                throw new NotImplementedException();
            }

            public static NDarray robust_scale(NDarray X, int axis = 0, bool with_centering = true, bool with_scaling = true, PyTuple? quantile_range = null, bool copy = true, bool unit_variance = false)
            {
                throw new NotImplementedException();
            }

            public static NDarray scale(NDarray X, int axis = 0, bool with_mean = true, bool with_std = true, bool copy = true)
            {
                throw new NotImplementedException();
            }

            public class Binarizer
            {
                public Binarizer(float threshold = 0.0f, bool copy = true)
                {
                }

                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Binarizer fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public Binarizer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public Binarizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public Binarizer set_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, bool? copy = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class FunctionTransformer
            {
                public FunctionTransformer(PyObject? func = null, PyObject? inverse_func = null, bool validate = false, bool accept_sparse = false, bool check_inverse = true, PyObject? feature_names_out = null, PyDict? kw_args = null, PyDict? inv_kw_args = null)
                {
                }

                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public FunctionTransformer fit(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public FunctionTransformer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public FunctionTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(PyObject X)
                {
                    throw new NotImplementedException();
                }
            }

            public class KBinsDiscretizer
            {
                public KBinsDiscretizer(int n_bins = 5, string encode = "onehot", string strategy = "quantile", float? dtype = null, int? subsample = 200000, int? random_state = null)
                {
                }

                public NDarray bin_edges_ => Helpers.ToCSharpNDarray(self.GetAttr("bin_edges_"));
                public NDarray<long> n_bins_ => Helpers.ToCSharpNDarray(self.GetAttr("n_bins_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public KBinsDiscretizer fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    throw new NotImplementedException();
                }

                public KBinsDiscretizer set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public KBinsDiscretizer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public KBinsDiscretizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class KernelCenterer
            {
                public KernelCenterer()
                {
                }

                public NDarray K_fit_rows_ => Helpers.ToCSharpNDarray(self.GetAttr("K_fit_rows_"));
                public float K_fit_all_ => Helpers.ToCSharpNDarray(self.GetAttr("K_fit_all_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public KernelCenterer fit(NDarray K, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public KernelCenterer set_fit_request(string? K = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public KernelCenterer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public KernelCenterer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public KernelCenterer set_transform_request(string? K = "$UNCHANGED$", string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray K, bool copy = true)
                {
                    throw new NotImplementedException();
                }
            }

            public class LabelBinarizer
            {
                public LabelBinarizer(int neg_label = 0, int pos_label = 1, bool sparse_output = false)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public string y_type_ => Helpers.ToCSharpNDarray(self.GetAttr("y_type_"));
                public bool sparse_input_ => Helpers.ToCSharpNDarray(self.GetAttr("sparse_input_"));

                public LabelBinarizer fit(NDarray y)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray y)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray Y, float? threshold = null)
                {
                    throw new NotImplementedException();
                }

                public LabelBinarizer set_inverse_transform_request(string? threshold = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public LabelBinarizer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public LabelBinarizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray y)
                {
                    throw new NotImplementedException();
                }
            }

            public class LabelEncoder
            {
                public LabelEncoder()
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));

                public LabelEncoder fit(NDarray y)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray y)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray y)
                {
                    throw new NotImplementedException();
                }

                public LabelEncoder set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public LabelEncoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray y)
                {
                    throw new NotImplementedException();
                }
            }

            public class MaxAbsScaler
            {
                public MaxAbsScaler(bool copy = true)
                {
                }

                public NDarray scale_ => Helpers.ToCSharpNDarray(self.GetAttr("scale_"));
                public NDarray max_abs_ => Helpers.ToCSharpNDarray(self.GetAttr("max_abs_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_seen_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_seen_"));

                public MaxAbsScaler fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public MaxAbsScaler partial_fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public MaxAbsScaler set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public MaxAbsScaler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MinMaxScaler
            {
                public MinMaxScaler(PyTuple? feature_range = null, bool copy = true, bool clip = false)
                {
                }

                public NDarray min_ => Helpers.ToCSharpNDarray(self.GetAttr("min_"));
                public NDarray scale_ => Helpers.ToCSharpNDarray(self.GetAttr("scale_"));
                public NDarray data_min_ => Helpers.ToCSharpNDarray(self.GetAttr("data_min_"));
                public NDarray data_max_ => Helpers.ToCSharpNDarray(self.GetAttr("data_max_"));
                public NDarray data_range_ => Helpers.ToCSharpNDarray(self.GetAttr("data_range_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public int n_samples_seen_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_seen_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MinMaxScaler fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public MinMaxScaler partial_fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public MinMaxScaler set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public MinMaxScaler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MultiLabelBinarizer
            {
                public MultiLabelBinarizer(NDarray? classes = null, bool sparse_output = false)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));

                public MultiLabelBinarizer fit(PyObject y)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(PyObject y)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public PyTuple inverse_transform(NDarray yt)
                {
                    throw new NotImplementedException();
                }

                public MultiLabelBinarizer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public MultiLabelBinarizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(PyObject y)
                {
                    throw new NotImplementedException();
                }
            }

            public class Normalizer
            {
                public Normalizer(string norm = "l2", bool copy = true)
                {
                }

                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Normalizer fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public Normalizer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public Normalizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public Normalizer set_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, bool? copy = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class OneHotEncoder
            {
                public OneHotEncoder(string categories = "auto", NDarray? drop = null, bool sparse_output = true, float? dtype = null, string handle_unknown = "error", float? min_frequency = null, int? max_categories = null, string feature_name_combiner = "concat")
                {
                }

                public NDarray categories_ => Helpers.ToCSharpNDarray(self.GetAttr("categories_"));
                public NDarray drop_idx_ => Helpers.ToCSharpNDarray(self.GetAttr("drop_idx_"));
                public NDarray infrequent_categories_ => Helpers.ToCSharpNDarray(self.GetAttr("infrequent_categories_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public PyObject feature_name_combiner => Helpers.ToCSharpNDarray(self.GetAttr("feature_name_combiner"));

                public OneHotEncoder fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public OneHotEncoder set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public OneHotEncoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class OrdinalEncoder
            {
                public OrdinalEncoder(string categories = "auto", float? dtype = null, string handle_unknown = "error", int? unknown_value = null, int? encoded_missing_value = null, float? min_frequency = null, int? max_categories = null)
                {
                }

                public NDarray categories_ => Helpers.ToCSharpNDarray(self.GetAttr("categories_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray infrequent_categories_ => Helpers.ToCSharpNDarray(self.GetAttr("infrequent_categories_"));

                public OrdinalEncoder fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public OrdinalEncoder set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public OrdinalEncoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class PolynomialFeatures
            {
                public PolynomialFeatures(int degree = 2, bool interaction_only = false, bool include_bias = true, string order = "C")
                {
                }

                public NDarray powers_ => Helpers.ToCSharpNDarray(self.GetAttr("powers_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_output_features_ => Helpers.ToCSharpNDarray(self.GetAttr("n_output_features_"));

                public PolynomialFeatures fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public PolynomialFeatures set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public PolynomialFeatures set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class PowerTransformer
            {
                public PowerTransformer(string method = "yeo-johnson", bool standardize = true, bool copy = true)
                {
                }

                public NDarray lambdas_ => Helpers.ToCSharpNDarray(self.GetAttr("lambdas_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public PowerTransformer fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public PowerTransformer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public PowerTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class QuantileTransformer
            {
                public QuantileTransformer(int n_quantiles = 1000, string output_distribution = "uniform", bool ignore_implicit_zeros = false, int? subsample = 10000, int? random_state = null, bool copy = true)
                {
                }

                public int n_quantiles_ => Helpers.ToCSharpNDarray(self.GetAttr("n_quantiles_"));
                public NDarray quantiles_ => Helpers.ToCSharpNDarray(self.GetAttr("quantiles_"));
                public NDarray references_ => Helpers.ToCSharpNDarray(self.GetAttr("references_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public QuantileTransformer fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public QuantileTransformer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public QuantileTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class RobustScaler
            {
                public RobustScaler(bool with_centering = true, bool with_scaling = true, PyTuple? quantile_range = null, bool copy = true, bool unit_variance = false)
                {
                }

                public NDarray center_ => Helpers.ToCSharpNDarray(self.GetAttr("center_"));
                public NDarray scale_ => Helpers.ToCSharpNDarray(self.GetAttr("scale_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public RobustScaler fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public RobustScaler set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public RobustScaler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SplineTransformer
            {
                public SplineTransformer(int n_knots = 5, int degree = 3, string knots = "uniform", string extrapolation = "constant", bool include_bias = true, string order = "C", bool sparse_output = false)
                {
                }

                public NDarray bsplines_ => Helpers.ToCSharpNDarray(self.GetAttr("bsplines_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_features_out_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_out_"));

                public SplineTransformer fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public SplineTransformer set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public SplineTransformer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SplineTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class StandardScaler
            {
                public StandardScaler(bool copy = true, bool with_mean = true, bool with_std = true)
                {
                }

                public NDarray scale_ => Helpers.ToCSharpNDarray(self.GetAttr("scale_"));
                public NDarray mean_ => Helpers.ToCSharpNDarray(self.GetAttr("mean_"));
                public NDarray var_ => Helpers.ToCSharpNDarray(self.GetAttr("var_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray n_samples_seen_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_seen_"));

                public StandardScaler fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X, bool? copy = null)
                {
                    throw new NotImplementedException();
                }

                public StandardScaler partial_fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public StandardScaler set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public StandardScaler set_inverse_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public StandardScaler set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public StandardScaler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public StandardScaler set_partial_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public StandardScaler set_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, bool? copy = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class TargetEncoder
            {
                public TargetEncoder(string categories = "auto", string target_type = "auto", string smooth = "auto", int cv = 5, bool shuffle = true, int? random_state = null)
                {
                }

                public NDarray encodings_ => Helpers.ToCSharpNDarray(self.GetAttr("encodings_"));
                public NDarray categories_ => Helpers.ToCSharpNDarray(self.GetAttr("categories_"));
                public string target_type_ => Helpers.ToCSharpNDarray(self.GetAttr("target_type_"));
                public float target_mean_ => Helpers.ToCSharpNDarray(self.GetAttr("target_mean_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));

                public TargetEncoder fit(NDarray X, NDarray y)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray y)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public TargetEncoder set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public TargetEncoder set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}