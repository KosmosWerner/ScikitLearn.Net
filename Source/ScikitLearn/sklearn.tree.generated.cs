using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class tree
        {
            public static string export_graphviz(PyObject decision_tree, string? out_file = null, int? max_depth = null, NDarray? feature_names = null, NDarray? class_names = null, string label = "all", bool filled = false, bool leaves_parallel = false, bool impurity = true, bool node_ids = false, bool proportion = false, bool rotate = false, bool rounded = false, bool special_characters = false, int precision = 3, string fontname = "helvetica")
            {
                throw new NotImplementedException();
            }

            public static string export_text(PyObject decision_tree, NDarray? feature_names = null, NDarray? class_names = null, int max_depth = 10, int spacing = 3, int decimals = 2, bool show_weights = false)
            {
                throw new NotImplementedException();
            }

            public static PyTuple plot_tree(DecisionTreeClassifier decision_tree, int? max_depth = null, NDarray? feature_names = null, NDarray? class_names = null, string label = "all", bool filled = false, bool impurity = true, bool node_ids = false, bool proportion = false, bool rounded = false, int precision = 3, PyObject? ax = null, int? fontsize = null)
            {
                throw new NotImplementedException();
            }

            public static PyTuple plot_tree(DecisionTreeRegressor decision_tree, int? max_depth = null, NDarray? feature_names = null, NDarray? class_names = null, string label = "all", bool filled = false, bool impurity = true, bool node_ids = false, bool proportion = false, bool rounded = false, int precision = 3, PyObject? ax = null, int? fontsize = null)
            {
                throw new NotImplementedException();
            }

            public class DecisionTreeClassifier
            {
                public DecisionTreeClassifier(string criterion = "gini", string splitter = "best", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = null, int? random_state = null, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, PyDict? class_weight = null, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int max_features_ => Helpers.ToCSharpNDarray(self.GetAttr("max_features_"));
                public PyTuple n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public PyObject tree_ => Helpers.ToCSharpNDarray(self.GetAttr("tree_"));

                public NDarray apply(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray decision_path(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeClassifier get_depth()
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeClassifier get_n_leaves()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeClassifier set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeClassifier set_predict_proba_request(string? check_input = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeClassifier set_predict_request(string? check_input = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class DecisionTreeRegressor
            {
                public DecisionTreeRegressor(string criterion = "squared_error", string splitter = "best", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = null, int? random_state = null, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
                {
                }

                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int max_features_ => Helpers.ToCSharpNDarray(self.GetAttr("max_features_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public PyObject tree_ => Helpers.ToCSharpNDarray(self.GetAttr("tree_"));

                public NDarray apply(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray decision_path(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeRegressor get_depth()
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeRegressor get_n_leaves()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeRegressor set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeRegressor set_predict_request(string? check_input = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public DecisionTreeRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class ExtraTreeClassifier
            {
                public ExtraTreeClassifier(string criterion = "gini", string splitter = "random", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? random_state = null, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, PyDict? class_weight = null, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
                {
                }

                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int max_features_ => Helpers.ToCSharpNDarray(self.GetAttr("max_features_"));
                public PyTuple n_classes_ => Helpers.ToCSharpNDarray(self.GetAttr("n_classes_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public PyObject tree_ => Helpers.ToCSharpNDarray(self.GetAttr("tree_"));

                public NDarray apply(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray decision_path(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeClassifier get_depth()
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeClassifier get_n_leaves()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeClassifier set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeClassifier set_predict_proba_request(string? check_input = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeClassifier set_predict_request(string? check_input = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class ExtraTreeRegressor
            {
                public ExtraTreeRegressor(string criterion = "squared_error", string splitter = "random", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? random_state = null, float min_impurity_decrease = 0.0f, int? max_leaf_nodes = null, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
                {
                }

                public int max_features_ => Helpers.ToCSharpNDarray(self.GetAttr("max_features_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));
                public NDarray feature_importances_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_importances_"));
                public int n_outputs_ => Helpers.ToCSharpNDarray(self.GetAttr("n_outputs_"));
                public PyObject tree_ => Helpers.ToCSharpNDarray(self.GetAttr("tree_"));

                public NDarray apply(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray decision_path(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeRegressor get_depth()
                {
                    throw new NotImplementedException();
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeRegressor get_n_leaves()
                {
                    throw new NotImplementedException();
                }

                public PyDict get_params(bool deep = true)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(NDarray X, bool check_input = true)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeRegressor set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeRegressor set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeRegressor set_predict_request(string? check_input = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public ExtraTreeRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}