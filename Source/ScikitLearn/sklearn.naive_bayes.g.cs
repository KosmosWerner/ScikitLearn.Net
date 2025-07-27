namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class naive_bayes
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
            return Py.Import("sklearn.naive_bayes");
        }

        static naive_bayes()
        {
            ReInitializeLazySelf();
        }

        public class BernoulliNB : PythonObject
        {
            public BernoulliNB(float alpha = 1.0f, bool force_alpha = true, float? binarize = 0.0f, bool fit_prior = true, NDarray? class_prior = null)
            {
                _ = sklearn.naive_bayes.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (alpha != 1.0f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (force_alpha != true)
                    pyDict["force_alpha"] = Helpers.ToPython(force_alpha);
                if (binarize != 0.0f)
                    pyDict["binarize"] = Helpers.ToPython(binarize);
                if (fit_prior != true)
                    pyDict["fit_prior"] = Helpers.ToPython(fit_prior);
                if (class_prior != null)
                    pyDict["class_prior"] = Helpers.ToPython(class_prior);
                self = sklearn.naive_bayes.self.InvokeMethod("BernoulliNB", args, pyDict);
            }

            internal BernoulliNB(PyObject pyObject)
            {
                _ = sklearn.naive_bayes.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static BernoulliNB Encapsule(PyObject pyObject) => new BernoulliNB(pyObject);
            public static BernoulliNB Wrap(PyObject pyObject) => new BernoulliNB(pyObject);
            public NDarray class_count_ => new NotImplementedException();
            public NDarray class_log_prior_ => new NotImplementedException();
            public NDarray classes_ => new NotImplementedException();
            public NDarray feature_count_ => new NotImplementedException();
            public NDarray feature_log_prob_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public BernoulliNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public BernoulliNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
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

            public NDarray predict_joint_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

            public BernoulliNB set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public BernoulliNB set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public BernoulliNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public BernoulliNB set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class CategoricalNB : PythonObject
        {
            public CategoricalNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null, NDarray? min_categories = null)
            {
                _ = sklearn.naive_bayes.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (alpha != 1.0f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (force_alpha != true)
                    pyDict["force_alpha"] = Helpers.ToPython(force_alpha);
                if (fit_prior != true)
                    pyDict["fit_prior"] = Helpers.ToPython(fit_prior);
                if (class_prior != null)
                    pyDict["class_prior"] = Helpers.ToPython(class_prior);
                if (min_categories != null)
                    pyDict["min_categories"] = Helpers.ToPython(min_categories);
                self = sklearn.naive_bayes.self.InvokeMethod("CategoricalNB", args, pyDict);
            }

            internal CategoricalNB(PyObject pyObject)
            {
                _ = sklearn.naive_bayes.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static CategoricalNB Encapsule(PyObject pyObject) => new CategoricalNB(pyObject);
            public static CategoricalNB Wrap(PyObject pyObject) => new CategoricalNB(pyObject);
            public NDarray category_count_ => new NotImplementedException();
            public NDarray class_count_ => new NotImplementedException();
            public NDarray class_log_prior_ => new NotImplementedException();
            public NDarray classes_ => new NotImplementedException();
            public NDarray feature_log_prob_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();
            public NDarray<long> n_categories_ => new NotImplementedException();

            public CategoricalNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public CategoricalNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
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

            public NDarray predict_joint_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

            public CategoricalNB set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public CategoricalNB set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public CategoricalNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public CategoricalNB set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class ComplementNB : PythonObject
        {
            public ComplementNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null, bool norm = false)
            {
                _ = sklearn.naive_bayes.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (alpha != 1.0f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (force_alpha != true)
                    pyDict["force_alpha"] = Helpers.ToPython(force_alpha);
                if (fit_prior != true)
                    pyDict["fit_prior"] = Helpers.ToPython(fit_prior);
                if (class_prior != null)
                    pyDict["class_prior"] = Helpers.ToPython(class_prior);
                if (norm != false)
                    pyDict["norm"] = Helpers.ToPython(norm);
                self = sklearn.naive_bayes.self.InvokeMethod("ComplementNB", args, pyDict);
            }

            internal ComplementNB(PyObject pyObject)
            {
                _ = sklearn.naive_bayes.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static ComplementNB Encapsule(PyObject pyObject) => new ComplementNB(pyObject);
            public static ComplementNB Wrap(PyObject pyObject) => new ComplementNB(pyObject);
            public NDarray class_count_ => new NotImplementedException();
            public NDarray class_log_prior_ => new NotImplementedException();
            public NDarray classes_ => new NotImplementedException();
            public NDarray feature_all_ => new NotImplementedException();
            public NDarray feature_count_ => new NotImplementedException();
            public NDarray feature_log_prob_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public ComplementNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public ComplementNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
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

            public NDarray predict_joint_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

            public ComplementNB set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public ComplementNB set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public ComplementNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public ComplementNB set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class GaussianNB : PythonObject
        {
            public GaussianNB(NDarray? priors = null, float var_smoothing = 1e-09f)
            {
                _ = sklearn.naive_bayes.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (priors != null)
                    pyDict["priors"] = Helpers.ToPython(priors);
                if (var_smoothing != 1e-09f)
                    pyDict["var_smoothing"] = Helpers.ToPython(var_smoothing);
                self = sklearn.naive_bayes.self.InvokeMethod("GaussianNB", args, pyDict);
            }

            internal GaussianNB(PyObject pyObject)
            {
                _ = sklearn.naive_bayes.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static GaussianNB Encapsule(PyObject pyObject) => new GaussianNB(pyObject);
            public static GaussianNB Wrap(PyObject pyObject) => new GaussianNB(pyObject);
            public NDarray class_count_ => new NotImplementedException();
            public NDarray class_prior_ => new NotImplementedException();
            public NDarray classes_ => new NotImplementedException();
            public float epsilon_ => self.GetAttr("epsilon_").As<float>()public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();
            public NDarray var_ => new NotImplementedException();
            public NDarray theta_ => new NotImplementedException();

            public GaussianNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public GaussianNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
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

            public NDarray predict_joint_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

            public GaussianNB set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public GaussianNB set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public GaussianNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public GaussianNB set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class MultinomialNB : PythonObject
        {
            public MultinomialNB(float alpha = 1.0f, bool force_alpha = true, bool fit_prior = true, NDarray? class_prior = null)
            {
                _ = sklearn.naive_bayes.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (alpha != 1.0f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (force_alpha != true)
                    pyDict["force_alpha"] = Helpers.ToPython(force_alpha);
                if (fit_prior != true)
                    pyDict["fit_prior"] = Helpers.ToPython(fit_prior);
                if (class_prior != null)
                    pyDict["class_prior"] = Helpers.ToPython(class_prior);
                self = sklearn.naive_bayes.self.InvokeMethod("MultinomialNB", args, pyDict);
            }

            internal MultinomialNB(PyObject pyObject)
            {
                _ = sklearn.naive_bayes.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static MultinomialNB Encapsule(PyObject pyObject) => new MultinomialNB(pyObject);
            public static MultinomialNB Wrap(PyObject pyObject) => new MultinomialNB(pyObject);
            public NDarray class_count_ => new NotImplementedException();
            public NDarray class_log_prior_ => new NotImplementedException();
            public NDarray classes_ => new NotImplementedException();
            public NDarray feature_count_ => new NotImplementedException();
            public NDarray feature_log_prob_ => new NotImplementedException();
            public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

            public MultinomialNB fit(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public MultinomialNB partial_fit(NDarray X, NDarray y, NDarray? classes = null, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (classes != null)
                    pyDict["classes"] = Helpers.ToPython(classes);
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

            public NDarray predict_joint_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}

            public MultinomialNB set_fit_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public MultinomialNB set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public MultinomialNB set_partial_fit_request(string? classes = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (classes != "$UNCHANGED$")
                    pyDict["classes"] = Helpers.ToPython(classes);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_partial_fit_request", args, pyDict);
                return this;
            }

            public MultinomialNB set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }
    }
}