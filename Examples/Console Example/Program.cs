using Numpy;
using Python.Included;
using ScikitLearn;

namespace Console_Example;

internal class Program
{
    static void Main(string[] args)
    {
        // Install Python + dependencies
        Task.Run(SetupPythonEnvironment).Wait();

        // Create sample data
        var X = np.array(new int[,]
        {
            { 1,  2 },
            { 2,  2 },
            { 2,  3 },
            { 8,  7 },
            { 8,  8 },
            { 25, 25 }
        });

        // Apply DBSCAN clustering
        var clustering = new sklearn.cluster.DBSCAN(eps: 3, min_samples: 2).fit(X);

        // Output the cluster labels
        Console.WriteLine(clustering.labels_);
    }

    // -------------------------
    // Setup
    // -------------------------

    private static async Task SetupPythonEnvironment()
    {
        Installer.InstallPath = Path.GetFullPath(".");

        await Installer.SetupPython();
        await Installer.TryInstallPip();
        await Installer.PipInstallModule("numpy");
        await Installer.PipInstallModule("scikit-learn");
    }
}
