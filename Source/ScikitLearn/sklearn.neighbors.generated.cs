using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class neighbors
        {
            public static NDarray kneighbors_graph(NDarray X, int n_neighbors, string mode = "connectivity", string metric = "minkowski", int p = 2, PyDict? metric_params = null, bool include_self = false, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static NDarray radius_neighbors_graph(NDarray X, float radius, string mode = "connectivity", string metric = "minkowski", int p = 2, PyDict? metric_params = null, bool include_self = false, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static NDarray sort_graph_by_row_values(NDarray graph, bool copy = false, bool warn_when_not_sorted = true)
            {
                throw new NotImplementedException();
            }

            public class BallTree
            {
                public BallTree()
                {
                }

                public PyObject data => Helpers.ToCSharpNDarray(self.GetAttr("data"));
                public PyTuple valid_metrics => Helpers.ToCSharpNDarray(self.GetAttr("valid_metrics"));

                public NDarray get_arrays()
                {
                    throw new NotImplementedException();
                }

                public int get_n_calls()
                {
                    throw new NotImplementedException();
                }

                public int get_tree_stats()
                {
                    throw new NotImplementedException();
                }

                public NDarray kernel_density(NDarray X, float h, string kernel = "gaussian", int atol = 0, float rtol = 1E-8f, bool breadth_first = true, bool return_log = false)
                {
                    throw new NotImplementedException();
                }

                public (bool? , bool? , NDarray? , NDarray? ) query(NDarray X, int k = 1, bool return_distance = true, bool dualtree = false, bool breadth_first = false)
                {
                    throw new NotImplementedException();
                }

                public (bool? , bool? , bool? , NDarray? , PyObject? , PyObject? ) query_radius(NDarray X, PyObject r, bool return_distance = false, bool count_only = false, bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public void reset_n_calls()
                {
                    throw new NotImplementedException();
                }

                public NDarray two_point_correlation(NDarray X, NDarray r, bool dualtree = false)
                {
                    throw new NotImplementedException();
                }
            }

            public class KDTree
            {
                public KDTree()
                {
                }

                public PyObject data => Helpers.ToCSharpNDarray(self.GetAttr("data"));
                public PyTuple valid_metrics => Helpers.ToCSharpNDarray(self.GetAttr("valid_metrics"));

                public NDarray get_arrays()
                {
                    throw new NotImplementedException();
                }

                public int get_n_calls()
                {
                    throw new NotImplementedException();
                }

                public int get_tree_stats()
                {
                    throw new NotImplementedException();
                }

                public NDarray kernel_density(NDarray X, float h, string kernel = "gaussian", int atol = 0, float rtol = 1E-8f, bool breadth_first = true, bool return_log = false)
                {
                    throw new NotImplementedException();
                }

                public (bool? , bool? , NDarray? , NDarray? ) query(NDarray X, int k = 1, bool return_distance = true, bool dualtree = false, bool breadth_first = false)
                {
                    throw new NotImplementedException();
                }

                public (bool? , bool? , bool? , NDarray? , PyObject? , PyObject? ) query_radius(NDarray X, PyObject r, bool return_distance = false, bool count_only = false, bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public void reset_n_calls()
                {
                    throw new NotImplementedException();
                }

                public NDarray two_point_correlation(NDarray X, NDarray r, bool dualtree = false)
                {
                    throw new NotImplementedException();
                }
            }

            public class KNeighborsClassifier
            {
                public KNeighborsClassifier(int n_neighbors = 5, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public string effective_metric_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_fit_"));
                public bool outputs_2d_ => Helpers.ToCSharpNDarray(self.GetAttr("outputs_2d_"));

                public KNeighborsClassifier fit(NDarray X, NDarray y)
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

                public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public KNeighborsClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public KNeighborsClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class KNeighborsRegressor
            {
                public KNeighborsRegressor(int n_neighbors = 5, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
                {
                }

                public string effective_metric_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_fit_"));

                public KNeighborsRegressor fit(NDarray X, NDarray y)
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

                public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public KNeighborsRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public KNeighborsRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class KNeighborsTransformer
            {
                public KNeighborsTransformer(string mode = "distance", int n_neighbors = 5, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
                {
                }

                public string effective_metric_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_fit_"));

                public KNeighborsTransformer fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X)
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

                public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    throw new NotImplementedException();
                }

                public KNeighborsTransformer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public KNeighborsTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class KernelDensity
            {
                public KernelDensity(float bandwidth = 1.0f, string algorithm = "auto", string kernel = "gaussian", string metric = "euclidean", int atol = 0, int rtol = 0, bool breadth_first = true, int leaf_size = 40, PyDict? metric_params = null)
                {
                }

                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public PyObject tree_ => Helpers.ToCSharpNDarray(self.GetAttr("tree_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public float bandwidth_ => Helpers.ToCSharpNDarray(self.GetAttr("bandwidth_"));

                public KernelDensity fit(NDarray X, PyObject? y = null, NDarray? sample_weight = null)
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

                public NDarray sample(int n_samples = 1, int? random_state = null)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public KernelDensity set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public KernelDensity set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class LocalOutlierFactor
            {
                public LocalOutlierFactor(int n_neighbors = 20, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, string contamination = "auto", bool novelty = false, int? n_jobs = null)
                {
                }

                public NDarray negative_outlier_factor_ => Helpers.ToCSharpNDarray(self.GetAttr("negative_outlier_factor_"));
                public int n_neighbors_ => Helpers.ToCSharpNDarray(self.GetAttr("n_neighbors_"));
                public float offset_ => Helpers.ToCSharpNDarray(self.GetAttr("offset_"));
                public string effective_metric_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_fit_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public LocalOutlierFactor fit(NDarray X)
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

                public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray? X = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public LocalOutlierFactor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class NearestCentroid
            {
                public NearestCentroid(string metric = "euclidean", float? shrink_threshold = null)
                {
                }

                public NDarray centroids_ => Helpers.ToCSharpNDarray(self.GetAttr("centroids_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NearestCentroid fit(NDarray X, NDarray y)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NearestCentroid set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NearestCentroid set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class NearestNeighbors
            {
                public NearestNeighbors(int n_neighbors = 5, float radius = 1.0f, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
                {
                }

                public string effective_metric_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_fit_"));

                public NearestNeighbors fit(NDarray X)
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

                public (NDarray? , NDarray? ) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity")
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public NearestNeighbors set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class NeighborhoodComponentsAnalysis
            {
                public NeighborhoodComponentsAnalysis(int? n_components = null, string init = "auto", bool warm_start = false, int max_iter = 50, float tol = 1e-05f, PyObject? callback = null, int verbose = 0, int? random_state = null)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public PyObject random_state_ => Helpers.ToCSharpNDarray(self.GetAttr("random_state_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NeighborhoodComponentsAnalysis fit(NDarray X, NDarray y)
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

                public NeighborhoodComponentsAnalysis set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public NeighborhoodComponentsAnalysis set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class RadiusNeighborsClassifier
            {
                public RadiusNeighborsClassifier(float radius = 1.0f, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyObject? outlier_label = null, PyDict? metric_params = null, int? n_jobs = null)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public string effective_metric_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_fit_"));
                public NDarray outlier_label_ => Helpers.ToCSharpNDarray(self.GetAttr("outlier_label_"));
                public bool outputs_2d_ => Helpers.ToCSharpNDarray(self.GetAttr("outputs_2d_"));

                public RadiusNeighborsClassifier fit(NDarray X, NDarray y)
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

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public RadiusNeighborsClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public RadiusNeighborsClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class RadiusNeighborsRegressor
            {
                public RadiusNeighborsRegressor(float radius = 1.0f, string? weights = "uniform", string algorithm = "auto", int leaf_size = 30, int p = 2, string metric = "minkowski", PyDict? metric_params = null, int? n_jobs = null)
                {
                }

                public string effective_metric_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_fit_"));

                public RadiusNeighborsRegressor fit(NDarray X, NDarray y)
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

                public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public RadiusNeighborsRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public RadiusNeighborsRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class RadiusNeighborsTransformer
            {
                public RadiusNeighborsTransformer(string mode = "distance", float radius = 1.0f, string algorithm = "auto", int leaf_size = 30, string metric = "minkowski", int p = 2, PyDict? metric_params = null, int? n_jobs = null)
                {
                }

                public string effective_metric_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_"));
                public PyDict effective_metric_params_ => Helpers.ToCSharpNDarray(self.GetAttr("effective_metric_params_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_samples_fit_ => Helpers.ToCSharpNDarray(self.GetAttr("n_samples_fit_"));

                public RadiusNeighborsTransformer fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X)
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

                public (NDarray? , NDarray? ) radius_neighbors(NDarray? X = null, float? radius = null, bool return_distance = true, bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public NDarray radius_neighbors_graph(NDarray? X = null, float? radius = null, string mode = "connectivity", bool sort_results = false)
                {
                    throw new NotImplementedException();
                }

                public RadiusNeighborsTransformer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public RadiusNeighborsTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}