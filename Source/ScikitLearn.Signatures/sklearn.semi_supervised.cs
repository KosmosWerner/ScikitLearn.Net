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
        public class LabelPropagation : PythonObject,
            @base.BaseLabelPropagation<LabelPropagation>
        {
            // Constructor
            public LabelPropagation(
                string kernel = "rbf",
                int gamma = 20,
                int n_neighbors = 7,
                int max_iter = 1000,
                float tol = 1e-3f,
                int? n_jobs = null)
            { }

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
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LabelPropagation set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LabelPropagation set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LabelSpreading : PythonObject,
            @base.BaseLabelPropagation<LabelSpreading>
        {
            // Constructor
            public LabelSpreading(
                string kernel = "rbf",
                int gamma = 20,
                int n_neighbors = 7,
                float alpha = 0.2f,
                int max_iter = 30,
                float tol = 1e-3f,
                int? n_jobs = null)
            { }

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
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public LabelSpreading set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public LabelSpreading set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        [NeedsRevision]
        public class SelfTrainingClassifier : PythonObject,
            //@base.ClassifierMixin,
            @base.MetaEstimatorMixin,
            @base.BaseEstimator<SelfTrainingClassifier>
        {
            // Constructor
            public SelfTrainingClassifier(
                @base.BaseEstimator estimator,
                float threshold = 0.75f,
                string criterion = "threshold",
                int k_best = 10,
                int? max_iter = 10,
                bool verbose = false)
            { }

            // Properties
            [NeedsRevision]
            public PyObject estimator_ => default!;
            public NDarray classes_ => default!;
            public NDarray transduction_ => default!;
            public NDarray labeled_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;
            public string termination_condition_ => default!;

            // Methods
            public NDarray decision_function(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public SelfTrainingClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict_log_proba(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict_proba(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            [NeedsRevision]
            public float score(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            // public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public SelfTrainingClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }
    }
}