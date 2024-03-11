### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.Invoke(this Type, string, MethodInfoFilter, object[]) Method

Invokes a static method on a type

```csharp
public static object Invoke(this System.Type type, string name, Jcd.Reflection.MethodInfoFilter settings, params object[] @params);
```
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type containing the static method

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the method

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).settings'></a>

`settings` [MethodInfoFilter](MethodInfoFilter.md 'Jcd.Reflection.MethodInfoFilter')

The method selection settings such
as [AllStaticMethodsFilter](MethodInfoFilter.AllStaticMethodsFilter.md 'Jcd.Reflection.MethodInfoFilter.AllStaticMethodsFilter')

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).params'></a>

`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The params to pass

#### Returns

[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
The result of the call, if any