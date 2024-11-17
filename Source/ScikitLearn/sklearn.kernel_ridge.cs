using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class kernel_ridge
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
                return Py.Import("sklearn.kernel_ridge");
            }

            static kernel_ridge()
            {
                ReInitializeLazySelf();
            }

            public class KernelRidge : PythonObject
            {
                public KernelRidge(int alpha = 1, string kernel = "linear", float? gamma = null, int degree = 3, int coef0 = 1, PyDict? kernel_params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (alpha != 1)
                        pyDict["alpha"] = ToPython(alpha);
                    if (kernel != "linear")
                        pyDict["kernel"] = ToPython(kernel);
                    if (gamma != null)
                        pyDict["gamma"] = ToPython(gamma);
                    if (degree != 3)
                        pyDict["degree"] = ToPython(degree);
                    if (coef0 != 1)
                        pyDict["coef0"] = ToPython(coef0);
                    if (kernel_params != null)
                        pyDict["kernel_params"] = ToPython(kernel_params);
                    self = sklearn.kernel_ridge.self.InvokeMethod("KernelRidge", args, pyDict);
                }

                internal KernelRidge(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static KernelRidge Encapsule(PyObject pyObject)
                {
                    return new KernelRidge(pyObject);
                }

                public NDarray dual_coef_ => ToCsharp<NDarray>(self.GetAttr("dual_coef_"));
                public NDarray X_fit_ => ToCsharp<NDarray>(self.GetAttr("X_fit_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public KernelRidge fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public KernelRidge set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public KernelRidge set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public KernelRidge set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }
        }
    }
}