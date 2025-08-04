using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class multiclass
    {
        // Classes
        public class OneVsOneClassifier : PythonObject
        {
            // Constructor
            public OneVsOneClassifier(PyObject estimator, int? n_jobs = null)
            {
            }

            // Properties
            public PyTuple estimators_ => default!;
            public NDarray classes_ => default!;
            public int n_classes_ => default!;
            public PyObject pairwise_indices_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [Self]
            public OneVsOneClassifier fit(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public OneVsOneClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, params (string key, object value)[] @params) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public OneVsOneClassifier set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public OneVsOneClassifier set_partial_fit_request(string? classes = "$UNCHANGED$") => default!;
            [Self]
            public OneVsOneClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class OneVsRestClassifier : PythonObject
        {
            // Constructor
            public OneVsRestClassifier(PyObject estimator, int? n_jobs = null, int verbose = 0)
            {
            }

            // Properties
            public PyTuple estimators_ => default!;
            public NDarray classes_ => default!;
            public int n_classes_ => default!;
            public PyObject label_binarizer_ => default!;
            public bool multilabel_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [Self]
            public OneVsRestClassifier fit(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public OneVsRestClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, params (string key, object value)[] @params) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public OneVsRestClassifier set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public OneVsRestClassifier set_partial_fit_request(string? classes = "$UNCHANGED$") => default!;
            [Self]
            public OneVsRestClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class OutputCodeClassifier : PythonObject
        {
            // Constructor
            public OutputCodeClassifier(PyObject estimator, float code_size = 1.5f, int? random_state = null, int? n_jobs = null)
            {
            }

            // Properties
            public PyTuple estimators_ => default!;
            public NDarray classes_ => default!;
            public NDarray code_book_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public OutputCodeClassifier fit(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public OutputCodeClassifier set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public OutputCodeClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}