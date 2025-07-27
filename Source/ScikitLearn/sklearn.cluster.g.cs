namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class cluster
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
            return Py.Import("sklearn.cluster");
        }

        static cluster()
        {
            ReInitializeLazySelf();
        }

        public static (NDarray cluster_centers_indices, NDarray labels, int? n_iter) affinity_propagation(NDarray S, NDarray? preference = null, int convergence_iter = 15, int max_iter = 200, float damping = 0.5f, bool copy = true, bool verbose = false, bool return_n_iter = false, int? random_state = null)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(S) });
            PyDict pyDict = new PyDict();
            if (preference != null)
                pyDict["preference"] = Helpers.ToPython(preference);
            if (convergence_iter != 15)
                pyDict["convergence_iter"] = Helpers.ToPython(convergence_iter);
            if (max_iter != 200)
                pyDict["max_iter"] = Helpers.ToPython(max_iter);
            if (damping != 0.5f)
                pyDict["damping"] = Helpers.ToPython(damping);
            if (copy != true)
                pyDict["copy"] = Helpers.ToPython(copy);
            if (verbose != false)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (return_n_iter != false)
                pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            return new NotImplementedException();
        }

        public static NDarray cluster_optics_dbscan(NDarray reachability, NDarray core_distances, NDarray ordering, float eps)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(reachability), Helpers.ToPython(core_distances), Helpers.ToPython(ordering), Helpers.ToPython(eps) });
            PyDict pyDict = new PyDict();
            return new NotImplementedException();
        }

        public static (NDarray labels, NDarray clusters) cluster_optics_xi(NDarray reachability, NDarray predecessor, NDarray ordering, float min_samples, float? min_cluster_size = null, float xi = 0.05f, bool predecessor_correction = true)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(reachability), Helpers.ToPython(predecessor), Helpers.ToPython(ordering), Helpers.ToPython(min_samples) });
            PyDict pyDict = new PyDict();
            if (min_cluster_size != null)
                pyDict["min_cluster_size"] = Helpers.ToPython(min_cluster_size);
            if (xi != 0.05f)
                pyDict["xi"] = Helpers.ToPython(xi);
            if (predecessor_correction != true)
                pyDict["predecessor_correction"] = Helpers.ToPython(predecessor_correction);
            return new NotImplementedException();
        }

        public static (NDarray ordering_, NDarray core_distances_, NDarray reachability_, NDarray predecessor_) compute_optics_graph(NDarray X, float min_samples, float max_eps = float.PositiveInfinity, string metric = "minkowski", float p = 2, PyDict? metric_params = null, string algorithm = "auto", int leaf_size = 30, int? n_jobs = null)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(min_samples) });
            PyDict pyDict = new PyDict();
            if (max_eps != float.PositiveInfinity)
                pyDict["max_eps"] = Helpers.ToPython(max_eps);
            if (metric != "minkowski")
                pyDict["metric"] = Helpers.ToPython(metric);
            if (p != 2)
                pyDict["p"] = Helpers.ToPython(p);
            if (metric_params != null)
                pyDict["metric_params"] = Helpers.ToPython(metric_params);
            if (algorithm != "auto")
                pyDict["algorithm"] = Helpers.ToPython(algorithm);
            if (leaf_size != 30)
                pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            return new NotImplementedException();
        }

        public static (NDarray core_samples, NDarray labels) dbscan(NDarray X, float eps = 0.5f, int min_samples = 5, string metric = "minkowski", PyDict? metric_params = null, string algorithm = "auto", int leaf_size = 30, int p = 2, NDarray? sample_weight = null, int? n_jobs = null)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (eps != 0.5f)
                pyDict["eps"] = Helpers.ToPython(eps);
            if (min_samples != 5)
                pyDict["min_samples"] = Helpers.ToPython(min_samples);
            if (metric != "minkowski")
                pyDict["metric"] = Helpers.ToPython(metric);
            if (metric_params != null)
                pyDict["metric_params"] = Helpers.ToPython(metric_params);
            if (algorithm != "auto")
                pyDict["algorithm"] = Helpers.ToPython(algorithm);
            if (leaf_size != 30)
                pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
            if (p != 2)
                pyDict["p"] = Helpers.ToPython(p);
            if (sample_weight != null)
                pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            return new NotImplementedException();
        }

        public static float estimate_bandwidth(NDarray X, float quantile = 0.3f, int? n_samples = null, int? random_state = 0, int? n_jobs = null)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (quantile != 0.3f)
                pyDict["quantile"] = Helpers.ToPython(quantile);
            if (n_samples != null)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (random_state != 0)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            return self.InvokeMethod("estimate_bandwidth", args, pyDict).As<float>()}

        public static (NDarray centroid, NDarray label, float inertia, int? best_n_iter) k_means(NDarray X, int n_clusters, NDarray? sample_weight = null, string init = "k-means++", string n_init = "auto", int max_iter = 300, bool verbose = false, float tol = 0.0001f, int? random_state = null, bool copy_x = true, string algorithm = "lloyd", bool return_n_iter = false)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(n_clusters) });
            PyDict pyDict = new PyDict();
            if (sample_weight != null)
                pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
            if (init != "k-means++")
                pyDict["init"] = Helpers.ToPython(init);
            if (n_init != "auto")
                pyDict["n_init"] = Helpers.ToPython(n_init);
            if (max_iter != 300)
                pyDict["max_iter"] = Helpers.ToPython(max_iter);
            if (verbose != false)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (tol != 0.0001f)
                pyDict["tol"] = Helpers.ToPython(tol);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (copy_x != true)
                pyDict["copy_x"] = Helpers.ToPython(copy_x);
            if (algorithm != "lloyd")
                pyDict["algorithm"] = Helpers.ToPython(algorithm);
            if (return_n_iter != false)
                pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
            return new NotImplementedException();
        }

        public static (NDarray centers, NDarray indices) kmeans_plusplus(NDarray X, int n_clusters, NDarray? sample_weight = null, NDarray? x_squared_norms = null, int? random_state = null, int? n_local_trials = null)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(n_clusters) });
            PyDict pyDict = new PyDict();
            if (sample_weight != null)
                pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
            if (x_squared_norms != null)
                pyDict["x_squared_norms"] = Helpers.ToPython(x_squared_norms);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (n_local_trials != null)
                pyDict["n_local_trials"] = Helpers.ToPython(n_local_trials);
            return new NotImplementedException();
        }

        public static (NDarray cluster_centers, NDarray labels) mean_shift(NDarray X, float? bandwidth = null, NDarray? seeds = null, bool bin_seeding = false, int min_bin_freq = 1, bool cluster_all = true, int max_iter = 300, int? n_jobs = null)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (bandwidth != null)
                pyDict["bandwidth"] = Helpers.ToPython(bandwidth);
            if (seeds != null)
                pyDict["seeds"] = Helpers.ToPython(seeds);
            if (bin_seeding != false)
                pyDict["bin_seeding"] = Helpers.ToPython(bin_seeding);
            if (min_bin_freq != 1)
                pyDict["min_bin_freq"] = Helpers.ToPython(min_bin_freq);
            if (cluster_all != true)
                pyDict["cluster_all"] = Helpers.ToPython(cluster_all);
            if (max_iter != 300)
                pyDict["max_iter"] = Helpers.ToPython(max_iter);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            return new NotImplementedException();
        }

        public static NDarray spectral_clustering(NDarray affinity, int? n_clusters = null, int? n_components = null, string? eigen_solver = null, int? random_state = null, int n_init = 10, string eigen_tol = "auto", string assign_labels = "kmeans", bool verbose = false)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(affinity) });
            PyDict pyDict = new PyDict();
            if (n_clusters != null)
                pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
            if (n_components != null)
                pyDict["n_components"] = Helpers.ToPython(n_components);
            if (eigen_solver != null)
                pyDict["eigen_solver"] = Helpers.ToPython(eigen_solver);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (n_init != 10)
                pyDict["n_init"] = Helpers.ToPython(n_init);
            if (eigen_tol != "auto")
                pyDict["eigen_tol"] = Helpers.ToPython(eigen_tol);
            if (assign_labels != "kmeans")
                pyDict["assign_labels"] = Helpers.ToPython(assign_labels);
            if (verbose != false)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            return new NotImplementedException();
        }

        public static (NDarray children, int n_connected_components, int n_leaves, NDarray? parents, NDarray? distances) ward_tree(NDarray X, NDarray? connectivity = null, int? n_clusters = null, bool return_distance = false)
        {
            _ = sklearn.cluster.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (connectivity != null)
                pyDict["connectivity"] = Helpers.ToPython(connectivity);
            if (n_clusters != null)
                pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
            if (return_distance != false)
                pyDict["return_distance"] = Helpers.ToPython(return_distance);
            return new NotImplementedException();
        }

        public class AffinityPropagation : PythonObject
        {
            public AffinityPropagation(float damping = 0.5f, int max_iter = 200, int convergence_iter = 15, bool copy = true, NDarray? preference = null, string affinity = "euclidean", bool verbose = false, int? random_state = null)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (damping != 0.5f)
                    pyDict["damping"] = Helpers.ToPython(damping);
                if (max_iter != 200)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (convergence_iter != 15)
                    pyDict["convergence_iter"] = Helpers.ToPython(convergence_iter);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                if (preference != null)
                    pyDict["preference"] = Helpers.ToPython(preference);
                if (affinity != "euclidean")
                    pyDict["affinity"] = Helpers.ToPython(affinity);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.cluster.self.InvokeMethod("AffinityPropagation", args, pyDict);
            }

            internal AffinityPropagation(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static AffinityPropagation Encapsule(PyObject pyObject) => new AffinityPropagation(pyObject);
            public static AffinityPropagation Wrap(PyObject pyObject) => new AffinityPropagation(pyObject);
            public NDarray cluster_centers_indices_ => new NotImplementedException();
            public NDarray cluster_centers_ => new NotImplementedException();
            public NDarray labels_ => new NotImplementedException();
            public NDarray affinity_matrix_ => new NotImplementedException();
            public int n_iter_ => self.GetAttr("n_iter_").As<int>()public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public AffinityPropagation fit(NDarray X)
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
                return new NotImplementedException();
            }

            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing()
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

            public AffinityPropagation set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class AgglomerativeClustering : PythonObject
        {
            public AgglomerativeClustering(int? n_clusters = 2, string metric = "euclidean", PyObject? memory = null, NDarray? connectivity = null, string compute_full_tree = "auto", string linkage = "ward", float? distance_threshold = null, bool compute_distances = false)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_clusters != 2)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (memory != null)
                    pyDict["memory"] = Helpers.ToPython(memory);
                if (connectivity != null)
                    pyDict["connectivity"] = Helpers.ToPython(connectivity);
                if (compute_full_tree != "auto")
                    pyDict["compute_full_tree"] = Helpers.ToPython(compute_full_tree);
                if (linkage != "ward")
                    pyDict["linkage"] = Helpers.ToPython(linkage);
                if (distance_threshold != null)
                    pyDict["distance_threshold"] = Helpers.ToPython(distance_threshold);
                if (compute_distances != false)
                    pyDict["compute_distances"] = Helpers.ToPython(compute_distances);
                self = sklearn.cluster.self.InvokeMethod("AgglomerativeClustering", args, pyDict);
            }

            internal AgglomerativeClustering(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static AgglomerativeClustering Encapsule(PyObject pyObject) => new AgglomerativeClustering(pyObject);
            public static AgglomerativeClustering Wrap(PyObject pyObject) => new AgglomerativeClustering(pyObject);
            public int n_clusters_ => self.GetAttr("n_clusters_").As<int>()public NDarray labels_ => new NotImplementedException();
            public int n_leaves_ => self.GetAttr("n_leaves_").As<int>()public int n_connected_components_ => self.GetAttr("n_connected_components_").As<int>()public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();
            public NDarray children_ => new NotImplementedException();
            public NDarray distances_ => new NotImplementedException();

            public AgglomerativeClustering fit(NDarray X)
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

            public AgglomerativeClustering set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class Birch : PythonObject
        {
            public Birch(float threshold = 0.5f, int branching_factor = 50, int? n_clusters = 3, bool compute_labels = true, bool copy = true)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (threshold != 0.5f)
                    pyDict["threshold"] = Helpers.ToPython(threshold);
                if (branching_factor != 50)
                    pyDict["branching_factor"] = Helpers.ToPython(branching_factor);
                if (n_clusters != 3)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (compute_labels != true)
                    pyDict["compute_labels"] = Helpers.ToPython(compute_labels);
                if (copy != true)
                    pyDict["copy"] = Helpers.ToPython(copy);
                self = sklearn.cluster.self.InvokeMethod("Birch", args, pyDict);
            }

            internal Birch(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static Birch Encapsule(PyObject pyObject) => new Birch(pyObject);
            public static Birch Wrap(PyObject pyObject) => new Birch(pyObject);
            public PyObject root_ => new NotImplementedException();
            public PyObject dummy_leaf_ => new NotImplementedException();
            public NDarray subcluster_centers_ => new NotImplementedException();
            public NDarray subcluster_labels_ => new NotImplementedException();
            public NDarray labels_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public Birch fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return new NotImplementedException();
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

            public Birch partial_fit(NDarray? X = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                self.InvokeMethod("partial_fit", args, pyDict);
                return this;
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public Birch set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public Birch set_params(Dictionary<string, PyObject>? @params = null)
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
                return new NotImplementedException();
            }
        }

        public class BisectingKMeans : PythonObject
        {
            public BisectingKMeans(int n_clusters = 8, string init = "random", int n_init = 1, int? random_state = null, int max_iter = 300, int verbose = 0, float tol = 0.0001f, bool copy_x = true, string algorithm = "lloyd", string bisecting_strategy = "biggest_inertia")
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_clusters != 8)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (init != "random")
                    pyDict["init"] = Helpers.ToPython(init);
                if (n_init != 1)
                    pyDict["n_init"] = Helpers.ToPython(n_init);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (max_iter != 300)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (copy_x != true)
                    pyDict["copy_x"] = Helpers.ToPython(copy_x);
                if (algorithm != "lloyd")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (bisecting_strategy != "biggest_inertia")
                    pyDict["bisecting_strategy"] = Helpers.ToPython(bisecting_strategy);
                self = sklearn.cluster.self.InvokeMethod("BisectingKMeans", args, pyDict);
            }

            internal BisectingKMeans(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static BisectingKMeans Encapsule(PyObject pyObject) => new BisectingKMeans(pyObject);
            public static BisectingKMeans Wrap(PyObject pyObject) => new BisectingKMeans(pyObject);
            public NDarray cluster_centers_ => new NotImplementedException();
            public NDarray labels_ => new NotImplementedException();
            public float inertia_ => self.GetAttr("inertia_").As<float>()public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public BisectingKMeans fit(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public float score(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

            public BisectingKMeans set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public BisectingKMeans set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public BisectingKMeans set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public BisectingKMeans set_score_request(string? sample_weight = "$UNCHANGED$")
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

        public class DBSCAN : PythonObject
        {
            public DBSCAN(float eps = 0.5f, int min_samples = 5, string metric = "euclidean", PyDict? metric_params = null, string algorithm = "auto", int leaf_size = 30, float? p = null, int? n_jobs = null)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (eps != 0.5f)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (min_samples != 5)
                    pyDict["min_samples"] = Helpers.ToPython(min_samples);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (p != null)
                    pyDict["p"] = Helpers.ToPython(p);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.cluster.self.InvokeMethod("DBSCAN", args, pyDict);
            }

            internal DBSCAN(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static DBSCAN Encapsule(PyObject pyObject) => new DBSCAN(pyObject);
            public static DBSCAN Wrap(PyObject pyObject) => new DBSCAN(pyObject);
            public NDarray core_sample_indices_ => new NotImplementedException();
            public NDarray components_ => new NotImplementedException();
            public NDarray labels_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public DBSCAN fit(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public DBSCAN set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public DBSCAN set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class FeatureAgglomeration : PythonObject
        {
            public FeatureAgglomeration(int? n_clusters = 2, string metric = "euclidean", PyObject? memory = null, NDarray? connectivity = null, string compute_full_tree = "auto", string linkage = "ward", PyObject? pooling_func = null, float? distance_threshold = null, bool compute_distances = false)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_clusters != 2)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (memory != null)
                    pyDict["memory"] = Helpers.ToPython(memory);
                if (connectivity != null)
                    pyDict["connectivity"] = Helpers.ToPython(connectivity);
                if (compute_full_tree != "auto")
                    pyDict["compute_full_tree"] = Helpers.ToPython(compute_full_tree);
                if (linkage != "ward")
                    pyDict["linkage"] = Helpers.ToPython(linkage);
                if (pooling_func != null)
                    pyDict["pooling_func"] = Helpers.ToPython(pooling_func);
                if (distance_threshold != null)
                    pyDict["distance_threshold"] = Helpers.ToPython(distance_threshold);
                if (compute_distances != false)
                    pyDict["compute_distances"] = Helpers.ToPython(compute_distances);
                self = sklearn.cluster.self.InvokeMethod("FeatureAgglomeration", args, pyDict);
            }

            internal FeatureAgglomeration(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static FeatureAgglomeration Encapsule(PyObject pyObject) => new FeatureAgglomeration(pyObject);
            public static FeatureAgglomeration Wrap(PyObject pyObject) => new FeatureAgglomeration(pyObject);
            public int n_clusters_ => self.GetAttr("n_clusters_").As<int>()public NDarray labels_ => new NotImplementedException();
            public int n_leaves_ => self.GetAttr("n_leaves_").As<int>()public int n_connected_components_ => self.GetAttr("n_connected_components_").As<int>()public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();
            public NDarray children_ => new NotImplementedException();
            public NDarray distances_ => new NotImplementedException();

            public FeatureAgglomeration fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
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

            public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (Xt != null)
                    pyDict["Xt"] = Helpers.ToPython(Xt);
                return new NotImplementedException();
            }

            public FeatureAgglomeration set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public FeatureAgglomeration set_params(Dictionary<string, PyObject>? @params = null)
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
                return new NotImplementedException();
            }
        }

        public class HDBSCAN : PythonObject
        {
            public HDBSCAN(int min_cluster_size = 5, int? min_samples = null, float cluster_selection_epsilon = 0.0f, int? max_cluster_size = null, string metric = "euclidean", PyDict? metric_params = null, float alpha = 1.0f, string algorithm = "auto", int leaf_size = 40, int? n_jobs = null, string cluster_selection_method = "eom", bool allow_single_cluster = false, string? store_centers = null, bool copy = false)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (min_cluster_size != 5)
                    pyDict["min_cluster_size"] = Helpers.ToPython(min_cluster_size);
                if (min_samples != null)
                    pyDict["min_samples"] = Helpers.ToPython(min_samples);
                if (cluster_selection_epsilon != 0.0f)
                    pyDict["cluster_selection_epsilon"] = Helpers.ToPython(cluster_selection_epsilon);
                if (max_cluster_size != null)
                    pyDict["max_cluster_size"] = Helpers.ToPython(max_cluster_size);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (alpha != 1.0f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 40)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (cluster_selection_method != "eom")
                    pyDict["cluster_selection_method"] = Helpers.ToPython(cluster_selection_method);
                if (allow_single_cluster != false)
                    pyDict["allow_single_cluster"] = Helpers.ToPython(allow_single_cluster);
                if (store_centers != null)
                    pyDict["store_centers"] = Helpers.ToPython(store_centers);
                if (copy != false)
                    pyDict["copy"] = Helpers.ToPython(copy);
                self = sklearn.cluster.self.InvokeMethod("HDBSCAN", args, pyDict);
            }

            internal HDBSCAN(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static HDBSCAN Encapsule(PyObject pyObject) => new HDBSCAN(pyObject);
            public static HDBSCAN Wrap(PyObject pyObject) => new HDBSCAN(pyObject);
            public NDarray labels_ => new NotImplementedException();
            public NDarray probabilities_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();
            public NDarray centroids_ => new NotImplementedException();
            public NDarray medoids_ => new NotImplementedException();

            public NDarray dbscan_clustering(float cut_distance, int min_cluster_size = 5)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(cut_distance) });
                PyDict pyDict = new PyDict();
                if (min_cluster_size != 5)
                    pyDict["min_cluster_size"] = Helpers.ToPython(min_cluster_size);
                return new NotImplementedException();
            }

            public HDBSCAN fit(NDarray X, PyObject? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X, PyObject? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public HDBSCAN set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class KMeans : PythonObject
        {
            public KMeans(int n_clusters = 8, string init = "k-means++", string n_init = "auto", int max_iter = 300, float tol = 0.0001f, int verbose = 0, int? random_state = null, bool copy_x = true, string algorithm = "lloyd")
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_clusters != 8)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (init != "k-means++")
                    pyDict["init"] = Helpers.ToPython(init);
                if (n_init != "auto")
                    pyDict["n_init"] = Helpers.ToPython(n_init);
                if (max_iter != 300)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (tol != 0.0001f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (copy_x != true)
                    pyDict["copy_x"] = Helpers.ToPython(copy_x);
                if (algorithm != "lloyd")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                self = sklearn.cluster.self.InvokeMethod("KMeans", args, pyDict);
            }

            internal KMeans(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static KMeans Encapsule(PyObject pyObject) => new KMeans(pyObject);
            public static KMeans Wrap(PyObject pyObject) => new KMeans(pyObject);
            public NDarray cluster_centers_ => new NotImplementedException();
            public NDarray labels_ => new NotImplementedException();
            public float inertia_ => self.GetAttr("inertia_").As<float>()public int n_iter_ => self.GetAttr("n_iter_").As<int>()public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public KMeans fit(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public float score(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

            public KMeans set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public KMeans set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public KMeans set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public KMeans set_score_request(string? sample_weight = "$UNCHANGED$")
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

        public class MeanShift : PythonObject
        {
            public MeanShift(float? bandwidth = null, NDarray? seeds = null, bool bin_seeding = false, int min_bin_freq = 1, bool cluster_all = true, int? n_jobs = null, int max_iter = 300)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (bandwidth != null)
                    pyDict["bandwidth"] = Helpers.ToPython(bandwidth);
                if (seeds != null)
                    pyDict["seeds"] = Helpers.ToPython(seeds);
                if (bin_seeding != false)
                    pyDict["bin_seeding"] = Helpers.ToPython(bin_seeding);
                if (min_bin_freq != 1)
                    pyDict["min_bin_freq"] = Helpers.ToPython(min_bin_freq);
                if (cluster_all != true)
                    pyDict["cluster_all"] = Helpers.ToPython(cluster_all);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (max_iter != 300)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                self = sklearn.cluster.self.InvokeMethod("MeanShift", args, pyDict);
            }

            internal MeanShift(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static MeanShift Encapsule(PyObject pyObject) => new MeanShift(pyObject);
            public static MeanShift Wrap(PyObject pyObject) => new MeanShift(pyObject);
            public NDarray cluster_centers_ => new NotImplementedException();
            public NDarray labels_ => new NotImplementedException();
            public int n_iter_ => self.GetAttr("n_iter_").As<int>()public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public MeanShift fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public MeanShift set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class MiniBatchKMeans : PythonObject
        {
            public MiniBatchKMeans(int n_clusters = 8, string init = "k-means++", int max_iter = 100, int batch_size = 1024, int verbose = 0, bool compute_labels = true, int? random_state = null, float tol = 0.0f, int max_no_improvement = 10, int? init_size = null, string n_init = "auto", float reassignment_ratio = 0.01f)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_clusters != 8)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (init != "k-means++")
                    pyDict["init"] = Helpers.ToPython(init);
                if (max_iter != 100)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (batch_size != 1024)
                    pyDict["batch_size"] = Helpers.ToPython(batch_size);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (compute_labels != true)
                    pyDict["compute_labels"] = Helpers.ToPython(compute_labels);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (tol != 0.0f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (max_no_improvement != 10)
                    pyDict["max_no_improvement"] = Helpers.ToPython(max_no_improvement);
                if (init_size != null)
                    pyDict["init_size"] = Helpers.ToPython(init_size);
                if (n_init != "auto")
                    pyDict["n_init"] = Helpers.ToPython(n_init);
                if (reassignment_ratio != 0.01f)
                    pyDict["reassignment_ratio"] = Helpers.ToPython(reassignment_ratio);
                self = sklearn.cluster.self.InvokeMethod("MiniBatchKMeans", args, pyDict);
            }

            internal MiniBatchKMeans(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static MiniBatchKMeans Encapsule(PyObject pyObject) => new MiniBatchKMeans(pyObject);
            public static MiniBatchKMeans Wrap(PyObject pyObject) => new MiniBatchKMeans(pyObject);
            public NDarray cluster_centers_ => new NotImplementedException();
            public NDarray labels_ => new NotImplementedException();
            public float inertia_ => self.GetAttr("inertia_").As<float>()public int n_iter_ => self.GetAttr("n_iter_").As<int>()public int n_steps_ => self.GetAttr("n_steps_").As<int>()public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public MiniBatchKMeans fit(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return new NotImplementedException();
            }

            public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
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

            public MiniBatchKMeans partial_fit(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("partial_fit", args, pyDict);
                return this;
            }

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public float score(NDarray X, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

            public MiniBatchKMeans set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public MiniBatchKMeans set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public MiniBatchKMeans set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public MiniBatchKMeans set_partial_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public MiniBatchKMeans set_score_request(string? sample_weight = "$UNCHANGED$")
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

        public class OPTICS : PythonObject
        {
            public OPTICS(int min_samples = 5, float max_eps = float.PositiveInfinity, string metric = "minkowski", int p = 2, PyDict? metric_params = null, string cluster_method = "xi", float? eps = null, float xi = 0.05f, bool predecessor_correction = true, float? min_cluster_size = null, string algorithm = "auto", int leaf_size = 30, PyObject? memory = null, int? n_jobs = null)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (min_samples != 5)
                    pyDict["min_samples"] = Helpers.ToPython(min_samples);
                if (max_eps != float.PositiveInfinity)
                    pyDict["max_eps"] = Helpers.ToPython(max_eps);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (cluster_method != "xi")
                    pyDict["cluster_method"] = Helpers.ToPython(cluster_method);
                if (eps != null)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (xi != 0.05f)
                    pyDict["xi"] = Helpers.ToPython(xi);
                if (predecessor_correction != true)
                    pyDict["predecessor_correction"] = Helpers.ToPython(predecessor_correction);
                if (min_cluster_size != null)
                    pyDict["min_cluster_size"] = Helpers.ToPython(min_cluster_size);
                if (algorithm != "auto")
                    pyDict["algorithm"] = Helpers.ToPython(algorithm);
                if (leaf_size != 30)
                    pyDict["leaf_size"] = Helpers.ToPython(leaf_size);
                if (memory != null)
                    pyDict["memory"] = Helpers.ToPython(memory);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.cluster.self.InvokeMethod("OPTICS", args, pyDict);
            }

            internal OPTICS(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static OPTICS Encapsule(PyObject pyObject) => new OPTICS(pyObject);
            public static OPTICS Wrap(PyObject pyObject) => new OPTICS(pyObject);
            public NDarray labels_ => new NotImplementedException();
            public NDarray reachability_ => new NotImplementedException();
            public NDarray ordering_ => new NotImplementedException();
            public NDarray core_distances_ => new NotImplementedException();
            public NDarray predecessor_ => new NotImplementedException();
            public NDarray cluster_hierarchy_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public OPTICS fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public OPTICS set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class SpectralBiclustering : PythonObject
        {
            public SpectralBiclustering(int n_clusters = 3, string method = "bistochastic", int n_components = 6, int n_best = 3, string svd_method = "randomized", int? n_svd_vecs = null, bool mini_batch = false, string init = "k-means++", int n_init = 10, int? random_state = null)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_clusters != 3)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (method != "bistochastic")
                    pyDict["method"] = Helpers.ToPython(method);
                if (n_components != 6)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (n_best != 3)
                    pyDict["n_best"] = Helpers.ToPython(n_best);
                if (svd_method != "randomized")
                    pyDict["svd_method"] = Helpers.ToPython(svd_method);
                if (n_svd_vecs != null)
                    pyDict["n_svd_vecs"] = Helpers.ToPython(n_svd_vecs);
                if (mini_batch != false)
                    pyDict["mini_batch"] = Helpers.ToPython(mini_batch);
                if (init != "k-means++")
                    pyDict["init"] = Helpers.ToPython(init);
                if (n_init != 10)
                    pyDict["n_init"] = Helpers.ToPython(n_init);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.cluster.self.InvokeMethod("SpectralBiclustering", args, pyDict);
            }

            internal SpectralBiclustering(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static SpectralBiclustering Encapsule(PyObject pyObject) => new SpectralBiclustering(pyObject);
            public static SpectralBiclustering Wrap(PyObject pyObject) => new SpectralBiclustering(pyObject);
            public NDarray rows_ => new NotImplementedException();
            public NDarray columns_ => new NotImplementedException();
            public NDarray row_labels_ => new NotImplementedException();
            public NDarray column_labels_ => new NotImplementedException();
            public NDarray biclusters_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public SpectralBiclustering fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public (NDarray<long>? , NDarray<long>? ) get_indices(int i)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i) });
                PyDict pyDict = new PyDict();
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

            public (int? , int? ) get_shape(int i)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray get_submatrix(int i, NDarray data)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i), Helpers.ToPython(data) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public SpectralBiclustering set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class SpectralClustering : PythonObject
        {
            public SpectralClustering(int n_clusters = 8, PyObject? eigen_solver = null, int? n_components = null, int? random_state = null, int n_init = 10, float gamma = 1.0f, string affinity = "rbf", int n_neighbors = 10, string eigen_tol = "auto", string assign_labels = "kmeans", int degree = 3, int coef0 = 1, PyDict? kernel_params = null, int? n_jobs = null, bool verbose = false)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_clusters != 8)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (eigen_solver != null)
                    pyDict["eigen_solver"] = Helpers.ToPython(eigen_solver);
                if (n_components != null)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (n_init != 10)
                    pyDict["n_init"] = Helpers.ToPython(n_init);
                if (gamma != 1.0f)
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (affinity != "rbf")
                    pyDict["affinity"] = Helpers.ToPython(affinity);
                if (n_neighbors != 10)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (eigen_tol != "auto")
                    pyDict["eigen_tol"] = Helpers.ToPython(eigen_tol);
                if (assign_labels != "kmeans")
                    pyDict["assign_labels"] = Helpers.ToPython(assign_labels);
                if (degree != 3)
                    pyDict["degree"] = Helpers.ToPython(degree);
                if (coef0 != 1)
                    pyDict["coef0"] = Helpers.ToPython(coef0);
                if (kernel_params != null)
                    pyDict["kernel_params"] = Helpers.ToPython(kernel_params);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.cluster.self.InvokeMethod("SpectralClustering", args, pyDict);
            }

            internal SpectralClustering(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static SpectralClustering Encapsule(PyObject pyObject) => new SpectralClustering(pyObject);
            public static SpectralClustering Wrap(PyObject pyObject) => new SpectralClustering(pyObject);
            public NDarray affinity_matrix_ => new NotImplementedException();
            public NDarray labels_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public SpectralClustering fit(NDarray X)
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

            public SpectralClustering set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class SpectralCoclustering : PythonObject
        {
            public SpectralCoclustering(int n_clusters = 3, string svd_method = "randomized", int? n_svd_vecs = null, bool mini_batch = false, string init = "k-means++", int n_init = 10, int? random_state = null)
            {
                _ = sklearn.cluster.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_clusters != 3)
                    pyDict["n_clusters"] = Helpers.ToPython(n_clusters);
                if (svd_method != "randomized")
                    pyDict["svd_method"] = Helpers.ToPython(svd_method);
                if (n_svd_vecs != null)
                    pyDict["n_svd_vecs"] = Helpers.ToPython(n_svd_vecs);
                if (mini_batch != false)
                    pyDict["mini_batch"] = Helpers.ToPython(mini_batch);
                if (init != "k-means++")
                    pyDict["init"] = Helpers.ToPython(init);
                if (n_init != 10)
                    pyDict["n_init"] = Helpers.ToPython(n_init);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.cluster.self.InvokeMethod("SpectralCoclustering", args, pyDict);
            }

            internal SpectralCoclustering(PyObject pyObject)
            {
                _ = sklearn.cluster.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static SpectralCoclustering Encapsule(PyObject pyObject) => new SpectralCoclustering(pyObject);
            public static SpectralCoclustering Wrap(PyObject pyObject) => new SpectralCoclustering(pyObject);
            public NDarray rows_ => new NotImplementedException();
            public NDarray columns_ => new NotImplementedException();
            public NDarray row_labels_ => new NotImplementedException();
            public NDarray column_labels_ => new NotImplementedException();
            public NDarray biclusters_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public SpectralCoclustering fit(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public (NDarray<long>? , NDarray<long>? ) get_indices(int i)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i) });
                PyDict pyDict = new PyDict();
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

            public (int? , int? ) get_shape(int i)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray get_submatrix(int i, NDarray data)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i), Helpers.ToPython(data) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public SpectralCoclustering set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }
    }
}