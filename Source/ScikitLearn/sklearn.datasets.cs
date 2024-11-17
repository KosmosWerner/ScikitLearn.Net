using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class datasets
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
                return Py.Import("sklearn.datasets");
            }

            static datasets()
            {
                ReInitializeLazySelf();
            }

            public static void clear_data_home(string? data_home = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                sklearn.datasets.self.InvokeMethod("clear_data_home", args, pyDict);
            }

            public static void dump_svmlight_file(NDarray X, NDarray y, string f, bool zero_based = true, string? comment = null, NDarray? query_id = null, bool multilabel = false)
            {
                PyTuple args = ToTuple(new object[] { X, y, f });
                PyDict pyDict = new PyDict();
                if (zero_based != true)
                    pyDict["zero_based"] = ToPython(zero_based);
                if (comment != null)
                    pyDict["comment"] = ToPython(comment);
                if (query_id != null)
                    pyDict["query_id"] = ToPython(query_id);
                if (multilabel != false)
                    pyDict["multilabel"] = ToPython(multilabel);
                sklearn.datasets.self.InvokeMethod("dump_svmlight_file", args, pyDict);
            }

            public static (PyDict, NDarray, NDarray, string, NDarray, bool) fetch_20newsgroups(string? data_home = null, string subset = "train", NDarray? categories = null, bool shuffle = true, int? random_state = 42, PyTuple? remove = null, bool download_if_missing = true, bool return_X_y = false, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (subset != "train")
                    pyDict["subset"] = ToPython(subset);
                if (categories != null)
                    pyDict["categories"] = ToPython(categories);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (random_state != 42)
                    pyDict["random_state"] = ToPython(random_state);
                if (remove != null)
                    pyDict["remove"] = ToPython(remove);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_20newsgroups", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]), ToCsharp<string>(result[3]), ToCsharp<NDarray>(result[4]), ToCsharp<bool>(result[5]));
            }

            public static (PyDict, NDarray, NDarray, NDarray, string, NDarray, bool) fetch_20newsgroups_vectorized(string subset = "train", PyTuple? remove = null, string? data_home = null, bool download_if_missing = true, bool return_X_y = false, bool normalize = true, bool as_frame = false, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (subset != "train")
                    pyDict["subset"] = ToPython(subset);
                if (remove != null)
                    pyDict["remove"] = ToPython(remove);
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (normalize != true)
                    pyDict["normalize"] = ToPython(normalize);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_20newsgroups_vectorized", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]), ToCsharp<NDarray>(result[3]), ToCsharp<string>(result[4]), ToCsharp<NDarray>(result[5]), ToCsharp<bool>(result[6]));
            }

            public static (PyDict, bool) fetch_california_housing(string? data_home = null, bool download_if_missing = true, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_california_housing", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<bool>(result[1]));
            }

            public static (PyDict, PyObject, bool) fetch_covtype(string? data_home = null, bool download_if_missing = true, int? random_state = null, bool shuffle = false, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (shuffle != false)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_covtype", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<PyObject>(result[1]), ToCsharp<bool>(result[2]));
            }

            public static (PyDict, PyObject, bool) fetch_kddcup99(PyObject? subset = null, string? data_home = null, bool shuffle = false, int? random_state = null, bool percent10 = true, bool download_if_missing = true, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (subset != null)
                    pyDict["subset"] = ToPython(subset);
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (shuffle != false)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (percent10 != true)
                    pyDict["percent10"] = ToPython(percent10);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_kddcup99", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<PyObject>(result[1]), ToCsharp<bool>(result[2]));
            }

            public static PyDict fetch_lfw_pairs(string subset = "train", string? data_home = null, bool funneled = true, float resize = 0.5f, bool color = false, PyTuple? slice_ = null, bool download_if_missing = true, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (subset != "train")
                    pyDict["subset"] = ToPython(subset);
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (funneled != true)
                    pyDict["funneled"] = ToPython(funneled);
                if (resize != 0.5f)
                    pyDict["resize"] = ToPython(resize);
                if (color != false)
                    pyDict["color"] = ToPython(color);
                if (slice_ != null)
                    pyDict["slice_"] = ToPython(slice_);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                return new PyDict(sklearn.datasets.self.InvokeMethod("fetch_lfw_pairs", args, pyDict));
            }

            public static (PyDict, bool) fetch_lfw_people(string? data_home = null, bool funneled = true, float? resize = 0.5f, int? min_faces_per_person = 0, bool color = false, PyTuple? slice_ = null, bool download_if_missing = true, bool return_X_y = false, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (funneled != true)
                    pyDict["funneled"] = ToPython(funneled);
                if (resize != 0.5f)
                    pyDict["resize"] = ToPython(resize);
                if (min_faces_per_person != 0)
                    pyDict["min_faces_per_person"] = ToPython(min_faces_per_person);
                if (color != false)
                    pyDict["color"] = ToPython(color);
                if (slice_ != null)
                    pyDict["slice_"] = ToPython(slice_);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_lfw_people", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<bool>(result[1]));
            }

            public static (PyDict, NDarray, bool) fetch_olivetti_faces(string? data_home = null, bool shuffle = false, int? random_state = 0, bool download_if_missing = true, bool return_X_y = false, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (shuffle != false)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (random_state != 0)
                    pyDict["random_state"] = ToPython(random_state);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_olivetti_faces", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<bool>(result[2]));
            }

            public static (PyDict, PyObject, bool) fetch_openml(string? name = null, string version = "active", int? data_id = null, string? data_home = null, string? target_column = "default-target", bool cache = true, bool return_X_y = false, string as_frame = "auto", int n_retries = 3, float delay = 1.0f, string parser = "auto", PyDict? read_csv_kwargs = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (name != null)
                    pyDict["name"] = ToPython(name);
                if (version != "active")
                    pyDict["version"] = ToPython(version);
                if (data_id != null)
                    pyDict["data_id"] = ToPython(data_id);
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (target_column != "default-target")
                    pyDict["target_column"] = ToPython(target_column);
                if (cache != true)
                    pyDict["cache"] = ToPython(cache);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != "auto")
                    pyDict["as_frame"] = ToPython(as_frame);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                if (parser != "auto")
                    pyDict["parser"] = ToPython(parser);
                if (read_csv_kwargs != null)
                    pyDict["read_csv_kwargs"] = ToPython(read_csv_kwargs);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_openml", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<PyObject>(result[1]), ToCsharp<bool>(result[2]));
            }

            public static (PyDict, PyTuple) fetch_rcv1(string? data_home = null, string subset = "all", bool download_if_missing = true, int? random_state = null, bool shuffle = false, bool return_X_y = false, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (subset != "all")
                    pyDict["subset"] = ToPython(subset);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (shuffle != false)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("fetch_rcv1", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<PyTuple>(result[1]));
            }

            public static PyDict fetch_species_distributions(string? data_home = null, bool download_if_missing = true, int n_retries = 3, float delay = 1.0f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                if (download_if_missing != true)
                    pyDict["download_if_missing"] = ToPython(download_if_missing);
                if (n_retries != 3)
                    pyDict["n_retries"] = ToPython(n_retries);
                if (delay != 1.0f)
                    pyDict["delay"] = ToPython(delay);
                return new PyDict(sklearn.datasets.self.InvokeMethod("fetch_species_distributions", args, pyDict));
            }

            public static string get_data_home(string? data_home = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (data_home != null)
                    pyDict["data_home"] = ToPython(data_home);
                return ToCsharp<string>(sklearn.datasets.self.InvokeMethod("get_data_home", args, pyDict));
            }

            public static (PyDict, bool) load_breast_cancer(bool return_X_y = false, bool as_frame = false)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("load_breast_cancer", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<bool>(result[1]));
            }

            public static (PyDict, NDarray, PyObject, NDarray, string, string, string, bool) load_diabetes(bool return_X_y = false, bool as_frame = false, bool scaled = true)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                if (scaled != true)
                    pyDict["scaled"] = ToPython(scaled);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("load_diabetes", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<PyObject>(result[2]), ToCsharp<NDarray>(result[3]), ToCsharp<string>(result[4]), ToCsharp<string>(result[5]), ToCsharp<string>(result[6]), ToCsharp<bool>(result[7]));
            }

            public static (PyDict, NDarray, PyObject, PyObject, NDarray, NDarray, string, bool) load_digits(int n_class = 10, bool return_X_y = false, bool as_frame = false)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_class != 10)
                    pyDict["n_class"] = ToPython(n_class);
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("load_digits", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<PyObject>(result[2]), ToCsharp<PyObject>(result[3]), ToCsharp<NDarray>(result[4]), ToCsharp<NDarray>(result[5]), ToCsharp<string>(result[6]), ToCsharp<bool>(result[7]));
            }

            public static (PyDict, NDarray) load_files(string container_path, string? description = null, PyTuple? categories = null, bool load_content = true, bool shuffle = true, string? encoding = null, string decode_error = "strict", int? random_state = 0, PyTuple? allowed_extensions = null)
            {
                PyTuple args = ToTuple(new object[] { container_path });
                PyDict pyDict = new PyDict();
                if (description != null)
                    pyDict["description"] = ToPython(description);
                if (categories != null)
                    pyDict["categories"] = ToPython(categories);
                if (load_content != true)
                    pyDict["load_content"] = ToPython(load_content);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (encoding != null)
                    pyDict["encoding"] = ToPython(encoding);
                if (decode_error != "strict")
                    pyDict["decode_error"] = ToPython(decode_error);
                if (random_state != 0)
                    pyDict["random_state"] = ToPython(random_state);
                if (allowed_extensions != null)
                    pyDict["allowed_extensions"] = ToPython(allowed_extensions);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("load_files", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (PyDict, NDarray, PyObject, PyObject, NDarray, string, string, bool) load_iris(bool return_X_y = false, bool as_frame = false)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("load_iris", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<PyObject>(result[2]), ToCsharp<PyObject>(result[3]), ToCsharp<NDarray>(result[4]), ToCsharp<string>(result[5]), ToCsharp<string>(result[6]), ToCsharp<bool>(result[7]));
            }

            public static (PyDict, NDarray, PyObject, PyObject, NDarray, string, string, string, bool) load_linnerud(bool return_X_y = false, bool as_frame = false)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("load_linnerud", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<PyObject>(result[2]), ToCsharp<PyObject>(result[3]), ToCsharp<NDarray>(result[4]), ToCsharp<string>(result[5]), ToCsharp<string>(result[6]), ToCsharp<string>(result[7]), ToCsharp<bool>(result[8]));
            }

            public static NDarray load_sample_image(PyObject image_name)
            {
                PyTuple args = ToTuple(new object[] { image_name });
                PyDict pyDict = new PyDict();
                return ToCsharp<NDarray>(sklearn.datasets.self.InvokeMethod("load_sample_image", args, pyDict));
            }

            public static PyDict load_sample_images()
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                return new PyDict(sklearn.datasets.self.InvokeMethod("load_sample_images", args, pyDict));
            }

            public static (NDarray, NDarray, NDarray) load_svmlight_file(string f, int? n_features = null, float? dtype = null, bool multilabel = false, string zero_based = "auto", bool query_id = false, int offset = 0, int length = -1)
            {
                PyTuple args = ToTuple(new object[] { f });
                PyDict pyDict = new PyDict();
                if (n_features != null)
                    pyDict["n_features"] = ToPython(n_features);
                if (dtype != null)
                    pyDict["dtype"] = ToPython(dtype);
                if (multilabel != false)
                    pyDict["multilabel"] = ToPython(multilabel);
                if (zero_based != "auto")
                    pyDict["zero_based"] = ToPython(zero_based);
                if (query_id != false)
                    pyDict["query_id"] = ToPython(query_id);
                if (offset != 0)
                    pyDict["offset"] = ToPython(offset);
                if (length != -1)
                    pyDict["length"] = ToPython(length);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("load_svmlight_file", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
            }

            public static NDarray load_svmlight_files(NDarray files, int? n_features = null, float? dtype = null, bool multilabel = false, string zero_based = "auto", bool query_id = false, int offset = 0, int length = -1)
            {
                PyTuple args = ToTuple(new object[] { files });
                PyDict pyDict = new PyDict();
                if (n_features != null)
                    pyDict["n_features"] = ToPython(n_features);
                if (dtype != null)
                    pyDict["dtype"] = ToPython(dtype);
                if (multilabel != false)
                    pyDict["multilabel"] = ToPython(multilabel);
                if (zero_based != "auto")
                    pyDict["zero_based"] = ToPython(zero_based);
                if (query_id != false)
                    pyDict["query_id"] = ToPython(query_id);
                if (offset != 0)
                    pyDict["offset"] = ToPython(offset);
                if (length != -1)
                    pyDict["length"] = ToPython(length);
                return ToCsharp<NDarray>(sklearn.datasets.self.InvokeMethod("load_svmlight_files", args, pyDict));
            }

            public static (PyDict, NDarray, PyObject, PyObject, NDarray, string, bool) load_wine(bool return_X_y = false, bool as_frame = false)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (return_X_y != false)
                    pyDict["return_X_y"] = ToPython(return_X_y);
                if (as_frame != false)
                    pyDict["as_frame"] = ToPython(as_frame);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("load_wine", args, pyDict));
                return (ToCsharp<PyDict>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<PyObject>(result[2]), ToCsharp<PyObject>(result[3]), ToCsharp<NDarray>(result[4]), ToCsharp<string>(result[5]), ToCsharp<bool>(result[6]));
            }

            public static (NDarray, NDarray, NDarray) make_biclusters(NDarray shape, int n_clusters, float noise = 0.0f, int minval = 10, int maxval = 100, bool shuffle = true, int? random_state = null)
            {
                PyTuple args = ToTuple(new object[] { shape, n_clusters });
                PyDict pyDict = new PyDict();
                if (noise != 0.0f)
                    pyDict["noise"] = ToPython(noise);
                if (minval != 10)
                    pyDict["minval"] = ToPython(minval);
                if (maxval != 100)
                    pyDict["maxval"] = ToPython(maxval);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_biclusters", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
            }

            public static (NDarray, NDarray, NDarray) make_blobs(int n_samples = 100, int n_features = 2, NDarray? centers = null, float cluster_std = 1.0f, float? center_box = null, bool shuffle = true, int? random_state = null, bool return_centers = false)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (n_features != 2)
                    pyDict["n_features"] = ToPython(n_features);
                if (centers != null)
                    pyDict["centers"] = ToPython(centers);
                if (cluster_std != 1.0f)
                    pyDict["cluster_std"] = ToPython(cluster_std);
                if (center_box != null)
                    pyDict["center_box"] = ToPython(center_box);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (return_centers != false)
                    pyDict["return_centers"] = ToPython(return_centers);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_blobs", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
            }

            public static (NDarray, NDarray, NDarray) make_checkerboard(NDarray shape, NDarray n_clusters, float noise = 0.0f, int minval = 10, int maxval = 100, bool shuffle = true, int? random_state = null)
            {
                PyTuple args = ToTuple(new object[] { shape, n_clusters });
                PyDict pyDict = new PyDict();
                if (noise != 0.0f)
                    pyDict["noise"] = ToPython(noise);
                if (minval != 10)
                    pyDict["minval"] = ToPython(minval);
                if (maxval != 100)
                    pyDict["maxval"] = ToPython(maxval);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_checkerboard", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
            }

            public static (NDarray, NDarray) make_circles(int n_samples = 100, bool shuffle = true, float? noise = null, int? random_state = null, float factor = 0.8f)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (noise != null)
                    pyDict["noise"] = ToPython(noise);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (factor != 0.8f)
                    pyDict["factor"] = ToPython(factor);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_circles", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray) make_classification(int n_samples = 100, int n_features = 20, int n_informative = 2, int n_redundant = 2, int n_repeated = 0, int n_classes = 2, int n_clusters_per_class = 2, NDarray? weights = null, float flip_y = 0.01f, float class_sep = 1.0f, bool hypercube = true, float? shift = 0.0f, float? scale = 1.0f, bool shuffle = true, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (n_features != 20)
                    pyDict["n_features"] = ToPython(n_features);
                if (n_informative != 2)
                    pyDict["n_informative"] = ToPython(n_informative);
                if (n_redundant != 2)
                    pyDict["n_redundant"] = ToPython(n_redundant);
                if (n_repeated != 0)
                    pyDict["n_repeated"] = ToPython(n_repeated);
                if (n_classes != 2)
                    pyDict["n_classes"] = ToPython(n_classes);
                if (n_clusters_per_class != 2)
                    pyDict["n_clusters_per_class"] = ToPython(n_clusters_per_class);
                if (weights != null)
                    pyDict["weights"] = ToPython(weights);
                if (flip_y != 0.01f)
                    pyDict["flip_y"] = ToPython(flip_y);
                if (class_sep != 1.0f)
                    pyDict["class_sep"] = ToPython(class_sep);
                if (hypercube != true)
                    pyDict["hypercube"] = ToPython(hypercube);
                if (shift != 0.0f)
                    pyDict["shift"] = ToPython(shift);
                if (scale != 1.0f)
                    pyDict["scale"] = ToPython(scale);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_classification", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray) make_friedman1(int n_samples = 100, int n_features = 10, float noise = 0.0f, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (n_features != 10)
                    pyDict["n_features"] = ToPython(n_features);
                if (noise != 0.0f)
                    pyDict["noise"] = ToPython(noise);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_friedman1", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray) make_friedman2(int n_samples = 100, float noise = 0.0f, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (noise != 0.0f)
                    pyDict["noise"] = ToPython(noise);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_friedman2", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray) make_friedman3(int n_samples = 100, float noise = 0.0f, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (noise != 0.0f)
                    pyDict["noise"] = ToPython(noise);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_friedman3", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray) make_gaussian_quantiles(NDarray? mean = null, float cov = 1.0f, int n_samples = 100, int n_features = 2, int n_classes = 3, bool shuffle = true, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (mean != null)
                    pyDict["mean"] = ToPython(mean);
                if (cov != 1.0f)
                    pyDict["cov"] = ToPython(cov);
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (n_features != 2)
                    pyDict["n_features"] = ToPython(n_features);
                if (n_classes != 3)
                    pyDict["n_classes"] = ToPython(n_classes);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_gaussian_quantiles", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray) make_hastie_10_2(int n_samples = 12000, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 12000)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_hastie_10_2", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static NDarray make_low_rank_matrix(int n_samples = 100, int n_features = 100, int effective_rank = 10, float tail_strength = 0.5f, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (n_features != 100)
                    pyDict["n_features"] = ToPython(n_features);
                if (effective_rank != 10)
                    pyDict["effective_rank"] = ToPython(effective_rank);
                if (tail_strength != 0.5f)
                    pyDict["tail_strength"] = ToPython(tail_strength);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                return ToCsharp<NDarray>(sklearn.datasets.self.InvokeMethod("make_low_rank_matrix", args, pyDict));
            }

            public static (NDarray, NDarray) make_moons(int n_samples = 100, bool shuffle = true, float? noise = null, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (noise != null)
                    pyDict["noise"] = ToPython(noise);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_moons", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, NDarray, NDarray, NDarray) make_multilabel_classification(int n_samples = 100, int n_features = 20, int n_classes = 5, int n_labels = 2, int length = 50, bool allow_unlabeled = true, bool sparse = false, string return_indicator = "dense", bool return_distributions = false, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (n_features != 20)
                    pyDict["n_features"] = ToPython(n_features);
                if (n_classes != 5)
                    pyDict["n_classes"] = ToPython(n_classes);
                if (n_labels != 2)
                    pyDict["n_labels"] = ToPython(n_labels);
                if (length != 50)
                    pyDict["length"] = ToPython(length);
                if (allow_unlabeled != true)
                    pyDict["allow_unlabeled"] = ToPython(allow_unlabeled);
                if (sparse != false)
                    pyDict["sparse"] = ToPython(sparse);
                if (return_indicator != "dense")
                    pyDict["return_indicator"] = ToPython(return_indicator);
                if (return_distributions != false)
                    pyDict["return_distributions"] = ToPython(return_distributions);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_multilabel_classification", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]), ToCsharp<NDarray>(result[3]));
            }

            public static (NDarray, NDarray, NDarray) make_regression(int n_samples = 100, int n_features = 100, int n_informative = 10, int n_targets = 1, float bias = 0.0f, int? effective_rank = null, float tail_strength = 0.5f, float noise = 0.0f, bool shuffle = true, bool coef = false, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (n_features != 100)
                    pyDict["n_features"] = ToPython(n_features);
                if (n_informative != 10)
                    pyDict["n_informative"] = ToPython(n_informative);
                if (n_targets != 1)
                    pyDict["n_targets"] = ToPython(n_targets);
                if (bias != 0.0f)
                    pyDict["bias"] = ToPython(bias);
                if (effective_rank != null)
                    pyDict["effective_rank"] = ToPython(effective_rank);
                if (tail_strength != 0.5f)
                    pyDict["tail_strength"] = ToPython(tail_strength);
                if (noise != 0.0f)
                    pyDict["noise"] = ToPython(noise);
                if (shuffle != true)
                    pyDict["shuffle"] = ToPython(shuffle);
                if (coef != false)
                    pyDict["coef"] = ToPython(coef);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_regression", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]), ToCsharp<NDarray>(result[2]));
            }

            public static (NDarray, NDarray) make_s_curve(int n_samples = 100, float noise = 0.0f, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (noise != 0.0f)
                    pyDict["noise"] = ToPython(noise);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_s_curve", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static (NDarray, PyDict, NDarray) make_sparse_coded_signal(int n_samples, int n_components, int n_features, int n_nonzero_coefs, int? random_state = null)
            {
                PyTuple args = ToTuple(new object[] { n_samples, n_components, n_features, n_nonzero_coefs });
                PyDict pyDict = new PyDict();
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_sparse_coded_signal", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<PyDict>(result[1]), ToCsharp<NDarray>(result[2]));
            }

            public static NDarray make_sparse_spd_matrix(int? n_dim = null, float alpha = 0.95f, bool norm_diag = false, float smallest_coef = 0.1f, float largest_coef = 0.9f, string? sparse_format = null, int? random_state = null, string dim = "deprecated")
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_dim != null)
                    pyDict["n_dim"] = ToPython(n_dim);
                if (alpha != 0.95f)
                    pyDict["alpha"] = ToPython(alpha);
                if (norm_diag != false)
                    pyDict["norm_diag"] = ToPython(norm_diag);
                if (smallest_coef != 0.1f)
                    pyDict["smallest_coef"] = ToPython(smallest_coef);
                if (largest_coef != 0.9f)
                    pyDict["largest_coef"] = ToPython(largest_coef);
                if (sparse_format != null)
                    pyDict["sparse_format"] = ToPython(sparse_format);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (dim != "deprecated")
                    pyDict["dim"] = ToPython(dim);
                return ToCsharp<NDarray>(sklearn.datasets.self.InvokeMethod("make_sparse_spd_matrix", args, pyDict));
            }

            public static (NDarray, NDarray) make_sparse_uncorrelated(int n_samples = 100, int n_features = 10, int? random_state = null)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (n_features != 10)
                    pyDict["n_features"] = ToPython(n_features);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_sparse_uncorrelated", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }

            public static NDarray make_spd_matrix(int n_dim, int? random_state = null)
            {
                PyTuple args = ToTuple(new object[] { n_dim });
                PyDict pyDict = new PyDict();
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                return ToCsharp<NDarray>(sklearn.datasets.self.InvokeMethod("make_spd_matrix", args, pyDict));
            }

            public static (NDarray, NDarray) make_swiss_roll(int n_samples = 100, float noise = 0.0f, int? random_state = null, bool hole = false)
            {
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (n_samples != 100)
                    pyDict["n_samples"] = ToPython(n_samples);
                if (noise != 0.0f)
                    pyDict["noise"] = ToPython(noise);
                if (random_state != null)
                    pyDict["random_state"] = ToPython(random_state);
                if (hole != false)
                    pyDict["hole"] = ToPython(hole);
                PyTuple result = new PyTuple(sklearn.datasets.self.InvokeMethod("make_swiss_roll", args, pyDict));
                return (ToCsharp<NDarray>(result[0]), ToCsharp<NDarray>(result[1]));
            }
        }
    }
}