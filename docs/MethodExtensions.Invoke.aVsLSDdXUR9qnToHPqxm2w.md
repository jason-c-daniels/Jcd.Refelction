### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.Invoke(this object, string, MethodInfoFilter, object[]) Method

Invoke the method on the specified object using the provided parameters

```csharp
public static object Invoke(this object self, string name, Jcd.Reflection.MethodInfoFilter settings, params object[] @params);
```
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoFilter,object[]).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance to invoke the method on

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoFilter,object[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the name of the method to invoke

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoFilter,object[]).settings'></a>

`settings` [MethodInfoFilter](MethodInfoFilter.md 'Jcd.Reflection.MethodInfoFilter')

The method selection settings such
as [AllInstanceMethodsFilter](MethodInfoFilter.AllInstanceMethodsFilter.md 'Jcd.Reflection.MethodInfoFilter.AllInstanceMethodsFilter')

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoFilter,object[]).params'></a>

`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the params for the method

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
the result, if any