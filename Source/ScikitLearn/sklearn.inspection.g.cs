namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class inspection
    {
        private static Lazy<PyObject> _lazy_self;
        public static PyObject self { get => _lazy_self.Value; }

        private static void ReInitializeLazySelf()
        {
            _lazy_self = new Lazy<PyObject>(() =>
            {
                try
                {
                    return InstallAndImport();
                }
                catch (Exception)
                {
                    return InstallAndImport(true);
                }
            });
        }

        private static PyObject InstallAndImport(bool force = false)
        {
            PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
            PythonEngine.Initialize();
            return Py.Import("sklearn.inspection");
        }

        static inspection() => ReInitializeLazySelf();
        public static PyDict partial_dependence(PyObject estimator, NDarray X, NDarray features, NDarray? sample_weight = null, NDarray? categorical_features = null, NDarray? feature_names = null, string response_method = "auto", PyTuple? percentiles = null, int grid_resolution = 100, string method = "auto", string kind = "average")
        {
            _ = sklearn.inspection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(features) });
            PyDict pyDict = new PyDict();
            if (sample_weight != null)
                pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
            if (categorical_features != null)
                pyDict["categorical_features"] = Helpers.ToPython(categorical_features);
            if (feature_names != null)
                pyDict["feature_names"] = Helpers.ToPython(feature_names);
            if (response_method != "auto")
                pyDict["response_method"] = Helpers.ToPython(response_method);
            if (percentiles != null)
                pyDict["percentiles"] = Helpers.ToPython(percentiles);
            if (grid_resolution != 100)
                pyDict["grid_resolution"] = Helpers.ToPython(grid_resolution);
            if (method != "auto")
                pyDict["method"] = Helpers.ToPython(method);
            if (kind != "average")
                pyDict["kind"] = Helpers.ToPython(kind);
            var __pyObject = self.InvokeMethod("partial_dependence", args, pyDict);
            return new PyDict(__pyObject);
        }

        public static PyDict permutation_importance(PyObject estimator, NDarray X, NDarray y, PyDict? scoring = null, int n_repeats = 5, int? n_jobs = null, int? random_state = null, NDarray? sample_weight = null, float max_samples = 1.0f)
        {
            _ = sklearn.inspection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y) });
            PyDict pyDict = new PyDict();
            if (scoring != null)
                pyDict["scoring"] = Helpers.ToPython(scoring);
            if (n_repeats != 5)
                pyDict["n_repeats"] = Helpers.ToPython(n_repeats);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (sample_weight != null)
                pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
            if (max_samples != 1.0f)
                pyDict["max_samples"] = Helpers.ToPython(max_samples);
            var __pyObject = self.InvokeMethod("permutation_importance", args, pyDict);
            return new PyDict(__pyObject);
        }

        public class DecisionBoundaryDisplay : PythonObject
        {
            public DecisionBoundaryDisplay(NDarray xx0, NDarray xx1, NDarray response, string? xlabel = null, string? ylabel = null)
            {
                _ = sklearn.inspection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(xx0), Helpers.ToPython(xx1), Helpers.ToPython(response) });
                PyDict pyDict = new PyDict();
                if (xlabel != null)
                    pyDict["xlabel"] = Helpers.ToPython(xlabel);
                if (ylabel != null)
                    pyDict["ylabel"] = Helpers.ToPython(ylabel);
                self = sklearn.inspection.self.InvokeMethod("DecisionBoundaryDisplay", args, pyDict);
            }

            internal DecisionBoundaryDisplay(PyObject pyObject)
            {
                _ = sklearn.inspection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static DecisionBoundaryDisplay Encapsule(PyObject pyObject) => new DecisionBoundaryDisplay(pyObject);
            public static DecisionBoundaryDisplay Wrap(PyObject pyObject) => new DecisionBoundaryDisplay(pyObject);
            public PyObject surface_
            {
                get
                {
                    var __pyObject = self.GetAttr("surface_");
                    return __pyObject;
                }
            }

            public PyObject ax_
            {
                get
                {
                    var __pyObject = self.GetAttr("ax_");
                    return __pyObject;
                }
            }

            public PyObject figure_
            {
                get
                {
                    var __pyObject = self.GetAttr("figure_");
                    return __pyObject;
                }
            }

            public PyObject from_estimator(PyObject estimator, NDarray X, int grid_resolution = 100, float eps = 1.0f, string plot_method = "contourf", string response_method = "auto", string? class_of_interest = null, string? xlabel = null, string? ylabel = null, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (grid_resolution != 100)
                    pyDict["grid_resolution"] = Helpers.ToPython(grid_resolution);
                if (eps != 1.0f)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (plot_method != "contourf")
                    pyDict["plot_method"] = Helpers.ToPython(plot_method);
                if (response_method != "auto")
                    pyDict["response_method"] = Helpers.ToPython(response_method);
                if (class_of_interest != null)
                    pyDict["class_of_interest"] = Helpers.ToPython(class_of_interest);
                if (xlabel != null)
                    pyDict["xlabel"] = Helpers.ToPython(xlabel);
                if (ylabel != null)
                    pyDict["ylabel"] = Helpers.ToPython(ylabel);
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("from_estimator", args, pyDict);
                return __pyObject;
            }

            public PyObject plot(string plot_method = "contourf", PyObject? ax = null, string? xlabel = null, string? ylabel = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (plot_method != "contourf")
                    pyDict["plot_method"] = Helpers.ToPython(plot_method);
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (xlabel != null)
                    pyDict["xlabel"] = Helpers.ToPython(xlabel);
                if (ylabel != null)
                    pyDict["ylabel"] = Helpers.ToPython(ylabel);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("plot", args, pyDict);
                return __pyObject;
            }
        }

        public class PartialDependenceDisplay : PythonObject
        {
            public PartialDependenceDisplay(PyDict pd_results, PyTuple features, PyTuple feature_names, int target_idx, PyDict deciles, string kind = "average", int? subsample = 1000, int? random_state = null, PyTuple? is_categorical = null)
            {
                _ = sklearn.inspection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(pd_results), Helpers.ToPython(features), Helpers.ToPython(feature_names), Helpers.ToPython(target_idx), Helpers.ToPython(deciles) });
                PyDict pyDict = new PyDict();
                if (kind != "average")
                    pyDict["kind"] = Helpers.ToPython(kind);
                if (subsample != 1000)
                    pyDict["subsample"] = Helpers.ToPython(subsample);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (is_categorical != null)
                    pyDict["is_categorical"] = Helpers.ToPython(is_categorical);
                self = sklearn.inspection.self.InvokeMethod("PartialDependenceDisplay", args, pyDict);
            }

            internal PartialDependenceDisplay(PyObject pyObject)
            {
                _ = sklearn.inspection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static PartialDependenceDisplay Encapsule(PyObject pyObject) => new PartialDependenceDisplay(pyObject);
            public static PartialDependenceDisplay Wrap(PyObject pyObject) => new PartialDependenceDisplay(pyObject);
            public PyObject bounding_ax_
            {
                get
                {
                    var __pyObject = self.GetAttr("bounding_ax_");
                    return __pyObject;
                }
            }

            public NDarray axes_
            {
                get
                {
                    var __pyObject = self.GetAttr("axes_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray lines_
            {
                get
                {
                    var __pyObject = self.GetAttr("lines_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray deciles_vlines_
            {
                get
                {
                    var __pyObject = self.GetAttr("deciles_vlines_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray deciles_hlines_
            {
                get
                {
                    var __pyObject = self.GetAttr("deciles_hlines_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray contours_
            {
                get
                {
                    var __pyObject = self.GetAttr("contours_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray bars_
            {
                get
                {
                    var __pyObject = self.GetAttr("bars_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray heatmaps_
            {
                get
                {
                    var __pyObject = self.GetAttr("heatmaps_");
                    return new NDarray(__pyObject);
                }
            }

            public PyObject figure_
            {
                get
                {
                    var __pyObject = self.GetAttr("figure_");
                    return __pyObject;
                }
            }

            public PyObject from_estimator(PyObject estimator, NDarray X, PyTuple features, NDarray? sample_weight = null, NDarray? categorical_features = null, NDarray? feature_names = null, int? target = null, string response_method = "auto", int n_cols = 3, int grid_resolution = 100, PyTuple? percentiles = null, string method = "auto", int? n_jobs = null, int verbose = 0, PyDict? line_kw = null, PyDict? ice_lines_kw = null, PyDict? pd_line_kw = null, PyDict? contour_kw = null, NDarray? ax = null, string kind = "average", bool centered = false, int? subsample = 1000, int? random_state = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(features) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (categorical_features != null)
                    pyDict["categorical_features"] = Helpers.ToPython(categorical_features);
                if (feature_names != null)
                    pyDict["feature_names"] = Helpers.ToPython(feature_names);
                if (target != null)
                    pyDict["target"] = Helpers.ToPython(target);
                if (response_method != "auto")
                    pyDict["response_method"] = Helpers.ToPython(response_method);
                if (n_cols != 3)
                    pyDict["n_cols"] = Helpers.ToPython(n_cols);
                if (grid_resolution != 100)
                    pyDict["grid_resolution"] = Helpers.ToPython(grid_resolution);
                if (percentiles != null)
                    pyDict["percentiles"] = Helpers.ToPython(percentiles);
                if (method != "auto")
                    pyDict["method"] = Helpers.ToPython(method);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (line_kw != null)
                    pyDict["line_kw"] = Helpers.ToPython(line_kw);
                if (ice_lines_kw != null)
                    pyDict["ice_lines_kw"] = Helpers.ToPython(ice_lines_kw);
                if (pd_line_kw != null)
                    pyDict["pd_line_kw"] = Helpers.ToPython(pd_line_kw);
                if (contour_kw != null)
                    pyDict["contour_kw"] = Helpers.ToPython(contour_kw);
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (kind != "average")
                    pyDict["kind"] = Helpers.ToPython(kind);
                if (centered != false)
                    pyDict["centered"] = Helpers.ToPython(centered);
                if (subsample != 1000)
                    pyDict["subsample"] = Helpers.ToPython(subsample);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                var __pyObject = self.InvokeMethod("from_estimator", args, pyDict);
                return __pyObject;
            }

            public PyObject plot(NDarray? ax = null, int n_cols = 3, PyDict? line_kw = null, PyDict? ice_lines_kw = null, PyDict? pd_line_kw = null, PyDict? contour_kw = null, PyDict? bar_kw = null, PyDict? heatmap_kw = null, PyDict? pdp_lim = null, bool centered = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (n_cols != 3)
                    pyDict["n_cols"] = Helpers.ToPython(n_cols);
                if (line_kw != null)
                    pyDict["line_kw"] = Helpers.ToPython(line_kw);
                if (ice_lines_kw != null)
                    pyDict["ice_lines_kw"] = Helpers.ToPython(ice_lines_kw);
                if (pd_line_kw != null)
                    pyDict["pd_line_kw"] = Helpers.ToPython(pd_line_kw);
                if (contour_kw != null)
                    pyDict["contour_kw"] = Helpers.ToPython(contour_kw);
                if (bar_kw != null)
                    pyDict["bar_kw"] = Helpers.ToPython(bar_kw);
                if (heatmap_kw != null)
                    pyDict["heatmap_kw"] = Helpers.ToPython(heatmap_kw);
                if (pdp_lim != null)
                    pyDict["pdp_lim"] = Helpers.ToPython(pdp_lim);
                if (centered != false)
                    pyDict["centered"] = Helpers.ToPython(centered);
                var __pyObject = self.InvokeMethod("plot", args, pyDict);
                return __pyObject;
            }
        }
    }
}