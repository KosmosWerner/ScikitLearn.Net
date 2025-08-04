using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class cluster
    {
        // Methods
        [EnableItem(Item: "n_iter", If: "return_n_iter")]
        public static (NDarray cluster_centers_indices, NDarray labels, int? n_iter) affinity_propagation(
            NDarray S,
            [OneOf<float, NDarray>] object? preference = null,
            int convergence_iter = 15,
            int max_iter = 200,
            float damping = 0.5f,
            bool copy = true,
            bool verbose = false,
            bool return_n_iter = false,
            int? random_state = null) => default!;

        public static NDarray cluster_optics_dbscan(
            NDarray reachability,
            NDarray core_distances,
            NDarray ordering,
            float eps) => default!;

        public static (NDarray labels, NDarray clusters) cluster_optics_xi(
            NDarray reachability,
            NDarray predecessor,
            NDarray ordering,
            [OneOf<int, float>] object min_samples,
            [OneOf<int, float>] object? min_cluster_size = null,
            float xi = 0.05f,
            bool predecessor_correction = true) => default!;

        public static (NDarray ordering_, NDarray core_distances_, NDarray reachability_, NDarray predecessor_) compute_optics_graph(
            NDarray X,
            [OneOf<int, float>] object min_samples,
            float max_eps = float.PositiveInfinity,
            string metric = "minkowski",
            float p = 2,
            Dictionary<string, object>? metric_params = null,
            string algorithm = "auto",
            int leaf_size = 30,
            int? n_jobs = null) => default!;

        public static (NDarray core_samples, NDarray labels) dbscan(
            NDarray X,
            float eps = 0.5f,
            int min_samples = 5,
            string metric = "minkowski",
            Dictionary<string, object>? metric_params = null,
            string algorithm = "auto",
            int leaf_size = 30,
            int p = 2,
            NDarray? sample_weight = null,
            int? n_jobs = null) => default!;

        public static float estimate_bandwidth(
            NDarray X,
            float quantile = 0.3f,
            int? n_samples = null,
            int? random_state = 0,
            int? n_jobs = null) => default!;

        [EnableItem(Item: "best_n_iter", If: "return_n_iter")]
        public static (NDarray centroid, NDarray label, float inertia, int? best_n_iter) k_means(
            NDarray X,
            int n_clusters,
            NDarray? sample_weight = null,
            string init = "k-means++",
            string n_init = "auto",
            int max_iter = 300,
            bool verbose = false,
            float tol = 0.0001f,
            int? random_state = null,
            bool copy_x = true,
            string algorithm = "lloyd",
            bool return_n_iter = false) => default!;

        public static (NDarray centers, NDarray indices) kmeans_plusplus(
            NDarray X,
            int n_clusters,
            NDarray? sample_weight = null,
            NDarray? x_squared_norms = null,
            int? random_state = null,
            int? n_local_trials = null) => default!;

        public static (NDarray cluster_centers, NDarray labels) mean_shift(
            NDarray X,
            float? bandwidth = null,
            NDarray? seeds = null,
            bool bin_seeding = false,
            int min_bin_freq = 1,
            bool cluster_all = true,
            int max_iter = 300,
            int? n_jobs = null) => default!;

        public static NDarray spectral_clustering(
            NDarray affinity,
            int? n_clusters = null,
            int? n_components = null,
            string? eigen_solver = null,
            int? random_state = null,
            int n_init = 10,
            string eigen_tol = "auto",
            string assign_labels = "kmeans",
            bool verbose = false) => default!;

        [EnableItem(Item: "parents", If: "connectivity != null")]
        [EnableItem(Item: "distances", If: "return_distance")]
        public static (NDarray children, int n_connected_components, int n_leaves, NDarray? parents, NDarray? distances) ward_tree(
            NDarray X,
            NDarray? connectivity = null,
            int? n_clusters = null,
            bool return_distance = false) => default!;

        // Classes
        public class AffinityPropagation :
            @base.BaseEstimator<AffinityPropagation>,
            @base.ClusterMixin
        {
            // Constructor
            public AffinityPropagation(
                float damping = 0.5f,
                int max_iter = 200,
                int convergence_iter = 15,
                bool copy = true,
                [OneOf<float, NDarray>] object? preference = null,
                string affinity = "euclidean",
                bool verbose = false,
                int? random_state = null)
            { }

            // Properties
            public NDarray cluster_centers_indices_ => default!;
            public NDarray cluster_centers_ => default!;
            public NDarray labels_ => default!;
            public NDarray affinity_matrix_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public AffinityPropagation fit(NDarray X, [Ignored] NDarray? y = null) => default!;
            public NDarray<long> fit_predict(NDarray X, [Ignored] NDarray? y = null, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            [Self] public AffinityPropagation set_params(params (string key, object value)[] @params) => default!;
        }

        public class AgglomerativeClustering :
            @base.BaseEstimator<AgglomerativeClustering>,
            @base.ClusterMixin
        {
            // Constructor
            public AgglomerativeClustering(
                int? n_clusters = 2,
                string metric = "euclidean",
                [OneOf<string, joblib.memory.Memory>] object? memory = null,
                NDarray? connectivity = null,
                [OneOf<bool, string>(Default: "auto")] object compute_full_tree = default!,
                string linkage = "ward",
                float? distance_threshold = null,
                bool compute_distances = false)
            { }

            // Properties
            public int n_clusters_ => default!;
            public NDarray labels_ => default!;
            public int n_leaves_ => default!;
            public int n_connected_components_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray children_ => default!;
            public NDarray distances_ => default!;

            // Methods
            [Self] public AgglomerativeClustering fit(NDarray X, [Ignored] NDarray? y = null) => default!;
            public NDarray<long> fit_predict(NDarray X, [Ignored] NDarray? y = null, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public AgglomerativeClustering set_params(params (string key, object value)[] @params) => default!;
        }

        public class Birch :
            @base.ClassNamePrefixFeaturesOutMixin,
            @base.ClusterMixin,
            @base.TransformerMixin<Birch>,
            @base.BaseEstimator<Birch>
        {
            // Constructor
            public Birch(
                float threshold = 0.5f,
                int branching_factor = 50,
                [OneOf<int, @base.ClusterMixin>(Default: 3)] object? n_clusters = default!,
                bool compute_labels = true)
            { }

            // Properties
            public PyObject root_ => default!;
            public PyObject dummy_leaf_ => default!;
            public NDarray subcluster_centers_ => default!;
            public NDarray subcluster_labels_ => default!;
            public NDarray labels_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public Birch fit(NDarray X) => default!;
            public NDarray<long> fit_predict(NDarray X, [Ignored] NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self] public Birch partial_fit(NDarray? X = null) => default!;
            public NDarray predict(NDarray X) => default!;
            [Self] public Birch set_output(string? transform = null) => default!;
            [Self] public Birch set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        // Revision
        public class BisectingKMeans :
            @base.BaseKMeans<BisectingKMeans>
        {
            // Constructor
            public BisectingKMeans(
                int n_clusters = 8,
                string init = "random",
                int n_init = 1,
                int? random_state = null,
                int max_iter = 300,
                int verbose = 0,
                float tol = 0.0001f,
                bool copy_x = true,
                string algorithm = "lloyd",
                string bisecting_strategy = "biggest_inertia")
            { }

            // Properties
            public NDarray cluster_centers_ => default!;
            public NDarray labels_ => default!;
            public float inertia_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self] public BisectingKMeans fit(NDarray X, [Ignored] NDarray? y = null, NDarray? sample_weight = null) => default!;
            public NDarray fit_predict(NDarray X, [Ignored] NDarray? y = null, NDarray? sample_weight = null) => default!;
            //public NDarray<long> fit_predict(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, NDarray? sample_weight = null) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray? sample_weight = null) => default!;
            [Self] public BisectingKMeans set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self] public BisectingKMeans set_output(string? transform = null) => default!;
            [Self] public BisectingKMeans set_params(params (string key, object value)[] @params) => default!;
            [Self] public BisectingKMeans set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class DBSCAN : PythonObject,
            @base.ClusterMixin<DBSCAN>,
            @base.BaseEstimator<DBSCAN>

        {
            // Constructor
            public DBSCAN(float eps = 0.5f, int min_samples = 5, string metric = "euclidean", PyDict? metric_params = null, string algorithm = "auto", int leaf_size = 30, float? p = null, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray core_sample_indices_ => default!;
            public NDarray components_ => default!;
            public NDarray labels_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public DBSCAN fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray<long> fit_predict(NDarray X, NDarray? sample_weight = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public DBSCAN set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public DBSCAN set_params(params (string key, object value)[] @params) => default!;
        }

        public class FeatureAgglomeration : PythonObject,
            @base.ClassNamePrefixFeaturesOutMixin,
            @base.AgglomerationTransform<FeatureAgglomeration>,
            @base.AgglomerativeClustering<FeatureAgglomeration>
        {
            // Constructor
            public FeatureAgglomeration(int? n_clusters = 2, string metric = "euclidean", PyObject? memory = null, NDarray? connectivity = null, string compute_full_tree = "auto", string linkage = "ward", PyObject? pooling_func = null, float? distance_threshold = null, bool compute_distances = false)
            {
            }

            // Properties
            public int n_clusters_ => default!;
            public NDarray labels_ => default!;
            public int n_leaves_ => default!;
            public int n_connected_components_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray children_ => default!;
            public NDarray distances_ => default!;

            // Methods
            [Self]
            public FeatureAgglomeration fit(NDarray X) => default!;

            public NDarray<long> fit_predict(NDarray X, params (string key, object value)[] @params) => default!;

            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null) => default!;
            [Self]
            public FeatureAgglomeration set_output(string? transform = null) => default!;
            [Self]
            public FeatureAgglomeration set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class HDBSCAN : PythonObject,
            @base.ClusterMixin<HDBSCAN>,
            @base.BaseEstimator<HDBSCAN>
        {
            // Constructor
            public HDBSCAN(int min_cluster_size = 5, int? min_samples = null, float cluster_selection_epsilon = 0.0f, int? max_cluster_size = null, string metric = "euclidean", PyDict? metric_params = null, float alpha = 1.0f, string algorithm = "auto", int leaf_size = 40, int? n_jobs = null, string cluster_selection_method = "eom", bool allow_single_cluster = false, string? store_centers = null, bool copy = false)
            {
            }

            // Properties
            public NDarray labels_ => default!;
            public NDarray probabilities_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray centroids_ => default!;
            public NDarray medoids_ => default!;

            // Methods
            public NDarray dbscan_clustering(float cut_distance, int min_cluster_size = 5) => default!;
            [Self]
            public HDBSCAN fit(NDarray X) => default!;
            public NDarray<long> fit_predict(NDarray X, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public HDBSCAN set_params(params (string key, object value)[] @params) => default!;
        }

        public class KMeans : PythonObject
        {
            // Constructor
            public KMeans(int n_clusters = 8, string init = "k-means++", string n_init = "auto", int max_iter = 300, float tol = 0.0001f, int verbose = 0, int? random_state = null, bool copy_x = true, string algorithm = "lloyd")
            {
            }

            // Properties
            public NDarray cluster_centers_ => default!;
            public NDarray labels_ => default!;
            public float inertia_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public KMeans fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray fit_predict(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray? sample_weight = null) => default!;
            [Self]
            public KMeans set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public KMeans set_output(string? transform = null) => default!;
            [Self]
            public KMeans set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public KMeans set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class MeanShift : PythonObject
        {
            // Constructor
            public MeanShift(float? bandwidth = null, NDarray? seeds = null, bool bin_seeding = false, int min_bin_freq = 1, bool cluster_all = true, int? n_jobs = null, int max_iter = 300)
            {
            }

            // Properties
            public NDarray cluster_centers_ => default!;
            public NDarray labels_ => default!;
            public int n_iter_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public MeanShift fit(NDarray X) => default!;
            public NDarray<long> fit_predict(NDarray X, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            [Self]
            public MeanShift set_params(params (string key, object value)[] @params) => default!;
        }

        public class MiniBatchKMeans : PythonObject
        {
            // Constructor
            public MiniBatchKMeans(int n_clusters = 8, string init = "k-means++", int max_iter = 100, int batch_size = 1024, int verbose = 0, bool compute_labels = true, int? random_state = null, float tol = 0.0f, int max_no_improvement = 10, int? init_size = null, string n_init = "auto", float reassignment_ratio = 0.01f)
            {
            }

            // Properties
            public NDarray cluster_centers_ => default!;
            public NDarray labels_ => default!;
            public float inertia_ => default!;
            public int n_iter_ => default!;
            public int n_steps_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public MiniBatchKMeans fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray fit_predict(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public MiniBatchKMeans partial_fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray? sample_weight = null) => default!;
            [Self]
            public MiniBatchKMeans set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public MiniBatchKMeans set_output(string? transform = null) => default!;
            [Self]
            public MiniBatchKMeans set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public MiniBatchKMeans set_partial_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [Self]
            public MiniBatchKMeans set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class OPTICS : PythonObject
        {
            // Constructor
            public OPTICS(
                int min_samples = 5,
                float max_eps = float.PositiveInfinity,
                string metric = "minkowski",
                int p = 2,
                PyDict? metric_params = null,
                string cluster_method = "xi",
                float? eps = null,
                float xi = 0.05f,
                bool predecessor_correction = true,
                float? min_cluster_size = null,
                string algorithm = "auto",
                int leaf_size = 30,
                PyObject? memory = null,
                int? n_jobs = null)
            { }

            // Properties
            public NDarray labels_ => default!;
            public NDarray reachability_ => default!;
            public NDarray ordering_ => default!;
            public NDarray core_distances_ => default!;
            public NDarray predecessor_ => default!;
            public NDarray cluster_hierarchy_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public OPTICS fit(NDarray X) => default!;
            public NDarray<long> fit_predict(NDarray X, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public OPTICS set_params(params (string key, object value)[] @params) => default!;
        }

        public class SpectralBiclustering : PythonObject
        {
            // Constructor
            public SpectralBiclustering(int n_clusters = 3, string method = "bistochastic", int n_components = 6, int n_best = 3, string svd_method = "randomized", int? n_svd_vecs = null, bool mini_batch = false, string init = "k-means++", int n_init = 10, int? random_state = null)
            {
            }

            // Properties
            public NDarray rows_ => default!;
            public NDarray columns_ => default!;
            public NDarray row_labels_ => default!;
            public NDarray column_labels_ => default!;
            public NDarray biclusters_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SpectralBiclustering fit(NDarray X) => default!;
            public (NDarray<long>?, NDarray<long>?) get_indices(int i) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public (int?, int?) get_shape(int i) => default!;
            public NDarray get_submatrix(int i, NDarray data) => default!;
            [Self]
            public SpectralBiclustering set_params(params (string key, object value)[] @params) => default!;
        }

        public class SpectralClustering : PythonObject
        {
            // Constructor
            public SpectralClustering(int n_clusters = 8, PyObject? eigen_solver = null, int? n_components = null, int? random_state = null, int n_init = 10, float gamma = 1.0f, string affinity = "rbf", int n_neighbors = 10, string eigen_tol = "auto", string assign_labels = "kmeans", int degree = 3, int coef0 = 1, PyDict? kernel_params = null, int? n_jobs = null, bool verbose = false)
            {
            }

            // Properties
            public NDarray affinity_matrix_ => default!;
            public NDarray labels_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SpectralClustering fit(NDarray X) => default!;
            public NDarray fit_predict(NDarray X) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public SpectralClustering set_params(params (string key, object value)[] @params) => default!;
        }

        public class SpectralCoclustering : PythonObject
        {
            // Constructor
            public SpectralCoclustering(int n_clusters = 3, string svd_method = "randomized", int? n_svd_vecs = null, bool mini_batch = false, string init = "k-means++", int n_init = 10, int? random_state = null)
            {
            }

            // Properties
            public NDarray rows_ => default!;
            public NDarray columns_ => default!;
            public NDarray row_labels_ => default!;
            public NDarray column_labels_ => default!;
            public NDarray biclusters_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [Self]
            public SpectralCoclustering fit(NDarray X) => default!;
            public (NDarray<long>?, NDarray<long>?) get_indices(int i) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public (int?, int?) get_shape(int i) => default!;
            public NDarray get_submatrix(int i, NDarray data) => default!;
            [Self]
            public SpectralCoclustering set_params(params (string key, object value)[] @params) => default!;
        }
    }
}