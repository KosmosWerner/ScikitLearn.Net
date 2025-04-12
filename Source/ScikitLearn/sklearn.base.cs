using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
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

            public class BaseEstimator : PythonObject
            {
                public BaseEstimator()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("BaseEstimator", args, pyDict);
                }

                internal BaseEstimator(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static BaseEstimator Encapsule(PyObject pyObject)
                {
                    return new BaseEstimator(pyObject);
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
                        pyDict["deep"] = Helpers.ToPython(deep);
                    return new PyDict(self.InvokeMethod("get_params", args, pyDict));
                }

                public BaseEstimator set_params(Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
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
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("BiclusterMixin", args, pyDict);
                }

                internal BiclusterMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static BiclusterMixin Encapsule(PyObject pyObject)
                {
                    return new BiclusterMixin(pyObject);
                }

                public (NDarray<long>? , NDarray<long>? ) get_indices(int i)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(i)]);
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("get_indices", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpNDarray<long>(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray<long>(result[1]) : null);
                }

                public (int? , int? ) get_shape(int i)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(i)]);
                    PyDict pyDict = new PyDict();
                    PyTuple result = new PyTuple(self.InvokeMethod("get_shape", args, pyDict));
                    var __length = result.Length();
                    return (__length > 0 ? Helpers.ToCSharpInt(result[0]) : null, __length > 1 ? Helpers.ToCSharpInt(result[1]) : null);
                }

                public NDarray get_submatrix(int i, NDarray data)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(i), Helpers.ToPython(data)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("get_submatrix", args, pyDict));
                }
            }

            public class ClassNamePrefixFeaturesOutMixin : PythonObject
            {
                public ClassNamePrefixFeaturesOutMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("ClassNamePrefixFeaturesOutMixin", args, pyDict);
                }

                internal ClassNamePrefixFeaturesOutMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static ClassNamePrefixFeaturesOutMixin Encapsule(PyObject pyObject)
                {
                    return new ClassNamePrefixFeaturesOutMixin(pyObject);
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }
            }

            public class ClassifierMixin : PythonObject
            {
                public ClassifierMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("ClassifierMixin", args, pyDict);
                }

                internal ClassifierMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static ClassifierMixin Encapsule(PyObject pyObject)
                {
                    return new ClassifierMixin(pyObject);
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }
            }

            public class ClusterMixin : PythonObject
            {
                public ClusterMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("ClusterMixin", args, pyDict);
                }

                internal ClusterMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static ClusterMixin Encapsule(PyObject pyObject)
                {
                    return new ClusterMixin(pyObject);
                }

                public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray<long>(self.InvokeMethod("fit_predict", args, pyDict));
                }
            }

            public class DensityMixin : PythonObject
            {
                public DensityMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("DensityMixin", args, pyDict);
                }

                internal DensityMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static DensityMixin Encapsule(PyObject pyObject)
                {
                    return new DensityMixin(pyObject);
                }

                public float score(NDarray X)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }
            }

            public class MetaEstimatorMixin : PythonObject
            {
                public MetaEstimatorMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("MetaEstimatorMixin", args, pyDict);
                }

                internal MetaEstimatorMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static MetaEstimatorMixin Encapsule(PyObject pyObject)
                {
                    return new MetaEstimatorMixin(pyObject);
                }
            }

            public class OneToOneFeatureMixin : PythonObject
            {
                public OneToOneFeatureMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("OneToOneFeatureMixin", args, pyDict);
                }

                internal OneToOneFeatureMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static OneToOneFeatureMixin Encapsule(PyObject pyObject)
                {
                    return new OneToOneFeatureMixin(pyObject);
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (input_features != null)
                        pyDict["input_features"] = Helpers.ToPython(input_features);
                    return self.InvokeMethod("get_feature_names_out", args, pyDict);
                }
            }

            public class OutlierMixin : PythonObject
            {
                public OutlierMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("OutlierMixin", args, pyDict);
                }

                internal OutlierMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static OutlierMixin Encapsule(PyObject pyObject)
                {
                    return new OutlierMixin(pyObject);
                }

                public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_predict", args, pyDict));
                }
            }

            public class RegressorMixin : PythonObject
            {
                public RegressorMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("RegressorMixin", args, pyDict);
                }

                internal RegressorMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static RegressorMixin Encapsule(PyObject pyObject)
                {
                    return new RegressorMixin(pyObject);
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    return Helpers.ToCSharpFloat(self.InvokeMethod("score", args, pyDict));
                }
            }

            public class TransformerMixin : PythonObject
            {
                public TransformerMixin()
                {
                    _ = sklearn.@base.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.@base.self.InvokeMethod("TransformerMixin", args, pyDict);
                }

                internal TransformerMixin(PyObject pyObject)
                {
                    _ = sklearn.@base.self;
                    self = pyObject;
                }

                public static TransformerMixin Encapsule(PyObject pyObject)
                {
                    return new TransformerMixin(pyObject);
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (y != null)
                        pyDict["y"] = Helpers.ToPython(y);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(self.InvokeMethod("fit_transform", args, pyDict));
                }

                public TransformerMixin set_output(PyObject? transform = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (transform != null)
                        pyDict["transform"] = Helpers.ToPython(transform);
                    self.InvokeMethod("set_output", args, pyDict);
                    return this;
                }
            }

            public static PyObject clone(PyTuple estimator, bool safe = true)
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple([Helpers.ToPython(estimator)]);
                PyDict pyDict = new PyDict();
                if (safe != true)
                    pyDict["safe"] = Helpers.ToPython(safe);
                return sklearn.@base.self.InvokeMethod("clone", args, pyDict);
            }

            public static bool is_classifier(PyObject estimator)
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple([Helpers.ToPython(estimator)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpBool(sklearn.@base.self.InvokeMethod("is_classifier", args, pyDict));
            }

            public static bool is_regressor(PyObject estimator)
            {
                _ = sklearn.@base.self;
                PyTuple args = new PyTuple([Helpers.ToPython(estimator)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpBool(sklearn.@base.self.InvokeMethod("is_regressor", args, pyDict));
            }
        }
    }
}