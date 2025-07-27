namespace ScikitLearn;
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

        public static NDarray johnson_lindenstrauss_min_dim(NDarray n_samples, float eps = 0.1f)
        {
            _ = sklearn.random_projection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_samples) });
            PyDict pyDict = new PyDict();
            if (eps != 0.1f)
                pyDict["eps"] = Helpers.ToPython(eps);
            throw new NotImplementedException();
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

            public static GaussianRandomProjection Encapsule(PyObject pyObject) => new GaussianRandomProjection(pyObject);
            public int n_components_
            {
                get
                {
                    return self.GetAttr("n_components_").As<int>();
                }
            }

            public NDarray components_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray inverse_components_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public GaussianRandomProjection fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray inverse_transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public GaussianRandomProjection set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public GaussianRandomProjection set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
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

            public static SparseRandomProjection Encapsule(PyObject pyObject) => new SparseRandomProjection(pyObject);
            public int n_components_
            {
                get
                {
                    return self.GetAttr("n_components_").As<int>();
                }
            }

            public NDarray components_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray inverse_components_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float density_
            {
                get
                {
                    return self.GetAttr("density_").As<float>();
                }
            }

            public int n_features_in_
            {
                get
                {
                    return self.GetAttr("n_features_in_").As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public SparseRandomProjection fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                throw new NotImplementedException();
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                throw new NotImplementedException();
            }

            public NDarray inverse_transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public SparseRandomProjection set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public SparseRandomProjection set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }
        }
    }
}