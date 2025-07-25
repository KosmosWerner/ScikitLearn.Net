using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;
using ScikitLearn.Signatures.Annotations;

namespace ScikitLearn;
[Module]
public static partial class sklearn
{
    // Methods
    [Checked]
    public static void config_context(
        bool? assume_finite = null,
        int? working_memory = null,
        bool? print_changed_only = null,
        string? display = null,
        int? pairwise_dist_chunk_size = null,
        bool? enable_cython_pairwise_dist = null,
        bool? array_api_dispatch = null,
        string? transform_output = null,
        bool? enable_metadata_routing = null,
        bool? skip_parameter_validation = null)
    { }

    [Checked]
    public static PyDict get_config()
    { return default!; }

    [Checked]
    public static void set_config(
        bool? assume_finite = null,
        int? working_memory = null,
        bool? print_changed_only = null,
        string? display = null,
        int? pairwise_dist_chunk_size = null,
        bool? enable_cython_pairwise_dist = null,
        bool? array_api_dispatch = null,
        string? transform_output = null,
        bool? enable_metadata_routing = null,
        bool? skip_parameter_validation = null)
    { }

    [Checked]
    public static void show_versions()
    { }
}