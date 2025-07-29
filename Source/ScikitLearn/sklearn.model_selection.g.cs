namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class model_selection
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
            return Py.Import("sklearn.model_selection");
        }

        static model_selection() => ReInitializeLazySelf();
        public static PyObject check_cv(int? cv = 5, NDarray? y = null, bool classifier = false)
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { });
            PyDict pyDict = new PyDict();
            if (cv != 5)
                pyDict["cv"] = Helpers.ToPython(cv);
            if (y != null)
                pyDict["y"] = Helpers.ToPython(y);
            if (classifier != false)
                pyDict["classifier"] = Helpers.ToPython(classifier);
            var __pyObject = self.InvokeMethod("check_cv", args, pyDict);
            return __pyObject;
        }

        public static NDarray train_test_split(NDarray[] arrays, float? test_size = null, float? train_size = null, int? random_state = null, bool shuffle = true, NDarray? stratify = null)
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(arrays) });
            PyDict pyDict = new PyDict();
            if (test_size != null)
                pyDict["test_size"] = Helpers.ToPython(test_size);
            if (train_size != null)
                pyDict["train_size"] = Helpers.ToPython(train_size);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (shuffle != true)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (stratify != null)
                pyDict["stratify"] = Helpers.ToPython(stratify);
            var __pyObject = self.InvokeMethod("train_test_split", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static PyDict ParameterSampler(PyDict param_distributions, int n_iter, int? random_state = null)
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(param_distributions), Helpers.ToPython(n_iter) });
            PyDict pyDict = new PyDict();
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            var __pyObject = self.InvokeMethod("ParameterSampler", args, pyDict);
            return new PyDict(__pyObject);
        }

        public static PyDict cross_val_predict(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", string method = "predict")
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (y != null)
                pyDict["y"] = Helpers.ToPython(y);
            if (groups != null)
                pyDict["groups"] = Helpers.ToPython(groups);
            if (cv != null)
                pyDict["cv"] = Helpers.ToPython(cv);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (verbose != 0)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (fit_params != null)
                pyDict["fit_params"] = Helpers.ToPython(fit_params);
            if (@params != null)
                pyDict["params"] = Helpers.ToPython(@params);
            if (pre_dispatch != "2*n_jobs")
                pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
            if (method != "predict")
                pyDict["method"] = Helpers.ToPython(method);
            var __pyObject = self.InvokeMethod("cross_val_predict", args, pyDict);
            return new PyDict(__pyObject);
        }

        public static NDarray cross_val_score(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, string? scoring = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", PyObject? error_score = null)
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (y != null)
                pyDict["y"] = Helpers.ToPython(y);
            if (groups != null)
                pyDict["groups"] = Helpers.ToPython(groups);
            if (scoring != null)
                pyDict["scoring"] = Helpers.ToPython(scoring);
            if (cv != null)
                pyDict["cv"] = Helpers.ToPython(cv);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (verbose != 0)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (fit_params != null)
                pyDict["fit_params"] = Helpers.ToPython(fit_params);
            if (@params != null)
                pyDict["params"] = Helpers.ToPython(@params);
            if (pre_dispatch != "2*n_jobs")
                pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
            if (error_score != null)
                pyDict["error_score"] = Helpers.ToPython(error_score);
            var __pyObject = self.InvokeMethod("cross_val_score", args, pyDict);
            return new NDarray(__pyObject);
        }

        public static PyDict cross_validate(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, PyDict? scoring = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", bool return_train_score = false, bool return_estimator = false, bool return_indices = false, PyObject? error_score = null)
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X) });
            PyDict pyDict = new PyDict();
            if (y != null)
                pyDict["y"] = Helpers.ToPython(y);
            if (groups != null)
                pyDict["groups"] = Helpers.ToPython(groups);
            if (scoring != null)
                pyDict["scoring"] = Helpers.ToPython(scoring);
            if (cv != null)
                pyDict["cv"] = Helpers.ToPython(cv);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (verbose != 0)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (fit_params != null)
                pyDict["fit_params"] = Helpers.ToPython(fit_params);
            if (@params != null)
                pyDict["params"] = Helpers.ToPython(@params);
            if (pre_dispatch != "2*n_jobs")
                pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
            if (return_train_score != false)
                pyDict["return_train_score"] = Helpers.ToPython(return_train_score);
            if (return_estimator != false)
                pyDict["return_estimator"] = Helpers.ToPython(return_estimator);
            if (return_indices != false)
                pyDict["return_indices"] = Helpers.ToPython(return_indices);
            if (error_score != null)
                pyDict["error_score"] = Helpers.ToPython(error_score);
            var __pyObject = self.InvokeMethod("cross_validate", args, pyDict);
            return new PyDict(__pyObject);
        }

        public static (NDarray? , NDarray? , NDarray? , NDarray? , NDarray? ) learning_curve(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, NDarray? train_sizes = null, int? cv = null, string? scoring = null, bool exploit_incremental_learning = false, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, bool shuffle = false, int? random_state = null, PyObject? error_score = null, bool return_times = false, PyDict? fit_params = null)
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y) });
            PyDict pyDict = new PyDict();
            if (groups != null)
                pyDict["groups"] = Helpers.ToPython(groups);
            if (train_sizes != null)
                pyDict["train_sizes"] = Helpers.ToPython(train_sizes);
            if (cv != null)
                pyDict["cv"] = Helpers.ToPython(cv);
            if (scoring != null)
                pyDict["scoring"] = Helpers.ToPython(scoring);
            if (exploit_incremental_learning != false)
                pyDict["exploit_incremental_learning"] = Helpers.ToPython(exploit_incremental_learning);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (pre_dispatch != "all")
                pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
            if (verbose != 0)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (shuffle != false)
                pyDict["shuffle"] = Helpers.ToPython(shuffle);
            if (random_state != null)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (error_score != null)
                pyDict["error_score"] = Helpers.ToPython(error_score);
            if (return_times != false)
                pyDict["return_times"] = Helpers.ToPython(return_times);
            if (fit_params != null)
                pyDict["fit_params"] = Helpers.ToPython(fit_params);
            var __pyObject = self.InvokeMethod("learning_curve", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null, __pyObjectLength > 2 ? new NDarray(__pyObjectTuple[2]) : null, __pyObjectLength > 3 ? new NDarray(__pyObjectTuple[3]) : null, __pyObjectLength > 4 ? new NDarray(__pyObjectTuple[4]) : null);
        }

        public static (float? , NDarray? , float? ) permutation_test_score(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, int? cv = null, int n_permutations = 100, int? n_jobs = null, int? random_state = 0, int verbose = 0, string? scoring = null, PyDict? fit_params = null)
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y) });
            PyDict pyDict = new PyDict();
            if (groups != null)
                pyDict["groups"] = Helpers.ToPython(groups);
            if (cv != null)
                pyDict["cv"] = Helpers.ToPython(cv);
            if (n_permutations != 100)
                pyDict["n_permutations"] = Helpers.ToPython(n_permutations);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (random_state != 0)
                pyDict["random_state"] = Helpers.ToPython(random_state);
            if (verbose != 0)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (scoring != null)
                pyDict["scoring"] = Helpers.ToPython(scoring);
            if (fit_params != null)
                pyDict["fit_params"] = Helpers.ToPython(fit_params);
            var __pyObject = self.InvokeMethod("permutation_test_score", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? __pyObjectTuple[0].As<float>() : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null, __pyObjectLength > 2 ? __pyObjectTuple[2].As<float>() : null);
        }

        public static (NDarray? , NDarray? ) validation_curve(PyObject estimator, NDarray X, NDarray y, string param_name, NDarray param_range, NDarray? groups = null, int? cv = null, string? scoring = null, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, PyObject? error_score = null, PyDict? fit_params = null)
        {
            _ = sklearn.model_selection.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y), Helpers.ToPython(param_name), Helpers.ToPython(param_range) });
            PyDict pyDict = new PyDict();
            if (groups != null)
                pyDict["groups"] = Helpers.ToPython(groups);
            if (cv != null)
                pyDict["cv"] = Helpers.ToPython(cv);
            if (scoring != null)
                pyDict["scoring"] = Helpers.ToPython(scoring);
            if (n_jobs != null)
                pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
            if (pre_dispatch != "all")
                pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
            if (verbose != 0)
                pyDict["verbose"] = Helpers.ToPython(verbose);
            if (error_score != null)
                pyDict["error_score"] = Helpers.ToPython(error_score);
            if (fit_params != null)
                pyDict["fit_params"] = Helpers.ToPython(fit_params);
            var __pyObject = self.InvokeMethod("validation_curve", args, pyDict);
            var __pyObjectTuple = new PyTuple(__pyObject);
            var __pyObjectLength = __pyObjectTuple.Length();
            return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
        }

        public class GroupKFold : PythonObject
        {
            public GroupKFold(int n_splits = 5)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 5)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                self = sklearn.model_selection.self.InvokeMethod("GroupKFold", args, pyDict);
            }

            internal GroupKFold(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static GroupKFold Encapsule(PyObject pyObject) => new GroupKFold(pyObject);
            public static GroupKFold Wrap(PyObject pyObject) => new GroupKFold(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public GroupKFold set_split_request(string? groups = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (groups != "$UNCHANGED$")
                    pyDict["groups"] = Helpers.ToPython(groups);
                self.InvokeMethod("set_split_request", args, pyDict);
                return this;
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class GroupShuffleSplit : PythonObject
        {
            public GroupShuffleSplit(int n_splits = 5, float? test_size = null, float? train_size = null, int? random_state = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 5)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (test_size != null)
                    pyDict["test_size"] = Helpers.ToPython(test_size);
                if (train_size != null)
                    pyDict["train_size"] = Helpers.ToPython(train_size);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.model_selection.self.InvokeMethod("GroupShuffleSplit", args, pyDict);
            }

            internal GroupShuffleSplit(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static GroupShuffleSplit Encapsule(PyObject pyObject) => new GroupShuffleSplit(pyObject);
            public static GroupShuffleSplit Wrap(PyObject pyObject) => new GroupShuffleSplit(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public GroupShuffleSplit set_split_request(string? groups = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (groups != "$UNCHANGED$")
                    pyDict["groups"] = Helpers.ToPython(groups);
                self.InvokeMethod("set_split_request", args, pyDict);
                return this;
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class KFold : PythonObject
        {
            public KFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 5)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (shuffle != false)
                    pyDict["shuffle"] = Helpers.ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.model_selection.self.InvokeMethod("KFold", args, pyDict);
            }

            internal KFold(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static KFold Encapsule(PyObject pyObject) => new KFold(pyObject);
            public static KFold Wrap(PyObject pyObject) => new KFold(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class LeaveOneGroupOut : PythonObject
        {
            public LeaveOneGroupOut()
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.model_selection.self.InvokeMethod("LeaveOneGroupOut", args, pyDict);
            }

            internal LeaveOneGroupOut(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LeaveOneGroupOut Encapsule(PyObject pyObject) => new LeaveOneGroupOut(pyObject);
            public static LeaveOneGroupOut Wrap(PyObject pyObject) => new LeaveOneGroupOut(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public LeaveOneGroupOut set_split_request(string? groups = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (groups != "$UNCHANGED$")
                    pyDict["groups"] = Helpers.ToPython(groups);
                self.InvokeMethod("set_split_request", args, pyDict);
                return this;
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class LeaveOneOut : PythonObject
        {
            public LeaveOneOut()
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.model_selection.self.InvokeMethod("LeaveOneOut", args, pyDict);
            }

            internal LeaveOneOut(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LeaveOneOut Encapsule(PyObject pyObject) => new LeaveOneOut(pyObject);
            public static LeaveOneOut Wrap(PyObject pyObject) => new LeaveOneOut(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(NDarray X, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class LeavePGroupsOut : PythonObject
        {
            public LeavePGroupsOut(int n_groups)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(n_groups) });
                PyDict pyDict = new PyDict();
                self = sklearn.model_selection.self.InvokeMethod("LeavePGroupsOut", args, pyDict);
            }

            internal LeavePGroupsOut(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LeavePGroupsOut Encapsule(PyObject pyObject) => new LeavePGroupsOut(pyObject);
            public static LeavePGroupsOut Wrap(PyObject pyObject) => new LeavePGroupsOut(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public LeavePGroupsOut set_split_request(string? groups = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (groups != "$UNCHANGED$")
                    pyDict["groups"] = Helpers.ToPython(groups);
                self.InvokeMethod("set_split_request", args, pyDict);
                return this;
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class LeavePOut : PythonObject
        {
            public LeavePOut(int p)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(p) });
                PyDict pyDict = new PyDict();
                self = sklearn.model_selection.self.InvokeMethod("LeavePOut", args, pyDict);
            }

            internal LeavePOut(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LeavePOut Encapsule(PyObject pyObject) => new LeavePOut(pyObject);
            public static LeavePOut Wrap(PyObject pyObject) => new LeavePOut(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public void get_n_splits(NDarray X, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                self.InvokeMethod("get_n_splits", args, pyDict);
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class PredefinedSplit : PythonObject
        {
            public PredefinedSplit(NDarray test_fold)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(test_fold) });
                PyDict pyDict = new PyDict();
                self = sklearn.model_selection.self.InvokeMethod("PredefinedSplit", args, pyDict);
            }

            internal PredefinedSplit(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static PredefinedSplit Encapsule(PyObject pyObject) => new PredefinedSplit(pyObject);
            public static PredefinedSplit Wrap(PyObject pyObject) => new PredefinedSplit(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class RepeatedKFold : PythonObject
        {
            public RepeatedKFold(int n_splits = 5, int n_repeats = 10, int? random_state = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 5)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (n_repeats != 10)
                    pyDict["n_repeats"] = Helpers.ToPython(n_repeats);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.model_selection.self.InvokeMethod("RepeatedKFold", args, pyDict);
            }

            internal RepeatedKFold(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static RepeatedKFold Encapsule(PyObject pyObject) => new RepeatedKFold(pyObject);
            public static RepeatedKFold Wrap(PyObject pyObject) => new RepeatedKFold(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class RepeatedStratifiedKFold : PythonObject
        {
            public RepeatedStratifiedKFold(int n_splits = 5, int n_repeats = 10, int? random_state = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 5)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (n_repeats != 10)
                    pyDict["n_repeats"] = Helpers.ToPython(n_repeats);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.model_selection.self.InvokeMethod("RepeatedStratifiedKFold", args, pyDict);
            }

            internal RepeatedStratifiedKFold(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static RepeatedStratifiedKFold Encapsule(PyObject pyObject) => new RepeatedStratifiedKFold(pyObject);
            public static RepeatedStratifiedKFold Wrap(PyObject pyObject) => new RepeatedStratifiedKFold(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class ShuffleSplit : PythonObject
        {
            public ShuffleSplit(int n_splits = 10, float? test_size = null, float? train_size = null, int? random_state = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 10)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (test_size != null)
                    pyDict["test_size"] = Helpers.ToPython(test_size);
                if (train_size != null)
                    pyDict["train_size"] = Helpers.ToPython(train_size);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.model_selection.self.InvokeMethod("ShuffleSplit", args, pyDict);
            }

            internal ShuffleSplit(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ShuffleSplit Encapsule(PyObject pyObject) => new ShuffleSplit(pyObject);
            public static ShuffleSplit Wrap(PyObject pyObject) => new ShuffleSplit(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class StratifiedGroupKFold : PythonObject
        {
            public StratifiedGroupKFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 5)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (shuffle != false)
                    pyDict["shuffle"] = Helpers.ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.model_selection.self.InvokeMethod("StratifiedGroupKFold", args, pyDict);
            }

            internal StratifiedGroupKFold(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static StratifiedGroupKFold Encapsule(PyObject pyObject) => new StratifiedGroupKFold(pyObject);
            public static StratifiedGroupKFold Wrap(PyObject pyObject) => new StratifiedGroupKFold(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public StratifiedGroupKFold set_split_request(string? groups = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (groups != "$UNCHANGED$")
                    pyDict["groups"] = Helpers.ToPython(groups);
                self.InvokeMethod("set_split_request", args, pyDict);
                return this;
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class StratifiedKFold : PythonObject
        {
            public StratifiedKFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 5)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (shuffle != false)
                    pyDict["shuffle"] = Helpers.ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.model_selection.self.InvokeMethod("StratifiedKFold", args, pyDict);
            }

            internal StratifiedKFold(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static StratifiedKFold Encapsule(PyObject pyObject) => new StratifiedKFold(pyObject);
            public static StratifiedKFold Wrap(PyObject pyObject) => new StratifiedKFold(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray y, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class StratifiedShuffleSplit : PythonObject
        {
            public StratifiedShuffleSplit(int n_splits = 10, float? test_size = null, float? train_size = null, int? random_state = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 10)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (test_size != null)
                    pyDict["test_size"] = Helpers.ToPython(test_size);
                if (train_size != null)
                    pyDict["train_size"] = Helpers.ToPython(train_size);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                self = sklearn.model_selection.self.InvokeMethod("StratifiedShuffleSplit", args, pyDict);
            }

            internal StratifiedShuffleSplit(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static StratifiedShuffleSplit Encapsule(PyObject pyObject) => new StratifiedShuffleSplit(pyObject);
            public static StratifiedShuffleSplit Wrap(PyObject pyObject) => new StratifiedShuffleSplit(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray y, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class TimeSeriesSplit : PythonObject
        {
            public TimeSeriesSplit(int n_splits = 5, int? max_train_size = null, int? test_size = null, int gap = 0)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (n_splits != 5)
                    pyDict["n_splits"] = Helpers.ToPython(n_splits);
                if (max_train_size != null)
                    pyDict["max_train_size"] = Helpers.ToPython(max_train_size);
                if (test_size != null)
                    pyDict["test_size"] = Helpers.ToPython(test_size);
                if (gap != 0)
                    pyDict["gap"] = Helpers.ToPython(gap);
                self = sklearn.model_selection.self.InvokeMethod("TimeSeriesSplit", args, pyDict);
            }

            internal TimeSeriesSplit(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static TimeSeriesSplit Encapsule(PyObject pyObject) => new TimeSeriesSplit(pyObject);
            public static TimeSeriesSplit Wrap(PyObject pyObject) => new TimeSeriesSplit(pyObject);
            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("get_n_splits", args, pyDict);
                return __pyObject.As<int>();
            }

            public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                var __pyObject = self.InvokeMethod("split", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray(__pyObjectTuple[1]) : null);
            }
        }

        public class GridSearchCV : PythonObject
        {
            public GridSearchCV(PyObject estimator, PyDict param_grid, PyDict? scoring = null, int? n_jobs = null, bool refit = true, int? cv = null, int verbose = 0, string pre_dispatch = "2*n_jobs", PyObject? error_score = null, bool return_train_score = false)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(param_grid) });
                PyDict pyDict = new PyDict();
                if (scoring != null)
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (refit != true)
                    pyDict["refit"] = Helpers.ToPython(refit);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (pre_dispatch != "2*n_jobs")
                    pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
                if (error_score != null)
                    pyDict["error_score"] = Helpers.ToPython(error_score);
                if (return_train_score != false)
                    pyDict["return_train_score"] = Helpers.ToPython(return_train_score);
                self = sklearn.model_selection.self.InvokeMethod("GridSearchCV", args, pyDict);
            }

            internal GridSearchCV(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static GridSearchCV Encapsule(PyObject pyObject) => new GridSearchCV(pyObject);
            public static GridSearchCV Wrap(PyObject pyObject) => new GridSearchCV(pyObject);
            public PyDict cv_results_
            {
                get
                {
                    var __pyObject = self.GetAttr("cv_results_");
                    return new PyDict(__pyObject);
                }
            }

            public PyObject best_estimator_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_estimator_");
                    return __pyObject;
                }
            }

            public float best_score_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_score_");
                    return __pyObject.As<float>();
                }
            }

            public PyDict best_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_params_");
                    return new PyDict(__pyObject);
                }
            }

            public int best_index_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_index_");
                    return __pyObject.As<int>();
                }
            }

            public PyDict scorer_
            {
                get
                {
                    var __pyObject = self.GetAttr("scorer_");
                    return new PyDict(__pyObject);
                }
            }

            public int n_splits_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_splits_");
                    return __pyObject.As<int>();
                }
            }

            public float refit_time_
            {
                get
                {
                    var __pyObject = self.GetAttr("refit_time_");
                    return __pyObject.As<float>();
                }
            }

            public bool multimetric_
            {
                get
                {
                    var __pyObject = self.GetAttr("multimetric_");
                    return __pyObject.As<bool>();
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

            public NDarray decision_function(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public GridSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

            public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (Xt != null)
                    pyDict["Xt"] = Helpers.ToPython(Xt);
                var __pyObject = self.InvokeMethod("inverse_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public GridSearchCV set_params(Dictionary<string, PyObject>? @params = null)
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
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class HalvingGridSearchCV : PythonObject
        {
            public HalvingGridSearchCV(PyObject estimator, PyDict param_grid, int factor = 3, string resource = "n_samples", string max_resources = "auto", string min_resources = "exhaust", bool aggressive_elimination = false, int cv = 5, string? scoring = null, bool refit = true, PyObject? error_score = null, bool return_train_score = true, int? random_state = null, int? n_jobs = null, int verbose = 0)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(param_grid) });
                PyDict pyDict = new PyDict();
                if (factor != 3)
                    pyDict["factor"] = Helpers.ToPython(factor);
                if (resource != "n_samples")
                    pyDict["resource"] = Helpers.ToPython(resource);
                if (max_resources != "auto")
                    pyDict["max_resources"] = Helpers.ToPython(max_resources);
                if (min_resources != "exhaust")
                    pyDict["min_resources"] = Helpers.ToPython(min_resources);
                if (aggressive_elimination != false)
                    pyDict["aggressive_elimination"] = Helpers.ToPython(aggressive_elimination);
                if (cv != 5)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (scoring != null)
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (refit != true)
                    pyDict["refit"] = Helpers.ToPython(refit);
                if (error_score != null)
                    pyDict["error_score"] = Helpers.ToPython(error_score);
                if (return_train_score != true)
                    pyDict["return_train_score"] = Helpers.ToPython(return_train_score);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.model_selection.self.InvokeMethod("HalvingGridSearchCV", args, pyDict);
            }

            internal HalvingGridSearchCV(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static HalvingGridSearchCV Encapsule(PyObject pyObject) => new HalvingGridSearchCV(pyObject);
            public static HalvingGridSearchCV Wrap(PyObject pyObject) => new HalvingGridSearchCV(pyObject);
            public PyTuple n_resources_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_resources_");
                    return new PyTuple(__pyObject);
                }
            }

            public PyTuple n_candidates_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_candidates_");
                    return new PyTuple(__pyObject);
                }
            }

            public int n_remaining_candidates_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_remaining_candidates_");
                    return __pyObject.As<int>();
                }
            }

            public int max_resources_
            {
                get
                {
                    var __pyObject = self.GetAttr("max_resources_");
                    return __pyObject.As<int>();
                }
            }

            public int min_resources_
            {
                get
                {
                    var __pyObject = self.GetAttr("min_resources_");
                    return __pyObject.As<int>();
                }
            }

            public int n_iterations_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iterations_");
                    return __pyObject.As<int>();
                }
            }

            public int n_possible_iterations_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_possible_iterations_");
                    return __pyObject.As<int>();
                }
            }

            public int n_required_iterations_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_required_iterations_");
                    return __pyObject.As<int>();
                }
            }

            public PyDict cv_results_
            {
                get
                {
                    var __pyObject = self.GetAttr("cv_results_");
                    return new PyDict(__pyObject);
                }
            }

            public PyDict best_estimator_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_estimator_");
                    return new PyDict(__pyObject);
                }
            }

            public float best_score_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_score_");
                    return __pyObject.As<float>();
                }
            }

            public PyDict best_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_params_");
                    return new PyDict(__pyObject);
                }
            }

            public int best_index_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_index_");
                    return __pyObject.As<int>();
                }
            }

            public PyDict scorer_
            {
                get
                {
                    var __pyObject = self.GetAttr("scorer_");
                    return new PyDict(__pyObject);
                }
            }

            public int n_splits_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_splits_");
                    return __pyObject.As<int>();
                }
            }

            public float refit_time_
            {
                get
                {
                    var __pyObject = self.GetAttr("refit_time_");
                    return __pyObject.As<float>();
                }
            }

            public bool multimetric_
            {
                get
                {
                    var __pyObject = self.GetAttr("multimetric_");
                    return __pyObject.As<bool>();
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

            public NDarray decision_function(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public HalvingGridSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

            public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (Xt != null)
                    pyDict["Xt"] = Helpers.ToPython(Xt);
                var __pyObject = self.InvokeMethod("inverse_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public HalvingGridSearchCV set_params(Dictionary<string, PyObject>? @params = null)
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
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class HalvingRandomSearchCV : PythonObject
        {
            public HalvingRandomSearchCV(PyObject estimator, PyDict param_distributions, string n_candidates = "exhaust", int factor = 3, string resource = "n_samples", string max_resources = "auto", string min_resources = "smallest", bool aggressive_elimination = false, int cv = 5, string? scoring = null, bool refit = true, PyObject? error_score = null, bool return_train_score = true, int? random_state = null, int? n_jobs = null, int verbose = 0)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(param_distributions) });
                PyDict pyDict = new PyDict();
                if (n_candidates != "exhaust")
                    pyDict["n_candidates"] = Helpers.ToPython(n_candidates);
                if (factor != 3)
                    pyDict["factor"] = Helpers.ToPython(factor);
                if (resource != "n_samples")
                    pyDict["resource"] = Helpers.ToPython(resource);
                if (max_resources != "auto")
                    pyDict["max_resources"] = Helpers.ToPython(max_resources);
                if (min_resources != "smallest")
                    pyDict["min_resources"] = Helpers.ToPython(min_resources);
                if (aggressive_elimination != false)
                    pyDict["aggressive_elimination"] = Helpers.ToPython(aggressive_elimination);
                if (cv != 5)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (scoring != null)
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (refit != true)
                    pyDict["refit"] = Helpers.ToPython(refit);
                if (error_score != null)
                    pyDict["error_score"] = Helpers.ToPython(error_score);
                if (return_train_score != true)
                    pyDict["return_train_score"] = Helpers.ToPython(return_train_score);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                self = sklearn.model_selection.self.InvokeMethod("HalvingRandomSearchCV", args, pyDict);
            }

            internal HalvingRandomSearchCV(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static HalvingRandomSearchCV Encapsule(PyObject pyObject) => new HalvingRandomSearchCV(pyObject);
            public static HalvingRandomSearchCV Wrap(PyObject pyObject) => new HalvingRandomSearchCV(pyObject);
            public PyTuple n_resources_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_resources_");
                    return new PyTuple(__pyObject);
                }
            }

            public PyTuple n_candidates_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_candidates_");
                    return new PyTuple(__pyObject);
                }
            }

            public int n_remaining_candidates_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_remaining_candidates_");
                    return __pyObject.As<int>();
                }
            }

            public int max_resources_
            {
                get
                {
                    var __pyObject = self.GetAttr("max_resources_");
                    return __pyObject.As<int>();
                }
            }

            public int min_resources_
            {
                get
                {
                    var __pyObject = self.GetAttr("min_resources_");
                    return __pyObject.As<int>();
                }
            }

            public int n_iterations_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_iterations_");
                    return __pyObject.As<int>();
                }
            }

            public int n_possible_iterations_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_possible_iterations_");
                    return __pyObject.As<int>();
                }
            }

            public int n_required_iterations_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_required_iterations_");
                    return __pyObject.As<int>();
                }
            }

            public PyDict cv_results_
            {
                get
                {
                    var __pyObject = self.GetAttr("cv_results_");
                    return new PyDict(__pyObject);
                }
            }

            public PyDict best_estimator_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_estimator_");
                    return new PyDict(__pyObject);
                }
            }

            public float best_score_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_score_");
                    return __pyObject.As<float>();
                }
            }

            public PyDict best_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_params_");
                    return new PyDict(__pyObject);
                }
            }

            public int best_index_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_index_");
                    return __pyObject.As<int>();
                }
            }

            public PyDict scorer_
            {
                get
                {
                    var __pyObject = self.GetAttr("scorer_");
                    return new PyDict(__pyObject);
                }
            }

            public int n_splits_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_splits_");
                    return __pyObject.As<int>();
                }
            }

            public float refit_time_
            {
                get
                {
                    var __pyObject = self.GetAttr("refit_time_");
                    return __pyObject.As<float>();
                }
            }

            public bool multimetric_
            {
                get
                {
                    var __pyObject = self.GetAttr("multimetric_");
                    return __pyObject.As<bool>();
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

            public NDarray decision_function(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public HalvingRandomSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

            public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (Xt != null)
                    pyDict["Xt"] = Helpers.ToPython(Xt);
                var __pyObject = self.InvokeMethod("inverse_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public HalvingRandomSearchCV set_params(Dictionary<string, PyObject>? @params = null)
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
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class ParameterGrid : PythonObject
        {
            public ParameterGrid(PyDict param_grid)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(param_grid) });
                PyDict pyDict = new PyDict();
                self = sklearn.model_selection.self.InvokeMethod("ParameterGrid", args, pyDict);
            }

            internal ParameterGrid(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ParameterGrid Encapsule(PyObject pyObject) => new ParameterGrid(pyObject);
            public static ParameterGrid Wrap(PyObject pyObject) => new ParameterGrid(pyObject);
        }

        public class RandomizedSearchCV : PythonObject
        {
            public RandomizedSearchCV(PyObject estimator, PyDict param_distributions, int n_iter = 10, PyDict? scoring = null, int? n_jobs = null, bool refit = true, int? cv = null, int verbose = 0, string pre_dispatch = "2*n_jobs", int? random_state = null, PyObject? error_score = null, bool return_train_score = false)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(param_distributions) });
                PyDict pyDict = new PyDict();
                if (n_iter != 10)
                    pyDict["n_iter"] = Helpers.ToPython(n_iter);
                if (scoring != null)
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (refit != true)
                    pyDict["refit"] = Helpers.ToPython(refit);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (pre_dispatch != "2*n_jobs")
                    pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (error_score != null)
                    pyDict["error_score"] = Helpers.ToPython(error_score);
                if (return_train_score != false)
                    pyDict["return_train_score"] = Helpers.ToPython(return_train_score);
                self = sklearn.model_selection.self.InvokeMethod("RandomizedSearchCV", args, pyDict);
            }

            internal RandomizedSearchCV(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static RandomizedSearchCV Encapsule(PyObject pyObject) => new RandomizedSearchCV(pyObject);
            public static RandomizedSearchCV Wrap(PyObject pyObject) => new RandomizedSearchCV(pyObject);
            public PyDict cv_results_
            {
                get
                {
                    var __pyObject = self.GetAttr("cv_results_");
                    return new PyDict(__pyObject);
                }
            }

            public PyObject best_estimator_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_estimator_");
                    return __pyObject;
                }
            }

            public float best_score_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_score_");
                    return __pyObject.As<float>();
                }
            }

            public PyDict best_params_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_params_");
                    return new PyDict(__pyObject);
                }
            }

            public int best_index_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_index_");
                    return __pyObject.As<int>();
                }
            }

            public PyDict scorer_
            {
                get
                {
                    var __pyObject = self.GetAttr("scorer_");
                    return new PyDict(__pyObject);
                }
            }

            public int n_splits_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_splits_");
                    return __pyObject.As<int>();
                }
            }

            public float refit_time_
            {
                get
                {
                    var __pyObject = self.GetAttr("refit_time_");
                    return __pyObject.As<float>();
                }
            }

            public bool multimetric_
            {
                get
                {
                    var __pyObject = self.GetAttr("multimetric_");
                    return __pyObject.As<bool>();
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

            public NDarray decision_function(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public RandomizedSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

            public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (X != null)
                    pyDict["X"] = Helpers.ToPython(X);
                if (Xt != null)
                    pyDict["Xt"] = Helpers.ToPython(Xt);
                var __pyObject = self.InvokeMethod("inverse_transform", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(PyObject X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (y != null)
                    pyDict["y"] = Helpers.ToPython(y);
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

            public RandomizedSearchCV set_params(Dictionary<string, PyObject>? @params = null)
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
                var __pyObject = self.InvokeMethod("transform", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class FixedThresholdClassifier : PythonObject
        {
            public FixedThresholdClassifier(PyObject estimator, string threshold = "auto", string? pos_label = null, string response_method = "auto")
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
                PyDict pyDict = new PyDict();
                if (threshold != "auto")
                    pyDict["threshold"] = Helpers.ToPython(threshold);
                if (pos_label != null)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (response_method != "auto")
                    pyDict["response_method"] = Helpers.ToPython(response_method);
                self = sklearn.model_selection.self.InvokeMethod("FixedThresholdClassifier", args, pyDict);
            }

            internal FixedThresholdClassifier(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static FixedThresholdClassifier Encapsule(PyObject pyObject) => new FixedThresholdClassifier(pyObject);
            public static FixedThresholdClassifier Wrap(PyObject pyObject) => new FixedThresholdClassifier(pyObject);
            public PyObject estimator_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimator_");
                    return __pyObject;
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

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public FixedThresholdClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public FixedThresholdClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public FixedThresholdClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class TunedThresholdClassifierCV : PythonObject
        {
            public TunedThresholdClassifierCV(PyObject estimator, string scoring = "balanced_accuracy", string response_method = "auto", int thresholds = 100, float? cv = null, bool refit = true, int? n_jobs = null, int? random_state = null, bool store_cv_results = false)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
                PyDict pyDict = new PyDict();
                if (scoring != "balanced_accuracy")
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (response_method != "auto")
                    pyDict["response_method"] = Helpers.ToPython(response_method);
                if (thresholds != 100)
                    pyDict["thresholds"] = Helpers.ToPython(thresholds);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (refit != true)
                    pyDict["refit"] = Helpers.ToPython(refit);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (store_cv_results != false)
                    pyDict["store_cv_results"] = Helpers.ToPython(store_cv_results);
                self = sklearn.model_selection.self.InvokeMethod("TunedThresholdClassifierCV", args, pyDict);
            }

            internal TunedThresholdClassifierCV(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static TunedThresholdClassifierCV Encapsule(PyObject pyObject) => new TunedThresholdClassifierCV(pyObject);
            public static TunedThresholdClassifierCV Wrap(PyObject pyObject) => new TunedThresholdClassifierCV(pyObject);
            public PyObject estimator_
            {
                get
                {
                    var __pyObject = self.GetAttr("estimator_");
                    return __pyObject;
                }
            }

            public float best_threshold_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_threshold_");
                    return __pyObject.As<float>();
                }
            }

            public float best_score_
            {
                get
                {
                    var __pyObject = self.GetAttr("best_score_");
                    return __pyObject.As<float>();
                }
            }

            public PyDict cv_results_
            {
                get
                {
                    var __pyObject = self.GetAttr("cv_results_");
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

            public NDarray decision_function(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("decision_function", args, pyDict);
                return new NDarray(__pyObject);
            }

            public TunedThresholdClassifierCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("fit", args, pyDict);
                return this;
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

            public NDarray predict(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public TunedThresholdClassifierCV set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public TunedThresholdClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class LearningCurveDisplay : PythonObject
        {
            public LearningCurveDisplay(NDarray train_sizes, NDarray train_scores, NDarray test_scores, string? score_name = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(train_sizes), Helpers.ToPython(train_scores), Helpers.ToPython(test_scores) });
                PyDict pyDict = new PyDict();
                if (score_name != null)
                    pyDict["score_name"] = Helpers.ToPython(score_name);
                self = sklearn.model_selection.self.InvokeMethod("LearningCurveDisplay", args, pyDict);
            }

            internal LearningCurveDisplay(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static LearningCurveDisplay Encapsule(PyObject pyObject) => new LearningCurveDisplay(pyObject);
            public static LearningCurveDisplay Wrap(PyObject pyObject) => new LearningCurveDisplay(pyObject);
            public PyObject ax_
            {
                get
                {
                    var __pyObject = self.GetAttr("ax_");
                    return __pyObject;
                }
            }

            public PyObject figure_
            {
                get
                {
                    var __pyObject = self.GetAttr("figure_");
                    return __pyObject;
                }
            }

            public PyTuple errorbar_
            {
                get
                {
                    var __pyObject = self.GetAttr("errorbar_");
                    return new PyTuple(__pyObject);
                }
            }

            public PyTuple lines_
            {
                get
                {
                    var __pyObject = self.GetAttr("lines_");
                    return new PyTuple(__pyObject);
                }
            }

            public PyTuple fill_between_
            {
                get
                {
                    var __pyObject = self.GetAttr("fill_between_");
                    return new PyTuple(__pyObject);
                }
            }

            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, NDarray? train_sizes = null, int? cv = null, string? scoring = null, bool exploit_incremental_learning = false, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, bool shuffle = false, int? random_state = null, PyObject? error_score = null, PyDict? fit_params = null, PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                if (train_sizes != null)
                    pyDict["train_sizes"] = Helpers.ToPython(train_sizes);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (scoring != null)
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (exploit_incremental_learning != false)
                    pyDict["exploit_incremental_learning"] = Helpers.ToPython(exploit_incremental_learning);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (pre_dispatch != "all")
                    pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (shuffle != false)
                    pyDict["shuffle"] = Helpers.ToPython(shuffle);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (error_score != null)
                    pyDict["error_score"] = Helpers.ToPython(error_score);
                if (fit_params != null)
                    pyDict["fit_params"] = Helpers.ToPython(fit_params);
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (negate_score != false)
                    pyDict["negate_score"] = Helpers.ToPython(negate_score);
                if (score_name != null)
                    pyDict["score_name"] = Helpers.ToPython(score_name);
                if (score_type != "both")
                    pyDict["score_type"] = Helpers.ToPython(score_type);
                if (std_display_style != "fill_between")
                    pyDict["std_display_style"] = Helpers.ToPython(std_display_style);
                if (line_kw != null)
                    pyDict["line_kw"] = Helpers.ToPython(line_kw);
                if (fill_between_kw != null)
                    pyDict["fill_between_kw"] = Helpers.ToPython(fill_between_kw);
                if (errorbar_kw != null)
                    pyDict["errorbar_kw"] = Helpers.ToPython(errorbar_kw);
                var __pyObject = self.InvokeMethod("from_estimator", args, pyDict);
                return __pyObject;
            }

            public PyObject plot(PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (negate_score != false)
                    pyDict["negate_score"] = Helpers.ToPython(negate_score);
                if (score_name != null)
                    pyDict["score_name"] = Helpers.ToPython(score_name);
                if (score_type != "both")
                    pyDict["score_type"] = Helpers.ToPython(score_type);
                if (std_display_style != "fill_between")
                    pyDict["std_display_style"] = Helpers.ToPython(std_display_style);
                if (line_kw != null)
                    pyDict["line_kw"] = Helpers.ToPython(line_kw);
                if (fill_between_kw != null)
                    pyDict["fill_between_kw"] = Helpers.ToPython(fill_between_kw);
                if (errorbar_kw != null)
                    pyDict["errorbar_kw"] = Helpers.ToPython(errorbar_kw);
                var __pyObject = self.InvokeMethod("plot", args, pyDict);
                return __pyObject;
            }
        }

        public class ValidationCurveDisplay : PythonObject
        {
            public ValidationCurveDisplay(string param_name, NDarray param_range, NDarray train_scores, NDarray test_scores, string? score_name = null)
            {
                _ = sklearn.model_selection.self;
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(param_name), Helpers.ToPython(param_range), Helpers.ToPython(train_scores), Helpers.ToPython(test_scores) });
                PyDict pyDict = new PyDict();
                if (score_name != null)
                    pyDict["score_name"] = Helpers.ToPython(score_name);
                self = sklearn.model_selection.self.InvokeMethod("ValidationCurveDisplay", args, pyDict);
            }

            internal ValidationCurveDisplay(PyObject pyObject)
            {
                _ = sklearn.model_selection.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ValidationCurveDisplay Encapsule(PyObject pyObject) => new ValidationCurveDisplay(pyObject);
            public static ValidationCurveDisplay Wrap(PyObject pyObject) => new ValidationCurveDisplay(pyObject);
            public PyObject ax_
            {
                get
                {
                    var __pyObject = self.GetAttr("ax_");
                    return __pyObject;
                }
            }

            public PyObject figure_
            {
                get
                {
                    var __pyObject = self.GetAttr("figure_");
                    return __pyObject;
                }
            }

            public PyTuple errorbar_
            {
                get
                {
                    var __pyObject = self.GetAttr("errorbar_");
                    return new PyTuple(__pyObject);
                }
            }

            public PyTuple lines_
            {
                get
                {
                    var __pyObject = self.GetAttr("lines_");
                    return new PyTuple(__pyObject);
                }
            }

            public PyTuple fill_between_
            {
                get
                {
                    var __pyObject = self.GetAttr("fill_between_");
                    return new PyTuple(__pyObject);
                }
            }

            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, string param_name, NDarray param_range, NDarray? groups = null, int? cv = null, string? scoring = null, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, PyObject? error_score = null, PyDict? fit_params = null, PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y), Helpers.ToPython(param_name), Helpers.ToPython(param_range) });
                PyDict pyDict = new PyDict();
                if (groups != null)
                    pyDict["groups"] = Helpers.ToPython(groups);
                if (cv != null)
                    pyDict["cv"] = Helpers.ToPython(cv);
                if (scoring != null)
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (pre_dispatch != "all")
                    pyDict["pre_dispatch"] = Helpers.ToPython(pre_dispatch);
                if (verbose != 0)
                    pyDict["verbose"] = Helpers.ToPython(verbose);
                if (error_score != null)
                    pyDict["error_score"] = Helpers.ToPython(error_score);
                if (fit_params != null)
                    pyDict["fit_params"] = Helpers.ToPython(fit_params);
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (negate_score != false)
                    pyDict["negate_score"] = Helpers.ToPython(negate_score);
                if (score_name != null)
                    pyDict["score_name"] = Helpers.ToPython(score_name);
                if (score_type != "both")
                    pyDict["score_type"] = Helpers.ToPython(score_type);
                if (std_display_style != "fill_between")
                    pyDict["std_display_style"] = Helpers.ToPython(std_display_style);
                if (line_kw != null)
                    pyDict["line_kw"] = Helpers.ToPython(line_kw);
                if (fill_between_kw != null)
                    pyDict["fill_between_kw"] = Helpers.ToPython(fill_between_kw);
                if (errorbar_kw != null)
                    pyDict["errorbar_kw"] = Helpers.ToPython(errorbar_kw);
                var __pyObject = self.InvokeMethod("from_estimator", args, pyDict);
                return __pyObject;
            }

            public PyObject plot(PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (ax != null)
                    pyDict["ax"] = Helpers.ToPython(ax);
                if (negate_score != false)
                    pyDict["negate_score"] = Helpers.ToPython(negate_score);
                if (score_name != null)
                    pyDict["score_name"] = Helpers.ToPython(score_name);
                if (score_type != "both")
                    pyDict["score_type"] = Helpers.ToPython(score_type);
                if (std_display_style != "fill_between")
                    pyDict["std_display_style"] = Helpers.ToPython(std_display_style);
                if (line_kw != null)
                    pyDict["line_kw"] = Helpers.ToPython(line_kw);
                if (fill_between_kw != null)
                    pyDict["fill_between_kw"] = Helpers.ToPython(fill_between_kw);
                if (errorbar_kw != null)
                    pyDict["errorbar_kw"] = Helpers.ToPython(errorbar_kw);
                var __pyObject = self.InvokeMethod("plot", args, pyDict);
                return __pyObject;
            }
        }
    }
}