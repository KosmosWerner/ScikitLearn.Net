﻿# Sklearn.Net
[![](https://img.shields.io/nuget/dt/ScikitLearn?color=4cbb3b\&label=Downloads\&logo=NuGet\&style=flat-square)](https://www.nuget.org/packages/ScikitLearn)
[![](https://img.shields.io/nuget/v/ScikitLearn?color=0078D4\&logo=NuGet\&style=flat-square)](https://www.nuget.org/packages/ScikitLearn)

**C# bindings for Scikit-Learn**, focused on bringing Machine Learning into the C# environment. This library provides easy access to machine learning models, results, parameters, and datasets.

Built on top of [Numpy.Bare](https://github.com/SciSharp/Numpy.NET) and automatically generated from [Scikit-Learn’s documentation](https://scikit-learn.org/stable/index.html), supporting most classes and methods.

## 🔧 Installation

### If You Already Have Python Installed

Set the path to your `python311.dll` file as follows:

```csharp
Runtime.PythonDLL = "your_path_to_python311.dll";
```

Replace `"your_path_to_python311.dll"` with the actual path to `python311.dll` on your system. This allows Sklearn.NET to use your existing Python installation.

### Installing Python Locally

If you prefer a local Python installation, install [Python.Included](https://github.com/henon/Python.Included) [NuGet package](https://www.nuget.org/packages/Python.Included/3.11.6) (version 3.11.6). Then add the following code to initialize the environment:

```csharp
using Python.Included;
using Python.Runtime;
using Numpy;
using ScikitLearn;
```

```csharp
internal class Program
{
    // This asynchronous method installs NumPy and Scikit-learn.
    // The first run may take a few minutes. After that, startup is nearly instant.
    // You can also copy the installation to a shared location for use across projects.
    private static async Task InitializeInstallerAsync()
    {
        Installer.InstallPath = Path.GetFullPath("."); // Set the desired installation path
    
        await Installer.SetupPython();
        await Installer.TryInstallPip();
        await Installer.PipInstallModule("numpy");
        await Installer.PipInstallModule("scikit-learn");
    }

    public static void Main(string[] args)
    {
        Task.Run(InitializeInstallerAsync).Wait();

        // Your code here
    }
}
```

🖥️ [Console Example](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Console%20Example/Program.cs#L36)
💻 [Desktop Example](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Desktop%20Example/MainWindow.xaml.cs#L47)

## ⚙ Usage

Example replicating [DBSCAN](https://scikit-learn.org/stable/modules/generated/sklearn.cluster.DBSCAN.html):

```csharp
var X = np.array(new int[,] {
    { 1, 2 }, { 2, 2 }, { 2, 3 },
    { 8, 7 }, { 8, 8 }, { 25, 25 } });

var clustering = new sklearn.cluster.DBSCAN(eps: 3, min_samples: 2).fit(X);
Console.WriteLine(clustering.labels_);
```

Output:

```
[ 0  0  0  1  1 -1]
```

💻 [See full code](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Console%20Example/Program.cs)

## ⚠ Notes

### 1. Accessing the `labels_` Array

Scikit-Learn typically uses `ndarray(int64)`, which corresponds to `long[]` in C#. Use the following to extract data:

```csharp
long[] labels = my_model.labels_.GetData<long>();
```

### 2. PythonEngine.Shutdown()

For desktop apps, always call `PythonEngine.Shutdown()` when the app closes to avoid Python processes running in the background.

💻 [Desktop Example](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Desktop%20Example/MainWindow.xaml.cs#L68)

### 3. Missing Methods or Constructors?

Each static class contains a `self` field of type `PyObject`, which you can use to create instances or call missing methods.
If you create an object and are confident of its type, use the static `Encapsule(PyObject pyObject)` method to convert it into a typed wrapper:

```csharp
PyObject obj = sklearn.cluster.self.InvokeMethod("DBSCAN", your_custom_args);

var model = sklearn.cluster.DBSCAN.Encapsule(obj);
model.fit(...);
```

## 💻 Desktop Applications

This project was born from the need to use classification algorithms within the rich UI features of C#, such as WinForms and WPF, for building complex applications.
Here’s a simple app that interactively compares clustering methods like DBSCAN, OPTICS, and Mean Shift using the [ScottPlot](https://github.com/ScottPlot/ScottPlot) graphing library:

[![](https://raw.githubusercontent.com/KosmosWerner/ScikitLearn.Net/refs/heads/master/Dev/cluster_dbscan.gif)](https://github.com/KosmosWerner/ScikitLearn.Net)

💻 [Full code here](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Examples/Desktop%20Example)

## 🤝 How to Contribute

To make the project easier to maintain, all class and method declarations are located in the [ScikitLearn.Signatures](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Source/ScikitLearn.Signatures) project.

If a method, constructor, or class has incorrect parameters, correct or implement it there. Then run the [CodeGenerator](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Source/CodeGenerator) to apply changes.

## 📝 Final Notes

This project is still in early development, so some parts may be incomplete or lack error handling.
Work is ongoing to add tests that verify return types and improve type safety.


## Licenses

This project is licensed under the MIT License.

It wraps and makes use of the Scikit-Learn project, which is licensed under the BSD 3-Clause License.  
See [LICENSE.scikit-learn](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/LICENSE.scikit-learn.txt) for details.