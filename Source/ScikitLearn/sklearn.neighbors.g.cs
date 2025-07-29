namespace ScikitLearn;
#nullable enable
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

        static neighbors() => ReInitializeLazySelf();
        public static NDarray kneighbors_graph(NDarray X, int n_neighbors, string mode = "connectivity", string metric = "minkowski", int p = 2, PyDict? metric_params = null, bool include_self = false, int? n_jobs = null)
        {
            _ = sklearn.neighbors.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(n_neighbors) });
            PyDict pyDict = new PyDict();
            if (mode != "connectivity")
                pyDict["mode"] = Helpers.ToPython(mode);
            if (metric != "minkowski")
                pyDict["metric"] = Helpers.ToPython(metric);
            if (p != 2)
                pyDict["p"] = Helpers.ToPython(p);
            if (metric_params != null)
                pyDict["metric_params"] = Helpers.ToPython(metric_params);
            if (include_self != false)
                pyDict["include_self"] = Helpers.ToPython(include_self);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            var __pyObject = self.InvokeMethod("kneighbors_graph", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static NDarray radius_neighbors_graph(NDarray X, float radius, string mode = "connectivity", string metric = "minkowski", int p = 2, PyDict? metric_params = null, bool include_self = false, int? n_jobs = null)
        {
            _ = sklearn.neighbors.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(radius) });
            PyDict pyDict = new PyDict();
            if (mode != "connectivity")
                pyDict["mode"] = Helpers.ToPython(mode);
            if (metric != "minkowski")
                pyDict["metric"] = Helpers.ToPython(metric);
            if (p != 2)
                pyDict["p"] = Helpers.ToPython(p);
            if (metric_params != null)
                pyDict["metric_params"] = Helpers.ToPython(metric_params);
            if (include_self != false)
                pyDict["include_self"] = Helpers.ToPython(include_self);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            var __pyObject = self.InvokeMethod("radius_neighbors_graph", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static NDarray sort_graph_by_row_values(NDarray graph, bool copy = false, bool warn_when_not_sorted = true)
        {
            _ = sklearn.neighbors.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(graph) });
            PyDict pyDict = new PyDict();
            if (copy != false)
                pyDict["copy"] = Helpers.ToPython(copy);
            if (warn_when_not_sorted != true)
                pyDict["warn_when_not_sorted"] = Helpers.ToPython(warn_when_not_sorted);
            var __pyObject = self.InvokeMethod("sort_graph_by_row_values", args, pyDict);
            return new NDarray(__pyObject);
        }

        public class BallTree : PythonObject
        {
            public BallTree()
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.neighbors.self.InvokeMethod("BallTree", args, pyDict);
            }

            internal BallTree(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static BallTree Encapsule(PyObject pyObject) => new BallTree(pyObject);
            public static BallTree Wrap(PyObject pyObject) => new BallTree(pyObject);
            public PyObject data
            {
                get
                {
                    var __pyObject = self.GetAttr("data");
                    return __pyObject;
                }
            }

            public PyTuple valid_metrics
            {
                get
                {
                    var __pyObject = self.GetAttr("valid_metrics");
                    return new PyTuple(__pyObject);
                }
            }

            public NDarray get_arrays()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_arrays", args, pyDict);
                return new NDarray(__pyObject);
            }

            public int get_n_calls()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_n_calls", args, pyDict);
                return __pyObject.As<int>();
            }

            public int get_tree_stats()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_tree_stats", args, pyDict);
                return __pyObject.As<int>();
            }

            public NDarray kernel_density(NDarray X, float h, string kernel = "gaussian", int atol = 0, float rtol = 1E-8f, bool breadth_first = true, bool return_log = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(h) });
                PyDict pyDict = new PyDict();
                if (kernel != "gaussian")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (atol != 0)
                    pyDict["atol"] = Helpers.ToPython(atol);
                if (rtol != 1E-8f)
                    pyDict["rtol"] = Helpers.ToPython(rtol);
                if (breadth_first != true)
                    pyDict["breadth_first"] = Helpers.ToPython(breadth_first);
                if (return_log != false)
                    pyDict["return_log"] = Helpers.ToPython(return_log);
                var __pyObject = self.InvokeMethod("kernel_density", args, pyDict);
                return new NDarray(__pyObject);
            }

            public (bool? , bool? , NDarray? , NDarray? ) query(NDarray X, int k = 1, bool return_distance = true, bool dualtree = false, bool breadth_first = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (k != 1)
                    pyDict["k"] = Helpers.ToPython(k);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                if (dualtree != false)
                    pyDict["dualtree"] = Helpers.ToPython(dualtree);
                if (breadth_first != false)
                    pyDict["breadth_first"] = Helpers.ToPython(breadth_first);
                var __pyObject = self.InvokeMethod("query", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? __pyObjectTuple[0].As<bool>() : null, __pyObjectLength > 1 ? __pyObjectTuple[1].As<bool>() : null, __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null, __pyObjectLength > 3 ? new NDarray(__pyObjectTuple[3]) : null);
            }

            public (bool? , bool? , bool? , NDarray? , PyObject? , PyObject? ) query_radius(NDarray X, PyObject r, bool return_distance = false, bool count_only = false, bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(r) });
                PyDict pyDict = new PyDict();
                if (return_distance != false)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                if (count_only != false)
                    pyDict["count_only"] = Helpers.ToPython(count_only);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("query_radius", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? __pyObjectTuple[0].As<bool>() : null, __pyObjectLength > 1 ? __pyObjectTuple[1].As<bool>() : null, __pyObjectLength > 2 ? __pyObjectTuple[2].As<bool>() : null, __pyObjectLength > 3 ? new NDarray(__pyObjectTuple[3]) : null, __pyObjectLength > 4 ? __pyObjectTuple[4] : null, __pyObjectLength > 5 ? __pyObjectTuple[5] : null);
            }

            public void reset_n_calls()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("reset_n_calls", args, pyDict);
            }

            public NDarray two_point_correlation(NDarray X, NDarray r, bool dualtree = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(r) });
                PyDict pyDict = new PyDict();
                if (dualtree != false)
                    pyDict["dualtree"] = Helpers.ToPython(dualtree);
                var __pyObject = self.InvokeMethod("two_point_correlation", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class KDTree : PythonObject
        {
            public KDTree()
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.neighbors.self.InvokeMethod("KDTree", args, pyDict);
            }

            internal KDTree(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static KDTree Encapsule(PyObject pyObject) => new KDTree(pyObject);
            public static KDTree Wrap(PyObject pyObject) => new KDTree(pyObject);
            public PyObject data
            {
                get
                {
                    var __pyObject = self.GetAttr("data");
                    return __pyObject;
                }
            }

            public PyTuple valid_metrics
            {
                get
                {
                    var __pyObject = self.GetAttr("valid_metrics");
                    return new PyTuple(__pyObject);
                }
            }

            public NDarray get_arrays()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_arrays", args, pyDict);
                return new NDarray(__pyObject);
            }

            public int get_n_calls()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_n_calls", args, pyDict);
                return __pyObject.As<int>();
            }

            public int get_tree_stats()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_tree_stats", args, pyDict);
                return __pyObject.As<int>();
            }

            public NDarray kernel_density(NDarray X, float h, string kernel = "gaussian", int atol = 0, float rtol = 1E-8f, bool breadth_first = true, bool return_log = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(h) });
                PyDict pyDict = new PyDict();
                if (kernel != "gaussian")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (atol != 0)
                    pyDict["atol"] = Helpers.ToPython(atol);
                if (rtol != 1E-8f)
                    pyDict["rtol"] = Helpers.ToPython(rtol);
                if (breadth_first != true)
                    pyDict["breadth_first"] = Helpers.ToPython(breadth_first);
                if (return_log != false)
                    pyDict["return_log"] = Helpers.ToPython(return_log);
                var __pyObject = self.InvokeMethod("kernel_density", args, pyDict);
                return new NDarray(__pyObject);
            }

            public (bool? , bool? , NDarray? , NDarray? ) query(NDarray X, int k = 1, bool return_distance = true, bool dualtree = false, bool breadth_first = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (k != 1)
                    pyDict["k"] = Helpers.ToPython(k);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                if (dualtree != false)
                    pyDict["dualtree"] = Helpers.ToPython(dualtree);
                if (breadth_first != false)
                    pyDict["breadth_first"] = Helpers.ToPython(breadth_first);
                var __pyObject = self.InvokeMethod("query", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? __pyObjectTuple[0].As<bool>() : null, __pyObjectLength > 1 ? __pyObjectTuple[1].As<bool>() : null, __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null, __pyObjectLength > 3 ? new NDarray(__pyObjectTuple[3]) : null);
            }

            public (bool? , bool? , bool? , NDarray? , PyObject? , PyObject? ) query_radius(NDarray X, PyObject r, bool return_distance = false, bool count_only = false, bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(r) });
                PyDict pyDict = new PyDict();
                if (return_distance != false)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                if (count_only != false)
                    pyDict["count_only"] = Helpers.ToPython(count_only);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("query_radius", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? __pyObjectTuple[0].As<bool>() : null, __pyObjectLength > 1 ? __pyObjectTuple[1].As<bool>() : null, __pyObjectLength > 2 ? __pyObjectTuple[2].As<bool>() : null, __pyObjectLength > 3 ? new NDarray(__pyObjectTuple[3]) : null, __pyObjectLength > 4 ? __pyObjectTuple[4] : null, __pyObjectLength > 5 ? __pyObjectTuple[5] : null);
            }

            public void reset_n_calls()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("reset_n_calls", args, pyDict);
            }

            public NDarray two_point_correlation(NDarray X, NDarray r, bool dualtree = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(r) });
                PyDict pyDict = new PyDict();
                if (dualtree != false)
                    pyDict["dualtree"] = Helpers.ToPython(dualtree);
                var __pyObject = self.InvokeMethod("two_point_correlation", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class KNeighborsClassifier : PythonObject
        {
            public KNeighborsClassifier(int n_neighbors = 5, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_neighbors != 5)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (weights != "uniform")
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.neighbors.self.InvokeMethod("KNeighborsClassifier", args, pyDict);
            }

            internal KNeighborsClassifier(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static KNeighborsClassifier Encapsule(PyObject pyObject) => new KNeighborsClassifier(pyObject);
            public static KNeighborsClassifier Wrap(PyObject pyObject) => new KNeighborsClassifier(pyObject);
            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public string effective_metric_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_");
                    return __pyObject.As<string>();
                }
            }

            public PyDict effective_metric_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_params_");
                    return new PyDict(__pyObject);
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

            public int n_samples_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_samples_fit_");
                    return __pyObject.As<int>();
                }
            }

            public bool outputs_2d_
            {
                get
                {
                    var __pyObject = self.GetAttr("outputs_2d_");
                    return __pyObject.As<bool>();
                }
            }

            public KNeighborsClassifier fit(NDarray X, NDarray y)
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

            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                var __pyObject = self.InvokeMethod("kneighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                var __pyObject = self.InvokeMethod("kneighbors_graph", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
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

            public KNeighborsClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public KNeighborsClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class KNeighborsRegressor : PythonObject
        {
            public KNeighborsRegressor(int n_neighbors = 5, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_neighbors != 5)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (weights != "uniform")
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.neighbors.self.InvokeMethod("KNeighborsRegressor", args, pyDict);
            }

            internal KNeighborsRegressor(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static KNeighborsRegressor Encapsule(PyObject pyObject) => new KNeighborsRegressor(pyObject);
            public static KNeighborsRegressor Wrap(PyObject pyObject) => new KNeighborsRegressor(pyObject);
            public string effective_metric_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_");
                    return __pyObject.As<string>();
                }
            }

            public PyDict effective_metric_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_params_");
                    return new PyDict(__pyObject);
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

            public int n_samples_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_samples_fit_");
                    return __pyObject.As<int>();
                }
            }

            public KNeighborsRegressor fit(NDarray X, NDarray y)
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

            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                var __pyObject = self.InvokeMethod("kneighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                var __pyObject = self.InvokeMethod("kneighbors_graph", args, pyDict);
                return new NDarray(__pyObject);
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

            public KNeighborsRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public KNeighborsRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class KNeighborsTransformer : PythonObject
        {
            public KNeighborsTransformer(string mode = "distance", int n_neighbors = 5, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (mode != "distance")
                    pyDict["mode"] = Helpers.ToPython(mode);
                if (n_neighbors != 5)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.neighbors.self.InvokeMethod("KNeighborsTransformer", args, pyDict);
            }

            internal KNeighborsTransformer(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static KNeighborsTransformer Encapsule(PyObject pyObject) => new KNeighborsTransformer(pyObject);
            public static KNeighborsTransformer Wrap(PyObject pyObject) => new KNeighborsTransformer(pyObject);
            public string effective_metric_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_");
                    return __pyObject.As<string>();
                }
            }

            public PyDict effective_metric_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_params_");
                    return new PyDict(__pyObject);
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

            public int n_samples_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_samples_fit_");
                    return __pyObject.As<int>();
                }
            }

            public KNeighborsTransformer fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                var __pyObject = self.InvokeMethod("kneighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                var __pyObject = self.InvokeMethod("kneighbors_graph", args, pyDict);
                return new NDarray(__pyObject);
            }

            public KNeighborsTransformer set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public KNeighborsTransformer set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
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

        public class KernelDensity : PythonObject
        {
            public KernelDensity(float bandwidth = 1.0f, string algorithm = "auto", string kernel = "gaussian", string metric = "euclidean", int atol = 0, int rtol = 0, bool breadth_first = true, int leaf_size = 40, PyDict? metric_params = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (bandwidth != 1.0f)
                    pyDict["bandwidth"] = Helpers.ToPython(bandwidth);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (kernel != "gaussian")
                    pyDict["kernel"] = Helpers.ToPython(kernel);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (atol != 0)
                    pyDict["atol"] = Helpers.ToPython(atol);
                if (rtol != 0)
                    pyDict["rtol"] = Helpers.ToPython(rtol);
                if (breadth_first != true)
                    pyDict["breadth_first"] = Helpers.ToPython(breadth_first);
                if (leaf_size != 40)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                self = sklearn.neighbors.self.InvokeMethod("KernelDensity", args, pyDict);
            }

            internal KernelDensity(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static KernelDensity Encapsule(PyObject pyObject) => new KernelDensity(pyObject);
            public static KernelDensity Wrap(PyObject pyObject) => new KernelDensity(pyObject);
            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject tree_
            {
                get
                {
                    var __pyObject = self.GetAttr("tree_");
                    return __pyObject;
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

            public float bandwidth_
            {
                get
                {
                    var __pyObject = self.GetAttr("bandwidth_");
                    return __pyObject.As<float>();
                }
            }

            public KernelDensity fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public NDarray sample(int n_samples = 1, int? random_state = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_samples != 1)
                    pyDict["n_samples"] = Helpers.ToPython(n_samples);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                var __pyObject = self.InvokeMethod("sample", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, PyObject? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public NDarray score_samples(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score_samples", args, pyDict);
                return new NDarray(__pyObject);
            }

            public KernelDensity set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public KernelDensity set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class LocalOutlierFactor : PythonObject
        {
            public LocalOutlierFactor(int n_neighbors = 20, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, string contamination = "auto", bool novelty = false, int? n_jobs = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_neighbors != 20)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (contamination != "auto")
                    pyDict["contamination"] = Helpers.ToPython(contamination);
                if (novelty != false)
                    pyDict["novelty"] = Helpers.ToPython(novelty);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.neighbors.self.InvokeMethod("LocalOutlierFactor", args, pyDict);
            }

            internal LocalOutlierFactor(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LocalOutlierFactor Encapsule(PyObject pyObject) => new LocalOutlierFactor(pyObject);
            public static LocalOutlierFactor Wrap(PyObject pyObject) => new LocalOutlierFactor(pyObject);
            public NDarray negative_outlier_factor_
            {
                get
                {
                    var __pyObject = self.GetAttr("negative_outlier_factor_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_neighbors_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_neighbors_");
                    return __pyObject.As<int>();
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

            public string effective_metric_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_");
                    return __pyObject.As<string>();
                }
            }

            public PyDict effective_metric_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_params_");
                    return new PyDict(__pyObject);
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

            public int n_samples_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_samples_fit_");
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

            public LocalOutlierFactor fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                var __pyObject = self.InvokeMethod("kneighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                var __pyObject = self.InvokeMethod("kneighbors_graph", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict(NDarray? X = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
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

            public LocalOutlierFactor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class NearestCentroid : PythonObject
        {
            public NearestCentroid(string metric = "euclidean", float? shrink_threshold = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (shrink_threshold != null)
                    pyDict["shrink_threshold"] = Helpers.ToPython(shrink_threshold);
                self = sklearn.neighbors.self.InvokeMethod("NearestCentroid", args, pyDict);
            }

            internal NearestCentroid(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static NearestCentroid Encapsule(PyObject pyObject) => new NearestCentroid(pyObject);
            public static NearestCentroid Wrap(PyObject pyObject) => new NearestCentroid(pyObject);
            public NDarray centroids_
            {
                get
                {
                    var __pyObject = self.GetAttr("centroids_");
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

            public NearestCentroid fit(NDarray X, NDarray y)
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

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public NearestCentroid set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NearestCentroid set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class NearestNeighbors : PythonObject
        {
            public NearestNeighbors(int n_neighbors = 5, float radius = 1.0f, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_neighbors != 5)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (radius != 1.0f)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.neighbors.self.InvokeMethod("NearestNeighbors", args, pyDict);
            }

            internal NearestNeighbors(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static NearestNeighbors Encapsule(PyObject pyObject) => new NearestNeighbors(pyObject);
            public static NearestNeighbors Wrap(PyObject pyObject) => new NearestNeighbors(pyObject);
            public string effective_metric_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_");
                    return __pyObject.As<string>();
                }
            }

            public PyDict effective_metric_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_params_");
                    return new PyDict(__pyObject);
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

            public int n_samples_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_samples_fit_");
                    return __pyObject.As<int>();
                }
            }

            public NearestNeighbors fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
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

            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                var __pyObject = self.InvokeMethod("kneighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                var __pyObject = self.InvokeMethod("kneighbors_graph", args, pyDict);
                return new NDarray(__pyObject);
            }

            public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("radius_neighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("radius_neighbors_graph", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NearestNeighbors set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class NeighborhoodComponentsAnalysis : PythonObject
        {
            public NeighborhoodComponentsAnalysis(int? n_components = null, string init = "auto", bool warm_start = false, int max_iter = 50, float tol = 1e-05f, PyObject? callback = null, int verbose = 0, int? random_state = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_components != null)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (init != "auto")
                    pyDict["init"] = Helpers.ToPython(init);
                if (warm_start != false)
                    pyDict["warm_start"] = Helpers.ToPython(warm_start);
                if (max_iter != 50)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 1e-05f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (callback != null)
                    pyDict["callback"] = Helpers.ToPython(callback);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.neighbors.self.InvokeMethod("NeighborhoodComponentsAnalysis", args, pyDict);
            }

            internal NeighborhoodComponentsAnalysis(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static NeighborhoodComponentsAnalysis Encapsule(PyObject pyObject) => new NeighborhoodComponentsAnalysis(pyObject);
            public static NeighborhoodComponentsAnalysis Wrap(PyObject pyObject) => new NeighborhoodComponentsAnalysis(pyObject);
            public NDarray components_
            {
                get
                {
                    var __pyObject = self.GetAttr("components_");
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject random_state_
            {
                get
                {
                    var __pyObject = self.GetAttr("random_state_");
                    return __pyObject;
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

            public NeighborhoodComponentsAnalysis fit(NDarray X, NDarray y)
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

            public NeighborhoodComponentsAnalysis set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public NeighborhoodComponentsAnalysis set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
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

        public class RadiusNeighborsClassifier : PythonObject
        {
            public RadiusNeighborsClassifier(float radius = 1.0f, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyObject? outlier_label = null, PyDict? metric_params = null, int? n_jobs = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (radius != 1.0f)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (weights != "uniform")
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (outlier_label != null)
                    pyDict["outlier_label"] = Helpers.ToPython(outlier_label);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.neighbors.self.InvokeMethod("RadiusNeighborsClassifier", args, pyDict);
            }

            internal RadiusNeighborsClassifier(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static RadiusNeighborsClassifier Encapsule(PyObject pyObject) => new RadiusNeighborsClassifier(pyObject);
            public static RadiusNeighborsClassifier Wrap(PyObject pyObject) => new RadiusNeighborsClassifier(pyObject);
            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public string effective_metric_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_");
                    return __pyObject.As<string>();
                }
            }

            public PyDict effective_metric_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_params_");
                    return new PyDict(__pyObject);
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

            public int n_samples_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_samples_fit_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray outlier_label_
            {
                get
                {
                    var __pyObject = self.GetAttr("outlier_label_");
                    return new NDarray(__pyObject);
                }
            }

            public bool outputs_2d_
            {
                get
                {
                    var __pyObject = self.GetAttr("outputs_2d_");
                    return __pyObject.As<bool>();
                }
            }

            public RadiusNeighborsClassifier fit(NDarray X, NDarray y)
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

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("radius_neighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("radius_neighbors_graph", args, pyDict);
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

            public RadiusNeighborsClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public RadiusNeighborsClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class RadiusNeighborsRegressor : PythonObject
        {
            public RadiusNeighborsRegressor(float radius = 1.0f, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (radius != 1.0f)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (weights != "uniform")
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.neighbors.self.InvokeMethod("RadiusNeighborsRegressor", args, pyDict);
            }

            internal RadiusNeighborsRegressor(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static RadiusNeighborsRegressor Encapsule(PyObject pyObject) => new RadiusNeighborsRegressor(pyObject);
            public static RadiusNeighborsRegressor Wrap(PyObject pyObject) => new RadiusNeighborsRegressor(pyObject);
            public string effective_metric_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_");
                    return __pyObject.As<string>();
                }
            }

            public PyDict effective_metric_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_params_");
                    return new PyDict(__pyObject);
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

            public int n_samples_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_samples_fit_");
                    return __pyObject.As<int>();
                }
            }

            public RadiusNeighborsRegressor fit(NDarray X, NDarray y)
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

            public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("radius_neighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("radius_neighbors_graph", args, pyDict);
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

            public RadiusNeighborsRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public RadiusNeighborsRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class RadiusNeighborsTransformer : PythonObject
        {
            public RadiusNeighborsTransformer(string mode = "distance", float radius = 1.0f, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
            {
                _ = sklearn.neighbors.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (mode != "distance")
                    pyDict["mode"] = Helpers.ToPython(mode);
                if (radius != 1.0f)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.neighbors.self.InvokeMethod("RadiusNeighborsTransformer", args, pyDict);
            }

            internal RadiusNeighborsTransformer(PyObject pyObject)
            {
                _ = sklearn.neighbors.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static RadiusNeighborsTransformer Encapsule(PyObject pyObject) => new RadiusNeighborsTransformer(pyObject);
            public static RadiusNeighborsTransformer Wrap(PyObject pyObject) => new RadiusNeighborsTransformer(pyObject);
            public string effective_metric_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_");
                    return __pyObject.As<string>();
                }
            }

            public PyDict effective_metric_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("effective_metric_params_");
                    return new PyDict(__pyObject);
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

            public int n_samples_fit_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_samples_fit_");
                    return __pyObject.As<int>();
                }
            }

            public RadiusNeighborsTransformer fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
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

            public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (return_distance != true)
                    pyDict["return_distance"] = Helpers.ToPython(return_distance);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("radius_neighbors", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }

            public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (mode != "connectivity")
                    pyDict["mode"] = Helpers.ToPython(mode);
                if (sort_results != false)
                    pyDict["sort_results"] = Helpers.ToPython(sort_results);
                var __pyObject = self.InvokeMethod("radius_neighbors_graph", args, pyDict);
                return new NDarray(__pyObject);
            }

            public RadiusNeighborsTransformer set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public RadiusNeighborsTransformer set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
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
    }
}