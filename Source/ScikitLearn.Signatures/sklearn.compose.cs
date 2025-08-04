using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class compose
    {
        // Methods
        public static PyObject make_column_selector(
            string? pattern = null, 
            PyObject? dtype_include = null,
            PyObject? dtype_exclude = null) => default!;
        public static PyObject make_column_transformer(
            PyObject[] transformers,
            string remainder = "drop", 
            float sparse_threshold = 0.3f, 
            int? n_jobs = null, 
            bool verbose = false, 
            bool verbose_feature_names_out = true, 
            bool force_int_remainder_cols = true) => default!;
        // Classes
        public class ColumnTransformer : PythonObject
        {
            // Constructor
            public ColumnTransformer(PyTuple transformers, string remainder = "drop", float sparse_threshold = 0.3f, int? n_jobs = null, PyDict? transformer_weights = null, bool verbose = false, bool verbose_feature_names_out = true, bool force_int_remainder_cols = true)
            {
            }

            // Properties
            public PyObject transformers_ => default!;
            public PyDict named_transformers_ => default!;
            public bool sparse_output_ => default!;
            public PyDict output_indices_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public ColumnTransformer fit(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public ColumnTransformer set_output(string? transform = null) => default!;
            [Self]
            public ColumnTransformer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X, params (string key, object value)[] @params) => default!;
        }

        public class TransformedTargetRegressor : PythonObject
        {
            // Constructor
            public TransformedTargetRegressor(PyObject? regressor = null, PyObject? transformer = null, PyObject? func = null, PyObject? inverse_func = null, bool check_inverse = true)
            {
            }

            // Properties
            public PyObject regressor_ => default!;
            public PyObject transformer_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public TransformedTargetRegressor fit(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            public void get_metadata_routing()
            {
            }

            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, params (string key, object value)[] @params) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public TransformedTargetRegressor set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public TransformedTargetRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}