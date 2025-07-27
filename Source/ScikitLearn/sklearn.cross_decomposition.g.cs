namespace ScikitLearn;
public static partial class sklearn
{
    public static class cross_decomposition
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
            return Py.Import("sklearn.cross_decomposition");
        }

        static cross_decomposition()
        {
            ReInitializeLazySelf();
        }

        public class CCA : PythonObject
        {
            public CCA(int n_components = 2, bool scale = true, int max_iter = 500, float tol = 1e-06f, bool copy = true)
            {
                _ = sklearn.cross_decomposition.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (scale != true)
                    pyDict["scale"] = Helpers.ToPython(scale);
                if (max_iter != 500)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 1e-06f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                self = sklearn.cross_decomposition.self.InvokeMethod("CCA", args, pyDict);
            }

            internal CCA(PyObject pyObject)
            {
                _ = sklearn.cross_decomposition.self;
                self = pyObject;
            }

            public static CCA Encapsule(PyObject pyObject) => new CCA(pyObject);
            public NDarray x_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray x_loadings_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_loadings_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray x_rotations_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_rotations_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray coef_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray intercept_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray n_iter_
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

            public CCA fit(NDarray X, NDarray? y = null, NDarray? Y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                throw new NotImplementedException();
            }

            public CCA fit_transform(NDarray X, NDarray? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public (NDarray? , NDarray? ) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X, bool copy = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
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

            public CCA set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public CCA set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public CCA set_predict_request(string? copy = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (copy != "$UNCHANGED$")
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }

            public CCA set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public CCA set_transform_request(string? copy = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (copy != "$UNCHANGED$")
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }
        }

        public class PLSCanonical : PythonObject
        {
            public PLSCanonical(int n_components = 2, bool scale = true, string algorithm = "nipals", int max_iter = 500, float tol = 1e-06f, bool copy = true)
            {
                _ = sklearn.cross_decomposition.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (scale != true)
                    pyDict["scale"] = Helpers.ToPython(scale);
                if (algorithm != "nipals")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (max_iter != 500)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 1e-06f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                self = sklearn.cross_decomposition.self.InvokeMethod("PLSCanonical", args, pyDict);
            }

            internal PLSCanonical(PyObject pyObject)
            {
                _ = sklearn.cross_decomposition.self;
                self = pyObject;
            }

            public static PLSCanonical Encapsule(PyObject pyObject) => new PLSCanonical(pyObject);
            public NDarray x_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray x_loadings_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_loadings_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray x_rotations_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_rotations_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray coef_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray intercept_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray n_iter_
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

            public PLSCanonical fit(NDarray X, NDarray? y = null, NDarray? Y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                throw new NotImplementedException();
            }

            public PLSCanonical fit_transform(NDarray X, NDarray? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public (NDarray? , NDarray? ) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X, bool copy = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
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

            public PLSCanonical set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public PLSCanonical set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PLSCanonical set_predict_request(string? copy = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (copy != "$UNCHANGED$")
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }

            public PLSCanonical set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PLSCanonical set_transform_request(string? copy = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (copy != "$UNCHANGED$")
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }
        }

        public class PLSRegression : PythonObject
        {
            public PLSRegression(int n_components = 2, bool scale = true, int max_iter = 500, float tol = 1e-06f, bool copy = true)
            {
                _ = sklearn.cross_decomposition.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (scale != true)
                    pyDict["scale"] = Helpers.ToPython(scale);
                if (max_iter != 500)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 1e-06f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                self = sklearn.cross_decomposition.self.InvokeMethod("PLSRegression", args, pyDict);
            }

            internal PLSRegression(PyObject pyObject)
            {
                _ = sklearn.cross_decomposition.self;
                self = pyObject;
            }

            public static PLSRegression Encapsule(PyObject pyObject) => new PLSRegression(pyObject);
            public NDarray x_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray x_loadings_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_loadings_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray x_scores_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_scores_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray x_rotations_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_rotations_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray coef_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray intercept_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray n_iter_
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

            public PLSRegression fit(NDarray X, NDarray? y = null, NDarray? Y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                throw new NotImplementedException();
            }

            public PLSRegression fit_transform(NDarray X, NDarray? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public (NDarray? , NDarray? ) inverse_transform(NDarray X, NDarray? y = null, NDarray? Y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X, bool copy = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
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

            public PLSRegression set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public PLSRegression set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public PLSRegression set_predict_request(string? copy = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (copy != "$UNCHANGED$")
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }

            public PLSRegression set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }

            public PLSRegression set_transform_request(string? copy = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (copy != "$UNCHANGED$")
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null, bool copy = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                throw new NotImplementedException();
            }
        }

        public class PLSSVD : PythonObject
        {
            public PLSSVD(int n_components = 2, bool scale = true, bool copy = true)
            {
                _ = sklearn.cross_decomposition.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (scale != true)
                    pyDict["scale"] = Helpers.ToPython(scale);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                self = sklearn.cross_decomposition.self.InvokeMethod("PLSSVD", args, pyDict);
            }

            internal PLSSVD(PyObject pyObject)
            {
                _ = sklearn.cross_decomposition.self;
                self = pyObject;
            }

            public static PLSSVD Encapsule(PyObject pyObject) => new PLSSVD(pyObject);
            public NDarray x_weights_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray y_weights_
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

            public PLSSVD fit(NDarray X, NDarray? y = null, NDarray? Y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                throw new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public PLSSVD set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                throw new NotImplementedException();
            }

            public PLSSVD set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public NDarray transform(NDarray X, NDarray? y = null, NDarray? Y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                throw new NotImplementedException();
            }
        }
    }
}