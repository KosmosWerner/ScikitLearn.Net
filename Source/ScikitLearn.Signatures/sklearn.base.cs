using System;
using System.Collections.Generic;
using System.Net;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public interface IPythonWrapper
{
    PyObject self => default!;
}

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

        public interface _MetadataRequester : IPythonWrapper
        {
            sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing();
        }

        public interface BaseEstimator : _MetadataRequester { }
        public interface BaseEstimator<Self> : BaseEstimator
        {
            Dictionary<string, PyObject> get_params(bool deep = true);
            [Self] Self set_params(params (string key, object value)[] @params);
        }

        public interface BiclusterMixin : IPythonWrapper
        {
            (NDarray row_ind, NDarray col_ind) get_indices(int i);
            (int n_rows, int n_cols) get_shape(int i);
            NDarray get_submatrix(int i, NDarray data);
        }

        public interface ClassNamePrefixFeaturesOutMixin : IPythonWrapper
        {
            NDarray<string> get_feature_names_out(NDarray<string>? input_features = null);
        }

        public interface ClassifierMixin : IPythonWrapper
        {
            float score(NDarray X, NDarray y, NDarray? sample_weight = null);
        }

        public interface ClusterMixin : IPythonWrapper
        {
            NDarray<long> fit_predict(NDarray X, NDarray? y = null, params (string key, object value)[] @params);
        }

        public interface DensityMixin : IPythonWrapper
        {
            float score(NDarray X, NDarray? y = null);
        }

        public interface MetaEstimatorMixin : IPythonWrapper
        { }

        public interface OneToOneFeatureMixin : IPythonWrapper
        {
            NDarray get_feature_names_out(NDarray? input_features = null);
        }

        public interface OutlierMixin : IPythonWrapper
        {
            NDarray fit_predict(NDarray X, NDarray? y = null, params (string key, object value)[] @params);
        }

        public interface RegressorMixin : IPythonWrapper
        {
            float score(NDarray X, NDarray y, NDarray? sample_weight = null);
        }

        public interface _SetOutputMixin<Self> : IPythonWrapper
        {
            [Self] Self set_output(string? transform = null);

        }

        public interface TransformerMixin : IPythonWrapper { }
        public interface TransformerMixin<Self> :
            TransformerMixin,
            _SetOutputMixin<Self>
        {
            NDarray fit_transform(NDarray X, NDarray? y = null, params (string key, object value)[] @params);
        }

        // Derived

       




        public interface BaseKMeans<Self> :
            BaseEstimator<Self>,
            ClassNamePrefixFeaturesOutMixin,
            TransformerMixin<Self>,
            ClusterMixin
        {
            NDarray predict(NDarray X);
            NDarray transform(NDarray X);
            NDarray fit_predict(NDarray X, NDarray? y = null, NDarray? sample_weight = null);
            float score(NDarray X, NDarray? sample_weight = null);
        }

        public interface AgglomerationTransform<Self> :
            TransformerMixin<Self>
        { }

        public interface AgglomerativeClustering<Self> :
            ClusterMixin,
            BaseEstimator<Self>
        { }

        public interface _BaseComposition<self> :
            BaseEstimator<self>
        { }

       

        

        

      

        public interface KNeighborsMixin : IPythonWrapper
        {
            (NDarray?, NDarray?) kneighbors(NDarray? X = null, int? n_neighbors = null, bool return_distance = true);
            NDarray kneighbors_graph(NDarray? X = null, int? n_neighbors = null, string mode = "connectivity");
        }

        public interface NeighborsBase<Self> :
            MultiOutputMixin,
            BaseEstimator<Self>
        { }

        public interface LinearClassifierMixin :
            ClassifierMixin
        {
            NDarray decision_function(NDarray X);
            NDarray predict(NDarray X);
        }

        public interface SparseCoefMixin<Self> : IPythonWrapper
        {
            [Self] Self densify();
            [Self] Self sparsify();
        }

        public interface LinearModel<Self> :
            BaseEstimator<Self>
        {
            Self fit(NDarray X, NDarray y, NDarray? sample_weight = null);
            NDarray predict(NDarray X);
        }

        public interface BaseLibSVM<Self> :
            BaseEstimator<Self>
        {
            NDarray coef_ { get; }
            NDarray n_support_ { get; }

            [Self] Self fit(NDarray X, NDarray y, NDarray? sample_weight = null);
            NDarray predict(NDarray X);
        }

        public interface BaseSVC<Self> :
            ClassifierMixin,
            BaseLibSVM<Self>
        {
            NDarray probA_ { get; }
            NDarray probB_ { get; }

            NDarray decision_function(NDarray X);
            NDarray predict_proba(NDarray X);
            NDarray predict_log_proba(NDarray X);
        }



        // neural_network








        #region model_selection
        public interface BaseCrossValidator :
            _MetadataRequester
        {
            (NDarray train, NDarray test) split(NDarray X, NDarray? y = null, NDarray? groups = null);
            int get_n_splits([Ignored] NDarray? X = null, [Ignored] NDarray? y = null, [Ignored] NDarray? groups = null);
        }
        public interface GroupsConsumerMixin :
            _MetadataRequester
        { }

        public interface _BaseKFold :
            BaseCrossValidator
        { }

        public interface BaseShuffleSplit
            : _MetadataRequester
        {
            (NDarray train, NDarray test) split(NDarray X, NDarray? y = null, NDarray? groups = null);
            int get_n_splits([Ignored] NDarray? X = null, [Ignored] NDarray? y = null, [Ignored] NDarray? groups = null);
        }

        public interface _UnsupportedGroupCVMixin : IPythonWrapper
        {
            (NDarray train, NDarray test) split(NDarray X, NDarray? y = null, [Ignored] NDarray? groups = null);
        }
        public interface _RepeatedSplits :
            _MetadataRequester
        {
            (NDarray train, NDarray test) split(NDarray X, NDarray? y = null, NDarray? groups = null);
            int get_n_splits([Ignored] NDarray? X = null, [Ignored] NDarray? y = null, NDarray? groups = null);
        }
        #endregion


        #region cross_decomposition
        public interface _PLS<Self> :
            ClassNamePrefixFeaturesOutMixin,
            TransformerMixin<Self>,
            RegressorMixin,
            MultiOutputMixin,
            BaseEstimator<Self>
        {
            Self fit(NDarray X, NDarray? y = null);
            NDarray transform(NDarray X, NDarray? y = null, bool copy = true);
        }
        #endregion
    }
}