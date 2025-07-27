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

        static calibration()
        {
            ReInitializeLazySelf();
        }

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
            return new NotImplementedException();
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static CalibratedClassifierCV Encapsule(PyObject pyObject) => new CalibratedClassifierCV(pyObject);
            public static CalibratedClassifierCV Wrap(PyObject pyObject) => new CalibratedClassifierCV(pyObject);
            public NDarray classes_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();
            public bool calibrated_classifiers_ => self.GetAttr("calibrated_classifiers_").As<bool>()public CalibratedClassifierCV fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
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
                return new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                return new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static CalibrationDisplay Encapsule(PyObject pyObject) => new CalibrationDisplay(pyObject);
            public static CalibrationDisplay Wrap(PyObject pyObject) => new CalibrationDisplay(pyObject);
            public PyObject line_ => new NotImplementedException();
            public PyObject ax_ => new NotImplementedException();
            public PyObject figure_ => new NotImplementedException();

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
                return new NotImplementedException();
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
                return new NotImplementedException();
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
                return new NotImplementedException();
            }
        }
    }
}