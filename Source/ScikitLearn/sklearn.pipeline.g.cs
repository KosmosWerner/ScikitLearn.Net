namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class pipeline
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
            return Py.Import("sklearn.pipeline");
        }

        static pipeline() => ReInitializeLazySelf();
        public static PyObject make_pipeline(PyObject[] steps, PyObject? memory = null, bool verbose = false)
        {
            _ = sklearn.pipeline.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(steps) });
            PyDict pyDict = new PyDict();
            if (memory != null)
                pyDict["memory"] = Helpers.ToPython(memory);
            if (verbose != false)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            var __pyObject = self.InvokeMethod("make_pipeline", args, pyDict);
            return __pyObject;
        }

        public static PyObject make_union(PyObject[] transformers, int? n_jobs = null, bool verbose = false)
        {
            _ = sklearn.pipeline.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(transformers) });
            PyDict pyDict = new PyDict();
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (verbose != false)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            var __pyObject = self.InvokeMethod("make_union", args, pyDict);
            return __pyObject;
        }

        public class FeatureUnion : PythonObject
        {
            public FeatureUnion(PyTuple transformer_list, int? n_jobs = null, PyDict? transformer_weights = null, bool verbose = false, bool verbose_feature_names_out = true)
            {
                _ = sklearn.pipeline.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(transformer_list) });
                PyDict pyDict = new PyDict();
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (transformer_weights != null)
                    pyDict["transformer_weights"] = Helpers.ToPython(transformer_weights);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (verbose_feature_names_out != true)
                    pyDict["verbose_feature_names_out"] = Helpers.ToPython(verbose_feature_names_out);
                self = sklearn.pipeline.self.InvokeMethod("FeatureUnion", args, pyDict);
            }

            internal FeatureUnion(PyObject pyObject)
            {
                _ = sklearn.pipeline.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static FeatureUnion Encapsule(PyObject pyObject) => new FeatureUnion(pyObject);
            public static FeatureUnion Wrap(PyObject pyObject) => new FeatureUnion(pyObject);
            public PyDict named_transformers
            {
                get
                {
                    var __pyObject = self.GetAttr("named_transformers");
                    return new PyDict(__pyObject);
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

            public FeatureUnion fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public string get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return __pyObject.As<string>();
            }

            public FeatureUnion set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public FeatureUnion set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public NDarray transform(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class Pipeline : PythonObject
        {
            public Pipeline(PyTuple steps, PyObject? memory = null, bool verbose = false)
            {
                _ = sklearn.pipeline.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(steps) });
                PyDict pyDict = new PyDict();
                if (memory != null)
                    pyDict["memory"] = Helpers.ToPython(memory);
                if (verbose != false)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.pipeline.self.InvokeMethod("Pipeline", args, pyDict);
            }

            internal Pipeline(PyObject pyObject)
            {
                _ = sklearn.pipeline.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static Pipeline Encapsule(PyObject pyObject) => new Pipeline(pyObject);
            public static Pipeline Wrap(PyObject pyObject) => new Pipeline(pyObject);
            public PyDict named_steps
            {
                get
                {
                    var __pyObject = self.GetAttr("named_steps");
                    return new PyDict(__pyObject);
                }
            }

            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
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

            public NDarray decision_function(PyObject X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public Pipeline fit(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_predict(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("fit_predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray fit_transform(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
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

            public string get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return __pyObject.As<string>();
            }

            public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (Xt != null)
                    pyDict["Xt"] = Helpers.ToPython(Xt);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("inverse_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict(PyObject X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(PyObject X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(PyObject X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(PyObject X, PyObject? y = null, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public NDarray score_samples(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score_samples", args, pyDict);
                return new NDarray(__pyObject);
            }

            public Pipeline set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public Pipeline set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public Pipeline set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }

            public NDarray transform(PyObject X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }
    }
}