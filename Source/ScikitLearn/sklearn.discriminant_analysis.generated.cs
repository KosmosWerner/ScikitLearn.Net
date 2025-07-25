using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class discriminant_analysis
        {
            public class LinearDiscriminantAnalysis
            {
                public LinearDiscriminantAnalysis(string solver = "svd", float? shrinkage = null, NDarray? priors = null, int? n_components = null, bool store_covariance = false, float tol = 0.0001f, PyObject? covariance_estimator = null)
                {
                }

                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray explained_variance_ratio_ => Helpers.ToCSharpNDarray(self.GetAttr("explained_variance_ratio_"));
                public NDarray means_ => Helpers.ToCSharpNDarray(self.GetAttr("means_"));
                public NDarray priors_ => Helpers.ToCSharpNDarray(self.GetAttr("priors_"));
                public NDarray scalings_ => Helpers.ToCSharpNDarray(self.GetAttr("scalings_"));
                public NDarray xbar_ => Helpers.ToCSharpNDarray(self.GetAttr("xbar_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public LinearDiscriminantAnalysis fit(NDarray X, NDarray y)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public LinearDiscriminantAnalysis set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public LinearDiscriminantAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public LinearDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class QuadraticDiscriminantAnalysis
            {
                public QuadraticDiscriminantAnalysis(NDarray? priors = null, float reg_param = 0.0f, bool store_covariance = false, float tol = 0.0001f)
                {
                }

                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray means_ => Helpers.ToCSharpNDarray(self.GetAttr("means_"));
                public NDarray priors_ => Helpers.ToCSharpNDarray(self.GetAttr("priors_"));
                public NDarray rotations_ => Helpers.ToCSharpNDarray(self.GetAttr("rotations_"));
                public NDarray scalings_ => Helpers.ToCSharpNDarray(self.GetAttr("scalings_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public QuadraticDiscriminantAnalysis fit(NDarray X, NDarray y)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public QuadraticDiscriminantAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public QuadraticDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}