namespace ScikitLearn;
#nullable enable
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

        static datasets() => ReInitializeLazySelf();
        public static void clear_data_home(string? data_home = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            self.InvokeMethod("clear_data_home", args, pyDict);
        }

        public static void dump_svmlight_file(NDarray X, NDarray y, string f, bool zero_based = true, string? comment = null, NDarray? query_id = null, bool multilabel = false)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y), Helpers.ToPython(f) });
            PyDict pyDict = new PyDict();
            if (zero_based != true)
                pyDict["zero_based"] = Helpers.ToPython(zero_based);
            if (comment != null)
                pyDict["comment"] = Helpers.ToPython(comment);
            if (query_id != null)
                pyDict["query_id"] = Helpers.ToPython(query_id);
            if (multilabel != false)
                pyDict["multilabel"] = Helpers.ToPython(multilabel);
            self.InvokeMethod("dump_svmlight_file", args, pyDict);
        }

        public static (PyDict? , PyTuple? ) fetch_20newsgroups(string? data_home = null, string subset = "train", NDarray? categories = null, bool shuffle = true, int? random_state = 42, PyTuple? remove = null, bool download_if_missing = true, bool return_X_y = false, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (subset != "train")
                pyDict["subset"] = Helpers.ToPython(subset);
            if (categories != null)
                pyDict["categories"] = Helpers.ToPython(categories);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != 42)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (remove != null)
                pyDict["remove"] = Helpers.ToPython(remove);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_20newsgroups", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) fetch_20newsgroups_vectorized(string subset = "train", PyTuple? remove = null, string? data_home = null, bool download_if_missing = true, bool return_X_y = false, bool normalize = true, bool as_frame = false, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (subset != "train")
                pyDict["subset"] = Helpers.ToPython(subset);
            if (remove != null)
                pyDict["remove"] = Helpers.ToPython(remove);
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (normalize != true)
                pyDict["normalize"] = Helpers.ToPython(normalize);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_20newsgroups_vectorized", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) fetch_california_housing(string? data_home = null, bool download_if_missing = true, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_california_housing", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) fetch_covtype(string? data_home = null, bool download_if_missing = true, int? random_state = null, bool shuffle = false, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (shuffle != false)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_covtype", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) fetch_kddcup99(PyObject? subset = null, string? data_home = null, bool shuffle = false, int? random_state = null, bool percent10 = true, bool download_if_missing = true, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (subset != null)
                pyDict["subset"] = Helpers.ToPython(subset);
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (shuffle != false)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (percent10 != true)
                pyDict["percent10"] = Helpers.ToPython(percent10);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_kddcup99", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static PyDict fetch_lfw_pairs(string subset = "train", string? data_home = null, bool funneled = true, float resize = 0.5f, bool color = false, PyTuple? slice_ = null, bool download_if_missing = true, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (subset != "train")
                pyDict["subset"] = Helpers.ToPython(subset);
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (funneled != true)
                pyDict["funneled"] = Helpers.ToPython(funneled);
            if (resize != 0.5f)
                pyDict["resize"] = Helpers.ToPython(resize);
            if (color != false)
                pyDict["color"] = Helpers.ToPython(color);
            if (slice_ != null)
                pyDict["slice_"] = Helpers.ToPython(slice_);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_lfw_pairs", args, pyDict);
            return new PyDict(__pyObject);
        }

        public static (PyDict? , PyTuple? ) fetch_lfw_people(string? data_home = null, bool funneled = true, float? resize = 0.5f, int? min_faces_per_person = 0, bool color = false, PyTuple? slice_ = null, bool download_if_missing = true, bool return_X_y = false, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (funneled != true)
                pyDict["funneled"] = Helpers.ToPython(funneled);
            if (resize != 0.5f)
                pyDict["resize"] = Helpers.ToPython(resize);
            if (min_faces_per_person != 0)
                pyDict["min_faces_per_person"] = Helpers.ToPython(min_faces_per_person);
            if (color != false)
                pyDict["color"] = Helpers.ToPython(color);
            if (slice_ != null)
                pyDict["slice_"] = Helpers.ToPython(slice_);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_lfw_people", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) fetch_olivetti_faces(string? data_home = null, bool shuffle = false, int? random_state = 0, bool download_if_missing = true, bool return_X_y = false, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (shuffle != false)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != 0)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_olivetti_faces", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) fetch_openml(string? name = null, string version = "active", int? data_id = null, string? data_home = null, string? target_column = "default-target", bool cache = true, bool return_X_y = false, string as_frame = "auto", int n_retries = 3, float delay = 1.0f, string parser = "auto", PyDict? read_csv_kwargs = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (name != null)
                pyDict["name"] = Helpers.ToPython(name);
            if (version != "active")
                pyDict["version"] = Helpers.ToPython(version);
            if (data_id != null)
                pyDict["data_id"] = Helpers.ToPython(data_id);
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (target_column != "default-target")
                pyDict["target_column"] = Helpers.ToPython(target_column);
            if (cache != true)
                pyDict["cache"] = Helpers.ToPython(cache);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != "auto")
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            if (parser != "auto")
                pyDict["parser"] = Helpers.ToPython(parser);
            if (read_csv_kwargs != null)
                pyDict["read_csv_kwargs"] = Helpers.ToPython(read_csv_kwargs);
            var __pyObject = self.InvokeMethod("fetch_openml", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) fetch_rcv1(string? data_home = null, string subset = "all", bool download_if_missing = true, int? random_state = null, bool shuffle = false, bool return_X_y = false, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (subset != "all")
                pyDict["subset"] = Helpers.ToPython(subset);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (shuffle != false)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_rcv1", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static PyDict fetch_species_distributions(string? data_home = null, bool download_if_missing = true, int n_retries = 3, float delay = 1.0f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            if (download_if_missing != true)
                pyDict["download_if_missing"] = Helpers.ToPython(download_if_missing);
            if (n_retries != 3)
                pyDict["n_retries"] = Helpers.ToPython(n_retries);
            if (delay != 1.0f)
                pyDict["delay"] = Helpers.ToPython(delay);
            var __pyObject = self.InvokeMethod("fetch_species_distributions", args, pyDict);
            return new PyDict(__pyObject);
        }

        public static string get_data_home(string? data_home = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (data_home != null)
                pyDict["data_home"] = Helpers.ToPython(data_home);
            var __pyObject = self.InvokeMethod("get_data_home", args, pyDict);
            return __pyObject.As<string>();
        }

        public static (PyDict? , PyTuple? ) load_breast_cancer(bool return_X_y = false, bool as_frame = false)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            var __pyObject = self.InvokeMethod("load_breast_cancer", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) load_diabetes(bool return_X_y = false, bool as_frame = false, bool scaled = true)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            if (scaled != true)
                pyDict["scaled"] = Helpers.ToPython(scaled);
            var __pyObject = self.InvokeMethod("load_diabetes", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) load_digits(int n_class = 10, bool return_X_y = false, bool as_frame = false)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_class != 10)
                pyDict["n_class"] = Helpers.ToPython(n_class);
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            var __pyObject = self.InvokeMethod("load_digits", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static PyDict load_files(string container_path, string? description = null, PyTuple? categories = null, bool load_content = true, bool shuffle = true, string? encoding = null, string decode_error = "strict", int? random_state = 0, PyTuple? allowed_extensions = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(container_path) });
            PyDict pyDict = new PyDict();
            if (description != null)
                pyDict["description"] = Helpers.ToPython(description);
            if (categories != null)
                pyDict["categories"] = Helpers.ToPython(categories);
            if (load_content != true)
                pyDict["load_content"] = Helpers.ToPython(load_content);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (encoding != null)
                pyDict["encoding"] = Helpers.ToPython(encoding);
            if (decode_error != "strict")
                pyDict["decode_error"] = Helpers.ToPython(decode_error);
            if (random_state != 0)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (allowed_extensions != null)
                pyDict["allowed_extensions"] = Helpers.ToPython(allowed_extensions);
            var __pyObject = self.InvokeMethod("load_files", args, pyDict);
            return new PyDict(__pyObject);
        }

        public static (PyDict? , PyTuple? ) load_iris(bool return_X_y = false, bool as_frame = false)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            var __pyObject = self.InvokeMethod("load_iris", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (PyDict? , PyTuple? ) load_linnerud(bool return_X_y = false, bool as_frame = false)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            var __pyObject = self.InvokeMethod("load_linnerud", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static NDarray load_sample_image(PyObject image_name)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(image_name) });
            PyDict pyDict = new PyDict();
            var __pyObject = self.InvokeMethod("load_sample_image", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static PyDict load_sample_images()
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            var __pyObject = self.InvokeMethod("load_sample_images", args, pyDict);
            return new PyDict(__pyObject);
        }

        public static (NDarray? , NDarray? , NDarray? ) load_svmlight_file(string f, int? n_features = null, float? dtype = null, bool multilabel = false, string zero_based = "auto", bool query_id = false, int offset = 0, int length = -1)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(f) });
            PyDict pyDict = new PyDict();
            if (n_features != null)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (dtype != null)
                pyDict["dtype"] = Helpers.ToPython(dtype);
            if (multilabel != false)
                pyDict["multilabel"] = Helpers.ToPython(multilabel);
            if (zero_based != "auto")
                pyDict["zero_based"] = Helpers.ToPython(zero_based);
            if (query_id != false)
                pyDict["query_id"] = Helpers.ToPython(query_id);
            if (offset != 0)
                pyDict["offset"] = Helpers.ToPython(offset);
            if (length != -1)
                pyDict["length"] = Helpers.ToPython(length);
            var __pyObject = self.InvokeMethod("load_svmlight_file", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null, __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null);
        }

        public static NDarray load_svmlight_files(NDarray files, int? n_features = null, float? dtype = null, bool multilabel = false, string zero_based = "auto", bool query_id = false, int offset = 0, int length = -1)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(files) });
            PyDict pyDict = new PyDict();
            if (n_features != null)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (dtype != null)
                pyDict["dtype"] = Helpers.ToPython(dtype);
            if (multilabel != false)
                pyDict["multilabel"] = Helpers.ToPython(multilabel);
            if (zero_based != "auto")
                pyDict["zero_based"] = Helpers.ToPython(zero_based);
            if (query_id != false)
                pyDict["query_id"] = Helpers.ToPython(query_id);
            if (offset != 0)
                pyDict["offset"] = Helpers.ToPython(offset);
            if (length != -1)
                pyDict["length"] = Helpers.ToPython(length);
            var __pyObject = self.InvokeMethod("load_svmlight_files", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static (PyDict? , PyTuple? ) load_wine(bool return_X_y = false, bool as_frame = false)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (return_X_y != false)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            if (as_frame != false)
                pyDict["as_frame"] = Helpers.ToPython(as_frame);
            var __pyObject = self.InvokeMethod("load_wine", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new PyDict(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new PyTuple(__pyObjectTuple[1]) : null);
        }

        public static (NDarray? , NDarray? , NDarray? ) make_biclusters(NDarray shape, int n_clusters, float noise = 0.0f, int minval = 10, int maxval = 100, bool shuffle = true, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(shape), Helpers.ToPython(n_clusters) });
            PyDict pyDict = new PyDict();
            if (noise != 0.0f)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (minval != 10)
                pyDict["minval"] = Helpers.ToPython(minval);
            if (maxval != 100)
                pyDict["maxval"] = Helpers.ToPython(maxval);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_biclusters", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null, __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null);
        }

        public static (NDarray X, NDarray y, NDarray? centers) make_blobs(int n_samples = 100, int n_features = 2, NDarray? centers = null, float cluster_std = 1.0f, PyTuple? center_box = null, bool shuffle = true, int? random_state = null, bool return_centers = false)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (n_features != 2)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (centers != null)
                pyDict["centers"] = Helpers.ToPython(centers);
            if (cluster_std != 1.0f)
                pyDict["cluster_std"] = Helpers.ToPython(cluster_std);
            if (center_box != null)
                pyDict["center_box"] = Helpers.ToPython(center_box);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (return_centers != false)
                pyDict["return_centers"] = Helpers.ToPython(return_centers);
            var __pyObject = self.InvokeMethod("make_blobs", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]), __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null);
        }

        public static (NDarray X, NDarray rows, NDarray cols) make_checkerboard(NDarray shape, NDarray n_clusters, float noise = 0.0f, int minval = 10, int maxval = 100, bool shuffle = true, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(shape), Helpers.ToPython(n_clusters) });
            PyDict pyDict = new PyDict();
            if (noise != 0.0f)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (minval != 10)
                pyDict["minval"] = Helpers.ToPython(minval);
            if (maxval != 100)
                pyDict["maxval"] = Helpers.ToPython(maxval);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_checkerboard", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]), new NDarray(__pyObjectTuple[2]));
        }

        public static (NDarray X, NDarray y) make_circles(int n_samples = 100, bool shuffle = true, float? noise = null, int? random_state = null, float factor = 0.8f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (noise != null)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (factor != 0.8f)
                pyDict["factor"] = Helpers.ToPython(factor);
            var __pyObject = self.InvokeMethod("make_circles", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (NDarray X, NDarray y) make_circles((int, int) n_samples, bool shuffle = true, float? noise = null, int? random_state = null, float factor = 0.8f)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_samples) });
            PyDict pyDict = new PyDict();
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (noise != null)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (factor != 0.8f)
                pyDict["factor"] = Helpers.ToPython(factor);
            var __pyObject = self.InvokeMethod("make_circles", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (sklearn.utils.Bunch? data, (NDarray X, NDarray y)? X_y) make_classification(int n_samples = 100, int n_features = 20, int n_informative = 2, int n_redundant = 2, int n_repeated = 0, int n_classes = 2, int n_clusters_per_class = 2, NDarray? weights = null, float flip_y = 0.01f, float class_sep = 1.0f, bool hypercube = true, float? shift = 0.0f, float? scale = 1.0f, bool shuffle = true, int? random_state = null, bool return_X_y = true)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (n_features != 20)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (n_informative != 2)
                pyDict["n_informative"] = Helpers.ToPython(n_informative);
            if (n_redundant != 2)
                pyDict["n_redundant"] = Helpers.ToPython(n_redundant);
            if (n_repeated != 0)
                pyDict["n_repeated"] = Helpers.ToPython(n_repeated);
            if (n_classes != 2)
                pyDict["n_classes"] = Helpers.ToPython(n_classes);
            if (n_clusters_per_class != 2)
                pyDict["n_clusters_per_class"] = Helpers.ToPython(n_clusters_per_class);
            if (weights != null)
                pyDict["weights"] = Helpers.ToPython(weights);
            if (flip_y != 0.01f)
                pyDict["flip_y"] = Helpers.ToPython(flip_y);
            if (class_sep != 1.0f)
                pyDict["class_sep"] = Helpers.ToPython(class_sep);
            if (hypercube != true)
                pyDict["hypercube"] = Helpers.ToPython(hypercube);
            if (shift != 0.0f)
                pyDict["shift"] = Helpers.ToPython(shift);
            if (scale != 1.0f)
                pyDict["scale"] = Helpers.ToPython(scale);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (return_X_y != true)
                pyDict["return_X_y"] = Helpers.ToPython(return_X_y);
            var __pyVariant = self.InvokeMethod("make_classification", args, pyDict);
            if (return_X_y == false)
            {
                return (ScikitLearn.sklearn.utils.Bunch.Wrap(__pyVariant), null);
            }
            else
            {
                var __pyVariantTuple = new PyTuple(__pyVariant);
                var __pyVariantLength = __pyVariantTuple.Length();
                return (null, (new NDarray(__pyVariantTuple[0]), new NDarray(__pyVariantTuple[1])));
            }
        }

        public static (NDarray X, NDarray y) make_friedman1(int n_samples = 100, int n_features = 10, float noise = 0.0f, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (n_features != 10)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (noise != 0.0f)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_friedman1", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (NDarray X, NDarray y) make_friedman2(int n_samples = 100, float noise = 0.0f, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (noise != 0.0f)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_friedman2", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (NDarray X, NDarray y) make_friedman3(int n_samples = 100, float noise = 0.0f, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (noise != 0.0f)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_friedman3", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (NDarray X, NDarray y) make_gaussian_quantiles(NDarray? mean = null, float cov = 1.0f, int n_samples = 100, int n_features = 2, int n_classes = 3, bool shuffle = true, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (mean != null)
                pyDict["mean"] = Helpers.ToPython(mean);
            if (cov != 1.0f)
                pyDict["cov"] = Helpers.ToPython(cov);
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (n_features != 2)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (n_classes != 3)
                pyDict["n_classes"] = Helpers.ToPython(n_classes);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_gaussian_quantiles", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (NDarray X, NDarray y) make_hastie_10_2(int n_samples = 12000, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 12000)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_hastie_10_2", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static NDarray make_low_rank_matrix(int n_samples = 100, int n_features = 100, int effective_rank = 10, float tail_strength = 0.5f, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (n_features != 100)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (effective_rank != 10)
                pyDict["effective_rank"] = Helpers.ToPython(effective_rank);
            if (tail_strength != 0.5f)
                pyDict["tail_strength"] = Helpers.ToPython(tail_strength);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_low_rank_matrix", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static (NDarray X, NDarray y) make_moons(int n_samples = 100, bool shuffle = true, float? noise = null, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (noise != null)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_moons", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (NDarray X, NDarray y) make_moons(Shape n_samples, bool shuffle = true, float? noise = null, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_samples) });
            PyDict pyDict = new PyDict();
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (noise != null)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_moons", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (NDarray X, NDarray Y, NDarray? p_c, NDarray? p_w_c) make_multilabel_classification(int n_samples = 100, int n_features = 20, int n_classes = 5, int n_labels = 2, int length = 50, bool allow_unlabeled = true, bool sparse = false, string return_indicator = "dense", bool return_distributions = false, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (n_features != 20)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (n_classes != 5)
                pyDict["n_classes"] = Helpers.ToPython(n_classes);
            if (n_labels != 2)
                pyDict["n_labels"] = Helpers.ToPython(n_labels);
            if (length != 50)
                pyDict["length"] = Helpers.ToPython(length);
            if (allow_unlabeled != true)
                pyDict["allow_unlabeled"] = Helpers.ToPython(allow_unlabeled);
            if (sparse != false)
                pyDict["sparse"] = Helpers.ToPython(sparse);
            if (return_indicator != "dense")
                pyDict["return_indicator"] = Helpers.ToPython(return_indicator);
            if (return_distributions != false)
                pyDict["return_distributions"] = Helpers.ToPython(return_distributions);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_multilabel_classification", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]), __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null, __pyObjectLength > 3 ? new NDarray(__pyObjectTuple[3]) : null);
        }

        public static (NDarray X, NDarray y, NDarray? coef) make_regression(int n_samples = 100, int n_features = 100, int n_informative = 10, int n_targets = 1, float bias = 0.0f, int? effective_rank = null, float tail_strength = 0.5f, float noise = 0.0f, bool shuffle = true, bool coef = false, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (n_features != 100)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (n_informative != 10)
                pyDict["n_informative"] = Helpers.ToPython(n_informative);
            if (n_targets != 1)
                pyDict["n_targets"] = Helpers.ToPython(n_targets);
            if (bias != 0.0f)
                pyDict["bias"] = Helpers.ToPython(bias);
            if (effective_rank != null)
                pyDict["effective_rank"] = Helpers.ToPython(effective_rank);
            if (tail_strength != 0.5f)
                pyDict["tail_strength"] = Helpers.ToPython(tail_strength);
            if (noise != 0.0f)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (coef != false)
                pyDict["coef"] = Helpers.ToPython(coef);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_regression", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]), __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null);
        }

        public static (NDarray X, NDarray t) make_s_curve(int n_samples = 100, float noise = 0.0f, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (noise != 0.0f)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_s_curve", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static (NDarray data, NDarray dictionary, NDarray code) make_sparse_coded_signal(int n_samples, int n_components, int n_features, int n_nonzero_coefs, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_samples), Helpers.ToPython(n_components), Helpers.ToPython(n_features), Helpers.ToPython(n_nonzero_coefs) });
            PyDict pyDict = new PyDict();
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_sparse_coded_signal", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]), new NDarray(__pyObjectTuple[2]));
        }

        public static NDarray make_sparse_spd_matrix(int n_dim = 1, float alpha = 0.95f, bool norm_diag = false, float smallest_coef = 0.1f, float largest_coef = 0.9f, string? sparse_format = null, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_dim != 1)
                pyDict["n_dim"] = Helpers.ToPython(n_dim);
            if (alpha != 0.95f)
                pyDict["alpha"] = Helpers.ToPython(alpha);
            if (norm_diag != false)
                pyDict["norm_diag"] = Helpers.ToPython(norm_diag);
            if (smallest_coef != 0.1f)
                pyDict["smallest_coef"] = Helpers.ToPython(smallest_coef);
            if (largest_coef != 0.9f)
                pyDict["largest_coef"] = Helpers.ToPython(largest_coef);
            if (sparse_format != null)
                pyDict["sparse_format"] = Helpers.ToPython(sparse_format);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_sparse_spd_matrix", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static (NDarray X, NDarray y) make_sparse_uncorrelated(int n_samples = 100, int n_features = 10, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (n_features != 10)
                pyDict["n_features"] = Helpers.ToPython(n_features);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_sparse_uncorrelated", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }

        public static NDarray make_spd_matrix(int n_dim, int? random_state = null)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_dim) });
            PyDict pyDict = new PyDict();
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("make_spd_matrix", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static (NDarray X, NDarray t) make_swiss_roll(int n_samples = 100, float noise = 0.0f, int? random_state = null, bool hole = false)
        {
            _ = sklearn.datasets.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (n_samples != 100)
                pyDict["n_samples"] = Helpers.ToPython(n_samples);
            if (noise != 0.0f)
                pyDict["noise"] = Helpers.ToPython(noise);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (hole != false)
                pyDict["hole"] = Helpers.ToPython(hole);
            var __pyObject = self.InvokeMethod("make_swiss_roll", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (new NDarray(__pyObjectTuple[0]), new NDarray(__pyObjectTuple[1]));
        }
    }
}