using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class semi_supervised
    {
        // Classes
        public class LabelPropagation
        {
            // Constructor
            public LabelPropagation(string kernel = "rbf", int gamma = 20, int n_neighbors = 7, int max_iter = 1000, float tol = 0.001f, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray X_ => default!;
            public NDarray classes_ => default!;
            public NDarray label_distributions_ => default!;
            public NDarray transduction_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [ReturnThis]
            public LabelPropagation fit(NDarray X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LabelPropagation set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LabelPropagation set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LabelSpreading
        {
            // Constructor
            public LabelSpreading(string kernel = "rbf", int gamma = 20, int n_neighbors = 7, float alpha = 0.2f, int max_iter = 30, float tol = 0.001f, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray X_ => default!;
            public NDarray classes_ => default!;
            public NDarray label_distributions_ => default!;
            public NDarray transduction_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [ReturnThis]
            public LabelSpreading fit(NDarray X, NDarray y) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LabelSpreading set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LabelSpreading set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class SelfTrainingClassifier
        {
            // Constructor
            public SelfTrainingClassifier(PyObject base_estimator, float threshold = 0.75f, string criterion = "threshold", int k_best = 10, int? max_iter = 10, bool verbose = false)
            {
            }

            // Properties
            public PyObject base_estimator_ => default!;
            public NDarray classes_ => default!;
            public NDarray transduction_ => default!;
            public NDarray labeled_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public PyObject termination_condition_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public SelfTrainingClassifier fit(NDarray X, NDarray y) => default!;
            public void get_metadata_routing()
            {
            }

            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y) => default!;
            [ReturnThis]
            public SelfTrainingClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }
    }
}