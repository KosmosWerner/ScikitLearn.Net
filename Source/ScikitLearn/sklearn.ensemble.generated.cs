using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class ensemble
        {
            public class AdaBoostClassifier
            {
                public AdaBoostClassifier(PyObject? estimator = null, int n_estimators = 50, float learning_rate = 1.0f, string algorithm = "SAMME.R", int? random_state = null)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public NDarray estimator_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_weights_"));
                public NDarray estimator_errors_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_errors_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public AdaBoostClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public AdaBoostClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public AdaBoostClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public AdaBoostClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float staged_score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class AdaBoostRegressor
            {
                public AdaBoostRegressor(PyObject? estimator = null, int n_estimators = 50, float learning_rate = 1.0f, string loss = "linear", int? random_state = null)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray estimator_weights_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_weights_"));
                public NDarray estimator_errors_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_errors_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public AdaBoostRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public AdaBoostRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public AdaBoostRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public AdaBoostRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float staged_score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class BaggingClassifier
            {
                public BaggingClassifier(PyObject? estimator = null, int n_estimators = 10, float max_samples = 1.0f, float max_features = 1.0f, bool bootstrap = true, bool bootstrap_features = false, bool oob_score = false, bool warm_start = false, int? n_jobs = null, int? random_state = null, int verbose = 0)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray estimators_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_samples_"));
                public NDarray estimators_features_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_features_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public float oob_score_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_score_"));
                public NDarray oob_decision_function_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_decision_function_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public BaggingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
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

                public NDarray predict_log_proba(NDarray X)
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

                public BaggingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public BaggingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public BaggingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class BaggingRegressor
            {
                public BaggingRegressor(PyObject? estimator = null, int n_estimators = 10, float max_samples = 1.0f, float max_features = 1.0f, bool bootstrap = true, bool bootstrap_features = false, bool oob_score = false, bool warm_start = false, int? n_jobs = null, int? random_state = null, int verbose = 0)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray estimators_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_samples_"));
                public NDarray estimators_features_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_features_"));
                public float oob_score_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_score_"));
                public NDarray oob_prediction_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_prediction_"));

                public BaggingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public BaggingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public BaggingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public BaggingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class ExtraTreesClassifier
            {
                public ExtraTreesClassifier(int n_estimators = 100, string criterion = "gini", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = false, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, PyDict? class_weight = null, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public float oob_score_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_score_"));
                public NDarray oob_decision_function_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_decision_function_"));
                public NDarray estimators_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) decision_path(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreesClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict_log_proba(NDarray X)
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

                public ExtraTreesClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ExtraTreesClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreesClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class ExtraTreesRegressor
            {
                public ExtraTreesRegressor(int n_estimators = 100, string criterion = "squared_error", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = false, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public float oob_score_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_score_"));
                public NDarray oob_prediction_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_prediction_"));
                public NDarray estimators_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) decision_path(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreesRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreesRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ExtraTreesRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreesRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class GradientBoostingClassifier
            {
                public GradientBoostingClassifier(string loss = "log_loss", float learning_rate = 0.1f, int n_estimators = 100, float subsample = 1.0f, string criterion = "friedman_mse", int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_depth = 3, float min_impurity_decrease = 0.0f, PyObject? init = null, int? random_state = null, float? max_features = null, int verbose = 0, int? max_leaf_nodes = null, bool warm_start = false, float validation_fraction = 0.1f, int? n_iter_no_change = null, float tol = 0.0001f, float ccp_alpha = 0.0f)
                {
                }

                public int n_estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("n_estimators_"));
                public int n_trees_per_iteration_ => Helpers.ToCSharpNDarray(self.GetAttr("n_trees_per_iteration_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public NDarray oob_improvement_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_improvement_"));
                public NDarray oob_scores_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_scores_"));
                public float oob_score_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_score_"));
                public NDarray train_score_ => Helpers.ToCSharpNDarray(self.GetAttr("train_score_"));
                public PyObject init_ => Helpers.ToCSharpNDarray(self.GetAttr("init_"));
                public NDarray estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public int max_features_ => Helpers.ToCSharpNDarray(self.GetAttr("max_features_"));

                public NDarray apply(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public GradientBoostingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, PyObject? monitor = null)
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

                public NDarray predict_log_proba(NDarray X)
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

                public GradientBoostingClassifier set_fit_request(string? monitor = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public GradientBoostingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public GradientBoostingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class GradientBoostingRegressor
            {
                public GradientBoostingRegressor(string loss = "squared_error", float learning_rate = 0.1f, int n_estimators = 100, float subsample = 1.0f, string criterion = "friedman_mse", int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_depth = 3, float min_impurity_decrease = 0.0f, PyObject? init = null, int? random_state = null, float? max_features = null, float alpha = 0.9f, int verbose = 0, int? max_leaf_nodes = null, bool warm_start = false, float validation_fraction = 0.1f, int? n_iter_no_change = null, float tol = 0.0001f, float ccp_alpha = 0.0f)
                {
                }

                public int n_estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("n_estimators_"));
                public int n_trees_per_iteration_ => Helpers.ToCSharpNDarray(self.GetAttr("n_trees_per_iteration_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public NDarray oob_improvement_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_improvement_"));
                public NDarray oob_scores_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_scores_"));
                public float oob_score_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_score_"));
                public NDarray train_score_ => Helpers.ToCSharpNDarray(self.GetAttr("train_score_"));
                public PyObject init_ => Helpers.ToCSharpNDarray(self.GetAttr("init_"));
                public NDarray estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int max_features_ => Helpers.ToCSharpNDarray(self.GetAttr("max_features_"));

                public NDarray apply(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public GradientBoostingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, PyObject? monitor = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public GradientBoostingRegressor set_fit_request(string? monitor = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public GradientBoostingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public GradientBoostingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class HistGradientBoostingClassifier
            {
                public HistGradientBoostingClassifier(string loss = "log_loss", float learning_rate = 0.1f, int max_iter = 100, int? max_leaf_nodes = 31, int? max_depth = null, int min_samples_leaf = 20, float l2_regularization = 0.0f, float max_features = 1.0f, int max_bins = 255, string? categorical_features = "warn", PyDict? monotonic_cst = null, int? interaction_cst = null, bool warm_start = false, string early_stopping = "auto", string? scoring = "loss", float? validation_fraction = 0.1f, int n_iter_no_change = 10, float tol = 1e-07f, int verbose = 0, int? random_state = null, PyDict? class_weight = null)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public bool do_early_stopping_ => Helpers.ToCSharpNDarray(self.GetAttr("do_early_stopping_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_trees_per_iteration_ => Helpers.ToCSharpNDarray(self.GetAttr("n_trees_per_iteration_"));
                public NDarray train_score_ => Helpers.ToCSharpNDarray(self.GetAttr("train_score_"));
                public NDarray validation_score_ => Helpers.ToCSharpNDarray(self.GetAttr("validation_score_"));
                public NDarray is_categorical_ => Helpers.ToCSharpNDarray(self.GetAttr("is_categorical_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public HistGradientBoostingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public HistGradientBoostingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public HistGradientBoostingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public HistGradientBoostingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class HistGradientBoostingRegressor
            {
                public HistGradientBoostingRegressor(string loss = "squared_error", float? quantile = null, float learning_rate = 0.1f, int max_iter = 100, int? max_leaf_nodes = 31, int? max_depth = null, int min_samples_leaf = 20, float l2_regularization = 0.0f, float max_features = 1.0f, int max_bins = 255, string? categorical_features = "warn", PyDict? monotonic_cst = null, int? interaction_cst = null, bool warm_start = false, string early_stopping = "auto", string? scoring = "loss", float? validation_fraction = 0.1f, int n_iter_no_change = 10, float tol = 1e-07f, int verbose = 0, int? random_state = null)
                {
                }

                public bool do_early_stopping_ => Helpers.ToCSharpNDarray(self.GetAttr("do_early_stopping_"));
                public int n_iter_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iter_"));
                public int n_trees_per_iteration_ => Helpers.ToCSharpNDarray(self.GetAttr("n_trees_per_iteration_"));
                public NDarray train_score_ => Helpers.ToCSharpNDarray(self.GetAttr("train_score_"));
                public NDarray validation_score_ => Helpers.ToCSharpNDarray(self.GetAttr("validation_score_"));
                public NDarray is_categorical_ => Helpers.ToCSharpNDarray(self.GetAttr("is_categorical_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public HistGradientBoostingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public HistGradientBoostingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public HistGradientBoostingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public HistGradientBoostingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray staged_predict(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class IsolationForest
            {
                public IsolationForest(int n_estimators = 100, string max_samples = "auto", string contamination = "auto", float max_features = 1.0f, bool bootstrap = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray estimators_features_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_features_"));
                public NDarray estimators_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_samples_"));
                public int max_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("max_samples_"));
                public float offset_ => Helpers.ToCSharpNDarray(self.GetAttr("offset_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public IsolationForest fit(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null)
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

                public NDarray score_samples(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public IsolationForest set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public IsolationForest set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class RandomForestClassifier
            {
                public RandomForestClassifier(int n_estimators = 100, string criterion = "gini", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = true, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, PyDict? class_weight = null, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public float oob_score_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_score_"));
                public NDarray oob_decision_function_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_decision_function_"));
                public NDarray estimators_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) decision_path(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public RandomForestClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict_log_proba(NDarray X)
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

                public RandomForestClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public RandomForestClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public RandomForestClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class RandomForestRegressor
            {
                public RandomForestRegressor(int n_estimators = 100, string criterion = "squared_error", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = true, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public float oob_score_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_score_"));
                public NDarray oob_prediction_ => Helpers.ToCSharpNDarray(self.GetAttr("oob_prediction_"));
                public NDarray estimators_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) decision_path(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public RandomForestRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public RandomForestRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public RandomForestRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public RandomForestRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class RandomTreesEmbedding
            {
                public RandomTreesEmbedding(int n_estimators = 100, int max_depth = 5, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool sparse_output = true, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public PyObject one_hot_encoder_ => Helpers.ToCSharpNDarray(self.GetAttr("one_hot_encoder_"));
                public NDarray estimators_samples_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_samples_"));

                public NDarray apply(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) decision_path(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public RandomTreesEmbedding fit(NDarray X, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray? sample_weight = null)
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

                public RandomTreesEmbedding set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public RandomTreesEmbedding set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public RandomTreesEmbedding set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class StackingClassifier
            {
                public StackingClassifier(PyTuple estimators, PyObject? final_estimator = null, int? cv = null, string stack_method = "auto", int? n_jobs = null, bool passthrough = false, int verbose = 0)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public PyDict named_estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("named_estimators_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public PyObject final_estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("final_estimator_"));
                public PyTuple stack_method_ => Helpers.ToCSharpNDarray(self.GetAttr("stack_method_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public StackingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null)
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

                public NDarray predict_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public StackingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public StackingClassifier set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public StackingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public StackingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class StackingRegressor
            {
                public StackingRegressor(PyTuple estimators, PyObject? final_estimator = null, int? cv = null, int? n_jobs = null, bool passthrough = false, int verbose = 0)
                {
                }

                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public PyDict named_estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("named_estimators_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public PyObject final_estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("final_estimator_"));
                public PyTuple stack_method_ => Helpers.ToCSharpNDarray(self.GetAttr("stack_method_"));

                public StackingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray fit_transform(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject get_feature_names_out(NDarray? input_features = null)
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

                public StackingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public StackingRegressor set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public StackingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public StackingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class VotingClassifier
            {
                public VotingClassifier(PyTuple estimators, string voting = "hard", NDarray? weights = null, int? n_jobs = null, bool flatten_transform = true, bool verbose = false)
                {
                }

                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public PyDict named_estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("named_estimators_"));
                public PyObject le_ => Helpers.ToCSharpNDarray(self.GetAttr("le_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public VotingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
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

                public VotingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public VotingClassifier set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public VotingClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public VotingClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public PyObject transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public class VotingRegressor
            {
                public VotingRegressor(PyTuple estimators, NDarray? weights = null, int? n_jobs = null, bool verbose = false)
                {
                }

                public PyTuple estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("estimators_"));
                public PyDict named_estimators_ => Helpers.ToCSharpNDarray(self.GetAttr("named_estimators_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public VotingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null)
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

                public NDarray predict(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public VotingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public VotingRegressor set_output(PyObject? transform = null)
                {
                    throw new NotImplementedException();
                }

                public VotingRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public VotingRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public PyDict transform(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}