using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class isotonic
        {
            public static bool check_increasing(NDarray x, NDarray y)
            {
                throw new NotImplementedException();
            }

            public static NDarray isotonic_regression(NDarray y, NDarray? sample_weight = null, float? y_min = null, float? y_max = null, bool increasing = true)
            {
                throw new NotImplementedException();
            }

            public class IsotonicRegression
            {
                public IsotonicRegression(float? y_min = null, float? y_max = null, bool increasing = true, string out_of_bounds = "nan")
                {
                }

                public float X_min_ => Helpers.ToCSharpNDarray(self.GetAttr("X_min_"));
                public float X_max_ => Helpers.ToCSharpNDarray(self.GetAttr("X_max_"));
                public NDarray X_thresholds_ => Helpers.ToCSharpNDarray(self.GetAttr("X_thresholds_"));
                public NDarray y_thresholds_ => Helpers.ToCSharpNDarray(self.GetAttr("y_thresholds_"));
                public PyObject f_ => Helpers.ToCSharpNDarray(self.GetAttr("f_"));
                public bool increasing_ => Helpers.ToCSharpNDarray(self.GetAttr("increasing_"));

                public IsotonicRegression fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict(NDarray T)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public IsotonicRegression set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public IsotonicRegression set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public IsotonicRegression set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public IsotonicRegression set_predict_request(string? T = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public IsotonicRegression set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public IsotonicRegression set_transform_request(string? T = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray T)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}