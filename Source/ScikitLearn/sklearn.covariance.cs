using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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

            public class EllipticEnvelope : PythonObject
            {
                public EllipticEnvelope(bool store_precision = true, bool assume_centered = false, float? support_fraction = null, float contamination = 0.1f, int? random_state = null)
                {
                    _ = sklearn.covariance.self;
                    PyTuple args = new PyTuple();
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

                public static EllipticEnvelope Encapsule(PyObject pyObject)
                {
                    return new EllipticEnvelope(pyObject);
                }

                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public float offset_ => Helpers.ToCSharpFloat(self.GetAttr("offset_"));
                public NDarray raw_location_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_location_"));
                public NDarray raw_covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_covariance_"));
                public NDarray raw_support_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_support_"));
                public NDarray dist_ => Helpers.ToCSharpNDarray(self.GetAttr("dist_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray correct_covariance(NDarray data)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(data)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("correct_covariance", args, pyDict));
                }

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("decision_function", args, pyDict));
                }

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(comp_cov)]);
                    PyDict pyDict = new PyDict();
                    if (norm != "frobenius")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (scaling != true)
                        pyDict["scaling"] = Helpers.ToPython(scaling);
                    if (squared != true)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("error_norm", args, pyDict));
                }

                public EllipticEnvelope fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_predict", args, pyDict));
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray mahalanobis(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("mahalanobis", args, pyDict));
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("predict", args, pyDict));
                }

                public (NDarray?, NDarray?, NDarray?) reweight_covariance(NDarray data)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(data)]);
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("reweight_covariance", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null);
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("score_samples", args, pyDict));
                }

                public EllipticEnvelope set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public EllipticEnvelope set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class EmpiricalCovariance : PythonObject
            {
                public EmpiricalCovariance(bool store_precision = true, bool assume_centered = false)
                {
                    _ = sklearn.covariance.self;
                    PyTuple args = new PyTuple();
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

                public static EmpiricalCovariance Encapsule(PyObject pyObject)
                {
                    return new EmpiricalCovariance(pyObject);
                }

                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(comp_cov)]);
                    PyDict pyDict = new PyDict();
                    if (norm != "frobenius")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (scaling != true)
                        pyDict["scaling"] = Helpers.ToPython(scaling);
                    if (squared != true)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("error_norm", args, pyDict));
                }

                public EmpiricalCovariance fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray mahalanobis(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("mahalanobis", args, pyDict));
                }

                public float score(NDarray X_test)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X_test)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public EmpiricalCovariance set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public EmpiricalCovariance set_score_request(string? X_test = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X_test != "$UNCHANGED$")
                        pyDict["X_test"] = Helpers.ToPython(X_test);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class GraphicalLasso : PythonObject
            {
                public GraphicalLasso(float alpha = 0.01f, string mode = "cd", PyObject? covariance = null, float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, bool verbose = false, float eps = float.Epsilon, bool assume_centered = false)
                {
                    _ = sklearn.covariance.self;
                    PyTuple args = new PyTuple();
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

                public static GraphicalLasso Encapsule(PyObject pyObject)
                {
                    return new GraphicalLasso(pyObject);
                }

                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public PyObject costs_ => self.GetAttr("costs_");
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(comp_cov)]);
                    PyDict pyDict = new PyDict();
                    if (norm != "frobenius")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (scaling != true)
                        pyDict["scaling"] = Helpers.ToPython(scaling);
                    if (squared != true)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("error_norm", args, pyDict));
                }

                public GraphicalLasso fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray mahalanobis(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("mahalanobis", args, pyDict));
                }

                public float score(NDarray X_test)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X_test)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public GraphicalLasso set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public GraphicalLasso set_score_request(string? X_test = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X_test != "$UNCHANGED$")
                        pyDict["X_test"] = Helpers.ToPython(X_test);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class GraphicalLassoCV : PythonObject
            {
                public GraphicalLassoCV(int alphas = 4, int n_refinements = 4, int? cv = null, float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, string mode = "cd", int? n_jobs = null, bool verbose = false, float eps = float.Epsilon, bool assume_centered = false)
                {
                    _ = sklearn.covariance.self;
                    PyTuple args = new PyTuple();
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

                public static GraphicalLassoCV Encapsule(PyObject pyObject)
                {
                    return new GraphicalLassoCV(pyObject);
                }

                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public PyObject costs_ => self.GetAttr("costs_");
                public float alpha_ => Helpers.ToCSharpFloat(self.GetAttr("alpha_"));
                public PyDict cv_results_ => new PyDict(self.GetAttr("cv_results_"));
                public int n_iter_ => Helpers.ToCSharpInt(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(comp_cov)]);
                    PyDict pyDict = new PyDict();
                    if (norm != "frobenius")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (scaling != true)
                        pyDict["scaling"] = Helpers.ToPython(scaling);
                    if (squared != true)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("error_norm", args, pyDict));
                }

                public GraphicalLassoCV fit(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray mahalanobis(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("mahalanobis", args, pyDict));
                }

                public float score(NDarray X_test)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X_test)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public GraphicalLassoCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public GraphicalLassoCV set_score_request(string? X_test = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X_test != "$UNCHANGED$")
                        pyDict["X_test"] = Helpers.ToPython(X_test);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class LedoitWolf : PythonObject
            {
                public LedoitWolf(bool store_precision = true, bool assume_centered = false, int block_size = 1000)
                {
                    _ = sklearn.covariance.self;
                    PyTuple args = new PyTuple();
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

                public static LedoitWolf Encapsule(PyObject pyObject)
                {
                    return new LedoitWolf(pyObject);
                }

                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public float shrinkage_ => Helpers.ToCSharpFloat(self.GetAttr("shrinkage_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(comp_cov)]);
                    PyDict pyDict = new PyDict();
                    if (norm != "frobenius")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (scaling != true)
                        pyDict["scaling"] = Helpers.ToPython(scaling);
                    if (squared != true)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("error_norm", args, pyDict));
                }

                public LedoitWolf fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray mahalanobis(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("mahalanobis", args, pyDict));
                }

                public float score(NDarray X_test)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X_test)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public LedoitWolf set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public LedoitWolf set_score_request(string? X_test = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X_test != "$UNCHANGED$")
                        pyDict["X_test"] = Helpers.ToPython(X_test);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class MinCovDet : PythonObject
            {
                public MinCovDet(bool store_precision = true, bool assume_centered = false, float? support_fraction = null, int? random_state = null)
                {
                    _ = sklearn.covariance.self;
                    PyTuple args = new PyTuple();
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

                public static MinCovDet Encapsule(PyObject pyObject)
                {
                    return new MinCovDet(pyObject);
                }

                public NDarray raw_location_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_location_"));
                public NDarray raw_covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_covariance_"));
                public NDarray raw_support_ => Helpers.ToCSharpNDarray(self.GetAttr("raw_support_"));
                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public NDarray support_ => Helpers.ToCSharpNDarray(self.GetAttr("support_"));
                public NDarray dist_ => Helpers.ToCSharpNDarray(self.GetAttr("dist_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray correct_covariance(NDarray data)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(data)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("correct_covariance", args, pyDict));
                }

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(comp_cov)]);
                    PyDict pyDict = new PyDict();
                    if (norm != "frobenius")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (scaling != true)
                        pyDict["scaling"] = Helpers.ToPython(scaling);
                    if (squared != true)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("error_norm", args, pyDict));
                }

                public MinCovDet fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray mahalanobis(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("mahalanobis", args, pyDict));
                }

                public (NDarray?, NDarray?, NDarray?) reweight_covariance(NDarray data)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(data)]);
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("reweight_covariance", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null);
                }

                public float score(NDarray X_test)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X_test)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public MinCovDet set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public MinCovDet set_score_request(string? X_test = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X_test != "$UNCHANGED$")
                        pyDict["X_test"] = Helpers.ToPython(X_test);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class OAS : PythonObject
            {
                public OAS(bool store_precision = true, bool assume_centered = false)
                {
                    _ = sklearn.covariance.self;
                    PyTuple args = new PyTuple();
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

                public static OAS Encapsule(PyObject pyObject)
                {
                    return new OAS(pyObject);
                }

                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public float shrinkage_ => Helpers.ToCSharpFloat(self.GetAttr("shrinkage_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(comp_cov)]);
                    PyDict pyDict = new PyDict();
                    if (norm != "frobenius")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (scaling != true)
                        pyDict["scaling"] = Helpers.ToPython(scaling);
                    if (squared != true)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("error_norm", args, pyDict));
                }

                public OAS fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray mahalanobis(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("mahalanobis", args, pyDict));
                }

                public float score(NDarray X_test)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X_test)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public OAS set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public OAS set_score_request(string? X_test = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X_test != "$UNCHANGED$")
                        pyDict["X_test"] = Helpers.ToPython(X_test);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class ShrunkCovariance : PythonObject
            {
                public ShrunkCovariance(bool store_precision = true, bool assume_centered = false, float shrinkage = 0.1f)
                {
                    _ = sklearn.covariance.self;
                    PyTuple args = new PyTuple();
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

                public static ShrunkCovariance Encapsule(PyObject pyObject)
                {
                    return new ShrunkCovariance(pyObject);
                }

                public NDarray covariance_ => Helpers.ToCSharpNDarray(self.GetAttr("covariance_"));
                public NDarray location_ => Helpers.ToCSharpNDarray(self.GetAttr("location_"));
                public NDarray precision_ => Helpers.ToCSharpNDarray(self.GetAttr("precision_"));
                public int n_features_in_ => Helpers.ToCSharpInt(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public float error_norm(NDarray comp_cov, string norm = "frobenius", bool scaling = true, bool squared = true)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(comp_cov)]);
                    PyDict pyDict = new PyDict();
                    if (norm != "frobenius")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (scaling != true)
                        pyDict["scaling"] = Helpers.ToPython(scaling);
                    if (squared != true)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("error_norm", args, pyDict));
                }

                public ShrunkCovariance fit(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public NDarray get_precision()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_precision", args, pyDict));
                }

                public NDarray mahalanobis(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("mahalanobis", args, pyDict));
                }

                public float score(NDarray X_test)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X_test)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }

                public ShrunkCovariance set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public ShrunkCovariance set_score_request(string? X_test = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X_test != "$UNCHANGED$")
                        pyDict["X_test"] = Helpers.ToPython(X_test);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public static NDarray empirical_covariance(NDarray X, bool assume_centered = false)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                return Helpers.ToCSharpNDarray(sklearn.covariance.self.InvokeMethod("empirical_covariance", args, pyDict));
            }

            public static (NDarray?, NDarray?, PyObject?, int?) graphical_lasso(NDarray emp_cov, float alpha, string mode = "cd", float tol = 0.0001f, float enet_tol = 0.0001f, int max_iter = 100, bool verbose = false, bool return_costs = false, float eps = float.Epsilon, bool return_n_iter = false)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple([Helpers.ToPython(emp_cov), Helpers.ToPython(alpha)]);
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
                PyTuple result = new PyTuple(sklearn.covariance.self.InvokeMethod("graphical_lasso", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpPyObject(result[2]) : null, __length > 3 ? Helpers.ToCSharpInt(result[3]) : null);
            }

            public static (NDarray?, float?) ledoit_wolf(NDarray X, bool assume_centered = false, int block_size = 1000)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                if (block_size != 1000)
                    pyDict["block_size"] = Helpers.ToPython(block_size);
                PyTuple result = new PyTuple(sklearn.covariance.self.InvokeMethod("ledoit_wolf", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpFloat(result[1]) : null);
            }

            public static float ledoit_wolf_shrinkage(NDarray X, bool assume_centered = false, int block_size = 1000)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                if (block_size != 1000)
                    pyDict["block_size"] = Helpers.ToPython(block_size);
                return Helpers.ToCSharpFloat(sklearn.covariance.self.InvokeMethod("ledoit_wolf_shrinkage", args, pyDict));
            }

            public static (NDarray?, float?) oas(NDarray X, bool assume_centered = false)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (assume_centered != false)
                    pyDict["assume_centered"] = Helpers.ToPython(assume_centered);
                PyTuple result = new PyTuple(sklearn.covariance.self.InvokeMethod("oas", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpFloat(result[1]) : null);
            }

            public static NDarray shrunk_covariance(NDarray emp_cov, float shrinkage = 0.1f)
            {
                _ = sklearn.covariance.self;
                PyTuple args = new PyTuple([Helpers.ToPython(emp_cov)]);
                PyDict pyDict = new PyDict();
                if (shrinkage != 0.1f)
                    pyDict["shrinkage"] = Helpers.ToPython(shrinkage);
                return Helpers.ToCSharpNDarray(sklearn.covariance.self.InvokeMethod("shrunk_covariance", args, pyDict));
            }
        }
    }
}