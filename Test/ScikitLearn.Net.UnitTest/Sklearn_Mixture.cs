using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScikitLearn.Net.UnitTest;

public class Sklearn_Mixture
{
    [Fact]
    public async Task BayesianGaussianMixture()
    {
        await Shared.InstallAsync();

        var X = np.array(new int[,]{
            { 1, 2 },
            { 1, 4 },
            { 1, 0 },
            { 4, 2 },
            { 12, 4 },
            { 10, 7 }});

        var bgm = new sklearn.mixture.BayesianGaussianMixture(
            n_components: 2,
            random_state: 42).fit(X);

        //bgm.means_;
    }
}
