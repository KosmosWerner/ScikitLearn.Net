namespace CodeGenerator;

public static class Helpers
{
    private static DirectoryInfo? _cachedSolutionDirectory;

    public static DirectoryInfo? TryGetSolutionDirectoryInfo(string? currentPath = null)
    {
        if (_cachedSolutionDirectory is not null) return _cachedSolutionDirectory;
        int attempt = 0;
        const int MAX_ATTEMPTS = 10;
        var directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());

        while (directory is not null && attempt < MAX_ATTEMPTS)
        {
            try
            {
                if (directory.EnumerateFiles("*.sln", SearchOption.TopDirectoryOnly).Any())
                {
                    _cachedSolutionDirectory = directory;
                    return directory;
                }
            }
            catch (UnauthorizedAccessException)
            {
                return null;
            }

            directory = directory.Parent;
            attempt++;
        }

        return null;
    }

    public static string? TryGetSolutionPath(string? currentPath = null)
        => TryGetSolutionDirectoryInfo(currentPath)?.FullName;
}