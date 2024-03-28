### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.GetMethod(this Type, string, MethodInfoFilter) Method

Gets a methodInfo by name from a type.

```csharp
public static System.Reflection.MethodInfo GetMethod(this System.Type type, string name, Jcd.Reflection.MethodInfoFilter settings);
```
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

the type to interrogate

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the name of the method

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter).settings'></a>

`settings` [MethodInfoFilter](MethodInfoFilter.md 'Jcd.Reflection.MethodInfoFilter')

#### Returns
[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')
the result of the call, if any