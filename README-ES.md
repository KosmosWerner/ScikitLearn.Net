# ScikitLearn.Net

[![](https://img.shields.io/nuget/dt/ScikitLearn?color=4cbb3b\&label=Downloads\&logo=NuGet\&style=flat-square)](https://www.nuget.org/packages/ScikitLearn)
[![](https://img.shields.io/nuget/v/ScikitLearn?color=0078D4\&logo=NuGet\&style=flat-square)](https://www.nuget.org/packages/ScikitLearn)

**Bindings de C# para Scikit-Learn**, enfocados en llevar el Machine Learning al entorno de C#. Esta biblioteca proporciona acceso sencillo a modelos de aprendizaje automático, resultados, parámetros y conjuntos de datos.

Construida sobre [Numpy.Bare](https://github.com/SciSharp/Numpy.NET) y basada en la [documentación de Scikit-Learn](https://scikit-learn.org/stable/index.html), soportando la mayoría de las clases y métodos.

[![📘 Leer en Español](https://img.shields.io/badge/📘%20Leer%20en-Español-blue?style=flat-square)](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/README-ES.md)
[![📗 Read in English](https://img.shields.io/badge/📗%20Read%20in-English-green?style=flat-square)](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/README.md)
[![📙 Ler em Português BR](https://img.shields.io/badge/📙%20Ler%20em-Português%20BR-orange?style=flat-square)](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/README-PT-BR.md)

## 🔧 Instalación

### Si ya tienes Python instalado

Establece la ruta a tu archivo `python311.dll` de la siguiente forma:

```csharp
Runtime.PythonDLL = "tu_ruta_a_python311.dll";
```

Reemplaza `"tu_ruta_a_python311.dll"` con la ruta real a `python311.dll` en tu sistema. Esto permite que Sklearn.NET use tu instalación existente de Python.

### Instalando Python localmente

Si prefieres una instalación local de Python, **instala [Python.Included](https://github.com/henon/Python.Included) [paquete NuGet](https://www.nuget.org/packages/Python.Included/3.11.6) (versión 3.11.6)** y luego agrega el siguiente código para inicializar el entorno:

```csharp
using Python.Included;
using Python.Runtime;
using Numpy;
using ScikitLearn;
```

```csharp
internal class Program
{
    // 🚨 ADVERTENCIA: Este método REQUIERE conexión a internet y puede tardar varios minutos 
    // en el primer intento. También puede FALLAR en los primeros intentos.
    // ✅ RECOMENDACIÓN: Una vez creada la carpeta de Python, reutilízala en varios proyectos 
    // para evitar esta demora en el futuro.

    // Este método asincrónico instala NumPy y Scikit-learn.
    private static async Task InitializeInstallerAsync()
    {
        // Establece la ruta de instalación deseada
        Installer.InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    
        await Installer.SetupPython();
        await Installer.TryInstallPip();
        await Installer.PipInstallModule("numpy");
        await Installer.PipInstallModule("scikit-learn");
    }

    public static void Main(string[] args)
    {
        Task.Run(InitializeInstallerAsync).Wait();

        // Tu código aquí
    }
}
```

⚠️ **Nota:** El proceso de instalación **requiere conexión a internet** y puede tardar varios minutos en la primera ejecución. También puede **fallar en los primeros intentos**.

✅ **Recomendación:** Una vez creada la carpeta de Python, **reutilízala entre varios proyectos** para evitar esta demora.

🖥️ [\[Ejemplo de Consola\]](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Console%20Example/Program.cs#L10)

💻 [\[Ejemplo de Escritorio\]](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Desktop%20Example/MainWindow.xaml.cs#L47)

## ⚙ Uso

Ejemplo que replica [DBSCAN](https://scikit-learn.org/stable/modules/generated/sklearn.cluster.DBSCAN.html):

```csharp
var X = np.array(new int[,] {
    { 1, 2 }, { 2, 2 }, { 2, 3 },
    { 8, 7 }, { 8, 8 }, { 25, 25 } });

var clustering = new sklearn.cluster.DBSCAN(eps: 3, min_samples: 2).fit(X);
Console.WriteLine(clustering.labels_);
```

Salida:

```
[ 0  0  0  1  1 -1]
```

💻 [\[Ver código completo\]](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Console%20Example/Program.cs)

## ⚠ Notas

### 1. 🚨 **Accediendo al arreglo `labels_` o a arreglos de punto flotante** 🚨

Scikit-Learn típicamente usa `ndarray(int64)`, que corresponde a `long[]` en C#. Usa lo siguiente para extraer los datos:

```csharp
long[] labels = my_model.labels_.GetData<long>();
```

⚠ **Si necesitas convertir arreglos de punto flotante a un formato C#, ten mucho cuidado con la conversión de tipos.**

```csharp
var x = sklearn.datasets.make_circles(n_samples: 1).X;
Console.WriteLine(x.GetData<float>()[0]);
Console.WriteLine(x.GetData<double>()[0]);
```

```
-1.5881868E-23 // usando float  [ERROR]
0.8            // usando double [OK]
```

En el futuro, se planea retornar expresiones de la forma `NDarray<double>` donde sea apropiado en lugar de `NDarray`.
**Mientras tanto, verifica mediante pruebas unitarias que los resultados coincidan con lo esperado.**

### 2. PythonEngine.Shutdown()

Para aplicaciones de escritorio, siempre llama a `PythonEngine.Shutdown()` cuando la aplicación se cierre, para evitar procesos de Python ejecutándose en segundo plano.

💻 [\[Ejemplo de Escritorio\]](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Desktop%20Example/MainWindow.xaml.cs#L68)

### 3. ¿Métodos o constructores faltantes?

Cada clase estática contiene un campo `self` de tipo `PyObject`, que puedes usar para crear instancias o llamar a métodos faltantes.
Si creas un objeto y estás seguro de su tipo, usa el método estático `Wrap(PyObject pyObject)` para convertirlo en un contenedor tipado:

```csharp
PyObject obj = sklearn.cluster.self.InvokeMethod("DBSCAN", your_custom_args);

var model = sklearn.cluster.DBSCAN.Wrap(obj);
model.fit(...);
```

## 💻 Aplicaciones de Escritorio

Este proyecto nació de la necesidad de usar algoritmos de clasificación dentro de las capacidades de UI enriquecida de C#, como WinForms y WPF, para construir aplicaciones complejas.
Aquí hay una aplicación simple que compara de forma interactiva métodos de clustering como DBSCAN, OPTICS y Mean Shift utilizando la librería de gráficos [ScottPlot](https://github.com/ScottPlot/ScottPlot):

[![](https://raw.githubusercontent.com/KosmosWerner/ScikitLearn.Net/refs/heads/master/Dev/cluster_dbscan.gif)](https://github.com/KosmosWerner/ScikitLearn.Net)

💻 [\[Código completo aquí\]](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Examples/Desktop%20Example)

## 🤝 Cómo Contribuir

Para facilitar el mantenimiento del proyecto, todas las declaraciones de clases y métodos se encuentran en el proyecto [ScikitLearn.Signatures](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Source/ScikitLearn.Signatures).

Si un método, constructor o clase tiene parámetros incorrectos, corrígelo o impleméntalo allí. Luego ejecuta el [CodeGenerator](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Source/CodeGenerator) para aplicar los cambios.

## 📝 Notas Finales

Este proyecto aún está en desarrollo temprano, por lo que algunas partes pueden estar incompletas o carecer de manejo de errores.
Se está trabajando en agregar pruebas que verifiquen los tipos de retorno y mejoren la seguridad de tipos.

## Licencias

Este proyecto está licenciado bajo la licencia MIT.

Envuelve y hace uso del proyecto Scikit-Learn, que está licenciado bajo la licencia BSD 3-Clause.
Consulta [LICENSE.scikit-learn](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/LICENSE.scikit-learn.txt) para más detalles.