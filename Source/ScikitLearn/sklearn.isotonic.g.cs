namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class isotonic
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
            return Py.Import("sklearn.isotonic");
        }

        static isotonic() => ReInitializeLazySelf();
        public static bool check_increasing(NDarray x, NDarray y)
        {
            _ = sklearn.isotonic.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(x), Helpers.ToPython(y) });
            PyDict pyDict = new PyDict();
            var __pyObject = self.InvokeMethod("check_increasing", args, pyDict);
            return __pyObject.As<bool>();
        }

        public static NDarray isotonic_regression(NDarray y, NDarray? sample_weight = null, float? y_min = null, float? y_max = null, bool increasing = true)
        {
            _ = sklearn.isotonic.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(y) });
            PyDict pyDict = new PyDict();
            if (sample_weight != null)
                pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
            if (y_min != null)
                pyDict["y_min"] = Helpers.ToPython(y_min);
            if (y_max != null)
                pyDict["y_max"] = Helpers.ToPython(y_max);
            if (increasing != true)
                pyDict["increasing"] = Helpers.ToPython(increasing);
            var __pyObject = self.InvokeMethod("isotonic_regression", args, pyDict);
            return new NDarray(__pyObject);
        }

        public class IsotonicRegression : PythonObject
        {
            public IsotonicRegression(float? y_min = null, float? y_max = null, bool increasing = true, string out_of_bounds = "nan")
            {
                _ = sklearn.isotonic.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (y_min != null)
                    pyDict["y_min"] = Helpers.ToPython(y_min);
                if (y_max != null)
                    pyDict["y_max"] = Helpers.ToPython(y_max);
                if (increasing != true)
                    pyDict["increasing"] = Helpers.ToPython(increasing);
                if (out_of_bounds != "nan")
                    pyDict["out_of_bounds"] = Helpers.ToPython(out_of_bounds);
                self = sklearn.isotonic.self.InvokeMethod("IsotonicRegression", args, pyDict);
            }

            internal IsotonicRegression(PyObject pyObject)
            {
                _ = sklearn.isotonic.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static IsotonicRegression Encapsule(PyObject pyObject) => new IsotonicRegression(pyObject);
            public static IsotonicRegression Wrap(PyObject pyObject) => new IsotonicRegression(pyObject);
            public float X_min_
            {
                get
                {
                    var __pyObject = self.GetAttr("X_min_");
                    return __pyObject.As<float>();
                }
            }

            public float X_max_
            {
                get
                {
                    var __pyObject = self.GetAttr("X_max_");
                    return __pyObject.As<float>();
                }
            }

            public NDarray X_thresholds_
            {
                get
                {
                    var __pyObject = self.GetAttr("X_thresholds_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray y_thresholds_
            {
                get
                {
                    var __pyObject = self.GetAttr("y_thresholds_");
                    return new NDarray(__pyObject);
                }
            }

            public PyObject f_
            {
                get
                {
                    var __pyObject = self.GetAttr("f_");
                    return __pyObject;
                }
            }

            public bool increasing_
            {
                get
                {
                    var __pyObject = self.GetAttr("increasing_");
                    return __pyObject.As<bool>();
                }
            }

            public IsotonicRegression fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("fit_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                var __pyObject = self.InvokeMethod("get_feature_names_out", args, pyDict);
                return __pyObject;
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

            public NDarray predict(NDarray T)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(T) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
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

            public IsotonicRegression set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public IsotonicRegression set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public IsotonicRegression set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public IsotonicRegression set_predict_request(string? T = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (T != "$UNCHANGED$")
                    pyDict["T"] = Helpers.ToPython(T);
                self.InvokeMethod("set_predict_request", args, pyDict);
                return this;
            }

            public IsotonicRegression set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }

            public IsotonicRegression set_transform_request(string? T = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (T != "$UNCHANGED$")
                    pyDict["T"] = Helpers.ToPython(T);
                self.InvokeMethod("set_transform_request", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray T)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(T) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }
    }
}