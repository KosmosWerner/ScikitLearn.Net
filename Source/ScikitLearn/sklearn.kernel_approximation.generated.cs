using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class kernel_approximation
        {
            public class AdditiveChi2Sampler
            {
                public AdditiveChi2Sampler(int sample_steps = 2, float? sample_interval = null)
                {
                }

                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public AdditiveChi2Sampler fit(NDarray X, NDarray? y = null)
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

                public AdditiveChi2Sampler set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public AdditiveChi2Sampler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class Nystroem
            {
                public Nystroem(string kernel = "rbf", float? gamma = null, float? coef0 = null, float? degree = null, PyDict? kernel_params = null, int n_components = 100, int? random_state = null, int? n_jobs = null)
                {
                }

                public NDarray components_ => Helpers.ToCSharpNDarray(self.GetAttr("components_"));
                public NDarray component_indices_ => Helpers.ToCSharpNDarray(self.GetAttr("component_indices_"));
                public NDarray normalization_ => Helpers.ToCSharpNDarray(self.GetAttr("normalization_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public Nystroem fit(NDarray X, NDarray? y = null)
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

                public Nystroem set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public Nystroem set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class PolynomialCountSketch
            {
                public PolynomialCountSketch(float gamma = 1.0f, int degree = 2, int coef0 = 0, int n_components = 100, int? random_state = null)
                {
                }

                public NDarray indexHash_ => Helpers.ToCSharpNDarray(self.GetAttr("indexHash_"));
                public NDarray bitHash_ => Helpers.ToCSharpNDarray(self.GetAttr("bitHash_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public PolynomialCountSketch fit(NDarray X, NDarray? y = null)
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

                public PolynomialCountSketch set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public PolynomialCountSketch set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class RBFSampler
            {
                public RBFSampler(float gamma = 1.0f, int n_components = 100, int? random_state = null)
                {
                }

                public NDarray random_offset_ => Helpers.ToCSharpNDarray(self.GetAttr("random_offset_"));
                public NDarray random_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("random_weights_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public RBFSampler fit(NDarray X, NDarray? y = null)
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

                public RBFSampler set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public RBFSampler set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class SkewedChi2Sampler
            {
                public SkewedChi2Sampler(float skewedness = 1.0f, int n_components = 100, int? random_state = null)
                {
                }

                public NDarray random_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("random_weights_"));
                public NDarray random_offset_ => Helpers.ToCSharpNDarray(self.GetAttr("random_offset_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public SkewedChi2Sampler fit(NDarray X, NDarray? y = null)
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

                public SkewedChi2Sampler set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public SkewedChi2Sampler set_params(Dictionary<string, PyObject>? @params = null)
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