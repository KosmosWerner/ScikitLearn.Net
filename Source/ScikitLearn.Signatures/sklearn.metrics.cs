using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class metrics
    {
        // Methods
        [NeedsRevision]
        public static PyObject check_scoring(
            @base.BaseEstimator? estimator = null,
            [OneOf<string, PyObject>] object? scoring = null,
            bool allow_none = false,
            bool raise_exc = true) => default!;
        [NeedsRevision]
        public static PyObject get_scorer(
            [OneOf<string, PyObject>] object? scoring) => default!;

        public static string[] get_scorer_names() => default!;
        [NeedsRevision]
        public static PyObject make_scorer(PyObject score_func, PyDict? response_method = null, bool greater_is_better = true, string needs_proba = "deprecated", string needs_threshold = "deprecated", params (string key, object value)[] @params) => default!;



        public static float accuracy_score(NDarray y_true, NDarray y_pred, bool normalize = true, NDarray? sample_weight = null) => default!;
        public static float auc(NDarray x, NDarray y) => default!;
        public static float average_precision_score(NDarray y_true, NDarray y_score, string? average = "macro", int pos_label = 1, NDarray? sample_weight = null) => default!;
        public static float balanced_accuracy_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, bool adjusted = false) => default!;
        public static float brier_score_loss(NDarray y_true, NDarray? y_proba = null, NDarray? sample_weight = null, string? pos_label = null, string y_prob = "deprecated") => default!;
        public static PyTuple class_likelihood_ratios(NDarray y_true, NDarray y_pred, NDarray? labels = null, NDarray? sample_weight = null, bool raise_warning = true) => default!;
        public static PyDict classification_report(NDarray y_true, NDarray y_pred, NDarray? labels = null, NDarray? target_names = null, NDarray? sample_weight = null, int digits = 2, bool output_dict = false, string zero_division = "warn") => default!;
        public static float cohen_kappa_score(NDarray y1, NDarray y2, NDarray? labels = null, PyObject? weights = null, NDarray? sample_weight = null) => default!;
        public static NDarray confusion_matrix(NDarray y_true, NDarray y_pred, NDarray? labels = null, NDarray? sample_weight = null, PyObject? normalize = null) => default!;
        public static NDarray d2_log_loss_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, NDarray? labels = null) => default!;
        public static float dcg_score(NDarray y_true, NDarray y_score, int? k = null, int log_base = 2, NDarray? sample_weight = null, bool ignore_ties = false) => default!;
        public static (NDarray?, NDarray?, NDarray?) det_curve(NDarray y_true, NDarray y_score, string? pos_label = null, NDarray? sample_weight = null) => default!;
        public static NDarray f1_score(NDarray y_true, NDarray y_pred, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn") => default!;
        public static NDarray? fbeta_score(NDarray y_true, NDarray y_pred, float beta, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn") => default!;
        public static float hamming_loss(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null) => default!;
        public static float hinge_loss(NDarray y_true, NDarray pred_decision, NDarray? labels = null, NDarray? sample_weight = null) => default!;
        public static NDarray jaccard_score(NDarray y_true, NDarray y_pred, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn") => default!;
        public static float log_loss(NDarray y_true, NDarray y_pred, bool normalize = true, NDarray? sample_weight = null, NDarray? labels = null) => default!;
        public static float matthews_corrcoef(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null) => default!;
        public static NDarray multilabel_confusion_matrix(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, NDarray? labels = null, bool samplewise = false) => default!;
        public static float ndcg_score(NDarray y_true, NDarray y_score, int? k = null, NDarray? sample_weight = null, bool ignore_ties = false) => default!;
        public static (NDarray?, NDarray?, NDarray?) precision_recall_curve(NDarray y_true, NDarray? y_score = null, string? pos_label = null, NDarray? sample_weight = null, bool drop_intermediate = false, string probas_pred = "deprecated") => default!;
        public static NDarray? precision_score(NDarray y_true, NDarray y_pred, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn") => default!;
        public static (NDarray?, NDarray?, NDarray?, NDarray?) precision_recall_fscore_support(NDarray y_true, NDarray y_pred, float beta = 1.0f, NDarray? labels = null, int pos_label = 1, PyObject? average = null, PyTuple? warn_for = null, NDarray? sample_weight = null, string zero_division = "warn") => default!;
        public static NDarray? recall_score(NDarray y_true, NDarray y_pred, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn") => default!;
        public static float roc_auc_score(NDarray y_true, NDarray y_score, string? average = "macro", NDarray? sample_weight = null, float? max_fpr = null, string multi_class = "raise", NDarray? labels = null) => default!;
        public static (NDarray?, NDarray?, NDarray?) roc_curve(NDarray y_true, NDarray y_score, string? pos_label = null, NDarray? sample_weight = null, bool drop_intermediate = true) => default!;
        public static float top_k_accuracy_score(NDarray y_true, NDarray y_score, int k = 2, bool normalize = true, NDarray? sample_weight = null, NDarray? labels = null) => default!;
        public static float zero_one_loss(NDarray y_true, NDarray y_pred, bool normalize = true, NDarray? sample_weight = null) => default!;
        public static NDarray d2_absolute_error_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average") => default!;
        public static NDarray d2_pinball_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, float alpha = 0.5f, string multioutput = "uniform_average") => default!;
        public static NDarray d2_tweedie_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, int power = 0) => default!;
        public static NDarray explained_variance_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average", bool force_finite = true) => default!;
        public static float max_error(NDarray y_true, NDarray y_pred) => default!;
        public static NDarray mean_absolute_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average") => default!;
        public static NDarray mean_absolute_percentage_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average") => default!;
        public static float mean_gamma_deviance(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null) => default!;
        public static NDarray mean_pinball_loss(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, float alpha = 0.5f, string multioutput = "uniform_average") => default!;
        public static float mean_poisson_deviance(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null) => default!;
        public static NDarray mean_squared_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average", string squared = "deprecated") => default!;
        public static NDarray mean_squared_log_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average", string squared = "deprecated") => default!;
        public static float mean_tweedie_deviance(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, int power = 0) => default!;
        public static NDarray median_absolute_error(NDarray y_true, NDarray y_pred, string multioutput = "uniform_average", NDarray? sample_weight = null) => default!;
        public static NDarray r2_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string? multioutput = "uniform_average", bool force_finite = true) => default!;
        public static NDarray root_mean_squared_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average") => default!;
        public static NDarray root_mean_squared_log_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average") => default!;
        public static float coverage_error(NDarray y_true, NDarray y_score, NDarray? sample_weight = null) => default!;
        public static float label_ranking_average_precision_score(NDarray y_true, NDarray y_score, NDarray? sample_weight = null) => default!;
        public static float label_ranking_loss(NDarray y_true, NDarray y_score, NDarray? sample_weight = null) => default!;
        public static float adjusted_mutual_info_score(NDarray labels_true, NDarray labels_pred, string average_method = "arithmetic") => default!;
        public static float adjusted_rand_score(NDarray labels_true, NDarray labels_pred) => default!;
        public static float calinski_harabasz_score(NDarray X, NDarray labels) => default!;
        public static float completeness_score(NDarray labels_true, NDarray labels_pred) => default!;
        public static float davies_bouldin_score(NDarray X, NDarray labels) => default!;
        public static float fowlkes_mallows_score(NDarray labels_true, NDarray labels_pred, bool sparse = false) => default!;
        public static (float?, float?, float?) homogeneity_completeness_v_measure(NDarray labels_true, NDarray labels_pred, float beta = 1.0f) => default!;
        public static float homogeneity_score(NDarray labels_true, NDarray labels_pred) => default!;
        public static float mutual_info_score(NDarray labels_true, NDarray labels_pred, NDarray? contingency = null) => default!;
        public static float normalized_mutual_info_score(NDarray labels_true, NDarray labels_pred, string average_method = "arithmetic") => default!;
        public static float rand_score(NDarray labels_true, NDarray labels_pred) => default!;
        public static NDarray silhouette_samples(NDarray X, NDarray labels, string metric = "euclidean", params (string key, object value)[] @params) => default!;
        public static float silhouette_score(NDarray X, NDarray labels, string metric = "euclidean", int? sample_size = null, int? random_state = null, params (string key, object value)[] @params) => default!;
        public static float v_measure_score(NDarray labels_true, NDarray labels_pred, float beta = 1.0f) => default!;
        public static float consensus_score(PyTuple a, PyTuple b, string similarity = "jaccard") => default!;
        public static NDarray pairwise_distances(NDarray X, NDarray? Y = null, string metric = "euclidean", int? n_jobs = null, bool force_all_finite = true, params (string key, object value)[] @params) => default!;
        public static NDarray pairwise_distances_argmin(NDarray X, NDarray Y, int axis = 1, string metric = "euclidean", PyDict? metric_kwargs = null) => default!;
        public static (NDarray?, NDarray?) pairwise_distances_argmin_min(NDarray X, NDarray Y, int axis = 1, string metric = "euclidean", PyDict? metric_kwargs = null) => default!;
        public static NDarray pairwise_distances_chunked(NDarray X, NDarray? Y = null, PyObject? reduce_func = null, string metric = "euclidean", int? n_jobs = null, float? working_memory = null, params (string key, object value)[] @params) => default!;
        // Classes
        //public class DistanceMetric : PythonObject
        //{
        //    // Constructor
        //    public DistanceMetric()
        //    {
        //    }

        //    // Methods
        //    static public PyObject get_metric(string metric, float? dtype = null, params (string key, object value)[] @params) => default!;
        //}

        public class ConfusionMatrixDisplay : PythonObject
        {
            // Constructor
            public ConfusionMatrixDisplay(
                NDarray confusion_matrix,
                NDarray? display_labels = null)
            { }

            // Properties
            public PyObject im_ => default!;
            public NDarray text_ => default!;
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;

            // Methods
            public static ConfusionMatrixDisplay from_estimator(
                @base.BaseEstimator estimator,
                NDarray X,
                NDarray y,
                NDarray? labels = null,
                NDarray? sample_weight = null,
                string? normalize = null,
                NDarray? display_labels = null,
                bool include_values = true,
                string xticks_rotation = "horizontal",
                string? values_format = null,
                string cmap = "viridis",
                PyObject? ax = null,
                bool colorbar = true,
                PyDict? im_kw = null,
                PyDict? text_kw = null) => default!;
            public static ConfusionMatrixDisplay from_predictions(
                NDarray y_true,
                NDarray y_pred,
                NDarray? labels = null,
                NDarray? sample_weight = null,
                PyObject? normalize = null,
                NDarray? display_labels = null,
                bool include_values = true,
                string xticks_rotation = "horizontal",
                string? values_format = null,
                string cmap = "viridis",
                PyObject? ax = null,
                bool colorbar = true,
                PyDict? im_kw = null,
                PyDict? text_kw = null) => default!;
            public static ConfusionMatrixDisplay plot(
                bool include_values = true,
                string cmap = "viridis",
                string xticks_rotation = "horizontal",
                string? values_format = null, PyObject? ax = null, bool colorbar = true, PyDict? im_kw = null, PyDict? text_kw = null) => default!;
        }

        public class DetCurveDisplay : PythonObject
        {
            // Constructor
            public DetCurveDisplay(NDarray fpr, NDarray fnr, string? estimator_name = null, string? pos_label = null)
            {
            }

            // Properties
            public PyObject line_ => default!;
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;

            // Methods
            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? sample_weight = null, string response_method = "auto", string? pos_label = null, string? name = null, PyObject? ax = null, params (string key, object value)[] @params) => default!;
            public PyObject from_predictions(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string? pos_label = null, string? name = null, PyObject? ax = null, params (string key, object value)[] @params) => default!;
            public PyObject plot(PyObject? ax = null, string? name = null, params (string key, object value)[] @params) => default!;
        }

        public class PrecisionRecallDisplay : PythonObject
        {
            // Constructor
            public PrecisionRecallDisplay(NDarray precision, NDarray recall, float? average_precision = null, string? estimator_name = null, string? pos_label = null, float? prevalence_pos_label = null)
            {
            }

            // Properties
            public PyObject line_ => default!;
            public PyObject chance_level_ => default!;
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;

            // Methods
            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? sample_weight = null, string? pos_label = null, bool drop_intermediate = false, string response_method = "auto", string? name = null, PyObject? ax = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, params (string key, object value)[] @params) => default!;
            public PyObject from_predictions(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string? pos_label = null, bool drop_intermediate = false, string? name = null, PyObject? ax = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, params (string key, object value)[] @params) => default!;
            public PyObject plot(PyObject? ax = null, string? name = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, params (string key, object value)[] @params) => default!;
        }

        public class PredictionErrorDisplay : PythonObject
        {
            // Constructor
            public PredictionErrorDisplay(NDarray y_true, NDarray y_pred)
            {
            }

            // Properties
            public PyObject line_ => default!;
            public PyObject errors_lines_ => default!;
            public PyObject scatter_ => default!;
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;

            // Methods
            public PyDict from_estimator(PyObject estimator, NDarray X, NDarray y, string kind = "residual_vs_predicted", int? subsample = 1000, int? random_state = null, PyObject? ax = null, PyDict? scatter_kwargs = null, PyDict? line_kwargs = null) => default!;
            public PyDict from_predictions(NDarray y_true, NDarray y_pred, string kind = "residual_vs_predicted", int? subsample = 1000, int? random_state = null, PyObject? ax = null, PyDict? scatter_kwargs = null, PyDict? line_kwargs = null) => default!;
            public PyDict plot(PyObject? ax = null, string kind = "residual_vs_predicted", PyDict? scatter_kwargs = null, PyDict? line_kwargs = null) => default!;
        }

        public class RocCurveDisplay : PythonObject
        {
            // Constructor
            public RocCurveDisplay(NDarray fpr, NDarray tpr, float? roc_auc = null, string? estimator_name = null, string? pos_label = null)
            {
            }

            // Properties
            public PyObject line_ => default!;
            public PyObject chance_level_ => default!;
            public PyObject ax_ => default!;
            public PyObject figure_ => default!;

            // Methods
            public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? sample_weight = null, bool drop_intermediate = true, string response_method = "auto", string? pos_label = null, string? name = null, PyObject? ax = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, params (string key, object value)[] @params) => default!;
            public PyObject from_predictions(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, bool drop_intermediate = true, string? pos_label = null, string? name = null, PyObject? ax = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, params (string key, object value)[] @params) => default!;
            public PyObject plot(PyObject? ax = null, string? name = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, params (string key, object value)[] @params) => default!;
        }

        // Revised!! v v v v

        [Module]
        public static class cluster
        {
            // Methods
            public static NDarray contingency_matrix(NDarray labels_true, NDarray labels_pred, float? eps = null, bool sparse = false, Dtype? dtype = null) => default!;
            public static NDarray<long> pair_confusion_matrix(NDarray labels_true, NDarray labels_pred) => default!;
        }

        [Module]
        public static class pairwise
        {
            // Methods
            public static NDarray additive_chi2_kernel(NDarray X, NDarray? Y = null) => default!;
            public static NDarray chi2_kernel(NDarray X, NDarray? Y = null, float gamma = 1.0f) => default!;
            public static NDarray cosine_distances(NDarray X, NDarray? Y = null) => default!;
            public static NDarray cosine_similarity(NDarray X, NDarray? Y = null, bool dense_output = true) => default!;
            [NeedsRevision]
            public static PyDict distance_metrics() => default!;
            public static NDarray euclidean_distances(NDarray X, NDarray? Y = null, NDarray? Y_norm_squared = null, bool squared = false, NDarray? X_norm_squared = null) => default!;
            public static NDarray haversine_distances(NDarray X, NDarray? Y = null) => default!;
            [NeedsRevision]
            public static PyDict kernel_metrics() => default!;
            public static NDarray laplacian_kernel(NDarray X, NDarray? Y = null, float? gamma = null) => default!;
            public static NDarray linear_kernel(NDarray X, NDarray? Y = null, bool dense_output = true) => default!;
            public static NDarray manhattan_distances(NDarray X, NDarray? Y = null) => default!;
            public static NDarray nan_euclidean_distances(NDarray X, NDarray? Y = null, bool squared = false, float? missing_values = null, bool copy = true) => default!;
            public static NDarray paired_cosine_distances(NDarray X, NDarray Y) => default!;
            public static NDarray paired_distances(NDarray X, NDarray Y, string metric = "euclidean", params (string key, object value)[] @params) => default!;
            public static NDarray paired_euclidean_distances(NDarray X, NDarray Y) => default!;
            public static NDarray paired_manhattan_distances(NDarray X, NDarray Y) => default!;
            public static NDarray pairwise_kernels(NDarray X, NDarray? Y = null, string metric = "linear", bool filter_params = false, int? n_jobs = null, params (string key, object value)[] @params) => default!;
            public static NDarray polynomial_kernel(NDarray X, NDarray? Y = null, int degree = 3, float? gamma = null, int coef0 = 1) => default!;
            public static NDarray rbf_kernel(NDarray X, NDarray? Y = null, float? gamma = null) => default!;
            public static NDarray sigmoid_kernel(NDarray X, NDarray? Y = null, float? gamma = null, int coef0 = 1) => default!;
        }
    }
}