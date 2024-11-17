using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class neighbors
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
                return Py.Import("sklearn.neighbors");
            }

            static neighbors()
            {
                ReInitializeLazySelf();
            }

            public class BallTree : PythonObject
            {
                public BallTree()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.neighbors.self.InvokeMethod("BallTree", args, pyDict);
                }

                internal BallTree(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static BallTree Encapsule(PyObject pyObject)
                {
                    return new BallTree(pyObject);
                }

                public PyObject data => self.GetAttr("data");
                public PyTuple valid_metrics => new PyTuple(self.GetAttr("valid_metrics"));

                public NDarray get_arrays()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("get_arrays", args, pyDict));
                }

                public int get_n_calls()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<int>(self.InvokeMethod("get_n_calls", args, pyDict));
                }

                public int get_tree_stats()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<int>(self.InvokeMethod("get_tree_stats", args, pyDict));
                }

                public NDarray kernel_density(NDarray X, float h, string kernel = "gaussian", int atol = 0, float rtol = 1E-8f, bool breadth_first = true, bool return_log = false)
                {
                    PyTuple args = ToTuple(new object[] { X, h });
                    PyDict pyDict = new PyDict();
                    if (kernel != "gaussian")
                        pyDict["kernel"] = ToPython(kernel);
                    if (atol != 0)
                        pyDict["atol"] = ToPython(atol);
                    if (rtol != 1E-8f)
                        pyDict["rtol"] = ToPython(rtol);
                    if (breadth_first != true)
                        pyDict["breadth_first"] = ToPython(breadth_first);
                    if (return_log != false)
                        pyDict["return_log"] = ToPython(return_log);
                    return ToCsharp<NDarray>(self.InvokeMethod("kernel_density", args, pyDict));
                }

                public (bool, bool, NDarray, NDarray) query(NDarray X, int k = 1, bool return_distance = true, bool dualtree = false, bool breadth_first = false)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (k != 1)
                        pyDict["k"] = ToPython(k);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    if (dualtree != false)
                        pyDict["dualtree"] = ToPython(dualtree);
                    if (breadth_first != false)
                        pyDict["breadth_first"] = ToPython(breadth_first);
                    PyTuple result = new PyTuple(self.InvokeMethod("query", args, pyDict));
                    return (ToCsharp<bool>(result[0]), ToCsharp<bool>(result[1]), ToCsharp<NDarray>(result[2]), ToCsharp<NDarray>(result[3]));
                }

                public (bool, bool, bool, NDarray, PyObject, PyObject) query_radius(NDarray X, PyObject r, bool return_distance = false, bool count_only = false, bool sort_results = false)
                {
                    PyTuple args = ToTuple(new object[] { X, r });
                    PyDict pyDict = new PyDict();
                    if (return_distance != false)
                        pyDict["return_distance"] = ToPython(return_distance);
                    if (count_only != false)
                        pyDict["count_only"] = ToPython(count_only);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    PyTuple result = new PyTuple(self.InvokeMethod("query_radius", args, pyDict));
                    return (ToCsharp<bool>(result[0]), ToCsharp<bool>(result[1]), ToCsharp<bool>(result[2]), ToCsharp<NDarray>(result[3]), ToCsharp<PyObject>(result[4]), ToCsharp<PyObject>(result[5]));
                }

                public void reset_n_calls()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("reset_n_calls", args, pyDict);
                }

                public NDarray two_point_correlation(NDarray X, NDarray r, bool dualtree = false)
                {
                    PyTuple args = ToTuple(new object[] { X, r });
                    PyDict pyDict = new PyDict();
                    if (dualtree != false)
                        pyDict["dualtree"] = ToPython(dualtree);
                    return ToCsharp<NDarray>(self.InvokeMethod("two_point_correlation", args, pyDict));
                }
            }

            public class KDTree : PythonObject
            {
                public KDTree()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.neighbors.self.InvokeMethod("KDTree", args, pyDict);
                }

                internal KDTree(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static KDTree Encapsule(PyObject pyObject)
                {
                    return new KDTree(pyObject);
                }

                public PyObject data => self.GetAttr("data");
                public PyTuple valid_metrics => new PyTuple(self.GetAttr("valid_metrics"));

                public NDarray get_arrays()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("get_arrays", args, pyDict));
                }

                public int get_n_calls()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<int>(self.InvokeMethod("get_n_calls", args, pyDict));
                }

                public int get_tree_stats()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<int>(self.InvokeMethod("get_tree_stats", args, pyDict));
                }

                public NDarray kernel_density(NDarray X, float h, string kernel = "gaussian", int atol = 0, float rtol = 1E-8f, bool breadth_first = true, bool return_log = false)
                {
                    PyTuple args = ToTuple(new object[] { X, h });
                    PyDict pyDict = new PyDict();
                    if (kernel != "gaussian")
                        pyDict["kernel"] = ToPython(kernel);
                    if (atol != 0)
                        pyDict["atol"] = ToPython(atol);
                    if (rtol != 1E-8f)
                        pyDict["rtol"] = ToPython(rtol);
                    if (breadth_first != true)
                        pyDict["breadth_first"] = ToPython(breadth_first);
                    if (return_log != false)
                        pyDict["return_log"] = ToPython(return_log);
                    return ToCsharp<NDarray>(self.InvokeMethod("kernel_density", args, pyDict));
                }

                public (bool, bool, NDarray, NDarray) query(NDarray X, int k = 1, bool return_distance = true, bool dualtree = false, bool breadth_first = false)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (k != 1)
                        pyDict["k"] = ToPython(k);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    if (dualtree != false)
                        pyDict["dualtree"] = ToPython(dualtree);
                    if (breadth_first != false)
                        pyDict["breadth_first"] = ToPython(breadth_first);
                    PyTuple result = new PyTuple(self.InvokeMethod("query", args, pyDict));
                    return (ToCsharp<bool>(result[0]), ToCsharp<bool>(result[1]), ToCsharp<NDarray>(result[2]), ToCsharp<NDarray>(result[3]));
                }

                public (bool, bool, bool, NDarray, PyObject, PyObject) query_radius(NDarray X, PyObject r, bool return_distance = false, bool count_only = false, bool sort_results = false)
                {
                    PyTuple args = ToTuple(new object[] { X, r });
                    PyDict pyDict = new PyDict();
                    if (return_distance != false)
                        pyDict["return_distance"] = ToPython(return_distance);
                    if (count_only != false)
                        pyDict["count_only"] = ToPython(count_only);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    PyTuple result = new PyTuple(self.InvokeMethod("query_radius", args, pyDict));
                    return (ToCsharp<bool>(result[0]), ToCsharp<bool>(result[1]), ToCsharp<bool>(result[2]), ToCsharp<NDarray>(result[3]), ToCsharp<PyObject>(result[4]), ToCsharp<PyObject>(result[5]));
                }

                public void reset_n_calls()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("reset_n_calls", args, pyDict);
                }

                public NDarray two_point_correlation(NDarray X, NDarray r, bool dualtree = false)
                {
                    PyTuple args = ToTuple(new object[] { X, r });
                    PyDict pyDict = new PyDict();
                    if (dualtree != false)
                        pyDict["dualtree"] = ToPython(dualtree);
                    return ToCsharp<NDarray>(self.InvokeMethod("two_point_correlation", args, pyDict));
                }
            }

            public class KNeighborsClassifier : PythonObject
            {
                public KNeighborsClassifier(int n_neighbors = 5, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_neighbors != 5)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (weights != "uniform")
                        pyDict["weights"] = ToPython(weights);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (leaf_size != 30)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.neighbors.self.InvokeMethod("KNeighborsClassifier", args, pyDict);
                }

                internal KNeighborsClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static KNeighborsClassifier Encapsule(PyObject pyObject)
                {
                    return new KNeighborsClassifier(pyObject);
                }

                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public string effective_metric_ => ToCsharp<string>(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => new PyDict(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => ToCsharp<int>(self.GetAttr("n_samples_fit_"));
                public bool outputs_2d_ => ToCsharp<bool>(self.GetAttr("outputs_2d_"));

                public KNeighborsClassifier fit(NDarray X, NDarray y)
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

                public (NDarray, NDarray) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    PyTuple result = new PyTuple(self.InvokeMethod("kneighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    return ToCsharp<NDarray>(self.InvokeMethod("kneighbors_graph", args, pyDict));
                }

                public NDarray predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
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

                public KNeighborsClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public KNeighborsClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class KNeighborsRegressor : PythonObject
            {
                public KNeighborsRegressor(int n_neighbors = 5, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_neighbors != 5)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (weights != "uniform")
                        pyDict["weights"] = ToPython(weights);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (leaf_size != 30)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.neighbors.self.InvokeMethod("KNeighborsRegressor", args, pyDict);
                }

                internal KNeighborsRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static KNeighborsRegressor Encapsule(PyObject pyObject)
                {
                    return new KNeighborsRegressor(pyObject);
                }

                public string effective_metric_ => ToCsharp<string>(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => new PyDict(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => ToCsharp<int>(self.GetAttr("n_samples_fit_"));

                public KNeighborsRegressor fit(NDarray X, NDarray y)
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

                public (NDarray, NDarray) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    PyTuple result = new PyTuple(self.InvokeMethod("kneighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    return ToCsharp<NDarray>(self.InvokeMethod("kneighbors_graph", args, pyDict));
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

                public KNeighborsRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public KNeighborsRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class KNeighborsTransformer : PythonObject
            {
                public KNeighborsTransformer(string mode = "distance", int n_neighbors = 5, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (mode != "distance")
                        pyDict["mode"] = ToPython(mode);
                    if (n_neighbors != 5)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (leaf_size != 30)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.neighbors.self.InvokeMethod("KNeighborsTransformer", args, pyDict);
                }

                internal KNeighborsTransformer(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static KNeighborsTransformer Encapsule(PyObject pyObject)
                {
                    return new KNeighborsTransformer(pyObject);
                }

                public string effective_metric_ => ToCsharp<string>(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => new PyDict(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => ToCsharp<int>(self.GetAttr("n_samples_fit_"));

                public KNeighborsTransformer fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public (NDarray, NDarray) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    PyTuple result = new PyTuple(self.InvokeMethod("kneighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    return ToCsharp<NDarray>(self.InvokeMethod("kneighbors_graph", args, pyDict));
                }

                public KNeighborsTransformer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public KNeighborsTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class KernelDensity : PythonObject
            {
                public KernelDensity(float bandwidth = 1.0f, string algorithm = "auto", string kernel = "gaussian", string metric = "euclidean", int atol = 0, int rtol = 0, bool breadth_first = true, int leaf_size = 40, PyDict? metric_params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (bandwidth != 1.0f)
                        pyDict["bandwidth"] = ToPython(bandwidth);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (kernel != "gaussian")
                        pyDict["kernel"] = ToPython(kernel);
                    if (metric != "euclidean")
                        pyDict["metric"] = ToPython(metric);
                    if (atol != 0)
                        pyDict["atol"] = ToPython(atol);
                    if (rtol != 0)
                        pyDict["rtol"] = ToPython(rtol);
                    if (breadth_first != true)
                        pyDict["breadth_first"] = ToPython(breadth_first);
                    if (leaf_size != 40)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    self = sklearn.neighbors.self.InvokeMethod("KernelDensity", args, pyDict);
                }

                internal KernelDensity(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static KernelDensity Encapsule(PyObject pyObject)
                {
                    return new KernelDensity(pyObject);
                }

                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public PyObject tree_ => self.GetAttr("tree_");
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public float bandwidth_ => ToCsharp<float>(self.GetAttr("bandwidth_"));

                public KernelDensity fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
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

                public NDarray sample(int n_samples = 1, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_samples != 1)
                        pyDict["n_samples"] = ToPython(n_samples);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    return ToCsharp<NDarray>(self.InvokeMethod("sample", args, pyDict));
                }

                public float score(NDarray X, PyObject? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("score_samples", args, pyDict));
                }

                public KernelDensity set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public KernelDensity set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class LocalOutlierFactor : PythonObject
            {
                public LocalOutlierFactor(int n_neighbors = 20, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, string contamination = "auto", bool novelty = false, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_neighbors != 20)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (leaf_size != 30)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (contamination != "auto")
                        pyDict["contamination"] = ToPython(contamination);
                    if (novelty != false)
                        pyDict["novelty"] = ToPython(novelty);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.neighbors.self.InvokeMethod("LocalOutlierFactor", args, pyDict);
                }

                internal LocalOutlierFactor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static LocalOutlierFactor Encapsule(PyObject pyObject)
                {
                    return new LocalOutlierFactor(pyObject);
                }

                public NDarray negative_outlier_factor_ => ToCsharp<NDarray>(self.GetAttr("negative_outlier_factor_"));
                public int n_neighbors_ => ToCsharp<int>(self.GetAttr("n_neighbors_"));
                public float offset_ => ToCsharp<float>(self.GetAttr("offset_"));
                public string effective_metric_ => ToCsharp<string>(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => new PyDict(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => ToCsharp<int>(self.GetAttr("n_samples_fit_"));

                public NDarray decision_function(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("decision_function", args, pyDict));
                }

                public LocalOutlierFactor fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_predict(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public (NDarray, NDarray) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    PyTuple result = new PyTuple(self.InvokeMethod("kneighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    return ToCsharp<NDarray>(self.InvokeMethod("kneighbors_graph", args, pyDict));
                }

                public NDarray predict(NDarray? X = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    return ToCsharp<NDarray>(self.InvokeMethod("predict", args, pyDict));
                }

                public NDarray score_samples(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("score_samples", args, pyDict));
                }

                public LocalOutlierFactor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class NearestCentroid : PythonObject
            {
                public NearestCentroid(string metric = "euclidean", float? shrink_threshold = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (metric != "euclidean")
                        pyDict["metric"] = ToPython(metric);
                    if (shrink_threshold != null)
                        pyDict["shrink_threshold"] = ToPython(shrink_threshold);
                    self = sklearn.neighbors.self.InvokeMethod("NearestCentroid", args, pyDict);
                }

                internal NearestCentroid(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static NearestCentroid Encapsule(PyObject pyObject)
                {
                    return new NearestCentroid(pyObject);
                }

                public NDarray centroids_ => ToCsharp<NDarray>(self.GetAttr("centroids_"));
                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NearestCentroid fit(NDarray X, NDarray y)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public NearestCentroid set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NearestCentroid set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class NearestNeighbors : PythonObject
            {
                public NearestNeighbors(int n_neighbors = 5, float radius = 1.0f, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_neighbors != 5)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (radius != 1.0f)
                        pyDict["radius"] = ToPython(radius);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (leaf_size != 30)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.neighbors.self.InvokeMethod("NearestNeighbors", args, pyDict);
                }

                internal NearestNeighbors(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static NearestNeighbors Encapsule(PyObject pyObject)
                {
                    return new NearestNeighbors(pyObject);
                }

                public string effective_metric_ => ToCsharp<string>(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => new PyDict(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => ToCsharp<int>(self.GetAttr("n_samples_fit_"));

                public NearestNeighbors fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
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

                public (NDarray, NDarray) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    PyTuple result = new PyTuple(self.InvokeMethod("kneighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    return ToCsharp<NDarray>(self.InvokeMethod("kneighbors_graph", args, pyDict));
                }

                public (NDarray, NDarray) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    PyTuple result = new PyTuple(self.InvokeMethod("radius_neighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    return ToCsharp<NDarray>(self.InvokeMethod("radius_neighbors_graph", args, pyDict));
                }

                public NearestNeighbors set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class NeighborhoodComponentsAnalysis : PythonObject
            {
                public NeighborhoodComponentsAnalysis(int? n_components = null, string init = "auto", bool warm_start = false, int max_iter = 50, float tol = 1e-05f, PyObject? callback = null, int verbose = 0, int? random_state = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != null)
                        pyDict["n_components"] = ToPython(n_components);
                    if (init != "auto")
                        pyDict["init"] = ToPython(init);
                    if (warm_start != false)
                        pyDict["warm_start"] = ToPython(warm_start);
                    if (max_iter != 50)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (tol != 1e-05f)
                        pyDict["tol"] = ToPython(tol);
                    if (callback != null)
                        pyDict["callback"] = ToPython(callback);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    self = sklearn.neighbors.self.InvokeMethod("NeighborhoodComponentsAnalysis", args, pyDict);
                }

                internal NeighborhoodComponentsAnalysis(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static NeighborhoodComponentsAnalysis Encapsule(PyObject pyObject)
                {
                    return new NeighborhoodComponentsAnalysis(pyObject);
                }

                public NDarray components_ => ToCsharp<NDarray>(self.GetAttr("components_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));
                public PyObject random_state_ => self.GetAttr("random_state_");
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public NeighborhoodComponentsAnalysis fit(NDarray X, NDarray y)
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

                public NeighborhoodComponentsAnalysis set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public NeighborhoodComponentsAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public class RadiusNeighborsClassifier : PythonObject
            {
                public RadiusNeighborsClassifier(float radius = 1.0f, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyObject? outlier_label = null, PyDict? metric_params = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (radius != 1.0f)
                        pyDict["radius"] = ToPython(radius);
                    if (weights != "uniform")
                        pyDict["weights"] = ToPython(weights);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (leaf_size != 30)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (outlier_label != null)
                        pyDict["outlier_label"] = ToPython(outlier_label);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.neighbors.self.InvokeMethod("RadiusNeighborsClassifier", args, pyDict);
                }

                internal RadiusNeighborsClassifier(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RadiusNeighborsClassifier Encapsule(PyObject pyObject)
                {
                    return new RadiusNeighborsClassifier(pyObject);
                }

                public NDarray classes_ => ToCsharp<NDarray>(self.GetAttr("classes_"));
                public string effective_metric_ => ToCsharp<string>(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => new PyDict(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => ToCsharp<int>(self.GetAttr("n_samples_fit_"));
                public NDarray outlier_label_ => ToCsharp<NDarray>(self.GetAttr("outlier_label_"));
                public bool outputs_2d_ => ToCsharp<bool>(self.GetAttr("outputs_2d_"));

                public RadiusNeighborsClassifier fit(NDarray X, NDarray y)
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

                public NDarray predict_proba(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("predict_proba", args, pyDict));
                }

                public (NDarray, NDarray) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    PyTuple result = new PyTuple(self.InvokeMethod("radius_neighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    return ToCsharp<NDarray>(self.InvokeMethod("radius_neighbors_graph", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public RadiusNeighborsClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public RadiusNeighborsClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class RadiusNeighborsRegressor : PythonObject
            {
                public RadiusNeighborsRegressor(float radius = 1.0f, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (radius != 1.0f)
                        pyDict["radius"] = ToPython(radius);
                    if (weights != "uniform")
                        pyDict["weights"] = ToPython(weights);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (leaf_size != 30)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.neighbors.self.InvokeMethod("RadiusNeighborsRegressor", args, pyDict);
                }

                internal RadiusNeighborsRegressor(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RadiusNeighborsRegressor Encapsule(PyObject pyObject)
                {
                    return new RadiusNeighborsRegressor(pyObject);
                }

                public string effective_metric_ => ToCsharp<string>(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => new PyDict(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => ToCsharp<int>(self.GetAttr("n_samples_fit_"));

                public RadiusNeighborsRegressor fit(NDarray X, NDarray y)
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

                public (NDarray, NDarray) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    PyTuple result = new PyTuple(self.InvokeMethod("radius_neighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    return ToCsharp<NDarray>(self.InvokeMethod("radius_neighbors_graph", args, pyDict));
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = ToTuple(new object[] { X, y });
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    return ToCsharp<float>(self.InvokeMethod("score", args, pyDict));
                }

                public RadiusNeighborsRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public RadiusNeighborsRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (sample_weight != "$UNCHANGED$")
                        pyDict["sample_weight"] = ToPython(sample_weight);
                    self.InvokeMethod("set_score_request", args, pyDict);
                    return this;
                }
            }

            public class RadiusNeighborsTransformer : PythonObject
            {
                public RadiusNeighborsTransformer(string mode = "distance", float radius = 1.0f, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (mode != "distance")
                        pyDict["mode"] = ToPython(mode);
                    if (radius != 1.0f)
                        pyDict["radius"] = ToPython(radius);
                    if (algorithm != "auto")
                        pyDict["algorithm"] = ToPython(algorithm);
                    if (leaf_size != 30)
                        pyDict["leaf_size"] = ToPython(leaf_size);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.neighbors.self.InvokeMethod("RadiusNeighborsTransformer", args, pyDict);
                }

                internal RadiusNeighborsTransformer(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static RadiusNeighborsTransformer Encapsule(PyObject pyObject)
                {
                    return new RadiusNeighborsTransformer(pyObject);
                }

                public string effective_metric_ => ToCsharp<string>(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => new PyDict(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => ToCsharp<int>(self.GetAttr("n_samples_fit_"));

                public RadiusNeighborsTransformer fit(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
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

                public (NDarray, NDarray) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (return_distance != true)
                        pyDict["return_distance"] = ToPython(return_distance);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    PyTuple result = new PyTuple(self.InvokeMethod("radius_neighbors", args, pyDict));
                    return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
                }

                public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (X != null)
                        pyDict["X"] = ToPython(X);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (mode != "connectivity")
                        pyDict["mode"] = ToPython(mode);
                    if (sort_results != false)
                        pyDict["sort_results"] = ToPython(sort_results);
                    return ToCsharp<NDarray>(self.InvokeMethod("radius_neighbors_graph", args, pyDict));
                }

                public RadiusNeighborsTransformer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public RadiusNeighborsTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(NDarray X)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                }
            }

            public static NDarray kneighbors_graph(NDarray X, int n_neighbors, string mode = "connectivity", string metric = "minkowski", int p = 2, PyDict? metric_params = null, bool include_self = false, int? n_jobs = null)
            {
                PyTuple args = ToTuple(new object[] { X, n_neighbors });
                PyDict pyDict = new PyDict();
                if (mode != "connectivity")
                    pyDict["mode"] = ToPython(mode);
                if (metric != "minkowski")
                    pyDict["metric"] = ToPython(metric);
                if (p != 2)
                    pyDict["p"] = ToPython(p);
                if (metric_params != null)
                    pyDict["metric_params"] = ToPython(metric_params);
                if (include_self != false)
                    pyDict["include_self"] = ToPython(include_self);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                return ToCsharp<NDarray>(sklearn.neighbors.self.InvokeMethod("kneighbors_graph", args, pyDict));
            }

            public static NDarray radius_neighbors_graph(NDarray X, float radius, string mode = "connectivity", string metric = "minkowski", int p = 2, PyDict? metric_params = null, bool include_self = false, int? n_jobs = null)
            {
                PyTuple args = ToTuple(new object[] { X, radius });
                PyDict pyDict = new PyDict();
                if (mode != "connectivity")
                    pyDict["mode"] = ToPython(mode);
                if (metric != "minkowski")
                    pyDict["metric"] = ToPython(metric);
                if (p != 2)
                    pyDict["p"] = ToPython(p);
                if (metric_params != null)
                    pyDict["metric_params"] = ToPython(metric_params);
                if (include_self != false)
                    pyDict["include_self"] = ToPython(include_self);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                return ToCsharp<NDarray>(sklearn.neighbors.self.InvokeMethod("radius_neighbors_graph", args, pyDict));
            }

            public static NDarray sort_graph_by_row_values(NDarray graph, bool copy = false, bool warn_when_not_sorted = true)
            {
                PyTuple args = ToTuple(new object[] { graph });
                PyDict pyDict = new PyDict();
                if (copy != false)
                    pyDict["copy"] = ToPython(copy);
                if (warn_when_not_sorted != true)
                    pyDict["warn_when_not_sorted"] = ToPython(warn_when_not_sorted);
                return ToCsharp<NDarray>(sklearn.neighbors.self.InvokeMethod("sort_graph_by_row_values", args, pyDict));
            }
        }
    }
}