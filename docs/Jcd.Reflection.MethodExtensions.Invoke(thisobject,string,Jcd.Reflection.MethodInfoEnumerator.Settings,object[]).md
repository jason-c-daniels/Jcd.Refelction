### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd.Reflection.MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.Invoke(this object, string, Settings, object[]) Method

Invoke the method on the specified object using the provided parameters

```csharp
public static object Invoke(this object self, string name, Jcd.Reflection.MethodInfoEnumerator.Settings settings, params object[] @params);
```
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance to invoke the method on

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the name of the method to invoke

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).settings'></a>

`settings` [Settings](Jcd.Reflection.MethodInfoEnumerator.Settings.md 'Jcd.Reflection.MethodInfoEnumerator.Settings')

The method selection settings such as [AllInstanceMethodsFilter](Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter.md 'Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter')

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).params'></a>

`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the params for the method

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
the result, if any