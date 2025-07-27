namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class feature_extraction
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
            return Py.Import("sklearn.feature_extraction");
        }

        static feature_extraction()
        {
            ReInitializeLazySelf();
        }

        public class DictVectorizer : PythonObject
        {
            public DictVectorizer(float? dtype = null, string separator = "=", bool sparse = true, bool sort = true)
            {
                _ = sklearn.feature_extraction.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (dtype != null)
                    pyDict["dtype"] = Helpers.ToPython(dtype);
                if (separator != "=")
                    pyDict["separator"] = Helpers.ToPython(separator);
                if (sparse != true)
                    pyDict["sparse"] = Helpers.ToPython(sparse);
                if (sort != true)
                    pyDict["sort"] = Helpers.ToPython(sort);
                self = sklearn.feature_extraction.self.InvokeMethod("DictVectorizer", args, pyDict);
            }

            internal DictVectorizer(PyObject pyObject)
            {
                _ = sklearn.feature_extraction.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static DictVectorizer Encapsule(PyObject pyObject) => new DictVectorizer(pyObject);
            public static DictVectorizer Wrap(PyObject pyObject) => new DictVectorizer(pyObject);
            public PyDict vocabulary_ => new NotImplementedException();
            public PyObject feature_names_ => new NotImplementedException();

            public DictVectorizer fit(PyObject X, PyObject? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public NDarray fit_transform(PyObject X, PyObject? y = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                return new NotImplementedException();
            }

            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                return new NotImplementedException();
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

            public PyObject inverse_transform(NDarray X, PyDict? dict_type = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (dict_type != null)
                    pyDict["dict_type"] = Helpers.ToPython(dict_type);
                return new NotImplementedException();
            }

            public DictVectorizer restrict(NDarray support, bool indices = false)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(support) });
                PyDict pyDict = new PyDict();
                if (indices != false)
                    pyDict["indices"] = Helpers.ToPython(indices);
                self.InvokeMethod("restrict", args, pyDict);
                return this;
            }

            public DictVectorizer set_inverse_transform_request(string? dict_type = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (dict_type != "$UNCHANGED$")
                    pyDict["dict_type"] = Helpers.ToPython(dict_type);
                self.InvokeMethod("set_inverse_transform_request", args, pyDict);
                return this;
            }

            public DictVectorizer set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public DictVectorizer set_params(Dictionary<string, PyObject>? @params = null)
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
                return new NotImplementedException();
            }
        }

        public class FeatureHasher : PythonObject
        {
            public FeatureHasher(int n_features = 1048576, string input_type = "dict", float? dtype = null, bool alternate_sign = true)
            {
                _ = sklearn.feature_extraction.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_features != 1048576)
                    pyDict["n_features"] = Helpers.ToPython(n_features);
                if (input_type != "dict")
                    pyDict["input_type"] = Helpers.ToPython(input_type);
                if (dtype != null)
                    pyDict["dtype"] = Helpers.ToPython(dtype);
                if (alternate_sign != true)
                    pyDict["alternate_sign"] = Helpers.ToPython(alternate_sign);
                self = sklearn.feature_extraction.self.InvokeMethod("FeatureHasher", args, pyDict);
            }

            internal FeatureHasher(PyObject pyObject)
            {
                _ = sklearn.feature_extraction.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static FeatureHasher Encapsule(PyObject pyObject) => new FeatureHasher(pyObject);
            public static FeatureHasher Wrap(PyObject pyObject) => new FeatureHasher(pyObject);
            public FeatureHasher fit()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
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
                return new NotImplementedException();
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

            public FeatureHasher set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }

            public FeatureHasher set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public FeatureHasher set_transform_request(string? raw_X = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (raw_X != "$UNCHANGED$")
                    pyDict["raw_X"] = Helpers.ToPython(raw_X);
                self.InvokeMethod("set_transform_request", args, pyDict);
                return this;
            }

            public NDarray transform(PyObject raw_X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(raw_X) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }
        }

        public static class image
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
                return Py.Import("sklearn.feature_extraction.image");
            }

            static image()
            {
                ReInitializeLazySelf();
            }

            public static NDarray extract_patches_2d(NDarray image, int patch_size, float? max_patches = null, int? random_state = null)
            {
                _ = sklearn.feature_extraction.image.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(image), Helpers.ToPython(patch_size) });
                PyDict pyDict = new PyDict();
                if (max_patches != null)
                    pyDict["max_patches"] = Helpers.ToPython(max_patches);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                return new NotImplementedException();
            }

            public static NDarray grid_to_graph(int n_x, int n_y, int n_z = 1, NDarray? mask = null, NDarray? return_as = null, int? dtype = null)
            {
                _ = sklearn.feature_extraction.image.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_x), Helpers.ToPython(n_y) });
                PyDict pyDict = new PyDict();
                if (n_z != 1)
                    pyDict["n_z"] = Helpers.ToPython(n_z);
                if (mask != null)
                    pyDict["mask"] = Helpers.ToPython(mask);
                if (return_as != null)
                    pyDict["return_as"] = Helpers.ToPython(return_as);
                if (dtype != null)
                    pyDict["dtype"] = Helpers.ToPython(dtype);
                return new NotImplementedException();
            }

            public static NDarray img_to_graph(NDarray img, NDarray? mask = null, NDarray? return_as = null, PyObject? dtype = null)
            {
                _ = sklearn.feature_extraction.image.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(img) });
                PyDict pyDict = new PyDict();
                if (mask != null)
                    pyDict["mask"] = Helpers.ToPython(mask);
                if (return_as != null)
                    pyDict["return_as"] = Helpers.ToPython(return_as);
                if (dtype != null)
                    pyDict["dtype"] = Helpers.ToPython(dtype);
                return new NotImplementedException();
            }

            public static NDarray reconstruct_from_patches_2d(NDarray patches, int image_size)
            {
                _ = sklearn.feature_extraction.image.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(patches), Helpers.ToPython(image_size) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public class PatchExtractor : PythonObject
            {
                public PatchExtractor(int? patch_size = null, float? max_patches = null, int? random_state = null)
                {
                    _ = sklearn.feature_extraction.image.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (patch_size != null)
                        pyDict["patch_size"] = Helpers.ToPython(patch_size);
                    if (max_patches != null)
                        pyDict["max_patches"] = Helpers.ToPython(max_patches);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    self = sklearn.feature_extraction.image.self.InvokeMethod("PatchExtractor", args, pyDict);
                }

                internal PatchExtractor(PyObject pyObject)
                {
                    _ = sklearn.feature_extraction.image.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static PatchExtractor Encapsule(PyObject pyObject) => new PatchExtractor(pyObject);
                public static PatchExtractor Wrap(PyObject pyObject) => new PatchExtractor(pyObject);
                public PatchExtractor fit(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
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
                    return new NotImplementedException();
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

                public PatchExtractor set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public PatchExtractor set_params(Dictionary<string, PyObject>? @params = null)
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
                    return new NotImplementedException();
                }
            }
        }

        public static class text
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
                return Py.Import("sklearn.feature_extraction.text");
            }

            static text()
            {
                ReInitializeLazySelf();
            }

            public class CountVectorizer : PythonObject
            {
                public CountVectorizer(string input = "content", string encoding = "utf-8", string decode_error = "strict", PyObject? strip_accents = null, bool lowercase = true, PyObject? preprocessor = null, PyObject? tokenizer = null, PyObject? stop_words = null, string? token_pattern = "(?u)\\b\\w\\w+\\b", PyTuple? ngram_range = null, string analyzer = "word", float max_df = 1.0f, int min_df = 1, int? max_features = null, PyObject? vocabulary = null, bool binary = false, int? dtype = null)
                {
                    _ = sklearn.feature_extraction.text.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (input != "content")
                        pyDict["input"] = Helpers.ToPython(input);
                    if (encoding != "utf-8")
                        pyDict["encoding"] = Helpers.ToPython(encoding);
                    if (decode_error != "strict")
                        pyDict["decode_error"] = Helpers.ToPython(decode_error);
                    if (strip_accents != null)
                        pyDict["strip_accents"] = Helpers.ToPython(strip_accents);
                    if (lowercase != true)
                        pyDict["lowercase"] = Helpers.ToPython(lowercase);
                    if (preprocessor != null)
                        pyDict["preprocessor"] = Helpers.ToPython(preprocessor);
                    if (tokenizer != null)
                        pyDict["tokenizer"] = Helpers.ToPython(tokenizer);
                    if (stop_words != null)
                        pyDict["stop_words"] = Helpers.ToPython(stop_words);
                    if (token_pattern != "(?u)\\b\\w\\w+\\b")
                        pyDict["token_pattern"] = Helpers.ToPython(token_pattern);
                    if (ngram_range != null)
                        pyDict["ngram_range"] = Helpers.ToPython(ngram_range);
                    if (analyzer != "word")
                        pyDict["analyzer"] = Helpers.ToPython(analyzer);
                    if (max_df != 1.0f)
                        pyDict["max_df"] = Helpers.ToPython(max_df);
                    if (min_df != 1)
                        pyDict["min_df"] = Helpers.ToPython(min_df);
                    if (max_features != null)
                        pyDict["max_features"] = Helpers.ToPython(max_features);
                    if (vocabulary != null)
                        pyDict["vocabulary"] = Helpers.ToPython(vocabulary);
                    if (binary != false)
                        pyDict["binary"] = Helpers.ToPython(binary);
                    if (dtype != null)
                        pyDict["dtype"] = Helpers.ToPython(dtype);
                    self = sklearn.feature_extraction.text.self.InvokeMethod("CountVectorizer", args, pyDict);
                }

                internal CountVectorizer(PyObject pyObject)
                {
                    _ = sklearn.feature_extraction.text.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static CountVectorizer Encapsule(PyObject pyObject) => new CountVectorizer(pyObject);
                public static CountVectorizer Wrap(PyObject pyObject) => new CountVectorizer(pyObject);
                public PyDict vocabulary_ => new NotImplementedException();
                public bool fixed_vocabulary_ => self.GetAttr("fixed_vocabulary_").As<bool>()public PyObject build_analyzer()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public PyObject build_preprocessor()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public PyObject build_tokenizer()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public string decode(string doc)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(doc) });
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("decode", args, pyDict).As<string>()}

                public CountVectorizer fit(PyObject raw_documents, PyObject? y = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(raw_documents) });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(PyObject raw_documents, PyObject? y = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(raw_documents) });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    return new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
                    return new NotImplementedException();
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

                public void get_stop_words()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public CountVectorizer set_fit_request(string? raw_documents = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (raw_documents != "$UNCHANGED$")
                        pyDict["raw_documents"] = Helpers.ToPython(raw_documents);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public CountVectorizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public CountVectorizer set_transform_request(string? raw_documents = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (raw_documents != "$UNCHANGED$")
                        pyDict["raw_documents"] = Helpers.ToPython(raw_documents);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(PyObject raw_documents)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(raw_documents) });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }
            }

            public class HashingVectorizer : PythonObject
            {
                public HashingVectorizer(string input = "content", string encoding = "utf-8", string decode_error = "strict", PyObject? strip_accents = null, bool lowercase = true, PyObject? preprocessor = null, PyObject? tokenizer = null, PyObject? stop_words = null, string? token_pattern = "(?u)\\b\\w\\w+\\b", PyTuple? ngram_range = null, string analyzer = "word", int n_features = 1048576, bool binary = false, string norm = "l2", bool alternate_sign = true, float? dtype = null)
                {
                    _ = sklearn.feature_extraction.text.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (input != "content")
                        pyDict["input"] = Helpers.ToPython(input);
                    if (encoding != "utf-8")
                        pyDict["encoding"] = Helpers.ToPython(encoding);
                    if (decode_error != "strict")
                        pyDict["decode_error"] = Helpers.ToPython(decode_error);
                    if (strip_accents != null)
                        pyDict["strip_accents"] = Helpers.ToPython(strip_accents);
                    if (lowercase != true)
                        pyDict["lowercase"] = Helpers.ToPython(lowercase);
                    if (preprocessor != null)
                        pyDict["preprocessor"] = Helpers.ToPython(preprocessor);
                    if (tokenizer != null)
                        pyDict["tokenizer"] = Helpers.ToPython(tokenizer);
                    if (stop_words != null)
                        pyDict["stop_words"] = Helpers.ToPython(stop_words);
                    if (token_pattern != "(?u)\\b\\w\\w+\\b")
                        pyDict["token_pattern"] = Helpers.ToPython(token_pattern);
                    if (ngram_range != null)
                        pyDict["ngram_range"] = Helpers.ToPython(ngram_range);
                    if (analyzer != "word")
                        pyDict["analyzer"] = Helpers.ToPython(analyzer);
                    if (n_features != 1048576)
                        pyDict["n_features"] = Helpers.ToPython(n_features);
                    if (binary != false)
                        pyDict["binary"] = Helpers.ToPython(binary);
                    if (norm != "l2")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (alternate_sign != true)
                        pyDict["alternate_sign"] = Helpers.ToPython(alternate_sign);
                    if (dtype != null)
                        pyDict["dtype"] = Helpers.ToPython(dtype);
                    self = sklearn.feature_extraction.text.self.InvokeMethod("HashingVectorizer", args, pyDict);
                }

                internal HashingVectorizer(PyObject pyObject)
                {
                    _ = sklearn.feature_extraction.text.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static HashingVectorizer Encapsule(PyObject pyObject) => new HashingVectorizer(pyObject);
                public static HashingVectorizer Wrap(PyObject pyObject) => new HashingVectorizer(pyObject);
                public PyObject build_analyzer()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public PyObject build_preprocessor()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public PyObject build_tokenizer()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public string decode(string doc)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(doc) });
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("decode", args, pyDict).As<string>()}

                public HashingVectorizer fit(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(PyObject X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    return new NotImplementedException();
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

                public void get_stop_words()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public HashingVectorizer partial_fit(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("partial_fit", args, pyDict);
                    return this;
                }

                public HashingVectorizer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public HashingVectorizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public NDarray transform(PyObject X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }
            }

            public class TfidfTransformer : PythonObject
            {
                public TfidfTransformer(string? norm = "l2", bool use_idf = true, bool smooth_idf = true, bool sublinear_tf = false)
                {
                    _ = sklearn.feature_extraction.text.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (norm != "l2")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (use_idf != true)
                        pyDict["use_idf"] = Helpers.ToPython(use_idf);
                    if (smooth_idf != true)
                        pyDict["smooth_idf"] = Helpers.ToPython(smooth_idf);
                    if (sublinear_tf != false)
                        pyDict["sublinear_tf"] = Helpers.ToPython(sublinear_tf);
                    self = sklearn.feature_extraction.text.self.InvokeMethod("TfidfTransformer", args, pyDict);
                }

                internal TfidfTransformer(PyObject pyObject)
                {
                    _ = sklearn.feature_extraction.text.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static TfidfTransformer Encapsule(PyObject pyObject) => new TfidfTransformer(pyObject);
                public static TfidfTransformer Wrap(PyObject pyObject) => new TfidfTransformer(pyObject);
                public NDarray idf_ => new NotImplementedException();
                public int n_features_in_ => self.GetAttr("n_features_in_").As<int>()public NDarray feature_names_in_ => new NotImplementedException();

                public TfidfTransformer fit(NDarray X, PyObject? y = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
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
                    return new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
                    return new NotImplementedException();
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

                public TfidfTransformer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public TfidfTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public TfidfTransformer set_transform_request(string? copy = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (copy != "$UNCHANGED$")
                        pyDict["copy"] = Helpers.ToPython(copy);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(PyObject X, bool copy = true)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return new NotImplementedException();
                }
            }

            public class TfidfVectorizer : PythonObject
            {
                public TfidfVectorizer(string input = "content", string encoding = "utf-8", string decode_error = "strict", PyObject? strip_accents = null, bool lowercase = true, PyObject? preprocessor = null, PyObject? tokenizer = null, string analyzer = "word", PyObject? stop_words = null, string token_pattern = "(?u)\\b\\w\\w+\\b", PyTuple? ngram_range = null, float max_df = 1.0f, int min_df = 1, int? max_features = null, PyObject? vocabulary = null, bool binary = false, float? dtype = null, string? norm = "l2", bool use_idf = true, bool smooth_idf = true, bool sublinear_tf = false)
                {
                    _ = sklearn.feature_extraction.text.self;
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (input != "content")
                        pyDict["input"] = Helpers.ToPython(input);
                    if (encoding != "utf-8")
                        pyDict["encoding"] = Helpers.ToPython(encoding);
                    if (decode_error != "strict")
                        pyDict["decode_error"] = Helpers.ToPython(decode_error);
                    if (strip_accents != null)
                        pyDict["strip_accents"] = Helpers.ToPython(strip_accents);
                    if (lowercase != true)
                        pyDict["lowercase"] = Helpers.ToPython(lowercase);
                    if (preprocessor != null)
                        pyDict["preprocessor"] = Helpers.ToPython(preprocessor);
                    if (tokenizer != null)
                        pyDict["tokenizer"] = Helpers.ToPython(tokenizer);
                    if (analyzer != "word")
                        pyDict["analyzer"] = Helpers.ToPython(analyzer);
                    if (stop_words != null)
                        pyDict["stop_words"] = Helpers.ToPython(stop_words);
                    if (token_pattern != "(?u)\\b\\w\\w+\\b")
                        pyDict["token_pattern"] = Helpers.ToPython(token_pattern);
                    if (ngram_range != null)
                        pyDict["ngram_range"] = Helpers.ToPython(ngram_range);
                    if (max_df != 1.0f)
                        pyDict["max_df"] = Helpers.ToPython(max_df);
                    if (min_df != 1)
                        pyDict["min_df"] = Helpers.ToPython(min_df);
                    if (max_features != null)
                        pyDict["max_features"] = Helpers.ToPython(max_features);
                    if (vocabulary != null)
                        pyDict["vocabulary"] = Helpers.ToPython(vocabulary);
                    if (binary != false)
                        pyDict["binary"] = Helpers.ToPython(binary);
                    if (dtype != null)
                        pyDict["dtype"] = Helpers.ToPython(dtype);
                    if (norm != "l2")
                        pyDict["norm"] = Helpers.ToPython(norm);
                    if (use_idf != true)
                        pyDict["use_idf"] = Helpers.ToPython(use_idf);
                    if (smooth_idf != true)
                        pyDict["smooth_idf"] = Helpers.ToPython(smooth_idf);
                    if (sublinear_tf != false)
                        pyDict["sublinear_tf"] = Helpers.ToPython(sublinear_tf);
                    self = sklearn.feature_extraction.text.self.InvokeMethod("TfidfVectorizer", args, pyDict);
                }

                internal TfidfVectorizer(PyObject pyObject)
                {
                    _ = sklearn.feature_extraction.text.self;
                    self = pyObject;
                }

                [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
                public static TfidfVectorizer Encapsule(PyObject pyObject) => new TfidfVectorizer(pyObject);
                public static TfidfVectorizer Wrap(PyObject pyObject) => new TfidfVectorizer(pyObject);
                public PyDict vocabulary_ => new NotImplementedException();
                public bool fixed_vocabulary_ => self.GetAttr("fixed_vocabulary_").As<bool>()public NDarray idf_ => new NotImplementedException();

                public PyObject build_analyzer()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public PyObject build_preprocessor()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public PyObject build_tokenizer()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public string decode(string doc)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(doc) });
                    PyDict pyDict = new PyDict();
                    return self.InvokeMethod("decode", args, pyDict).As<string>()}

                public TfidfVectorizer fit(PyObject raw_documents, PyObject? y = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(raw_documents) });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public PyObject fit_transform(PyObject raw_documents, PyObject? y = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(raw_documents) });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    return new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
                    return new NotImplementedException();
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

                public void get_stop_words()
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray X)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }

                public TfidfVectorizer set_fit_request(string? raw_documents = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (raw_documents != "$UNCHANGED$")
                        pyDict["raw_documents"] = Helpers.ToPython(raw_documents);
                    self.InvokeMethod("set_fit_request", args, pyDict);
                    return this;
                }

                public TfidfVectorizer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public TfidfVectorizer set_transform_request(string? raw_documents = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple(new PyObject[] { });
                    PyDict pyDict = new PyDict();
                    if (raw_documents != "$UNCHANGED$")
                        pyDict["raw_documents"] = Helpers.ToPython(raw_documents);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public PyObject transform(PyObject raw_documents)
                {
                    PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(raw_documents) });
                    PyDict pyDict = new PyDict();
                    return new NotImplementedException();
                }
            }
        }
    }
}