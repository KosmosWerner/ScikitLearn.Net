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
        public class OneVsOneClassifier
        {
            // Constructor
            public OneVsOneClassifier(PyObject estimator, int? n_jobs = null)
            {
            }

            // Properties
            public PyTuple estimators_ => default !;
            public NDarray classes_ => default !;
            public int n_classes_ => default !;
            public PyObject pairwise_indices_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            public NDarray decision_function(NDarray X) => default !;
            [ReturnThis]
            public OneVsOneClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            [ReturnThis]
            public OneVsOneClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray predict(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public OneVsOneClassifier set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public OneVsOneClassifier set_partial_fit_request(string? classes = "$UNCHANGED$") => default !;
            [ReturnThis]
            public OneVsOneClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class OneVsRestClassifier
        {
            // Constructor
            public OneVsRestClassifier(PyObject estimator, int? n_jobs = null, int verbose = 0)
            {
            }

            // Properties
            public PyTuple estimators_ => default !;
            public NDarray classes_ => default !;
            public int n_classes_ => default !;
            public PyObject label_binarizer_ => default !;
            public bool multilabel_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            public NDarray decision_function(NDarray X) => default !;
            [ReturnThis]
            public OneVsRestClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            [ReturnThis]
            public OneVsRestClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray predict(NDarray X) => default !;
            public NDarray predict_proba(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public OneVsRestClassifier set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public OneVsRestClassifier set_partial_fit_request(string? classes = "$UNCHANGED$") => default !;
            [ReturnThis]
            public OneVsRestClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class OutputCodeClassifier
        {
            // Constructor
            public OutputCodeClassifier(PyObject estimator, float code_size = 1.5f, int? random_state = null, int? n_jobs = null)
            {
            }

            // Properties
            public PyTuple estimators_ => default !;
            public NDarray classes_ => default !;
            public NDarray code_book_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            [ReturnThis]
            public OutputCodeClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public NDarray predict(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public OutputCodeClassifier set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public OutputCodeClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }
    }
}