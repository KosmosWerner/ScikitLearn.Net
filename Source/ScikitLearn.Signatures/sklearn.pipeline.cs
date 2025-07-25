using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class pipeline
    {
        // Methods
        public static PyObject make_pipeline(PyObject[] steps, PyObject? memory = null, bool verbose = false) => default !;
        public static PyObject make_union(PyObject[] transformers, int? n_jobs = null, bool verbose = false) => default !;
        // Classes
        public class FeatureUnion
        {
            // Constructor
            public FeatureUnion(PyTuple transformer_list, int? n_jobs = null, PyDict? transformer_weights = null, bool verbose = false, bool verbose_feature_names_out = true)
            {
            }

            // Properties
            public PyDict named_transformers => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            [ReturnThis]
            public FeatureUnion fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public string get_params(bool deep = true) => default !;
            [ReturnThis]
            public FeatureUnion set_output(PyObject? transform = null) => default !;
            [ReturnThis]
            public FeatureUnion set_params(Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray transform(NDarray X, Dictionary<string, PyObject>? @params = null) => default !;
        }

        public class Pipeline
        {
            // Constructor
            public Pipeline(PyTuple steps, PyObject? memory = null, bool verbose = false)
            {
            }

            // Properties
            public PyDict named_steps => default !;
            public NDarray classes_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            public NDarray decision_function(PyObject X, Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public Pipeline fit(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray fit_predict(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray fit_transform(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public string get_params(bool deep = true) => default !;
            public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray predict(PyObject X, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray predict_log_proba(PyObject X, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray predict_proba(PyObject X, Dictionary<string, PyObject>? @params = null) => default !;
            public float score(PyObject X, PyObject? y = null, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray score_samples(PyObject X) => default !;
            [ReturnThis]
            public Pipeline set_output(PyObject? transform = null) => default !;
            [ReturnThis]
            public Pipeline set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public Pipeline set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
            public NDarray transform(PyObject X, Dictionary<string, PyObject>? @params = null) => default !;
        }
    }
}