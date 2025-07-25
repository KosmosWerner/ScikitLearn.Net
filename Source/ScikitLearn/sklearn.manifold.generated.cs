using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class manifold
        {
            public static (NDarray? , float? ) locally_linear_embedding(NDarray X, int n_neighbors, int n_components, float reg = 0.001f, string eigen_solver = "auto", float tol = 1e-06f, int max_iter = 100, string method = "standard", float hessian_tol = 0.0001f, float modified_tol = 1e-12f, int? random_state = null, int? n_jobs = null)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , string? , int? ) smacof(NDarray dissimilarities, bool metric = true, int n_components = 2, NDarray? init = null, int n_init = 8, int? n_jobs = null, int max_iter = 300, int verbose = 0, float eps = 0.001f, int? random_state = null, bool return_n_iter = false, string normalized_stress = "auto")
            {
                throw new NotImplementedException();
            }

            public static NDarray spectral_embedding(NDarray adjacency, int n_components = 8, PyObject? eigen_solver = null, int? random_state = null, string eigen_tol = "auto", bool norm_laplacian = true, bool drop_first = true)
            {
                throw new NotImplementedException();
            }

            public static float trustworthiness(NDarray X, NDarray X_embedded, int n_neighbors = 5, string metric = "euclidean")
            {
                throw new NotImplementedException();
            }

            public class Isomap
            {
                public Isomap(int? n_neighbors = 5, float? radius = null, int n_components = 2, string eigen_solver = "auto", int tol = 0, int? max_iter = null, string path_method = "auto", string neighbors_algorithm = "auto", int? n_jobs = null, string metric = "minkowski", int p = 2, PyDict? metric_params = null)
                {
                }

                public NDarray embedding_ => Helpers.ToCSharpNDarray(self.GetAttr("embedding_"));
                public PyObject kernel_pca_ => Helpers.ToCSharpNDarray(self.GetAttr("kernel_pca_"));
                public PyObject nbrs_ => Helpers.ToCSharpNDarray(self.GetAttr("nbrs_"));
                public NDarray dist_matrix_ => Helpers.ToCSharpNDarray(self.GetAttr("dist_matrix_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Isomap fit(NDarray X)
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

                public string reconstruction_error()
                {
                    throw new NotImplementedException();
                }

                public Isomap set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public Isomap set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class LocallyLinearEmbedding
            {
                public LocallyLinearEmbedding(int n_neighbors = 5, int n_components = 2, float reg = 0.001f, string eigen_solver = "auto", float tol = 1e-06f, int max_iter = 100, string method = "standard", float hessian_tol = 0.0001f, float modified_tol = 1e-12f, string neighbors_algorithm = "auto", int? random_state = null, int? n_jobs = null)
                {
                }

                public NDarray embedding_ => Helpers.ToCSharpNDarray(self.GetAttr("embedding_"));
                public float reconstruction_error_ => Helpers.ToCSharpNDarray(self.GetAttr("reconstruction_error_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public PyObject nbrs_ => Helpers.ToCSharpNDarray(self.GetAttr("nbrs_"));

                public LocallyLinearEmbedding fit(NDarray X)
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

                public LocallyLinearEmbedding set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public LocallyLinearEmbedding set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MDS
            {
                public MDS(int n_components = 2, bool metric = true, int n_init = 4, int max_iter = 300, int verbose = 0, float eps = 0.001f, int? n_jobs = null, int? random_state = null, string dissimilarity = "euclidean", string normalized_stress = "auto")
                {
                }

                public NDarray embedding_ => Helpers.ToCSharpNDarray(self.GetAttr("embedding_"));
                public float stress_ => Helpers.ToCSharpNDarray(self.GetAttr("stress_"));
                public NDarray dissimilarity_matrix_ => Helpers.ToCSharpNDarray(self.GetAttr("dissimilarity_matrix_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));

                public MDS fit(NDarray X, NDarray? init = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? init = null)
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

                public MDS set_fit_request(string? init = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public MDS set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class SpectralEmbedding
            {
                public SpectralEmbedding(int n_components = 2, string affinity = "nearest_neighbors", float? gamma = null, int? random_state = null, PyObject? eigen_solver = null, string eigen_tol = "auto", int? n_neighbors = null, int? n_jobs = null)
                {
                }

                public NDarray embedding_ => Helpers.ToCSharpNDarray(self.GetAttr("embedding_"));
                public NDarray affinity_matrix_ => Helpers.ToCSharpNDarray(self.GetAttr("affinity_matrix_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_neighbors_ => Helpers.ToCSharpNDarray(self.GetAttr("n_neighbors_"));

                public SpectralEmbedding fit(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X)
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

                public SpectralEmbedding set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class TSNE
            {
                public TSNE(int n_components = 2, float perplexity = 30.0f, float early_exaggeration = 12.0f, string learning_rate = "auto", int? max_iter = null, int n_iter_without_progress = 300, float min_grad_norm = 1e-07f, string metric = "euclidean", PyDict? metric_params = null, string init = "pca", int verbose = 0, int? random_state = null, string method = "barnes_hut", float angle = 0.5f, int? n_jobs = null, string n_iter = "deprecated")
                {
                }

                public NDarray embedding_ => Helpers.ToCSharpNDarray(self.GetAttr("embedding_"));
                public float kl_divergence_ => Helpers.ToCSharpNDarray(self.GetAttr("kl_divergence_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public float learning_rate_ => Helpers.ToCSharpNDarray(self.GetAttr("learning_rate_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));

                public TSNE fit(NDarray X, PyObject? y = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, PyObject? y = null)
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

                public TSNE set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public TSNE set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}