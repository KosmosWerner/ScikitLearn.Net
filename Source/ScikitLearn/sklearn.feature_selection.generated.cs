using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class feature_selection
        {
            public static (NDarray? , NDarray? ) chi2(NDarray X, NDarray y)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , NDarray? ) f_classif(NDarray X, NDarray y)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , NDarray? ) f_regression(NDarray X, NDarray y, bool center = true, bool force_finite = true)
            {
                throw new NotImplementedException();
            }

            public static NDarray mutual_info_classif(NDarray X, NDarray y, string discrete_features = "auto", int n_neighbors = 3, bool copy = true, int? random_state = null, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static NDarray mutual_info_regression(NDarray X, NDarray y, string discrete_features = "auto", int n_neighbors = 3, bool copy = true, int? random_state = null, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static NDarray r_regression(NDarray X, NDarray y, bool center = true, bool force_finite = true)
            {
                throw new NotImplementedException();
            }

            public class GenericUnivariateSelect
            {
                public GenericUnivariateSelect(PyObject? score_func = null, string mode = "percentile", float param = 1e-05f)
                {
                }

                public NDarray scores_ => Helpers.ToCSharpNDarray(self.GetAttr("scores_"));
                public NDarray pvalues_ => Helpers.ToCSharpNDarray(self.GetAttr("pvalues_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public GenericUnivariateSelect fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public GenericUnivariateSelect set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public GenericUnivariateSelect set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class RFE
            {
                public RFE(PyObject estimator, float? n_features_to_select = null, int step = 1, int verbose = 0, string importance_getter = "auto")
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public int n_features_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray ranking_ => Helpers.ToCSharpNDarray(self.GetAttr("ranking_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public RFE fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public void get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
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

                public float score(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public RFE set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public RFE set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class RFECV
            {
                public RFECV(PyObject estimator, int step = 1, int min_features_to_select = 1, int? cv = null, string? scoring = null, int verbose = 0, int? n_jobs = null, string importance_getter = "auto")
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyDict cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public int n_features_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray ranking_ => Helpers.ToCSharpNDarray(self.GetAttr("ranking_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public RFECV fit(NDarray X, NDarray y, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public void get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
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

                public float score(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public RFECV set_fit_request(string? groups = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public RFECV set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public RFECV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SelectFdr
            {
                public SelectFdr(PyObject? score_func = null, float alpha = 0.05f)
                {
                }

                public NDarray scores_ => Helpers.ToCSharpNDarray(self.GetAttr("scores_"));
                public NDarray pvalues_ => Helpers.ToCSharpNDarray(self.GetAttr("pvalues_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SelectFdr fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SelectFdr set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SelectFdr set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SelectFpr
            {
                public SelectFpr(PyObject? score_func = null, float alpha = 0.05f)
                {
                }

                public NDarray scores_ => Helpers.ToCSharpNDarray(self.GetAttr("scores_"));
                public NDarray pvalues_ => Helpers.ToCSharpNDarray(self.GetAttr("pvalues_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SelectFpr fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SelectFpr set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SelectFpr set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SelectFromModel
            {
                public SelectFromModel(PyObject estimator, string? threshold = null, bool prefit = false, int norm_order = 1, int? max_features = null, string importance_getter = "auto")
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public int max_features_ => Helpers.ToCSharpNDarray(self.GetAttr("max_features_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public float threshold_ => Helpers.ToCSharpNDarray(self.GetAttr("threshold_"));

                public SelectFromModel fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SelectFromModel partial_fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public SelectFromModel set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SelectFromModel set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SelectFwe
            {
                public SelectFwe(PyObject? score_func = null, float alpha = 0.05f)
                {
                }

                public NDarray scores_ => Helpers.ToCSharpNDarray(self.GetAttr("scores_"));
                public NDarray pvalues_ => Helpers.ToCSharpNDarray(self.GetAttr("pvalues_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SelectFwe fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SelectFwe set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SelectFwe set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SelectKBest
            {
                public SelectKBest(PyObject? score_func = null, int k = 10)
                {
                }

                public NDarray scores_ => Helpers.ToCSharpNDarray(self.GetAttr("scores_"));
                public NDarray pvalues_ => Helpers.ToCSharpNDarray(self.GetAttr("pvalues_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SelectKBest fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SelectKBest set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SelectKBest set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SelectPercentile
            {
                public SelectPercentile(PyObject? score_func = null, int percentile = 10)
                {
                }

                public NDarray scores_ => Helpers.ToCSharpNDarray(self.GetAttr("scores_"));
                public NDarray pvalues_ => Helpers.ToCSharpNDarray(self.GetAttr("pvalues_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SelectPercentile fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SelectPercentile set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SelectPercentile set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SelectorMixin
            {
                public SelectorMixin()
                {
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SelectorMixin set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SequentialFeatureSelector
            {
                public SequentialFeatureSelector(PyObject estimator, string n_features_to_select = "auto", float? tol = null, string direction = "forward", string? scoring = null, int? cv = 5, int? n_jobs = null)
                {
                }

                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_features_to_select_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_to_select_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));

                public SequentialFeatureSelector fit(NDarray X, NDarray? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public void get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SequentialFeatureSelector set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SequentialFeatureSelector set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class VarianceThreshold
            {
                public VarianceThreshold(float threshold = 0.0f)
                {
                }

                public NDarray variances_ => Helpers.ToCSharpNDarray(self.GetAttr("variances_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public VarianceThreshold fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public NDarray get_support(bool indices = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public VarianceThreshold set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public VarianceThreshold set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}