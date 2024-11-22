using Python.Included;
using Python.Runtime;
using Numpy;
using ScikitLearn;
using ScottPlot.WPF;
using System.IO;
using System.Windows;

namespace ExampleCluster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] coordinates1x;
        double[] coordinates1y;

        double[] coordinates2x;
        double[] coordinates2y;

        double[] coordinates3x;
        double[] coordinates3y;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            Closed += MainWindow_Closed;

            Task.Run(InitializeInstallerAsync).Wait();
            GenerateRandomPoints();
            GenerateRandomGroups();
            GenerateRandomCircles();
        }

        private void MainWindow_Closed(object? sender, EventArgs e)
        {
            PythonEngine.Shutdown();
        }

        readonly Random random = new(42);

        private static async Task InitializeInstallerAsync()
        {
            Installer.InstallPath = Path.GetFullPath(".");

            await Installer.SetupPython();
            await Installer.TryInstallPip();
            await Installer.PipInstallModule("numpy");
            await Installer.PipInstallModule("scikit-learn");
        }

        public void GenerateRandomPoints()
        {
            int count = 300;
            coordinates1x = new double[count];
            coordinates1y = new double[count];
            for (int i = 0; i < count; i++)
            {
                coordinates1x[i] = -10 + random.NextDouble() * 20;
                coordinates1y[i] = -10 + random.NextDouble() * 20;
            }

            PlotRandomPoints(coordinates1x, coordinates1y, plotDbcan1, plotOptics1, plotMean1);
        }

        public void GenerateRandomGroups()
        {
            (var X, _, _) = sklearn.datasets.make_blobs(n_samples: 1500, cluster_std: 2f);
            if (X == null) return;
            NDarray xs = X[":,0"];
            NDarray ys = X[":,1"];
            coordinates2x = xs.GetData<double>();
            coordinates2y = ys.GetData<double>();

            PlotRandomPoints(coordinates2x, coordinates2y, plotDbcan2, plotOptics2, plotMean2);
        }

        public void GenerateRandomCircles()
        {
            (var X, _) = sklearn.datasets.make_circles(n_samples: 1500, noise: 0.05f, factor: 0.5f);
            if (X == null) return;
            X = X * 10;
            NDarray xs = X[":,0"];
            NDarray ys = X[":,1"];
            coordinates3x = xs.GetData<double>();
            coordinates3y = ys.GetData<double>();

            PlotRandomPoints(coordinates3x, coordinates3y, plotDbcan3, plotOptics3, plotMean3);
        }

        private void ButtonGenerate_Click(object sender, RoutedEventArgs e)
        {
            GenerateRandomPoints();
            GenerateRandomGroups();
            GenerateRandomCircles();
        }

        private void ClassifyBDSCAN(double[] _xs, double[] _ys, WpfPlot plot)
        {
            if (!(boolDBSCAN.IsChecked ?? false)) return;

            var xs = np.array(_xs);
            var ys = np.array(_ys);

            NDarray X = np.vstack(xs, ys).T;
            var model = new sklearn.cluster.DBSCAN(eps: (float)slEps.Value, min_samples: (int)slMinSamples.Value);

            NDarray labels = model.fit_predict(X);

            var tags = labels.GetData<long>();
            var min = tags.Min();
            var max = tags.Max();

            plot.Plot.Clear();
            for (var i = min; i <= max; i++)
            {
                List<double> lx = [];
                List<double> ly = [];

                for (int j = 0; j < tags.Length; j++)
                {
                    if (tags[j] != i) continue;
                    lx.Add(_xs[j]);
                    ly.Add(_ys[j]);
                }

                plot.Plot.Add.ScatterPoints(lx, ly, color: (i == -1) ? ScottPlot.Colors.Gray : ScottPlot.Color.RandomHue());
            }

            plot.Refresh();
        }

        private void ClassifyOPTICS(double[] _xs, double[] _ys, WpfPlot plot)
        {
            if (!(boolOPTICS.IsChecked ?? false)) return;

            var xs = np.array(_xs);
            var ys = np.array(_ys);

            NDarray X = np.vstack(xs, ys).T;

            var model = new sklearn.cluster.OPTICS(min_samples: (int)slMin_Samples2.Value).fit(X);

            NDarray labels = model.labels_;
            var tags = labels.GetData<long>();
            var min = tags.Min();
            var max = tags.Max();

            plot.Plot.Clear();
            for (var i = min; i <= max; i++)
            {
                List<double> lx = [];
                List<double> ly = [];

                for (int j = 0; j < tags.Length; j++)
                {
                    if (tags[j] != i) continue;
                    lx.Add(_xs[j]);
                    ly.Add(_ys[j]);
                }

                plot.Plot.Add.ScatterPoints(lx, ly, color: (i == -1) ? ScottPlot.Colors.Gray : ScottPlot.Color.RandomHue());
            }

            plot.Refresh();
        }

        private void ClassifyMeanShift(double[] _xs, double[] _ys, WpfPlot plot)
        {
            if (!(boolMeanShift.IsChecked ?? false)) return;

            var xs = np.array(_xs);
            var ys = np.array(_ys);

            NDarray X = np.vstack(xs, ys).T;

            var model = new sklearn.cluster.MeanShift(bandwidth: (float)slBandWidth.Value).fit(X);

            NDarray labels = model.labels_;
            var tags = labels.GetData<long>();
            var min = tags.Min();
            var max = tags.Max();

            plot.Plot.Clear();
            for (var i = min; i <= max; i++)
            {
                List<double> lx = [];
                List<double> ly = [];

                for (int j = 0; j < tags.Length; j++)
                {
                    if (tags[j] != i) continue;
                    lx.Add(_xs[j]);
                    ly.Add(_ys[j]);
                }

                plot.Plot.Add.ScatterPoints(lx, ly, color: (i == -1) ? ScottPlot.Colors.Gray : ScottPlot.Color.RandomHue());
            }

            plot.Refresh();
        }

        private void ButtonClassify_Click(object sender, RoutedEventArgs e)
        {
            ClassifyBDSCAN(coordinates1x, coordinates1y, plotDbcan1);
            ClassifyBDSCAN(coordinates2x, coordinates2y, plotDbcan2);
            ClassifyBDSCAN(coordinates3x, coordinates3y, plotDbcan3);

            ClassifyOPTICS(coordinates1x, coordinates1y, plotOptics1);
            ClassifyOPTICS(coordinates2x, coordinates2y, plotOptics2);
            ClassifyOPTICS(coordinates3x, coordinates3y, plotOptics3);

            ClassifyMeanShift(coordinates1x, coordinates1y, plotMean1);
            ClassifyMeanShift(coordinates2x, coordinates2y, plotMean2);
            ClassifyMeanShift(coordinates3x, coordinates3y, plotMean3);
        }

        private void PlotRandomPoints(double[] coordinatesx, double[] coordinatesy, WpfPlot plotDbcan, WpfPlot plotOptics, WpfPlot plotMean, bool clear = true)
        {
            if (clear)
            {
                plotDbcan.Plot.Clear();
                plotOptics.Plot.Clear();
                plotMean.Plot.Clear();
            }
            plotDbcan.Plot.Add.ScatterPoints(coordinatesx, coordinatesy);
            plotOptics.Plot.Add.ScatterPoints(coordinatesx, coordinatesy);
            plotMean.Plot.Add.ScatterPoints(coordinatesx, coordinatesy);
            plotDbcan.Refresh();
            plotOptics.Refresh();
            plotMean.Refresh();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            plotDbcan1.Plot.Axes.Link(plotOptics1);
            plotDbcan1.Plot.Axes.Link(plotMean1);

            plotOptics1.Plot.Axes.Link(plotDbcan1);
            plotOptics1.Plot.Axes.Link(plotMean1);

            plotMean1.Plot.Axes.Link(plotDbcan1);
            plotMean1.Plot.Axes.Link(plotOptics1);



            plotDbcan2.Plot.Axes.Link(plotOptics2);
            plotDbcan2.Plot.Axes.Link(plotMean2);

            plotOptics2.Plot.Axes.Link(plotDbcan2);
            plotOptics2.Plot.Axes.Link(plotMean2);

            plotMean2.Plot.Axes.Link(plotDbcan2);
            plotMean2.Plot.Axes.Link(plotOptics2);


            plotDbcan3.Plot.Axes.Link(plotOptics3);
            plotDbcan3.Plot.Axes.Link(plotMean3);

            plotOptics3.Plot.Axes.Link(plotDbcan3);
            plotOptics3.Plot.Axes.Link(plotMean3);

            plotMean3.Plot.Axes.Link(plotDbcan3);
            plotMean3.Plot.Axes.Link(plotOptics3);
        }
    }
}