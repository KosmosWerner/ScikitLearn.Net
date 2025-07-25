using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class model_selection
        {
            public static PyObject check_cv(int? cv = 5, NDarray? y = null, bool classifier = false)
            {
                throw new NotImplementedException();
            }

            public static NDarray train_test_split(NDarray[] arrays, float? test_size = null, float? train_size = null, int? random_state = null, bool shuffle = true, NDarray? stratify = null)
            {
                throw new NotImplementedException();
            }

            public static PyDict ParameterSampler(PyDict param_distributions, int n_iter, int? random_state = null)
            {
                throw new NotImplementedException();
            }

            public static PyDict cross_val_predict(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", string method = "predict")
            {
                throw new NotImplementedException();
            }

            public static NDarray cross_val_score(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, string? scoring = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", PyObject? error_score = null)
            {
                throw new NotImplementedException();
            }

            public static PyDict cross_validate(PyObject estimator, NDarray X, NDarray? y = null, NDarray? groups = null, PyDict? scoring = null, int? cv = null, int? n_jobs = null, int verbose = 0, PyDict? fit_params = null, PyDict? @params = null, string pre_dispatch = "2*n_jobs", bool return_train_score = false, bool return_estimator = false, bool return_indices = false, PyObject? error_score = null)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , NDarray? , NDarray? , NDarray? , NDarray? ) learning_curve(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, NDarray? train_sizes = null, int? cv = null, string? scoring = null, bool exploit_incremental_learning = false, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, bool shuffle = false, int? random_state = null, PyObject? error_score = null, bool return_times = false, PyDict? fit_params = null)
            {
                throw new NotImplementedException();
            }

            public static (float? , NDarray? , float? ) permutation_test_score(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, int? cv = null, int n_permutations = 100, int? n_jobs = null, int? random_state = 0, int verbose = 0, string? scoring = null, PyDict? fit_params = null)
            {
                throw new NotImplementedException();
            }

            public static (NDarray? , NDarray? ) validation_curve(PyObject estimator, NDarray X, NDarray y, string param_name, NDarray param_range, NDarray? groups = null, int? cv = null, string? scoring = null, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, PyObject? error_score = null, PyDict? fit_params = null)
            {
                throw new NotImplementedException();
            }

            public class GroupKFold
            {
                public GroupKFold(int n_splits = 5)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public GroupKFold set_split_request(string? groups = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class GroupShuffleSplit
            {
                public GroupShuffleSplit(int n_splits = 5, float? test_size = null, float? train_size = null, int? random_state = null)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public GroupShuffleSplit set_split_request(string? groups = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class KFold
            {
                public KFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class LeaveOneGroupOut
            {
                public LeaveOneGroupOut()
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }

                public LeaveOneGroupOut set_split_request(string? groups = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class LeaveOneOut
            {
                public LeaveOneOut()
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(NDarray X, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class LeavePGroupsOut
            {
                public LeavePGroupsOut(int n_groups)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }

                public LeavePGroupsOut set_split_request(string? groups = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class LeavePOut
            {
                public LeavePOut(int p)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public void get_n_splits(NDarray X, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class PredefinedSplit
            {
                public PredefinedSplit(NDarray test_fold)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class RepeatedKFold
            {
                public RepeatedKFold(int n_splits = 5, int n_repeats = 10, int? random_state = null)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class RepeatedStratifiedKFold
            {
                public RepeatedStratifiedKFold(int n_splits = 5, int n_repeats = 10, int? random_state = null)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class ShuffleSplit
            {
                public ShuffleSplit(int n_splits = 10, float? test_size = null, float? train_size = null, int? random_state = null)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class StratifiedGroupKFold
            {
                public StratifiedGroupKFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public StratifiedGroupKFold set_split_request(string? groups = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class StratifiedKFold
            {
                public StratifiedKFold(int n_splits = 5, bool shuffle = false, int? random_state = null)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray y, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class StratifiedShuffleSplit
            {
                public StratifiedShuffleSplit(int n_splits = 10, float? test_size = null, float? train_size = null, int? random_state = null)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray y, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class TimeSeriesSplit
            {
                public TimeSeriesSplit(int n_splits = 5, int? max_train_size = null, int? test_size = null, int gap = 0)
                {
                }

                public PyObject get_metadata_routing()
                {
                    throw new NotImplementedException();
                }

                public int get_n_splits(PyObject? X = null, PyObject? y = null, PyObject? groups = null)
                {
                    throw new NotImplementedException();
                }

                public (NDarray? , NDarray? ) split(NDarray X, NDarray? y = null, NDarray? groups = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class GridSearchCV
            {
                public GridSearchCV(PyObject estimator, PyDict param_grid, PyDict? scoring = null, int? n_jobs = null, bool refit = true, int? cv = null, int verbose = 0, string pre_dispatch = "2*n_jobs", PyObject? error_score = null, bool return_train_score = false)
                {
                }

                public PyDict cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public PyObject best_estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("best_estimator_"));
                public float best_score_ => Helpers.ToCSharpNDarray(self.GetAttr("best_score_"));
                public PyDict best_params_ => Helpers.ToCSharpNDarray(self.GetAttr("best_params_"));
                public int best_index_ => Helpers.ToCSharpNDarray(self.GetAttr("best_index_"));
                public PyDict scorer_ => Helpers.ToCSharpNDarray(self.GetAttr("scorer_"));
                public int n_splits_ => Helpers.ToCSharpNDarray(self.GetAttr("n_splits_"));
                public float refit_time_ => Helpers.ToCSharpNDarray(self.GetAttr("refit_time_"));
                public bool multimetric_ => Helpers.ToCSharpNDarray(self.GetAttr("multimetric_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public GridSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

                public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public GridSearchCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(PyObject X)
                {
                    throw new NotImplementedException();
                }
            }

            public class HalvingGridSearchCV
            {
                public HalvingGridSearchCV(PyObject estimator, PyDict param_grid, int factor = 3, string resource = "n_samples", string max_resources = "auto", string min_resources = "exhaust", bool aggressive_elimination = false, int cv = 5, string? scoring = null, bool refit = true, PyObject? error_score = null, bool return_train_score = true, int? random_state = null, int? n_jobs = null, int verbose = 0)
                {
                }

                public PyTuple n_resources_ => Helpers.ToCSharpNDarray(self.GetAttr("n_resources_"));
                public PyTuple n_candidates_ => Helpers.ToCSharpNDarray(self.GetAttr("n_candidates_"));
                public int n_remaining_candidates_ => Helpers.ToCSharpNDarray(self.GetAttr("n_remaining_candidates_"));
                public int max_resources_ => Helpers.ToCSharpNDarray(self.GetAttr("max_resources_"));
                public int min_resources_ => Helpers.ToCSharpNDarray(self.GetAttr("min_resources_"));
                public int n_iterations_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iterations_"));
                public int n_possible_iterations_ => Helpers.ToCSharpNDarray(self.GetAttr("n_possible_iterations_"));
                public int n_required_iterations_ => Helpers.ToCSharpNDarray(self.GetAttr("n_required_iterations_"));
                public PyDict cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public PyDict best_estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("best_estimator_"));
                public float best_score_ => Helpers.ToCSharpNDarray(self.GetAttr("best_score_"));
                public PyDict best_params_ => Helpers.ToCSharpNDarray(self.GetAttr("best_params_"));
                public int best_index_ => Helpers.ToCSharpNDarray(self.GetAttr("best_index_"));
                public PyDict scorer_ => Helpers.ToCSharpNDarray(self.GetAttr("scorer_"));
                public int n_splits_ => Helpers.ToCSharpNDarray(self.GetAttr("n_splits_"));
                public float refit_time_ => Helpers.ToCSharpNDarray(self.GetAttr("refit_time_"));
                public bool multimetric_ => Helpers.ToCSharpNDarray(self.GetAttr("multimetric_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public HalvingGridSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

                public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public HalvingGridSearchCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(PyObject X)
                {
                    throw new NotImplementedException();
                }
            }

            public class HalvingRandomSearchCV
            {
                public HalvingRandomSearchCV(PyObject estimator, PyDict param_distributions, string n_candidates = "exhaust", int factor = 3, string resource = "n_samples", string max_resources = "auto", string min_resources = "smallest", bool aggressive_elimination = false, int cv = 5, string? scoring = null, bool refit = true, PyObject? error_score = null, bool return_train_score = true, int? random_state = null, int? n_jobs = null, int verbose = 0)
                {
                }

                public PyTuple n_resources_ => Helpers.ToCSharpNDarray(self.GetAttr("n_resources_"));
                public PyTuple n_candidates_ => Helpers.ToCSharpNDarray(self.GetAttr("n_candidates_"));
                public int n_remaining_candidates_ => Helpers.ToCSharpNDarray(self.GetAttr("n_remaining_candidates_"));
                public int max_resources_ => Helpers.ToCSharpNDarray(self.GetAttr("max_resources_"));
                public int min_resources_ => Helpers.ToCSharpNDarray(self.GetAttr("min_resources_"));
                public int n_iterations_ => Helpers.ToCSharpNDarray(self.GetAttr("n_iterations_"));
                public int n_possible_iterations_ => Helpers.ToCSharpNDarray(self.GetAttr("n_possible_iterations_"));
                public int n_required_iterations_ => Helpers.ToCSharpNDarray(self.GetAttr("n_required_iterations_"));
                public PyDict cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public PyDict best_estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("best_estimator_"));
                public float best_score_ => Helpers.ToCSharpNDarray(self.GetAttr("best_score_"));
                public PyDict best_params_ => Helpers.ToCSharpNDarray(self.GetAttr("best_params_"));
                public int best_index_ => Helpers.ToCSharpNDarray(self.GetAttr("best_index_"));
                public PyDict scorer_ => Helpers.ToCSharpNDarray(self.GetAttr("scorer_"));
                public int n_splits_ => Helpers.ToCSharpNDarray(self.GetAttr("n_splits_"));
                public float refit_time_ => Helpers.ToCSharpNDarray(self.GetAttr("refit_time_"));
                public bool multimetric_ => Helpers.ToCSharpNDarray(self.GetAttr("multimetric_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public HalvingRandomSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

                public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public HalvingRandomSearchCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(PyObject X)
                {
                    throw new NotImplementedException();
                }
            }

            public class ParameterGrid
            {
                public ParameterGrid(PyDict param_grid)
                {
                }
            }

            public class RandomizedSearchCV
            {
                public RandomizedSearchCV(PyObject estimator, PyDict param_distributions, int n_iter = 10, PyDict? scoring = null, int? n_jobs = null, bool refit = true, int? cv = null, int verbose = 0, string pre_dispatch = "2*n_jobs", int? random_state = null, PyObject? error_score = null, bool return_train_score = false)
                {
                }

                public PyDict cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public PyObject best_estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("best_estimator_"));
                public float best_score_ => Helpers.ToCSharpNDarray(self.GetAttr("best_score_"));
                public PyDict best_params_ => Helpers.ToCSharpNDarray(self.GetAttr("best_params_"));
                public int best_index_ => Helpers.ToCSharpNDarray(self.GetAttr("best_index_"));
                public PyDict scorer_ => Helpers.ToCSharpNDarray(self.GetAttr("scorer_"));
                public int n_splits_ => Helpers.ToCSharpNDarray(self.GetAttr("n_splits_"));
                public float refit_time_ => Helpers.ToCSharpNDarray(self.GetAttr("refit_time_"));
                public bool multimetric_ => Helpers.ToCSharpNDarray(self.GetAttr("multimetric_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public RandomizedSearchCV fit(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
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

                public NDarray inverse_transform(PyObject? X = null, PyObject? Xt = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_log_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public NDarray predict_proba(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public float score(NDarray X, NDarray? y = null, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray score_samples(PyObject X)
                {
                    throw new NotImplementedException();
                }

                public RandomizedSearchCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public NDarray transform(PyObject X)
                {
                    throw new NotImplementedException();
                }
            }

            public class FixedThresholdClassifier
            {
                public FixedThresholdClassifier(PyObject estimator, string threshold = "auto", string? pos_label = null, string response_method = "auto")
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public FixedThresholdClassifier fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
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

                public FixedThresholdClassifier set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public FixedThresholdClassifier set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class TunedThresholdClassifierCV
            {
                public TunedThresholdClassifierCV(PyObject estimator, string scoring = "balanced_accuracy", string response_method = "auto", int thresholds = 100, float? cv = null, bool refit = true, int? n_jobs = null, int? random_state = null, bool store_cv_results = false)
                {
                }

                public PyObject estimator_ => Helpers.ToCSharpNDarray(self.GetAttr("estimator_"));
                public float best_threshold_ => Helpers.ToCSharpNDarray(self.GetAttr("best_threshold_"));
                public float best_score_ => Helpers.ToCSharpNDarray(self.GetAttr("best_score_"));
                public PyDict cv_results_ => Helpers.ToCSharpNDarray(self.GetAttr("cv_results_"));
                public NDarray classes_ => Helpers.ToCSharpNDarray(self.GetAttr("classes_"));
                public int n_features_in_ => Helpers.ToCSharpNDarray(self.GetAttr("n_features_in_"));
                public NDarray feature_names_in_ => Helpers.ToCSharpNDarray(self.GetAttr("feature_names_in_"));

                public NDarray decision_function(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public TunedThresholdClassifierCV fit(NDarray X, NDarray y, Dictionary<string, PyObject>? @params = null)
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

                public TunedThresholdClassifierCV set_params(Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public TunedThresholdClassifierCV set_score_request(string? sample_weight = "$UNCHANGED$")
                {
                    throw new NotImplementedException();
                }
            }

            public class LearningCurveDisplay
            {
                public LearningCurveDisplay(NDarray train_sizes, NDarray train_scores, NDarray test_scores, string? score_name = null)
                {
                }

                public PyObject ax_ => Helpers.ToCSharpNDarray(self.GetAttr("ax_"));
                public PyObject figure_ => Helpers.ToCSharpNDarray(self.GetAttr("figure_"));
                public PyTuple errorbar_ => Helpers.ToCSharpNDarray(self.GetAttr("errorbar_"));
                public PyTuple lines_ => Helpers.ToCSharpNDarray(self.GetAttr("lines_"));
                public PyTuple fill_between_ => Helpers.ToCSharpNDarray(self.GetAttr("fill_between_"));

                public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? groups = null, NDarray? train_sizes = null, int? cv = null, string? scoring = null, bool exploit_incremental_learning = false, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, bool shuffle = false, int? random_state = null, PyObject? error_score = null, PyDict? fit_params = null, PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject plot(PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null)
                {
                    throw new NotImplementedException();
                }
            }

            public class ValidationCurveDisplay
            {
                public ValidationCurveDisplay(string param_name, NDarray param_range, NDarray train_scores, NDarray test_scores, string? score_name = null)
                {
                }

                public PyObject ax_ => Helpers.ToCSharpNDarray(self.GetAttr("ax_"));
                public PyObject figure_ => Helpers.ToCSharpNDarray(self.GetAttr("figure_"));
                public PyTuple errorbar_ => Helpers.ToCSharpNDarray(self.GetAttr("errorbar_"));
                public PyTuple lines_ => Helpers.ToCSharpNDarray(self.GetAttr("lines_"));
                public PyTuple fill_between_ => Helpers.ToCSharpNDarray(self.GetAttr("fill_between_"));

                public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, string param_name, NDarray param_range, NDarray? groups = null, int? cv = null, string? scoring = null, int? n_jobs = null, string pre_dispatch = "all", int verbose = 0, PyObject? error_score = null, PyDict? fit_params = null, PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null)
                {
                    throw new NotImplementedException();
                }

                public PyObject plot(PyObject? ax = null, bool negate_score = false, string? score_name = null, string score_type = "both", string? std_display_style = "fill_between", PyDict? line_kw = null, PyDict? fill_between_kw = null, PyDict? errorbar_kw = null)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}