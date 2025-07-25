using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class compose
        {
            public static PyObject make_column_selector(string? pattern = null, PyTuple? dtype_include = null, PyTuple? dtype_exclude = null)
            {
                throw new NotImplementedException();
            }

            public static PyObject make_column_transformer(PyObject[] transformers, string remainder = "drop", float sparse_threshold = 0.3f, int? n_jobs = null, bool verbose = false, bool verbose_feature_names_out = true, bool force_int_remainder_cols = true)
            {
                throw new NotImplementedException();
            }

            public class ColumnTransformer
            {
                public ColumnTransformer(PyTuple transformers, string remainder = "drop", float sparse_threshold = 0.3f, int? n_jobs = null, PyDict? transformer_weights = null, bool verbose = false, bool verbose_feature_names_out = true, bool force_int_remainder_cols = true)
                {
                }

                public PyObject transformers_ => Helpers.ToCSharpNDarray(self.GetAttr("transformers_"));
                public PyDict named_transformers_ => Helpers.ToCSharpNDarray(self.GetAttr("named_transformers_"));
                public bool sparse_output_ => Helpers.ToCSharpNDarray(self.GetAttr("sparse_output_"));
                public PyDict output_indices_ => Helpers.ToCSharpNDarray(self.GetAttr("output_indices_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public ColumnTransformer fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public ColumnTransformer set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public ColumnTransformer set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class TransformedTargetRegressor
            {
                public TransformedTargetRegressor(PyObject? regressor = null, PyObject? transformer = null, PyObject? func = null, PyObject? inverse_func = null, bool check_inverse = true)
                {
                }

                public PyObject regressor_ => Helpers.ToCSharpNDarray(self.GetAttr("regressor_"));
                public PyObject transformer_ => Helpers.ToCSharpNDarray(self.GetAttr("transformer_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public TransformedTargetRegressor fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public void get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public TransformedTargetRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public TransformedTargetRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}