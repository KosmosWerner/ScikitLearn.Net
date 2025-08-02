using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScikitLearn;

public static partial class joblib
{
    [Module]
    public static class memory
    {
        public class Memory : PythonObject
        {
            public Memory(
                string? location = null,
                string backend = "local",
                string? mmap_mode = null,
                bool compress = false,
                int verbose = 1,
                int? bytes_limit = null,
                Dictionary<string, PyObject>? backend_options = null)
            { }

            public void clear(bool warn = true) { }
        }
    }
}