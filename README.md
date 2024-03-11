# Jcd.Reflection

A _dotnetstandard2.0_ library containing some commonly implemented reflection helpers.

v2.0 has many breaking changes. See the [Version History](#version-history) for details.

## Examples

```csharp
    internal static class Program
    {
        private static void Main()
        {
            var c = new TestClass();
            // set the private field, _field
            c.SetValue("_field",10);

            // now get its value.
            var val = (int)c.GetValue("_field");
            Console.WriteLine(val);

            // Now set a private property with a backing field.
            c.SetValue("PrivateProperty",20);

            // Now call a private helper method that returns the value from the backing field.
            val = c.Invoke<int>("InternalGetField");
            Console.WriteLine(val);
```

## Special Thanks To

* [Kristian Hellang on GitHub](https://github.com/khellang) for the [Scrutor](https://github.com/khellang/Scrutor)
  project.

Scrutor inspired the technique I'm using for finding implementations of specific types as well as
a couple of other handy utility methods.

## Badges

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.Reflection)](https://github.com/jason-c-daniels/Jcd.Reflection/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/sbmfvmr1jmcf1pic?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-reflection)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.Reflection)](https://www.codefactor.io/repository/github/jason-c-daniels/jcd.reflection)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.Reflection?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.Reflection)
[![Nuget](https://img.shields.io/nuget/v/Jcd.Reflection?logo=nuget)](https://www.nuget.org/packages/Jcd.Reflection)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.Reflection/blob/main/docs/Jcd.Reflection.md)

## Version History

### v2.0 Breaking Changes

Version 2.0 comes with a significant number of breaking changes for advanced use cases. These are listed below

- `ExpandoObjectExtensions` was removed. It wasn't functioning as planned. An overhaul of the approach is needed.
- All overloads of `FilterMethods` were renamed to `GetMethods`
- The filter parameter was moved to the last parameter on an overload of `GetMethods` (formerly `FilterMethods`).
- Renamed `EnumerationSettings` to `Filter` in `MemberInfoEnumerator`, `FieldOrPropertyEnumerator`,
  and `MethodInfoEnumerator`
- Moved and renamed type from `MethodInfoEnumerator.Settings` to `MethodInfoFilter`.
- Moved predefined instances of  `MethodInfoEnumerator.Settings` from `MethodInfoEnumerator` to `MethodInfoFilter`.
- Moved and renamed type from `MemberInfoEnumerator.Settings` to `MemberInfoFilter`.
- Moved and renamed type from `FieldOrPropertyEnumerator.Settings` to `FieldOrPropertyInfoFilter`.
- `MethodInfoFilter`, `MemberInfoFilter`, `FieldOrPropertyInfoFilter` fields are now get-only properties, requiring a
  call to `new` to create new instances.
- To facilitate the use of init properties on `MethodInfoFilter`, `MemberInfoFilter`, `FieldOrPropertyInfoFilter`
  types, a custom `IsExternalInit` is required of target frameworks not supporting it. See this project's source code
  for an example ([`IsExternalInit.cs`](Jcd.Reflection/IsExternalInit.cs)).
- Extension methods `GetCusomAttributes` and `HasAttribute` were moved into classes named after the underlying method.
  This will only break non-extension invocations.
