## ScikitLearn.Net v1.1.0
_Not yet on NuGet..._

- Implemented a new workflow: methods responsible for converting C# objects to Python now identify types at compile-time instead of runtime. https://github.com/KosmosWerner/ScikitLearn.Net/pull/16
- Fixed the issue of tuples containing extra elements, caused by the Pre-Generator adding dictionary elements contained within tuples in the documentation. https://github.com/KosmosWerner/ScikitLearn.Net/pull/18

## ScikitLearn.Net v1.0.0
_Published on [NuGet](https://www.nuget.org/packages/ScikitLearn) on 2024-11-17_

- Added all `Scikit-Learn` methods and classes.
- Implemented the `Encapsule` method to enable functionality for `PyObject` types when necessary.
