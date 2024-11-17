using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class calibration
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
                return Py.Import("sklearn.calibration");
            }

            static calibration()
            {
                ReInitializeLazySelf();
            }

            public class CalibratedClassifierCV : PythonObject
            {
                public CalibratedClassifierCV(PyObject? estimator = null, string method = "sigmoid", int? cv = null, int? n_jobs = null, bool ensemble = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (estimator != null)
                        pyDict["estimator"] = ToPython(estimator);
                    if (method != "sigmoid")
                        pyDict["method"] = ToPython(method);
                    if (cv != null)
                        pyDict["cv"] = ToPython(cv);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (ensemble != true)
                        pyDict["ensemble"] = ToPython(ensemble);
                    self = sklearn.calibration.self.InvokeMethod("CalibratedClassifierCV", args, pyDict);
                }

                internal CalibratedClassifierCV(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static CalibratedClassifierCV Encapsule(PyObject pyObject)
                {
                    return new CalibratedClassifierCV(pyObject);
                }

                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public bool calibrated_classifiers_ => ToCsharp<bool>(self.GetAttr("calibrated_classifiers_"));

                public CalibratedClassifierCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
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

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public CalibratedClassifierCV set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public CalibratedClassifierCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public CalibratedClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public static (NDarray, NDarray) calibration_curve(NDarray y_true, NDarray y_prob, string? pos_label = null, int n_bins = 5, string strategy = "uniform")
            {
                PyTuple args = ToTuple(new object[] { y_true, y_prob });
                PyDict pyDict = new PyDict();
                if (pos_label != null)
                    pyDict["pos_label"] = ToPython(pos_label);
                if (n_bins != 5)
                    pyDict["n_bins"] = ToPython(n_bins);
                if (strategy != "uniform")
                    pyDict["strategy"] = ToPython(strategy);
                PyTuple result = new PyTuple(sklearn.calibration.self.InvokeMethod("calibration_curve", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public class CalibrationDisplay : PythonObject
            {
                public CalibrationDisplay(NDarray prob_true, NDarray prob_pred, NDarray y_prob, string? estimator_name = null, string? pos_label = null)
                {
                    PyTuple args = ToTuple(new object[] { prob_true, prob_pred, y_prob });
                    PyDict pyDict = new PyDict();
                    if (estimator_name != null)
                        pyDict["estimator_name"] = ToPython(estimator_name);
                    if (pos_label != null)
                        pyDict["pos_label"] = ToPython(pos_label);
                    self = sklearn.calibration.self.InvokeMethod("CalibrationDisplay", args, pyDict);
                }

                internal CalibrationDisplay(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static CalibrationDisplay Encapsule(PyObject pyObject)
                {
                    return new CalibrationDisplay(pyObject);
                }

                public PyObject line_ => self.GetAttr("line_");
                public PyObject ax_ => self.GetAttr("ax_");
                public PyObject figure_ => self.GetAttr("figure_");

                public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, int n_bins = 5, string strategy = "uniform", string? pos_label = null, string? name = null, bool ref_line = true, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { estimator, X, y });
                    PyDict pyDict = new PyDict();
                    if (n_bins != 5)
                        pyDict["n_bins"] = ToPython(n_bins);
                    if (strategy != "uniform")
                        pyDict["strategy"] = ToPython(strategy);
                    if (pos_label != null)
                        pyDict["pos_label"] = ToPython(pos_label);
                    if (name != null)
                        pyDict["name"] = ToPython(name);
                    if (ref_line != true)
                        pyDict["ref_line"] = ToPython(ref_line);
                    if (ax != null)
                        pyDict["ax"] = ToPython(ax);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return self.InvokeMethod("from_estimator", args, pyDict);
                }

                public PyObject from_predictions(NDarray y_true, NDarray y_prob, int n_bins = 5, string strategy = "uniform", string? pos_label = null, string? name = null, bool ref_line = true, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { y_true, y_prob });
                    PyDict pyDict = new PyDict();
                    if (n_bins != 5)
                        pyDict["n_bins"] = ToPython(n_bins);
                    if (strategy != "uniform")
                        pyDict["strategy"] = ToPython(strategy);
                    if (pos_label != null)
                        pyDict["pos_label"] = ToPython(pos_label);
                    if (name != null)
                        pyDict["name"] = ToPython(name);
                    if (ref_line != true)
                        pyDict["ref_line"] = ToPython(ref_line);
                    if (ax != null)
                        pyDict["ax"] = ToPython(ax);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return self.InvokeMethod("from_predictions", args, pyDict);
                }

                public PyObject plot(PyObject? ax = null, string? name = null, bool ref_line = true, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (ax != null)
                        pyDict["ax"] = ToPython(ax);
                    if (name != null)
                        pyDict["name"] = ToPython(name);
                    if (ref_line != true)
                        pyDict["ref_line"] = ToPython(ref_line);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return self.InvokeMethod("plot", args, pyDict);
                }
            }
        }
    }
}