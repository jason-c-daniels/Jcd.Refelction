### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.Invoke(this Type, string, Settings, object[]) Method

Invokes a static method on a type

```csharp
public static object Invoke(this System.Type type, string name, Jcd.Reflection.MethodInfoEnumerator.Settings settings, params object[] @params);
```

#### Parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type containing the static method

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the method

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).settings'></a>

`settings` [Settings](MethodInfoEnumerator.Settings.md 'Jcd.Reflection.MethodInfoEnumerator.Settings')

The method selection settings such
as [AllStaticMethodsFilter](MethodExtensions.AllStaticMethodsFilter.md 'Jcd.Reflection.MethodExtensions.AllStaticMethodsFilter')

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).params'></a>

`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The params to pass

#### Returns

[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The result of the call, if any