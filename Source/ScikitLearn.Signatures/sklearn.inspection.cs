using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class inspection
    {
        // Methods
        public static PyDict partial_dependence(
            @base.BaseEstimator estimator,
            NDarray X,
            NDarray features,
            NDarray? sample_weight = null,
            NDarray? categorical_features = null,
            NDarray? feature_names = null,
            string response_method = "auto",
            PyTuple? percentiles = null,
            int grid_resolution = 100,
            string method = "auto",
            string kind = "average") => default!;
        public static PyDict permutation_importance(PyObject estimator, NDarray X, NDarray y, PyDict? scoring = null, int n_repeats = 5, int? n_jobs = null, int? random_state = null, NDarray? sample_weight = null, float max_samples = 1.0f) => default!;
        // Classes
        public class DecisionBoundaryDisplay : PythonObject
        {
            // Constructor
            public DecisionBoundaryDisplay(NDarray xx0, NDarray xx1, NDarray response, string? xlabel = null, string? ylabel = null)
            {
            }

            // Properties
            public PyObject surface_ => default!;
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;

            // Methods

            public PyObject from_estimator(PyObject estimator, NDarray X, int grid_resolution = 100, float eps = 1.0f, string plot_method = "contourf", string response_method = "auto", string? class_of_interest = null, string? xlabel = null, string? ylabel = null, PyObject? ax = null, params (string key, object value)[] @params) => default!;
            public PyObject plot(string plot_method = "contourf", PyObject? ax = null, string? xlabel = null, string? ylabel = null, params (string key, object value)[] @params) => default!;
        }

        public class PartialDependenceDisplay : PythonObject
        {
            // Constructor
            public PartialDependenceDisplay(PyDict pd_results, PyTuple features, PyTuple feature_names, int target_idx, PyDict deciles, string kind = "average", int? subsample = 1000, int? random_state = null, PyTuple? is_categorical = null)
            {
            }

            // Properties
            public PyObject bounding_ax_ => default!;
            public NDarray axes_ => default!;
            public NDarray lines_ => default!;
            public NDarray deciles_vlines_ => default!;
            public NDarray deciles_hlines_ => default!;
            public NDarray contours_ => default!;
            public NDarray bars_ => default!;
            public NDarray heatmaps_ => default!;
            public PyObject figure_ => default!;

            // Methods
            public PyObject from_estimator(PyObject estimator, NDarray X, PyTuple features, NDarray? sample_weight = null, NDarray? categorical_features = null, NDarray? feature_names = null, int? target = null, string response_method = "auto", int n_cols = 3, int grid_resolution = 100, PyTuple? percentiles = null, string method = "auto", int? n_jobs = null, int verbose = 0, PyDict? line_kw = null, PyDict? ice_lines_kw = null, PyDict? pd_line_kw = null, PyDict? contour_kw = null, NDarray? ax = null, string kind = "average", bool centered = false, int? subsample = 1000, int? random_state = null) => default!;
            public PyObject plot(NDarray? ax = null, int n_cols = 3, PyDict? line_kw = null, PyDict? ice_lines_kw = null, PyDict? pd_line_kw = null, PyDict? contour_kw = null, PyDict? bar_kw = null, PyDict? heatmap_kw = null, PyDict? pdp_lim = null, bool centered = false) => default!;
        }
    }
}