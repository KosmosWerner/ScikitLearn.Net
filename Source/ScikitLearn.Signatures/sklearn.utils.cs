using System;
using System.Collections.Generic;
using System.Numerics;
using Numpy;
using Python.Runtime;

namespace ScikitLearn;
public static partial class sklearn
{
    // Classes
    [Module]
    public static class utils
    {
        // Methods
        public static NDarray as_float_array(
            NDarray X,
            bool copy = true,
            bool ensure_all_finite = true) => default!;

        public static void assert_all_finite(
            NDarray X,
            bool allow_nan = false,
            string? estimator_name = null,
            string input_name = "")
        { }

        public static string estimator_html_repr(
            [NeedsSpecification] PythonObject estimator) => default!;

        public static Slice[] gen_batches(
            int n,
            int batch_size,
            int min_batch_size = 0) => default!;

        public static Slice[] gen_even_slices(
            int n,
            int n_packs,
            int? n_samples = null) => default!;

        [NeedsRevision]
        public static NDarray? indexable(
            PyObject[] iterables) => default!;

        [NeedsRevision]
        public static void murmurhash3_32(
            NDarray key,
            int seed = 0,
            bool positive = false)
        { }

        public static NDarray resample(
            NDarray[] arrays,
            bool replace = true,
            int? n_samples = null,
            int? random_state = null,
            NDarray? stratify = null,
            NDarray? sample_weight = null) => default!;

        public static NDarray safe_mask(
            NDarray X,
            NDarray mask) => default!;

        public static NDarray safe_sqr(
            NDarray X,
            bool copy = true) => default!;

        public static NDarray shuffle(
            NDarray[] arrays,
            int? random_state = null,
            int? n_samples = null) => default!;

        public static (PyObject?, PyObject?) check_X_y(
            NDarray X,
            NDarray y,
            bool accept_sparse = false,
            bool accept_large_sparse = true,
            string? dtype = "numeric",
            PyObject? order = null,
            bool copy = false,
            bool force_writeable = false,
            bool force_all_finite = true,
            bool ensure_2d = true,
            bool allow_nd = false,
            bool multi_output = false,
            int ensure_min_samples = 1,
            int ensure_min_features = 1,
            bool y_numeric = false,
            string? estimator = null) => default!;

        public static PyObject check_array(
            PyObject array,
            bool accept_sparse = false,
            bool accept_large_sparse = true,
            string? dtype = "numeric",
            PyObject? order = null,
            bool copy = false,
            bool force_writeable = false,
            bool force_all_finite = true,
            bool ensure_2d = true,
            bool allow_nd = false,
            int ensure_min_samples = 1,
            int ensure_min_features = 1,
            string? estimator = null,
            string input_name = "") => default!;

        public static void check_consistent_length(NDarray[] arrays)
        {
        }

        public static PyObject check_random_state(int seed) => default!;
        public static PyObject check_scalar(PyObject x, string name, PyTuple target_type, float? min_val = null, float? max_val = null, string include_boundaries = "both") => default!;
        // Classes
        public class Bunch : PythonObject
        {
            // Constructor
            public Bunch()
            {
            }

            // Methods
            public PyObject this[string index]
            {
                get { return self.GetItem(index); }
                set { self.SetItem(index, value); }
            }
        }

        public static class arrayfuncs
        {
            // Methods
            public static float min_pos(NDarray X) => default!;
        }

        public static class class_weight
        {
            // Methods
            public static NDarray compute_class_weight(PyDict class_weight, NDarray classes, NDarray y) => default!;
            public static NDarray compute_sample_weight(PyDict class_weight, NDarray y, NDarray? indices = null) => default!;
        }

        public static class discovery
        {
            // Methods
            public static PyTuple all_displays() => default!;
            public static PyTuple all_estimators(PyTuple? type_filter = null) => default!;
            public static PyTuple all_functions() => default!;
        }

        public static class estimator_checks
        {
            // Methods
            public static PyObject check_estimator(PyObject? estimator = null, bool generate_only = false) => default!;
            public static PyObject parametrize_with_checks(PyTuple estimators) => default!;
        }

        public static class extmath
        {
            // Methods
            public static float density(NDarray w) => default!;
            public static float fast_logdet(NDarray A) => default!;
            public static NDarray randomized_range_finder(NDarray A, int size, int n_iter, string power_iteration_normalizer = "auto", int? random_state = null) => default!;
            public static (NDarray?, NDarray?, NDarray?) randomized_svd(NDarray M, int n_components, int n_oversamples = 10, string n_iter = "auto", string power_iteration_normalizer = "auto", string transpose = "auto", bool flip_sign = true, int? random_state = null, string svd_lapack_driver = "gesdd") => default!;
            public static NDarray safe_sparse_dot(NDarray a, NDarray b, bool dense_output = false) => default!;
            public static (NDarray?, NDarray?) weighted_mode(NDarray a, NDarray w, int axis = 0) => default!;
        }

        public static class graph
        {
            // Methods
            public static PyDict single_source_shortest_path_length(NDarray graph, int source, int? cutoff = null) => default!;
        }

        [Module]
        public static class metadata_routing
        {
            // Methods
            public static PyObject get_routing_for_object(PyObject? obj = null) => default!;
            public static PyDict process_routing(PyObject _obj, string _method, params (string key, object value)[] @params) => default!;
            // Classes
            public class MetadataRequest : PythonObject
            {
                // Constructor
                public MetadataRequest(string owner)
                {
                }

                // Methods
                public string consumes(string method, string @params) => default!;
            }

            public class MetadataRouter : PythonObject
            {
                // Constructor
                public MetadataRouter(string owner)
                {
                }

                // Methods
                [Self]
                public MetadataRouter add(PyObject method_mapping, params (string key, object value)[] @params) => default!;
                [Self]
                public MetadataRouter add_self_request(PyObject obj) => default!;
                public string consumes(string method, string @params) => default!;
                public PyDict route_params(string caller, PyDict @params) => default!;
                public void validate_metadata(string method, PyDict @params)
                {
                }
            }

            public class MethodMapping : PythonObject
            {
                // Constructor
                public MethodMapping()
                {
                }

                // Methods
                [Self]
                public MethodMapping add(string caller, string callee) => default!;
            }
        }

        [Module]
        public static class metaestimators
        {
            // Methods
            public static PyObject available_if(PyObject check) => default!;
        }

        [Module]
        public static class multiclass
        {
            // Methods
            public static bool is_multilabel(NDarray y) => default!;
            public static string type_of_target(NDarray y, string input_name = "") => default!;
            public static NDarray unique_labels(NDarray[] ys) => default!;
        }

        [Module]
        public static class parallel
        {
            // Methods
            public static PyTuple delayed(PyObject function) => default!;
            // Classes
            public class Parallel : PythonObject
            {
                // Constructor
                public Parallel(string return_as = "list", string pre_dispatch = "2 * n_jobs", string batch_size = "auto")
                {
                }

                // Methods
                public void dispatch_next()
                {
                }

                public void dispatch_one_batch()
                {
                }

                public void format(int indent = 0)
                {
                }

                public void print_progress()
                {
                }
            }
        }

        [Module]
        public static class random
        {
            // Methods
            public static NDarray sample_without_replacement(int n_population, int n_samples, string method = "auto", int? random_state = null) => default!;
        }

        [Module]
        public static class sparsefuncs
        {
            // Methods
            public static (NDarray?, NDarray?, NDarray?) incr_mean_variance_axis(NDarray X, PyObject axis, NDarray last_mean, NDarray last_var, NDarray last_n, NDarray? weights = null) => default!;
            public static void inplace_column_scale(NDarray X, NDarray scale)
            {
            }

            public static void inplace_csr_column_scale(NDarray X, NDarray scale)
            {
            }

            public static void inplace_row_scale(NDarray X, NDarray scale)
            {
            }

            public static void inplace_swap_column(NDarray X, int m, int n)
            {
            }

            public static void inplace_swap_row(NDarray X, int m, int n)
            {
            }

            public static (NDarray?, NDarray?, NDarray?) mean_variance_axis(NDarray X, PyObject axis, NDarray? weights = null, bool return_sum_weights = false) => default!;
        }

        [Module]
        public static class sparsefuncs_fast
        {
            // Methods
            public static void inplace_csr_row_normalize_l1(NDarray X) { }

            public static void inplace_csr_row_normalize_l2(PyObject X) { }
        }

        [Module]
        public static class validation
        {
            // Methods
            public static void check_is_fitted(PyObject estimator, string? attributes = null, string? msg = null, PyObject? all_or_any = null) { }

            public static PyObject check_memory(PyObject memory) => default!;
            public static NDarray check_symmetric(NDarray array, float tol = 1e-10f, bool raise_warning = true, bool raise_exception = false) => default!;
            public static NDarray column_or_1d(NDarray y, PyObject? dtype = null, bool warn = false) => default!;
            public static bool has_fit_parameter(PyObject estimator, string parameter) => default!;
        }
    }
}