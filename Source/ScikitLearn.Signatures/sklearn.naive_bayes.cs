using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class naive_bayes
    {
        // Classes
        public class BernoulliNB : PythonObject
        {
            // Constructor
            public BernoulliNB(float alpha = 1.0f, bool force_alpha = true, float? binarize = 0.0f, bool fit_prior = true, NDarray? class_prior = null)
            {
            }

            // Properties
            public NDarray class_count_ => default!;
            public NDarray class_log_prior_ => default!;
            public NDarray classes_ => default!;
            public NDarray feature_count_ => default!;
            public NDarray feature_log_prob_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public BernoulliNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public BernoulliNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public BernoulliNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public BernoulliNB set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public BernoulliNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public BernoulliNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class CategoricalNB : PythonObject
        {
            // Constructor
            public CategoricalNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null, NDarray? min_categories = null)
            {
            }

            // Properties
            public NDarray category_count_ => default!;
            public NDarray class_count_ => default!;
            public NDarray class_log_prior_ => default!;
            public NDarray classes_ => default!;
            public NDarray feature_log_prob_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray<long> n_categories_ => default!;

            // Methods
            [ReturnThis]
            public CategoricalNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public CategoricalNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public CategoricalNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public CategoricalNB set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public CategoricalNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public CategoricalNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class ComplementNB : PythonObject
        {
            // Constructor
            public ComplementNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null, bool norm = false)
            {
            }

            // Properties
            public NDarray class_count_ => default!;
            public NDarray class_log_prior_ => default!;
            public NDarray classes_ => default!;
            public NDarray feature_all_ => default!;
            public NDarray feature_count_ => default!;
            public NDarray feature_log_prob_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public ComplementNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public ComplementNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ComplementNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ComplementNB set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ComplementNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ComplementNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class GaussianNB : PythonObject
        {
            // Constructor
            public GaussianNB(NDarray? priors = null, float var_smoothing = 1e-09f)
            {
            }

            // Properties
            public NDarray class_count_ => default!;
            public NDarray class_prior_ => default!;
            public NDarray classes_ => default!;
            public float epsilon_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray var_ => default!;
            public NDarray theta_ => default!;

            // Methods
            [ReturnThis]
            public GaussianNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public GaussianNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public GaussianNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public GaussianNB set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public GaussianNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public GaussianNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class MultinomialNB : PythonObject
        {
            // Constructor
            public MultinomialNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null)
            {
            }

            // Properties
            public NDarray class_count_ => default!;
            public NDarray class_log_prior_ => default!;
            public NDarray classes_ => default!;
            public NDarray feature_count_ => default!;
            public NDarray feature_log_prob_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public MultinomialNB fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public MultinomialNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_joint_log_proba(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public MultinomialNB set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultinomialNB set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public MultinomialNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MultinomialNB set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}