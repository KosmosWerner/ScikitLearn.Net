using Numpy;
using Python.Included;
using Python.Runtime;
using ScikitLearn;
using ScottPlot.WPF;
using System.IO;
using System.Windows;

namespace Desktop_Example;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Data points
    NDarray pointsA;
    NDarray pointsB;
    NDarray pointsC;


    public MainWindow()
    {
        InitializeComponent();
        Loaded += MainWindow_Loaded;
        Closed += MainWindow_Closed;

        // Install Python + dependencies
        Task.Run(InitializeInstallerAsync).Wait();

        // Generate initial datasets
        pointsA = np.random.rand(300, 2) * 20 - 10;
        pointsB = sklearn.datasets.make_blobs(n_samples: 1500, cluster_std: 2f).Item1 * 1;
        pointsC = sklearn.datasets.make_circles(n_samples: 1500, noise: 0.05f, factor: 0.5f).Item1 * 3;

        // Plot datasets
        PlotPoints(pointsA, plotDbcan1, plotOptics1, plotMean1);
        PlotPoints(pointsB, plotDbcan2, plotOptics2, plotMean2);
        PlotPoints(pointsC, plotDbcan3, plotOptics3, plotMean3);
    }


    // -------------------------
    // Setup
    // -------------------------

    private static async Task InitializeInstallerAsync()
    {
        Installer.InstallPath = Path.GetFullPath(".");
        await Installer.SetupPython();
        await Installer.TryInstallPip();
        await Installer.PipInstallModule("numpy");
        await Installer.PipInstallModule("scikit-learn");
    }

    // -------------------------
    // Window Events
    // -------------------------

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        // Link plots for synchronized zooming/panning
        LinkPlots(plotDbcan1, plotOptics1, plotMean1);
        LinkPlots(plotDbcan2, plotOptics2, plotMean2);
        LinkPlots(plotDbcan3, plotOptics3, plotMean3);
    }

    private void MainWindow_Closed(object? sender, EventArgs e)
    {
        PythonEngine.Shutdown();
    }

    // -------------------------
    // Classification Methods
    // -------------------------

    private void ClassifyBDSCAN(NDarray points, WpfPlot outputPlot)
    {
        if (!(boolDBSCAN.IsChecked ?? false)) return;

        var model = new sklearn.cluster.DBSCAN(
            eps: (float)sliderEPS.Value,
            min_samples: (int)sliderMinSamples.Value);

        NDarray labels = model.fit_predict(points);
        PlotClusters(points, labels, outputPlot);
    }

    private void ClassifyOPTICS(NDarray points, WpfPlot outputPlot)
    {
        if (!(boolOPTICS.IsChecked ?? false)) return;

        var model = new sklearn.cluster.OPTICS(
            min_samples: (int)slMin_Samples2.Value)
            .fit(points);

        NDarray labels = model.labels_;
        PlotClusters(points, labels, outputPlot);
    }

    private void ClassifyMeanShift(NDarray points, WpfPlot outputPlot)
    {
        if (!(boolMeanShift.IsChecked ?? false)) return;

        var model = new sklearn.cluster.MeanShift(
            bandwidth: (float)slBandWidth.Value)
            .fit(points);

        NDarray labels = model.labels_;
        PlotClusters(points, labels, outputPlot);
    }

    private void PlotClusters(NDarray points, NDarray labels, WpfPlot outputPlot)
    {
        var tags = labels.GetData<long>();
        var (min, max) = (tags.Min(), tags.Max());

        outputPlot.Plot.Clear();

        for (var i = min; i <= max; i++)
        {
            var indices = labels.equals(i);
            var xs = points[":,0"][indices].GetData<float>();
            var ys = points[":,1"][indices].GetData<float>();
            ScottPlot.Color color = (i == -1) ? ScottPlot.Colors.Gray : ScottPlot.Color.RandomHue();

            outputPlot.Plot.Add.ScatterPoints(xs, ys, color);
        }

        outputPlot.Refresh();
    }

    // -------------------------
    // Point Generation (Reset)
    // -------------------------

    public void ResetPointsA()
    {
        pointsA = np.random.rand(300, 2) * 20 - 10;
        PlotPoints(pointsA, plotDbcan1, plotOptics1, plotMean1);
    }

    public void ResetPointsB()
    {
        pointsB = sklearn.datasets.make_blobs(n_samples: 1500, cluster_std: 2f).Item1;
        PlotPoints(pointsB, plotDbcan2, plotOptics2, plotMean2);
    }

    public void ResetPointsC()
    {
        pointsC = sklearn.datasets.make_circles(n_samples: 1500, noise: 0.05f, factor: 0.5f).Item1 * 3;
        PlotPoints(pointsC, plotDbcan3, plotOptics3, plotMean3);
    }

    private void ButtonGenerate_Click(object sender, RoutedEventArgs e)
    {
        ResetPointsA();
        ResetPointsB();
        ResetPointsC();
    }

    // -------------------------
    // Plotting
    // -------------------------

    private void PlotPoints(NDarray points, WpfPlot plot1, WpfPlot plot2, WpfPlot plot3, bool clear = true)
    {
        if (clear)
        {
            plot1.Plot.Clear();
            plot2.Plot.Clear();
            plot3.Plot.Clear();
        }

        var xs = points[":,0"].GetData<float>();
        var ys = points[":,1"].GetData<float>();

        plot1.Plot.Add.ScatterPoints(xs, ys);
        plot2.Plot.Add.ScatterPoints(xs, ys);
        plot3.Plot.Add.ScatterPoints(xs, ys);

        plot1.Refresh();
        plot2.Refresh();
        plot3.Refresh();
    }

    private void LinkPlots(WpfPlot p1, WpfPlot p2, WpfPlot p3)
    {
        p1.Plot.Axes.Link(p2);
        p1.Plot.Axes.Link(p3);
        p2.Plot.Axes.Link(p1);
        p2.Plot.Axes.Link(p3);
        p3.Plot.Axes.Link(p1);
        p3.Plot.Axes.Link(p2);
    }

    // -------------------------
    // Classification Handlers
    // -------------------------

    private void ButtonClassify_Click(object sender, RoutedEventArgs e)
    {
        ClassifyBDSCAN(pointsA, plotDbcan1);
        ClassifyBDSCAN(pointsB, plotDbcan2);
        ClassifyBDSCAN(pointsC, plotDbcan3);

        ClassifyOPTICS(pointsA, plotOptics1);
        ClassifyOPTICS(pointsB, plotOptics2);
        ClassifyOPTICS(pointsC, plotOptics3);

        ClassifyMeanShift(pointsA, plotMean1);
        ClassifyMeanShift(pointsB, plotMean2);
        ClassifyMeanShift(pointsC, plotMean3);
    }
}