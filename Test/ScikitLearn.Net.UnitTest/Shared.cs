using Python.Included;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScikitLearn.Net.UnitTest;

internal static class Shared
{
    public static async Task InstallAsync()
    {
        Installer.InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        await Installer.SetupPython();
        await Installer.TryInstallPip();
        await Installer.PipInstallModule("numpy");
        await Installer.PipInstallModule("scikit-learn");
    }
}
