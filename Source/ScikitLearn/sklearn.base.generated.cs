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
            public static PyObject clone(PyTuple estimator, bool safe = true)
            {
                throw new NotImplementedException();
            }

            public static bool is_classifier(PyObject estimator)
            {
                throw new NotImplementedException();
            }

            public static bool is_regressor(PyObject estimator)
            {
                throw new NotImplementedException();
            }

            public class BaseEstimator
            {
                public BaseEstimator()
                {
                }

                public sklearn.utils.metadata_routing.MetadataRequest get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public BaseEstimator set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class BiclusterMixin
            {
                public BiclusterMixin()
                {
                }

                public (NDarray<long>? , NDarray<long>? ) get_indices(int i)
                {
                    throw new NotImplementedException();
                }

                public (int? , int? ) get_shape(int i)
                {
                    throw new NotImplementedException();
                }

                public NDarray get_submatrix(int i, NDarray data)
                {
                    throw new NotImplementedException();
                }
            }

            public class ClassNamePrefixFeaturesOutMixin
            {
                public ClassNamePrefixFeaturesOutMixin()
                {
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class ClassifierMixin
            {
                public ClassifierMixin()
                {
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class ClusterMixin
            {
                public ClusterMixin()
                {
                }

                public NDarray<long> fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class DensityMixin
            {
                public DensityMixin()
                {
                }

                public float score(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class MetaEstimatorMixin
            {
                public MetaEstimatorMixin()
                {
                }
            }

            public class OneToOneFeatureMixin
            {
                public OneToOneFeatureMixin()
                {
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class OutlierMixin
            {
                public OutlierMixin()
                {
                }

                public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class RegressorMixin
            {
                public RegressorMixin()
                {
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class TransformerMixin
            {
                public TransformerMixin()
                {
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public TransformerMixin set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}