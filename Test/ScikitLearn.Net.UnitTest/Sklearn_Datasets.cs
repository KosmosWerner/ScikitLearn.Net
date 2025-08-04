using Numpy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ScikitLearn.Net.UnitTest;

public class Sklearn_Datasets
{
    [Fact]
    public async Task make_biclusters()
    {
        await Shared.InstallAsync();

        var (data, rows, cols) = sklearn.datasets.make_biclusters(
            shape: new int[] { 10, 20 },
            n_clusters: 2,
            random_state: 42);
        if (data is null) return;
        Assert.Equal(new Shape(10, 20), data);
        Assert.Equal(new Shape(2, 10), rows);
        Assert.Equal(new Shape(2, 20), cols);
    }

    [Fact]
    public async Task make_blobs()
    {
        await Shared.InstallAsync();

        var (X, y, _) = sklearn.datasets.make_blobs(
            n_samples: 10,
            centers: 3,
            n_features: 2,
            random_state: 0);

        Assert.Equal(new Shape(10, 2), X.shape);
        Assert.Equal(np.array(0, 0, 1, 0, 2, 2, 2, 1, 1, 0), y);

        (X, y, _) = sklearn.datasets.make_blobs(
            n_samples: new int[] { 3, 3, 4 },
            centers: null,
            n_features: 2,
            random_state: 0);

        Assert.Equal(new Shape(10, 2), X.shape);
        Assert.Equal(np.array(0, 1, 2, 0, 2, 2, 2, 1, 1, 0), y);
    }
}
