using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class kernel_approximation
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
                return Py.Import("sklearn.kernel_approximation");
            }

            static kernel_approximation()
            {
                ReInitializeLazySelf();
            }

            public class AdditiveChi2Sampler : PythonObject
            {
                public AdditiveChi2Sampler(int sample_steps = 2, float? sample_interval = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_steps != 2)
                        pyDict["sample_steps"] = ToPython(sample_steps);
                    if (sample_interval != null)
                        pyDict["sample_interval"] = ToPython(sample_interval);
                    self = sklearn.kernel_approximation.self.InvokeMethod("AdditiveChi2Sampler", args, pyDict);
                }

                internal AdditiveChi2Sampler(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static AdditiveChi2Sampler Encapsule(PyObject pyObject)
                {
                    return new AdditiveChi2Sampler(pyObject);
                }

                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public AdditiveChi2Sampler fit(NDarray X, NDarray? y = null)
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

                public AdditiveChi2Sampler set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public AdditiveChi2Sampler set_params(Dictionary<string, PyObject>? @params = null)
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

            public class Nystroem : PythonObject
            {
                public Nystroem(string kernel = "rbf", float? gamma = null, float? coef0 = null, float? degree = null, PyDict? kernel_params = null, int n_components = 100, int? random_state = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (kernel != "rbf")
                        pyDict["kernel"] = ToPython(kernel);
                    if (gamma != null)
                        pyDict["gamma"] = ToPython(gamma);
                    if (coef0 != null)
                        pyDict["coef0"] = ToPython(coef0);
                    if (degree != null)
                        pyDict["degree"] = ToPython(degree);
                    if (kernel_params != null)
                        pyDict["kernel_params"] = ToPython(kernel_params);
                    if (n_components != 100)
                        pyDict["n_components"] = ToPython(n_components);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.kernel_approximation.self.InvokeMethod("Nystroem", args, pyDict);
                }

                internal Nystroem(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static Nystroem Encapsule(PyObject pyObject)
                {
                    return new Nystroem(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public NDarray component_indices_ => ToCsharp<NDarray>(self.GetAttr("component_indices_"));
                public NDarray normalization_ => ToCsharp<NDarray>(self.GetAttr("normalization_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public Nystroem fit(NDarray X, NDarray? y = null)
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

                public Nystroem set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public Nystroem set_params(Dictionary<string, PyObject>? @params = null)
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

            public class PolynomialCountSketch : PythonObject
            {
                public PolynomialCountSketch(float gamma = 1.0f, int degree = 2, int coef0 = 0, int n_components = 100, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (gamma != 1.0f)
                        pyDict["gamma"] = ToPython(gamma);
                    if (degree != 2)
                        pyDict["degree"] = ToPython(degree);
                    if (coef0 != 0)
                        pyDict["coef0"] = ToPython(coef0);
                    if (n_components != 100)
                        pyDict["n_components"] = ToPython(n_components);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.kernel_approximation.self.InvokeMethod("PolynomialCountSketch", args, pyDict);
                }

                internal PolynomialCountSketch(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static PolynomialCountSketch Encapsule(PyObject pyObject)
                {
                    return new PolynomialCountSketch(pyObject);
                }

                public NDarray indexHash_ => ToCsharp<NDarray>(self.GetAttr("indexHash_"));
                public NDarray bitHash_ => ToCsharp<NDarray>(self.GetAttr("bitHash_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public PolynomialCountSketch fit(NDarray X, NDarray? y = null)
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

                public PolynomialCountSketch set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public PolynomialCountSketch set_params(Dictionary<string, PyObject>? @params = null)
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

            public class RBFSampler : PythonObject
            {
                public RBFSampler(float gamma = 1.0f, int n_components = 100, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (gamma != 1.0f)
                        pyDict["gamma"] = ToPython(gamma);
                    if (n_components != 100)
                        pyDict["n_components"] = ToPython(n_components);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.kernel_approximation.self.InvokeMethod("RBFSampler", args, pyDict);
                }

                internal RBFSampler(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RBFSampler Encapsule(PyObject pyObject)
                {
                    return new RBFSampler(pyObject);
                }

                public NDarray random_offset_ => ToCsharp<NDarray>(self.GetAttr("random_offset_"));
                public NDarray random_weights_ => ToCsharp<NDarray>(self.GetAttr("random_weights_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public RBFSampler fit(NDarray X, NDarray? y = null)
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

                public RBFSampler set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public RBFSampler set_params(Dictionary<string, PyObject>? @params = null)
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

            public class SkewedChi2Sampler : PythonObject
            {
                public SkewedChi2Sampler(float skewedness = 1.0f, int n_components = 100, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (skewedness != 1.0f)
                        pyDict["skewedness"] = ToPython(skewedness);
                    if (n_components != 100)
                        pyDict["n_components"] = ToPython(n_components);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.kernel_approximation.self.InvokeMethod("SkewedChi2Sampler", args, pyDict);
                }

                internal SkewedChi2Sampler(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SkewedChi2Sampler Encapsule(PyObject pyObject)
                {
                    return new SkewedChi2Sampler(pyObject);
                }

                public NDarray random_weights_ => ToCsharp<NDarray>(self.GetAttr("random_weights_"));
                public NDarray random_offset_ => ToCsharp<NDarray>(self.GetAttr("random_offset_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public SkewedChi2Sampler fit(NDarray X, NDarray? y = null)
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

                public SkewedChi2Sampler set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SkewedChi2Sampler set_params(Dictionary<string, PyObject>? @params = null)
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
        }
    }
}