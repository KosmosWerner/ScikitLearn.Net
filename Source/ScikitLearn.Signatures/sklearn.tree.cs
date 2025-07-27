using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;
using ScikitLearn.Signatures.Annotations;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class tree
    {
        // Methods
        [Generate]
        public static string export_graphviz(
            PyObject decision_tree,
            string? out_file = null,
            int? max_depth = null,
            NDarray? feature_names = null,
            NDarray? class_names = null,
            string label = "all",
            bool filled = false,
            bool leaves_parallel = false,
            bool impurity = true,
            bool node_ids = false,
            bool proportion = false,
            bool rotate = false,
            bool rounded = false,
            bool special_characters = false,
            int precision = 3,
            string fontname = "helvetica") => default!;
        [Generate]
        public static string export_text(
            PyObject decision_tree,
            NDarray? feature_names = null,
            NDarray? class_names = null,
            int max_depth = 10,
            int spacing = 3,
            int decimals = 2,
            bool show_weights = false) => default!;
        [Generate]
        public static PyTuple plot_tree(
            DecisionTreeClassifier decision_tree,
            int? max_depth = null,
            NDarray? feature_names = null,
            NDarray? class_names = null,
            string label = "all",
            bool filled = false,
            bool impurity = true,
            bool node_ids = false,
            bool proportion = false,
            bool rounded = false,
            int precision = 3,
            PyObject? ax = null,
            int? fontsize = null) => default!;
        [Generate]
        public static PyTuple plot_tree(
            DecisionTreeRegressor decision_tree,
            int? max_depth = null,
            NDarray? feature_names = null,
            NDarray? class_names = null,
            string label = "all",
            bool filled = false,
            bool impurity = true,
            bool node_ids = false,
            bool proportion = false,
            bool rounded = false,
            int precision = 3,
            PyObject? ax = null,
            int? fontsize = null) => default!;
        // Classes
        public class DecisionTreeClassifier : PythonObject
        {
            // Constructor
            public DecisionTreeClassifier(
                string criterion = "gini",
                string splitter = "best",
                int? max_depth = null,
                int min_samples_split = 2,
                int min_samples_leaf = 1,
                float min_weight_fraction_leaf = 0.0f,
                float? max_features = null,
                int? random_state = null,
                int? max_leaf_nodes = null,
                float min_impurity_decrease = 0.0f,
                PyDict? class_weight = null,
                float ccp_alpha = 0.0f,
                NDarray? monotonic_cst = null)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public NDarray feature_importances_ => default!;
            public int max_features_ => default!;
            public PyTuple n_classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public PyObject tree_ => default!;

            // Methods
            public NDarray apply(NDarray X, bool check_input = true) => default!;
            public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray decision_path(NDarray X, bool check_input = true) => default!;
            [ReturnThis]
            public DecisionTreeClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true) => default!;
            [ReturnThis]
            public DecisionTreeClassifier get_depth() => default!;
            public PyObject get_metadata_routing() => default!;
            [ReturnThis]
            public DecisionTreeClassifier get_n_leaves() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, bool check_input = true) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X, bool check_input = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public DecisionTreeClassifier set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public DecisionTreeClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public DecisionTreeClassifier set_predict_proba_request(string? check_input = "$UNCHANGED$") => default!;
            [ReturnThis]
            public DecisionTreeClassifier set_predict_request(string? check_input = "$UNCHANGED$") => default!;
            [ReturnThis]
            public DecisionTreeClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class DecisionTreeRegressor : PythonObject
        {
            // Constructor
            public DecisionTreeRegressor(string criterion = "squared_error", string splitter = "best", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = null, int? random_state = null, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
            {
            }

            // Properties
            public NDarray feature_importances_ => default!;
            public int max_features_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public PyObject tree_ => default!;

            // Methods
            public NDarray apply(NDarray X, bool check_input = true) => default!;
            public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray decision_path(NDarray X, bool check_input = true) => default!;
            [ReturnThis]
            public DecisionTreeRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true) => default!;
            [ReturnThis]
            public DecisionTreeRegressor get_depth() => default!;
            public PyObject get_metadata_routing() => default!;
            [ReturnThis]
            public DecisionTreeRegressor get_n_leaves() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, bool check_input = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public DecisionTreeRegressor set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public DecisionTreeRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public DecisionTreeRegressor set_predict_request(string? check_input = "$UNCHANGED$") => default!;
            [ReturnThis]
            public DecisionTreeRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class ExtraTreeClassifier : PythonObject
        {
            // Constructor
            public ExtraTreeClassifier(string criterion = "gini", string splitter = "random", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? random_state = null, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, PyDict? class_weight = null, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
            {
            }

            // Properties
            public NDarray classes_ => default!;
            public int max_features_ => default!;
            public PyTuple n_classes_ => default!;
            public NDarray feature_importances_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public int n_outputs_ => default!;
            public PyObject tree_ => default!;

            // Methods
            public NDarray apply(NDarray X, bool check_input = true) => default!;
            public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray decision_path(NDarray X, bool check_input = true) => default!;
            [ReturnThis]
            public ExtraTreeClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true) => default!;
            [ReturnThis]
            public ExtraTreeClassifier get_depth() => default!;
            public PyObject get_metadata_routing() => default!;
            [ReturnThis]
            public ExtraTreeClassifier get_n_leaves() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, bool check_input = true) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X, bool check_input = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ExtraTreeClassifier set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ExtraTreeClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ExtraTreeClassifier set_predict_proba_request(string? check_input = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ExtraTreeClassifier set_predict_request(string? check_input = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ExtraTreeClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class ExtraTreeRegressor : PythonObject
        {
            // Constructor
            public ExtraTreeRegressor(string criterion = "squared_error", string splitter = "random", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? random_state = null, float min_impurity_decrease = 0.0f, int? max_leaf_nodes = null, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
            {
            }

            // Properties
            public int max_features_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;
            public NDarray feature_importances_ => default!;
            public int n_outputs_ => default!;
            public PyObject tree_ => default!;

            // Methods
            public NDarray apply(NDarray X, bool check_input = true) => default!;
            public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            public NDarray decision_path(NDarray X, bool check_input = true) => default!;
            [ReturnThis]
            public ExtraTreeRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true) => default!;
            [ReturnThis]
            public ExtraTreeRegressor get_depth() => default!;
            public PyObject get_metadata_routing() => default!;
            [ReturnThis]
            public ExtraTreeRegressor get_n_leaves() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X, bool check_input = true) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public ExtraTreeRegressor set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ExtraTreeRegressor set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public ExtraTreeRegressor set_predict_request(string? check_input = "$UNCHANGED$") => default!;
            [ReturnThis]
            public ExtraTreeRegressor set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }
    }
}