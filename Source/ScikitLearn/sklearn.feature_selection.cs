using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class feature_selection
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
                return Py.Import("sklearn.feature_selection");
            }

            static feature_selection()
            {
                ReInitializeLazySelf();
            }

            public class GenericUnivariateSelect : PythonObject
            {
                public GenericUnivariateSelect(PyObject? score_func = null, string mode = "percentile", float param = 1e-05f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (score_func != null)
                        pyDict["score_func"] = ToPython(score_func);
                    if (mode != "percentile")
                        pyDict["mode"] = ToPython(mode);
                    if (param != 1e-05f)
                        pyDict["param"] = ToPython(param);
                    self = sklearn.feature_selection.self.InvokeMethod("GenericUnivariateSelect", args, pyDict);
                }

                internal GenericUnivariateSelect(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static GenericUnivariateSelect Encapsule(PyObject pyObject)
                {
                    return new GenericUnivariateSelect(pyObject);
                }

                public NDarray scores_ => ToCsharp<NDarray>(self.GetAttr("scores_"));
                public NDarray pvalues_ => ToCsharp<NDarray>(self.GetAttr("pvalues_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public GenericUnivariateSelect fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public GenericUnivariateSelect set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public GenericUnivariateSelect set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class RFE : PythonObject
            {
                public RFE(PyObject estimator, float? n_features_to_select = null, int step = 1, int verbose = 0, string importance_getter = "auto")
                {
                    PyTuple args = ToTuple(new object[] { estimator });
                    PyDict pyDict = new PyDict();
                    if (n_features_to_select != null)
                        pyDict["n_features_to_select"] = ToPython(n_features_to_select);
                    if (step != 1)
                        pyDict["step"] = ToPython(step);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (importance_getter != "auto")
                        pyDict["importance_getter"] = ToPython(importance_getter);
                    self = sklearn.feature_selection.self.InvokeMethod("RFE", args, pyDict);
                }

                internal RFE(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RFE Encapsule(PyObject pyObject)
                {
                    return new RFE(pyObject);
                }

                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public PyObject estimator_ => self.GetAttr("estimator_");
                public int n_features_ => ToCsharp<int>(self.GetAttr("n_features_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public NDarray ranking_ => ToCsharp<NDarray>(self.GetAttr("ranking_"));
                public NDarray support_ => ToCsharp<NDarray>(self.GetAttr("support_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public RFE fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public void get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_log_proba", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public RFE set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public RFE set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class RFECV : PythonObject
            {
                public RFECV(PyObject estimator, int step = 1, int min_features_to_select = 1, int? cv = null, string? scoring = null, int verbose = 0, int? n_jobs = null, string importance_getter = "auto")
                {
                    PyTuple args = ToTuple(new object[] { estimator });
                    PyDict pyDict = new PyDict();
                    if (step != 1)
                        pyDict["step"] = ToPython(step);
                    if (min_features_to_select != 1)
                        pyDict["min_features_to_select"] = ToPython(min_features_to_select);
                    if (cv != null)
                        pyDict["cv"] = ToPython(cv);
                    if (scoring != null)
                        pyDict["scoring"] = ToPython(scoring);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (importance_getter != "auto")
                        pyDict["importance_getter"] = ToPython(importance_getter);
                    self = sklearn.feature_selection.self.InvokeMethod("RFECV", args, pyDict);
                }

                internal RFECV(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RFECV Encapsule(PyObject pyObject)
                {
                    return new RFECV(pyObject);
                }

                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public PyObject estimator_ => self.GetAttr("estimator_");
                public PyDict cv_results_ => new PyDict(self.GetAttr("cv_results_"));
                public int n_features_ => ToCsharp<int>(self.GetAttr("n_features_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public NDarray ranking_ => ToCsharp<NDarray>(self.GetAttr("ranking_"));
                public NDarray support_ => ToCsharp<NDarray>(self.GetAttr("support_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public RFECV fit(NDarray X, NDarray y, NDarray? groups = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (groups != null)
                        pyDict["groups"] = ToPython(groups);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public void get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_log_proba", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public RFECV set_fit_request(string? groups = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (groups != "$UNCHANGED$")
                        pyDict["groups"] = ToPython(groups);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public RFECV set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public RFECV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SelectFdr : PythonObject
            {
                public SelectFdr(PyObject? score_func = null, float alpha = 0.05f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (score_func != null)
                        pyDict["score_func"] = ToPython(score_func);
                    if (alpha != 0.05f)
                        pyDict["alpha"] = ToPython(alpha);
                    self = sklearn.feature_selection.self.InvokeMethod("SelectFdr", args, pyDict);
                }

                internal SelectFdr(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SelectFdr Encapsule(PyObject pyObject)
                {
                    return new SelectFdr(pyObject);
                }

                public NDarray scores_ => ToCsharp<NDarray>(self.GetAttr("scores_"));
                public NDarray pvalues_ => ToCsharp<NDarray>(self.GetAttr("pvalues_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SelectFdr fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SelectFdr set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SelectFdr set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SelectFpr : PythonObject
            {
                public SelectFpr(PyObject? score_func = null, float alpha = 0.05f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (score_func != null)
                        pyDict["score_func"] = ToPython(score_func);
                    if (alpha != 0.05f)
                        pyDict["alpha"] = ToPython(alpha);
                    self = sklearn.feature_selection.self.InvokeMethod("SelectFpr", args, pyDict);
                }

                internal SelectFpr(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SelectFpr Encapsule(PyObject pyObject)
                {
                    return new SelectFpr(pyObject);
                }

                public NDarray scores_ => ToCsharp<NDarray>(self.GetAttr("scores_"));
                public NDarray pvalues_ => ToCsharp<NDarray>(self.GetAttr("pvalues_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SelectFpr fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SelectFpr set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SelectFpr set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SelectFromModel : PythonObject
            {
                public SelectFromModel(PyObject estimator, string? threshold = null, bool prefit = false, int norm_order = 1, int? max_features = null, string importance_getter = "auto")
                {
                    PyTuple args = ToTuple(new object[] { estimator });
                    PyDict pyDict = new PyDict();
                    if (threshold != null)
                        pyDict["threshold"] = ToPython(threshold);
                    if (prefit != false)
                        pyDict["prefit"] = ToPython(prefit);
                    if (norm_order != 1)
                        pyDict["norm_order"] = ToPython(norm_order);
                    if (max_features != null)
                        pyDict["max_features"] = ToPython(max_features);
                    if (importance_getter != "auto")
                        pyDict["importance_getter"] = ToPython(importance_getter);
                    self = sklearn.feature_selection.self.InvokeMethod("SelectFromModel", args, pyDict);
                }

                internal SelectFromModel(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SelectFromModel Encapsule(PyObject pyObject)
                {
                    return new SelectFromModel(pyObject);
                }

                public PyObject estimator_ => self.GetAttr("estimator_");
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public int max_features_ => ToCsharp<int>(self.GetAttr("max_features_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public float threshold_ => ToCsharp<float>(self.GetAttr("threshold_"));

                public SelectFromModel fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SelectFromModel partial_fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public SelectFromModel set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SelectFromModel set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SelectFwe : PythonObject
            {
                public SelectFwe(PyObject? score_func = null, float alpha = 0.05f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (score_func != null)
                        pyDict["score_func"] = ToPython(score_func);
                    if (alpha != 0.05f)
                        pyDict["alpha"] = ToPython(alpha);
                    self = sklearn.feature_selection.self.InvokeMethod("SelectFwe", args, pyDict);
                }

                internal SelectFwe(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SelectFwe Encapsule(PyObject pyObject)
                {
                    return new SelectFwe(pyObject);
                }

                public NDarray scores_ => ToCsharp<NDarray>(self.GetAttr("scores_"));
                public NDarray pvalues_ => ToCsharp<NDarray>(self.GetAttr("pvalues_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SelectFwe fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SelectFwe set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SelectFwe set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SelectKBest : PythonObject
            {
                public SelectKBest(PyObject? score_func = null, int k = 10)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (score_func != null)
                        pyDict["score_func"] = ToPython(score_func);
                    if (k != 10)
                        pyDict["k"] = ToPython(k);
                    self = sklearn.feature_selection.self.InvokeMethod("SelectKBest", args, pyDict);
                }

                internal SelectKBest(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SelectKBest Encapsule(PyObject pyObject)
                {
                    return new SelectKBest(pyObject);
                }

                public NDarray scores_ => ToCsharp<NDarray>(self.GetAttr("scores_"));
                public NDarray pvalues_ => ToCsharp<NDarray>(self.GetAttr("pvalues_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SelectKBest fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SelectKBest set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SelectKBest set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SelectPercentile : PythonObject
            {
                public SelectPercentile(PyObject? score_func = null, int percentile = 10)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (score_func != null)
                        pyDict["score_func"] = ToPython(score_func);
                    if (percentile != 10)
                        pyDict["percentile"] = ToPython(percentile);
                    self = sklearn.feature_selection.self.InvokeMethod("SelectPercentile", args, pyDict);
                }

                internal SelectPercentile(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SelectPercentile Encapsule(PyObject pyObject)
                {
                    return new SelectPercentile(pyObject);
                }

                public NDarray scores_ => ToCsharp<NDarray>(self.GetAttr("scores_"));
                public NDarray pvalues_ => ToCsharp<NDarray>(self.GetAttr("pvalues_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SelectPercentile fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SelectPercentile set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SelectPercentile set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SelectorMixin : PythonObject
            {
                public SelectorMixin()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.feature_selection.self.InvokeMethod("SelectorMixin", args, pyDict);
                }

                internal SelectorMixin(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SelectorMixin Encapsule(PyObject pyObject)
                {
                    return new SelectorMixin(pyObject);
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SelectorMixin set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SequentialFeatureSelector : PythonObject
            {
                public SequentialFeatureSelector(PyObject estimator, string n_features_to_select = "auto", float? tol = null, string direction = "forward", string? scoring = null, int? cv = 5, int? n_jobs = null)
                {
                    PyTuple args = ToTuple(new object[] { estimator });
                    PyDict pyDict = new PyDict();
                    if (n_features_to_select != "auto")
                        pyDict["n_features_to_select"] = ToPython(n_features_to_select);
                    if (tol != null)
                        pyDict["tol"] = ToPython(tol);
                    if (direction != "forward")
                        pyDict["direction"] = ToPython(direction);
                    if (scoring != null)
                        pyDict["scoring"] = ToPython(scoring);
                    if (cv != 5)
                        pyDict["cv"] = ToPython(cv);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.feature_selection.self.InvokeMethod("SequentialFeatureSelector", args, pyDict);
                }

                internal SequentialFeatureSelector(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SequentialFeatureSelector Encapsule(PyObject pyObject)
                {
                    return new SequentialFeatureSelector(pyObject);
                }

                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_features_to_select_ => ToCsharp<int>(self.GetAttr("n_features_to_select_"));
                public NDarray support_ => ToCsharp<NDarray>(self.GetAttr("support_"));

                public SequentialFeatureSelector fit(NDarray X, NDarray? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public void get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SequentialFeatureSelector set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SequentialFeatureSelector set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class VarianceThreshold : PythonObject
            {
                public VarianceThreshold(float threshold = 0.0f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (threshold != 0.0f)
                        pyDict["threshold"] = ToPython(threshold);
                    self = sklearn.feature_selection.self.InvokeMethod("VarianceThreshold", args, pyDict);
                }

                internal VarianceThreshold(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static VarianceThreshold Encapsule(PyObject pyObject)
                {
                    return new VarianceThreshold(pyObject);
                }

                public NDarray variances_ => ToCsharp<NDarray>(self.GetAttr("variances_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public VarianceThreshold fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }

                public PyObject get_metadata_routing()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("get_metadata_routing", args, pyDict);
                }

                public PyDict get_params(bool deep = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (deep != true)
                        pyDict["deep"] = ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_support(bool indices = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    return ToCsharp<NDarray>(self.InvokeMethod("get_support", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public VarianceThreshold set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public VarianceThreshold set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public static (NDarray, NDarray) chi2(NDarray X, NDarray y)
            {
                PyTuple args = ToTuple(new object[] { X, y });
                PyDict pyDict = new PyDict();
                PyTuple result = new PyTuple(sklearn.feature_selection.self.InvokeMethod("chi2", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray) f_classif(NDarray X, NDarray y)
            {
                PyTuple args = ToTuple(new object[] { X, y });
                PyDict pyDict = new PyDict();
                PyTuple result = new PyTuple(sklearn.feature_selection.self.InvokeMethod("f_classif", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray) f_regression(NDarray X, NDarray y, bool center = true, bool force_finite = true)
            {
                PyTuple args = ToTuple(new object[] { X, y });
                PyDict pyDict = new PyDict();
                if (center != true)
                    pyDict["center"] = ToPython(center);
                if (force_finite != true)
                    pyDict["force_finite"] = ToPython(force_finite);
                PyTuple result = new PyTuple(sklearn.feature_selection.self.InvokeMethod("f_regression", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static NDarray mutual_info_classif(NDarray X, NDarray y, string discrete_features = "auto", int n_neighbors = 3, bool copy = true, int? random_state = null, int? n_jobs = null)
            {
                PyTuple args = ToTuple(new object[] { X, y });
                PyDict pyDict = new PyDict();
                if (discrete_features != "auto")
                    pyDict["discrete_features"] = ToPython(discrete_features);
                if (n_neighbors != 3)
                    pyDict["n_neighbors"] = ToPython(n_neighbors);
                if (copy != true)
                    pyDict["copy"] = ToPython(copy);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                return ToCsharp<NDarray>(sklearn.feature_selection.self.InvokeMethod("mutual_info_classif", args, pyDict));
            }

            public static NDarray mutual_info_regression(NDarray X, NDarray y, string discrete_features = "auto", int n_neighbors = 3, bool copy = true, int? random_state = null, int? n_jobs = null)
            {
                PyTuple args = ToTuple(new object[] { X, y });
                PyDict pyDict = new PyDict();
                if (discrete_features != "auto")
                    pyDict["discrete_features"] = ToPython(discrete_features);
                if (n_neighbors != 3)
                    pyDict["n_neighbors"] = ToPython(n_neighbors);
                if (copy != true)
                    pyDict["copy"] = ToPython(copy);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                return ToCsharp<NDarray>(sklearn.feature_selection.self.InvokeMethod("mutual_info_regression", args, pyDict));
            }

            public static NDarray r_regression(NDarray X, NDarray y, bool center = true, bool force_finite = true)
            {
                PyTuple args = ToTuple(new object[] { X, y });
                PyDict pyDict = new PyDict();
                if (center != true)
                    pyDict["center"] = ToPython(center);
                if (force_finite != true)
                    pyDict["force_finite"] = ToPython(force_finite);
                return ToCsharp<NDarray>(sklearn.feature_selection.self.InvokeMethod("r_regression", args, pyDict));
            }
        }
    }
}