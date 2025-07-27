using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class dummy
    {
        // Classes
        public class DummyClassifier : PythonObject
        {
            // Constructor
            public DummyClassifier(string strategy = "prior", int? random_state = null, NDarray? constant = null)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public PyTuple n_classes_ => default!;
            public NDarray class_prior_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public bool sparse_output_ => default!;

            // Methods
            [ReturnThis]
            public DummyClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(PyObject X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public DummyClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public DummyClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public DummyClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class DummyRegressor : PythonObject
        {
            // Constructor
            public DummyRegressor(string strategy = "mean", NDarray? constant = null, float? quantile = null)
            {
            }

            // Properties
            public NDarray constant_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;

            // Methods
            [ReturnThis]
            public DummyRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?) predict(NDarray X, bool return_std = false) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public DummyRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public DummyRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public DummyRegressor set_predict_request(string? return_std = "$UNCHANGED$") => default!;
            [ReturnThis]
            public DummyRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}