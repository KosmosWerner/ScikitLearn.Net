using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class pipeline
        {
            public static PyObject make_pipeline(PyObject[] steps, PyObject? memory = null, bool verbose = false)
            {
                throw new NotImplementedException();
            }

            public static PyObject make_union(PyObject[] transformers, int? n_jobs = null, bool verbose = false)
            {
                throw new NotImplementedException();
            }

            public class FeatureUnion
            {
                public FeatureUnion(PyTuple transformer_list, int? n_jobs = null, PyDict? transformer_weights = null, bool verbose = false, bool verbose_feature_names_out = true)
                {
                }

                public PyDict named_transformers => Helpers.ToCSharpNDarray(self.GetAttr("named_transformers"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public FeatureUnion fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

                public string get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public FeatureUnion set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public FeatureUnion set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class Pipeline
            {
                public Pipeline(PyTuple steps, PyObject? memory = null, bool verbose = false)
                {
                }

                public PyDict named_steps => Helpers.ToCSharpNDarray(self.GetAttr("named_steps"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public Pipeline fit(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(PyObject X, PyObject? y = null, Dictionary<string, PyObject>? @params = null)
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

                public string get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray inverse_transform(NDarray? X = null, NDarray? Xt = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public float score(PyObject X, PyObject? y = null, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public Pipeline set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public Pipeline set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public Pipeline set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(PyObject X, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}