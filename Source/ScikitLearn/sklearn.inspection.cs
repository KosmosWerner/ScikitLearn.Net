using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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

            static inspection()
            {
                ReInitializeLazySelf();
            }

            public static PyDict partial_dependence(PyObject estimator, NDarray X, NDarray features, NDarray? sample_weight = null, NDarray? categorical_features = null, NDarray? feature_names = null, string response_method = "auto", float? percentiles = null, int grid_resolution = 100, string method = "auto", string kind = "average")
            {
                PyTuple args = ToTuple(new object[] { estimator, X, features });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = ToPython(sample_weight);
                if (categorical_features != null)
                    pyDict["categorical_features"] = ToPython(categorical_features);
                if (feature_names != null)
                    pyDict["feature_names"] = ToPython(feature_names);
                if (response_method != "auto")
                    pyDict["response_method"] = ToPython(response_method);
                if (percentiles != null)
                    pyDict["percentiles"] = ToPython(percentiles);
                if (grid_resolution != 100)
                    pyDict["grid_resolution"] = ToPython(grid_resolution);
                if (method != "auto")
                    pyDict["method"] = ToPython(method);
                if (kind != "average")
                    pyDict["kind"] = ToPython(kind);
                return new PyDict(sklearn.inspection.self.InvokeMethod("partial_dependence", args, pyDict));
            }

            public static PyDict permutation_importance(PyObject estimator, NDarray X, NDarray y, PyDict? scoring = null, int n_repeats = 5, int? n_jobs = null, int? random_state = null, NDarray? sample_weight = null, float max_samples = 1.0f)
            {
                PyTuple args = ToTuple(new object[] { estimator, X, y });
                PyDict pyDict = new PyDict();
                if (scoring != null)
                    pyDict["scoring"] = ToPython(scoring);
                if (n_repeats != 5)
                    pyDict["n_repeats"] = ToPython(n_repeats);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (sample_weight != null)
                    pyDict["sample_weight"] = ToPython(sample_weight);
                if (max_samples != 1.0f)
                    pyDict["max_samples"] = ToPython(max_samples);
                return new PyDict(sklearn.inspection.self.InvokeMethod("permutation_importance", args, pyDict));
            }

            public class DecisionBoundaryDisplay : PythonObject
            {
                public DecisionBoundaryDisplay(NDarray xx0, NDarray xx1, NDarray response, string? xlabel = null, string? ylabel = null)
                {
                    PyTuple args = ToTuple(new object[] { xx0, xx1, response });
                    PyDict pyDict = new PyDict();
                    if (xlabel != null)
                        pyDict["xlabel"] = ToPython(xlabel);
                    if (ylabel != null)
                        pyDict["ylabel"] = ToPython(ylabel);
                    self = sklearn.inspection.self.InvokeMethod("DecisionBoundaryDisplay", args, pyDict);
                }

                internal DecisionBoundaryDisplay(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static DecisionBoundaryDisplay Encapsule(PyObject pyObject)
                {
                    return new DecisionBoundaryDisplay(pyObject);
                }

                public PyObject surface_ => self.GetAttr("surface_");
                public PyObject ax_ => self.GetAttr("ax_");
                public PyObject figure_ => self.GetAttr("figure_");

                public PyObject from_estimator(PyObject estimator, NDarray X, int grid_resolution = 100, float eps = 1.0f, string plot_method = "contourf", string response_method = "auto", string? class_of_interest = null, string? xlabel = null, string? ylabel = null, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { estimator, X });
                    PyDict pyDict = new PyDict();
                    if (grid_resolution != 100)
                        pyDict["grid_resolution"] = ToPython(grid_resolution);
                    if (eps != 1.0f)
                        pyDict["eps"] = ToPython(eps);
                    if (plot_method != "contourf")
                        pyDict["plot_method"] = ToPython(plot_method);
                    if (response_method != "auto")
                        pyDict["response_method"] = ToPython(response_method);
                    if (class_of_interest != null)
                        pyDict["class_of_interest"] = ToPython(class_of_interest);
                    if (xlabel != null)
                        pyDict["xlabel"] = ToPython(xlabel);
                    if (ylabel != null)
                        pyDict["ylabel"] = ToPython(ylabel);
                    if (ax != null)
                        pyDict["ax"] = ToPython(ax);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return self.InvokeMethod("from_estimator", args, pyDict);
                }

                public PyObject plot(string plot_method = "contourf", PyObject? ax = null, string? xlabel = null, string? ylabel = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (plot_method != "contourf")
                        pyDict["plot_method"] = ToPython(plot_method);
                    if (ax != null)
                        pyDict["ax"] = ToPython(ax);
                    if (xlabel != null)
                        pyDict["xlabel"] = ToPython(xlabel);
                    if (ylabel != null)
                        pyDict["ylabel"] = ToPython(ylabel);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return self.InvokeMethod("plot", args, pyDict);
                }
            }

            public class PartialDependenceDisplay : PythonObject
            {
                public PartialDependenceDisplay(PyDict pd_results, PyTuple features, PyTuple feature_names, int target_idx, PyDict deciles, string kind = "average", int? subsample = 1000, int? random_state = null, PyTuple? is_categorical = null)
                {
                    PyTuple args = ToTuple(new object[] { pd_results, features, feature_names, target_idx, deciles });
                    PyDict pyDict = new PyDict();
                    if (kind != "average")
                        pyDict["kind"] = ToPython(kind);
                    if (subsample != 1000)
                        pyDict["subsample"] = ToPython(subsample);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (is_categorical != null)
                        pyDict["is_categorical"] = ToPython(is_categorical);
                    self = sklearn.inspection.self.InvokeMethod("PartialDependenceDisplay", args, pyDict);
                }

                internal PartialDependenceDisplay(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static PartialDependenceDisplay Encapsule(PyObject pyObject)
                {
                    return new PartialDependenceDisplay(pyObject);
                }

                public PyObject bounding_ax_ => self.GetAttr("bounding_ax_");
                public NDarray axes_ => ToCsharp<NDarray>(self.GetAttr("axes_"));
                public NDarray lines_ => ToCsharp<NDarray>(self.GetAttr("lines_"));
                public NDarray deciles_vlines_ => ToCsharp<NDarray>(self.GetAttr("deciles_vlines_"));
                public NDarray deciles_hlines_ => ToCsharp<NDarray>(self.GetAttr("deciles_hlines_"));
                public NDarray contours_ => ToCsharp<NDarray>(self.GetAttr("contours_"));
                public NDarray bars_ => ToCsharp<NDarray>(self.GetAttr("bars_"));
                public NDarray heatmaps_ => ToCsharp<NDarray>(self.GetAttr("heatmaps_"));
                public PyObject figure_ => self.GetAttr("figure_");

                public PyObject from_estimator(PyObject estimator, NDarray X, PyTuple features, NDarray? sample_weight = null, NDarray? categorical_features = null, NDarray? feature_names = null, int? target = null, string response_method = "auto", int n_cols = 3, int grid_resolution = 100, float? percentiles = null, string method = "auto", int? n_jobs = null, int verbose = 0, PyDict? line_kw = null, PyDict? ice_lines_kw = null, PyDict? pd_line_kw = null, PyDict? contour_kw = null, NDarray? ax = null, string kind = "average", bool centered = false, int? subsample = 1000, int? random_state = null)
                {
                    PyTuple args = ToTuple(new object[] { estimator, X, features });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    if (categorical_features != null)
                        pyDict["categorical_features"] = ToPython(categorical_features);
                    if (feature_names != null)
                        pyDict["feature_names"] = ToPython(feature_names);
                    if (target != null)
                        pyDict["target"] = ToPython(target);
                    if (response_method != "auto")
                        pyDict["response_method"] = ToPython(response_method);
                    if (n_cols != 3)
                        pyDict["n_cols"] = ToPython(n_cols);
                    if (grid_resolution != 100)
                        pyDict["grid_resolution"] = ToPython(grid_resolution);
                    if (percentiles != null)
                        pyDict["percentiles"] = ToPython(percentiles);
                    if (method != "auto")
                        pyDict["method"] = ToPython(method);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (line_kw != null)
                        pyDict["line_kw"] = ToPython(line_kw);
                    if (ice_lines_kw != null)
                        pyDict["ice_lines_kw"] = ToPython(ice_lines_kw);
                    if (pd_line_kw != null)
                        pyDict["pd_line_kw"] = ToPython(pd_line_kw);
                    if (contour_kw != null)
                        pyDict["contour_kw"] = ToPython(contour_kw);
                    if (ax != null)
                        pyDict["ax"] = ToPython(ax);
                    if (kind != "average")
                        pyDict["kind"] = ToPython(kind);
                    if (centered != false)
                        pyDict["centered"] = ToPython(centered);
                    if (subsample != 1000)
                        pyDict["subsample"] = ToPython(subsample);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    return self.InvokeMethod("from_estimator", args, pyDict);
                }

                public PyObject plot(NDarray? ax = null, int n_cols = 3, PyDict? line_kw = null, PyDict? ice_lines_kw = null, PyDict? pd_line_kw = null, PyDict? contour_kw = null, PyDict? bar_kw = null, PyDict? heatmap_kw = null, PyDict? pdp_lim = null, bool centered = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (ax != null)
                        pyDict["ax"] = ToPython(ax);
                    if (n_cols != 3)
                        pyDict["n_cols"] = ToPython(n_cols);
                    if (line_kw != null)
                        pyDict["line_kw"] = ToPython(line_kw);
                    if (ice_lines_kw != null)
                        pyDict["ice_lines_kw"] = ToPython(ice_lines_kw);
                    if (pd_line_kw != null)
                        pyDict["pd_line_kw"] = ToPython(pd_line_kw);
                    if (contour_kw != null)
                        pyDict["contour_kw"] = ToPython(contour_kw);
                    if (bar_kw != null)
                        pyDict["bar_kw"] = ToPython(bar_kw);
                    if (heatmap_kw != null)
                        pyDict["heatmap_kw"] = ToPython(heatmap_kw);
                    if (pdp_lim != null)
                        pyDict["pdp_lim"] = ToPython(pdp_lim);
                    if (centered != false)
                        pyDict["centered"] = ToPython(centered);
                    return self.InvokeMethod("plot", args, pyDict);
                }
            }
        }
    }
}