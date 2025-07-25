using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class semi_supervised
        {
            public class LabelPropagation
            {
                public LabelPropagation(string kernel = "rbf", int gamma = 20, int n_neighbors = 7, int max_iter = 1000, float tol = 0.001f, int? n_jobs = null)
                {
                }

                public NDarray X_ => Helpers.ToCSharpNDarray(self.GetAttr("X_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray label_distributions_ => Helpers.ToCSharpNDarray(self.GetAttr("label_distributions_"));
                public NDarray transduction_ => Helpers.ToCSharpNDarray(self.GetAttr("transduction_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));

                public LabelPropagation fit(NDarray X, NDarray y)
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

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public LabelPropagation set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public LabelPropagation set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class LabelSpreading
            {
                public LabelSpreading(string kernel = "rbf", int gamma = 20, int n_neighbors = 7, float alpha = 0.2f, int max_iter = 30, float tol = 0.001f, int? n_jobs = null)
                {
                }

                public NDarray X_ => Helpers.ToCSharpNDarray(self.GetAttr("X_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray label_distributions_ => Helpers.ToCSharpNDarray(self.GetAttr("label_distributions_"));
                public NDarray transduction_ => Helpers.ToCSharpNDarray(self.GetAttr("transduction_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));

                public LabelSpreading fit(NDarray X, NDarray y)
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

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public LabelSpreading set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public LabelSpreading set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class SelfTrainingClassifier
            {
                public SelfTrainingClassifier(PyObject base_estimator, float threshold = 0.75f, string criterion = "threshold", int k_best = 10, int? max_iter = 10, bool verbose = false)
                {
                }

                public PyObject base_estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("base_estimator_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray transduction_ => Helpers.ToCSharpNDarray(self.GetAttr("transduction_"));
                public NDarray labeled_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("labeled_iter_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public PyObject termination_condition_ => Helpers.ToCSharpNDarray(self.GetAttr("termination_condition_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public SelfTrainingClassifier fit(NDarray X, NDarray y)
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

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y)
                {
                    throw new NotImplementedException();
                }

                public SelfTrainingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}