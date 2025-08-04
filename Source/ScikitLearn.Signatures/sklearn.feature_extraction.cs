using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class feature_extraction
    {
        // Classes
        public class DictVectorizer : PythonObject
        {
            // Constructor
            public DictVectorizer(float? dtype = null, string separator = "=", bool sparse = true, bool sort = true)
            {
            }

            // Properties
            public PyDict vocabulary_ => default!;
            public PyObject feature_names_ => default!;

            // Methods
            [Self]
            public DictVectorizer fit(PyObject X, PyObject? y = null) => default!;
            public NDarray fit_transform(PyObject X, PyObject? y = null) => default!;
            public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            public PyObject inverse_transform(NDarray X, PyDict? dict_type = null) => default!;
            [Self]
            public DictVectorizer restrict(NDarray support, bool indices = false) => default!;
            [Self]
            public DictVectorizer set_inverse_transform_request(string? dict_type = "$UNCHANGED$") => default!;
            [Self]
            public DictVectorizer set_output(string? transform = null) => default!;
            [Self]
            public DictVectorizer set_params(params (string key, object value)[] @params) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class FeatureHasher : PythonObject
        {
            // Constructor
            public FeatureHasher(int n_features = 1048576, string input_type = "dict", float? dtype = null, bool alternate_sign = true)
            {
            }

            // Methods
            [Self]
            public FeatureHasher fit() => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
            [Self]
            public FeatureHasher set_output(string? transform = null) => default!;
            [Self]
            public FeatureHasher set_params(params (string key, object value)[] @params) => default!;
            [Self]
            public FeatureHasher set_transform_request(string? raw_X = "$UNCHANGED$") => default!;
            public NDarray transform(PyObject raw_X) => default!;
        }

        [Module]
        public static class image
        {
            // Methods
            public static NDarray extract_patches_2d(NDarray image, int patch_size, float? max_patches = null, int? random_state = null) => default!;
            public static NDarray grid_to_graph(int n_x, int n_y, int n_z = 1, NDarray? mask = null, NDarray? return_as = null, int? dtype = null) => default!;
            public static NDarray img_to_graph(NDarray img, NDarray? mask = null, NDarray? return_as = null, PyObject? dtype = null) => default!;
            public static NDarray reconstruct_from_patches_2d(NDarray patches, int image_size) => default!;
            // Classes
            public class PatchExtractor : PythonObject
            {
                // Constructor
                public PatchExtractor(int? patch_size = null, float? max_patches = null, int? random_state = null)
                {
                }

                // Methods
                [Self]
                public PatchExtractor fit(NDarray X) => default!;
                public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
                public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
                public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
                [Self]
                public PatchExtractor set_output(string? transform = null) => default!;
                [Self]
                public PatchExtractor set_params(params (string key, object value)[] @params) => default!;
                public NDarray transform(NDarray X) => default!;
            }
        }

        [Module]
        public static class text
        {
            // Classes
            public class CountVectorizer : PythonObject
            {
                // Constructor
                public CountVectorizer(string input = "content", string encoding = "utf-8", string decode_error = "strict", PyObject? strip_accents = null, bool lowercase = true, PyObject? preprocessor = null, PyObject? tokenizer = null, PyObject? stop_words = null, string? token_pattern = "(?u)\\b\\w\\w+\\b", PyTuple? ngram_range = null, string analyzer = "word", float max_df = 1.0f, int min_df = 1, int? max_features = null, PyObject? vocabulary = null, bool binary = false, int? dtype = null)
                {
                }

                // Properties
                public PyDict vocabulary_ => default!;
                public bool fixed_vocabulary_ => default!;

                // Methods
                public PyObject build_analyzer() => default!;
                public PyObject build_preprocessor() => default!;
                public PyObject build_tokenizer() => default!;
                public string decode(string doc) => default!;
                [Self]
                public CountVectorizer fit(PyObject raw_documents, PyObject? y = null) => default!;
                public NDarray fit_transform(PyObject raw_documents, PyObject? y = null) => default!;
                public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
                public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
                public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
                public void get_stop_words()
                {
                }

                public NDarray inverse_transform(NDarray X) => default!;
                [Self]
                public CountVectorizer set_fit_request(string? raw_documents = "$UNCHANGED$") => default!;
                [Self]
                public CountVectorizer set_params(params (string key, object value)[] @params) => default!;
                [Self]
                public CountVectorizer set_transform_request(string? raw_documents = "$UNCHANGED$") => default!;
                public NDarray transform(PyObject raw_documents) => default!;
            }

            public class HashingVectorizer : PythonObject
            {
                // Constructor
                public HashingVectorizer(string input = "content", string encoding = "utf-8", string decode_error = "strict", PyObject? strip_accents = null, bool lowercase = true, PyObject? preprocessor = null, PyObject? tokenizer = null, PyObject? stop_words = null, string? token_pattern = "(?u)\\b\\w\\w+\\b", PyTuple? ngram_range = null, string analyzer = "word", int n_features = 1048576, bool binary = false, string norm = "l2", bool alternate_sign = true, float? dtype = null)
                {
                }

                // Methods
                public PyObject build_analyzer() => default!;
                public PyObject build_preprocessor() => default!;
                public PyObject build_tokenizer() => default!;
                public string decode(string doc) => default!;
                [Self]
                public HashingVectorizer fit(NDarray X) => default!;
                public NDarray fit_transform(PyObject X, PyObject? y = null) => default!;
                public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
                public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
                public void get_stop_words()
                {
                }

                [Self]
                public HashingVectorizer partial_fit(NDarray X) => default!;
                [Self]
                public HashingVectorizer set_output(string? transform = null) => default!;
                [Self]
                public HashingVectorizer set_params(params (string key, object value)[] @params) => default!;
                public NDarray transform(PyObject X) => default!;
            }

            public class TfidfTransformer : PythonObject
            {
                // Constructor
                public TfidfTransformer(string? norm = "l2", bool use_idf = true, bool smooth_idf = true, bool sublinear_tf = false)
                {
                }

                // Properties
                public NDarray idf_ => default!;
                public int n_features_in_ => default!;
                public NDarray feature_names_in_ => default!;

                // Methods
                [Self]
                public TfidfTransformer fit(NDarray X, PyObject? y = null) => default!;
                public NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params) => default!;
                public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
                public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
                public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
                [Self]
                public TfidfTransformer set_output(string? transform = null) => default!;
                [Self]
                public TfidfTransformer set_params(params (string key, object value)[] @params) => default!;
                [Self]
                public TfidfTransformer set_transform_request(string? copy = "$UNCHANGED$") => default!;
                public NDarray transform(PyObject X, bool copy = true) => default!;
            }

            public class TfidfVectorizer : PythonObject
            {
                // Constructor
                public TfidfVectorizer(string input = "content", string encoding = "utf-8", string decode_error = "strict", PyObject? strip_accents = null, bool lowercase = true, PyObject? preprocessor = null, PyObject? tokenizer = null, string analyzer = "word", PyObject? stop_words = null, string token_pattern = "(?u)\\b\\w\\w+\\b", PyTuple? ngram_range = null, float max_df = 1.0f, int min_df = 1, int? max_features = null, PyObject? vocabulary = null, bool binary = false, float? dtype = null, string? norm = "l2", bool use_idf = true, bool smooth_idf = true, bool sublinear_tf = false)
                {
                }

                // Properties
                public PyDict vocabulary_ => default!;
                public bool fixed_vocabulary_ => default!;
                public NDarray idf_ => default!;

                // Methods
                public PyObject build_analyzer() => default!;
                public PyObject build_preprocessor() => default!;
                public PyObject build_tokenizer() => default!;
                public string decode(string doc) => default!;
                [Self]
                public TfidfVectorizer fit(PyObject raw_documents, PyObject? y = null) => default!;
                public PyObject fit_transform(PyObject raw_documents, PyObject? y = null) => default!;
                public NDarray<string> get_feature_names_out(NDarray<string>? input_features = null) => default!;
                public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
                public Dictionary<string, PyObject> get_params(bool deep = true) => default!;
                public void get_stop_words()
                {
                }

                public NDarray inverse_transform(NDarray X) => default!;
                [Self]
                public TfidfVectorizer set_fit_request(string? raw_documents = "$UNCHANGED$") => default!;
                [Self]
                public TfidfVectorizer set_params(params (string key, object value)[] @params) => default!;
                [Self]
                public TfidfVectorizer set_transform_request(string? raw_documents = "$UNCHANGED$") => default!;
                public PyObject transform(PyObject raw_documents) => default!;
            }
        }
    }
}