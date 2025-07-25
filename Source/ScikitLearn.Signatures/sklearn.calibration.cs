using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class calibration
    {
        // Methods
        public static (NDarray? , NDarray? ) calibration_curve(NDarray y_true, NDarray y_prob, string? pos_label = null, int n_bins = 5, string strategy = "uniform") => default !;
        // Classes
        public class CalibratedClassifierCV
        {
            // Constructor
            public CalibratedClassifierCV(PyObject? estimator = null, string method = "sigmoid", int? cv = null, int? n_jobs = null, bool ensemble = true)
            {
            }

            // Properties
            public NDarray classes_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public bool calibrated_classifiers_ => default !;

            // Methods
            [ReturnThis]
            public CalibratedClassifierCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public NDarray predict(NDarray X) => default !;
            public NDarray predict_proba(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public CalibratedClassifierCV set_fit_request(string? sample_weight = "$UNCHANGED$") => default !;
            [ReturnThis]
            public CalibratedClassifierCV set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public CalibratedClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class CalibrationDisplay
        {
            // Constructor
            public CalibrationDisplay(NDarray prob_true, NDarray prob_pred, NDarray y_prob, string? estimator_name = null, string? pos_label = null)
            {
            }

            // Properties
            public PyObject line_ => default !;
            public PyObject ax_ => default !;
            public PyObject figure_ => default !;

            // Methods
            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, int n_bins = 5, string strategy = "uniform", string? pos_label = null, string? name = null, bool ref_line = true, PyObject? ax = null, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject from_predictions(NDarray y_true, NDarray y_prob, int n_bins = 5, string strategy = "uniform", string? pos_label = null, string? name = null, bool ref_line = true, PyObject? ax = null, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject plot(PyObject? ax = null, string? name = null, bool ref_line = true, Dictionary<string, PyObject>? @params = null) => default !;
        }
    }
}