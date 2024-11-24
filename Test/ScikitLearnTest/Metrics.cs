using Numpy;
using Python.Included;
using Python.Runtime;
using ScikitLearn;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace ScikitLearnTest
{
    public class Metrics
    {
        private static async Task InitializeInstallerAsync()
        {
            Installer.InstallPath = Path.GetFullPath(".");

            await Installer.SetupPython();
            await Installer.TryInstallPip();
            await Installer.PipInstallModule("numpy");
            await Installer.PipInstallModule("scikit-learn");
        }

        [Fact]
        public async Task confusion_matrix()
        {
            await InitializeInstallerAsync();
            int[] y1_true = [2, 0, 2, 2, 0, 1];
            int[] y1_pred = [0, 0, 2, 2, 0, 2];

            var result1 = sklearn.metrics.confusion_matrix(y1_true, y1_pred);
            Console.WriteLine(result1);

            string[] y2_true = ["cat", "ant", "cat", "cat", "ant", "bird"];
            string[] y2_pred = ["ant", "ant", "cat", "cat", "ant", "cat"];
            string[] labels = ["ant", "bird", "cat"];

            var result2 = sklearn.metrics.confusion_matrix(y2_true, y2_pred, labels);
            Console.WriteLine(result2);
        }
    }
}