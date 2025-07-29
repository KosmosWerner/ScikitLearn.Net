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

        static discriminant_analysis() => ReInitializeLazySelf();
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

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LinearDiscriminantAnalysis Encapsule(PyObject pyObject) => new LinearDiscriminantAnalysis(pyObject);
            public static LinearDiscriminantAnalysis Wrap(PyObject pyObject) => new LinearDiscriminantAnalysis(pyObject);
            public NDarray coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("coef_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray intercept_
            {
                get
                {
                    var __pyObject = self.GetAttr("intercept_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray covariance_
            {
                get
                {
                    var __pyObject = self.GetAttr("covariance_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray explained_variance_ratio_
            {
                get
                {
                    var __pyObject = self.GetAttr("explained_variance_ratio_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray means_
            {
                get
                {
                    var __pyObject = self.GetAttr("means_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray priors_
            {
                get
                {
                    var __pyObject = self.GetAttr("priors_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray scalings_
            {
                get
                {
                    var __pyObject = self.GetAttr("scalings_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray xbar_
            {
                get
                {
                    var __pyObject = self.GetAttr("xbar_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
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

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
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

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
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
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
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

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static QuadraticDiscriminantAnalysis Encapsule(PyObject pyObject) => new QuadraticDiscriminantAnalysis(pyObject);
            public static QuadraticDiscriminantAnalysis Wrap(PyObject pyObject) => new QuadraticDiscriminantAnalysis(pyObject);
            public NDarray covariance_
            {
                get
                {
                    var __pyObject = self.GetAttr("covariance_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray means_
            {
                get
                {
                    var __pyObject = self.GetAttr("means_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray priors_
            {
                get
                {
                    var __pyObject = self.GetAttr("priors_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray rotations_
            {
                get
                {
                    var __pyObject = self.GetAttr("rotations_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray scalings_
            {
                get
                {
                    var __pyObject = self.GetAttr("scalings_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
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

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
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

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
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