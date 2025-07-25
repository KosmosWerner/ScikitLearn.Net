using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class cross_decomposition
        {
            public class CCA
            {
                public CCA(int n_components = 2, bool scale = true, int max_iter = 500, float tol = 1e-06f, bool copy = true)
                {
                }

                public NDarray x_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("x_weights_"));
                public NDarray y_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("y_weights_"));
                public NDarray x_loadings_ => Helpers.ToCSharpNDarray(self.GetAttr("x_loadings_"));
                public NDarray y_loadings_ => Helpers.ToCSharpNDarray(self.GetAttr("y_loadings_"));
                public NDarray x_rotations_ => Helpers.ToCSharpNDarray(self.GetAttr("x_rotations_"));
                public NDarray y_rotations_ => Helpers.ToCSharpNDarray(self.GetAttr("y_rotations_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public CCA fit(NDarray X, NDarray? y = null, NDarray? Y = null)
                {
                    throw new NotImplementedException();
                }

                public CCA fit_transform(NDarray X, NDarray? y = null)
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

                public (NDarray? , NDarray? ) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X, bool copy = true)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public CCA set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public CCA set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public CCA set_predict_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public CCA set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public CCA set_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true)
                {
                    throw new NotImplementedException();
                }
            }

            public class PLSCanonical
            {
                public PLSCanonical(int n_components = 2, bool scale = true, string algorithm = "nipals", int max_iter = 500, float tol = 1e-06f, bool copy = true)
                {
                }

                public NDarray x_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("x_weights_"));
                public NDarray y_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("y_weights_"));
                public NDarray x_loadings_ => Helpers.ToCSharpNDarray(self.GetAttr("x_loadings_"));
                public NDarray y_loadings_ => Helpers.ToCSharpNDarray(self.GetAttr("y_loadings_"));
                public NDarray x_rotations_ => Helpers.ToCSharpNDarray(self.GetAttr("x_rotations_"));
                public NDarray y_rotations_ => Helpers.ToCSharpNDarray(self.GetAttr("y_rotations_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public PLSCanonical fit(NDarray X, NDarray? y = null, NDarray? Y = null)
                {
                    throw new NotImplementedException();
                }

                public PLSCanonical fit_transform(NDarray X, NDarray? y = null)
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

                public (NDarray? , NDarray? ) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X, bool copy = true)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PLSCanonical set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public PLSCanonical set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PLSCanonical set_predict_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public PLSCanonical set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public PLSCanonical set_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true)
                {
                    throw new NotImplementedException();
                }
            }

            public class PLSRegression
            {
                public PLSRegression(int n_components = 2, bool scale = true, int max_iter = 500, float tol = 1e-06f, bool copy = true)
                {
                }

                public NDarray x_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("x_weights_"));
                public NDarray y_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("y_weights_"));
                public NDarray x_loadings_ => Helpers.ToCSharpNDarray(self.GetAttr("x_loadings_"));
                public NDarray y_loadings_ => Helpers.ToCSharpNDarray(self.GetAttr("y_loadings_"));
                public NDarray x_scores_ => Helpers.ToCSharpNDarray(self.GetAttr("x_scores_"));
                public NDarray y_scores_ => Helpers.ToCSharpNDarray(self.GetAttr("y_scores_"));
                public NDarray x_rotations_ => Helpers.ToCSharpNDarray(self.GetAttr("x_rotations_"));
                public NDarray y_rotations_ => Helpers.ToCSharpNDarray(self.GetAttr("y_rotations_"));
                public NDarray coef_ => Helpers.ToCSharpNDarray(self.GetAttr("coef_"));
                public NDarray intercept_ => Helpers.ToCSharpNDarray(self.GetAttr("intercept_"));
                public NDarray n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public PLSRegression fit(NDarray X, NDarray? y = null, NDarray? Y = null)
                {
                    throw new NotImplementedException();
                }

                public PLSRegression fit_transform(NDarray X, NDarray? y = null)
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

                public (NDarray? , NDarray? ) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X, bool copy = true)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PLSRegression set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public PLSRegression set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PLSRegression set_predict_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public PLSRegression set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public PLSRegression set_transform_request(string? copy = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true)
                {
                    throw new NotImplementedException();
                }
            }

            public class PLSSVD
            {
                public PLSSVD(int n_components = 2, bool scale = true, bool copy = true)
                {
                }

                public NDarray x_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("x_weights_"));
                public NDarray y_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("y_weights_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public PLSSVD fit(NDarray X, NDarray? y = null, NDarray? Y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null)
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

                public PLSSVD set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public PLSSVD set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}