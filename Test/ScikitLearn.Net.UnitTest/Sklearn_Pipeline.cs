using Python.Included;
using Numpy;
using ScikitLearn;
using Python.Runtime;

namespace ScikitLearn.Net.UnitTest;

public class Sklearn_Pipeline
{
    [Fact]
    public async Task Pipeline()
    {
        await Shared.InstallAsync();

        var result = sklearn.datasets.make_classification(random_state: 0).X_y;
        if (result == null) return;

        NDarray a = sklearn.model_selection.train_test_split([result.Value.X, result.Value.y], random_state: 0);

        var pipe = new sklearn.pipeline.Pipeline(
            [
                ("scaler", new sklearn.preprocessing.StandardScaler()),
                ("svc", new sklearn.svm.SVC())
            ]);



        //Console.WriteLine(pipe.fit(X_train, y_train).score(X_test, y_test));

        //pipe.set_params(new()
        //{
        //    ["svc__C"] = new PyInt(10)
        //});
    }
}