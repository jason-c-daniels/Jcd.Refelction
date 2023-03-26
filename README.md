# Jcd.Reflection

A dotnetstandard2.0 library containing some commonly implemented reflection helpers.

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
