using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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

            static isotonic()
            {
                ReInitializeLazySelf();
            }

            public class IsotonicRegression : PythonObject
            {
                public IsotonicRegression(float? y_min = null, float? y_max = null, bool increasing = true, string out_of_bounds = "nan")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (y_min != null)
                        pyDict["y_min"] = ToPython(y_min);
                    if (y_max != null)
                        pyDict["y_max"] = ToPython(y_max);
                    if (increasing != true)
                        pyDict["increasing"] = ToPython(increasing);
                    if (out_of_bounds != "nan")
                        pyDict["out_of_bounds"] = ToPython(out_of_bounds);
                    self = sklearn.isotonic.self.InvokeMethod("IsotonicRegression", args, pyDict);
                }

                internal IsotonicRegression(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static IsotonicRegression Encapsule(PyObject pyObject)
                {
                    return new IsotonicRegression(pyObject);
                }

                public float X_min_ => ToCsharp<float>(self.GetAttr("X_min_"));
                public float X_max_ => ToCsharp<float>(self.GetAttr("X_max_"));
                public NDarray X_thresholds_ => ToCsharp<NDarray>(self.GetAttr("X_thresholds_"));
                public NDarray y_thresholds_ => ToCsharp<NDarray>(self.GetAttr("y_thresholds_"));
                public PyObject f_ => self.GetAttr("f_");
                public bool increasing_ => ToCsharp<bool>(self.GetAttr("increasing_"));

                public IsotonicRegression fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public NDarray predict(NDarray T)
                {
                    PyTuple args = ToTuple(new object[] { T });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public IsotonicRegression set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public IsotonicRegression set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public IsotonicRegression set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public IsotonicRegression set_predict_request(string? T = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (T != "$UNCHANGED$")
                        pyDict["T"] = ToPython(T);
                    self.InvokeMethod("set_predict_request", args, pyDict);
                    return this;
                }

                public IsotonicRegression set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public IsotonicRegression set_transform_request(string? T = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (T != "$UNCHANGED$")
                        pyDict["T"] = ToPython(T);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray T)
                {
                    PyTuple args = ToTuple(new object[] { T });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public static bool check_increasing(NDarray x, NDarray y)
            {
                PyTuple args = ToTuple(new object[] { x, y });
                PyDict pyDict = new PyDict();
                return ToCsharp<bool>(sklearn.isotonic.self.InvokeMethod("check_increasing", args, pyDict));
            }

            public static NDarray isotonic_regression(NDarray y, NDarray? sample_weight = null, float? y_min = null, float? y_max = null, bool increasing = true)
            {
                PyTuple args = ToTuple(new object[] { y });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = ToPython(sample_weight);
                if (y_min != null)
                    pyDict["y_min"] = ToPython(y_min);
                if (y_max != null)
                    pyDict["y_max"] = ToPython(y_max);
                if (increasing != true)
                    pyDict["increasing"] = ToPython(increasing);
                return ToCsharp<NDarray>(sklearn.isotonic.self.InvokeMethod("isotonic_regression", args, pyDict));
            }
        }
    }
}