namespace ScikitLearn;
public static partial class sklearn
{
    public static class covariance
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
            return Py.Import("sklearn.covariance");
        }

        static covariance()
        {
            ReInitializeLazySelf();
        }

        public static NDarray empirical_covariance(NDarray X, bool assume_centered = false)
        {
            _ = sklearn.covariance.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (assume_centered != false)
                pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
            throw new NotImplementedException();
        }

        public static (NDarray? , NDarray? , PyObject? , int? ) graphical_lasso(NDarray emp_cov, float alpha, string mode = "cd", float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, bool verbose = false, bool return_costs = false, float eps = float.Epsilon, bool return_n_iter = false)
        {
            _ = sklearn.covariance.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(emp_cov), Helpers.ToPython(alpha) });
            PyDict pyDict = new PyDict();
            if (mode != "cd")
                pyDict["mode"] = Helpers.ToPython(mode);
            if (tol != 0.0001f)
                pyDict["tol"] = Helpers.ToPython(tol);
            if (enet_tol != 0.0001f)
                pyDict["enet_tol"] = Helpers.ToPython(enet_tol);
            if (max_iter != 100)
                pyDict["max_iter"] = Helpers.ToPython(max_iter);
            if (verbose != false)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (return_costs != false)
                pyDict["return_costs"] = Helpers.ToPython(return_costs);
            if (eps != float.Epsilon)
                pyDict["eps"] = Helpers.ToPython(eps);
            if (return_n_iter != false)
                pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
            throw new NotImplementedException();
        }

        public static (NDarray? , float? ) ledoit_wolf(NDarray X, bool assume_centered = false, int block_size = 1000)
        {
            _ = sklearn.covariance.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (assume_centered != false)
                pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
            if (block_size != 1000)
                pyDict["block_size"] = Helpers.ToPython(block_size);
            throw new NotImplementedException();
        }

        public static float ledoit_wolf_shrinkage(NDarray X, bool assume_centered = false, int block_size = 1000)
        {
            _ = sklearn.covariance.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (assume_centered != false)
                pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
            if (block_size != 1000)
                pyDict["block_size"] = Helpers.ToPython(block_size);
            return self.InvokeMethod("ledoit_wolf_shrinkage", args, pyDict).As<float>();
        }

        public static (NDarray? , float? ) oas(NDarray X, bool assume_centered = false)
        {
            _ = sklearn.covariance.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (assume_centered != false)
                pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
            throw new NotImplementedException();
        }

        public static NDarray shrunk_covariance(NDarray emp_cov, float shrinkage = 0.1f)
        {
            _ = sklearn.covariance.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(emp_cov) });
            PyDict pyDict = new PyDict();
            if (shrinkage != 0.1f)
                pyDict["shrinkage"] = Helpers.ToPython(shrinkage);
            throw new NotImplementedException();
        }

        public class EllipticEnvelope : PythonObject
        {
            public EllipticEnvelope(bool store_precision = true, bool assume_centered = false, float? support_fraction = null, float contamination = 0.1f, int? random_state = null)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (store_precision != true)
                    pyDict["store_precision"] = Helpers.ToPython(store_precision);
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                if (support_fraction != null)
                    pyDict["support_fraction"] = Helpers.ToPython(support_fraction);
                if (contamination != 0.1f)
                    pyDict["contamination"] = Helpers.ToPython(contamination);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.covariance.self.InvokeMethod("EllipticEnvelope", args, pyDict);
            }

            internal EllipticEnvelope(PyObject pyObject)
            {
                _ = sklearn.covariance.self;
                self = pyObject;
            }

            public static EllipticEnvelope Encapsule(PyObject pyObject) => new EllipticEnvelope(pyObject);
            public NDarray location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray precision_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray support_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float offset_
            {
                get
                {
                    return self.GetAttr("offset_").As<float>();
                }
            }

            public NDarray raw_location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray raw_covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray raw_support_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray dist_
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

            public NDarray correct_covariance(NDarray data)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(data) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(comp_cov) });
                PyDict pyDict = new PyDict();
                if (norm != "frobenius")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (scaling != true)
                    pyDict["scaling"] = Helpers.ToPython(scaling);
                if (squared != true)
                    pyDict["squared"] = Helpers.ToPython(squared);
                return self.InvokeMethod("error_norm", args, pyDict).As<float>();
            }

            public EllipticEnvelope fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public NDarray get_precision()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray mahalanobis(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public (NDarray? , NDarray? , NDarray? ) reweight_covariance(NDarray data)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(data) });
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

            public NDarray score_samples(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public EllipticEnvelope set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public EllipticEnvelope set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                throw new NotImplementedException();
            }
        }

        public class EmpiricalCovariance : PythonObject
        {
            public EmpiricalCovariance(bool store_precision = true, bool assume_centered = false)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (store_precision != true)
                    pyDict["store_precision"] = Helpers.ToPython(store_precision);
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                self = sklearn.covariance.self.InvokeMethod("EmpiricalCovariance", args, pyDict);
            }

            internal EmpiricalCovariance(PyObject pyObject)
            {
                _ = sklearn.covariance.self;
                self = pyObject;
            }

            public static EmpiricalCovariance Encapsule(PyObject pyObject) => new EmpiricalCovariance(pyObject);
            public NDarray location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray precision_
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

            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(comp_cov) });
                PyDict pyDict = new PyDict();
                if (norm != "frobenius")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (scaling != true)
                    pyDict["scaling"] = Helpers.ToPython(scaling);
                if (squared != true)
                    pyDict["squared"] = Helpers.ToPython(squared);
                return self.InvokeMethod("error_norm", args, pyDict).As<float>();
            }

            public EmpiricalCovariance fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public NDarray get_precision()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray mahalanobis(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X_test)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X_test) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public EmpiricalCovariance set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public EmpiricalCovariance set_score_request(string? X_test = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X_test != "$UNCHANGED$")
                    pyDict["X_test"] = Helpers.ToPython(X_test);
                throw new NotImplementedException();
            }
        }

        public class GraphicalLasso : PythonObject
        {
            public GraphicalLasso(float alpha = 0.01f, string mode = "cd", PyObject? covariance = null, float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, bool verbose = false, float eps = float.Epsilon, bool assume_centered = false)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (alpha != 0.01f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (mode != "cd")
                    pyDict["mode"] = Helpers.ToPython(mode);
                if (covariance != null)
                    pyDict["covariance"] = Helpers.ToPython(covariance);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (enet_tol != 0.0001f)
                    pyDict["enet_tol"] = Helpers.ToPython(enet_tol);
                if (max_iter != 100)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (eps != float.Epsilon)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                self = sklearn.covariance.self.InvokeMethod("GraphicalLasso", args, pyDict);
            }

            internal GraphicalLasso(PyObject pyObject)
            {
                _ = sklearn.covariance.self;
                self = pyObject;
            }

            public static GraphicalLasso Encapsule(PyObject pyObject) => new GraphicalLasso(pyObject);
            public NDarray location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray precision_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_iter_
            {
                get
                {
                    return self.GetAttr("n_iter_").As<int>();
                }
            }

            public PyObject costs_
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

            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(comp_cov) });
                PyDict pyDict = new PyDict();
                if (norm != "frobenius")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (scaling != true)
                    pyDict["scaling"] = Helpers.ToPython(scaling);
                if (squared != true)
                    pyDict["squared"] = Helpers.ToPython(squared);
                return self.InvokeMethod("error_norm", args, pyDict).As<float>();
            }

            public GraphicalLasso fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public NDarray get_precision()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray mahalanobis(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X_test)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X_test) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public GraphicalLasso set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public GraphicalLasso set_score_request(string? X_test = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X_test != "$UNCHANGED$")
                    pyDict["X_test"] = Helpers.ToPython(X_test);
                throw new NotImplementedException();
            }
        }

        public class GraphicalLassoCV : PythonObject
        {
            public GraphicalLassoCV(int alphas = 4, int n_refinements = 4, int? cv = null, float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, string mode = "cd", int? n_jobs = null, bool verbose = false, float eps = float.Epsilon, bool assume_centered = false)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (alphas != 4)
                    pyDict["alphas"] = Helpers.ToPython(alphas);
                if (n_refinements != 4)
                    pyDict["n_refinements"] = Helpers.ToPython(n_refinements);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (enet_tol != 0.0001f)
                    pyDict["enet_tol"] = Helpers.ToPython(enet_tol);
                if (max_iter != 100)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (mode != "cd")
                    pyDict["mode"] = Helpers.ToPython(mode);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (eps != float.Epsilon)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                self = sklearn.covariance.self.InvokeMethod("GraphicalLassoCV", args, pyDict);
            }

            internal GraphicalLassoCV(PyObject pyObject)
            {
                _ = sklearn.covariance.self;
                self = pyObject;
            }

            public static GraphicalLassoCV Encapsule(PyObject pyObject) => new GraphicalLassoCV(pyObject);
            public NDarray location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray precision_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public PyObject costs_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float alpha_
            {
                get
                {
                    return self.GetAttr("alpha_").As<float>();
                }
            }

            public PyDict cv_results_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public int n_iter_
            {
                get
                {
                    return self.GetAttr("n_iter_").As<int>();
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

            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(comp_cov) });
                PyDict pyDict = new PyDict();
                if (norm != "frobenius")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (scaling != true)
                    pyDict["scaling"] = Helpers.ToPython(scaling);
                if (squared != true)
                    pyDict["squared"] = Helpers.ToPython(squared);
                return self.InvokeMethod("error_norm", args, pyDict).As<float>();
            }

            public GraphicalLassoCV fit(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public NDarray get_precision()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray mahalanobis(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X_test)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X_test) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public GraphicalLassoCV set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public GraphicalLassoCV set_score_request(string? X_test = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X_test != "$UNCHANGED$")
                    pyDict["X_test"] = Helpers.ToPython(X_test);
                throw new NotImplementedException();
            }
        }

        public class LedoitWolf : PythonObject
        {
            public LedoitWolf(bool store_precision = true, bool assume_centered = false, int block_size = 1000)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (store_precision != true)
                    pyDict["store_precision"] = Helpers.ToPython(store_precision);
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                if (block_size != 1000)
                    pyDict["block_size"] = Helpers.ToPython(block_size);
                self = sklearn.covariance.self.InvokeMethod("LedoitWolf", args, pyDict);
            }

            internal LedoitWolf(PyObject pyObject)
            {
                _ = sklearn.covariance.self;
                self = pyObject;
            }

            public static LedoitWolf Encapsule(PyObject pyObject) => new LedoitWolf(pyObject);
            public NDarray covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray precision_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float shrinkage_
            {
                get
                {
                    return self.GetAttr("shrinkage_").As<float>();
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

            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(comp_cov) });
                PyDict pyDict = new PyDict();
                if (norm != "frobenius")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (scaling != true)
                    pyDict["scaling"] = Helpers.ToPython(scaling);
                if (squared != true)
                    pyDict["squared"] = Helpers.ToPython(squared);
                return self.InvokeMethod("error_norm", args, pyDict).As<float>();
            }

            public LedoitWolf fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public NDarray get_precision()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray mahalanobis(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X_test)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X_test) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public LedoitWolf set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public LedoitWolf set_score_request(string? X_test = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X_test != "$UNCHANGED$")
                    pyDict["X_test"] = Helpers.ToPython(X_test);
                throw new NotImplementedException();
            }
        }

        public class MinCovDet : PythonObject
        {
            public MinCovDet(bool store_precision = true, bool assume_centered = false, float? support_fraction = null, int? random_state = null)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (store_precision != true)
                    pyDict["store_precision"] = Helpers.ToPython(store_precision);
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                if (support_fraction != null)
                    pyDict["support_fraction"] = Helpers.ToPython(support_fraction);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.covariance.self.InvokeMethod("MinCovDet", args, pyDict);
            }

            internal MinCovDet(PyObject pyObject)
            {
                _ = sklearn.covariance.self;
                self = pyObject;
            }

            public static MinCovDet Encapsule(PyObject pyObject) => new MinCovDet(pyObject);
            public NDarray raw_location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray raw_covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray raw_support_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray precision_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray support_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray dist_
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

            public NDarray correct_covariance(NDarray data)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(data) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(comp_cov) });
                PyDict pyDict = new PyDict();
                if (norm != "frobenius")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (scaling != true)
                    pyDict["scaling"] = Helpers.ToPython(scaling);
                if (squared != true)
                    pyDict["squared"] = Helpers.ToPython(squared);
                return self.InvokeMethod("error_norm", args, pyDict).As<float>();
            }

            public MinCovDet fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public NDarray get_precision()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray mahalanobis(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public (NDarray? , NDarray? , NDarray? ) reweight_covariance(NDarray data)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(data) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X_test)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X_test) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public MinCovDet set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public MinCovDet set_score_request(string? X_test = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X_test != "$UNCHANGED$")
                    pyDict["X_test"] = Helpers.ToPython(X_test);
                throw new NotImplementedException();
            }
        }

        public class OAS : PythonObject
        {
            public OAS(bool store_precision = true, bool assume_centered = false)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (store_precision != true)
                    pyDict["store_precision"] = Helpers.ToPython(store_precision);
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                self = sklearn.covariance.self.InvokeMethod("OAS", args, pyDict);
            }

            internal OAS(PyObject pyObject)
            {
                _ = sklearn.covariance.self;
                self = pyObject;
            }

            public static OAS Encapsule(PyObject pyObject) => new OAS(pyObject);
            public NDarray covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray precision_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public float shrinkage_
            {
                get
                {
                    return self.GetAttr("shrinkage_").As<float>();
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

            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(comp_cov) });
                PyDict pyDict = new PyDict();
                if (norm != "frobenius")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (scaling != true)
                    pyDict["scaling"] = Helpers.ToPython(scaling);
                if (squared != true)
                    pyDict["squared"] = Helpers.ToPython(squared);
                return self.InvokeMethod("error_norm", args, pyDict).As<float>();
            }

            public OAS fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public NDarray get_precision()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray mahalanobis(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X_test)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X_test) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public OAS set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public OAS set_score_request(string? X_test = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X_test != "$UNCHANGED$")
                    pyDict["X_test"] = Helpers.ToPython(X_test);
                throw new NotImplementedException();
            }
        }

        public class ShrunkCovariance : PythonObject
        {
            public ShrunkCovariance(bool store_precision = true, bool assume_centered = false, float shrinkage = 0.1f)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (store_precision != true)
                    pyDict["store_precision"] = Helpers.ToPython(store_precision);
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                if (shrinkage != 0.1f)
                    pyDict["shrinkage"] = Helpers.ToPython(shrinkage);
                self = sklearn.covariance.self.InvokeMethod("ShrunkCovariance", args, pyDict);
            }

            internal ShrunkCovariance(PyObject pyObject)
            {
                _ = sklearn.covariance.self;
                self = pyObject;
            }

            public static ShrunkCovariance Encapsule(PyObject pyObject) => new ShrunkCovariance(pyObject);
            public NDarray covariance_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray location_
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public NDarray precision_
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

            public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(comp_cov) });
                PyDict pyDict = new PyDict();
                if (norm != "frobenius")
                    pyDict["norm"] = Helpers.ToPython(norm);
                if (scaling != true)
                    pyDict["scaling"] = Helpers.ToPython(scaling);
                if (squared != true)
                    pyDict["squared"] = Helpers.ToPython(squared);
                return self.InvokeMethod("error_norm", args, pyDict).As<float>();
            }

            public ShrunkCovariance fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public NDarray get_precision()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public NDarray mahalanobis(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                throw new NotImplementedException();
            }

            public float score(NDarray X_test)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X_test) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("score", args, pyDict).As<float>();
            }

            public ShrunkCovariance set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                throw new NotImplementedException();
            }

            public ShrunkCovariance set_score_request(string? X_test = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X_test != "$UNCHANGED$")
                    pyDict["X_test"] = Helpers.ToPython(X_test);
                throw new NotImplementedException();
            }
        }
    }
}