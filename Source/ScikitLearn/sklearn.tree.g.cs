namespace ScikitLearn;
#nullable enable
public static partial class sklearn
{
    public static class tree
    {
        private static Lazy<PyObject> _lazy_self;
        public static PyObject self { get => _lazy_self.Value; }

        private static void ReInitializeLazySelf()
        {
            _lazy_self = new Lazy<PyObject>(() =>
            {
                try
                {
                    return InstallAndImport();
                }
                catch (Exception)
                {
                    return InstallAndImport(true);
                }
            });
        }

        private static PyObject InstallAndImport(bool force = false)
        {
            PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
            PythonEngine.Initialize();
            return Py.Import("sklearn.tree");
        }

        static tree() => ReInitializeLazySelf();
        public static string export_graphviz(PyObject decision_tree, string? out_file = null, int? max_depth = null, NDarray? feature_names = null, NDarray? class_names = null, string label = "all", bool filled = false, bool leaves_parallel = false, bool impurity = true, bool node_ids = false, bool proportion = false, bool rotate = false, bool rounded = false, bool special_characters = false, int precision = 3, string fontname = "helvetica")
        {
            _ = sklearn.tree.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(decision_tree) });
            PyDict pyDict = new PyDict();
            if (out_file != null)
                pyDict["out_file"] = Helpers.ToPython(out_file);
            if (max_depth != null)
                pyDict["max_depth"] = Helpers.ToPython(max_depth);
            if (feature_names != null)
                pyDict["feature_names"] = Helpers.ToPython(feature_names);
            if (class_names != null)
                pyDict["class_names"] = Helpers.ToPython(class_names);
            if (label != "all")
                pyDict["label"] = Helpers.ToPython(label);
            if (filled != false)
                pyDict["filled"] = Helpers.ToPython(filled);
            if (leaves_parallel != false)
                pyDict["leaves_parallel"] = Helpers.ToPython(leaves_parallel);
            if (impurity != true)
                pyDict["impurity"] = Helpers.ToPython(impurity);
            if (node_ids != false)
                pyDict["node_ids"] = Helpers.ToPython(node_ids);
            if (proportion != false)
                pyDict["proportion"] = Helpers.ToPython(proportion);
            if (rotate != false)
                pyDict["rotate"] = Helpers.ToPython(rotate);
            if (rounded != false)
                pyDict["rounded"] = Helpers.ToPython(rounded);
            if (special_characters != false)
                pyDict["special_characters"] = Helpers.ToPython(special_characters);
            if (precision != 3)
                pyDict["precision"] = Helpers.ToPython(precision);
            if (fontname != "helvetica")
                pyDict["fontname"] = Helpers.ToPython(fontname);
            var __pyObject = self.InvokeMethod("export_graphviz", args, pyDict);
            return __pyObject.As<string>();
        }

        public static string export_text(PyObject decision_tree, NDarray? feature_names = null, NDarray? class_names = null, int max_depth = 10, int spacing = 3, int decimals = 2, bool show_weights = false)
        {
            _ = sklearn.tree.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(decision_tree) });
            PyDict pyDict = new PyDict();
            if (feature_names != null)
                pyDict["feature_names"] = Helpers.ToPython(feature_names);
            if (class_names != null)
                pyDict["class_names"] = Helpers.ToPython(class_names);
            if (max_depth != 10)
                pyDict["max_depth"] = Helpers.ToPython(max_depth);
            if (spacing != 3)
                pyDict["spacing"] = Helpers.ToPython(spacing);
            if (decimals != 2)
                pyDict["decimals"] = Helpers.ToPython(decimals);
            if (show_weights != false)
                pyDict["show_weights"] = Helpers.ToPython(show_weights);
            var __pyObject = self.InvokeMethod("export_text", args, pyDict);
            return __pyObject.As<string>();
        }

        public static PyTuple plot_tree(DecisionTreeClassifier decision_tree, int? max_depth = null, NDarray? feature_names = null, NDarray? class_names = null, string label = "all", bool filled = false, bool impurity = true, bool node_ids = false, bool proportion = false, bool rounded = false, int precision = 3, PyObject? ax = null, int? fontsize = null)
        {
            _ = sklearn.tree.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(decision_tree) });
            PyDict pyDict = new PyDict();
            if (max_depth != null)
                pyDict["max_depth"] = Helpers.ToPython(max_depth);
            if (feature_names != null)
                pyDict["feature_names"] = Helpers.ToPython(feature_names);
            if (class_names != null)
                pyDict["class_names"] = Helpers.ToPython(class_names);
            if (label != "all")
                pyDict["label"] = Helpers.ToPython(label);
            if (filled != false)
                pyDict["filled"] = Helpers.ToPython(filled);
            if (impurity != true)
                pyDict["impurity"] = Helpers.ToPython(impurity);
            if (node_ids != false)
                pyDict["node_ids"] = Helpers.ToPython(node_ids);
            if (proportion != false)
                pyDict["proportion"] = Helpers.ToPython(proportion);
            if (rounded != false)
                pyDict["rounded"] = Helpers.ToPython(rounded);
            if (precision != 3)
                pyDict["precision"] = Helpers.ToPython(precision);
            if (ax != null)
                pyDict["ax"] = Helpers.ToPython(ax);
            if (fontsize != null)
                pyDict["fontsize"] = Helpers.ToPython(fontsize);
            var __pyObject = self.InvokeMethod("plot_tree", args, pyDict);
            return new PyTuple(__pyObject);
        }

        public static PyTuple plot_tree(DecisionTreeRegressor decision_tree, int? max_depth = null, NDarray? feature_names = null, NDarray? class_names = null, string label = "all", bool filled = false, bool impurity = true, bool node_ids = false, bool proportion = false, bool rounded = false, int precision = 3, PyObject? ax = null, int? fontsize = null)
        {
            _ = sklearn.tree.self;
            PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(decision_tree) });
            PyDict pyDict = new PyDict();
            if (max_depth != null)
                pyDict["max_depth"] = Helpers.ToPython(max_depth);
            if (feature_names != null)
                pyDict["feature_names"] = Helpers.ToPython(feature_names);
            if (class_names != null)
                pyDict["class_names"] = Helpers.ToPython(class_names);
            if (label != "all")
                pyDict["label"] = Helpers.ToPython(label);
            if (filled != false)
                pyDict["filled"] = Helpers.ToPython(filled);
            if (impurity != true)
                pyDict["impurity"] = Helpers.ToPython(impurity);
            if (node_ids != false)
                pyDict["node_ids"] = Helpers.ToPython(node_ids);
            if (proportion != false)
                pyDict["proportion"] = Helpers.ToPython(proportion);
            if (rounded != false)
                pyDict["rounded"] = Helpers.ToPython(rounded);
            if (precision != 3)
                pyDict["precision"] = Helpers.ToPython(precision);
            if (ax != null)
                pyDict["ax"] = Helpers.ToPython(ax);
            if (fontsize != null)
                pyDict["fontsize"] = Helpers.ToPython(fontsize);
            var __pyObject = self.InvokeMethod("plot_tree", args, pyDict);
            return new PyTuple(__pyObject);
        }

        public class DecisionTreeClassifier : PythonObject
        {
            public DecisionTreeClassifier(string criterion = "gini", string splitter = "best", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = null, int? random_state = null, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, PyDict? class_weight = null, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
            {
                _ = sklearn.tree.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (criterion != "gini")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (splitter != "best")
                    pyDict["splitter"] = Helpers.ToPython(splitter);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_features != null)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (class_weight != null)
                    pyDict["class_weight"] = Helpers.ToPython(class_weight);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                self = sklearn.tree.self.InvokeMethod("DecisionTreeClassifier", args, pyDict);
            }

            internal DecisionTreeClassifier(PyObject pyObject)
            {
                _ = sklearn.tree.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static DecisionTreeClassifier Encapsule(PyObject pyObject) => new DecisionTreeClassifier(pyObject);
            public static DecisionTreeClassifier Wrap(PyObject pyObject) => new DecisionTreeClassifier(pyObject);
            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_importances_");
                    return new NDarray(__pyObject);
                }
            }

            public int max_features_
            {
                get
                {
                    var __pyObject = self.GetAttr("max_features_");
                    return __pyObject.As<int>();
                }
            }

            public PyTuple n_classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_classes_");
                    return new PyTuple(__pyObject);
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_outputs_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_outputs_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject tree_
            {
                get
                {
                    var __pyObject = self.GetAttr("tree_");
                    return __pyObject;
                }
            }

            public NDarray apply(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("apply", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("cost_complexity_pruning_path", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray decision_path(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("decision_path", args, pyDict);
                return new NDarray(__pyObject);
            }

            public DecisionTreeClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public DecisionTreeClassifier get_depth()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_depth", args, pyDict);
                return this;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public DecisionTreeClassifier get_n_leaves()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_n_leaves", args, pyDict);
                return this;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray predict(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public DecisionTreeClassifier set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public DecisionTreeClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public DecisionTreeClassifier set_predict_proba_request(string? check_input = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("set_predict_proba_request", args, pyDict);
                return this;
            }

            public DecisionTreeClassifier set_predict_request(string? check_input = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("set_predict_request", args, pyDict);
                return this;
            }

            public DecisionTreeClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class DecisionTreeRegressor : PythonObject
        {
            public DecisionTreeRegressor(string criterion = "squared_error", string splitter = "best", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = null, int? random_state = null, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
            {
                _ = sklearn.tree.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (criterion != "squared_error")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (splitter != "best")
                    pyDict["splitter"] = Helpers.ToPython(splitter);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_features != null)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                self = sklearn.tree.self.InvokeMethod("DecisionTreeRegressor", args, pyDict);
            }

            internal DecisionTreeRegressor(PyObject pyObject)
            {
                _ = sklearn.tree.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static DecisionTreeRegressor Encapsule(PyObject pyObject) => new DecisionTreeRegressor(pyObject);
            public static DecisionTreeRegressor Wrap(PyObject pyObject) => new DecisionTreeRegressor(pyObject);
            public NDarray feature_importances_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_importances_");
                    return new NDarray(__pyObject);
                }
            }

            public int max_features_
            {
                get
                {
                    var __pyObject = self.GetAttr("max_features_");
                    return __pyObject.As<int>();
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_outputs_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_outputs_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject tree_
            {
                get
                {
                    var __pyObject = self.GetAttr("tree_");
                    return __pyObject;
                }
            }

            public NDarray apply(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("apply", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("cost_complexity_pruning_path", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray decision_path(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("decision_path", args, pyDict);
                return new NDarray(__pyObject);
            }

            public DecisionTreeRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public DecisionTreeRegressor get_depth()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_depth", args, pyDict);
                return this;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public DecisionTreeRegressor get_n_leaves()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_n_leaves", args, pyDict);
                return this;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray predict(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public DecisionTreeRegressor set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public DecisionTreeRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public DecisionTreeRegressor set_predict_request(string? check_input = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("set_predict_request", args, pyDict);
                return this;
            }

            public DecisionTreeRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class ExtraTreeClassifier : PythonObject
        {
            public ExtraTreeClassifier(string criterion = "gini", string splitter = "random", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, string? max_features = "sqrt", int? random_state = null, int? max_leaf_nodes = null, float min_impurity_decrease = 0.0f, PyDict? class_weight = null, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
            {
                _ = sklearn.tree.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (criterion != "gini")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (splitter != "random")
                    pyDict["splitter"] = Helpers.ToPython(splitter);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_features != "sqrt")
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (class_weight != null)
                    pyDict["class_weight"] = Helpers.ToPython(class_weight);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                self = sklearn.tree.self.InvokeMethod("ExtraTreeClassifier", args, pyDict);
            }

            internal ExtraTreeClassifier(PyObject pyObject)
            {
                _ = sklearn.tree.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ExtraTreeClassifier Encapsule(PyObject pyObject) => new ExtraTreeClassifier(pyObject);
            public static ExtraTreeClassifier Wrap(PyObject pyObject) => new ExtraTreeClassifier(pyObject);
            public NDarray classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("classes_");
                    return new NDarray(__pyObject);
                }
            }

            public int max_features_
            {
                get
                {
                    var __pyObject = self.GetAttr("max_features_");
                    return __pyObject.As<int>();
                }
            }

            public PyTuple n_classes_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_classes_");
                    return new PyTuple(__pyObject);
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_importances_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_outputs_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_outputs_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject tree_
            {
                get
                {
                    var __pyObject = self.GetAttr("tree_");
                    return __pyObject;
                }
            }

            public NDarray apply(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("apply", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("cost_complexity_pruning_path", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray decision_path(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("decision_path", args, pyDict);
                return new NDarray(__pyObject);
            }

            public ExtraTreeClassifier fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public ExtraTreeClassifier get_depth()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_depth", args, pyDict);
                return this;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public ExtraTreeClassifier get_n_leaves()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_n_leaves", args, pyDict);
                return this;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray predict(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_log_proba(NDarray X)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("predict_log_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public NDarray predict_proba(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("predict_proba", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public ExtraTreeClassifier set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public ExtraTreeClassifier set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public ExtraTreeClassifier set_predict_proba_request(string? check_input = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("set_predict_proba_request", args, pyDict);
                return this;
            }

            public ExtraTreeClassifier set_predict_request(string? check_input = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("set_predict_request", args, pyDict);
                return this;
            }

            public ExtraTreeClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }

        public class ExtraTreeRegressor : PythonObject
        {
            public ExtraTreeRegressor(string criterion = "squared_error", string splitter = "random", int? max_depth = null, int min_samples_split = 2, int min_samples_leaf = 1, float min_weight_fraction_leaf = 0.0f, float? max_features = 1.0f, int? random_state = null, float min_impurity_decrease = 0.0f, int? max_leaf_nodes = null, float ccp_alpha = 0.0f, NDarray? monotonic_cst = null)
            {
                _ = sklearn.tree.self;
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (criterion != "squared_error")
                    pyDict["criterion"] = Helpers.ToPython(criterion);
                if (splitter != "random")
                    pyDict["splitter"] = Helpers.ToPython(splitter);
                if (max_depth != null)
                    pyDict["max_depth"] = Helpers.ToPython(max_depth);
                if (min_samples_split != 2)
                    pyDict["min_samples_split"] = Helpers.ToPython(min_samples_split);
                if (min_samples_leaf != 1)
                    pyDict["min_samples_leaf"] = Helpers.ToPython(min_samples_leaf);
                if (min_weight_fraction_leaf != 0.0f)
                    pyDict["min_weight_fraction_leaf"] = Helpers.ToPython(min_weight_fraction_leaf);
                if (max_features != 1.0f)
                    pyDict["max_features"] = Helpers.ToPython(max_features);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (min_impurity_decrease != 0.0f)
                    pyDict["min_impurity_decrease"] = Helpers.ToPython(min_impurity_decrease);
                if (max_leaf_nodes != null)
                    pyDict["max_leaf_nodes"] = Helpers.ToPython(max_leaf_nodes);
                if (ccp_alpha != 0.0f)
                    pyDict["ccp_alpha"] = Helpers.ToPython(ccp_alpha);
                if (monotonic_cst != null)
                    pyDict["monotonic_cst"] = Helpers.ToPython(monotonic_cst);
                self = sklearn.tree.self.InvokeMethod("ExtraTreeRegressor", args, pyDict);
            }

            internal ExtraTreeRegressor(PyObject pyObject)
            {
                _ = sklearn.tree.self;
                self = pyObject;
            }

            [Obsolete("Encapsule is deprecated. Use Wrap instead.")]
            public static ExtraTreeRegressor Encapsule(PyObject pyObject) => new ExtraTreeRegressor(pyObject);
            public static ExtraTreeRegressor Wrap(PyObject pyObject) => new ExtraTreeRegressor(pyObject);
            public int max_features_
            {
                get
                {
                    var __pyObject = self.GetAttr("max_features_");
                    return __pyObject.As<int>();
                }
            }

            public int n_features_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_features_in_");
                    return __pyObject.As<int>();
                }
            }

            public NDarray feature_names_in_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_names_in_");
                    return new NDarray(__pyObject);
                }
            }

            public NDarray feature_importances_
            {
                get
                {
                    var __pyObject = self.GetAttr("feature_importances_");
                    return new NDarray(__pyObject);
                }
            }

            public int n_outputs_
            {
                get
                {
                    var __pyObject = self.GetAttr("n_outputs_");
                    return __pyObject.As<int>();
                }
            }

            public PyObject tree_
            {
                get
                {
                    var __pyObject = self.GetAttr("tree_");
                    return __pyObject;
                }
            }

            public NDarray apply(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("apply", args, pyDict);
                return new NDarray(__pyObject);
            }

            public PyDict cost_complexity_pruning_path(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("cost_complexity_pruning_path", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray decision_path(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("decision_path", args, pyDict);
                return new NDarray(__pyObject);
            }

            public ExtraTreeRegressor fit(NDarray X, NDarray y, NDarray? sample_weight = null, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("fit", args, pyDict);
                return this;
            }

            public ExtraTreeRegressor get_depth()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_depth", args, pyDict);
                return this;
            }

            public PyObject get_metadata_routing()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                var __pyObject = self.InvokeMethod("get_metadata_routing", args, pyDict);
                return __pyObject;
            }

            public ExtraTreeRegressor get_n_leaves()
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                self.InvokeMethod("get_n_leaves", args, pyDict);
                return this;
            }

            public PyDict get_params(bool deep = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (deep != true)
                    pyDict["deep"] = Helpers.ToPython(deep);
                var __pyObject = self.InvokeMethod("get_params", args, pyDict);
                return new PyDict(__pyObject);
            }

            public NDarray predict(NDarray X, bool check_input = true)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X) });
                PyDict pyDict = new PyDict();
                if (check_input != true)
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                var __pyObject = self.InvokeMethod("predict", args, pyDict);
                return new NDarray(__pyObject);
            }

            public float score(NDarray X, NDarray y, NDarray? sample_weight = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { Helpers.ToPython(X), Helpers.ToPython(y) });
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                var __pyObject = self.InvokeMethod("score", args, pyDict);
                return __pyObject.As<float>();
            }

            public ExtraTreeRegressor set_fit_request(string? check_input = "$UNCHANGED$", string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_fit_request", args, pyDict);
                return this;
            }

            public ExtraTreeRegressor set_params(Dictionary<string, PyObject>? @params = null)
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                self.InvokeMethod("set_params", args, pyDict);
                return this;
            }

            public ExtraTreeRegressor set_predict_request(string? check_input = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (check_input != "$UNCHANGED$")
                    pyDict["check_input"] = Helpers.ToPython(check_input);
                self.InvokeMethod("set_predict_request", args, pyDict);
                return this;
            }

            public ExtraTreeRegressor set_score_request(string? sample_weight = "$UNCHANGED$")
            {
                PyTuple args = new PyTuple(new PyObject[] { });
                PyDict pyDict = new PyDict();
                if (sample_weight != "$UNCHANGED$")
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                self.InvokeMethod("set_score_request", args, pyDict);
                return this;
            }
        }
    }
}