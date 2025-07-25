using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class kernel_ridge
    {
        // Classes
        public class KernelRidge
        {
            // Constructor
            public KernelRidge(int alpha = 1, string kernel = "linear", float? gamma = null, int degree = 3, int coef0 = 1, PyDict? kernel_params = null)
            {
            }

            // Properties
            public NDarray dual_coef_ => default !;
            public NDarray X_fit_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            [ReturnThis]
            public KernelRidge fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public NDarray predict(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public KernelRidge set_fit_request(string? sample_weight = "$UNCHANGED$") => default !;
            [ReturnThis]
            public KernelRidge set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public KernelRidge set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }
    }
}