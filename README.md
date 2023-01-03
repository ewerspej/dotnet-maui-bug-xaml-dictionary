# dotnet-maui-bug-xaml-dictionary
Bug Repro for XAML-only ResourceDictionaries 

## Description

When using a XAML-only `ResourceDictionary`, it's only possible to reference it by its path from within another XAML file, e.g. in `MergedDictionaries`.

However, for the purpose of theming apps during runtime, it is necessary to be able to reference a `ResourceDictionary` by its class name.

When a XAML-only `ResourceDictionary` is given a class name by specifying the `x:Class` attribute on it, the class can be referenced in C#, but the defined styles are not loaded or applied. Just the presence of the `x:Class` attribute already breaks the default behavior, even without instantiating the `ResourceDictionary` from C#.
