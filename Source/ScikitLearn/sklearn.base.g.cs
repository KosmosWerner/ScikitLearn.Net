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

        static @base()
        {
            ReInitializeLazySelf();
        }

        public static PyObject clone(PyTuple estimator, bool safe = true)
        {
            _ = sklearn.@base.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
            PyDict pyDict = new PyDict();
            if (safe != true)
                pyDict["safe"] = Helpers.ToPython(safe);
            return new NotImplementedException();
        }

        public static bool is_classifier(PyObject estimator)
        {
            _ = sklearn.@base.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
            PyDict pyDict = new PyDict();
            self.InvokeMethod("is_classifier", args, pyDict);
        }

        public static bool is_regressor(PyObject estimator)
        {
            _ = sklearn.@base.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(estimator) });
            PyDict pyDict = new PyDict();
            self.InvokeMethod("is_regressor", args, pyDict);
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static BaseEstimator Encapsule(PyObject pyObject) => new BaseEstimator(pyObject);
            public static BaseEstimator Wrap(PyObject pyObject) => new BaseEstimator(pyObject);
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing()
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static BiclusterMixin Encapsule(PyObject pyObject) => new BiclusterMixin(pyObject);
            public static BiclusterMixin Wrap(PyObject pyObject) => new BiclusterMixin(pyObject);
            public (NDarray<long>? , NDarray<long>? ) get_indices(int i)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public (int? , int? ) get_shape(int i)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
            }

            public NDarray get_submatrix(int i, NDarray data)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(i), Helpers.ToPython(data) });
                PyDict pyDict = new PyDict();
                return new NotImplementedException();
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static ClassNamePrefixFeaturesOutMixin Encapsule(PyObject pyObject) => new ClassNamePrefixFeaturesOutMixin(pyObject);
            public static ClassNamePrefixFeaturesOutMixin Wrap(PyObject pyObject) => new ClassNamePrefixFeaturesOutMixin(pyObject);
            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                return new NotImplementedException();
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static ClassifierMixin Encapsule(PyObject pyObject) => new ClassifierMixin(pyObject);
            public static ClassifierMixin Wrap(PyObject pyObject) => new ClassifierMixin(pyObject);
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static ClusterMixin Encapsule(PyObject pyObject) => new ClusterMixin(pyObject);
            public static ClusterMixin Wrap(PyObject pyObject) => new ClusterMixin(pyObject);
            public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return new NotImplementedException();
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static DensityMixin Encapsule(PyObject pyObject) => new DensityMixin(pyObject);
            public static DensityMixin Wrap(PyObject pyObject) => new DensityMixin(pyObject);
            public float score(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                return self.InvokeMethod("score", args, pyDict).As<float>()}
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static OneToOneFeatureMixin Encapsule(PyObject pyObject) => new OneToOneFeatureMixin(pyObject);
            public static OneToOneFeatureMixin Wrap(PyObject pyObject) => new OneToOneFeatureMixin(pyObject);
            public PyObject get_feature_names_out(NDarray? input_features = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (input_features != null)
                    pyDict["input_features"] = Helpers.ToPython(input_features);
                return new NotImplementedException();
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static OutlierMixin Encapsule(PyObject pyObject) => new OutlierMixin(pyObject);
            public static OutlierMixin Wrap(PyObject pyObject) => new OutlierMixin(pyObject);
            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return new NotImplementedException();
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
            public static RegressorMixin Encapsule(PyObject pyObject) => new RegressorMixin(pyObject);
            public static RegressorMixin Wrap(PyObject pyObject) => new RegressorMixin(pyObject);
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return self.InvokeMethod("score", args, pyDict).As<float>()}
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

            [Obsolete("Encapsule is deprecated. Please use Wrap for future implementations.")]
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
                return new NotImplementedException();
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