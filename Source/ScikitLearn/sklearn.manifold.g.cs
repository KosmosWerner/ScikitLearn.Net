namespace ScikitLearn;
#nullable enable
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

        static manifold() => ReInitializeLazySelf();
        public static (NDarray? , float? ) locally_linear_embedding(NDarray X, int n_neighbors, int n_components, float reg = 0.001f, string eigen_solver = "auto", float tol = 1e-06f, int max_iter = 100, string method = "standard", float hessian_tol = 0.0001f, float modified_tol = 1e-12f, int? random_state = null, int? n_jobs = null)
        {
            _ = sklearn.manifold.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(n_neighbors), Helpers.ToPython(n_components) });
            PyDict pyDict = new PyDict();
            if (reg != 0.001f)
                pyDict["reg"] = Helpers.ToPython(reg);
            if (eigen_solver != "auto")
                pyDict["eigen_solver"] = Helpers.ToPython(eigen_solver);
            if (tol != 1e-06f)
                pyDict["tol"] = Helpers.ToPython(tol);
            if (max_iter != 100)
                pyDict["max_iter"] = Helpers.ToPython(max_iter);
            if (method != "standard")
                pyDict["method"] = Helpers.ToPython(method);
            if (hessian_tol != 0.0001f)
                pyDict["hessian_tol"] = Helpers.ToPython(hessian_tol);
            if (modified_tol != 1e-12f)
                pyDict["modified_tol"] = Helpers.ToPython(modified_tol);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            var __pyObject = self.InvokeMethod("locally_linear_embedding", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? __pyObjectTuple[1].As<float>() : null);
        }

        public static (NDarray? , string? , int? ) smacof(NDarray dissimilarities, bool metric = true, int n_components = 2, NDarray? init = null, int n_init = 8, int? n_jobs = null, int max_iter = 300, int verbose = 0, float eps = 0.001f, int? random_state = null, bool return_n_iter = false, string normalized_stress = "auto")
        {
            _ = sklearn.manifold.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(dissimilarities) });
            PyDict pyDict = new PyDict();
            if (metric != true)
                pyDict["metric"] = Helpers.ToPython(metric);
            if (n_components != 2)
                pyDict["n_components"] = Helpers.ToPython(n_components);
            if (init != null)
                pyDict["init"] = Helpers.ToPython(init);
            if (n_init != 8)
                pyDict["n_init"] = Helpers.ToPython(n_init);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (max_iter != 300)
                pyDict["max_iter"] = Helpers.ToPython(max_iter);
            if (verbose != 0)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (eps != 0.001f)
                pyDict["eps"] = Helpers.ToPython(eps);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (return_n_iter != false)
                pyDict["return_n_iter"] = Helpers.ToPython(return_n_iter);
            if (normalized_stress != "auto")
                pyDict["normalized_stress"] = Helpers.ToPython(normalized_stress);
            var __pyObject = self.InvokeMethod("smacof", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? __pyObjectTuple[1].As<string>() : null, __pyObjectLength > 2 ? __pyObjectTuple[2].As<int>() : null);
        }

        public static NDarray spectral_embedding(NDarray adjacency, int n_components = 8, PyObject? eigen_solver = null, int? random_state = null, string eigen_tol = "auto", bool norm_laplacian = true, bool drop_first = true)
        {
            _ = sklearn.manifold.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(adjacency) });
            PyDict pyDict = new PyDict();
            if (n_components != 8)
                pyDict["n_components"] = Helpers.ToPython(n_components);
            if (eigen_solver != null)
                pyDict["eigen_solver"] = Helpers.ToPython(eigen_solver);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (eigen_tol != "auto")
                pyDict["eigen_tol"] = Helpers.ToPython(eigen_tol);
            if (norm_laplacian != true)
                pyDict["norm_laplacian"] = Helpers.ToPython(norm_laplacian);
            if (drop_first != true)
                pyDict["drop_first"] = Helpers.ToPython(drop_first);
            var __pyObject = self.InvokeMethod("spectral_embedding", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static float trustworthiness(NDarray X, NDarray X_embedded, int n_neighbors = 5, string metric = "euclidean")
        {
            _ = sklearn.manifold.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(X_embedded) });
            PyDict pyDict = new PyDict();
            if (n_neighbors != 5)
                pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
            if (metric != "euclidean")
                pyDict["metric"] = Helpers.ToPython(metric);
            var __pyObject = self.InvokeMethod("trustworthiness", args, pyDict);
            return __pyObject.As<float>();
        }

        public class Isomap : PythonObject
        {
            public Isomap(int? n_neighbors = 5, float? radius = null, int n_components = 2, string eigen_solver = "auto", int tol = 0, int? max_iter = null, string path_method = "auto", string neighbors_algorithm = "auto", int? n_jobs = null, string metric = "minkowski", int p = 2, PyDict? metric_params = null)
            {
                _ = sklearn.manifold.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_neighbors != 5)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (radius != null)
                    pyDict["radius"] = Helpers.ToPython(radius);
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (eigen_solver != "auto")
                    pyDict["eigen_solver"] = Helpers.ToPython(eigen_solver);
                if (tol != 0)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (max_iter != null)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (path_method != "auto")
                    pyDict["path_method"] = Helpers.ToPython(path_method);
                if (neighbors_algorithm != "auto")
                    pyDict["neighbors_algorithm"] = Helpers.ToPython(neighbors_algorithm);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (metric != "minkowski")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (p != 2)
                    pyDict["p"] = Helpers.ToPython(p);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                self = sklearn.manifold.self.InvokeMethod("Isomap", args, pyDict);
            }

            internal Isomap(PyObject pyObject)
            {
                _ = sklearn.manifold.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static Isomap Encapsule(PyObject pyObject) => new Isomap(pyObject);
            public static Isomap Wrap(PyObject pyObject) => new Isomap(pyObject);
            public NDarray embedding_
            {
                get
                {
                    var __pyObject = self.GetAttr("embedding_");
                    return new NDarray(__pyObject);
                }
            }

            public PyObject kernel_pca_
            {
                get
                {
                    var __pyObject = self.GetAttr("kernel_pca_");
                    return __pyObject;
                }
            }

            public PyObject nbrs_
            {
                get
                {
                    var __pyObject = self.GetAttr("nbrs_");
                    return __pyObject;
                }
            }

            public NDarray dist_matrix_
            {
                get
                {
                    var __pyObject = self.GetAttr("dist_matrix_");
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

            public Isomap fit(NDarray X)
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

            public string reconstruction_error()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("reconstruction_error", args, pyDict);
                return __pyObject.As<string>();
            }

            public Isomap set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public Isomap set_params(Dictionary<string, PyObject>? @params = null)
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

        public class LocallyLinearEmbedding : PythonObject
        {
            public LocallyLinearEmbedding(int n_neighbors = 5, int n_components = 2, float reg = 0.001f, string eigen_solver = "auto", float tol = 1e-06f, int max_iter = 100, string method = "standard", float hessian_tol = 0.0001f, float modified_tol = 1e-12f, string neighbors_algorithm = "auto", int? random_state = null, int? n_jobs = null)
            {
                _ = sklearn.manifold.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_neighbors != 5)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (reg != 0.001f)
                    pyDict["reg"] = Helpers.ToPython(reg);
                if (eigen_solver != "auto")
                    pyDict["eigen_solver"] = Helpers.ToPython(eigen_solver);
                if (tol != 1e-06f)
                    pyDict["tol"] = Helpers.ToPython(tol);
                if (max_iter != 100)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (method != "standard")
                    pyDict["method"] = Helpers.ToPython(method);
                if (hessian_tol != 0.0001f)
                    pyDict["hessian_tol"] = Helpers.ToPython(hessian_tol);
                if (modified_tol != 1e-12f)
                    pyDict["modified_tol"] = Helpers.ToPython(modified_tol);
                if (neighbors_algorithm != "auto")
                    pyDict["neighbors_algorithm"] = Helpers.ToPython(neighbors_algorithm);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.manifold.self.InvokeMethod("LocallyLinearEmbedding", args, pyDict);
            }

            internal LocallyLinearEmbedding(PyObject pyObject)
            {
                _ = sklearn.manifold.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LocallyLinearEmbedding Encapsule(PyObject pyObject) => new LocallyLinearEmbedding(pyObject);
            public static LocallyLinearEmbedding Wrap(PyObject pyObject) => new LocallyLinearEmbedding(pyObject);
            public NDarray embedding_
            {
                get
                {
                    var __pyObject = self.GetAttr("embedding_");
                    return new NDarray(__pyObject);
                }
            }

            public float reconstruction_error_
            {
                get
                {
                    var __pyObject = self.GetAttr("reconstruction_error_");
                    return __pyObject.As<float>();
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

            public PyObject nbrs_
            {
                get
                {
                    var __pyObject = self.GetAttr("nbrs_");
                    return __pyObject;
                }
            }

            public LocallyLinearEmbedding fit(NDarray X)
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

            public LocallyLinearEmbedding set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public LocallyLinearEmbedding set_params(Dictionary<string, PyObject>? @params = null)
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

        public class MDS : PythonObject
        {
            public MDS(int n_components = 2, bool metric = true, int n_init = 4, int max_iter = 300, int verbose = 0, float eps = 0.001f, int? n_jobs = null, int? random_state = null, string dissimilarity = "euclidean", string normalized_stress = "auto")
            {
                _ = sklearn.manifold.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (metric != true)
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (n_init != 4)
                    pyDict["n_init"] = Helpers.ToPython(n_init);
                if (max_iter != 300)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (eps != 0.001f)
                    pyDict["eps"] = Helpers.ToPython(eps);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (dissimilarity != "euclidean")
                    pyDict["dissimilarity"] = Helpers.ToPython(dissimilarity);
                if (normalized_stress != "auto")
                    pyDict["normalized_stress"] = Helpers.ToPython(normalized_stress);
                self = sklearn.manifold.self.InvokeMethod("MDS", args, pyDict);
            }

            internal MDS(PyObject pyObject)
            {
                _ = sklearn.manifold.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static MDS Encapsule(PyObject pyObject) => new MDS(pyObject);
            public static MDS Wrap(PyObject pyObject) => new MDS(pyObject);
            public NDarray embedding_
            {
                get
                {
                    var __pyObject = self.GetAttr("embedding_");
                    return new NDarray(__pyObject);
                }
            }

            public float stress_
            {
                get
                {
                    var __pyObject = self.GetAttr("stress_");
                    return __pyObject.As<float>();
                }
            }

            public NDarray dissimilarity_matrix_
            {
                get
                {
                    var __pyObject = self.GetAttr("dissimilarity_matrix_");
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

            public int n_iter_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iter_");
                    return __pyObject.As<int>();
                }
            }

            public MDS fit(NDarray X, NDarray? init = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (init != null)
                    pyDict["init"] = Helpers.ToPython(init);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X, NDarray? init = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (init != null)
                    pyDict["init"] = Helpers.ToPython(init);
                var __pyObject = self.InvokeMethod("fit_transform", args, pyDict);
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

            public MDS set_fit_request(string? init = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (init != "$UNCHANGED$")
                    pyDict["init"] = Helpers.ToPython(init);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public MDS set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class SpectralEmbedding : PythonObject
        {
            public SpectralEmbedding(int n_components = 2, string affinity = "nearest_neighbors", float? gamma = null, int? random_state = null, PyObject? eigen_solver = null, string eigen_tol = "auto", int? n_neighbors = null, int? n_jobs = null)
            {
                _ = sklearn.manifold.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (affinity != "nearest_neighbors")
                    pyDict["affinity"] = Helpers.ToPython(affinity);
                if (gamma != null)
                    pyDict["gamma"] = Helpers.ToPython(gamma);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (eigen_solver != null)
                    pyDict["eigen_solver"] = Helpers.ToPython(eigen_solver);
                if (eigen_tol != "auto")
                    pyDict["eigen_tol"] = Helpers.ToPython(eigen_tol);
                if (n_neighbors != null)
                    pyDict["n_neighbors"] = Helpers.ToPython(n_neighbors);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                self = sklearn.manifold.self.InvokeMethod("SpectralEmbedding", args, pyDict);
            }

            internal SpectralEmbedding(PyObject pyObject)
            {
                _ = sklearn.manifold.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static SpectralEmbedding Encapsule(PyObject pyObject) => new SpectralEmbedding(pyObject);
            public static SpectralEmbedding Wrap(PyObject pyObject) => new SpectralEmbedding(pyObject);
            public NDarray embedding_
            {
                get
                {
                    var __pyObject = self.GetAttr("embedding_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray affinity_matrix_
            {
                get
                {
                    var __pyObject = self.GetAttr("affinity_matrix_");
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

            public int n_neighbors_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_neighbors_");
                    return __pyObject.As<int>();
                }
            }

            public SpectralEmbedding fit(NDarray X)
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

            public SpectralEmbedding set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class TSNE : PythonObject
        {
            public TSNE(int n_components = 2, float perplexity = 30.0f, float early_exaggeration = 12.0f, string learning_rate = "auto", int? max_iter = null, int n_iter_without_progress = 300, float min_grad_norm = 1e-07f, string metric = "euclidean", PyDict? metric_params = null, string init = "pca", int verbose = 0, int? random_state = null, string method = "barnes_hut", float angle = 0.5f, int? n_jobs = null, string n_iter = "deprecated")
            {
                _ = sklearn.manifold.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_components != 2)
                    pyDict["n_components"] = Helpers.ToPython(n_components);
                if (perplexity != 30.0f)
                    pyDict["perplexity"] = Helpers.ToPython(perplexity);
                if (early_exaggeration != 12.0f)
                    pyDict["early_exaggeration"] = Helpers.ToPython(early_exaggeration);
                if (learning_rate != "auto")
                    pyDict["learning_rate"] = Helpers.ToPython(learning_rate);
                if (max_iter != null)
                    pyDict["max_iter"] = Helpers.ToPython(max_iter);
                if (n_iter_without_progress != 300)
                    pyDict["n_iter_without_progress"] = Helpers.ToPython(n_iter_without_progress);
                if (min_grad_norm != 1e-07f)
                    pyDict["min_grad_norm"] = Helpers.ToPython(min_grad_norm);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (metric_params != null)
                    pyDict["metric_params"] = Helpers.ToPython(metric_params);
                if (init != "pca")
                    pyDict["init"] = Helpers.ToPython(init);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (method != "barnes_hut")
                    pyDict["method"] = Helpers.ToPython(method);
                if (angle != 0.5f)
                    pyDict["angle"] = Helpers.ToPython(angle);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (n_iter != "deprecated")
                    pyDict["n_iter"] = Helpers.ToPython(n_iter);
                self = sklearn.manifold.self.InvokeMethod("TSNE", args, pyDict);
            }

            internal TSNE(PyObject pyObject)
            {
                _ = sklearn.manifold.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static TSNE Encapsule(PyObject pyObject) => new TSNE(pyObject);
            public static TSNE Wrap(PyObject pyObject) => new TSNE(pyObject);
            public NDarray embedding_
            {
                get
                {
                    var __pyObject = self.GetAttr("embedding_");
                    return new NDarray(__pyObject);
                }
            }

            public float kl_divergence_
            {
                get
                {
                    var __pyObject = self.GetAttr("kl_divergence_");
                    return __pyObject.As<float>();
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

            public float learning_rate_
            {
                get
                {
                    var __pyObject = self.GetAttr("learning_rate_");
                    return __pyObject.As<float>();
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

            public TSNE fit(NDarray X, PyObject? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(NDarray X, PyObject? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public TSNE set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public TSNE set_params(Dictionary<string, PyObject>? @params = null)
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