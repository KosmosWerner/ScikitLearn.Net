namespace ScikitLearn;
#nullable enable
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

        static random_projection() => ReInitializeLazySelf();
        public static NDarray johnson_lindenstrauss_min_dim(NDarray n_samples, float eps = 0.1f)
        {
            _ = sklearn.random_projection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_samples) });
            PyDict pyDict = new PyDict();
            if (eps != 0.1f)
                pyDict["eps"] = Helpers.ToPython(eps);
            var __pyObject = self.InvokeMethod("johnson_lindenstrauss_min_dim", args, pyDict);
            return new NDarray(__pyObject);
        }

        public class GaussianRandomProjection : PythonObject
        {
            public GaussianRandomProjection(string n_components = "auto", float eps = 0.1f, bool compute_inverse_components = false, int? random_state = null)
            {
                _ = sklearn.random_projection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
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

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static GaussianRandomProjection Encapsule(PyObject pyObject) => new GaussianRandomProjection(pyObject);
            public static GaussianRandomProjection Wrap(PyObject pyObject) => new GaussianRandomProjection(pyObject);
            public int n_components_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_components_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray components_
            {
                get
                {
                    var __pyObject = self.GetAttr("components_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray inverse_components_
            {
                get
                {
                    var __pyObject = self.GetAttr("inverse_components_");
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

            public GaussianRandomProjection fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public NDarray inverse_transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("inverse_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public GaussianRandomProjection set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public GaussianRandomProjection set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class SparseRandomProjection : PythonObject
        {
            public SparseRandomProjection(string n_components = "auto", string density = "auto", float eps = 0.1f, bool dense_output = false, bool compute_inverse_components = false, int? random_state = null)
            {
                _ = sklearn.random_projection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
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

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static SparseRandomProjection Encapsule(PyObject pyObject) => new SparseRandomProjection(pyObject);
            public static SparseRandomProjection Wrap(PyObject pyObject) => new SparseRandomProjection(pyObject);
            public int n_components_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_components_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray components_
            {
                get
                {
                    var __pyObject = self.GetAttr("components_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray inverse_components_
            {
                get
                {
                    var __pyObject = self.GetAttr("inverse_components_");
                    return new NDarray(__pyObject);
                }
            }

            public float density_
            {
                get
                {
                    var __pyObject = self.GetAttr("density_");
                    return __pyObject.As<float>();
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

            public SparseRandomProjection fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public NDarray inverse_transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("inverse_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public SparseRandomProjection set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public SparseRandomProjection set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }
    }
}