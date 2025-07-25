using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class dummy
        {
            public class DummyClassifier
            {
                public DummyClassifier(string strategy = "prior", int? random_state = null, NDarray? constant = null)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public PyTuple n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public NDarray class_prior_ => Helpers.ToCSharpNDarray(self.GetAttr("class_prior_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public bool sparse_output_ => Helpers.ToCSharpNDarray(self.GetAttr("sparse_output_"));

                public DummyClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public DummyClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DummyClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public DummyClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class DummyRegressor
            {
                public DummyRegressor(string strategy = "mean", NDarray? constant = null, float? quantile = null)
                {
                }

                public NDarray constant_ => Helpers.ToCSharpNDarray(self.GetAttr("constant_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));

                public DummyRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public (NDarray? , NDarray? ) predict(NDarray X, bool return_std = false)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public DummyRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DummyRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public DummyRegressor set_predict_request(string? return_std = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DummyRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}