using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class impute
    {
        // Classes
        public class IterativeImputer : PythonObject
        {
            // Constructor
            public IterativeImputer(PyObject? estimator = null, int? missing_values = null, bool sample_posterior = false, int max_iter = 10, float tol = 0.001f, int? n_nearest_features = null, string initial_strategy = "mean", string? fill_value = null, string imputation_order = "ascending", bool skip_complete = false, NDarray? min_value = null, float max_value = float.PositiveInfinity, int verbose = 0, int? random_state = null, bool add_indicator = false, bool keep_empty_features = false)
            {
            }

            // Properties
            public PyObject initial_imputer_ => default!;
            public PyTuple imputation_sequence_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_features_with_missing_ => default!;
            public PyObject indicator_ => default!;
            public PyObject random_state_ => default!;

            // Methods
            [ReturnThis]
            public IterativeImputer fit(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray fit_transform(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public IterativeImputer set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public IterativeImputer set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class KNNImputer : PythonObject
        {
            // Constructor
            public KNNImputer(string? missing_values = null, int n_neighbors = 5, string weights = "uniform", string metric = "nan_euclidean", bool copy = true, bool add_indicator = false, bool keep_empty_features = false)
            {
            }

            // Properties
            public PyObject indicator_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public KNNImputer fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public KNNImputer set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public KNNImputer set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class MissingIndicator : PythonObject
        {
            // Constructor
            public MissingIndicator(string? missing_values = null, string features = "missing-only", string sparse = "auto", bool error_on_new = true)
            {
            }

            // Properties
            public NDarray features_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MissingIndicator fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public MissingIndicator set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public MissingIndicator set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SimpleImputer : PythonObject
        {
            // Constructor
            public SimpleImputer(string? missing_values = null, string strategy = "mean", string? fill_value = null, bool copy = true, bool add_indicator = false, bool keep_empty_features = false)
            {
            }

            // Properties
            public NDarray statistics_ => default!;
            public PyObject indicator_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public SimpleImputer fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [ReturnThis]
            public SimpleImputer set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public SimpleImputer set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }
    }
}