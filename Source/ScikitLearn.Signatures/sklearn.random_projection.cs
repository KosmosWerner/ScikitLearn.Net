using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class random_projection
    {
        // Methods
        public static NDarray<int> johnson_lindenstrauss_min_dim(
            NDarray<int> n_samples, 
            float eps = 0.1f) => default!;

        // Classes
        public class GaussianRandomProjection : PythonObject
        {
            // Constructor
            public GaussianRandomProjection(
                string n_components = "auto", 
                float eps = 0.1f, 
                bool compute_inverse_components = false, 
                int? random_state = null)
            {
            }

            // Properties
            public int n_components_ => default!;
            public NDarray components_ => default!;
            public NDarray inverse_components_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public GaussianRandomProjection fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public GaussianRandomProjection set_output(string? transform = null) => default!;
            [Self]
            public GaussianRandomProjection set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SparseRandomProjection : PythonObject
        {
            // Constructor
            public SparseRandomProjection(string n_components = "auto", string density = "auto", float eps = 0.1f, bool dense_output = false, bool compute_inverse_components = false, int? random_state = null)
            {
            }

            // Properties
            public int n_components_ => default!;
            public NDarray components_ => default!;
            public NDarray inverse_components_ => default!;
            public float density_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SparseRandomProjection fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SparseRandomProjection set_output(string? transform = null) => default!;
            [Self]
            public SparseRandomProjection set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }
    }
}