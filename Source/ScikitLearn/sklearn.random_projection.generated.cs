using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class random_projection
        {
            public static NDarray johnson_lindenstrauss_min_dim(NDarray n_samples, float eps = 0.1f)
            {
                throw new NotImplementedException();
            }

            public class GaussianRandomProjection
            {
                public GaussianRandomProjection(string n_components = "auto", float eps = 0.1f, bool compute_inverse_components = false, int? random_state = null)
                {
                }

                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray inverse_components_ => Helpers.ToCSharpNDarray(self.GetAttr("inverse_components_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public GaussianRandomProjection fit(NDarray X)
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

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public GaussianRandomProjection set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public GaussianRandomProjection set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SparseRandomProjection
            {
                public SparseRandomProjection(string n_components = "auto", string density = "auto", float eps = 0.1f, bool dense_output = false, bool compute_inverse_components = false, int? random_state = null)
                {
                }

                public int n_components_ => Helpers.ToCSharpNDarray(self.GetAttr("n_components_"));
                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray inverse_components_ => Helpers.ToCSharpNDarray(self.GetAttr("inverse_components_"));
                public float density_ => Helpers.ToCSharpNDarray(self.GetAttr("density_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SparseRandomProjection fit(NDarray X)
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

                public NDarray inverse_transform(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SparseRandomProjection set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SparseRandomProjection set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}