using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class discriminant_analysis
    {
        // Classes
        public class LinearDiscriminantAnalysis :
            @base.ClassNamePrefixFeaturesOutMixin,
            @base.LinearClassifierMixin,
            @base.TransformerMixin<LinearDiscriminantAnalysis>,
            @base.BaseEstimator<LinearDiscriminantAnalysis>
        {
            // Constructor
            public LinearDiscriminantAnalysis(
                string solver = "svd",
                [OneOf<string, float>] object? shrinkage = null,
                NDarray? priors = null,
                int? n_components = null,
                bool store_covariance = false,
                float tol = 0.0001f,
                PyObject? covariance_estimator = null)
            { }

            // Properties
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray covariance_ => default!;
            public NDarray explained_variance_ratio_ => default!;
            public NDarray means_ => default!;
            public NDarray priors_ => default!;
            public NDarray scalings_ => default!;
            public NDarray xbar_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [Self]
            public LinearDiscriminantAnalysis fit(NDarray X, NDarray y) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public LinearDiscriminantAnalysis set_output(string? transform = null) => default!;
            [Self]
            public LinearDiscriminantAnalysis set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public LinearDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class QuadraticDiscriminantAnalysis :
        {
            // Constructor
            public QuadraticDiscriminantAnalysis(NDarray? priors = null, float reg_param = 0.0f, bool store_covariance = false, float tol = 0.0001f)
            {
            }

            // Properties
            public NDarray covariance_ => default!;
            public NDarray means_ => default!;
            public NDarray priors_ => default!;
            public NDarray rotations_ => default!;
            public NDarray scalings_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [Self]
            public QuadraticDiscriminantAnalysis fit(NDarray X, NDarray y) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [Self]
            public QuadraticDiscriminantAnalysis set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public QuadraticDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}