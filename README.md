# Sklearn.Net
[![](https://img.shields.io/nuget/dt/ScikitLearn?color=4cbb3b&label=Downloads&logo=NuGet&style=flat-square)](https://www.nuget.org/packages/ScikitLearn)
[![](https://img.shields.io/nuget/v/ScikitLearn?color=0078D4&logo=NuGet&style=flat-square)](https://www.nuget.org/packages/ScikitLearn)


C# bindings for Scikit-Learn, focused on bringing Machine Learning to the C# environment. This library provides easy access to machine learning models, results, parameters and datasets.

Powered by [Numpy.Bare](https://github.com/SciSharp/Numpy.NET) and generated based on [Scikit-Learn’s documentation](https://scikit-learn.org/stable/index.html), implementing most of the classes and methods.

## 🔧 Installation

### If Python is Already Installed

Set the path to your `python311.dll` file as follows:

```csharp
Runtime.PythonDLL = "your_path_to_python311.dll";
```

Replace `"your_path_to_python311.dll"` with the actual path where `python311.dll` is located on your system. This setting allows Sklearn.NET to use your existing Python installation directly.


### For a Local Python Installation

If you prefer to install Python locally, you’ll need to first install [Python.Included](https://github.com/henon/Python.Included) [Nuget](https://www.nuget.org/packages/Python.Included/3.11.6) v3.11.6. Then, add the following code to your program’s startup to install and configure the local Python installation:

```csharp
using Python.Included;
using Python.Runtime;
using Numpy;
using ScikitLearn;
```

```csharp
internal class Program
{
    // Define an asynchronous method to install numpy and scikit-learn; this may take a few minutes the first time.
    // Once installed, startup will be almost immediate. You can also copy the installation to a fixed location
    // for multiple projects to find it instantly
    private static async Task InitializeInstallerAsync()
    {
        Installer.InstallPath = Path.GetFullPath("."); // Specify the path for the local installation
    
        await Installer.SetupPython();
        await Installer.TryInstallPip();
        await Installer.PipInstallModule("numpy");
        await Installer.PipInstallModule("scikit-learn");
    }

    // Run this task in your application’s constructor or at the start of your code,
    // just ensure it runs before calling np or sklearn
    public static void Main(string[] args)
    {
        Task.Run(InitializeInstallerAsync).Wait();

        // Your code here
    }
}
```

## ⚙ Usage

Replicating the [DBSCAN](https://scikit-learn.org/stable/modules/generated/sklearn.cluster.DBSCAN.html) example:

```csharp
var X = np.array(new int[,] {
    { 1, 2 }, { 2, 2 }, { 2, 3 },
    { 8, 7 }, { 8,8 }, { 25, 25 } });

var clustering = new sklearn.cluster.DBSCAN(eps: 3, min_samples: 2).fit(X);
Console.WriteLine(clustering.labels_);
```
Output
```
[ 0  0  0  1  1 -1]
```
💻 [Full code here](https://github.com/KosmosWerner/ScikitLearn.Net/blob/main/Examples/ConsoleExample)

## ⚠ Notes
### 1. Getting an Array from `my_model.labels_`
ScikitLearn typically uses `ndarray(int64)`, which is equivalent to `long[]` in C# rather than `int[]`. To convert `labels_` to a C# array format, use:

```csharp
long[] labels = my_model.labels_.GetData<long>();
```

### 2. PythonEngine.Shutdown()
For desktop applications, be sure to call `PythonEngine.Shutdown()` when closing the application to prevent it from continuing in the background.

### 3. Can't Find the Methods or Constructors You Need
Each static class has a `self` field of type `PyObject`, from which you can create class instances or call omitted methods.  
When creating objects, you will receive an instance of `PyObject`. If you are sure of the type, each class has a static method `Encapsule(PyObject pyObject)`, which allows you to access the class's attributes and methods.

```csharp
PyObject obj = sklearn.cluster.self.InvokeMethod("DBSCAN", your_custom_args);

var model = sklearn.cluster.DBSCAN.Encapsule(obj);
model.fit(...);
```

## Desktop Applications

This project originated from the need to use classification algorithms within the UI benefits offered by C#, such as WinForms and WPF, for developing complex applications. Here’s a small example of an application that interactively compares different clustering types: DBSCAN, OPTICS, and Mean Shift using the [ScottPlot](https://github.com/ScottPlot/ScottPlot) graphics library.

[![](https://raw.githubusercontent.com/KosmosWerner/ScikitLearn.Net/refs/heads/main/Dev/cluster_dbscan.gif)](https://github.com/KosmosWerner/ScikitLearn.Net)

💻 [Full code here](https://github.com/KosmosWerner/ScikitLearn.Net/tree/main/Examples/ClusterExample)

## Final Notes
This project is just starting, so some parts may still lack full implementation or proper error handling. However, I’ll be adding tests to verify return types and improve typing accuracy.
