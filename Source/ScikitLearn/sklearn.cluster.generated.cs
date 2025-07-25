using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class cluster
        {
            public static (NDarray cluster_centers_indices, NDarray labels, int? n_iter) affinity_propagation(NDarray S, NDarray? preference = null, int convergence_iter = 15, int max_iter = 200, float damping = 0.5f, bool copy = true, bool verbose = false, bool return_n_iter = false, int? random_state = null)
            {
                throw new NotImplementedException();
            }

            public static NDarray cluster_optics_dbscan(NDarray reachability, NDarray core_distances, NDarray ordering, float eps)
            {
                throw new NotImplementedException();
            }

            public static (NDarray labels, NDarray clusters) cluster_optics_xi(NDarray reachability, NDarray predecessor, NDarray ordering, float min_samples, float? min_cluster_size = null, float xi = 0.05f, bool predecessor_correction = true)
            {
                throw new NotImplementedException();
            }

            public static (NDarray ordering_, NDarray core_distances_, NDarray reachability_, NDarray predecessor_) compute_optics_graph(NDarray X, float min_samples, float max_eps = float.PositiveInfinity, string metric = "minkowski", float p = 2, PyDict? metric_params = null, string algorithm = "auto", int leaf_size = 30, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static (NDarray core_samples, NDarray labels) dbscan(NDarray X, float eps = 0.5f, int min_samples = 5, string metric = "minkowski", PyDict? metric_params = null, string algorithm = "auto", int leaf_size = 30, int p = 2, NDarray? sample_weight = null, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static float estimate_bandwidth(NDarray X, float quantile = 0.3f, int? n_samples = null, int? random_state = 0, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static (NDarray centroid, NDarray label, float inertia, int? best_n_iter) k_means(NDarray X, int n_clusters, NDarray? sample_weight = null, string init = "k-means++", string n_init = "auto", int max_iter = 300, bool verbose = false, float tol = 0.0001f, int? random_state = null, bool copy_x = true, string algorithm = "lloyd", bool return_n_iter = false)
            {
                throw new NotImplementedException();
            }

            public static (NDarray centers, NDarray indices) kmeans_plusplus(NDarray X, int n_clusters, NDarray? sample_weight = null, NDarray? x_squared_norms = null, int? random_state = null, int? n_local_trials = null)
            {
                throw new NotImplementedException();
            }

            public static (NDarray cluster_centers, NDarray labels) mean_shift(NDarray X, float? bandwidth = null, NDarray? seeds = null, bool bin_seeding = false, int min_bin_freq = 1, bool cluster_all = true, int max_iter = 300, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static NDarray spectral_clustering(NDarray affinity, int? n_clusters = null, int? n_components = null, string? eigen_solver = null, int? random_state = null, int n_init = 10, string eigen_tol = "auto", string assign_labels = "kmeans", bool verbose = false)
            {
                throw new NotImplementedException();
            }

            public static (NDarray children, int n_connected_components, int n_leaves, NDarray? parents, NDarray? distances) ward_tree(NDarray X, NDarray? connectivity = null, int? n_clusters = null, bool return_distance = false)
            {
                throw new NotImplementedException();
            }

            public class AffinityPropagation
            {
                public AffinityPropagation(float damping = 0.5f, int max_iter = 200, int convergence_iter = 15, bool copy = true, NDarray? preference = null, string affinity = "euclidean", bool verbose = false, int? random_state = null)
                {
                }

                public NDarray cluster_centers_indices_ => Helpers.ToCSharpNDarray(self.GetAttr("cluster_centers_indices_"));
                public NDarray cluster_centers_ => Helpers.ToCSharpNDarray(self.GetAttr("cluster_centers_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public NDarray affinity_matrix_ => Helpers.ToCSharpNDarray(self.GetAttr("affinity_matrix_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public AffinityPropagation fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public AffinityPropagation set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class AgglomerativeClustering
            {
                public AgglomerativeClustering(int? n_clusters = 2, string metric = "euclidean", PyObject? memory = null, NDarray? connectivity = null, string compute_full_tree = "auto", string linkage = "ward", float? distance_threshold = null, bool compute_distances = false)
                {
                }

                public int n_clusters_ => Helpers.ToCSharpNDarray(self.GetAttr("n_clusters_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public int n_leaves_ => Helpers.ToCSharpNDarray(self.GetAttr("n_leaves_"));
                public int n_connected_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_connected_components_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray children_ => Helpers.ToCSharpNDarray(self.GetAttr("children_"));
                public NDarray distances_ => Helpers.ToCSharpNDarray(self.GetAttr("distances_"));

                public AgglomerativeClustering fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public AgglomerativeClustering set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class Birch
            {
                public Birch(float threshold = 0.5f, int branching_factor = 50, int? n_clusters = 3, bool compute_labels = true, bool copy = true)
                {
                }

                public PyObject root_ => Helpers.ToCSharpNDarray(self.GetAttr("root_"));
                public PyObject dummy_leaf_ => Helpers.ToCSharpNDarray(self.GetAttr("dummy_leaf_"));
                public NDarray subcluster_centers_ => Helpers.ToCSharpNDarray(self.GetAttr("subcluster_centers_"));
                public NDarray subcluster_labels_ => Helpers.ToCSharpNDarray(self.GetAttr("subcluster_labels_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Birch fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public Birch partial_fit(NDarray? X = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public Birch set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public Birch set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class BisectingKMeans
            {
                public BisectingKMeans(int n_clusters = 8, string init = "random", int n_init = 1, int? random_state = null, int max_iter = 300, int verbose = 0, float tol = 0.0001f, bool copy_x = true, string algorithm = "lloyd", string bisecting_strategy = "biggest_inertia")
                {
                }

                public NDarray cluster_centers_ => Helpers.ToCSharpNDarray(self.GetAttr("cluster_centers_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public float inertia_ => Helpers.ToCSharpNDarray(self.GetAttr("inertia_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public BisectingKMeans fit(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public BisectingKMeans set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public BisectingKMeans set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public BisectingKMeans set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public BisectingKMeans set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class DBSCAN
            {
                public DBSCAN(float eps = 0.5f, int min_samples = 5, string metric = "euclidean", PyDict? metric_params = null, string algorithm = "auto", int leaf_size = 30, float? p = null, int? n_jobs = null)
                {
                }

                public NDarray core_sample_indices_ => Helpers.ToCSharpNDarray(self.GetAttr("core_sample_indices_"));
                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public DBSCAN fit(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public DBSCAN set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DBSCAN set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class FeatureAgglomeration
            {
                public FeatureAgglomeration(int? n_clusters = 2, string metric = "euclidean", PyObject? memory = null, NDarray? connectivity = null, string compute_full_tree = "auto", string linkage = "ward", PyObject? pooling_func = null, float? distance_threshold = null, bool compute_distances = false)
                {
                }

                public int n_clusters_ => Helpers.ToCSharpNDarray(self.GetAttr("n_clusters_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public int n_leaves_ => Helpers.ToCSharpNDarray(self.GetAttr("n_leaves_"));
                public int n_connected_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_connected_components_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray children_ => Helpers.ToCSharpNDarray(self.GetAttr("children_"));
                public NDarray distances_ => Helpers.ToCSharpNDarray(self.GetAttr("distances_"));

                public FeatureAgglomeration fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null)
                {
                    throw new NotImplementedException();
                }

                public FeatureAgglomeration set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public FeatureAgglomeration set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class HDBSCAN
            {
                public HDBSCAN(int min_cluster_size = 5, int? min_samples = null, float cluster_selection_epsilon = 0.0f, int? max_cluster_size = null, string metric = "euclidean", PyDict? metric_params = null, float alpha = 1.0f, string algorithm = "auto", int leaf_size = 40, int? n_jobs = null, string cluster_selection_method = "eom", bool allow_single_cluster = false, string? store_centers = null, bool copy = false)
                {
                }

                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public NDarray probabilities_ => Helpers.ToCSharpNDarray(self.GetAttr("probabilities_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray centroids_ => Helpers.ToCSharpNDarray(self.GetAttr("centroids_"));
                public NDarray medoids_ => Helpers.ToCSharpNDarray(self.GetAttr("medoids_"));

                public NDarray dbscan_clustering(float cut_distance, int min_cluster_size = 5)
                {
                    throw new NotImplementedException();
                }

                public HDBSCAN fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public HDBSCAN set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class KMeans
            {
                public KMeans(int n_clusters = 8, string init = "k-means++", string n_init = "auto", int max_iter = 300, float tol = 0.0001f, int verbose = 0, int? random_state = null, bool copy_x = true, string algorithm = "lloyd")
                {
                }

                public NDarray cluster_centers_ => Helpers.ToCSharpNDarray(self.GetAttr("cluster_centers_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public float inertia_ => Helpers.ToCSharpNDarray(self.GetAttr("inertia_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public KMeans fit(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public KMeans set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public KMeans set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public KMeans set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public KMeans set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MeanShift
            {
                public MeanShift(float? bandwidth = null, NDarray? seeds = null, bool bin_seeding = false, int min_bin_freq = 1, bool cluster_all = true, int? n_jobs = null, int max_iter = 300)
                {
                }

                public NDarray cluster_centers_ => Helpers.ToCSharpNDarray(self.GetAttr("cluster_centers_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MeanShift fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public MeanShift set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class MiniBatchKMeans
            {
                public MiniBatchKMeans(int n_clusters = 8, string init = "k-means++", int max_iter = 100, int batch_size = 1024, int verbose = 0, bool compute_labels = true, int? random_state = null, float tol = 0.0f, int max_no_improvement = 10, int? init_size = null, string n_init = "auto", float reassignment_ratio = 0.01f)
                {
                }

                public NDarray cluster_centers_ => Helpers.ToCSharpNDarray(self.GetAttr("cluster_centers_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public float inertia_ => Helpers.ToCSharpNDarray(self.GetAttr("inertia_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_steps_ => Helpers.ToCSharpNDarray(self.GetAttr("n_steps_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public MiniBatchKMeans fit(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchKMeans partial_fit(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchKMeans set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public MiniBatchKMeans set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchKMeans set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public MiniBatchKMeans set_partial_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public MiniBatchKMeans set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class OPTICS
            {
                public OPTICS(int min_samples = 5, float max_eps = float.PositiveInfinity, string metric = "minkowski", int p = 2, PyDict? metric_params = null, string cluster_method = "xi", float? eps = null, float xi = 0.05f, bool predecessor_correction = true, float? min_cluster_size = null, string algorithm = "auto", int leaf_size = 30, PyObject? memory = null, int? n_jobs = null)
                {
                }

                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public NDarray reachability_ => Helpers.ToCSharpNDarray(self.GetAttr("reachability_"));
                public NDarray ordering_ => Helpers.ToCSharpNDarray(self.GetAttr("ordering_"));
                public NDarray core_distances_ => Helpers.ToCSharpNDarray(self.GetAttr("core_distances_"));
                public NDarray predecessor_ => Helpers.ToCSharpNDarray(self.GetAttr("predecessor_"));
                public NDarray cluster_hierarchy_ => Helpers.ToCSharpNDarray(self.GetAttr("cluster_hierarchy_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public OPTICS fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public OPTICS set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class SpectralBiclustering
            {
                public SpectralBiclustering(int n_clusters = 3, string method = "bistochastic", int n_components = 6, int n_best = 3, string svd_method = "randomized", int? n_svd_vecs = null, bool mini_batch = false, string init = "k-means++", int n_init = 10, int? random_state = null)
                {
                }

                public NDarray rows_ => Helpers.ToCSharpNDarray(self.GetAttr("rows_"));
                public NDarray columns_ => Helpers.ToCSharpNDarray(self.GetAttr("columns_"));
                public NDarray row_labels_ => Helpers.ToCSharpNDarray(self.GetAttr("row_labels_"));
                public NDarray column_labels_ => Helpers.ToCSharpNDarray(self.GetAttr("column_labels_"));
                public NDarray biclusters_ => Helpers.ToCSharpNDarray(self.GetAttr("biclusters_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SpectralBiclustering fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray<long>? , NDarray<long>? ) get_indices(int i)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public (int? , int? ) get_shape(int i)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_submatrix(int i, NDarray data)
                {
                    throw new NotImplementedException();
                }

                public SpectralBiclustering set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class SpectralClustering
            {
                public SpectralClustering(int n_clusters = 8, PyObject? eigen_solver = null, int? n_components = null, int? random_state = null, int n_init = 10, float gamma = 1.0f, string affinity = "rbf", int n_neighbors = 10, string eigen_tol = "auto", string assign_labels = "kmeans", int degree = 3, int coef0 = 1, PyDict? kernel_params = null, int? n_jobs = null, bool verbose = false)
                {
                }

                public NDarray affinity_matrix_ => Helpers.ToCSharpNDarray(self.GetAttr("affinity_matrix_"));
                public NDarray labels_ => Helpers.ToCSharpNDarray(self.GetAttr("labels_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SpectralClustering fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public SpectralClustering set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class SpectralCoclustering
            {
                public SpectralCoclustering(int n_clusters = 3, string svd_method = "randomized", int? n_svd_vecs = null, bool mini_batch = false, string init = "k-means++", int n_init = 10, int? random_state = null)
                {
                }

                public NDarray rows_ => Helpers.ToCSharpNDarray(self.GetAttr("rows_"));
                public NDarray columns_ => Helpers.ToCSharpNDarray(self.GetAttr("columns_"));
                public NDarray row_labels_ => Helpers.ToCSharpNDarray(self.GetAttr("row_labels_"));
                public NDarray column_labels_ => Helpers.ToCSharpNDarray(self.GetAttr("column_labels_"));
                public NDarray biclusters_ => Helpers.ToCSharpNDarray(self.GetAttr("biclusters_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SpectralCoclustering fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray<long>? , NDarray<long>? ) get_indices(int i)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public (int? , int? ) get_shape(int i)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_submatrix(int i, NDarray data)
                {
                    throw new NotImplementedException();
                }

                public SpectralCoclustering set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}