# ScikitLearn.Net

[![](https://img.shields.io/nuget/dt/ScikitLearn?color=4cbb3b\&label=Downloads\&logo=NuGet\&style=flat-square)](https://www.nuget.org/packages/ScikitLearn)
[![](https://img.shields.io/nuget/v/ScikitLearn?color=0078D4\&logo=NuGet\&style=flat-square)](https://www.nuget.org/packages/ScikitLearn)

**Bindings de C# para Scikit-Learn**, focados em levar Machine Learning para o ambiente C#. Esta biblioteca fornece acesso simples a modelos de aprendizado de máquina, resultados, parâmetros e conjuntos de dados.

Construída sobre [Numpy.Bare](https://github.com/SciSharp/Numpy.NET) e baseada na [documentação do Scikit-Learn](https://scikit-learn.org/stable/index.html), suportando a maioria das classes e métodos.

[![📘 Leer en Español](https://img.shields.io/badge/📘%20Leer%20en-Español-blue?style=flat-square)](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/README-ES.md)
[![📗 Read in English](https://img.shields.io/badge/📗%20Read%20in-English-green?style=flat-square)](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/README.md)
[![📙 Ler em Português BR](https://img.shields.io/badge/📙%20Ler%20em-Português%20BR-orange?style=flat-square)](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/README-PT-BR.md)

## 🔧 Instalação

### Se você já tem o Python instalado

Defina o caminho para o seu arquivo `python311.dll` da seguinte forma:

```csharp
Runtime.PythonDLL = "seu_caminho_para_python311.dll";
```

Substitua `"seu_caminho_para_python311.dll"` pelo caminho real para `python311.dll` no seu sistema. Isso permite que o Sklearn.NET use sua instalação existente do Python.

### Instalando Python localmente

Se preferir uma instalação local do Python, **instale [Python.Included](https://github.com/henon/Python.Included) [pacote NuGet](https://www.nuget.org/packages/Python.Included/3.11.6) (versão 3.11.6)** e adicione o seguinte código para inicializar o ambiente:

```csharp
using Python.Included;
using Python.Runtime;
using Numpy;
using ScikitLearn;
```

```csharp
internal class Program
{
    // 🚨 AVISO: Este método REQUER conexão com a internet e pode levar vários minutos 
    // na primeira tentativa. Ele também pode FALHAR nas primeiras execuções.
    // ✅ RECOMENDAÇÃO: Depois que a pasta do Python for criada, reutilize-a em vários projetos 
    // para evitar essa demora no futuro.

    // Este método assíncrono instala NumPy e Scikit-learn.
    private static async Task InitializeInstallerAsync()
    {
        // Define o caminho de instalação desejado
        Installer.InstallPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    
        await Installer.SetupPython();
        await Installer.TryInstallPip();
        await Installer.PipInstallModule("numpy");
        await Installer.PipInstallModule("scikit-learn");
    }

    public static void Main(string[] args)
    {
        Task.Run(InitializeInstallerAsync).Wait();

        // Seu código aqui
    }
}
```

⚠️ **Nota:** O processo de instalação **requer conexão com a internet** e pode levar vários minutos na primeira execução. Também pode **falhar nas primeiras tentativas**.

✅ **Recomendação:** Depois que a pasta do Python for criada, **reutilize-a entre vários projetos** para evitar essa demora.

🖥️ [[Exemplo de Console]](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Console%20Example/Program.cs#L10)

💻 [[Exemplo de Desktop]](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Desktop%20Example/MainWindow.xaml.cs#L47)

## ⚙ Uso

Exemplo que replica [DBSCAN](https://scikit-learn.org/stable/modules/generated/sklearn.cluster.DBSCAN.html):

```csharp
var X = np.array(new int[,] {
    { 1, 2 }, { 2, 2 }, { 2, 3 },
    { 8, 7 }, { 8, 8 }, { 25, 25 } });

var clustering = new sklearn.cluster.DBSCAN(eps: 3, min_samples: 2).fit(X);
Console.WriteLine(clustering.labels_);
```

Saída:

```
[ 0  0  0  1  1 -1]
```

💻 [[Veja o código completo]](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Console%20Example/Program.cs)

## ⚠ Notas

### 1. 🚨 **Acessando o array `labels_` ou arrays de ponto flutuante** 🚨

O Scikit-Learn normalmente usa `ndarray(int64)`, que corresponde a `long[]` em C#. Use o seguinte para extrair os dados:

```csharp
long[] labels = my_model.labels_.GetData<long>();
```

⚠ **Se você precisar converter arrays de ponto flutuante para um formato C#, tenha muito cuidado com a conversão de tipos.**

```csharp
var x = sklearn.datasets.make_circles(n_samples: 1).X;
Console.WriteLine(x.GetData<float>()[0]);
Console.WriteLine(x.GetData<double>()[0]);
```

```
-1.5881868E-23 // usando float  [ERRO]
0.8            // usando double [OK]
```

No futuro, planeja-se retornar expressões do tipo `NDarray<double>` quando apropriado em vez de `NDarray`.
**Enquanto isso, verifique com testes unitários se os resultados correspondem ao esperado.**

### 2. PythonEngine.Shutdown()

Para aplicativos desktop, sempre chame `PythonEngine.Shutdown()` quando o aplicativo for fechado, para evitar que processos do Python fiquem executando em segundo plano.

💻 [[Exemplo de Desktop]](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/Examples/Desktop%20Example/MainWindow.xaml.cs#L68)

### 3. Métodos ou construtores faltando?

Cada classe estática contém um campo `self` do tipo `PyObject`, que você pode usar para criar instâncias ou chamar métodos ausentes.
Se você criar um objeto e tiver certeza do seu tipo, use o método estático `Wrap(PyObject pyObject)` para convertê-lo em um wrapper tipado:

```csharp
PyObject obj = sklearn.cluster.self.InvokeMethod("DBSCAN", your_custom_args);

var model = sklearn.cluster.DBSCAN.Wrap(obj);
model.fit(...);
```

## 💻 Aplicações Desktop

Este projeto nasceu da necessidade de usar algoritmos de classificação dentro dos recursos avançados de UI do C#, como WinForms e WPF, para construir aplicativos complexos.
Aqui está um aplicativo simples que compara interativamente métodos de clustering como DBSCAN, OPTICS e Mean Shift usando a biblioteca de gráficos [ScottPlot](https://github.com/ScottPlot/ScottPlot):

[![](https://raw.githubusercontent.com/KosmosWerner/ScikitLearn.Net/refs/heads/master/Dev/cluster_dbscan.gif)](https://github.com/KosmosWerner/ScikitLearn.Net)

💻 [[Código completo aqui]](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Examples/Desktop%20Example)

## 🤝 Como Contribuir

Para facilitar a manutenção do projeto, todas as declarações de classes e métodos estão localizadas no projeto [ScikitLearn.Signatures](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Source/ScikitLearn.Signatures).

Se um método, construtor ou classe tiver parâmetros incorretos, corrija ou implemente-o lá. Em seguida, execute o [CodeGenerator](https://github.com/KosmosWerner/ScikitLearn.Net/tree/master/Source/CodeGenerator) para aplicar as alterações.

## 📝 Notas Finais

Este projeto ainda está em desenvolvimento inicial, então algumas partes podem estar incompletas ou sem tratamento de erros.
Está em andamento o trabalho para adicionar testes que verifiquem os tipos de retorno e melhorem a segurança de tipos.

## Licenças

Este projeto é licenciado sob a licença MIT.

Ele envolve e utiliza o projeto Scikit-Learn, que é licenciado sob a licença BSD 3-Clause.
Consulte [LICENSE.scikit-learn](https://github.com/KosmosWerner/ScikitLearn.Net/blob/master/LICENSE.scikit-learn.txt) para mais detalhes.
