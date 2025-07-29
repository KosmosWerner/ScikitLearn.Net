namespace ScikitLearn;
#nullable enable
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

        static svm() => ReInitializeLazySelf();
        public static float l1_min_c(NDarray X, NDarray y, string loss = "squared_hinge", bool fit_intercept = true, float intercept_scaling = 1.0f)
        {
            _ = sklearn.svm.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
            PyDict pyDict = new PyDict();
            if (loss != "squared_hinge")
                pyDict["loss"] = Helpers.ToPython(loss);
            if (fit_intercept != true)
                pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
            if (intercept_scaling != 1.0f)
                pyDict["intercept_scaling"] = Helpers.ToPython(intercept_scaling);
            var __pyObject = self.InvokeMethod("l1_min_c", args, pyDict);
            return __pyObject.As<float>();
        }

        public class LinearSVC : PythonObject
        {
            public LinearSVC(string penalty = "l2", string loss = "squared_hinge", string dual = "auto", float tol = 0.0001f, float C = 1.0f, string multi_class = "ovr", bool fit_intercept = true, int intercept_scaling = 1, PyDict? class_weight = null, int verbose = 0, int? random_state = null, int max_iter = 1000)
            {
                _ = sklearn.svm.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (penalty != "l2")
                    pyDict["penalty"] = Helpers.ToPython(penalty);
                if (loss != "squared_hinge")
                    pyDict["loss"] = Helpers.ToPython(loss);
                if (dual != "auto")
                    pyDict["dual"] = Helpers.ToPython(dual);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (C != 1.0f)
                    pyDict["C"] = Helpers.ToPython(C);
                if (multi_class != "ovr")
                    pyDict["multi_class"] = Helpers.ToPython(multi_class);
                if (fit_intercept != true)
                    pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                if (intercept_scaling != 1)
                    pyDict["intercept_scaling"] = Helpers.ToPython(intercept_scaling);
                if (class_weight != null)
                    pyDict["class_weight"] = Helpers.ToPython(class_weight);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (max_iter != 1000)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                self = sklearn.svm.self.InvokeMethod("LinearSVC", args, pyDict);
            }

            internal LinearSVC(PyObject pyObject)
            {
                _ = sklearn.svm.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LinearSVC Encapsule(PyObject pyObject) => new LinearSVC(pyObject);
            public static LinearSVC Wrap(PyObject pyObject) => new LinearSVC(pyObject);
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public LinearSVC densify()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("densify", args, pyDict);
                return this;
            }

            public LinearSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public LinearSVC set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public LinearSVC set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public LinearSVC set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }

            public LinearSVC sparsify()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("sparsify", args, pyDict);
                return this;
            }
        }

        public class LinearSVR : PythonObject
        {
            public LinearSVR(float epsilon = 0.0f, float tol = 0.0001f, float C = 1.0f, string loss = "epsilon_insensitive", bool fit_intercept = true, float intercept_scaling = 1.0f, string dual = "auto", int verbose = 0, int? random_state = null, int max_iter = 1000)
            {
                _ = sklearn.svm.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (epsilon != 0.0f)
                    pyDict["epsilon"] = Helpers.ToPython(epsilon);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (C != 1.0f)
                    pyDict["C"] = Helpers.ToPython(C);
                if (loss != "epsilon_insensitive")
                    pyDict["loss"] = Helpers.ToPython(loss);
                if (fit_intercept != true)
                    pyDict["fit_intercept"] = Helpers.ToPython(fit_intercept);
                if (intercept_scaling != 1.0f)
                    pyDict["intercept_scaling"] = Helpers.ToPython(intercept_scaling);
                if (dual != "auto")
                    pyDict["dual"] = Helpers.ToPython(dual);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (max_iter != 1000)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                self = sklearn.svm.self.InvokeMethod("LinearSVR", args, pyDict);
            }

            internal LinearSVR(PyObject pyObject)
            {
                _ = sklearn.svm.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LinearSVR Encapsule(PyObject pyObject) => new LinearSVR(pyObject);
            public static LinearSVR Wrap(PyObject pyObject) => new LinearSVR(pyObject);
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public LinearSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public LinearSVR set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public LinearSVR set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public LinearSVR set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class NuSVC : PythonObject
        {
            public NuSVC(float nu = 0.5f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, bool probability = false, float tol = 0.001f, int cache_size = 200, PyDict? class_weight = null, bool verbose = false, int max_iter = -1, string decision_function_shape = "ovr", bool break_ties = false, int? random_state = null)
            {
                _ = sklearn.svm.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (nu != 0.5f)
                    pyDict["nu"] = Helpers.ToPython(nu);
                if (kernel != "rbf")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (degree != 3)
                    pyDict["degree"] = Helpers.ToPython(degree);
                if (gamma != "scale")
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (coef0 != 0.0f)
                    pyDict["coef0"] = Helpers.ToPython(coef0);
                if (shrinking != true)
                    pyDict["shrinking"] = Helpers.ToPython(shrinking);
                if (probability != false)
                    pyDict["probability"] = Helpers.ToPython(probability);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (cache_size != 200)
                    pyDict["cache_size"] = Helpers.ToPython(cache_size);
                if (class_weight != null)
                    pyDict["class_weight"] = Helpers.ToPython(class_weight);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (max_iter != -1)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (decision_function_shape != "ovr")
                    pyDict["decision_function_shape"] = Helpers.ToPython(decision_function_shape);
                if (break_ties != false)
                    pyDict["break_ties"] = Helpers.ToPython(break_ties);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.svm.self.InvokeMethod("NuSVC", args, pyDict);
            }

            internal NuSVC(PyObject pyObject)
            {
                _ = sklearn.svm.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static NuSVC Encapsule(PyObject pyObject) => new NuSVC(pyObject);
            public static NuSVC Wrap(PyObject pyObject) => new NuSVC(pyObject);
            public NDarray class_weight_
            {
                get
                {
                    var __pyObject = self.GetAttr("class_weight_");
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

            public NDarray coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("coef_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray dual_coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("dual_coef_");
                    return new NDarray(__pyObject);
                }
            }

            public int fit_status_
            {
                get
                {
                    var __pyObject = self.GetAttr("fit_status_");
                    return __pyObject.As<int>();
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

            public NDarray n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_vectors_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_vectors_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray n_support_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray probA_
            {
                get
                {
                    var __pyObject = self.GetAttr("probA_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray probB_
            {
                get
                {
                    var __pyObject = self.GetAttr("probB_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray shape_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("shape_fit_");
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

            public NuSVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public NuSVC set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public NuSVC set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NuSVC set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class NuSVR : PythonObject
        {
            public NuSVR(float nu = 0.5f, float C = 1.0f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, float tol = 0.001f, int cache_size = 200, bool verbose = false, int max_iter = -1)
            {
                _ = sklearn.svm.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (nu != 0.5f)
                    pyDict["nu"] = Helpers.ToPython(nu);
                if (C != 1.0f)
                    pyDict["C"] = Helpers.ToPython(C);
                if (kernel != "rbf")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (degree != 3)
                    pyDict["degree"] = Helpers.ToPython(degree);
                if (gamma != "scale")
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (coef0 != 0.0f)
                    pyDict["coef0"] = Helpers.ToPython(coef0);
                if (shrinking != true)
                    pyDict["shrinking"] = Helpers.ToPython(shrinking);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (cache_size != 200)
                    pyDict["cache_size"] = Helpers.ToPython(cache_size);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (max_iter != -1)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                self = sklearn.svm.self.InvokeMethod("NuSVR", args, pyDict);
            }

            internal NuSVR(PyObject pyObject)
            {
                _ = sklearn.svm.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static NuSVR Encapsule(PyObject pyObject) => new NuSVR(pyObject);
            public static NuSVR Wrap(PyObject pyObject) => new NuSVR(pyObject);
            public NDarray coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("coef_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray dual_coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("dual_coef_");
                    return new NDarray(__pyObject);
                }
            }

            public int fit_status_
            {
                get
                {
                    var __pyObject = self.GetAttr("fit_status_");
                    return __pyObject.As<int>();
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray n_support_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray shape_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("shape_fit_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_vectors_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_vectors_");
                    return new NDarray(__pyObject);
                }
            }

            public NuSVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public NuSVR set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public NuSVR set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NuSVR set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class OneClassSVM : PythonObject
        {
            public OneClassSVM(string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, float tol = 0.001f, float nu = 0.5f, bool shrinking = true, int cache_size = 200, bool verbose = false, int max_iter = -1)
            {
                _ = sklearn.svm.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (kernel != "rbf")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (degree != 3)
                    pyDict["degree"] = Helpers.ToPython(degree);
                if (gamma != "scale")
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (coef0 != 0.0f)
                    pyDict["coef0"] = Helpers.ToPython(coef0);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (nu != 0.5f)
                    pyDict["nu"] = Helpers.ToPython(nu);
                if (shrinking != true)
                    pyDict["shrinking"] = Helpers.ToPython(shrinking);
                if (cache_size != 200)
                    pyDict["cache_size"] = Helpers.ToPython(cache_size);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (max_iter != -1)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                self = sklearn.svm.self.InvokeMethod("OneClassSVM", args, pyDict);
            }

            internal OneClassSVM(PyObject pyObject)
            {
                _ = sklearn.svm.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static OneClassSVM Encapsule(PyObject pyObject) => new OneClassSVM(pyObject);
            public static OneClassSVM Wrap(PyObject pyObject) => new OneClassSVM(pyObject);
            public NDarray coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("coef_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray dual_coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("dual_coef_");
                    return new NDarray(__pyObject);
                }
            }

            public int fit_status_
            {
                get
                {
                    var __pyObject = self.GetAttr("fit_status_");
                    return __pyObject.As<int>();
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray n_support_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_support_");
                    return new NDarray(__pyObject);
                }
            }

            public float offset_
            {
                get
                {
                    var __pyObject = self.GetAttr("offset_");
                    return __pyObject.As<float>();
                }
            }

            public NDarray shape_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("shape_fit_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_vectors_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_vectors_");
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

            public OneClassSVM fit(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("fit_predict", args, pyDict);
                return new NDarray(__pyObject);
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

            public NDarray score_samples(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score_samples", args, pyDict);
                return new NDarray(__pyObject);
            }

            public OneClassSVM set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public OneClassSVM set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class SVC : PythonObject
        {
            public SVC(float C = 1.0f, string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, bool shrinking = true, bool probability = false, float tol = 0.001f, int cache_size = 200, PyDict? class_weight = null, bool verbose = false, int max_iter = -1, string decision_function_shape = "ovr", bool break_ties = false, int? random_state = null)
            {
                _ = sklearn.svm.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (C != 1.0f)
                    pyDict["C"] = Helpers.ToPython(C);
                if (kernel != "rbf")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (degree != 3)
                    pyDict["degree"] = Helpers.ToPython(degree);
                if (gamma != "scale")
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (coef0 != 0.0f)
                    pyDict["coef0"] = Helpers.ToPython(coef0);
                if (shrinking != true)
                    pyDict["shrinking"] = Helpers.ToPython(shrinking);
                if (probability != false)
                    pyDict["probability"] = Helpers.ToPython(probability);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (cache_size != 200)
                    pyDict["cache_size"] = Helpers.ToPython(cache_size);
                if (class_weight != null)
                    pyDict["class_weight"] = Helpers.ToPython(class_weight);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (max_iter != -1)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (decision_function_shape != "ovr")
                    pyDict["decision_function_shape"] = Helpers.ToPython(decision_function_shape);
                if (break_ties != false)
                    pyDict["break_ties"] = Helpers.ToPython(break_ties);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.svm.self.InvokeMethod("SVC", args, pyDict);
            }

            internal SVC(PyObject pyObject)
            {
                _ = sklearn.svm.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static SVC Encapsule(PyObject pyObject) => new SVC(pyObject);
            public static SVC Wrap(PyObject pyObject) => new SVC(pyObject);
            public NDarray class_weight_
            {
                get
                {
                    var __pyObject = self.GetAttr("class_weight_");
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

            public NDarray coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("coef_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray dual_coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("dual_coef_");
                    return new NDarray(__pyObject);
                }
            }

            public int fit_status_
            {
                get
                {
                    var __pyObject = self.GetAttr("fit_status_");
                    return __pyObject.As<int>();
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

            public NDarray n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_vectors_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_vectors_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray n_support_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray probA_
            {
                get
                {
                    var __pyObject = self.GetAttr("probA_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray probB_
            {
                get
                {
                    var __pyObject = self.GetAttr("probB_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray shape_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("shape_fit_");
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

            public SVC fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public SVC set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public SVC set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public SVC set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class SVR : PythonObject
        {
            public SVR(string kernel = "rbf", int degree = 3, string gamma = "scale", float coef0 = 0.0f, float tol = 0.001f, float C = 1.0f, float epsilon = 0.1f, bool shrinking = true, int cache_size = 200, bool verbose = false, int max_iter = -1)
            {
                _ = sklearn.svm.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (kernel != "rbf")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (degree != 3)
                    pyDict["degree"] = Helpers.ToPython(degree);
                if (gamma != "scale")
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (coef0 != 0.0f)
                    pyDict["coef0"] = Helpers.ToPython(coef0);
                if (tol != 0.001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (C != 1.0f)
                    pyDict["C"] = Helpers.ToPython(C);
                if (epsilon != 0.1f)
                    pyDict["epsilon"] = Helpers.ToPython(epsilon);
                if (shrinking != true)
                    pyDict["shrinking"] = Helpers.ToPython(shrinking);
                if (cache_size != 200)
                    pyDict["cache_size"] = Helpers.ToPython(cache_size);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (max_iter != -1)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                self = sklearn.svm.self.InvokeMethod("SVR", args, pyDict);
            }

            internal SVR(PyObject pyObject)
            {
                _ = sklearn.svm.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static SVR Encapsule(PyObject pyObject) => new SVR(pyObject);
            public static SVR Wrap(PyObject pyObject) => new SVR(pyObject);
            public NDarray coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("coef_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray dual_coef_
            {
                get
                {
                    var __pyObject = self.GetAttr("dual_coef_");
                    return new NDarray(__pyObject);
                }
            }

            public int fit_status_
            {
                get
                {
                    var __pyObject = self.GetAttr("fit_status_");
                    return __pyObject.As<int>();
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray n_support_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray shape_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("shape_fit_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray support_vectors_
            {
                get
                {
                    var __pyObject = self.GetAttr("support_vectors_");
                    return new NDarray(__pyObject);
                }
            }

            public SVR fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public SVR set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public SVR set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public SVR set_score_request(string? sample_weight = "$UNCHANGED$")
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