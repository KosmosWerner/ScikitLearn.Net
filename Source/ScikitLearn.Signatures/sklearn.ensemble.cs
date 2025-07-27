using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class ensemble
    {
        // Classes
        public class AdaBoostClassifier : PythonObject
        {
            // Constructor
            public AdaBoostClassifier(PyObject? estimator = null, int n_estimators = 50, float learning_rate = 1.0f, string algorithm = "SAMME.R", int? random_state = null)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray classes_ => default!;
            public int n_classes_ => default!;
            public NDarray estimator_weights_ => default!;
            public NDarray estimator_errors_ => default!;
            public NDarray feature_importances_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public AdaBoostClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public void get_metadata_routing()
            {
            }

            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public AdaBoostClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public AdaBoostClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public AdaBoostClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray staged_decision_function(NDarray X) => default!;
            public NDarray staged_predict(NDarray X) => default!;
            public NDarray staged_predict_proba(NDarray X) => default!;
            public float staged_score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
        }

        public class AdaBoostRegressor : PythonObject
        {
            // Constructor
            public AdaBoostRegressor(PyObject? estimator = null, int n_estimators = 50, float learning_rate = 1.0f, string loss = "linear", int? random_state = null)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray estimator_weights_ => default!;
            public NDarray estimator_errors_ => default!;
            public NDarray feature_importances_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public AdaBoostRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public void get_metadata_routing()
            {
            }

            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public AdaBoostRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public AdaBoostRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public AdaBoostRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray staged_predict(NDarray X) => default!;
            public float staged_score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
        }

        public class BaggingClassifier : PythonObject
        {
            // Constructor
            public BaggingClassifier(PyObject? estimator = null, int n_estimators = 10, float max_samples = 1.0f, float max_features = 1.0f, bool bootstrap = true, bool bootstrap_features = false, bool oob_score = false, bool warm_start = false, int? n_jobs = null, int? random_state = null, int verbose = 0)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray estimators_samples_ => default!;
            public NDarray estimators_features_ => default!;
            public NDarray classes_ => default!;
            public int n_classes_ => default!;
            public float oob_score_ => default!;
            public NDarray oob_decision_function_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public BaggingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public BaggingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public BaggingClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public BaggingClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class BaggingRegressor : PythonObject
        {
            // Constructor
            public BaggingRegressor(PyObject? estimator = null, int n_estimators = 10, float max_samples = 1.0f, float max_features = 1.0f, bool bootstrap = true, bool bootstrap_features = false, bool oob_score = false, bool warm_start = false, int? n_jobs = null, int? random_state = null, int verbose = 0)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray estimators_samples_ => default!;
            public NDarray estimators_features_ => default!;
            public float oob_score_ => default!;
            public NDarray oob_prediction_ => default!;

            // Methods
            [ReturnThis]
            public BaggingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public BaggingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public BaggingRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public BaggingRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class ExtraTreesClassifier : PythonObject
        {
            // Constructor
            public ExtraTreesClassifier(int n_estimators = 100, string criterion = "gini", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = false, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, PyDict? class_weight = null, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray classes_ => default!;
            public int n_classes_ => default!;
            public NDarray feature_importances_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public float oob_score_ => default!;
            public NDarray oob_decision_function_ => default!;
            public NDarray estimators_samples_ => default!;

            // Methods
            public NDarray apply(NDarray X) => default!;
            public (NDarray?, NDarray?) decision_path(NDarray X) => default!;
            [ReturnThis]
            public ExtraTreesClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ExtraTreesClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ExtraTreesClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ExtraTreesClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class ExtraTreesRegressor : PythonObject
        {
            // Constructor
            public ExtraTreesRegressor(int n_estimators = 100, string criterion = "squared_error", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = false, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray feature_importances_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public float oob_score_ => default!;
            public NDarray oob_prediction_ => default!;
            public NDarray estimators_samples_ => default!;

            // Methods
            public NDarray apply(NDarray X) => default!;
            public (NDarray?, NDarray?) decision_path(NDarray X) => default!;
            [ReturnThis]
            public ExtraTreesRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ExtraTreesRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ExtraTreesRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ExtraTreesRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class GradientBoostingClassifier : PythonObject
        {
            // Constructor
            public GradientBoostingClassifier(string loss = "log_loss", float learning_rate = 0.1f, int n_estimators = 100, float subsample = 1.0f, string criterion = "friedman_mse", int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_depth = 3, float min_impurity_decrease = 0.0f, PyObject? init = null, int? random_state = null, float? max_features = null, int verbose = 0, int? max_leaf_nodes = null, bool warm_start = false, float validation_fraction = 0.1f, int? n_iter_no_change = null, float tol = 0.0001f, float ccp_alpha = 0.0f)
            {
            }

            // Properties
            public int n_estimators_ => default!;
            public int n_trees_per_iteration_ => default!;
            public NDarray feature_importances_ => default!;
            public NDarray oob_improvement_ => default!;
            public NDarray oob_scores_ => default!;
            public float oob_score_ => default!;
            public NDarray train_score_ => default!;
            public PyObject init_ => default!;
            public NDarray estimators_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_classes_ => default!;
            public int max_features_ => default!;

            // Methods
            public NDarray apply(NDarray X) => default!;
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public GradientBoostingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, PyObject? monitor = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public GradientBoostingClassifier set_fit_request(string? monitor = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public GradientBoostingClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public GradientBoostingClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray staged_decision_function(NDarray X) => default!;
            public NDarray staged_predict(NDarray X) => default!;
            public NDarray staged_predict_proba(NDarray X) => default!;
        }

        public class GradientBoostingRegressor : PythonObject
        {
            // Constructor
            public GradientBoostingRegressor(string loss = "squared_error", float learning_rate = 0.1f, int n_estimators = 100, float subsample = 1.0f, string criterion = "friedman_mse", int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_depth = 3, float min_impurity_decrease = 0.0f, PyObject? init = null, int? random_state = null, float? max_features = null, float alpha = 0.9f, int verbose = 0, int? max_leaf_nodes = null, bool warm_start = false, float validation_fraction = 0.1f, int? n_iter_no_change = null, float tol = 0.0001f, float ccp_alpha = 0.0f)
            {
            }

            // Properties
            public int n_estimators_ => default!;
            public int n_trees_per_iteration_ => default!;
            public NDarray feature_importances_ => default!;
            public NDarray oob_improvement_ => default!;
            public NDarray oob_scores_ => default!;
            public float oob_score_ => default!;
            public NDarray train_score_ => default!;
            public PyObject init_ => default!;
            public NDarray estimators_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int max_features_ => default!;

            // Methods
            public NDarray apply(NDarray X) => default!;
            [ReturnThis]
            public GradientBoostingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, PyObject? monitor = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public GradientBoostingRegressor set_fit_request(string? monitor = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public GradientBoostingRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public GradientBoostingRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray staged_predict(NDarray X) => default!;
        }

        public class HistGradientBoostingClassifier : PythonObject
        {
            // Constructor
            public HistGradientBoostingClassifier(string loss = "log_loss", float learning_rate = 0.1f, int max_iter = 100, int? max_leaf_nodes = 31, int? max_depth = null, int min_samples_leaf = 20, float l2_regularization = 0.0f, float max_features = 1.0f, int max_bins = 255, string? categorical_features = "warn", PyDict? monotonic_cst = null, int? interaction_cst = null, bool warm_start = false, string early_stopping = "auto", string? scoring = "loss", float? validation_fraction = 0.1f, int n_iter_no_change = 10, float tol = 1e-07f, int verbose = 0, int? random_state = null, PyDict? class_weight = null)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public bool do_early_stopping_ => default!;
            public int n_iter_ => default!;
            public int n_trees_per_iteration_ => default!;
            public NDarray train_score_ => default!;
            public NDarray validation_score_ => default!;
            public NDarray is_categorical_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public HistGradientBoostingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public HistGradientBoostingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public HistGradientBoostingClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public HistGradientBoostingClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray staged_decision_function(NDarray X) => default!;
            public NDarray staged_predict(NDarray X) => default!;
            public NDarray staged_predict_proba(NDarray X) => default!;
        }

        public class HistGradientBoostingRegressor : PythonObject
        {
            // Constructor
            public HistGradientBoostingRegressor(string loss = "squared_error", float? quantile = null, float learning_rate = 0.1f, int max_iter = 100, int? max_leaf_nodes = 31, int? max_depth = null, int min_samples_leaf = 20, float l2_regularization = 0.0f, float max_features = 1.0f, int max_bins = 255, string? categorical_features = "warn", PyDict? monotonic_cst = null, int? interaction_cst = null, bool warm_start = false, string early_stopping = "auto", string? scoring = "loss", float? validation_fraction = 0.1f, int n_iter_no_change = 10, float tol = 1e-07f, int verbose = 0, int? random_state = null)
            {
            }

            // Properties
            public bool do_early_stopping_ => default!;
            public int n_iter_ => default!;
            public int n_trees_per_iteration_ => default!;
            public NDarray train_score_ => default!;
            public NDarray validation_score_ => default!;
            public NDarray is_categorical_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public HistGradientBoostingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public HistGradientBoostingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public HistGradientBoostingRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public HistGradientBoostingRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray staged_predict(NDarray X) => default!;
        }

        public class IsolationForest : PythonObject
        {
            // Constructor
            public IsolationForest(int n_estimators = 100, string max_samples = "auto", string contamination = "auto", float max_features = 1.0f, bool bootstrap = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray estimators_features_ => default!;
            public NDarray estimators_samples_ => default!;
            public int max_samples_ => default!;
            public float offset_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public IsolationForest fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray fit_predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray score_samples(NDarray X) => default!;
            [ReturnThis]
            public IsolationForest set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public IsolationForest set_params(Dictionary<string, PyObject>? @params = null) => default!;
        }

        public class RandomForestClassifier : PythonObject
        {
            // Constructor
            public RandomForestClassifier(int n_estimators = 100, string criterion = "gini", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = true, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, PyDict? class_weight = null, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray classes_ => default!;
            public int n_classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public NDarray feature_importances_ => default!;
            public float oob_score_ => default!;
            public NDarray oob_decision_function_ => default!;
            public NDarray estimators_samples_ => default!;

            // Methods
            public NDarray apply(NDarray X) => default!;
            public (NDarray?, NDarray?) decision_path(NDarray X) => default!;
            [ReturnThis]
            public RandomForestClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public RandomForestClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public RandomForestClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public RandomForestClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class RandomForestRegressor : PythonObject
        {
            // Constructor
            public RandomForestRegressor(int n_estimators = 100, string criterion = "squared_error", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool bootstrap = true, bool oob_score = false, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false, float ccp_alpha = 0.0f, float? max_samples = null, NDarray? monotonic_cst = null)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray feature_importances_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public float oob_score_ => default!;
            public NDarray oob_prediction_ => default!;
            public NDarray estimators_samples_ => default!;

            // Methods
            public NDarray apply(NDarray X) => default!;
            public (NDarray?, NDarray?) decision_path(NDarray X) => default!;
            [ReturnThis]
            public RandomForestRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public RandomForestRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public RandomForestRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public RandomForestRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class RandomTreesEmbedding : PythonObject
        {
            // Constructor
            public RandomTreesEmbedding(int n_estimators = 100, int max_depth = 5, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, bool sparse_output = true, int? n_jobs = null, int? random_state = null, int verbose = 0, bool warm_start = false)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public PyTuple estimators_ => default!;
            public NDarray feature_importances_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public PyObject one_hot_encoder_ => default!;
            public NDarray estimators_samples_ => default!;

            // Methods
            public NDarray apply(NDarray X) => default!;
            public (NDarray?, NDarray?) decision_path(NDarray X) => default!;
            [ReturnThis]
            public RandomTreesEmbedding fit(NDarray X, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? sample_weight = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            [ReturnThis]
            public RandomTreesEmbedding set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public RandomTreesEmbedding set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public RandomTreesEmbedding set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class StackingClassifier : PythonObject
        {
            // Constructor
            public StackingClassifier(PyTuple estimators, PyObject? final_estimator = null, int? cv = null, string stack_method = "auto", int? n_jobs = null, bool passthrough = false, int verbose = 0)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public PyTuple estimators_ => default!;
            public PyDict named_estimators_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public PyObject final_estimator_ => default!;
            public PyTuple stack_method_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public StackingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public void get_metadata_routing()
            {
            }

            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public StackingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public StackingClassifier set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public StackingClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public StackingClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class StackingRegressor : PythonObject
        {
            // Constructor
            public StackingRegressor(PyTuple estimators, PyObject? final_estimator = null, int? cv = null, int? n_jobs = null, bool passthrough = false, int verbose = 0)
            {
            }

            // Properties
            public PyTuple estimators_ => default!;
            public PyDict named_estimators_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public PyObject final_estimator_ => default!;
            public PyTuple stack_method_ => default!;

            // Methods
            [ReturnThis]
            public StackingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public void get_metadata_routing()
            {
            }

            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, Dictionary<string, PyObject>? @params = null) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public StackingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public StackingRegressor set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public StackingRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public StackingRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public NDarray transform(NDarray X) => default!;
        }

        public class VotingClassifier : PythonObject
        {
            // Constructor
            public VotingClassifier(PyTuple estimators, string voting = "hard", NDarray? weights = null, int? n_jobs = null, bool flatten_transform = true, bool verbose = false)
            {
            }

            // Properties
            public PyTuple estimators_ => default!;
            public PyDict named_estimators_ => default!;
            public PyObject le_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public VotingClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public VotingClassifier set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public VotingClassifier set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public VotingClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public VotingClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public PyObject transform(NDarray X) => default!;
        }

        public class VotingRegressor : PythonObject
        {
            // Constructor
            public VotingRegressor(PyTuple estimators, NDarray? weights = null, int? n_jobs = null, bool verbose = false)
            {
            }

            // Properties
            public PyTuple estimators_ => default!;
            public PyDict named_estimators_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            [ReturnThis]
            public VotingRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray fit_transform(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_feature_names_out(NDarray? input_features = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public VotingRegressor set_fit_request(string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public VotingRegressor set_output(PyObject? transform = null) => default!;
            [ReturnThis]
            public VotingRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public VotingRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
            public PyDict transform(NDarray X) => default!;
        }
    }
}