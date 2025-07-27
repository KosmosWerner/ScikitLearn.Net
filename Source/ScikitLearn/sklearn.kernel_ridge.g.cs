namespace ScikitLearn;
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
                _ = sklearn.kernel_ridge.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (alpha != 1)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (kernel != "linear")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (gamma != null)
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (degree != 3)
                    pyDict["degree"] = Helpers.ToPython(degree);
                if (coef0 != 1)
                    pyDict["coef0"] = Helpers.ToPython(coef0);
                if (kernel_params != null)
                    pyDict["kernel_params"] = Helpers.ToPython(kernel_params);
                self = sklearn.kernel_ridge.self.InvokeMethod("KernelRidge", args, pyDict);
            }

            internal KernelRidge(PyObject pyObject)
            {
                _ = sklearn.kernel_ridge.self;
                self = pyObject;
            }

            public static KernelRidge Encapsule(PyObject pyObject) => new KernelRidge(pyObject);
            public NDarray dual_coef_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray X_fit_
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

            public KernelRidge fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public KernelRidge set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public KernelRidge set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public KernelRidge set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }
    }
}