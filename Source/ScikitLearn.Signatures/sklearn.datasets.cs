using System;
using System.Collections.Generic;
using Numpy;
using Numpy.Models;
using Python.Runtime;
using ScikitLearn.Signatures.Annotations;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class datasets
    {
        // Methods
        [Checked]
        public static void clear_data_home(
            string? data_home = null)
        { }

        [Checked]
        public static void dump_svmlight_file(
            NDarray X,
            NDarray y,
            string f,
            bool zero_based = true,
            string? comment = null,
            NDarray? query_id = null,
            bool multilabel = false)
        { }

        public static (PyDict?, PyTuple?) fetch_20newsgroups(
            string? data_home = null,
            string subset = "train",
            NDarray? categories = null,
            bool shuffle = true,
            int? random_state = 42,
            PyTuple? remove = null,
            bool download_if_missing = true,
            bool return_X_y = false,
            int n_retries = 3,
            float delay = 1.0f) => default!;
        public static (PyDict?, PyTuple?) fetch_20newsgroups_vectorized(string subset = "train", PyTuple? remove = null, string? data_home = null, bool download_if_missing = true, bool return_X_y = false, bool normalize = true, bool as_frame = false, int n_retries = 3, float delay = 1.0f) => default!;
        public static (PyDict?, PyTuple?) fetch_california_housing(string? data_home = null, bool download_if_missing = true, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f) => default!;
        public static (PyDict?, PyTuple?) fetch_covtype(string? data_home = null, bool download_if_missing = true, int? random_state = null, bool shuffle = false, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f) => default!;
        public static (PyDict?, PyTuple?) fetch_kddcup99(PyObject? subset = null, string? data_home = null, bool shuffle = false, int? random_state = null, bool percent10 = true, bool download_if_missing = true, bool return_X_y = false, bool as_frame = false, int n_retries = 3, float delay = 1.0f) => default!;
        public static PyDict fetch_lfw_pairs(string subset = "train", string? data_home = null, bool funneled = true, float resize = 0.5f, bool color = false, PyTuple? slice_ = null, bool download_if_missing = true, int n_retries = 3, float delay = 1.0f) => default!;
        public static (PyDict?, PyTuple?) fetch_lfw_people(string? data_home = null, bool funneled = true, float? resize = 0.5f, int? min_faces_per_person = 0, bool color = false, PyTuple? slice_ = null, bool download_if_missing = true, bool return_X_y = false, int n_retries = 3, float delay = 1.0f) => default!;
        public static (PyDict?, PyTuple?) fetch_olivetti_faces(string? data_home = null, bool shuffle = false, int? random_state = 0, bool download_if_missing = true, bool return_X_y = false, int n_retries = 3, float delay = 1.0f) => default!;
        public static (PyDict?, PyTuple?) fetch_openml(string? name = null, string version = "active", int? data_id = null, string? data_home = null, string? target_column = "default-target", bool cache = true, bool return_X_y = false, string as_frame = "auto", int n_retries = 3, float delay = 1.0f, string parser = "auto", PyDict? read_csv_kwargs = null) => default!;
        public static (PyDict?, PyTuple?) fetch_rcv1(string? data_home = null, string subset = "all", bool download_if_missing = true, int? random_state = null, bool shuffle = false, bool return_X_y = false, int n_retries = 3, float delay = 1.0f) => default!;
        public static PyDict fetch_species_distributions(string? data_home = null, bool download_if_missing = true, int n_retries = 3, float delay = 1.0f) => default!;
        public static string get_data_home(string? data_home = null) => default!;
        public static (PyDict?, PyTuple?) load_breast_cancer(bool return_X_y = false, bool as_frame = false) => default!;
        public static (PyDict?, PyTuple?) load_diabetes(bool return_X_y = false, bool as_frame = false, bool scaled = true) => default!;
        public static (PyDict?, PyTuple?) load_digits(int n_class = 10, bool return_X_y = false, bool as_frame = false) => default!;
        public static PyDict load_files(string container_path, string? description = null, PyTuple? categories = null, bool load_content = true, bool shuffle = true, string? encoding = null, string decode_error = "strict", int? random_state = 0, PyTuple? allowed_extensions = null) => default!;
        public static (PyDict?, PyTuple?) load_iris(bool return_X_y = false, bool as_frame = false) => default!;
        public static (PyDict?, PyTuple?) load_linnerud(bool return_X_y = false, bool as_frame = false) => default!;
        public static NDarray load_sample_image(PyObject image_name) => default!;
        public static PyDict load_sample_images() => default!;
        public static (NDarray?, NDarray?, NDarray?) load_svmlight_file(string f, int? n_features = null, float? dtype = null, bool multilabel = false, string zero_based = "auto", bool query_id = false, int offset = 0, int length = -1) => default!;
        public static NDarray load_svmlight_files(NDarray files, int? n_features = null, float? dtype = null, bool multilabel = false, string zero_based = "auto", bool query_id = false, int offset = 0, int length = -1) => default!;
        public static (PyDict?, PyTuple?) load_wine(bool return_X_y = false, bool as_frame = false) => default!;
        public static (NDarray?, NDarray?, NDarray?) make_biclusters(NDarray shape, int n_clusters, float noise = 0.0f, int minval = 10, int maxval = 100, bool shuffle = true, int? random_state = null) => default!;

        [TupleMemberCondition(Condition = "return_centers == true", Member = "center")]
        public static (NDarray X, NDarray y, NDarray? centers) make_blobs(
            int n_samples = 100,
            int n_features = 2,
            NDarray? centers = null,
            float cluster_std = 1.0f,
            PyTuple? center_box = null,
            bool shuffle = true,
            int? random_state = null,
            bool return_centers = false) => default!;

        public static (NDarray X, NDarray rows, NDarray cols) make_checkerboard(
            NDarray shape,
            NDarray n_clusters,
            float noise = 0.0f,
            int minval = 10,
            int maxval = 100,
            bool shuffle = true,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_circles(
            int n_samples = 100,
            bool shuffle = true,
            float? noise = null,
            int? random_state = null,
            float factor = 0.8f) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_circles(
           (int, int) n_samples,
           bool shuffle = true,
           float? noise = null,
           int? random_state = null,
           float factor = 0.8f) => default!;

        [Checked]
        [TupleVariantSelector(Condition = "return_X_y == false", WhenTrue = "data", WhenFalse = "X_y")]
        public static (sklearn.utils.Bunch? data, (NDarray X, NDarray y)? X_y) make_classification(
            int n_samples = 100,
            int n_features = 20,
            int n_informative = 2,
            int n_redundant = 2,
            int n_repeated = 0,
            int n_classes = 2,
            int n_clusters_per_class = 2,
            NDarray? weights = null,
            float flip_y = 0.01f,
            float class_sep = 1.0f,
            bool hypercube = true,
            float? shift = 0.0f,
            float? scale = 1.0f,
            bool shuffle = true,
            int? random_state = null,
            bool return_X_y = true) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_friedman1(
            int n_samples = 100,
            int n_features = 10,
            float noise = 0.0f,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_friedman2(
            int n_samples = 100,
            float noise = 0.0f,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_friedman3(
            int n_samples = 100,
            float noise = 0.0f,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_gaussian_quantiles(
            NDarray? mean = null,
            float cov = 1.0f,
            int n_samples = 100,
            int n_features = 2,
            int n_classes = 3,
            bool shuffle = true,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_hastie_10_2(
            int n_samples = 12000,
            int? random_state = null) => default!;

        [Checked]
        public static NDarray make_low_rank_matrix(
            int n_samples = 100,
            int n_features = 100,
            int effective_rank = 10,
            float tail_strength = 0.5f,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_moons(
            int n_samples = 100,
            bool shuffle = true,
            float? noise = null,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_moons(
            Shape n_samples,
            bool shuffle = true,
            float? noise = null,
            int? random_state = null) => default!;

        [Checked]
        [TupleMemberCondition(Condition = "return_distributions == true", Member = "p_c")]
        [TupleMemberCondition(Condition = "return_distributions == true", Member = "p_w_c")]
        public static (NDarray X, NDarray Y, NDarray? p_c, NDarray? p_w_c) make_multilabel_classification(
            int n_samples = 100,
            int n_features = 20,
            int n_classes = 5,
            int n_labels = 2,
            int length = 50,
            bool allow_unlabeled = true,
            bool sparse = false,
            string return_indicator = "dense",
            bool return_distributions = false,
            int? random_state = null) => default!;

        [Checked]
        [TupleMemberCondition(Condition = "coef == true", Member = "coef")]
        public static (NDarray X, NDarray y, NDarray? coef) make_regression(
            int n_samples = 100,
            int n_features = 100,
            int n_informative = 10,
            int n_targets = 1,
            float bias = 0.0f,
            int? effective_rank = null,
            float tail_strength = 0.5f,
            float noise = 0.0f,
            bool shuffle = true,
            bool coef = false,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray t) make_s_curve(
            int n_samples = 100,
            float noise = 0.0f,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray data, NDarray dictionary, NDarray code) make_sparse_coded_signal(
            int n_samples,
            int n_components,
            int n_features,
            int n_nonzero_coefs,
            int? random_state = null) => default!;

        [Checked]
        public static NDarray make_sparse_spd_matrix(
            int n_dim = 1,
            float alpha = 0.95f,
            bool norm_diag = false,
            float smallest_coef = 0.1f,
            float largest_coef = 0.9f,
            string? sparse_format = null,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray y) make_sparse_uncorrelated(
            int n_samples = 100,
            int n_features = 10,
            int? random_state = null) => default!;

        [Checked]
        public static NDarray make_spd_matrix(
            int n_dim,
            int? random_state = null) => default!;

        [Checked]
        public static (NDarray X, NDarray t) make_swiss_roll(
            int n_samples = 100,
            float noise = 0.0f,
            int? random_state = null,
            bool hole = false) => default!;
    }
}