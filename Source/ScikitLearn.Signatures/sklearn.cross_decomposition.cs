using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class cross_decomposition
    {
        // Classes
        public class CCA
        {
            // Constructor
            public CCA(int n_components = 2, bool scale = true, int max_iter = 500, float tol = 1e-06f, bool copy = true)
            {
            }

            // Properties
            public NDarray x_weights_ => default!;
            public NDarray y_weights_ => default!;
            public NDarray x_loadings_ => default!;
            public NDarray y_loadings_ => default!;
            public NDarray x_rotations_ => default!;
            public NDarray y_rotations_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public CCA fit(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
            [ReturnThis]
            public CCA fit_transform(NDarray X, NDarray? y = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
            public NDarray predict(NDarray X, bool copy = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public CCA set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public CCA set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public CCA set_predict_request(string? copy = "$UNCHANGED$") => default!;
            [ReturnThis]
            public CCA set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public CCA set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true) => default!;
        }

        public class PLSCanonical
        {
            // Constructor
            public PLSCanonical(int n_components = 2, bool scale = true, string algorithm = "nipals", int max_iter = 500, float tol = 1e-06f, bool copy = true)
            {
            }

            // Properties
            public NDarray x_weights_ => default!;
            public NDarray y_weights_ => default!;
            public NDarray x_loadings_ => default!;
            public NDarray y_loadings_ => default!;
            public NDarray x_rotations_ => default!;
            public NDarray y_rotations_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public PLSCanonical fit(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
            [ReturnThis]
            public PLSCanonical fit_transform(NDarray X, NDarray? y = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
            public NDarray predict(NDarray X, bool copy = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public PLSCanonical set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public PLSCanonical set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public PLSCanonical set_predict_request(string? copy = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PLSCanonical set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PLSCanonical set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true) => default!;
        }

        public class PLSRegression
        {
            // Constructor
            public PLSRegression(int n_components = 2, bool scale = true, int max_iter = 500, float tol = 1e-06f, bool copy = true)
            {
            }

            // Properties
            public NDarray x_weights_ => default!;
            public NDarray y_weights_ => default!;
            public NDarray x_loadings_ => default!;
            public NDarray y_loadings_ => default!;
            public NDarray x_scores_ => default!;
            public NDarray y_scores_ => default!;
            public NDarray x_rotations_ => default!;
            public NDarray y_rotations_ => default!;
            public NDarray coef_ => default!;
            public NDarray intercept_ => default!;
            public NDarray n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public PLSRegression fit(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
            [ReturnThis]
            public PLSRegression fit_transform(NDarray X, NDarray? y = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public (NDarray?, NDarray?) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
            public NDarray predict(NDarray X, bool copy = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public PLSRegression set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public PLSRegression set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public PLSRegression set_predict_request(string? copy = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PLSRegression set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public PLSRegression set_transform_request(string? copy = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true) => default!;
        }

        public class PLSSVD
        {
            // Constructor
            public PLSSVD(int n_components = 2, bool scale = true, bool copy = true)
            {
            }

            // Properties
            public NDarray x_weights_ => default!;
            public NDarray y_weights_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public PLSSVD fit(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public PLSSVD set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public PLSSVD set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null) => default!;
        }
    }
}