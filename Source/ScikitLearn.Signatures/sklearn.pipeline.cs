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
        public static Pipeline make_pipeline(
            @base.BaseEstimator[] steps,
            [OneOf<string, joblib.memory.Memory>] object? memory = null,
            NDarray<string>? transform_input = null,
            bool verbose = false) => default!;

        public static FeatureUnion make_union(
            @base.TransformerMixin[] transformers,
            int? n_jobs = null,
            bool verbose = false,
            bool verbose_feature_names_out = true) => default!;

        // Classes
        public class FeatureUnion : PythonObject,
            @base.TransformerMixin<FeatureUnion>,
            @base._BaseComposition<FeatureUnion>
        {
            // Constructor
            public FeatureUnion(
                (string name, @base.TransformerMixin transformer)[] transformer_list,
                int? n_jobs = null,
                Dictionary<string, float>? transformer_weights = null,
                bool verbose = false,
                bool verbose_feature_names_out = true)
            { }

            // Properties
            public utils.Bunch named_transformers => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public FeatureUnion fit(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public FeatureUnion set_output(string? transform = null) => default!;
            [Self]
            public FeatureUnion set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X, params (string key, object value)[] @params) => default!;
        }

        public class Pipeline : PythonObject,
            @base._BaseComposition<Pipeline>
        {
            // Constructor
            public Pipeline(
                (string name, @base.BaseEstimator estimator)[] steps,
                NDarray<string>? transform_input = null,
                OneOf<string, joblib.memory.Memory>? memory = null,
                bool verbose = false)
            { }

            // Properties
            public utils.Bunch named_steps => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [NeedsRevision]
            public NDarray decision_function(PyIterable X, params (string key, object value)[] @params) => default!;

            [Self]
            [NeedsRevision]
            public Pipeline fit(PyIterable X, PyIterable? y = null, params (string key, object value)[] @params) => default!;
            [NeedsRevision]
            public NDarray fit_predict(PyIterable X, PyIterable? y = null, params (string key, object value)[] @params) => default!;
            [NeedsRevision]
            public NDarray fit_transform(PyIterable X, PyIterable? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray X, NDarray? Xt = null, params (string key, object value)[] @params) => default!;
            [NeedsRevision]
            public NDarray predict(PyIterable X, params (string key, object value)[] @params) => default!;
            [NeedsRevision]
            public NDarray predict_log_proba(PyIterable X, params (string key, object value)[] @params) => default!;
            [NeedsRevision]
            public NDarray predict_proba(PyIterable X, params (string key, object value)[] @params) => default!;
            [NeedsRevision]
            public float score(PyIterable X, PyObject? y = null, NDarray? sample_weight = null, params (string key, object value)[] @params) => default!;
            [NeedsRevision]
            public NDarray score_samples(PyIterable X) => default!;
            [Self]
            public Pipeline set_output(string? transform = null) => default!;
            [Self]
            public Pipeline set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public Pipeline set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [NeedsRevision]
            public NDarray transform(PyIterable X, params (string key, object value)[] @params) => default!;
        }
    }
}