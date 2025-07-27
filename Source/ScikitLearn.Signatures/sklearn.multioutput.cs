using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class multioutput
    {
        // Classes
        public class ClassifierChain : PythonObject
        {
            // Constructor
            public ClassifierChain(PyObject base_estimator, NDarray? order = null, int? cv = null, string chain_method = "predict", int? random_state = null, bool verbose = false)
            {
            }

            // Properties
            public PyObject classes_ => default!;
            public PyObject estimators_ => default!;
            public PyObject order_ => default!;
            public string chain_method_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public ClassifierChain fit(NDarray X, NDarray Y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ClassifierChain set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ClassifierChain set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultiOutputClassifier : PythonObject
        {
            // Constructor
            public MultiOutputClassifier(PyObject estimator, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public PyTuple estimators_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MultiOutputClassifier fit(NDarray X, NDarray Y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public MultiOutputClassifier partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y) => default!;
            [ReturnThis]
            public MultiOutputClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultiOutputClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public MultiOutputClassifier set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultiOutputRegressor : PythonObject
        {
            // Constructor
            public MultiOutputRegressor(PyObject estimator, int? n_jobs = null)
            {
            }

            // Properties
            public PyTuple estimators_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MultiOutputRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public MultiOutputRegressor partial_fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public MultiOutputRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultiOutputRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public MultiOutputRegressor set_partial_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultiOutputRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class RegressorChain : PythonObject
        {
            // Constructor
            public RegressorChain(PyObject base_estimator, NDarray? order = null, int? cv = null, int? random_state = null, bool verbose = false)
            {
            }

            // Properties
            public PyObject estimators_ => default!;
            public PyObject order_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public RegressorChain fit(NDarray X, NDarray Y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public RegressorChain set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public RegressorChain set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}