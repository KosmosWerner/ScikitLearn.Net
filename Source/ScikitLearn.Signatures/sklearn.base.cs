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

        public static PyObject clone(
            PyTuple estimator,
            bool safe = true) => default!;
        public static bool is_classifier(PyObject estimator) => default!;
        public static bool is_regressor(PyObject estimator) => default!;

        // Interfaces
        public interface BaseEstimator
        { }

        public interface BaseEstimator<Self> : BaseEstimator
        {
            sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing();
            IReadOnlyDictionary<string, PyObject> get_params(bool deep = true);
            [ReturnThis] Self set_params(Dictionary<string, PyObject>? @params = null);
        }

        public interface BiclusterMixin
        {
            (NDarray row_ind, NDarray col_ind) get_indices(int i);
            (int n_rows, int n_cols) get_shape(int i);
            NDarray get_submatrix(int i, NDarray data);
        }

        public interface ClassNamePrefixFeaturesOutMixin
        {
            NDarray get_feature_names_out(NDarray<string>? input_features = null);
        }

        public interface ClassifierMixin
        {
            float score(NDarray X, NDarray y, NDarray? sample_weight = null);
        }

        public interface ClusterMixin
        { }

        public interface ClusterMixin<Self> : ClusterMixin
        {
            [ReturnThis] Self fit(NDarray X);
            NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null);
        }

        public interface ClusterMixinWeight<Self> : ClusterMixin
        {
            [ReturnThis] Self fit(NDarray X, NDarray? sample_weight = null);
            NDarray<long> fit_predict(NDarray X, NDarray? sample_weight = null);
        }

        public interface DensityMixin
        {
            float score(NDarray X, NDarray? y = null);
        }

        public interface MetaEstimatorMixin
        { }

        public interface OneToOneFeatureMixin
        {
            NDarray get_feature_names_out(NDarray? input_features = null);
        }

        public interface OutlierMixin
        {
            NDarray fit_predict(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null);
        }

        public interface RegressorMixin
        {
            float score(NDarray X, NDarray y, NDarray? sample_weight = null);
        }

        public interface TransformerMixin
        { }

        public interface TransformerMixin<Self> : TransformerMixin
        {
            NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null);
            [ReturnThis] Self set_output(string? transform = null);
        }

        public interface BaseKMeans<Self> :
            BaseEstimator<Self>,
            ClassNamePrefixFeaturesOutMixin,
            TransformerMixin<Self>,
            ClusterMixin<Self>
        { }

        public interface AgglomerationTransform<Self> :
            TransformerMixin<Self>
        { }

        public interface AgglomerativeClustering<Self> :
            ClusterMixin<Self>,
            BaseEstimator<Self>
        { }

        public interface IBaseComposition<self> :
            BaseEstimator<self>
        { }

        public interface BaseMixture<Self> :
            DensityMixin,
            BaseEstimator<Self>
        {
        }
    }
}