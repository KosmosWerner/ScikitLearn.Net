using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class @base
    {
        // Methods
        public static PyObject clone(PyTuple estimator, bool safe = true) => default!;
        public static bool is_classifier(PyObject estimator) => default!;
        public static bool is_regressor(PyObject estimator) => default!;
        // Classes
        public class BaseEstimator : PythonObject
        {
            // Constructor
            public BaseEstimator() { }

            // Methods
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public BaseEstimator set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class BiclusterMixin : PythonObject
        {
            // Constructor
            public BiclusterMixin() { }

            // Methods
            public (NDarray<long>?, NDarray<long>?) get_indices(int i) => default!;
            public (int?, int?) get_shape(int i) => default!;
            public NDarray get_submatrix(int i, NDarray data) => default!;
        }

        public class ClassNamePrefixFeaturesOutMixin : PythonObject
        {
            // Constructor
            public ClassNamePrefixFeaturesOutMixin() { }

            // Methods
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
        }

        public class ClassifierMixin : PythonObject
        {
            // Constructor
            public ClassifierMixin() { }

            // Methods
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
        }

        public class ClusterMixin : PythonObject
        {
            // Constructor
            public ClusterMixin() { }

            // Methods
            public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class DensityMixin : PythonObject
        {
            // Constructor
            public DensityMixin() { }

            // Methods
            public float score(NDarray X) => default!;
        }

        public class MetaEstimatorMixin : PythonObject
        {
            // Constructor
            public MetaEstimatorMixin() { }
        }

        public class OneToOneFeatureMixin : PythonObject
        {
            // Constructor
            public OneToOneFeatureMixin() { }

            // Methods
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
        }

        public class OutlierMixin : PythonObject
        {
            // Constructor
            public OutlierMixin() { }

            // Methods
            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class RegressorMixin : PythonObject
        {
            // Constructor
            public RegressorMixin() { }

            // Methods
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
        }

        public class TransformerMixin : PythonObject
        {
            // Constructor
            public TransformerMixin() { }

            // Methods
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public TransformerMixin set_output(PyObject? transform = null) => default!;
        }
    }
}