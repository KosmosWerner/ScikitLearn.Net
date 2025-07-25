using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class inspection
        {
            public static PyDict partial_dependence(PyObject estimator, NDarray X, NDarray features, NDarray? sample_weight = null, NDarray? categorical_features = null, NDarray? feature_names = null, string response_method = "auto", PyTuple? percentiles = null, int grid_resolution = 100, string method = "auto", string kind = "average")
            {
                throw new NotImplementedException();
            }

            public static PyDict permutation_importance(PyObject estimator, NDarray X, NDarray y, PyDict? scoring = null, int n_repeats = 5, int? n_jobs = null, int? random_state = null, NDarray? sample_weight = null, float max_samples = 1.0f)
            {
                throw new NotImplementedException();
            }

            public class DecisionBoundaryDisplay
            {
                public DecisionBoundaryDisplay(NDarray xx0, NDarray xx1, NDarray response, string? xlabel = null, string? ylabel = null)
                {
                }

                public PyObject surface_ => Helpers.ToCSharpNDarray(self.GetAttr("surface_"));
                public PyObject ax_ => Helpers.ToCSharpNDarray(self.GetAttr("ax_"));
                public PyObject figure_ => Helpers.ToCSharpNDarray(self.GetAttr("figure_"));

                public PyObject from_estimator(PyObject estimator, NDarray X, int grid_resolution = 100, float eps = 1.0f, string plot_method = "contourf", string response_method = "auto", string? class_of_interest = null, string? xlabel = null, string? ylabel = null, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject plot(string plot_method = "contourf", PyObject? ax = null, string? xlabel = null, string? ylabel = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class PartialDependenceDisplay
            {
                public PartialDependenceDisplay(PyDict pd_results, PyTuple features, PyTuple feature_names, int target_idx, PyDict deciles, string kind = "average", int? subsample = 1000, int? random_state = null, PyTuple? is_categorical = null)
                {
                }

                public PyObject bounding_ax_ => Helpers.ToCSharpNDarray(self.GetAttr("bounding_ax_"));
                public NDarray axes_ => Helpers.ToCSharpNDarray(self.GetAttr("axes_"));
                public NDarray lines_ => Helpers.ToCSharpNDarray(self.GetAttr("lines_"));
                public NDarray deciles_vlines_ => Helpers.ToCSharpNDarray(self.GetAttr("deciles_vlines_"));
                public NDarray deciles_hlines_ => Helpers.ToCSharpNDarray(self.GetAttr("deciles_hlines_"));
                public NDarray contours_ => Helpers.ToCSharpNDarray(self.GetAttr("contours_"));
                public NDarray bars_ => Helpers.ToCSharpNDarray(self.GetAttr("bars_"));
                public NDarray heatmaps_ => Helpers.ToCSharpNDarray(self.GetAttr("heatmaps_"));
                public PyObject figure_ => Helpers.ToCSharpNDarray(self.GetAttr("figure_"));

                public PyObject from_estimator(PyObject estimator, NDarray X, PyTuple features, NDarray? sample_weight = null, NDarray? categorical_features = null, NDarray? feature_names = null, int? target = null, string response_method = "auto", int n_cols = 3, int grid_resolution = 100, PyTuple? percentiles = null, string method = "auto", int? n_jobs = null, int verbose = 0, PyDict? line_kw = null, PyDict? ice_lines_kw = null, PyDict? pd_line_kw = null, PyDict? contour_kw = null, NDarray? ax = null, string kind = "average", bool centered = false, int? subsample = 1000, int? random_state = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject plot(NDarray? ax = null, int n_cols = 3, PyDict? line_kw = null, PyDict? ice_lines_kw = null, PyDict? pd_line_kw = null, PyDict? contour_kw = null, PyDict? bar_kw = null, PyDict? heatmap_kw = null, PyDict? pdp_lim = null, bool centered = false)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}