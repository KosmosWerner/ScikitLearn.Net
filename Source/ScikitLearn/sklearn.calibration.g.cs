namespace ScikitLearn;
#nullable enable
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

        static calibration() => ReInitializeLazySelf();
        public static (NDarray? , NDarray? ) calibration_curve(NDarray y_true, NDarray y_prob, string? pos_label = null, int n_bins = 5, string strategy = "uniform")
        {
            _ = sklearn.calibration.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(y_true), Helpers.ToPython(y_prob) });
            PyDict pyDict = new PyDict();
            if (pos_label != null)
                pyDict["pos_label"] = Helpers.ToPython(pos_label);
            if (n_bins != 5)
                pyDict["n_bins"] = Helpers.ToPython(n_bins);
            if (strategy != "uniform")
                pyDict["strategy"] = Helpers.ToPython(strategy);
            var __pyObject = self.InvokeMethod("calibration_curve", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
        }

        public class CalibratedClassifierCV : PythonObject
        {
            public CalibratedClassifierCV(PyObject? estimator = null, string method = "sigmoid", int? cv = null, int? n_jobs = null, bool ensemble = true)
            {
                _ = sklearn.calibration.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (estimator != null)
                    pyDict["estimator"] = Helpers.ToPython(estimator);
                if (method != "sigmoid")
                    pyDict["method"] = Helpers.ToPython(method);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (ensemble != true)
                    pyDict["ensemble"] = Helpers.ToPython(ensemble);
                self = sklearn.calibration.self.InvokeMethod("CalibratedClassifierCV", args, pyDict);
            }

            internal CalibratedClassifierCV(PyObject pyObject)
            {
                _ = sklearn.calibration.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static CalibratedClassifierCV Encapsule(PyObject pyObject) => new CalibratedClassifierCV(pyObject);
            public static CalibratedClassifierCV Wrap(PyObject pyObject) => new CalibratedClassifierCV(pyObject);
            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public bool calibrated_classifiers_
            {
                get
                {
                    var __pyObject = self.GetAttr("calibrated_classifiers_");
                    return __pyObject.As<bool>();
                }
            }

            public CalibratedClassifierCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public CalibratedClassifierCV set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public CalibratedClassifierCV set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public CalibratedClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class CalibrationDisplay : PythonObject
        {
            public CalibrationDisplay(NDarray prob_true, NDarray prob_pred, NDarray y_prob, string? estimator_name = null, string? pos_label = null)
            {
                _ = sklearn.calibration.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(prob_true), Helpers.ToPython(prob_pred), Helpers.ToPython(y_prob) });
                PyDict pyDict = new PyDict();
                if (estimator_name != null)
                    pyDict["estimator_name"] = Helpers.ToPython(estimator_name);
                if (pos_label != null)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                self = sklearn.calibration.self.InvokeMethod("CalibrationDisplay", args, pyDict);
            }

            internal CalibrationDisplay(PyObject pyObject)
            {
                _ = sklearn.calibration.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static CalibrationDisplay Encapsule(PyObject pyObject) => new CalibrationDisplay(pyObject);
            public static CalibrationDisplay Wrap(PyObject pyObject) => new CalibrationDisplay(pyObject);
            public PyObject line_
            {
                get
                {
                    var __pyObject = self.GetAttr("line_");
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

            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, int n_bins = 5, string strategy = "uniform", string? pos_label = null, string? name = null, bool ref_line = true, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (n_bins != 5)
                    pyDict["n_bins"] = Helpers.ToPython(n_bins);
                if (strategy != "uniform")
                    pyDict["strategy"] = Helpers.ToPython(strategy);
                if (pos_label != null)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (name != null)
                    pyDict["name"] = Helpers.ToPython(name);
                if (ref_line != true)
                    pyDict["ref_line"] = Helpers.ToPython(ref_line);
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("from_estimator", args, pyDict);
                return __pyObject;
            }

            public PyObject from_predictions(NDarray y_true, NDarray y_prob, int n_bins = 5, string strategy = "uniform", string? pos_label = null, string? name = null, bool ref_line = true, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(y_true), Helpers.ToPython(y_prob) });
                PyDict pyDict = new PyDict();
                if (n_bins != 5)
                    pyDict["n_bins"] = Helpers.ToPython(n_bins);
                if (strategy != "uniform")
                    pyDict["strategy"] = Helpers.ToPython(strategy);
                if (pos_label != null)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (name != null)
                    pyDict["name"] = Helpers.ToPython(name);
                if (ref_line != true)
                    pyDict["ref_line"] = Helpers.ToPython(ref_line);
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("from_predictions", args, pyDict);
                return __pyObject;
            }

            public PyObject plot(PyObject? ax = null, string? name = null, bool ref_line = true, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (name != null)
                    pyDict["name"] = Helpers.ToPython(name);
                if (ref_line != true)
                    pyDict["ref_line"] = Helpers.ToPython(ref_line);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("plot", args, pyDict);
                return __pyObject;
            }
        }
    }
}