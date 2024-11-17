using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class svm
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
                return Py.Import("sklearn.svm");
            }

            static svm()
            {
                ReInitializeLazySelf();
            }

            public class LinearSVC : PythonObject
            {
                public LinearSVC(string penalty = "l2", string loss = "squared_hinge", string dual = "auto", float tol = 0.0001f, float C = 1.0f, string multi_class = "ovr", bool fit_intercept = true, int intercept_scaling = 1, PyDict? class_weight = null, int verbose = 0, int? random_state = null, int max_iter = 1000)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (penalty != "l2")
                        pyDict["penalty"] = ToPython(penalty);
                    if (loss != "squared_hinge")
                        pyDict["loss"] = ToPython(loss);
                    if (dual != "auto")
                        pyDict["dual"] = ToPython(dual);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    if (C != 1.0f)
                        pyDict["C"] = ToPython(C);
                    if (multi_class != "ovr")
                        pyDict["multi_class"] = ToPython(multi_class);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = ToPython(fit_intercept);
                    if (intercept_scaling != 1)
                        pyDict["intercept_scaling"] = ToPython(intercept_scaling);
                    if (class_weight != null)
                        pyDict["class_weight"] = ToPython(class_weight);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = ToPython(max_iter);
                    self = sklearn.svm.self.InvokeMethod("LinearSVC", args, pyDict);
                }

                internal LinearSVC(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static LinearSVC Encapsule(PyObject pyObject)
                {
                    return new LinearSVC(pyObject);
                }

                public NDarray coef_ => ToCsharp<NDarray>(self.GetAttr("coef_"));
                public NDarray intercept_ => ToCsharp<NDarray>(self.GetAttr("intercept_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public LinearSVC densify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("densify", args, pyDict);
                    return this;
                }

                public LinearSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public LinearSVC set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LinearSVC set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LinearSVC set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }

                public LinearSVC sparsify()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("sparsify", args, pyDict);
                    return this;
                }
            }

            public class LinearSVR : PythonObject
            {
                public LinearSVR(float epsilon = 0.0f, float tol = 0.0001f, float C = 1.0f, string loss = "epsilon_insensitive", bool fit_intercept = true, float intercept_scaling = 1.0f, string dual = "auto", int verbose = 0, int? random_state = null, int max_iter = 1000)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (epsilon != 0.0f)
                        pyDict["epsilon"] = ToPython(epsilon);
                    if (tol != 0.0001f)
                        pyDict["tol"] = ToPython(tol);
                    if (C != 1.0f)
                        pyDict["C"] = ToPython(C);
                    if (loss != "epsilon_insensitive")
                        pyDict["loss"] = ToPython(loss);
                    if (fit_intercept != true)
                        pyDict["fit_intercept"] = ToPython(fit_intercept);
                    if (intercept_scaling != 1.0f)
                        pyDict["intercept_scaling"] = ToPython(intercept_scaling);
                    if (dual != "auto")
                        pyDict["dual"] = ToPython(dual);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (max_iter != 1000)
                        pyDict["max_iter"] = ToPython(max_iter);
                    self = sklearn.svm.self.InvokeMethod("LinearSVR", args, pyDict);
                }

                internal LinearSVR(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static LinearSVR Encapsule(PyObject pyObject)
                {
                    return new LinearSVR(pyObject);
                }

                public NDarray coef_ => ToCsharp<NDarray>(self.GetAttr("coef_"));
                public NDarray intercept_ => ToCsharp<NDarray>(self.GetAttr("intercept_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));

                public LinearSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public LinearSVR set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public LinearSVR set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LinearSVR set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class NuSVC : PythonObject
            {
                public NuSVC(float nu = 0.5f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, bool probability = false, float tol = 0.001f, int cache_size = 200, PyDict? class_weight = null, bool verbose = false, int max_iter = -1, string decision_function_shape = "ovr", bool break_ties = false, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (nu != 0.5f)
                        pyDict["nu"] = ToPython(nu);
                    if (kernel != "rbf")
                        pyDict["kernel"] = ToPython(kernel);
                    if (degree != 3)
                        pyDict["degree"] = ToPython(degree);
                    if (gamma != "scale")
                        pyDict["gamma"] = ToPython(gamma);
                    if (coef0 != 0.0f)
                        pyDict["coef0"] = ToPython(coef0);
                    if (shrinking != true)
                        pyDict["shrinking"] = ToPython(shrinking);
                    if (probability != false)
                        pyDict["probability"] = ToPython(probability);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (cache_size != 200)
                        pyDict["cache_size"] = ToPython(cache_size);
                    if (class_weight != null)
                        pyDict["class_weight"] = ToPython(class_weight);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (max_iter != -1)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (decision_function_shape != "ovr")
                        pyDict["decision_function_shape"] = ToPython(decision_function_shape);
                    if (break_ties != false)
                        pyDict["break_ties"] = ToPython(break_ties);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.svm.self.InvokeMethod("NuSVC", args, pyDict);
                }

                internal NuSVC(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static NuSVC Encapsule(PyObject pyObject)
                {
                    return new NuSVC(pyObject);
                }

                public NDarray class_weight_ => ToCsharp<NDarray>(self.GetAttr("class_weight_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public NDarray coef_ => ToCsharp<NDarray>(self.GetAttr("coef_"));
                public NDarray dual_coef_ => ToCsharp<NDarray>(self.GetAttr("dual_coef_"));
                public int fit_status_ => ToCsharp<int>(self.GetAttr("fit_status_"));
                public NDarray intercept_ => ToCsharp<NDarray>(self.GetAttr("intercept_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public NDarray n_iter_ => ToCsharp<NDarray>(self.GetAttr("n_iter_"));
                public NDarray support_ => ToCsharp<NDarray>(self.GetAttr("support_"));
                public NDarray support_vectors_ => ToCsharp<NDarray>(self.GetAttr("support_vectors_"));
                public NDarray n_support_ => ToCsharp<NDarray>(self.GetAttr("n_support_"));
                //public int fit_status_ => ToCsharp<int>(self.GetAttr("fit_status_"));
                public NDarray probA_ => ToCsharp<NDarray>(self.GetAttr("probA_"));
                public NDarray probB_ => ToCsharp<NDarray>(self.GetAttr("probB_"));
                public NDarray shape_fit_ => ToCsharp<NDarray>(self.GetAttr("shape_fit_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public NuSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NuSVC set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public NuSVC set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NuSVC set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class NuSVR : PythonObject
            {
                public NuSVR(float nu = 0.5f, float C = 1.0f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, float tol = 0.001f, int cache_size = 200, bool verbose = false, int max_iter = -1)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (nu != 0.5f)
                        pyDict["nu"] = ToPython(nu);
                    if (C != 1.0f)
                        pyDict["C"] = ToPython(C);
                    if (kernel != "rbf")
                        pyDict["kernel"] = ToPython(kernel);
                    if (degree != 3)
                        pyDict["degree"] = ToPython(degree);
                    if (gamma != "scale")
                        pyDict["gamma"] = ToPython(gamma);
                    if (coef0 != 0.0f)
                        pyDict["coef0"] = ToPython(coef0);
                    if (shrinking != true)
                        pyDict["shrinking"] = ToPython(shrinking);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (cache_size != 200)
                        pyDict["cache_size"] = ToPython(cache_size);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (max_iter != -1)
                        pyDict["max_iter"] = ToPython(max_iter);
                    self = sklearn.svm.self.InvokeMethod("NuSVR", args, pyDict);
                }

                internal NuSVR(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static NuSVR Encapsule(PyObject pyObject)
                {
                    return new NuSVR(pyObject);
                }

                public NDarray coef_ => ToCsharp<NDarray>(self.GetAttr("coef_"));
                public NDarray dual_coef_ => ToCsharp<NDarray>(self.GetAttr("dual_coef_"));
                public int fit_status_ => ToCsharp<int>(self.GetAttr("fit_status_"));
                public NDarray intercept_ => ToCsharp<NDarray>(self.GetAttr("intercept_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public NDarray n_support_ => ToCsharp<NDarray>(self.GetAttr("n_support_"));
                public NDarray shape_fit_ => ToCsharp<NDarray>(self.GetAttr("shape_fit_"));
                public NDarray support_ => ToCsharp<NDarray>(self.GetAttr("support_"));
                public NDarray support_vectors_ => ToCsharp<NDarray>(self.GetAttr("support_vectors_"));

                public NuSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NuSVR set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public NuSVR set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NuSVR set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class OneClassSVM : PythonObject
            {
                public OneClassSVM(string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, float tol = 0.001f, float nu = 0.5f, bool shrinking = true, int cache_size = 200, bool verbose = false, int max_iter = -1)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (kernel != "rbf")
                        pyDict["kernel"] = ToPython(kernel);
                    if (degree != 3)
                        pyDict["degree"] = ToPython(degree);
                    if (gamma != "scale")
                        pyDict["gamma"] = ToPython(gamma);
                    if (coef0 != 0.0f)
                        pyDict["coef0"] = ToPython(coef0);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (nu != 0.5f)
                        pyDict["nu"] = ToPython(nu);
                    if (shrinking != true)
                        pyDict["shrinking"] = ToPython(shrinking);
                    if (cache_size != 200)
                        pyDict["cache_size"] = ToPython(cache_size);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (max_iter != -1)
                        pyDict["max_iter"] = ToPython(max_iter);
                    self = sklearn.svm.self.InvokeMethod("OneClassSVM", args, pyDict);
                }

                internal OneClassSVM(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static OneClassSVM Encapsule(PyObject pyObject)
                {
                    return new OneClassSVM(pyObject);
                }

                public NDarray coef_ => ToCsharp<NDarray>(self.GetAttr("coef_"));
                public NDarray dual_coef_ => ToCsharp<NDarray>(self.GetAttr("dual_coef_"));
                public int fit_status_ => ToCsharp<int>(self.GetAttr("fit_status_"));
                public NDarray intercept_ => ToCsharp<NDarray>(self.GetAttr("intercept_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public NDarray n_support_ => ToCsharp<NDarray>(self.GetAttr("n_support_"));
                public float offset_ => ToCsharp<float>(self.GetAttr("offset_"));
                public NDarray shape_fit_ => ToCsharp<NDarray>(self.GetAttr("shape_fit_"));
                public NDarray support_ => ToCsharp<NDarray>(self.GetAttr("support_"));
                public NDarray support_vectors_ => ToCsharp<NDarray>(self.GetAttr("support_vectors_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public OneClassSVM fit(NDarray X, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_predict", args, pyDict));
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

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("score_samples", args, pyDict));
                }

                public OneClassSVM set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public OneClassSVM set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class SVC : PythonObject
            {
                public SVC(float C = 1.0f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, bool probability = false, float tol = 0.001f, int cache_size = 200, PyDict? class_weight = null, bool verbose = false, int max_iter = -1, string decision_function_shape = "ovr", bool break_ties = false, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (C != 1.0f)
                        pyDict["C"] = ToPython(C);
                    if (kernel != "rbf")
                        pyDict["kernel"] = ToPython(kernel);
                    if (degree != 3)
                        pyDict["degree"] = ToPython(degree);
                    if (gamma != "scale")
                        pyDict["gamma"] = ToPython(gamma);
                    if (coef0 != 0.0f)
                        pyDict["coef0"] = ToPython(coef0);
                    if (shrinking != true)
                        pyDict["shrinking"] = ToPython(shrinking);
                    if (probability != false)
                        pyDict["probability"] = ToPython(probability);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (cache_size != 200)
                        pyDict["cache_size"] = ToPython(cache_size);
                    if (class_weight != null)
                        pyDict["class_weight"] = ToPython(class_weight);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (max_iter != -1)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (decision_function_shape != "ovr")
                        pyDict["decision_function_shape"] = ToPython(decision_function_shape);
                    if (break_ties != false)
                        pyDict["break_ties"] = ToPython(break_ties);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.svm.self.InvokeMethod("SVC", args, pyDict);
                }

                internal SVC(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SVC Encapsule(PyObject pyObject)
                {
                    return new SVC(pyObject);
                }

                public NDarray class_weight_ => ToCsharp<NDarray>(self.GetAttr("class_weight_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public NDarray coef_ => ToCsharp<NDarray>(self.GetAttr("coef_"));
                public NDarray dual_coef_ => ToCsharp<NDarray>(self.GetAttr("dual_coef_"));
                public int fit_status_ => ToCsharp<int>(self.GetAttr("fit_status_"));
                public NDarray intercept_ => ToCsharp<NDarray>(self.GetAttr("intercept_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public NDarray n_iter_ => ToCsharp<NDarray>(self.GetAttr("n_iter_"));
                public NDarray support_ => ToCsharp<NDarray>(self.GetAttr("support_"));
                public NDarray support_vectors_ => ToCsharp<NDarray>(self.GetAttr("support_vectors_"));
                public NDarray n_support_ => ToCsharp<NDarray>(self.GetAttr("n_support_"));
                public NDarray probA_ => ToCsharp<NDarray>(self.GetAttr("probA_"));
                public NDarray probB_ => ToCsharp<NDarray>(self.GetAttr("probB_"));
                public NDarray shape_fit_ => ToCsharp<NDarray>(self.GetAttr("shape_fit_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public SVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public SVC set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public SVC set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public SVC set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class SVR : PythonObject
            {
                public SVR(string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, float tol = 0.001f, float C = 1.0f, float epsilon = 0.1f, bool shrinking = true, int cache_size = 200, bool verbose = false, int max_iter = -1)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (kernel != "rbf")
                        pyDict["kernel"] = ToPython(kernel);
                    if (degree != 3)
                        pyDict["degree"] = ToPython(degree);
                    if (gamma != "scale")
                        pyDict["gamma"] = ToPython(gamma);
                    if (coef0 != 0.0f)
                        pyDict["coef0"] = ToPython(coef0);
                    if (tol != 0.001f)
                        pyDict["tol"] = ToPython(tol);
                    if (C != 1.0f)
                        pyDict["C"] = ToPython(C);
                    if (epsilon != 0.1f)
                        pyDict["epsilon"] = ToPython(epsilon);
                    if (shrinking != true)
                        pyDict["shrinking"] = ToPython(shrinking);
                    if (cache_size != 200)
                        pyDict["cache_size"] = ToPython(cache_size);
                    if (verbose != false)
                        pyDict["verbose"] = ToPython(verbose);
                    if (max_iter != -1)
                        pyDict["max_iter"] = ToPython(max_iter);
                    self = sklearn.svm.self.InvokeMethod("SVR", args, pyDict);
                }

                internal SVR(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SVR Encapsule(PyObject pyObject)
                {
                    return new SVR(pyObject);
                }

                public NDarray coef_ => ToCsharp<NDarray>(self.GetAttr("coef_"));
                public NDarray dual_coef_ => ToCsharp<NDarray>(self.GetAttr("dual_coef_"));
                public int fit_status_ => ToCsharp<int>(self.GetAttr("fit_status_"));
                public NDarray intercept_ => ToCsharp<NDarray>(self.GetAttr("intercept_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public NDarray n_support_ => ToCsharp<NDarray>(self.GetAttr("n_support_"));
                public NDarray shape_fit_ => ToCsharp<NDarray>(self.GetAttr("shape_fit_"));
                public NDarray support_ => ToCsharp<NDarray>(self.GetAttr("support_"));
                public NDarray support_vectors_ => ToCsharp<NDarray>(self.GetAttr("support_vectors_"));

                public SVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public SVR set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public SVR set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public SVR set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public static float l1_min_c(NDarray X, NDarray y, string loss = "squared_hinge", bool fit_intercept = true, float intercept_scaling = 1.0f)
            {
                PyTuple args = ToTuple(new object[] { X, y });
                PyDict pyDict = new PyDict();
                if (loss != "squared_hinge")
                    pyDict["loss"] = ToPython(loss);
                if (fit_intercept != true)
                    pyDict["fit_intercept"] = ToPython(fit_intercept);
                if (intercept_scaling != 1.0f)
                    pyDict["intercept_scaling"] = ToPython(intercept_scaling);
                return ToCsharp<float>(sklearn.svm.self.InvokeMethod("l1_min_c", args, pyDict));
            }
        }
    }
}