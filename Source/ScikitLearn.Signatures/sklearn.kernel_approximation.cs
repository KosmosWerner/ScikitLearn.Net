using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class kernel_approximation
    {
        // Classes
        public class AdditiveChi2Sampler
        {
            // Constructor
            public AdditiveChi2Sampler(int sample_steps = 2, float? sample_interval = null)
            {
            }

            // Properties
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public AdditiveChi2Sampler fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public AdditiveChi2Sampler set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public AdditiveChi2Sampler set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class Nystroem
        {
            // Constructor
            public Nystroem(string kernel = "rbf", float? gamma = null, float? coef0 = null, float? degree = null, PyDict? kernel_params = null, int n_components = 100, int? random_state = null, int? n_jobs = null)
            {
            }

            // Properties
            public NDarray components_ => default!;
            public NDarray component_indices_ => default!;
            public NDarray normalization_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public Nystroem fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public Nystroem set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public Nystroem set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class PolynomialCountSketch
        {
            // Constructor
            public PolynomialCountSketch(float gamma = 1.0f, int degree = 2, int coef0 = 0, int n_components = 100, int? random_state = null)
            {
            }

            // Properties
            public NDarray indexHash_ => default!;
            public NDarray bitHash_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public PolynomialCountSketch fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public PolynomialCountSketch set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public PolynomialCountSketch set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class RBFSampler
        {
            // Constructor
            public RBFSampler(float gamma = 1.0f, int n_components = 100, int? random_state = null)
            {
            }

            // Properties
            public NDarray random_offset_ => default!;
            public NDarray random_weights_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public RBFSampler fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public RBFSampler set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public RBFSampler set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class SkewedChi2Sampler
        {
            // Constructor
            public SkewedChi2Sampler(float skewedness = 1.0f, int n_components = 100, int? random_state = null)
            {
            }

            // Properties
            public NDarray random_weights_ => default!;
            public NDarray random_offset_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public SkewedChi2Sampler fit(NDarray X, NDarray? y = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public SkewedChi2Sampler set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public SkewedChi2Sampler set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }
    }
}