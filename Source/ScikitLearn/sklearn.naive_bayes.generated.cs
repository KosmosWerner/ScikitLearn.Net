using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class naive_bayes
        {
            public class BernoulliNB
            {
                public BernoulliNB(float alpha = 1.0f, bool force_alpha = true, float? binarize = 0.0f, bool fit_prior = true, NDarray? class_prior = null)
                {
                }

                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_log_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_log_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_count_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_count_"));
                public NDarray feature_log_prob_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_log_prob_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public BernoulliNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public BernoulliNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public BernoulliNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public BernoulliNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public BernoulliNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public BernoulliNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class CategoricalNB
            {
                public CategoricalNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null, NDarray? min_categories = null)
                {
                }

                public NDarray category_count_ => Helpers.ToCSharpNDarray(self.GetAttr("category_count_"));
                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_log_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_log_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_log_prob_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_log_prob_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray<long> n_categories_ => Helpers.ToCSharpNDarray(self.GetAttr("n_categories_"));

                public CategoricalNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public CategoricalNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public CategoricalNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public CategoricalNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public CategoricalNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public CategoricalNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class ComplementNB
            {
                public ComplementNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null, bool norm = false)
                {
                }

                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_log_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_log_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_all_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_all_"));
                public NDarray feature_count_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_count_"));
                public NDarray feature_log_prob_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_log_prob_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public ComplementNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public ComplementNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public ComplementNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ComplementNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public ComplementNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ComplementNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class GaussianNB
            {
                public GaussianNB(NDarray? priors = null, float var_smoothing = 1e-09f)
                {
                }

                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public float epsilon_ => Helpers.ToCSharpNDarray(self.GetAttr("epsilon_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray var_ => Helpers.ToCSharpNDarray(self.GetAttr("var_"));
                public NDarray theta_ => Helpers.ToCSharpNDarray(self.GetAttr("theta_"));

                public GaussianNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public GaussianNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public GaussianNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public GaussianNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public GaussianNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public GaussianNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class MultinomialNB
            {
                public MultinomialNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null)
                {
                }

                public NDarray class_count_ => Helpers.ToCSharpNDarray(self.GetAttr("class_count_"));
                public NDarray class_log_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_log_prior_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_count_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_count_"));
                public NDarray feature_log_prob_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_log_prob_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MultinomialNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public MultinomialNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_joint_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public MultinomialNB set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public MultinomialNB set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public MultinomialNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public MultinomialNB set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}