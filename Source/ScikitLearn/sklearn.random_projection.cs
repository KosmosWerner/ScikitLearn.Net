using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class random_projection
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
                return Py.Import("sklearn.random_projection");
            }

            static random_projection()
            {
                ReInitializeLazySelf();
            }

            public class GaussianRandomProjection : PythonObject
            {
                public GaussianRandomProjection(string n_components = "auto", float eps = 0.1f, bool compute_inverse_components = false, int? random_state = null)
                {
                    _ = sklearn.random_projection.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != "auto")
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (eps != 0.1f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (compute_inverse_components != false)
                        pyDict["compute_inverse_components"] = Helpers.ToPython(compute_inverse_components);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.random_projection.self.InvokeMethod("GaussianRandomProjection", args, pyDict);
                }

                internal GaussianRandomProjection(PyObject pyObject)
                {
                    _ = sklearn.random_projection.self;
                    self = pyObject;
                }

                public static GaussianRandomProjection Encapsule(PyObject pyObject)
                {
                    return new GaussianRandomProjection(pyObject);
                }

                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray inverse_components_ => Helpers.ToCSharpNDarray(self.GetAttr("inverse_components_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public GaussianRandomProjection fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public GaussianRandomProjection set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public GaussianRandomProjection set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class SparseRandomProjection : PythonObject
            {
                public SparseRandomProjection(string n_components = "auto", string density = "auto", float eps = 0.1f, bool dense_output = false, bool compute_inverse_components = false, int? random_state = null)
                {
                    _ = sklearn.random_projection.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != "auto")
                        pyDict["n_components"] = Helpers.ToPython(n_components);
                    if (density != "auto")
                        pyDict["density"] = Helpers.ToPython(density);
                    if (eps != 0.1f)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (dense_output != false)
                        pyDict["dense_output"] = Helpers.ToPython(dense_output);
                    if (compute_inverse_components != false)
                        pyDict["compute_inverse_components"] = Helpers.ToPython(compute_inverse_components);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.random_projection.self.InvokeMethod("SparseRandomProjection", args, pyDict);
                }

                internal SparseRandomProjection(PyObject pyObject)
                {
                    _ = sklearn.random_projection.self;
                    self = pyObject;
                }

                public static SparseRandomProjection Encapsule(PyObject pyObject)
                {
                    return new SparseRandomProjection(pyObject);
                }

                public int n_components_ => Helpers.ToCSharpInt(self.GetAttr("n_components_"));
                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray inverse_components_ => Helpers.ToCSharpNDarray(self.GetAttr("inverse_components_"));
                public float density_ => Helpers.ToCSharpFloat(self.GetAttr("density_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SparseRandomProjection fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("inverse_transform", args, pyDict));
                }

                public SparseRandomProjection set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public SparseRandomProjection set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public static NDarray johnson_lindenstrauss_min_dim(NDarray n_samples, float eps = 0.1f)
            {
                _ = sklearn.random_projection.self;
                PyTuple args = new PyTuple([Helpers.ToPython(n_samples)]);
                PyDict pyDict = new PyDict();
                if (eps != 0.1f)
                    pyDict["eps"] = Helpers.ToPython(eps);
                return Helpers.ToCSharpNDarray(sklearn.random_projection.self.InvokeMethod("johnson_lindenstrauss_min_dim", args, pyDict));
            }
        }
    }
}