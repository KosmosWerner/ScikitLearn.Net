namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class discriminant_analysis
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
            return Py.Import("sklearn.discriminant_analysis");
        }

        static discriminant_analysis()
        {
            ReInitializeLazySelf();
        }

        public class LinearDiscriminantAnalysis : PythonObject
        {
            public LinearDiscriminantAnalysis(string solver = "svd", float? shrinkage = null, NDarray? priors = null, int? n_components = null, bool store_covariance = false, float tol = 0.0001f, PyObject? covariance_estimator = null)
            {
                _ = sklearn.discriminant_analysis.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (solver != "svd")
                    pyDict["solver"] = Helpers.ToPython(solver);
                if (shrinkage != null)
                    pyDict["shrinkage"] = Helpers.ToPython(shrinkage);
                if (priors != null)
                    pyDict["priors"] = Helpers.ToPython(priors);
                if (n_components != null)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (store_covariance != false)
                    pyDict["store_covariance"] = Helpers.ToPython(store_covariance);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (covariance_estimator != null)
                    pyDict["covariance_estimator"] = Helpers.ToPython(covariance_estimator);
                self = sklearn.discriminant_analysis.self.InvokeMethod("LinearDiscriminantAnalysis", args, pyDict);
            }

            internal LinearDiscriminantAnalysis(PyObject pyObject)
            {
                _ = sklearn.discriminant_analysis.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static LinearDiscriminantAnalysis Encapsule(PyObject pyObject) => new LinearDiscriminantAnalysis(pyObject);
            public static LinearDiscriminantAnalysis Wrap(PyObject pyObject) => new LinearDiscriminantAnalysis(pyObject);
            public NDarray coef_ => new NotImplementedException();
            public NDarray intercept_ => new NotImplementedException();
            public NDarray covariance_ => new NotImplementedException();
            public NDarray explained_variance_ratio_ => new NotImplementedException();
            public NDarray means_ => new NotImplementedException();
            public NDarray priors_ => new NotImplementedException();
            public NDarray scalings_ => new NotImplementedException();
            public NDarray xbar_ => new NotImplementedException();
            public NDarray classes_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public LinearDiscriminantAnalysis fit(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
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
                return new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                return new NotImplementedException();
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

            public NDarray predict_log_proba(NDarray X)
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

            public LinearDiscriminantAnalysis set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public LinearDiscriminantAnalysis set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public LinearDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }
        }

        public class QuadraticDiscriminantAnalysis : PythonObject
        {
            public QuadraticDiscriminantAnalysis(NDarray? priors = null, float reg_param = 0.0f, bool store_covariance = false, float tol = 0.0001f)
            {
                _ = sklearn.discriminant_analysis.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (priors != null)
                    pyDict["priors"] = Helpers.ToPython(priors);
                if (reg_param != 0.0f)
                    pyDict["reg_param"] = Helpers.ToPython(reg_param);
                if (store_covariance != false)
                    pyDict["store_covariance"] = Helpers.ToPython(store_covariance);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                self = sklearn.discriminant_analysis.self.InvokeMethod("QuadraticDiscriminantAnalysis", args, pyDict);
            }

            internal QuadraticDiscriminantAnalysis(PyObject pyObject)
            {
                _ = sklearn.discriminant_analysis.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static QuadraticDiscriminantAnalysis Encapsule(PyObject pyObject) => new QuadraticDiscriminantAnalysis(pyObject);
            public static QuadraticDiscriminantAnalysis Wrap(PyObject pyObject) => new QuadraticDiscriminantAnalysis(pyObject);
            public NDarray covariance_ => new NotImplementedException();
            public NDarray means_ => new NotImplementedException();
            public NDarray priors_ => new NotImplementedException();
            public NDarray rotations_ => new NotImplementedException();
            public NDarray scalings_ => new NotImplementedException();
            public NDarray classes_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public QuadraticDiscriminantAnalysis fit(NDarray X, NDarray y)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
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

            public NDarray predict_log_proba(NDarray X)
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

            public QuadraticDiscriminantAnalysis set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public QuadraticDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }
    }
}