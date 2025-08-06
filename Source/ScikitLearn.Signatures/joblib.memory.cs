namespace ScikitLearn;

public static partial class joblib
{
    [Module]
    public static class memory
    {
        public class Memory : IPythonWrapper
        {
            public Memory(
                string? location = null,
                string backend = "local",
                string? mmap_mode = null,
                bool compress = false,
                int verbose = 1,
                [Default(null)] NullOrOneOf<int, string> bytes_limit = default,
                Dictionary<string, object>? backend_options = null)
            { }

            public void clear(bool warn = true) { }
        }
    }
}