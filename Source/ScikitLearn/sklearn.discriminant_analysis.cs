using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (solver != "svd")
                        pyDict["solver"] = ToPython(solver);
                    if (shrinkage != null)
                        pyDict["shrinkage"] = ToPython(shrinkage);
                    if (priors != null)
                        pyDict["priors"] = ToPython(priors);
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (store_covariance != false)
                        pyDict["store_covariance"] = ToPython(store_covariance);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    if (covariance_estimator != null)
                        pyDict["covariance_estimator"] = ToPython(covariance_estimator);
                    self = sklearn.discriminant_analysis.self.InvokeMethod("LinearDiscriminantAnalysis", args, pyDict);
                }

                internal LinearDiscriminantAnalysis(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static LinearDiscriminantAnalysis Encapsule(PyObject pyObject)
                {
                    return new LinearDiscriminantAnalysis(pyObject);
                }

                public NDarray coef_ => ToCsharp<NDarray>(self.GetAttr("coef_"));
                public NDarray intercept_ => ToCsharp<NDarray>(self.GetAttr("intercept_"));
                public NDarray covariance_ => ToCsharp<NDarray>(self.GetAttr("covariance_"));
                public NDarray explained_variance_ratio_ => ToCsharp<NDarray>(self.GetAttr("explained_variance_ratio_"));
                public NDarray means_ => ToCsharp<NDarray>(self.GetAttr("means_"));
                public NDarray priors_ => ToCsharp<NDarray>(self.GetAttr("priors_"));
                public NDarray scalings_ => ToCsharp<NDarray>(self.GetAttr("scalings_"));
                public NDarray xbar_ => ToCsharp<NDarray>(self.GetAttr("xbar_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public LinearDiscriminantAnalysis fit(NDarray X, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
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

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_log_proba", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public LinearDiscriminantAnalysis set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public LinearDiscriminantAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LinearDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class QuadraticDiscriminantAnalysis : PythonObject
            {
                public QuadraticDiscriminantAnalysis(NDarray? priors = null, float reg_param = 0.0f, bool store_covariance = false, float tol = 0.0001f)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (priors != null)
                        pyDict["priors"] = ToPython(priors);
                    if (reg_param != 0.0f)
                        pyDict["reg_param"] = ToPython(reg_param);
                    if (store_covariance != false)
                        pyDict["store_covariance"] = ToPython(store_covariance);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    self = sklearn.discriminant_analysis.self.InvokeMethod("QuadraticDiscriminantAnalysis", args, pyDict);
                }

                internal QuadraticDiscriminantAnalysis(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static QuadraticDiscriminantAnalysis Encapsule(PyObject pyObject)
                {
                    return new QuadraticDiscriminantAnalysis(pyObject);
                }

                public NDarray covariance_ => ToCsharp<NDarray>(self.GetAttr("covariance_"));
                public NDarray means_ => ToCsharp<NDarray>(self.GetAttr("means_"));
                public NDarray priors_ => ToCsharp<NDarray>(self.GetAttr("priors_"));
                public NDarray rotations_ => ToCsharp<NDarray>(self.GetAttr("rotations_"));
                public NDarray scalings_ => ToCsharp<NDarray>(self.GetAttr("scalings_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public QuadraticDiscriminantAnalysis fit(NDarray X, NDarray y)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
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

                public NDarray predict_log_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_log_proba", args, pyDict));
                }

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public QuadraticDiscriminantAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public QuadraticDiscriminantAnalysis set_score_request(string? sample_weight = "$UNCHANGED$")
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