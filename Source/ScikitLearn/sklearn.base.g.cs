namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class @base
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
            return Py.Import("sklearn.base");
        }

        static @base() => ReInitializeLazySelf();
        public static PyObject clone(PyTuple estimator, bool safe = true)
        {
            _ = sklearn.@base.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
            PyDict pyDict = new PyDict();
            if (safe != true)
                pyDict["safe"] = Helpers.ToPython(safe);
            var __pyObject = self.InvokeMethod("clone", args, pyDict);
            return __pyObject;
        }

        public static bool is_classifier(PyObject estimator)
        {
            _ = sklearn.@base.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
            PyDict pyDict = new PyDict();
            var __pyObject = self.InvokeMethod("is_classifier", args, pyDict);
            return __pyObject.As<bool>();
        }

        public static bool is_regressor(PyObject estimator)
        {
            _ = sklearn.@base.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
            PyDict pyDict = new PyDict();
            var __pyObject = self.InvokeMethod("is_regressor", args, pyDict);
            return __pyObject.As<bool>();
        }

        public class BaseEstimator : PythonObject
        {
            public BaseEstimator()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("BaseEstimator", args, pyDict);
            }

            internal BaseEstimator(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static BaseEstimator Encapsule(PyObject pyObject) => new BaseEstimator(pyObject);
            public static BaseEstimator Wrap(PyObject pyObject) => new BaseEstimator(pyObject);
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return ScikitLearn.sklearn.utils.metadata_routing.MetadataRequest.Wrap(__pyObject);
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

            public BaseEstimator set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }
        }

        public class BiclusterMixin : PythonObject
        {
            public BiclusterMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("BiclusterMixin", args, pyDict);
            }

            internal BiclusterMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static BiclusterMixin Encapsule(PyObject pyObject) => new BiclusterMixin(pyObject);
            public static BiclusterMixin Wrap(PyObject pyObject) => new BiclusterMixin(pyObject);
            public (NDarray<long>? , NDarray<long>? ) get_indices(int i)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_indices", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? new NDarray<long>(__pyObjectTuple[0]) : null, __pyObjectLength > 1 ? new NDarray<long>(__pyObjectTuple[1]) : null);
            }

            public (int? , int? ) get_shape(int i)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_shape", args, pyDict);
                var __pyObjectTuple = new PyTuple(__pyObject);
                var __pyObjectLength = __pyObjectTuple.Length();
                return (__pyObjectLength > 0 ? __pyObjectTuple[0].As<int>() : null, __pyObjectLength > 1 ? __pyObjectTuple[1].As<int>() : null);
            }

            public NDarray get_submatrix(int i, NDarray data)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i), Helpers.ToPython(data) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_submatrix", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class ClassNamePrefixFeaturesOutMixin : PythonObject
        {
            public ClassNamePrefixFeaturesOutMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("ClassNamePrefixFeaturesOutMixin", args, pyDict);
            }

            internal ClassNamePrefixFeaturesOutMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ClassNamePrefixFeaturesOutMixin Encapsule(PyObject pyObject) => new ClassNamePrefixFeaturesOutMixin(pyObject);
            public static ClassNamePrefixFeaturesOutMixin Wrap(PyObject pyObject) => new ClassNamePrefixFeaturesOutMixin(pyObject);
            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                var __pyObject = self.InvokeMethod("get_feature_names_out", args, pyDict);
                return __pyObject;
            }
        }

        public class ClassifierMixin : PythonObject
        {
            public ClassifierMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("ClassifierMixin", args, pyDict);
            }

            internal ClassifierMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ClassifierMixin Encapsule(PyObject pyObject) => new ClassifierMixin(pyObject);
            public static ClassifierMixin Wrap(PyObject pyObject) => new ClassifierMixin(pyObject);
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }
        }

        public class ClusterMixin : PythonObject
        {
            public ClusterMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("ClusterMixin", args, pyDict);
            }

            internal ClusterMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ClusterMixin Encapsule(PyObject pyObject) => new ClusterMixin(pyObject);
            public static ClusterMixin Wrap(PyObject pyObject) => new ClusterMixin(pyObject);
            public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("fit_predict", args, pyDict);
                return new NDarray<long>(__pyObject);
            }
        }

        public class DensityMixin : PythonObject
        {
            public DensityMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("DensityMixin", args, pyDict);
            }

            internal DensityMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static DensityMixin Encapsule(PyObject pyObject) => new DensityMixin(pyObject);
            public static DensityMixin Wrap(PyObject pyObject) => new DensityMixin(pyObject);
            public float score(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }
        }

        public class MetaEstimatorMixin : PythonObject
        {
            public MetaEstimatorMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("MetaEstimatorMixin", args, pyDict);
            }

            internal MetaEstimatorMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static MetaEstimatorMixin Encapsule(PyObject pyObject) => new MetaEstimatorMixin(pyObject);
            public static MetaEstimatorMixin Wrap(PyObject pyObject) => new MetaEstimatorMixin(pyObject);
        }

        public class OneToOneFeatureMixin : PythonObject
        {
            public OneToOneFeatureMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("OneToOneFeatureMixin", args, pyDict);
            }

            internal OneToOneFeatureMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static OneToOneFeatureMixin Encapsule(PyObject pyObject) => new OneToOneFeatureMixin(pyObject);
            public static OneToOneFeatureMixin Wrap(PyObject pyObject) => new OneToOneFeatureMixin(pyObject);
            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                var __pyObject = self.InvokeMethod("get_feature_names_out", args, pyDict);
                return __pyObject;
            }
        }

        public class OutlierMixin : PythonObject
        {
            public OutlierMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("OutlierMixin", args, pyDict);
            }

            internal OutlierMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static OutlierMixin Encapsule(PyObject pyObject) => new OutlierMixin(pyObject);
            public static OutlierMixin Wrap(PyObject pyObject) => new OutlierMixin(pyObject);
            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                var __pyObject = self.InvokeMethod("fit_predict", args, pyDict);
                return new NDarray(__pyObject);
            }
        }

        public class RegressorMixin : PythonObject
        {
            public RegressorMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("RegressorMixin", args, pyDict);
            }

            internal RegressorMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static RegressorMixin Encapsule(PyObject pyObject) => new RegressorMixin(pyObject);
            public static RegressorMixin Wrap(PyObject pyObject) => new RegressorMixin(pyObject);
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }
        }

        public class TransformerMixin : PythonObject
        {
            public TransformerMixin()
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self = sklearn.@base.self.InvokeMethod("TransformerMixin", args, pyDict);
            }

            internal TransformerMixin(PyObject pyObject)
            {
                _ = sklearn.@base.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static TransformerMixin Encapsule(PyObject pyObject) => new TransformerMixin(pyObject);
            public static TransformerMixin Wrap(PyObject pyObject) => new TransformerMixin(pyObject);
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

            public TransformerMixin set_output(PyObject? transform = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (transform != null)
                    pyDict["transform"] = Helpers.ToPython(transform);
                self.InvokeMethod("set_output", args, pyDict);
                return this;
            }
        }
    }
}