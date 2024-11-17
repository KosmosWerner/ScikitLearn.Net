using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (dtype != null)
                        pyDict["dtype"] = ToPython(dtype);
                    if (separator != "=")
                        pyDict["separator"] = ToPython(separator);
                    if (sparse != true)
                        pyDict["sparse"] = ToPython(sparse);
                    if (sort != true)
                        pyDict["sort"] = ToPython(sort);
                    self = sklearn.feature_extraction.self.InvokeMethod("DictVectorizer", args, pyDict);
                }

                internal DictVectorizer(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static DictVectorizer Encapsule(PyObject pyObject)
                {
                    return new DictVectorizer(pyObject);
                }

                public PyDict vocabulary_ => new PyDict(self.GetAttr("vocabulary_"));
                public PyObject feature_names_ => self.GetAttr("feature_names_");

                public DictVectorizer fit(PyObject X, PyObject? y = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(PyObject X, PyObject? y = null)
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

                public PyObject inverse_transform(NDarray X, PyDict? dict_type = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (dict_type != null)
                        pyDict["dict_type"] = ToPython(dict_type);
                    return self.InvokeMethod("inverse_transform", args, pyDict);
                }

                public DictVectorizer restrict(NDarray support, bool indices = false)
                {
                    PyTuple args = ToTuple(new object[] { support });
                    PyDict pyDict = new PyDict();
                    if (indices != false)
                        pyDict["indices"] = ToPython(indices);
                    self.InvokeMethod("restrict", args, pyDict);
                    return this;
                }

                public DictVectorizer set_inverse_transform_request(string? dict_type = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (dict_type != "$UNCHANGED$")
                        pyDict["dict_type"] = ToPython(dict_type);
                    self.InvokeMethod("set_inverse_transform_request", args, pyDict);
                    return this;
                }

                public DictVectorizer set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public DictVectorizer set_params(Dictionary<string, PyObject>? @params = null)
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

            public class FeatureHasher : PythonObject
            {
                public FeatureHasher(int n_features = 1048576, string input_type = "dict", float? dtype = null, bool alternate_sign = true)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (n_features != 1048576)
                        pyDict["n_features"] = ToPython(n_features);
                    if (input_type != "dict")
                        pyDict["input_type"] = ToPython(input_type);
                    if (dtype != null)
                        pyDict["dtype"] = ToPython(dtype);
                    if (alternate_sign != true)
                        pyDict["alternate_sign"] = ToPython(alternate_sign);
                    self = sklearn.feature_extraction.self.InvokeMethod("FeatureHasher", args, pyDict);
                }

                internal FeatureHasher(PyObject pyObject)
                {
                    self = pyObject;
                }

                public static FeatureHasher Encapsule(PyObject pyObject)
                {
                    return new FeatureHasher(pyObject);
                }

                public FeatureHasher fit()
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self.InvokeMethod("fit", args, pyDict);
                    return this;
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = ToTuple(new object[] { X });
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = ToPython(y);
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
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

                public FeatureHasher set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }

                public FeatureHasher set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = ToPython(@params);
                    self.InvokeMethod("set_params", args, pyDict);
                    return this;
                }

                public FeatureHasher set_transform_request(string? raw_X = "$UNCHANGED$")
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (raw_X != "$UNCHANGED$")
                        pyDict["raw_X"] = ToPython(raw_X);
                    self.InvokeMethod("set_transform_request", args, pyDict);
                    return this;
                }

                public NDarray transform(PyObject raw_X)
                {
                    PyTuple args = ToTuple(new object[] { raw_X });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
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

                public class PatchExtractor : PythonObject
                {
                    public PatchExtractor(int? patch_size = null, float? max_patches = null, int? random_state = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (patch_size != null)
                            pyDict["patch_size"] = ToPython(patch_size);
                        if (max_patches != null)
                            pyDict["max_patches"] = ToPython(max_patches);
                        if (random_state != null)
                            pyDict["random_state"] = ToPython(random_state);
                        self = sklearn.feature_extraction.image.self.InvokeMethod("PatchExtractor", args, pyDict);
                    }

                    internal PatchExtractor(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static PatchExtractor Encapsule(PyObject pyObject)
                    {
                        return new PatchExtractor(pyObject);
                    }

                    public PatchExtractor fit(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("fit", args, pyDict);
                        return this;
                    }

                    public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        if (y != null)
                            pyDict["y"] = ToPython(y);
                        if (@params != null)
                            pyDict["params"] = ToPython(@params);
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

                    public PatchExtractor set_output(PyObject? transform = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (transform != null)
                            pyDict["transform"] = ToPython(transform);
                        self.InvokeMethod("set_output", args, pyDict);
                        return this;
                    }

                    public PatchExtractor set_params(Dictionary<string, PyObject>? @params = null)
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

                public static NDarray extract_patches_2d(NDarray image, int patch_size, float? max_patches = null, int? random_state = null)
                {
                    PyTuple args = ToTuple(new object[] { image, patch_size });
                    PyDict pyDict = new PyDict();
                    if (max_patches != null)
                        pyDict["max_patches"] = ToPython(max_patches);
                    if (random_state != null)
                        pyDict["random_state"] = ToPython(random_state);
                    return ToCsharp<NDarray>(sklearn.feature_extraction.image.self.InvokeMethod("extract_patches_2d", args, pyDict));
                }

                public static NDarray grid_to_graph(int n_x, int n_y, int n_z = 1, NDarray? mask = null, NDarray? return_as = null, int? dtype = null)
                {
                    PyTuple args = ToTuple(new object[] { n_x, n_y });
                    PyDict pyDict = new PyDict();
                    if (n_z != 1)
                        pyDict["n_z"] = ToPython(n_z);
                    if (mask != null)
                        pyDict["mask"] = ToPython(mask);
                    if (return_as != null)
                        pyDict["return_as"] = ToPython(return_as);
                    if (dtype != null)
                        pyDict["dtype"] = ToPython(dtype);
                    return ToCsharp<NDarray>(sklearn.feature_extraction.image.self.InvokeMethod("grid_to_graph", args, pyDict));
                }

                public static NDarray img_to_graph(NDarray img, NDarray? mask = null, NDarray? return_as = null, PyObject? dtype = null)
                {
                    PyTuple args = ToTuple(new object[] { img });
                    PyDict pyDict = new PyDict();
                    if (mask != null)
                        pyDict["mask"] = ToPython(mask);
                    if (return_as != null)
                        pyDict["return_as"] = ToPython(return_as);
                    if (dtype != null)
                        pyDict["dtype"] = ToPython(dtype);
                    return ToCsharp<NDarray>(sklearn.feature_extraction.image.self.InvokeMethod("img_to_graph", args, pyDict));
                }

                public static NDarray reconstruct_from_patches_2d(NDarray patches, int image_size)
                {
                    PyTuple args = ToTuple(new object[] { patches, image_size });
                    PyDict pyDict = new PyDict();
                    return ToCsharp<NDarray>(sklearn.feature_extraction.image.self.InvokeMethod("reconstruct_from_patches_2d", args, pyDict));
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
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (input != "content")
                            pyDict["input"] = ToPython(input);
                        if (encoding != "utf-8")
                            pyDict["encoding"] = ToPython(encoding);
                        if (decode_error != "strict")
                            pyDict["decode_error"] = ToPython(decode_error);
                        if (strip_accents != null)
                            pyDict["strip_accents"] = ToPython(strip_accents);
                        if (lowercase != true)
                            pyDict["lowercase"] = ToPython(lowercase);
                        if (preprocessor != null)
                            pyDict["preprocessor"] = ToPython(preprocessor);
                        if (tokenizer != null)
                            pyDict["tokenizer"] = ToPython(tokenizer);
                        if (stop_words != null)
                            pyDict["stop_words"] = ToPython(stop_words);
                        if (token_pattern != "(?u)\\b\\w\\w+\\b")
                            pyDict["token_pattern"] = ToPython(token_pattern);
                        if (ngram_range != null)
                            pyDict["ngram_range"] = ToPython(ngram_range);
                        if (analyzer != "word")
                            pyDict["analyzer"] = ToPython(analyzer);
                        if (max_df != 1.0f)
                            pyDict["max_df"] = ToPython(max_df);
                        if (min_df != 1)
                            pyDict["min_df"] = ToPython(min_df);
                        if (max_features != null)
                            pyDict["max_features"] = ToPython(max_features);
                        if (vocabulary != null)
                            pyDict["vocabulary"] = ToPython(vocabulary);
                        if (binary != false)
                            pyDict["binary"] = ToPython(binary);
                        if (dtype != null)
                            pyDict["dtype"] = ToPython(dtype);
                        self = sklearn.feature_extraction.text.self.InvokeMethod("CountVectorizer", args, pyDict);
                    }

                    internal CountVectorizer(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static CountVectorizer Encapsule(PyObject pyObject)
                    {
                        return new CountVectorizer(pyObject);
                    }

                    public PyDict vocabulary_ => new PyDict(self.GetAttr("vocabulary_"));
                    public bool fixed_vocabulary_ => ToCsharp<bool>(self.GetAttr("fixed_vocabulary_"));

                    public PyObject build_analyzer()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_analyzer", args, pyDict);
                    }

                    public PyObject build_preprocessor()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_preprocessor", args, pyDict);
                    }

                    public PyObject build_tokenizer()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_tokenizer", args, pyDict);
                    }

                    public string decode(string doc)
                    {
                        PyTuple args = ToTuple(new object[] { doc });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<string>(self.InvokeMethod("decode", args, pyDict));
                    }

                    public CountVectorizer fit(PyObject raw_documents, PyObject? y = null)
                    {
                        PyTuple args = ToTuple(new object[] { raw_documents });
                        PyDict pyDict = new PyDict();
                        if (y != null)
                            pyDict["y"] = ToPython(y);
                        self.InvokeMethod("fit", args, pyDict);
                        return this;
                    }

                    public NDarray fit_transform(PyObject raw_documents, PyObject? y = null)
                    {
                        PyTuple args = ToTuple(new object[] { raw_documents });
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

                    public void get_stop_words()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("get_stop_words", args, pyDict);
                    }

                    public NDarray inverse_transform(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                    }

                    public CountVectorizer set_fit_request(string? raw_documents = "$UNCHANGED$")
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (raw_documents != "$UNCHANGED$")
                            pyDict["raw_documents"] = ToPython(raw_documents);
                        self.InvokeMethod("set_fit_request", args, pyDict);
                        return this;
                    }

                    public CountVectorizer set_params(Dictionary<string, PyObject>? @params = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (@params != null)
                            pyDict["params"] = ToPython(@params);
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }

                    public CountVectorizer set_transform_request(string? raw_documents = "$UNCHANGED$")
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (raw_documents != "$UNCHANGED$")
                            pyDict["raw_documents"] = ToPython(raw_documents);
                        self.InvokeMethod("set_transform_request", args, pyDict);
                        return this;
                    }

                    public NDarray transform(PyObject raw_documents)
                    {
                        PyTuple args = ToTuple(new object[] { raw_documents });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                    }
                }

                public class HashingVectorizer : PythonObject
                {
                    public HashingVectorizer(string input = "content", string encoding = "utf-8", string decode_error = "strict", PyObject? strip_accents = null, bool lowercase = true, PyObject? preprocessor = null, PyObject? tokenizer = null, PyObject? stop_words = null, string? token_pattern = "(?u)\\b\\w\\w+\\b", PyTuple? ngram_range = null, string analyzer = "word", int n_features = 1048576, bool binary = false, string norm = "l2", bool alternate_sign = true, float? dtype = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (input != "content")
                            pyDict["input"] = ToPython(input);
                        if (encoding != "utf-8")
                            pyDict["encoding"] = ToPython(encoding);
                        if (decode_error != "strict")
                            pyDict["decode_error"] = ToPython(decode_error);
                        if (strip_accents != null)
                            pyDict["strip_accents"] = ToPython(strip_accents);
                        if (lowercase != true)
                            pyDict["lowercase"] = ToPython(lowercase);
                        if (preprocessor != null)
                            pyDict["preprocessor"] = ToPython(preprocessor);
                        if (tokenizer != null)
                            pyDict["tokenizer"] = ToPython(tokenizer);
                        if (stop_words != null)
                            pyDict["stop_words"] = ToPython(stop_words);
                        if (token_pattern != "(?u)\\b\\w\\w+\\b")
                            pyDict["token_pattern"] = ToPython(token_pattern);
                        if (ngram_range != null)
                            pyDict["ngram_range"] = ToPython(ngram_range);
                        if (analyzer != "word")
                            pyDict["analyzer"] = ToPython(analyzer);
                        if (n_features != 1048576)
                            pyDict["n_features"] = ToPython(n_features);
                        if (binary != false)
                            pyDict["binary"] = ToPython(binary);
                        if (norm != "l2")
                            pyDict["norm"] = ToPython(norm);
                        if (alternate_sign != true)
                            pyDict["alternate_sign"] = ToPython(alternate_sign);
                        if (dtype != null)
                            pyDict["dtype"] = ToPython(dtype);
                        self = sklearn.feature_extraction.text.self.InvokeMethod("HashingVectorizer", args, pyDict);
                    }

                    internal HashingVectorizer(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static HashingVectorizer Encapsule(PyObject pyObject)
                    {
                        return new HashingVectorizer(pyObject);
                    }

                    public PyObject build_analyzer()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_analyzer", args, pyDict);
                    }

                    public PyObject build_preprocessor()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_preprocessor", args, pyDict);
                    }

                    public PyObject build_tokenizer()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_tokenizer", args, pyDict);
                    }

                    public string decode(string doc)
                    {
                        PyTuple args = ToTuple(new object[] { doc });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<string>(self.InvokeMethod("decode", args, pyDict));
                    }

                    public HashingVectorizer fit(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("fit", args, pyDict);
                        return this;
                    }

                    public NDarray fit_transform(PyObject X, PyObject? y = null)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        if (y != null)
                            pyDict["y"] = ToPython(y);
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

                    public void get_stop_words()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("get_stop_words", args, pyDict);
                    }

                    public HashingVectorizer partial_fit(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("partial_fit", args, pyDict);
                        return this;
                    }

                    public HashingVectorizer set_output(PyObject? transform = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (transform != null)
                            pyDict["transform"] = ToPython(transform);
                        self.InvokeMethod("set_output", args, pyDict);
                        return this;
                    }

                    public HashingVectorizer set_params(Dictionary<string, PyObject>? @params = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (@params != null)
                            pyDict["params"] = ToPython(@params);
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }

                    public NDarray transform(PyObject X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                    }
                }

                public class TfidfTransformer : PythonObject
                {
                    public TfidfTransformer(string? norm = "l2", bool use_idf = true, bool smooth_idf = true, bool sublinear_tf = false)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (norm != "l2")
                            pyDict["norm"] = ToPython(norm);
                        if (use_idf != true)
                            pyDict["use_idf"] = ToPython(use_idf);
                        if (smooth_idf != true)
                            pyDict["smooth_idf"] = ToPython(smooth_idf);
                        if (sublinear_tf != false)
                            pyDict["sublinear_tf"] = ToPython(sublinear_tf);
                        self = sklearn.feature_extraction.text.self.InvokeMethod("TfidfTransformer", args, pyDict);
                    }

                    internal TfidfTransformer(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static TfidfTransformer Encapsule(PyObject pyObject)
                    {
                        return new TfidfTransformer(pyObject);
                    }

                    public NDarray idf_ => ToCsharp<NDarray>(self.GetAttr("idf_"));
                    public int n_features_in_ => ToCsharp<int>(self.GetAttr("n_features_in_"));
                    public NDarray feature_names_in_ => ToCsharp<NDarray>(self.GetAttr("feature_names_in_"));

                    public TfidfTransformer fit(NDarray X, PyObject? y = null)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        if (y != null)
                            pyDict["y"] = ToPython(y);
                        self.InvokeMethod("fit", args, pyDict);
                        return this;
                    }

                    public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        if (y != null)
                            pyDict["y"] = ToPython(y);
                        if (@params != null)
                            pyDict["params"] = ToPython(@params);
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

                    public TfidfTransformer set_output(PyObject? transform = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (transform != null)
                            pyDict["transform"] = ToPython(transform);
                        self.InvokeMethod("set_output", args, pyDict);
                        return this;
                    }

                    public TfidfTransformer set_params(Dictionary<string, PyObject>? @params = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (@params != null)
                            pyDict["params"] = ToPython(@params);
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }

                    public TfidfTransformer set_transform_request(string? copy = "$UNCHANGED$")
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (copy != "$UNCHANGED$")
                            pyDict["copy"] = ToPython(copy);
                        self.InvokeMethod("set_transform_request", args, pyDict);
                        return this;
                    }

                    public NDarray transform(PyObject X, bool copy = true)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        if (copy != true)
                            pyDict["copy"] = ToPython(copy);
                        return ToCsharp<NDarray>(self.InvokeMethod("transform", args, pyDict));
                    }
                }

                public class TfidfVectorizer : PythonObject
                {
                    public TfidfVectorizer(string input = "content", string encoding = "utf-8", string decode_error = "strict", PyObject? strip_accents = null, bool lowercase = true, PyObject? preprocessor = null, PyObject? tokenizer = null, string analyzer = "word", PyObject? stop_words = null, string token_pattern = "(?u)\\b\\w\\w+\\b", PyTuple? ngram_range = null, float max_df = 1.0f, int min_df = 1, int? max_features = null, PyObject? vocabulary = null, bool binary = false, float? dtype = null, string? norm = "l2", bool use_idf = true, bool smooth_idf = true, bool sublinear_tf = false)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (input != "content")
                            pyDict["input"] = ToPython(input);
                        if (encoding != "utf-8")
                            pyDict["encoding"] = ToPython(encoding);
                        if (decode_error != "strict")
                            pyDict["decode_error"] = ToPython(decode_error);
                        if (strip_accents != null)
                            pyDict["strip_accents"] = ToPython(strip_accents);
                        if (lowercase != true)
                            pyDict["lowercase"] = ToPython(lowercase);
                        if (preprocessor != null)
                            pyDict["preprocessor"] = ToPython(preprocessor);
                        if (tokenizer != null)
                            pyDict["tokenizer"] = ToPython(tokenizer);
                        if (analyzer != "word")
                            pyDict["analyzer"] = ToPython(analyzer);
                        if (stop_words != null)
                            pyDict["stop_words"] = ToPython(stop_words);
                        if (token_pattern != "(?u)\\b\\w\\w+\\b")
                            pyDict["token_pattern"] = ToPython(token_pattern);
                        if (ngram_range != null)
                            pyDict["ngram_range"] = ToPython(ngram_range);
                        if (max_df != 1.0f)
                            pyDict["max_df"] = ToPython(max_df);
                        if (min_df != 1)
                            pyDict["min_df"] = ToPython(min_df);
                        if (max_features != null)
                            pyDict["max_features"] = ToPython(max_features);
                        if (vocabulary != null)
                            pyDict["vocabulary"] = ToPython(vocabulary);
                        if (binary != false)
                            pyDict["binary"] = ToPython(binary);
                        if (dtype != null)
                            pyDict["dtype"] = ToPython(dtype);
                        if (norm != "l2")
                            pyDict["norm"] = ToPython(norm);
                        if (use_idf != true)
                            pyDict["use_idf"] = ToPython(use_idf);
                        if (smooth_idf != true)
                            pyDict["smooth_idf"] = ToPython(smooth_idf);
                        if (sublinear_tf != false)
                            pyDict["sublinear_tf"] = ToPython(sublinear_tf);
                        self = sklearn.feature_extraction.text.self.InvokeMethod("TfidfVectorizer", args, pyDict);
                    }

                    internal TfidfVectorizer(PyObject pyObject)
                    {
                        self = pyObject;
                    }

                    public static TfidfVectorizer Encapsule(PyObject pyObject)
                    {
                        return new TfidfVectorizer(pyObject);
                    }

                    public PyDict vocabulary_ => new PyDict(self.GetAttr("vocabulary_"));
                    public bool fixed_vocabulary_ => ToCsharp<bool>(self.GetAttr("fixed_vocabulary_"));
                    public NDarray idf_ => ToCsharp<NDarray>(self.GetAttr("idf_"));

                    public PyObject build_analyzer()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_analyzer", args, pyDict);
                    }

                    public PyObject build_preprocessor()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_preprocessor", args, pyDict);
                    }

                    public PyObject build_tokenizer()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("build_tokenizer", args, pyDict);
                    }

                    public string decode(string doc)
                    {
                        PyTuple args = ToTuple(new object[] { doc });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<string>(self.InvokeMethod("decode", args, pyDict));
                    }

                    public TfidfVectorizer fit(PyObject raw_documents, PyObject? y = null)
                    {
                        PyTuple args = ToTuple(new object[] { raw_documents });
                        PyDict pyDict = new PyDict();
                        if (y != null)
                            pyDict["y"] = ToPython(y);
                        self.InvokeMethod("fit", args, pyDict);
                        return this;
                    }

                    public PyObject fit_transform(PyObject raw_documents, PyObject? y = null)
                    {
                        PyTuple args = ToTuple(new object[] { raw_documents });
                        PyDict pyDict = new PyDict();
                        if (y != null)
                            pyDict["y"] = ToPython(y);
                        return self.InvokeMethod("fit_transform", args, pyDict);
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

                    public void get_stop_words()
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        self.InvokeMethod("get_stop_words", args, pyDict);
                    }

                    public NDarray inverse_transform(NDarray X)
                    {
                        PyTuple args = ToTuple(new object[] { X });
                        PyDict pyDict = new PyDict();
                        return ToCsharp<NDarray>(self.InvokeMethod("inverse_transform", args, pyDict));
                    }

                    public TfidfVectorizer set_fit_request(string? raw_documents = "$UNCHANGED$")
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (raw_documents != "$UNCHANGED$")
                            pyDict["raw_documents"] = ToPython(raw_documents);
                        self.InvokeMethod("set_fit_request", args, pyDict);
                        return this;
                    }

                    public TfidfVectorizer set_params(Dictionary<string, PyObject>? @params = null)
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (@params != null)
                            pyDict["params"] = ToPython(@params);
                        self.InvokeMethod("set_params", args, pyDict);
                        return this;
                    }

                    public TfidfVectorizer set_transform_request(string? raw_documents = "$UNCHANGED$")
                    {
                        PyTuple args = new PyTuple();
                        PyDict pyDict = new PyDict();
                        if (raw_documents != "$UNCHANGED$")
                            pyDict["raw_documents"] = ToPython(raw_documents);
                        self.InvokeMethod("set_transform_request", args, pyDict);
                        return this;
                    }

                    public PyObject transform(PyObject raw_documents)
                    {
                        PyTuple args = ToTuple(new object[] { raw_documents });
                        PyDict pyDict = new PyDict();
                        return self.InvokeMethod("transform", args, pyDict);
                    }
                }
            }
        }
    }
}