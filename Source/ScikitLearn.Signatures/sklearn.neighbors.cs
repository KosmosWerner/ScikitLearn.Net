using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class neighbors
    {
        // Methods
        public static NDarray kneighbors_graph(NDarray X, int n_neighbors, string mode = "connectivity", string metric = "minkowski", int p = 2, PyDict? metric_params = null, bool include_self = false, int? n_jobs = null) => default !;
        public static NDarray radius_neighbors_graph(NDarray X, float radius, string mode = "connectivity", string metric = "minkowski", int p = 2, PyDict? metric_params = null, bool include_self = false, int? n_jobs = null) => default !;
        public static NDarray sort_graph_by_row_values(NDarray graph, bool copy = false, bool warn_when_not_sorted = true) => default !;
        // Classes
        public class BallTree
        {
            // Constructor
            public BallTree()
            {
            }

            // Properties
            public PyObject data => default !;
            public PyTuple valid_metrics => default !;

            // Methods
            public NDarray get_arrays() => default !;
            public int get_n_calls() => default !;
            public int get_tree_stats() => default !;
            public NDarray kernel_density(NDarray X, float h, string kernel = "gaussian", int atol = 0, float rtol = 1E-8f, bool breadth_first = true, bool return_log = false) => default !;
            public (bool? , bool? , NDarray? , NDarray? ) query(NDarray X, int k = 1, bool return_distance = true, bool dualtree = false, bool breadth_first = false) => default !;
            public (bool? , bool? , bool? , NDarray? , PyObject? , PyObject? ) query_radius(NDarray X, PyObject r, bool return_distance = false, bool count_only = false, bool sort_results = false) => default !;
            public void reset_n_calls()
            {
            }

            public NDarray two_point_correlation(NDarray X, NDarray r, bool dualtree = false) => default !;
        }

        public class KDTree
        {
            // Constructor
            public KDTree()
            {
            }

            // Properties
            public PyObject data => default !;
            public PyTuple valid_metrics => default !;

            // Methods
            public NDarray get_arrays() => default !;
            public int get_n_calls() => default !;
            public int get_tree_stats() => default !;
            public NDarray kernel_density(NDarray X, float h, string kernel = "gaussian", int atol = 0, float rtol = 1E-8f, bool breadth_first = true, bool return_log = false) => default !;
            public (bool? , bool? , NDarray? , NDarray? ) query(NDarray X, int k = 1, bool return_distance = true, bool dualtree = false, bool breadth_first = false) => default !;
            public (bool? , bool? , bool? , NDarray? , PyObject? , PyObject? ) query_radius(NDarray X, PyObject r, bool return_distance = false, bool count_only = false, bool sort_results = false) => default !;
            public void reset_n_calls()
            {
            }

            public NDarray two_point_correlation(NDarray X, NDarray r, bool dualtree = false) => default !;
        }

        public class KNeighborsClassifier
        {
            // Constructor
            public KNeighborsClassifier(int n_neighbors = 5, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray classes_ => default !;
            public string effective_metric_ => default !;
            public PyDict effective_metric_params_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_samples_fit_ => default !;
            public bool outputs_2d_ => default !;

            // Methods
            [ReturnThis]
            public KNeighborsClassifier fit(NDarray X, NDarray y) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true) => default !;
            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity") => default !;
            public NDarray predict(NDarray X) => default !;
            public NDarray predict_proba(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public KNeighborsClassifier set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public KNeighborsClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class KNeighborsRegressor
        {
            // Constructor
            public KNeighborsRegressor(int n_neighbors = 5, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
            {
            }

            // Properties
            public string effective_metric_ => default !;
            public PyDict effective_metric_params_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_samples_fit_ => default !;

            // Methods
            [ReturnThis]
            public KNeighborsRegressor fit(NDarray X, NDarray y) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true) => default !;
            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity") => default !;
            public NDarray predict(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public KNeighborsRegressor set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public KNeighborsRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class KNeighborsTransformer
        {
            // Constructor
            public KNeighborsTransformer(string mode = "distance", int n_neighbors = 5, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
            {
            }

            // Properties
            public string effective_metric_ => default !;
            public PyDict effective_metric_params_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_samples_fit_ => default !;

            // Methods
            [ReturnThis]
            public KNeighborsTransformer fit(NDarray X) => default !;
            public NDarray fit_transform(NDarray X) => default !;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true) => default !;
            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity") => default !;
            [ReturnThis]
            public KNeighborsTransformer set_output(PyObject? transform = null) => default !;
            [ReturnThis]
            public KNeighborsTransformer set_params(Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray transform(NDarray X) => default !;
        }

        public class KernelDensity
        {
            // Constructor
            public KernelDensity(float bandwidth = 1.0f, string algorithm = "auto", string kernel = "gaussian", string metric = "euclidean", int atol = 0, int rtol = 0, bool breadth_first = true, int leaf_size = 40, PyDict? metric_params = null)
            {
            }

            // Properties
            public int n_features_in_ => default !;
            public PyObject tree_ => default !;
            public NDarray feature_names_in_ => default !;
            public float bandwidth_ => default !;

            // Methods
            [ReturnThis]
            public KernelDensity fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public NDarray sample(int n_samples = 1, int? random_state = null) => default !;
            public float score(NDarray X, PyObject? y = null) => default !;
            public NDarray score_samples(NDarray X) => default !;
            [ReturnThis]
            public KernelDensity set_fit_request(string? sample_weight = "$UNCHANGED$") => default !;
            [ReturnThis]
            public KernelDensity set_params(Dictionary<string, PyObject>? @params = null) => default !;
        }

        public class LocalOutlierFactor
        {
            // Constructor
            public LocalOutlierFactor(int n_neighbors = 20, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, string contamination = "auto", bool novelty = false, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray negative_outlier_factor_ => default !;
            public int n_neighbors_ => default !;
            public float offset_ => default !;
            public string effective_metric_ => default !;
            public PyDict effective_metric_params_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_samples_fit_ => default !;

            // Methods
            public NDarray decision_function(NDarray X) => default !;
            [ReturnThis]
            public LocalOutlierFactor fit(NDarray X) => default !;
            public NDarray fit_predict(NDarray X) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true) => default !;
            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity") => default !;
            public NDarray predict(NDarray? X = null) => default !;
            public NDarray score_samples(NDarray X) => default !;
            [ReturnThis]
            public LocalOutlierFactor set_params(Dictionary<string, PyObject>? @params = null) => default !;
        }

        public class NearestCentroid
        {
            // Constructor
            public NearestCentroid(string metric = "euclidean", float? shrink_threshold = null)
            {
            }

            // Properties
            public NDarray centroids_ => default !;
            public NDarray classes_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            [ReturnThis]
            public NearestCentroid fit(NDarray X, NDarray y) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public NDarray predict(NDarray X) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public NearestCentroid set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public NearestCentroid set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class NearestNeighbors
        {
            // Constructor
            public NearestNeighbors(int n_neighbors = 5, float radius = 1.0f, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
            {
            }

            // Properties
            public string effective_metric_ => default !;
            public PyDict effective_metric_params_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_samples_fit_ => default !;

            // Methods
            [ReturnThis]
            public NearestNeighbors fit(NDarray X) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true) => default !;
            public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity") => default !;
            public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false) => default !;
            public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false) => default !;
            [ReturnThis]
            public NearestNeighbors set_params(Dictionary<string, PyObject>? @params = null) => default !;
        }

        public class NeighborhoodComponentsAnalysis
        {
            // Constructor
            public NeighborhoodComponentsAnalysis(int? n_components = null, string init = "auto", bool warm_start = false, int max_iter = 50, float tol = 1e-05f, PyObject? callback = null, int verbose = 0, int? random_state = null)
            {
            }

            // Properties
            public NDarray components_ => default !;
            public int n_features_in_ => default !;
            public int n_iter_ => default !;
            public PyObject random_state_ => default !;
            public NDarray feature_names_in_ => default !;

            // Methods
            [ReturnThis]
            public NeighborhoodComponentsAnalysis fit(NDarray X, NDarray y) => default !;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default !;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            [ReturnThis]
            public NeighborhoodComponentsAnalysis set_output(PyObject? transform = null) => default !;
            [ReturnThis]
            public NeighborhoodComponentsAnalysis set_params(Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray transform(NDarray X) => default !;
        }

        public class RadiusNeighborsClassifier
        {
            // Constructor
            public RadiusNeighborsClassifier(float radius = 1.0f, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyObject? outlier_label = null, PyDict? metric_params = null, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray classes_ => default !;
            public string effective_metric_ => default !;
            public PyDict effective_metric_params_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_samples_fit_ => default !;
            public NDarray outlier_label_ => default !;
            public bool outputs_2d_ => default !;

            // Methods
            [ReturnThis]
            public RadiusNeighborsClassifier fit(NDarray X, NDarray y) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public NDarray predict(NDarray X) => default !;
            public NDarray predict_proba(NDarray X) => default !;
            public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false) => default !;
            public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public RadiusNeighborsClassifier set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public RadiusNeighborsClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class RadiusNeighborsRegressor
        {
            // Constructor
            public RadiusNeighborsRegressor(float radius = 1.0f, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
            {
            }

            // Properties
            public string effective_metric_ => default !;
            public PyDict effective_metric_params_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_samples_fit_ => default !;

            // Methods
            [ReturnThis]
            public RadiusNeighborsRegressor fit(NDarray X, NDarray y) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public NDarray predict(NDarray X) => default !;
            public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false) => default !;
            public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false) => default !;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default !;
            [ReturnThis]
            public RadiusNeighborsRegressor set_params(Dictionary<string, PyObject>? @params = null) => default !;
            [ReturnThis]
            public RadiusNeighborsRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default !;
        }

        public class RadiusNeighborsTransformer
        {
            // Constructor
            public RadiusNeighborsTransformer(string mode = "distance", float radius = 1.0f, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
            {
            }

            // Properties
            public string effective_metric_ => default !;
            public PyDict effective_metric_params_ => default !;
            public int n_features_in_ => default !;
            public NDarray feature_names_in_ => default !;
            public int n_samples_fit_ => default !;

            // Methods
            [ReturnThis]
            public RadiusNeighborsTransformer fit(NDarray X) => default !;
            public NDarray fit_transform(NDarray X) => default !;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default !;
            public PyObject get_metadata_routing() => default !;
            public PyDict get_params(bool deep = true) => default !;
            public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false) => default !;
            public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false) => default !;
            [ReturnThis]
            public RadiusNeighborsTransformer set_output(PyObject? transform = null) => default !;
            [ReturnThis]
            public RadiusNeighborsTransformer set_params(Dictionary<string, PyObject>? @params = null) => default !;
            public NDarray transform(NDarray X) => default !;
        }
    }
}