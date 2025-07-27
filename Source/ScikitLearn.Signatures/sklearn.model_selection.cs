using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class model_selection
    {
        // Methods
        public static PyObject check_cv(int? cv = 5, NDarray? y = null, bool classifier = false) => default!;
        public static NDarray train_test_split(NDarray[] arrays, float? test_size = null, float? train_size = null, int? random_state = null, bool shuffle = true, NDarray? stratify = null) => default!;
        public static PyDict ParameterSampler(PyDict param_distributions, int n_iter, int? random_state = null) => default!;
        public static PyDict cross_val_predict(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", string method = "predict") => default!;
        public static NDarray cross_val_score(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, string? scoring = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", PyObject? error_score = null) => default!;
        public static PyDict cross_validate(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, PyDict? scoring = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", bool return_train_score = false, bool return_estimator = false, bool return_indices = false, PyObject? error_score = null) => default!;
        public static (NDarray?, NDarray?, NDarray?, NDarray?, NDarray?) learning_curve(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, NDarray? train_sizes = null, int? cv = null, string? scoring = null, bool exploit_incremental_learning = false, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, bool shuffle = false, int? random_state = null, PyObject? error_score = null, bool return_times = false, PyDict? fit_params = null) => default!;
        public static (float?, NDarray?, float?) permutation_test_score(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, int? cv = null, int n_permutations = 100, int? n_jobs = null, int? random_state = 0, int verbose = 0, string? scoring = null, PyDict? fit_params = null) => default!;
        public static (NDarray?, NDarray?) validation_curve(PyObject estimator, NDarray X, NDarray y, string param_name, NDarray param_range, NDarray? groups = null, int? cv = null, string? scoring = null, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, PyObject? error_score = null, PyDict? fit_params = null) => default!;
        // Classes
        public class GroupKFold : PythonObject
        {
            // Constructor
            public GroupKFold(int n_splits = 5)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            [ReturnThis]
            public GroupKFold set_split_request(string? groups = "$UNCHANGED$") => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, NDarray? groups = null) => default!;
        }

        public class GroupShuffleSplit : PythonObject
        {
            // Constructor
            public GroupShuffleSplit(int n_splits = 5, float? test_size = null, float? train_size = null, int? random_state = null)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            [ReturnThis]
            public GroupShuffleSplit set_split_request(string? groups = "$UNCHANGED$") => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, NDarray? groups = null) => default!;
        }

        public class KFold : PythonObject
        {
            // Constructor
            public KFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, PyObject? groups = null) => default!;
        }

        public class LeaveOneGroupOut : PythonObject
        {
            // Constructor
            public LeaveOneGroupOut()
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null) => default!;
            [ReturnThis]
            public LeaveOneGroupOut set_split_request(string? groups = "$UNCHANGED$") => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, NDarray? groups = null) => default!;
        }

        public class LeaveOneOut : PythonObject
        {
            // Constructor
            public LeaveOneOut()
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(NDarray X, PyObject? y = null, PyObject? groups = null) => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, PyObject? groups = null) => default!;
        }

        public class LeavePGroupsOut : PythonObject
        {
            // Constructor
            public LeavePGroupsOut(int n_groups)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null) => default!;
            [ReturnThis]
            public LeavePGroupsOut set_split_request(string? groups = "$UNCHANGED$") => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, NDarray? groups = null) => default!;
        }

        public class LeavePOut : PythonObject
        {
            // Constructor
            public LeavePOut(int p)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public void get_n_splits(NDarray X, PyObject? y = null, PyObject? groups = null)
            {
            }

            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, PyObject? groups = null) => default!;
        }

        public class PredefinedSplit : PythonObject
        {
            // Constructor
            public PredefinedSplit(NDarray test_fold)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            public (NDarray?, NDarray?) split(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
        }

        public class RepeatedKFold : PythonObject
        {
            // Constructor
            public RepeatedKFold(int n_splits = 5, int n_repeats = 10, int? random_state = null)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null) => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, PyObject? groups = null) => default!;
        }

        public class RepeatedStratifiedKFold : PythonObject
        {
            // Constructor
            public RepeatedStratifiedKFold(int n_splits = 5, int n_repeats = 10, int? random_state = null)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null) => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, PyObject? groups = null) => default!;
        }

        public class ShuffleSplit : PythonObject
        {
            // Constructor
            public ShuffleSplit(int n_splits = 10, float? test_size = null, float? train_size = null, int? random_state = null)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, PyObject? groups = null) => default!;
        }

        public class StratifiedGroupKFold : PythonObject
        {
            // Constructor
            public StratifiedGroupKFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            [ReturnThis]
            public StratifiedGroupKFold set_split_request(string? groups = "$UNCHANGED$") => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, NDarray? groups = null) => default!;
        }

        public class StratifiedKFold : PythonObject
        {
            // Constructor
            public StratifiedKFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray y, PyObject? groups = null) => default!;
        }

        public class StratifiedShuffleSplit : PythonObject
        {
            // Constructor
            public StratifiedShuffleSplit(int n_splits = 10, float? test_size = null, float? train_size = null, int? random_state = null)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray y, PyObject? groups = null) => default!;
        }

        public class TimeSeriesSplit : PythonObject
        {
            // Constructor
            public TimeSeriesSplit(int n_splits = 5, int? max_train_size = null, int? test_size = null, int gap = 0)
            {
            }

            // Methods
            public PyObject get_metadata_routing() => default!;
            public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null) => default!;
            public (NDarray?, NDarray?) split(NDarray X, NDarray? y = null, NDarray? groups = null) => default!;
        }

        public class GridSearchCV : PythonObject
        {
            // Constructor
            public GridSearchCV(PyObject estimator, PyDict param_grid, PyDict? scoring = null, int? n_jobs = null, bool refit = true, int? cv = null, int verbose = 0, string pre_dispatch = "2*n_jobs", PyObject? error_score = null, bool return_train_score = false)
            {
            }

            // Properties
            public PyDict cv_results_ => default!;
            public PyObject best_estimator_ => default!;
            public float best_score_ => default!;
            public PyDict best_params_ => default!;
            public int best_index_ => default!;
            public PyDict scorer_ => default!;
            public int n_splits_ => default!;
            public float refit_time_ => default!;
            public bool multimetric_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(PyObject X) => default!;
            [ReturnThis]
            public GridSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null) => default!;
            public NDarray predict(PyObject X) => default!;
            public NDarray predict_log_proba(PyObject X) => default!;
            public NDarray predict_proba(PyObject X) => default!;
            public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray score_samples(PyObject X) => default!;
            [ReturnThis]
            public GridSearchCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(PyObject X) => default!;
        }

        public class HalvingGridSearchCV : PythonObject
        {
            // Constructor
            public HalvingGridSearchCV(PyObject estimator, PyDict param_grid, int factor = 3, string resource = "n_samples", string max_resources = "auto", string min_resources = "exhaust", bool aggressive_elimination = false, int cv = 5, string? scoring = null, bool refit = true, PyObject? error_score = null, bool return_train_score = true, int? random_state = null, int? n_jobs = null, int verbose = 0)
            {
            }

            // Properties
            public PyTuple n_resources_ => default!;
            public PyTuple n_candidates_ => default!;
            public int n_remaining_candidates_ => default!;
            public int max_resources_ => default!;
            public int min_resources_ => default!;
            public int n_iterations_ => default!;
            public int n_possible_iterations_ => default!;
            public int n_required_iterations_ => default!;
            public PyDict cv_results_ => default!;
            public PyDict best_estimator_ => default!;
            public float best_score_ => default!;
            public PyDict best_params_ => default!;
            public int best_index_ => default!;
            public PyDict scorer_ => default!;
            public int n_splits_ => default!;
            public float refit_time_ => default!;
            public bool multimetric_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(PyObject X) => default!;
            [ReturnThis]
            public HalvingGridSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null) => default!;
            public NDarray predict(PyObject X) => default!;
            public NDarray predict_log_proba(PyObject X) => default!;
            public NDarray predict_proba(PyObject X) => default!;
            public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray score_samples(PyObject X) => default!;
            [ReturnThis]
            public HalvingGridSearchCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(PyObject X) => default!;
        }

        public class HalvingRandomSearchCV : PythonObject
        {
            // Constructor
            public HalvingRandomSearchCV(PyObject estimator, PyDict param_distributions, string n_candidates = "exhaust", int factor = 3, string resource = "n_samples", string max_resources = "auto", string min_resources = "smallest", bool aggressive_elimination = false, int cv = 5, string? scoring = null, bool refit = true, PyObject? error_score = null, bool return_train_score = true, int? random_state = null, int? n_jobs = null, int verbose = 0)
            {
            }

            // Properties
            public PyTuple n_resources_ => default!;
            public PyTuple n_candidates_ => default!;
            public int n_remaining_candidates_ => default!;
            public int max_resources_ => default!;
            public int min_resources_ => default!;
            public int n_iterations_ => default!;
            public int n_possible_iterations_ => default!;
            public int n_required_iterations_ => default!;
            public PyDict cv_results_ => default!;
            public PyDict best_estimator_ => default!;
            public float best_score_ => default!;
            public PyDict best_params_ => default!;
            public int best_index_ => default!;
            public PyDict scorer_ => default!;
            public int n_splits_ => default!;
            public float refit_time_ => default!;
            public bool multimetric_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(PyObject X) => default!;
            [ReturnThis]
            public HalvingRandomSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null) => default!;
            public NDarray predict(PyObject X) => default!;
            public NDarray predict_log_proba(PyObject X) => default!;
            public NDarray predict_proba(PyObject X) => default!;
            public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray score_samples(PyObject X) => default!;
            [ReturnThis]
            public HalvingRandomSearchCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(PyObject X) => default!;
        }

        public class ParameterGrid : PythonObject
        {
            // Constructor
            public ParameterGrid(PyDict param_grid)
            {
            }
        }

        public class RandomizedSearchCV : PythonObject
        {
            // Constructor
            public RandomizedSearchCV(PyObject estimator, PyDict param_distributions, int n_iter = 10, PyDict? scoring = null, int? n_jobs = null, bool refit = true, int? cv = null, int verbose = 0, string pre_dispatch = "2*n_jobs", int? random_state = null, PyObject? error_score = null, bool return_train_score = false)
            {
            }

            // Properties
            public PyDict cv_results_ => default!;
            public PyObject best_estimator_ => default!;
            public float best_score_ => default!;
            public PyDict best_params_ => default!;
            public int best_index_ => default!;
            public PyDict scorer_ => default!;
            public int n_splits_ => default!;
            public float refit_time_ => default!;
            public bool multimetric_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(PyObject X) => default!;
            [ReturnThis]
            public RandomizedSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null) => default!;
            public NDarray predict(PyObject X) => default!;
            public NDarray predict_log_proba(PyObject X) => default!;
            public NDarray predict_proba(PyObject X) => default!;
            public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray score_samples(PyObject X) => default!;
            [ReturnThis]
            public RandomizedSearchCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            public NDarray transform(PyObject X) => default!;
        }

        public class FixedThresholdClassifier : PythonObject
        {
            // Constructor
            public FixedThresholdClassifier(PyObject estimator, string threshold = "auto", string? pos_label = null, string response_method = "auto")
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public FixedThresholdClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public FixedThresholdClassifier set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public FixedThresholdClassifier set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class TunedThresholdClassifierCV : PythonObject
        {
            // Constructor
            public TunedThresholdClassifierCV(PyObject estimator, string scoring = "balanced_accuracy", string response_method = "auto", int thresholds = 100, float? cv = null, bool refit = true, int? n_jobs = null, int? random_state = null, bool store_cv_results = false)
            {
            }

            // Properties
            public PyObject estimator_ => default!;
            public float best_threshold_ => default!;
            public float best_score_ => default!;
            public PyDict cv_results_ => default!;
            public NDarray classes_ => default!;
            public int n_features_in_ => default!;
            public NDarray feature_names_in_ => default!;

            // Methods
            public NDarray decision_function(NDarray X) => default!;
            [ReturnThis]
            public TunedThresholdClassifierCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null) => default!;
            public PyObject get_metadata_routing() => default!;
            public PyDict get_params(bool deep = true) => default!;
            public NDarray predict(NDarray X) => default!;
            public NDarray predict_log_proba(NDarray X) => default!;
            public NDarray predict_proba(NDarray X) => default!;
            public float score(NDarray X, NDarray y, NDarray? sample_weight = null) => default!;
            [ReturnThis]
            public TunedThresholdClassifierCV set_params(Dictionary<string, PyObject>? @params = null) => default!;
            [ReturnThis]
            public TunedThresholdClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$") => default!;
        }

        public class LearningCurveDisplay : PythonObject
        {
            // Constructor
            public LearningCurveDisplay(NDarray train_sizes, NDarray train_scores, NDarray test_scores, string? score_name = null)
            {
            }

            // Properties
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;
            public PyTuple errorbar_ => default!;
            public PyTuple lines_ => default!;
            public PyTuple fill_between_ => default!;

            // Methods
            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, NDarray? train_sizes = null, int? cv = null, string? scoring = null, bool exploit_incremental_learning = false, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, bool shuffle = false, int? random_state = null, PyObject? error_score = null, PyDict? fit_params = null, PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null) => default!;
            public PyObject plot(PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null) => default!;
        }

        public class ValidationCurveDisplay : PythonObject
        {
            // Constructor
            public ValidationCurveDisplay(string param_name, NDarray param_range, NDarray train_scores, NDarray test_scores, string? score_name = null)
            {
            }

            // Properties
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;
            public PyTuple errorbar_ => default!;
            public PyTuple lines_ => default!;
            public PyTuple fill_between_ => default!;

            // Methods
            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, string param_name, NDarray param_range, NDarray? groups = null, int? cv = null, string? scoring = null, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, PyObject? error_score = null, PyDict? fit_params = null, PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null) => default!;
            public PyObject plot(PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null) => default!;
        }
    }
}