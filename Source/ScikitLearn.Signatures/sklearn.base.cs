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
        public class BaseEstimator
        {
            // Constructor
            public BaseEstimator() { }

            // Methods
            public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public BaseEstimator set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class BiclusterMixin
        {
            // Constructor
            public BiclusterMixin() { }

            // Methods
            public (NDarray<long>?, NDarray<long>?) get_indices(int i) => default!;
            public (int?, int?) get_shape(int i) => default!;
            public NDarray get_submatrix(int i, NDarray data) => default!;
        }

        public class ClassNamePrefixFeaturesOutMixin
        {
            // Constructor
            public ClassNamePrefixFeaturesOutMixin() { }

            // Methods
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
        }

        public class ClassifierMixin
        {
            // Constructor
            public ClassifierMixin() { }

            // Methods
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
        }

        public class ClusterMixin
        {
            // Constructor
            public ClusterMixin() { }

            // Methods
            public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class DensityMixin
        {
            // Constructor
            public DensityMixin() { }

            // Methods
            public float score(NDarray X) => default!;
        }

        public class MetaEstimatorMixin
        {
            // Constructor
            public MetaEstimatorMixin() { }
        }

        public class OneToOneFeatureMixin
        {
            // Constructor
            public OneToOneFeatureMixin() { }

            // Methods
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
        }

        public class OutlierMixin
        {
            // Constructor
            public OutlierMixin() { }

            // Methods
            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class RegressorMixin
        {
            // Constructor
            public RegressorMixin() { }

            // Methods
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
        }

        public class TransformerMixin
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