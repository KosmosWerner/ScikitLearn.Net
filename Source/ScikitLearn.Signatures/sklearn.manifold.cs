using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class manifold
    {
        // Methods
        public static (NDarray?, float?) locally_linear_embedding(NDarray X, int n_neighbors, int n_components, float reg = 0.001f, string eigen_solver = "auto", float tol = 1e-06f, int max_iter = 100, string method = "standard", float hessian_tol = 0.0001f, float modified_tol = 1e-12f, int? random_state = null, int? n_jobs = null) => default!;
        public static (NDarray?, string?, int?) smacof(NDarray dissimilarities, bool metric = true, int n_components = 2, NDarray? init = null, int n_init = 8, int? n_jobs = null, int max_iter = 300, int verbose = 0, float eps = 0.001f, int? random_state = null, bool return_n_iter = false, string normalized_stress = "auto") => default!;
        public static NDarray spectral_embedding(NDarray adjacency, int n_components = 8, PyObject? eigen_solver = null, int? random_state = null, string eigen_tol = "auto", bool norm_laplacian = true, bool drop_first = true) => default!;
        public static float trustworthiness(NDarray X, NDarray X_embedded, int n_neighbors = 5, string metric = "euclidean") => default!;
        // Classes
        public class Isomap : PythonObject
        {
            // Constructor
            public Isomap(int? n_neighbors = 5, float? radius = null, int n_components = 2, string eigen_solver = "auto", int tol = 0, int? max_iter = null, string path_method = "auto", string neighbors_algorithm = "auto", int? n_jobs = null, string metric = "minkowski", int p = 2, PyDict? metric_params = null)
            {
            }

            // Properties
            public NDarray embedding_ => default!;
            public PyObject kernel_pca_ => default!;
            public PyObject nbrs_ => default!;
            public NDarray dist_matrix_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public Isomap fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public string reconstruction_error() => default!;
            [ReturnThis]
            public Isomap set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public Isomap set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class LocallyLinearEmbedding : PythonObject
        {
            // Constructor
            public LocallyLinearEmbedding(int n_neighbors = 5, int n_components = 2, float reg = 0.001f, string eigen_solver = "auto", float tol = 1e-06f, int max_iter = 100, string method = "standard", float hessian_tol = 0.0001f, float modified_tol = 1e-12f, string neighbors_algorithm = "auto", int? random_state = null, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray embedding_ => default!;
            public float reconstruction_error_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public PyObject nbrs_ => default!;

            // Methods
            [ReturnThis]
            public LocallyLinearEmbedding fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public LocallyLinearEmbedding set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public LocallyLinearEmbedding set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class MDS : PythonObject
        {
            // Constructor
            public MDS(int n_components = 2, bool metric = true, int n_init = 4, int max_iter = 300, int verbose = 0, float eps = 0.001f, int? n_jobs = null, int? random_state = null, string dissimilarity = "euclidean", string normalized_stress = "auto")
            {
            }

            // Properties
            public NDarray embedding_ => default!;
            public float stress_ => default!;
            public NDarray dissimilarity_matrix_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_iter_ => default!;

            // Methods
            [ReturnThis]
            public MDS fit(NDarray X, NDarray? init = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? init = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public MDS set_fit_request(string? init = "$UNCHANGED$") => default!;
            [ReturnThis]
            public MDS set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class SpectralEmbedding : PythonObject
        {
            // Constructor
            public SpectralEmbedding(int n_components = 2, string affinity = "nearest_neighbors", float? gamma = null, int? random_state = null, PyObject? eigen_solver = null, string eigen_tol = "auto", int? n_neighbors = null, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray embedding_ => default!;
            public NDarray affinity_matrix_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_neighbors_ => default!;

            // Methods
            [ReturnThis]
            public SpectralEmbedding fit(NDarray X) => default!;
            public NDarray fit_transform(NDarray X) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public SpectralEmbedding set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class TSNE : PythonObject
        {
            // Constructor
            public TSNE(int n_components = 2, float perplexity = 30.0f, float early_exaggeration = 12.0f, string learning_rate = "auto", int? max_iter = null, int n_iter_without_progress = 300, float min_grad_norm = 1e-07f, string metric = "euclidean", PyDict? metric_params = null, string init = "pca", int verbose = 0, int? random_state = null, string method = "barnes_hut", float angle = 0.5f, int? n_jobs = null, string n_iter = "deprecated")
            {
            }

            // Properties
            public NDarray embedding_ => default!;
            public float kl_divergence_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public float learning_rate_ => default!;
            public int n_iter_ => default!;

            // Methods
            [ReturnThis]
            public TSNE fit(NDarray X, PyObject? y = null) => default!;
            public NDarray fit_transform(NDarray X, PyObject? y = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public TSNE set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public TSNE set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }
    }
}