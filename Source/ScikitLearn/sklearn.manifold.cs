using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class manifold
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
                return Py.Import("sklearn.manifold");
            }

            static manifold()
            {
                ReInitializeLazySelf();
            }

            public class Isomap : PythonObject
            {
                public Isomap(int? n_neighbors = 5, float? radius = null, int n_components = 2, string eigen_solver = "auto", int tol = 0, int? max_iter = null, string path_method = "auto", string neighbors_algorithm = "auto", int? n_jobs = null, string metric = "minkowski", int p = 2, PyDict? metric_params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_neighbors != 5)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (radius != null)
                        pyDict["radius"] = ToPython(radius);
                    if (n_components != 2)
                        pyDict["n_components"] = ToPython(n_components);
                    if (eigen_solver != "auto")
                        pyDict["eigen_solver"] = ToPython(eigen_solver);
                    if (tol != 0)
                        pyDict["tol"] = ToPython(tol);
                    if (max_iter != null)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (path_method != "auto")
                        pyDict["path_method"] = ToPython(path_method);
                    if (neighbors_algorithm != "auto")
                        pyDict["neighbors_algorithm"] = ToPython(neighbors_algorithm);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (metric != "minkowski")
                        pyDict["metric"] = ToPython(metric);
                    if (p != 2)
                        pyDict["p"] = ToPython(p);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    self = sklearn.manifold.self.InvokeMethod("Isomap", args, pyDict);
                }

                internal Isomap(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static Isomap Encapsule(PyObject pyObject)
                {
                    return new Isomap(pyObject);
                }

                public NDarray embedding_ => ToCsharp<NDarray>(self.GetAttr("embedding_"));
                public PyObject kernel_pca_ => self.GetAttr("kernel_pca_");
                public PyObject nbrs_ => self.GetAttr("nbrs_");
                public NDarray dist_matrix_ => ToCsharp<NDarray>(self.GetAttr("dist_matrix_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                public Isomap fit(NDarray X)
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

                public string reconstruction_error()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return ToCsharp<string>(self.InvokeMethod("reconstruction_error", args, pyDict));
                }

                public Isomap set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public Isomap set_params(Dictionary<string, PyObject>? @params = null)
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

            public class LocallyLinearEmbedding : PythonObject
            {
                public LocallyLinearEmbedding(int n_neighbors = 5, int n_components = 2, float reg = 0.001f, string eigen_solver = "auto", float tol = 1e-06f, int max_iter = 100, string method = "standard", float hessian_tol = 0.0001f, float modified_tol = 1e-12f, string neighbors_algorithm = "auto", int? random_state = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_neighbors != 5)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (n_components != 2)
                        pyDict["n_components"] = ToPython(n_components);
                    if (reg != 0.001f)
                        pyDict["reg"] = ToPython(reg);
                    if (eigen_solver != "auto")
                        pyDict["eigen_solver"] = ToPython(eigen_solver);
                    if (tol != 1e-06f)
                        pyDict["tol"] = ToPython(tol);
                    if (max_iter != 100)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (method != "standard")
                        pyDict["method"] = ToPython(method);
                    if (hessian_tol != 0.0001f)
                        pyDict["hessian_tol"] = ToPython(hessian_tol);
                    if (modified_tol != 1e-12f)
                        pyDict["modified_tol"] = ToPython(modified_tol);
                    if (neighbors_algorithm != "auto")
                        pyDict["neighbors_algorithm"] = ToPython(neighbors_algorithm);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.manifold.self.InvokeMethod("LocallyLinearEmbedding", args, pyDict);
                }

                internal LocallyLinearEmbedding(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static LocallyLinearEmbedding Encapsule(PyObject pyObject)
                {
                    return new LocallyLinearEmbedding(pyObject);
                }

                public NDarray embedding_ => ToCsharp<NDarray>(self.GetAttr("embedding_"));
                public string reconstruction_error_ => ToCsharp<string>(self.GetAttr("reconstruction_error_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public PyObject nbrs_ => self.GetAttr("nbrs_");

                public LocallyLinearEmbedding fit(NDarray X)
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

                public LocallyLinearEmbedding set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public LocallyLinearEmbedding set_params(Dictionary<string, PyObject>? @params = null)
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

            public class MDS : PythonObject
            {
                public MDS(int n_components = 2, bool metric = true, int n_init = 4, int max_iter = 300, int verbose = 0, float eps = 0.001f, int? n_jobs = null, int? random_state = null, string dissimilarity = "euclidean", string normalized_stress = "auto")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 2)
                        pyDict["n_components"] = ToPython(n_components);
                    if (metric != true)
                        pyDict["metric"] = ToPython(metric);
                    if (n_init != 4)
                        pyDict["n_init"] = ToPython(n_init);
                    if (max_iter != 300)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (eps != 0.001f)
                        pyDict["eps"] = ToPython(eps);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (dissimilarity != "euclidean")
                        pyDict["dissimilarity"] = ToPython(dissimilarity);
                    if (normalized_stress != "auto")
                        pyDict["normalized_stress"] = ToPython(normalized_stress);
                    self = sklearn.manifold.self.InvokeMethod("MDS", args, pyDict);
                }

                internal MDS(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static MDS Encapsule(PyObject pyObject)
                {
                    return new MDS(pyObject);
                }

                public NDarray embedding_ => ToCsharp<NDarray>(self.GetAttr("embedding_"));
                public string stress_ => ToCsharp<string>(self.GetAttr("stress_"));
                public NDarray dissimilarity_matrix_ => ToCsharp<NDarray>(self.GetAttr("dissimilarity_matrix_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));

                public MDS fit(NDarray X, NDarray? init = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (init != null)
                        pyDict["init"] = ToPython(init);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? init = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (init != null)
                        pyDict["init"] = ToPython(init);
                    return ToCsharp<NDarray>(self.InvokeMethod("fit_transform", args, pyDict));
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

                public MDS set_fit_request(string? init = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (init != "$UNCHANGED$")
                        pyDict["init"] = ToPython(init);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public MDS set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class SpectralEmbedding : PythonObject
            {
                public SpectralEmbedding(int n_components = 2, string affinity = "nearest_neighbors", float? gamma = null, int? random_state = null, PyObject? eigen_solver = null, string eigen_tol = "auto", int? n_neighbors = null, int? n_jobs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 2)
                        pyDict["n_components"] = ToPython(n_components);
                    if (affinity != "nearest_neighbors")
                        pyDict["affinity"] = ToPython(affinity);
                    if (gamma != null)
                        pyDict["gamma"] = ToPython(gamma);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (eigen_solver != null)
                        pyDict["eigen_solver"] = ToPython(eigen_solver);
                    if (eigen_tol != "auto")
                        pyDict["eigen_tol"] = ToPython(eigen_tol);
                    if (n_neighbors != null)
                        pyDict["n_neighbors"] = ToPython(n_neighbors);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    self = sklearn.manifold.self.InvokeMethod("SpectralEmbedding", args, pyDict);
                }

                internal SpectralEmbedding(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static SpectralEmbedding Encapsule(PyObject pyObject)
                {
                    return new SpectralEmbedding(pyObject);
                }

                public NDarray embedding_ => ToCsharp<NDarray>(self.GetAttr("embedding_"));
                public NDarray affinity_matrix_ => ToCsharp<NDarray>(self.GetAttr("affinity_matrix_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public int n_neighbors_ => ToCsharp<int>(self.GetAttr("n_neighbors_"));

                public SpectralEmbedding fit(NDarray X)
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

                public SpectralEmbedding set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public class TSNE : PythonObject
            {
                public TSNE(int n_components = 2, float perplexity = 30.0f, float early_exaggeration = 12.0f, string learning_rate = "auto", int? max_iter = null, int n_iter_without_progress = 300, float min_grad_norm = 1e-07f, string metric = "euclidean", PyDict? metric_params = null, string init = "pca", int verbose = 0, int? random_state = null, string method = "barnes_hut", float angle = 0.5f, int? n_jobs = null, string n_iter = "deprecated")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_components != 2)
                        pyDict["n_components"] = ToPython(n_components);
                    if (perplexity != 30.0f)
                        pyDict["perplexity"] = ToPython(perplexity);
                    if (early_exaggeration != 12.0f)
                        pyDict["early_exaggeration"] = ToPython(early_exaggeration);
                    if (learning_rate != "auto")
                        pyDict["learning_rate"] = ToPython(learning_rate);
                    if (max_iter != null)
                        pyDict["max_iter"] = ToPython(max_iter);
                    if (n_iter_without_progress != 300)
                        pyDict["n_iter_without_progress"] = ToPython(n_iter_without_progress);
                    if (min_grad_norm != 1e-07f)
                        pyDict["min_grad_norm"] = ToPython(min_grad_norm);
                    if (metric != "euclidean")
                        pyDict["metric"] = ToPython(metric);
                    if (metric_params != null)
                        pyDict["metric_params"] = ToPython(metric_params);
                    if (init != "pca")
                        pyDict["init"] = ToPython(init);
                    if (verbose != 0)
                        pyDict["verbose"] = ToPython(verbose);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    if (method != "barnes_hut")
                        pyDict["method"] = ToPython(method);
                    if (angle != 0.5f)
                        pyDict["angle"] = ToPython(angle);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = ToPython(n_jobs);
                    if (n_iter != "deprecated")
                        pyDict["n_iter"] = ToPython(n_iter);
                    self = sklearn.manifold.self.InvokeMethod("TSNE", args, pyDict);
                }

                internal TSNE(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static TSNE Encapsule(PyObject pyObject)
                {
                    return new TSNE(pyObject);
                }

                public NDarray embedding_ => ToCsharp<NDarray>(self.GetAttr("embedding_"));
                public float kl_divergence_ => ToCsharp<float>(self.GetAttr("kl_divergence_"));
                public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));
                public float learning_rate_ => ToCsharp<float>(self.GetAttr("learning_rate_"));
                public int n_iter_ => ToCsharp<int>(self.GetAttr("n_iter_"));

                public TSNE fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, PyObject? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
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

                public TSNE set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public TSNE set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }
            }

            public static (NDarray, float) locally_linear_embedding(NDarray X, int n_neighbors, int n_components, float reg = 0.001f, string eigen_solver = "auto", float tol = 1e-06f, int max_iter = 100, string method = "standard", float hessian_tol = 0.0001f, float modified_tol = 1e-12f, int? random_state = null, int? n_jobs = null)
            {
                PyTuple args = ToTuple(new object[] { X, n_neighbors, n_components });
                PyDict pyDict = new PyDict();
                if (reg != 0.001f)
                    pyDict["reg"] = ToPython(reg);
                if (eigen_solver != "auto")
                    pyDict["eigen_solver"] = ToPython(eigen_solver);
                if (tol != 1e-06f)
                    pyDict["tol"] = ToPython(tol);
                if (max_iter != 100)
                    pyDict["max_iter"] = ToPython(max_iter);
                if (method != "standard")
                    pyDict["method"] = ToPython(method);
                if (hessian_tol != 0.0001f)
                    pyDict["hessian_tol"] = ToPython(hessian_tol);
                if (modified_tol != 1e-12f)
                    pyDict["modified_tol"] = ToPython(modified_tol);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                PyTuple result = new PyTuple(sklearn.manifold.self.InvokeMethod("locally_linear_embedding", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<float>(result[1]));
            }

            public static (NDarray, string, int) smacof(NDarray dissimilarities, bool metric = true, int n_components = 2, NDarray? init = null, int n_init = 8, int? n_jobs = null, int max_iter = 300, int verbose = 0, float eps = 0.001f, int? random_state = null, bool return_n_iter = false, string normalized_stress = "auto")
            {
                PyTuple args = ToTuple(new object[] { dissimilarities });
                PyDict pyDict = new PyDict();
                if (metric != true)
                    pyDict["metric"] = ToPython(metric);
                if (n_components != 2)
                    pyDict["n_components"] = ToPython(n_components);
                if (init != null)
                    pyDict["init"] = ToPython(init);
                if (n_init != 8)
                    pyDict["n_init"] = ToPython(n_init);
                if (n_jobs != null)
                    pyDict["n_jobs"] = ToPython(n_jobs);
                if (max_iter != 300)
                    pyDict["max_iter"] = ToPython(max_iter);
                if (verbose != 0)
                    pyDict["verbose"] = ToPython(verbose);
                if (eps != 0.001f)
                    pyDict["eps"] = ToPython(eps);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (return_n_iter != false)
                    pyDict["return_n_iter"] = ToPython(return_n_iter);
                if (normalized_stress != "auto")
                    pyDict["normalized_stress"] = ToPython(normalized_stress);
                PyTuple result = new PyTuple(sklearn.manifold.self.InvokeMethod("smacof", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<string>(result[1]), ToCsharp<int>(result[2]));
            }

            public static NDarray spectral_embedding(NDarray adjacency, int n_components = 8, PyObject? eigen_solver = null, int? random_state = null, string eigen_tol = "auto", bool norm_laplacian = true, bool drop_first = true)
            {
                PyTuple args = ToTuple(new object[] { adjacency });
                PyDict pyDict = new PyDict();
                if (n_components != 8)
                    pyDict["n_components"] = ToPython(n_components);
                if (eigen_solver != null)
                    pyDict["eigen_solver"] = ToPython(eigen_solver);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (eigen_tol != "auto")
                    pyDict["eigen_tol"] = ToPython(eigen_tol);
                if (norm_laplacian != true)
                    pyDict["norm_laplacian"] = ToPython(norm_laplacian);
                if (drop_first != true)
                    pyDict["drop_first"] = ToPython(drop_first);
                return ToCsharp<NDarray>(sklearn.manifold.self.InvokeMethod("spectral_embedding", args, pyDict));
            }

            public static float trustworthiness(NDarray X, NDarray X_embedded, int n_neighbors = 5, string metric = "euclidean")
            {
                PyTuple args = ToTuple(new object[] { X, X_embedded });
                PyDict pyDict = new PyDict();
                if (n_neighbors != 5)
                    pyDict["n_neighbors"] = ToPython(n_neighbors);
                if (metric != "euclidean")
                    pyDict["metric"] = ToPython(metric);
                return ToCsharp<float>(sklearn.manifold.self.InvokeMethod("trustworthiness", args, pyDict));
            }
        }
    }
}