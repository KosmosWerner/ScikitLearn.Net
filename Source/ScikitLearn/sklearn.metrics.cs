using System;
using System.Collections.Generic;
using Numpy;
using Python.Runtime;

namespace ScikitLearn
{
    public static partial class sklearn
    {
        public static class metrics
        {
            private static Lazy<PyObject> _lazy_self;
            public static PyObject self { get => _lazy_self.Value; }

            private static void ReInitializeLazySelf()
            {
                _lazy_self = new Lazy<PyObject>(() =>
                {
                    try
                    {
                        return InstallAndImport();
                    }
                    catch (Exception)
                    {
                        return InstallAndImport(true);
                    }
                });
            }

            private static PyObject InstallAndImport(bool force = false)
            {
                PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
                PythonEngine.Initialize();
                return Py.Import("sklearn.metrics");
            }

            static metrics()
            {
                ReInitializeLazySelf();
            }

            public static PyObject check_scoring(PyObject? estimator = null, PyDict? scoring = null, bool allow_none = false)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                if (estimator != null)
                    pyDict["estimator"] = Helpers.ToPython(estimator);
                if (scoring != null)
                    pyDict["scoring"] = Helpers.ToPython(scoring);
                if (allow_none != false)
                    pyDict["allow_none"] = Helpers.ToPython(allow_none);
                return sklearn.metrics.self.InvokeMethod("check_scoring", args, pyDict);
            }

            public static PyObject get_scorer(string scoring)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(scoring)]);
                PyDict pyDict = new PyDict();
                return sklearn.metrics.self.InvokeMethod("get_scorer", args, pyDict);
            }

            public static PyTuple get_scorer_names()
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple();
                PyDict pyDict = new PyDict();
                return new PyTuple(sklearn.metrics.self.InvokeMethod("get_scorer_names", args, pyDict));
            }

            public static PyObject make_scorer(PyObject score_func, PyDict? response_method = null, bool greater_is_better = true, string needs_proba = "deprecated", string needs_threshold = "deprecated", Dictionary<string, PyObject>? @params = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(score_func)]);
                PyDict pyDict = new PyDict();
                if (response_method != null)
                    pyDict["response_method"] = Helpers.ToPython(response_method);
                if (greater_is_better != true)
                    pyDict["greater_is_better"] = Helpers.ToPython(greater_is_better);
                if (needs_proba != "deprecated")
                    pyDict["needs_proba"] = Helpers.ToPython(needs_proba);
                if (needs_threshold != "deprecated")
                    pyDict["needs_threshold"] = Helpers.ToPython(needs_threshold);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return sklearn.metrics.self.InvokeMethod("make_scorer", args, pyDict);
            }

            public static float accuracy_score(NDarray y_true, NDarray y_pred, bool normalize = true, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (normalize != true)
                    pyDict["normalize"] = Helpers.ToPython(normalize);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("accuracy_score", args, pyDict));
            }

            public static float auc(NDarray x, NDarray y)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(x), Helpers.ToPython(y)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("auc", args, pyDict));
            }

            public static float average_precision_score(NDarray y_true, NDarray y_score, string? average = "macro", int pos_label = 1, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (average != "macro")
                    pyDict["average"] = Helpers.ToPython(average);
                if (pos_label != 1)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("average_precision_score", args, pyDict));
            }

            public static float balanced_accuracy_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, bool adjusted = false)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (adjusted != false)
                    pyDict["adjusted"] = Helpers.ToPython(adjusted);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("balanced_accuracy_score", args, pyDict));
            }

            public static float brier_score_loss(NDarray y_true, NDarray? y_proba = null, NDarray? sample_weight = null, string? pos_label = null, string y_prob = "deprecated")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true)]);
                PyDict pyDict = new PyDict();
                if (y_proba != null)
                    pyDict["y_proba"] = Helpers.ToPython(y_proba);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (pos_label != null)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (y_prob != "deprecated")
                    pyDict["y_prob"] = Helpers.ToPython(y_prob);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("brier_score_loss", args, pyDict));
            }

            public static PyTuple class_likelihood_ratios(NDarray y_true, NDarray y_pred, NDarray? labels = null, NDarray? sample_weight = null, bool raise_warning = true)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (raise_warning != true)
                    pyDict["raise_warning"] = Helpers.ToPython(raise_warning);
                return new PyTuple(sklearn.metrics.self.InvokeMethod("class_likelihood_ratios", args, pyDict));
            }

            public static PyDict classification_report(NDarray y_true, NDarray y_pred, NDarray? labels = null, NDarray? target_names = null, NDarray? sample_weight = null, int digits = 2, bool output_dict = false, string zero_division = "warn")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (target_names != null)
                    pyDict["target_names"] = Helpers.ToPython(target_names);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (digits != 2)
                    pyDict["digits"] = Helpers.ToPython(digits);
                if (output_dict != false)
                    pyDict["output_dict"] = Helpers.ToPython(output_dict);
                if (zero_division != "warn")
                    pyDict["zero_division"] = Helpers.ToPython(zero_division);
                return new PyDict(sklearn.metrics.self.InvokeMethod("classification_report", args, pyDict));
            }

            public static float cohen_kappa_score(NDarray y1, NDarray y2, NDarray? labels = null, PyObject? weights = null, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y1), Helpers.ToPython(y2)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (weights != null)
                    pyDict["weights"] = Helpers.ToPython(weights);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("cohen_kappa_score", args, pyDict));
            }

            public static NDarray confusion_matrix(NDarray y_true, NDarray y_pred, NDarray? labels = null, NDarray? sample_weight = null, PyObject? normalize = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (normalize != null)
                    pyDict["normalize"] = Helpers.ToPython(normalize);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("confusion_matrix", args, pyDict));
            }

            public static NDarray d2_log_loss_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, NDarray? labels = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("d2_log_loss_score", args, pyDict));
            }

            public static float dcg_score(NDarray y_true, NDarray y_score, int? k = null, int log_base = 2, NDarray? sample_weight = null, bool ignore_ties = false)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (k != null)
                    pyDict["k"] = Helpers.ToPython(k);
                if (log_base != 2)
                    pyDict["log_base"] = Helpers.ToPython(log_base);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (ignore_ties != false)
                    pyDict["ignore_ties"] = Helpers.ToPython(ignore_ties);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("dcg_score", args, pyDict));
            }

            public static (NDarray? , NDarray? , NDarray? ) det_curve(NDarray y_true, NDarray y_score, string? pos_label = null, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (pos_label != null)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                PyTuple result = new PyTuple(sklearn.metrics.self.InvokeMethod("det_curve", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null);
            }

            public static NDarray f1_score(NDarray y_true, NDarray y_pred, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (pos_label != 1)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (average != "binary")
                    pyDict["average"] = Helpers.ToPython(average);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (zero_division != "warn")
                    pyDict["zero_division"] = Helpers.ToPython(zero_division);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("f1_score", args, pyDict));
            }

            public static NDarray? fbeta_score(NDarray y_true, NDarray y_pred, float beta, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred), Helpers.ToPython(beta)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (pos_label != 1)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (average != "binary")
                    pyDict["average"] = Helpers.ToPython(average);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (zero_division != "warn")
                    pyDict["zero_division"] = Helpers.ToPython(zero_division);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("fbeta_score", args, pyDict));
            }

            public static float hamming_loss(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("hamming_loss", args, pyDict));
            }

            public static float hinge_loss(NDarray y_true, NDarray pred_decision, NDarray? labels = null, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(pred_decision)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("hinge_loss", args, pyDict));
            }

            public static NDarray jaccard_score(NDarray y_true, NDarray y_pred, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (pos_label != 1)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (average != "binary")
                    pyDict["average"] = Helpers.ToPython(average);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (zero_division != "warn")
                    pyDict["zero_division"] = Helpers.ToPython(zero_division);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("jaccard_score", args, pyDict));
            }

            public static float log_loss(NDarray y_true, NDarray y_pred, bool normalize = true, NDarray? sample_weight = null, NDarray? labels = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (normalize != true)
                    pyDict["normalize"] = Helpers.ToPython(normalize);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("log_loss", args, pyDict));
            }

            public static float matthews_corrcoef(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("matthews_corrcoef", args, pyDict));
            }

            public static NDarray multilabel_confusion_matrix(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, NDarray? labels = null, bool samplewise = false)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (samplewise != false)
                    pyDict["samplewise"] = Helpers.ToPython(samplewise);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("multilabel_confusion_matrix", args, pyDict));
            }

            public static float ndcg_score(NDarray y_true, NDarray y_score, int? k = null, NDarray? sample_weight = null, bool ignore_ties = false)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (k != null)
                    pyDict["k"] = Helpers.ToPython(k);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (ignore_ties != false)
                    pyDict["ignore_ties"] = Helpers.ToPython(ignore_ties);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("ndcg_score", args, pyDict));
            }

            public static (NDarray? , NDarray? , NDarray? ) precision_recall_curve(NDarray y_true, NDarray? y_score = null, string? pos_label = null, NDarray? sample_weight = null, bool drop_intermediate = false, string probas_pred = "deprecated")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true)]);
                PyDict pyDict = new PyDict();
                if (y_score != null)
                    pyDict["y_score"] = Helpers.ToPython(y_score);
                if (pos_label != null)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (drop_intermediate != false)
                    pyDict["drop_intermediate"] = Helpers.ToPython(drop_intermediate);
                if (probas_pred != "deprecated")
                    pyDict["probas_pred"] = Helpers.ToPython(probas_pred);
                PyTuple result = new PyTuple(sklearn.metrics.self.InvokeMethod("precision_recall_curve", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null);
            }

            public static (NDarray ?? ,  NDarray ?? ,  NDarray ?? ,  NDarray ?? )precision_recall_fscore_support(NDarray y_true, NDarray y_pred, float beta = 1.0f, NDarray? labels = null, int pos_label = 1, PyObject? average = null, PyTuple? warn_for = null, NDarray? sample_weight = null, string zero_division = "warn")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (beta != 1.0f)
                    pyDict["beta"] = Helpers.ToPython(beta);
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (pos_label != 1)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (average != null)
                    pyDict["average"] = Helpers.ToPython(average);
                if (warn_for != null)
                    pyDict["warn_for"] = Helpers.ToPython(warn_for);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (zero_division != "warn")
                    pyDict["zero_division"] = Helpers.ToPython(zero_division);
                PyTuple result = new PyTuple(sklearn.metrics.self.InvokeMethod("precision_recall_fscore_support", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null, __length > 3 ? Helpers.ToCSharpNDarray(result[3]) : null);
            }

            public static NDarray? precision_score(NDarray y_true, NDarray y_pred, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (pos_label != 1)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (average != "binary")
                    pyDict["average"] = Helpers.ToPython(average);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (zero_division != "warn")
                    pyDict["zero_division"] = Helpers.ToPython(zero_division);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("precision_score", args, pyDict));
            }

            public static NDarray? recall_score(NDarray y_true, NDarray y_pred, NDarray? labels = null, int pos_label = 1, string? average = "binary", NDarray? sample_weight = null, string zero_division = "warn")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                if (pos_label != 1)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (average != "binary")
                    pyDict["average"] = Helpers.ToPython(average);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (zero_division != "warn")
                    pyDict["zero_division"] = Helpers.ToPython(zero_division);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("recall_score", args, pyDict));
            }

            public static float roc_auc_score(NDarray y_true, NDarray y_score, string? average = "macro", NDarray? sample_weight = null, float? max_fpr = null, string multi_class = "raise", NDarray? labels = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (average != "macro")
                    pyDict["average"] = Helpers.ToPython(average);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (max_fpr != null)
                    pyDict["max_fpr"] = Helpers.ToPython(max_fpr);
                if (multi_class != "raise")
                    pyDict["multi_class"] = Helpers.ToPython(multi_class);
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("roc_auc_score", args, pyDict));
            }

            public static (NDarray? , NDarray? , NDarray? ) roc_curve(NDarray y_true, NDarray y_score, string? pos_label = null, NDarray? sample_weight = null, bool drop_intermediate = true)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (pos_label != null)
                    pyDict["pos_label"] = Helpers.ToPython(pos_label);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (drop_intermediate != true)
                    pyDict["drop_intermediate"] = Helpers.ToPython(drop_intermediate);
                PyTuple result = new PyTuple(sklearn.metrics.self.InvokeMethod("roc_curve", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null, __length > 2 ? Helpers.ToCSharpNDarray(result[2]) : null);
            }

            public static float top_k_accuracy_score(NDarray y_true, NDarray y_score, int k = 2, bool normalize = true, NDarray? sample_weight = null, NDarray? labels = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (k != 2)
                    pyDict["k"] = Helpers.ToPython(k);
                if (normalize != true)
                    pyDict["normalize"] = Helpers.ToPython(normalize);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (labels != null)
                    pyDict["labels"] = Helpers.ToPython(labels);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("top_k_accuracy_score", args, pyDict));
            }

            public static float zero_one_loss(NDarray y_true, NDarray y_pred, bool normalize = true, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (normalize != true)
                    pyDict["normalize"] = Helpers.ToPython(normalize);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("zero_one_loss", args, pyDict));
            }

            public static NDarray d2_absolute_error_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("d2_absolute_error_score", args, pyDict));
            }

            public static NDarray d2_pinball_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, float alpha = 0.5f, string multioutput = "uniform_average")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (alpha != 0.5f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("d2_pinball_score", args, pyDict));
            }

            public static NDarray d2_tweedie_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, int power = 0)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (power != 0)
                    pyDict["power"] = Helpers.ToPython(power);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("d2_tweedie_score", args, pyDict));
            }

            public static NDarray explained_variance_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average", bool force_finite = true)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                if (force_finite != true)
                    pyDict["force_finite"] = Helpers.ToPython(force_finite);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("explained_variance_score", args, pyDict));
            }

            public static float max_error(NDarray y_true, NDarray y_pred)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("max_error", args, pyDict));
            }

            public static NDarray mean_absolute_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("mean_absolute_error", args, pyDict));
            }

            public static NDarray mean_absolute_percentage_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("mean_absolute_percentage_error", args, pyDict));
            }

            public static float mean_gamma_deviance(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("mean_gamma_deviance", args, pyDict));
            }

            public static NDarray mean_pinball_loss(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, float alpha = 0.5f, string multioutput = "uniform_average")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (alpha != 0.5f)
                    pyDict["alpha"] = Helpers.ToPython(alpha);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("mean_pinball_loss", args, pyDict));
            }

            public static float mean_poisson_deviance(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("mean_poisson_deviance", args, pyDict));
            }

            public static NDarray mean_squared_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average", string squared = "deprecated")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                if (squared != "deprecated")
                    pyDict["squared"] = Helpers.ToPython(squared);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("mean_squared_error", args, pyDict));
            }

            public static NDarray mean_squared_log_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average", string squared = "deprecated")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                if (squared != "deprecated")
                    pyDict["squared"] = Helpers.ToPython(squared);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("mean_squared_log_error", args, pyDict));
            }

            public static float mean_tweedie_deviance(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, int power = 0)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (power != 0)
                    pyDict["power"] = Helpers.ToPython(power);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("mean_tweedie_deviance", args, pyDict));
            }

            public static NDarray median_absolute_error(NDarray y_true, NDarray y_pred, string multioutput = "uniform_average", NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("median_absolute_error", args, pyDict));
            }

            public static NDarray r2_score(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string? multioutput = "uniform_average", bool force_finite = true)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                if (force_finite != true)
                    pyDict["force_finite"] = Helpers.ToPython(force_finite);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("r2_score", args, pyDict));
            }

            public static NDarray root_mean_squared_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("root_mean_squared_error", args, pyDict));
            }

            public static NDarray root_mean_squared_log_error(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string multioutput = "uniform_average")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                if (multioutput != "uniform_average")
                    pyDict["multioutput"] = Helpers.ToPython(multioutput);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("root_mean_squared_log_error", args, pyDict));
            }

            public static float coverage_error(NDarray y_true, NDarray y_score, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("coverage_error", args, pyDict));
            }

            public static float label_ranking_average_precision_score(NDarray y_true, NDarray y_score, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("label_ranking_average_precision_score", args, pyDict));
            }

            public static float label_ranking_loss(NDarray y_true, NDarray y_score, NDarray? sample_weight = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_score)]);
                PyDict pyDict = new PyDict();
                if (sample_weight != null)
                    pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("label_ranking_loss", args, pyDict));
            }

            public static float adjusted_mutual_info_score(NDarray labels_true, NDarray labels_pred, string average_method = "arithmetic")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                if (average_method != "arithmetic")
                    pyDict["average_method"] = Helpers.ToPython(average_method);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("adjusted_mutual_info_score", args, pyDict));
            }

            public static float adjusted_rand_score(NDarray labels_true, NDarray labels_pred)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("adjusted_rand_score", args, pyDict));
            }

            public static float calinski_harabasz_score(NDarray X, NDarray labels)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(labels)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("calinski_harabasz_score", args, pyDict));
            }

            public static float completeness_score(NDarray labels_true, NDarray labels_pred)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("completeness_score", args, pyDict));
            }

            public static float davies_bouldin_score(NDarray X, NDarray labels)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(labels)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("davies_bouldin_score", args, pyDict));
            }

            public static float fowlkes_mallows_score(NDarray labels_true, NDarray labels_pred, bool sparse = false)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                if (sparse != false)
                    pyDict["sparse"] = Helpers.ToPython(sparse);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("fowlkes_mallows_score", args, pyDict));
            }

            public static (float? , float? , float? ) homogeneity_completeness_v_measure(NDarray labels_true, NDarray labels_pred, float beta = 1.0f)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                if (beta != 1.0f)
                    pyDict["beta"] = Helpers.ToPython(beta);
                PyTuple result = new PyTuple(sklearn.metrics.self.InvokeMethod("homogeneity_completeness_v_measure", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpFloat(result[0]) : null, __length > 1 ? Helpers.ToCSharpFloat(result[1]) : null, __length > 2 ? Helpers.ToCSharpFloat(result[2]) : null);
            }

            public static float homogeneity_score(NDarray labels_true, NDarray labels_pred)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("homogeneity_score", args, pyDict));
            }

            public static float mutual_info_score(NDarray labels_true, NDarray labels_pred, NDarray? contingency = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                if (contingency != null)
                    pyDict["contingency"] = Helpers.ToPython(contingency);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("mutual_info_score", args, pyDict));
            }

            public static float normalized_mutual_info_score(NDarray labels_true, NDarray labels_pred, string average_method = "arithmetic")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                if (average_method != "arithmetic")
                    pyDict["average_method"] = Helpers.ToPython(average_method);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("normalized_mutual_info_score", args, pyDict));
            }

            public static float rand_score(NDarray labels_true, NDarray labels_pred)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("rand_score", args, pyDict));
            }

            public static NDarray silhouette_samples(NDarray X, NDarray labels, string metric = "euclidean", Dictionary<string, PyObject>? @params = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(labels)]);
                PyDict pyDict = new PyDict();
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("silhouette_samples", args, pyDict));
            }

            public static float silhouette_score(NDarray X, NDarray labels, string metric = "euclidean", int? sample_size = null, int? random_state = null, Dictionary<string, PyObject>? @params = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(labels)]);
                PyDict pyDict = new PyDict();
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (sample_size != null)
                    pyDict["sample_size"] = Helpers.ToPython(sample_size);
                if (random_state != null)
                    pyDict["random_state"] = Helpers.ToPython(random_state);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("silhouette_score", args, pyDict));
            }

            public static float v_measure_score(NDarray labels_true, NDarray labels_pred, float beta = 1.0f)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                PyDict pyDict = new PyDict();
                if (beta != 1.0f)
                    pyDict["beta"] = Helpers.ToPython(beta);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("v_measure_score", args, pyDict));
            }

            public static float consensus_score(PyTuple a, PyTuple b, string similarity = "jaccard")
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(a), Helpers.ToPython(b)]);
                PyDict pyDict = new PyDict();
                if (similarity != "jaccard")
                    pyDict["similarity"] = Helpers.ToPython(similarity);
                return Helpers.ToCSharpFloat(sklearn.metrics.self.InvokeMethod("consensus_score", args, pyDict));
            }

            public class DistanceMetric : PythonObject
            {
                public DistanceMetric()
                {
                    _ = sklearn.metrics.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    self = sklearn.metrics.self.InvokeMethod("DistanceMetric", args, pyDict);
                }

                internal DistanceMetric(PyObject pyObject)
                {
                    _ = sklearn.metrics.self;
                    self = pyObject;
                }

                public static DistanceMetric Encapsule(PyObject pyObject)
                {
                    return new DistanceMetric(pyObject);
                }

                public PyObject get_metric(string metric, float? dtype = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(metric)]);
                    PyDict pyDict = new PyDict();
                    if (dtype != null)
                        pyDict["dtype"] = Helpers.ToPython(dtype);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("get_metric", args, pyDict);
                }
            }

            public static NDarray pairwise_distances(NDarray X, NDarray? Y = null, string metric = "euclidean", int? n_jobs = null, bool force_all_finite = true, Dictionary<string, PyObject>? @params = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (force_all_finite != true)
                    pyDict["force_all_finite"] = Helpers.ToPython(force_all_finite);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("pairwise_distances", args, pyDict));
            }

            public static NDarray pairwise_distances_argmin(NDarray X, NDarray Y, int axis = 1, string metric = "euclidean", PyDict? metric_kwargs = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(Y)]);
                PyDict pyDict = new PyDict();
                if (axis != 1)
                    pyDict["axis"] = Helpers.ToPython(axis);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (metric_kwargs != null)
                    pyDict["metric_kwargs"] = Helpers.ToPython(metric_kwargs);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("pairwise_distances_argmin", args, pyDict));
            }

            public static (NDarray? , NDarray? ) pairwise_distances_argmin_min(NDarray X, NDarray Y, int axis = 1, string metric = "euclidean", PyDict? metric_kwargs = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(Y)]);
                PyDict pyDict = new PyDict();
                if (axis != 1)
                    pyDict["axis"] = Helpers.ToPython(axis);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (metric_kwargs != null)
                    pyDict["metric_kwargs"] = Helpers.ToPython(metric_kwargs);
                PyTuple result = new PyTuple(sklearn.metrics.self.InvokeMethod("pairwise_distances_argmin_min", args, pyDict));
                var __length = result.Length();
                return (__length > 0 ? Helpers.ToCSharpNDarray(result[0]) : null, __length > 1 ? Helpers.ToCSharpNDarray(result[1]) : null);
            }

            public static NDarray pairwise_distances_chunked(NDarray X, NDarray? Y = null, PyObject? reduce_func = null, string metric = "euclidean", int? n_jobs = null, float? working_memory = null, Dictionary<string, PyObject>? @params = null)
            {
                _ = sklearn.metrics.self;
                PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                PyDict pyDict = new PyDict();
                if (Y != null)
                    pyDict["Y"] = Helpers.ToPython(Y);
                if (reduce_func != null)
                    pyDict["reduce_func"] = Helpers.ToPython(reduce_func);
                if (metric != "euclidean")
                    pyDict["metric"] = Helpers.ToPython(metric);
                if (n_jobs != null)
                    pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                if (working_memory != null)
                    pyDict["working_memory"] = Helpers.ToPython(working_memory);
                if (@params != null)
                    pyDict["params"] = Helpers.ToPython(@params);
                return Helpers.ToCSharpNDarray(sklearn.metrics.self.InvokeMethod("pairwise_distances_chunked", args, pyDict));
            }

            public class ConfusionMatrixDisplay : PythonObject
            {
                public ConfusionMatrixDisplay(NDarray confusion_matrix, NDarray? display_labels = null)
                {
                    _ = sklearn.metrics.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(confusion_matrix)]);
                    PyDict pyDict = new PyDict();
                    if (display_labels != null)
                        pyDict["display_labels"] = Helpers.ToPython(display_labels);
                    self = sklearn.metrics.self.InvokeMethod("ConfusionMatrixDisplay", args, pyDict);
                }

                internal ConfusionMatrixDisplay(PyObject pyObject)
                {
                    _ = sklearn.metrics.self;
                    self = pyObject;
                }

                public static ConfusionMatrixDisplay Encapsule(PyObject pyObject)
                {
                    return new ConfusionMatrixDisplay(pyObject);
                }

                public PyObject im_ => self.GetAttr("im_");
                public NDarray text_ => Helpers.ToCSharpNDarray(self.GetAttr("text_"));
                public PyObject ax_ => self.GetAttr("ax_");
                public PyObject figure_ => self.GetAttr("figure_");

                public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? labels = null, NDarray? sample_weight = null, PyObject? normalize = null, NDarray? display_labels = null, bool include_values = true, string xticks_rotation = "horizontal", string? values_format = null, string cmap = "viridis", PyObject? ax = null, bool colorbar = true, PyDict? im_kw = null, PyDict? text_kw = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (labels != null)
                        pyDict["labels"] = Helpers.ToPython(labels);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (normalize != null)
                        pyDict["normalize"] = Helpers.ToPython(normalize);
                    if (display_labels != null)
                        pyDict["display_labels"] = Helpers.ToPython(display_labels);
                    if (include_values != true)
                        pyDict["include_values"] = Helpers.ToPython(include_values);
                    if (xticks_rotation != "horizontal")
                        pyDict["xticks_rotation"] = Helpers.ToPython(xticks_rotation);
                    if (values_format != null)
                        pyDict["values_format"] = Helpers.ToPython(values_format);
                    if (cmap != "viridis")
                        pyDict["cmap"] = Helpers.ToPython(cmap);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (colorbar != true)
                        pyDict["colorbar"] = Helpers.ToPython(colorbar);
                    if (im_kw != null)
                        pyDict["im_kw"] = Helpers.ToPython(im_kw);
                    if (text_kw != null)
                        pyDict["text_kw"] = Helpers.ToPython(text_kw);
                    return self.InvokeMethod("from_estimator", args, pyDict);
                }

                public PyObject from_predictions(NDarray y_true, NDarray y_pred, NDarray? labels = null, NDarray? sample_weight = null, PyObject? normalize = null, NDarray? display_labels = null, bool include_values = true, string xticks_rotation = "horizontal", string? values_format = null, string cmap = "viridis", PyObject? ax = null, bool colorbar = true, PyDict? im_kw = null, PyDict? text_kw = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                    PyDict pyDict = new PyDict();
                    if (labels != null)
                        pyDict["labels"] = Helpers.ToPython(labels);
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (normalize != null)
                        pyDict["normalize"] = Helpers.ToPython(normalize);
                    if (display_labels != null)
                        pyDict["display_labels"] = Helpers.ToPython(display_labels);
                    if (include_values != true)
                        pyDict["include_values"] = Helpers.ToPython(include_values);
                    if (xticks_rotation != "horizontal")
                        pyDict["xticks_rotation"] = Helpers.ToPython(xticks_rotation);
                    if (values_format != null)
                        pyDict["values_format"] = Helpers.ToPython(values_format);
                    if (cmap != "viridis")
                        pyDict["cmap"] = Helpers.ToPython(cmap);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (colorbar != true)
                        pyDict["colorbar"] = Helpers.ToPython(colorbar);
                    if (im_kw != null)
                        pyDict["im_kw"] = Helpers.ToPython(im_kw);
                    if (text_kw != null)
                        pyDict["text_kw"] = Helpers.ToPython(text_kw);
                    return self.InvokeMethod("from_predictions", args, pyDict);
                }

                public PyObject plot(bool include_values = true, string cmap = "viridis", string xticks_rotation = "horizontal", string? values_format = null, PyObject? ax = null, bool colorbar = true, PyDict? im_kw = null, PyDict? text_kw = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (include_values != true)
                        pyDict["include_values"] = Helpers.ToPython(include_values);
                    if (cmap != "viridis")
                        pyDict["cmap"] = Helpers.ToPython(cmap);
                    if (xticks_rotation != "horizontal")
                        pyDict["xticks_rotation"] = Helpers.ToPython(xticks_rotation);
                    if (values_format != null)
                        pyDict["values_format"] = Helpers.ToPython(values_format);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (colorbar != true)
                        pyDict["colorbar"] = Helpers.ToPython(colorbar);
                    if (im_kw != null)
                        pyDict["im_kw"] = Helpers.ToPython(im_kw);
                    if (text_kw != null)
                        pyDict["text_kw"] = Helpers.ToPython(text_kw);
                    return self.InvokeMethod("plot", args, pyDict);
                }
            }

            public class DetCurveDisplay : PythonObject
            {
                public DetCurveDisplay(NDarray fpr, NDarray fnr, string? estimator_name = null, string? pos_label = null)
                {
                    _ = sklearn.metrics.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(fpr), Helpers.ToPython(fnr)]);
                    PyDict pyDict = new PyDict();
                    if (estimator_name != null)
                        pyDict["estimator_name"] = Helpers.ToPython(estimator_name);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    self = sklearn.metrics.self.InvokeMethod("DetCurveDisplay", args, pyDict);
                }

                internal DetCurveDisplay(PyObject pyObject)
                {
                    _ = sklearn.metrics.self;
                    self = pyObject;
                }

                public static DetCurveDisplay Encapsule(PyObject pyObject)
                {
                    return new DetCurveDisplay(pyObject);
                }

                public PyObject line_ => self.GetAttr("line_");
                public PyObject ax_ => self.GetAttr("ax_");
                public PyObject figure_ => self.GetAttr("figure_");

                public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? sample_weight = null, string response_method = "auto", string? pos_label = null, string? name = null, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (response_method != "auto")
                        pyDict["response_method"] = Helpers.ToPython(response_method);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("from_estimator", args, pyDict);
                }

                public PyObject from_predictions(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string? pos_label = null, string? name = null, PyObject? ax = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("from_predictions", args, pyDict);
                }

                public PyObject plot(PyObject? ax = null, string? name = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("plot", args, pyDict);
                }
            }

            public class PrecisionRecallDisplay : PythonObject
            {
                public PrecisionRecallDisplay(NDarray precision, NDarray recall, float? average_precision = null, string? estimator_name = null, string? pos_label = null, float? prevalence_pos_label = null)
                {
                    _ = sklearn.metrics.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(precision), Helpers.ToPython(recall)]);
                    PyDict pyDict = new PyDict();
                    if (average_precision != null)
                        pyDict["average_precision"] = Helpers.ToPython(average_precision);
                    if (estimator_name != null)
                        pyDict["estimator_name"] = Helpers.ToPython(estimator_name);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    if (prevalence_pos_label != null)
                        pyDict["prevalence_pos_label"] = Helpers.ToPython(prevalence_pos_label);
                    self = sklearn.metrics.self.InvokeMethod("PrecisionRecallDisplay", args, pyDict);
                }

                internal PrecisionRecallDisplay(PyObject pyObject)
                {
                    _ = sklearn.metrics.self;
                    self = pyObject;
                }

                public static PrecisionRecallDisplay Encapsule(PyObject pyObject)
                {
                    return new PrecisionRecallDisplay(pyObject);
                }

                public PyObject line_ => self.GetAttr("line_");
                public PyObject chance_level_ => self.GetAttr("chance_level_");
                public PyObject ax_ => self.GetAttr("ax_");
                public PyObject figure_ => self.GetAttr("figure_");

                public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? sample_weight = null, string? pos_label = null, bool drop_intermediate = false, string response_method = "auto", string? name = null, PyObject? ax = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    if (drop_intermediate != false)
                        pyDict["drop_intermediate"] = Helpers.ToPython(drop_intermediate);
                    if (response_method != "auto")
                        pyDict["response_method"] = Helpers.ToPython(response_method);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (plot_chance_level != false)
                        pyDict["plot_chance_level"] = Helpers.ToPython(plot_chance_level);
                    if (chance_level_kw != null)
                        pyDict["chance_level_kw"] = Helpers.ToPython(chance_level_kw);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("from_estimator", args, pyDict);
                }

                public PyObject from_predictions(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, string? pos_label = null, bool drop_intermediate = false, string? name = null, PyObject? ax = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    if (drop_intermediate != false)
                        pyDict["drop_intermediate"] = Helpers.ToPython(drop_intermediate);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (plot_chance_level != false)
                        pyDict["plot_chance_level"] = Helpers.ToPython(plot_chance_level);
                    if (chance_level_kw != null)
                        pyDict["chance_level_kw"] = Helpers.ToPython(chance_level_kw);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("from_predictions", args, pyDict);
                }

                public PyObject plot(PyObject? ax = null, string? name = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (plot_chance_level != false)
                        pyDict["plot_chance_level"] = Helpers.ToPython(plot_chance_level);
                    if (chance_level_kw != null)
                        pyDict["chance_level_kw"] = Helpers.ToPython(chance_level_kw);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("plot", args, pyDict);
                }
            }

            public class PredictionErrorDisplay : PythonObject
            {
                public PredictionErrorDisplay(NDarray y_true, NDarray y_pred)
                {
                    _ = sklearn.metrics.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                    PyDict pyDict = new PyDict();
                    self = sklearn.metrics.self.InvokeMethod("PredictionErrorDisplay", args, pyDict);
                }

                internal PredictionErrorDisplay(PyObject pyObject)
                {
                    _ = sklearn.metrics.self;
                    self = pyObject;
                }

                public static PredictionErrorDisplay Encapsule(PyObject pyObject)
                {
                    return new PredictionErrorDisplay(pyObject);
                }

                public PyObject line_ => self.GetAttr("line_");
                public PyObject errors_lines_ => self.GetAttr("errors_lines_");
                public PyObject scatter_ => self.GetAttr("scatter_");
                public PyObject ax_ => self.GetAttr("ax_");
                public PyObject figure_ => self.GetAttr("figure_");

                public PyDict from_estimator(PyObject estimator, NDarray X, NDarray y, string kind = "residual_vs_predicted", int? subsample = 1000, int? random_state = null, PyObject? ax = null, PyDict? scatter_kwargs = null, PyDict? line_kwargs = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (kind != "residual_vs_predicted")
                        pyDict["kind"] = Helpers.ToPython(kind);
                    if (subsample != 1000)
                        pyDict["subsample"] = Helpers.ToPython(subsample);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (scatter_kwargs != null)
                        pyDict["scatter_kwargs"] = Helpers.ToPython(scatter_kwargs);
                    if (line_kwargs != null)
                        pyDict["line_kwargs"] = Helpers.ToPython(line_kwargs);
                    return new PyDict(self.InvokeMethod("from_estimator", args, pyDict));
                }

                public PyDict from_predictions(NDarray y_true, NDarray y_pred, string kind = "residual_vs_predicted", int? subsample = 1000, int? random_state = null, PyObject? ax = null, PyDict? scatter_kwargs = null, PyDict? line_kwargs = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                    PyDict pyDict = new PyDict();
                    if (kind != "residual_vs_predicted")
                        pyDict["kind"] = Helpers.ToPython(kind);
                    if (subsample != 1000)
                        pyDict["subsample"] = Helpers.ToPython(subsample);
                    if (random_state != null)
                        pyDict["random_state"] = Helpers.ToPython(random_state);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (scatter_kwargs != null)
                        pyDict["scatter_kwargs"] = Helpers.ToPython(scatter_kwargs);
                    if (line_kwargs != null)
                        pyDict["line_kwargs"] = Helpers.ToPython(line_kwargs);
                    return new PyDict(self.InvokeMethod("from_predictions", args, pyDict));
                }

                public PyDict plot(PyObject? ax = null, string kind = "residual_vs_predicted", PyDict? scatter_kwargs = null, PyDict? line_kwargs = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (kind != "residual_vs_predicted")
                        pyDict["kind"] = Helpers.ToPython(kind);
                    if (scatter_kwargs != null)
                        pyDict["scatter_kwargs"] = Helpers.ToPython(scatter_kwargs);
                    if (line_kwargs != null)
                        pyDict["line_kwargs"] = Helpers.ToPython(line_kwargs);
                    return new PyDict(self.InvokeMethod("plot", args, pyDict));
                }
            }

            public class RocCurveDisplay : PythonObject
            {
                public RocCurveDisplay(NDarray fpr, NDarray tpr, float? roc_auc = null, string? estimator_name = null, string? pos_label = null)
                {
                    _ = sklearn.metrics.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(fpr), Helpers.ToPython(tpr)]);
                    PyDict pyDict = new PyDict();
                    if (roc_auc != null)
                        pyDict["roc_auc"] = Helpers.ToPython(roc_auc);
                    if (estimator_name != null)
                        pyDict["estimator_name"] = Helpers.ToPython(estimator_name);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    self = sklearn.metrics.self.InvokeMethod("RocCurveDisplay", args, pyDict);
                }

                internal RocCurveDisplay(PyObject pyObject)
                {
                    _ = sklearn.metrics.self;
                    self = pyObject;
                }

                public static RocCurveDisplay Encapsule(PyObject pyObject)
                {
                    return new RocCurveDisplay(pyObject);
                }

                public PyObject line_ => self.GetAttr("line_");
                public PyObject chance_level_ => self.GetAttr("chance_level_");
                public PyObject ax_ => self.GetAttr("ax_");
                public PyObject figure_ => self.GetAttr("figure_");

                public PyObject from_estimator(PyObject estimator, NDarray X, NDarray y, NDarray? sample_weight = null, bool drop_intermediate = true, string response_method = "auto", string? pos_label = null, string? name = null, PyObject? ax = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(estimator), Helpers.ToPython(X), Helpers.ToPython(y)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (drop_intermediate != true)
                        pyDict["drop_intermediate"] = Helpers.ToPython(drop_intermediate);
                    if (response_method != "auto")
                        pyDict["response_method"] = Helpers.ToPython(response_method);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (plot_chance_level != false)
                        pyDict["plot_chance_level"] = Helpers.ToPython(plot_chance_level);
                    if (chance_level_kw != null)
                        pyDict["chance_level_kw"] = Helpers.ToPython(chance_level_kw);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("from_estimator", args, pyDict);
                }

                public PyObject from_predictions(NDarray y_true, NDarray y_pred, NDarray? sample_weight = null, bool drop_intermediate = true, string? pos_label = null, string? name = null, PyObject? ax = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple([Helpers.ToPython(y_true), Helpers.ToPython(y_pred)]);
                    PyDict pyDict = new PyDict();
                    if (sample_weight != null)
                        pyDict["sample_weight"] = Helpers.ToPython(sample_weight);
                    if (drop_intermediate != true)
                        pyDict["drop_intermediate"] = Helpers.ToPython(drop_intermediate);
                    if (pos_label != null)
                        pyDict["pos_label"] = Helpers.ToPython(pos_label);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (plot_chance_level != false)
                        pyDict["plot_chance_level"] = Helpers.ToPython(plot_chance_level);
                    if (chance_level_kw != null)
                        pyDict["chance_level_kw"] = Helpers.ToPython(chance_level_kw);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("from_predictions", args, pyDict);
                }

                public PyObject plot(PyObject? ax = null, string? name = null, bool plot_chance_level = false, PyDict? chance_level_kw = null, Dictionary<string, PyObject>? @params = null)
                {
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    if (ax != null)
                        pyDict["ax"] = Helpers.ToPython(ax);
                    if (name != null)
                        pyDict["name"] = Helpers.ToPython(name);
                    if (plot_chance_level != false)
                        pyDict["plot_chance_level"] = Helpers.ToPython(plot_chance_level);
                    if (chance_level_kw != null)
                        pyDict["chance_level_kw"] = Helpers.ToPython(chance_level_kw);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return self.InvokeMethod("plot", args, pyDict);
                }
            }

            public static class cluster
            {
                private static Lazy<PyObject> _lazy_self;
                public static PyObject self { get => _lazy_self.Value; }

                private static void ReInitializeLazySelf()
                {
                    _lazy_self = new Lazy<PyObject>(() =>
                    {
                        try
                        {
                            return InstallAndImport();
                        }
                        catch (Exception)
                        {
                            return InstallAndImport(true);
                        }
                    });
                }

                private static PyObject InstallAndImport(bool force = false)
                {
                    PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
                    PythonEngine.Initialize();
                    return Py.Import("sklearn.metrics.cluster");
                }

                static cluster()
                {
                    ReInitializeLazySelf();
                }

                public static NDarray contingency_matrix(NDarray labels_true, NDarray labels_pred, float? eps = null, bool sparse = false, int? dtype = null)
                {
                    _ = sklearn.metrics.cluster.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                    PyDict pyDict = new PyDict();
                    if (eps != null)
                        pyDict["eps"] = Helpers.ToPython(eps);
                    if (sparse != false)
                        pyDict["sparse"] = Helpers.ToPython(sparse);
                    if (dtype != null)
                        pyDict["dtype"] = Helpers.ToPython(dtype);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.cluster.self.InvokeMethod("contingency_matrix", args, pyDict));
                }

                public static NDarray<long> pair_confusion_matrix(NDarray labels_true, NDarray labels_pred)
                {
                    _ = sklearn.metrics.cluster.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(labels_true), Helpers.ToPython(labels_pred)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray<long>(sklearn.metrics.cluster.self.InvokeMethod("pair_confusion_matrix", args, pyDict));
                }
            }

            public static class pairwise
            {
                private static Lazy<PyObject> _lazy_self;
                public static PyObject self { get => _lazy_self.Value; }

                private static void ReInitializeLazySelf()
                {
                    _lazy_self = new Lazy<PyObject>(() =>
                    {
                        try
                        {
                            return InstallAndImport();
                        }
                        catch (Exception)
                        {
                            return InstallAndImport(true);
                        }
                    });
                }

                private static PyObject InstallAndImport(bool force = false)
                {
                    PythonEngine.AddShutdownHandler(ReInitializeLazySelf);
                    PythonEngine.Initialize();
                    return Py.Import("sklearn.metrics.pairwise");
                }

                static pairwise()
                {
                    ReInitializeLazySelf();
                }

                public static NDarray additive_chi2_kernel(NDarray X, NDarray? Y = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("additive_chi2_kernel", args, pyDict));
                }

                public static NDarray chi2_kernel(NDarray X, NDarray? Y = null, float gamma = 1.0f)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (gamma != 1.0f)
                        pyDict["gamma"] = Helpers.ToPython(gamma);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("chi2_kernel", args, pyDict));
                }

                public static NDarray cosine_distances(NDarray X, NDarray? Y = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("cosine_distances", args, pyDict));
                }

                public static NDarray cosine_similarity(NDarray X, NDarray? Y = null, bool dense_output = true)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (dense_output != true)
                        pyDict["dense_output"] = Helpers.ToPython(dense_output);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("cosine_similarity", args, pyDict));
                }

                public static PyDict distance_metrics()
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return new PyDict(sklearn.metrics.pairwise.self.InvokeMethod("distance_metrics", args, pyDict));
                }

                public static NDarray euclidean_distances(NDarray X, NDarray? Y = null, NDarray? Y_norm_squared = null, bool squared = false, NDarray? X_norm_squared = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (Y_norm_squared != null)
                        pyDict["Y_norm_squared"] = Helpers.ToPython(Y_norm_squared);
                    if (squared != false)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    if (X_norm_squared != null)
                        pyDict["X_norm_squared"] = Helpers.ToPython(X_norm_squared);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("euclidean_distances", args, pyDict));
                }

                public static NDarray haversine_distances(NDarray X, NDarray? Y = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("haversine_distances", args, pyDict));
                }

                public static PyDict kernel_metrics()
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple();
                    PyDict pyDict = new PyDict();
                    return new PyDict(sklearn.metrics.pairwise.self.InvokeMethod("kernel_metrics", args, pyDict));
                }

                public static NDarray laplacian_kernel(NDarray X, NDarray? Y = null, float? gamma = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (gamma != null)
                        pyDict["gamma"] = Helpers.ToPython(gamma);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("laplacian_kernel", args, pyDict));
                }

                public static NDarray linear_kernel(NDarray X, NDarray? Y = null, bool dense_output = true)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (dense_output != true)
                        pyDict["dense_output"] = Helpers.ToPython(dense_output);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("linear_kernel", args, pyDict));
                }

                public static NDarray manhattan_distances(NDarray X, NDarray? Y = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("manhattan_distances", args, pyDict));
                }

                public static NDarray nan_euclidean_distances(NDarray X, NDarray? Y = null, bool squared = false, float? missing_values = null, bool copy = true)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (squared != false)
                        pyDict["squared"] = Helpers.ToPython(squared);
                    if (missing_values != null)
                        pyDict["missing_values"] = Helpers.ToPython(missing_values);
                    if (copy != true)
                        pyDict["copy"] = Helpers.ToPython(copy);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("nan_euclidean_distances", args, pyDict));
                }

                public static NDarray paired_cosine_distances(NDarray X, NDarray Y)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(Y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("paired_cosine_distances", args, pyDict));
                }

                public static NDarray paired_distances(NDarray X, NDarray Y, string metric = "euclidean", Dictionary<string, PyObject>? @params = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(Y)]);
                    PyDict pyDict = new PyDict();
                    if (metric != "euclidean")
                        pyDict["metric"] = Helpers.ToPython(metric);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("paired_distances", args, pyDict));
                }

                public static NDarray paired_euclidean_distances(NDarray X, NDarray Y)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(Y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("paired_euclidean_distances", args, pyDict));
                }

                public static NDarray paired_manhattan_distances(NDarray X, NDarray Y)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X), Helpers.ToPython(Y)]);
                    PyDict pyDict = new PyDict();
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("paired_manhattan_distances", args, pyDict));
                }

                public static NDarray pairwise_kernels(NDarray X, NDarray? Y = null, string metric = "linear", bool filter_params = false, int? n_jobs = null, Dictionary<string, PyObject>? @params = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (metric != "linear")
                        pyDict["metric"] = Helpers.ToPython(metric);
                    if (filter_params != false)
                        pyDict["filter_params"] = Helpers.ToPython(filter_params);
                    if (n_jobs != null)
                        pyDict["n_jobs"] = Helpers.ToPython(n_jobs);
                    if (@params != null)
                        pyDict["params"] = Helpers.ToPython(@params);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("pairwise_kernels", args, pyDict));
                }

                public static NDarray polynomial_kernel(NDarray X, NDarray? Y = null, int degree = 3, float? gamma = null, int coef0 = 1)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (degree != 3)
                        pyDict["degree"] = Helpers.ToPython(degree);
                    if (gamma != null)
                        pyDict["gamma"] = Helpers.ToPython(gamma);
                    if (coef0 != 1)
                        pyDict["coef0"] = Helpers.ToPython(coef0);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("polynomial_kernel", args, pyDict));
                }

                public static NDarray rbf_kernel(NDarray X, NDarray? Y = null, float? gamma = null)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (gamma != null)
                        pyDict["gamma"] = Helpers.ToPython(gamma);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("rbf_kernel", args, pyDict));
                }

                public static NDarray sigmoid_kernel(NDarray X, NDarray? Y = null, float? gamma = null, int coef0 = 1)
                {
                    _ = sklearn.metrics.pairwise.self;
                    PyTuple args = new PyTuple([Helpers.ToPython(X)]);
                    PyDict pyDict = new PyDict();
                    if (Y != null)
                        pyDict["Y"] = Helpers.ToPython(Y);
                    if (gamma != null)
                        pyDict["gamma"] = Helpers.ToPython(gamma);
                    if (coef0 != 1)
                        pyDict["coef0"] = Helpers.ToPython(coef0);
                    return Helpers.ToCSharpNDarray(sklearn.metrics.pairwise.self.InvokeMethod("sigmoid_kernel", args, pyDict));
                }
            }
        }
    }
}