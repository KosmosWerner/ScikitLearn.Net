using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class utils
        {
            public static PyObject _safe_indexing(NDarray X, NDarray indices, int axis = 0)
            {
                throw new NotImplementedException();
            }

            public static NDarray as_float_array(NDarray X, bool copy = true, bool force_all_finite = true)
            {
                throw new NotImplementedException();
            }

            public static void assert_all_finite(NDarray X, bool allow_nan = false, string? estimator_name = null, string input_name = "")
            {
                throw new NotImplementedException();
            }

            public static string estimator_html_repr(PyObject estimator)
            {
                throw new NotImplementedException();
            }

            public static PyObject gen_batches(int n, int batch_size, int min_batch_size = 0)
            {
                throw new NotImplementedException();
            }

            public static PyObject gen_even_slices(int n, int n_packs, int? n_samples = null)
            {
                throw new NotImplementedException();
            }

            public static NDarray? indexable(PyObject[] iterables)
            {
                throw new NotImplementedException();
            }

            public static void murmurhash3_32(NDarray key, int seed = 0, bool positive = false)
            {
                throw new NotImplementedException();
            }

            public static NDarray resample(NDarray[] arrays, bool replace = true, int? n_samples = null, int? random_state = null, NDarray? stratify = null)
            {
                throw new NotImplementedException();
            }

            public static NDarray safe_mask(NDarray X, NDarray mask)
            {
                throw new NotImplementedException();
            }

            public static PyObject safe_sqr(NDarray X, bool copy = true)
            {
                throw new NotImplementedException();
            }

            public static NDarray shuffle(NDarray[] arrays, int? random_state = null, int? n_samples = null)
            {
                throw new NotImplementedException();
            }

            public static (PyObject? , PyObject? ) check_X_y(NDarray X, NDarray y, bool accept_sparse = false, bool accept_large_sparse = true, string? dtype = "numeric", PyObject? order = null, bool copy = false, bool force_writeable = false, bool force_all_finite = true, bool ensure_2d = true, bool allow_nd = false, bool multi_output = false, int ensure_min_samples = 1, int ensure_min_features = 1, bool y_numeric = false, string? estimator = null)
            {
                throw new NotImplementedException();
            }

            public static PyObject check_array(PyObject array, bool accept_sparse = false, bool accept_large_sparse = true, string? dtype = "numeric", PyObject? order = null, bool copy = false, bool force_writeable = false, bool force_all_finite = true, bool ensure_2d = true, bool allow_nd = false, int ensure_min_samples = 1, int ensure_min_features = 1, string? estimator = null, string input_name = "")
            {
                throw new NotImplementedException();
            }

            public static void check_consistent_length(NDarray[] arrays)
            {
                throw new NotImplementedException();
            }

            public static PyObject check_random_state(int seed)
            {
                throw new NotImplementedException();
            }

            public static PyObject check_scalar(PyObject x, string name, PyTuple target_type, float? min_val = null, float? max_val = null, string include_boundaries = "both")
            {
                throw new NotImplementedException();
            }

            public class Bunch
            {
                public Bunch()
                {
                }

                public void clear()
                {
                    throw new NotImplementedException();
                }

                public void copy()
                {
                    throw new NotImplementedException();
                }

                public void fromkeys()
                {
                    throw new NotImplementedException();
                }

                public void get()
                {
                    throw new NotImplementedException();
                }

                public void items()
                {
                    throw new NotImplementedException();
                }

                public void keys()
                {
                    throw new NotImplementedException();
                }

                public void pop()
                {
                    throw new NotImplementedException();
                }

                public void popitem()
                {
                    throw new NotImplementedException();
                }

                public void setdefault()
                {
                    throw new NotImplementedException();
                }

                public void update()
                {
                    throw new NotImplementedException();
                }

                public void values()
                {
                    throw new NotImplementedException();
                }
            }

            public class deprecated
            {
                public deprecated(string extra = "")
                {
                }
            }

            public static class arrayfuncs
            {
                public static float min_pos(NDarray X)
                {
                    throw new NotImplementedException();
                }
            }

            public static class class_weight
            {
                public static NDarray compute_class_weight(PyDict class_weight, NDarray classes, NDarray y)
                {
                    throw new NotImplementedException();
                }

                public static NDarray compute_sample_weight(PyDict class_weight, NDarray y, NDarray? indices = null)
                {
                    throw new NotImplementedException();
                }
            }

            public static class discovery
            {
                public static PyTuple all_displays()
                {
                    throw new NotImplementedException();
                }

                public static PyTuple all_estimators(PyTuple? type_filter = null)
                {
                    throw new NotImplementedException();
                }

                public static PyTuple all_functions()
                {
                    throw new NotImplementedException();
                }
            }

            public static class estimator_checks
            {
                public static PyObject check_estimator(PyObject? estimator = null, bool generate_only = false)
                {
                    throw new NotImplementedException();
                }

                public static PyObject parametrize_with_checks(PyTuple estimators)
                {
                    throw new NotImplementedException();
                }
            }

            public static class extmath
            {
                public static float density(NDarray w)
                {
                    throw new NotImplementedException();
                }

                public static float fast_logdet(NDarray A)
                {
                    throw new NotImplementedException();
                }

                public static NDarray randomized_range_finder(NDarray A, int size, int n_iter, string power_iteration_normalizer = "auto", int? random_state = null)
                {
                    throw new NotImplementedException();
                }

                public static (NDarray? , NDarray? , NDarray? ) randomized_svd(NDarray M, int n_components, int n_oversamples = 10, string n_iter = "auto", string power_iteration_normalizer = "auto", string transpose = "auto", bool flip_sign = true, int? random_state = null, string svd_lapack_driver = "gesdd")
                {
                    throw new NotImplementedException();
                }

                public static NDarray safe_sparse_dot(NDarray a, NDarray b, bool dense_output = false)
                {
                    throw new NotImplementedException();
                }

                public static (NDarray? , NDarray? ) weighted_mode(NDarray a, NDarray w, int axis = 0)
                {
                    throw new NotImplementedException();
                }
            }

            public static class graph
            {
                public static PyDict single_source_shortest_path_length(NDarray graph, int source, int? cutoff = null)
                {
                    throw new NotImplementedException();
                }
            }

            public static class metadata_routing
            {
                public static PyObject get_routing_for_object(PyObject? obj = null)
                {
                    throw new NotImplementedException();
                }

                public static PyDict process_routing(PyObject _obj, string _method, Dictionary<string, PyObject>? @params = null)
                {
                    throw new NotImplementedException();
                }

                public class MetadataRequest
                {
                    public MetadataRequest(string owner)
                    {
                    }

                    public string consumes(string method, string @params)
                    {
                        throw new NotImplementedException();
                    }
                }

                public class MetadataRouter
                {
                    public MetadataRouter(string owner)
                    {
                    }

                    public MetadataRouter add(PyObject method_mapping, Dictionary<string, PyObject>? @params = null)
                    {
                        throw new NotImplementedException();
                    }

                    public MetadataRouter add_self_request(PyObject obj)
                    {
                        throw new NotImplementedException();
                    }

                    public string consumes(string method, string @params)
                    {
                        throw new NotImplementedException();
                    }

                    public PyDict route_params(string caller, PyDict @params)
                    {
                        throw new NotImplementedException();
                    }

                    public void validate_metadata(string method, PyDict @params)
                    {
                        throw new NotImplementedException();
                    }
                }

                public class MethodMapping
                {
                    public MethodMapping()
                    {
                    }

                    public MethodMapping add(string caller, string callee)
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            public static class metaestimators
            {
                public static PyObject available_if(PyObject check)
                {
                    throw new NotImplementedException();
                }
            }

            public static class multiclass
            {
                public static bool is_multilabel(NDarray y)
                {
                    throw new NotImplementedException();
                }

                public static string type_of_target(NDarray y, string input_name = "")
                {
                    throw new NotImplementedException();
                }

                public static NDarray unique_labels(NDarray[] ys)
                {
                    throw new NotImplementedException();
                }
            }

            public static class parallel
            {
                public static PyTuple delayed(PyObject function)
                {
                    throw new NotImplementedException();
                }

                public class Parallel
                {
                    public Parallel(string return_as = "list", string pre_dispatch = "2 * n_jobs", string batch_size = "auto")
                    {
                    }

                    public void dispatch_next()
                    {
                        throw new NotImplementedException();
                    }

                    public void dispatch_one_batch()
                    {
                        throw new NotImplementedException();
                    }

                    public void format(int indent = 0)
                    {
                        throw new NotImplementedException();
                    }

                    public void print_progress()
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            public static class random
            {
                public static NDarray sample_without_replacement(int n_population, int n_samples, string method = "auto", int? random_state = null)
                {
                    throw new NotImplementedException();
                }
            }

            public static class sparsefuncs
            {
                public static (NDarray? , NDarray? , NDarray? ) incr_mean_variance_axis(NDarray X, PyObject axis, NDarray last_mean, NDarray last_var, NDarray last_n, NDarray? weights = null)
                {
                    throw new NotImplementedException();
                }

                public static void inplace_column_scale(NDarray X, NDarray scale)
                {
                    throw new NotImplementedException();
                }

                public static void inplace_csr_column_scale(NDarray X, NDarray scale)
                {
                    throw new NotImplementedException();
                }

                public static void inplace_row_scale(NDarray X, NDarray scale)
                {
                    throw new NotImplementedException();
                }

                public static void inplace_swap_column(NDarray X, int m, int n)
                {
                    throw new NotImplementedException();
                }

                public static void inplace_swap_row(NDarray X, int m, int n)
                {
                    throw new NotImplementedException();
                }

                public static (NDarray? , NDarray? , NDarray? ) mean_variance_axis(NDarray X, PyObject axis, NDarray? weights = null, bool return_sum_weights = false)
                {
                    throw new NotImplementedException();
                }
            }

            public static class sparsefuncs_fast
            {
                public static void inplace_csr_row_normalize_l1(NDarray X)
                {
                    throw new NotImplementedException();
                }

                public static void inplace_csr_row_normalize_l2(PyObject X)
                {
                    throw new NotImplementedException();
                }
            }

            public static class validation
            {
                public static void check_is_fitted(PyObject estimator, string? attributes = null, string? msg = null, PyObject? all_or_any = null)
                {
                    throw new NotImplementedException();
                }

                public static PyObject check_memory(PyObject memory)
                {
                    throw new NotImplementedException();
                }

                public static NDarray check_symmetric(NDarray array, float tol = 1e-10f, bool raise_warning = true, bool raise_exception = false)
                {
                    throw new NotImplementedException();
                }

                public static NDarray column_or_1d(NDarray y, PyObject? dtype = null, bool warn = false)
                {
                    throw new NotImplementedException();
                }

                public static bool has_fit_parameter(PyObject estimator, string parameter)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}