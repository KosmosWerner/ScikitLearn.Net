using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class feature_selection
    {
        // Methods
        public static (NDarray?, NDarray?) chi2(NDarray X, NDarray y) => default!;
        public static (NDarray?, NDarray?) f_classif(NDarray X, NDarray y) => default!;
        public static (NDarray?, NDarray?) f_regression(NDarray X, NDarray y, bool center = true, bool force_finite = true) => default!;
        public static NDarray mutual_info_classif(NDarray X, NDarray y, string discrete_features = "auto", int n_neighbors = 3, bool copy = true, int? random_state = null, int? n_jobs = null) => default!;
        public static NDarray mutual_info_regression(NDarray X, NDarray y, string discrete_features = "auto", int n_neighbors = 3, bool copy = true, int? random_state = null, int? n_jobs = null) => default!;
        public static NDarray r_regression(NDarray X, NDarray y, bool center = true, bool force_finite = true) => default!;
        // Classes
        public class GenericUnivariateSelect : PythonObject
        {
            // Constructor
            public GenericUnivariateSelect(PyObject? score_func = null, string mode = "percentile", float param = 1e-05f)
            {
            }

            // Properties
            public NDarray scores_ => default!;
            public NDarray pvalues_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public GenericUnivariateSelect fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public GenericUnivariateSelect set_output(string? transform = null) => default!;
            [Self]
            public GenericUnivariateSelect set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class RFE : PythonObject
        {
            // Constructor
            public RFE(PyObject estimator, float? n_features_to_select = null, int step = 1, int verbose = 0, string importance_getter = "auto")
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public PyObject estimator_ => default!;
            public int n_features_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray ranking_ => default!;
            public NDarray support_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [Self]
            public RFE fit(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public void get_metadata_routing()
            {
            }

            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            [Self]
            public RFE set_output(string? transform = null) => default!;
            [Self]
            public RFE set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class RFECV : PythonObject
        {
            // Constructor
            public RFECV(PyObject estimator, int step = 1, int min_features_to_select = 1, int? cv = null, string? scoring = null, int verbose = 0, int? n_jobs = null, string importance_getter = "auto")
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public PyObject estimator_ => default!;
            public PyDict cv_results_ => default!;
            public int n_features_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray ranking_ => default!;
            public NDarray support_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [Self]
            public RFECV fit(NDarray X, NDarray y, NDarray? groups = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public void get_metadata_routing()
            {
            }

            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, params (string key, object value)[] @params) => default!;
            [Self]
            public RFECV set_fit_request(string? groups = "$UNCHANGED$") => default!;
            [Self]
            public RFECV set_output(string? transform = null) => default!;
            [Self]
            public RFECV set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SelectFdr : PythonObject
        {
            // Constructor
            public SelectFdr(PyObject? score_func = null, float alpha = 0.05f)
            {
            }

            // Properties
            public NDarray scores_ => default!;
            public NDarray pvalues_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SelectFdr fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SelectFdr set_output(string? transform = null) => default!;
            [Self]
            public SelectFdr set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SelectFpr : PythonObject
        {
            // Constructor
            public SelectFpr(PyObject? score_func = null, float alpha = 0.05f)
            {
            }

            // Properties
            public NDarray scores_ => default!;
            public NDarray pvalues_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SelectFpr fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SelectFpr set_output(string? transform = null) => default!;
            [Self]
            public SelectFpr set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SelectFromModel : PythonObject
        {
            // Constructor
            public SelectFromModel(PyObject estimator, string? threshold = null, bool prefit = false, int norm_order = 1, int? max_features = null, string importance_getter = "auto")
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public int n_features_in_ => default!;
            public int max_features_ => default!;
            public NDarray feature_names_in_ => default!;
            public float threshold_ => default!;

            // Methods
            [Self]
            public SelectFromModel fit(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SelectFromModel partial_fit(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            [Self]
            public SelectFromModel set_output(string? transform = null) => default!;
            [Self]
            public SelectFromModel set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SelectFwe : PythonObject
        {
            // Constructor
            public SelectFwe(PyObject? score_func = null, float alpha = 0.05f)
            {
            }

            // Properties
            public NDarray scores_ => default!;
            public NDarray pvalues_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SelectFwe fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SelectFwe set_output(string? transform = null) => default!;
            [Self]
            public SelectFwe set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SelectKBest : PythonObject
        {
            // Constructor
            public SelectKBest(PyObject? score_func = null, int k = 10)
            {
            }

            // Properties
            public NDarray scores_ => default!;
            public NDarray pvalues_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SelectKBest fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SelectKBest set_output(string? transform = null) => default!;
            [Self]
            public SelectKBest set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SelectPercentile : PythonObject
        {
            // Constructor
            public SelectPercentile(PyObject? score_func = null, int percentile = 10)
            {
            }

            // Properties
            public NDarray scores_ => default!;
            public NDarray pvalues_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SelectPercentile fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SelectPercentile set_output(string? transform = null) => default!;
            [Self]
            public SelectPercentile set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SelectorMixin : PythonObject
        {
            // Constructor
            public SelectorMixin()
            {
            }

            // Methods
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SelectorMixin set_output(string? transform = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SequentialFeatureSelector : PythonObject
        {
            // Constructor
            public SequentialFeatureSelector(PyObject estimator, string n_features_to_select = "auto", float? tol = null, string direction = "forward", string? scoring = null, int? cv = 5, int? n_jobs = null)
            {
            }

            // Properties
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_features_to_select_ => default!;
            public NDarray support_ => default!;

            // Methods
            [Self]
            public SequentialFeatureSelector fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public void get_metadata_routing()
            {
            }

            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public SequentialFeatureSelector set_output(string? transform = null) => default!;
            [Self]
            public SequentialFeatureSelector set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class VarianceThreshold : PythonObject
        {
            // Constructor
            public VarianceThreshold(float threshold = 0.0f)
            {
            }

            // Properties
            public NDarray variances_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public VarianceThreshold fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray get_support(bool indices = false) => default!;
            public NDarray inverse_transform(NDarray X) => default!;
            [Self]
            public VarianceThreshold set_output(string? transform = null) => default!;
            [Self]
            public VarianceThreshold set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }
    }
}