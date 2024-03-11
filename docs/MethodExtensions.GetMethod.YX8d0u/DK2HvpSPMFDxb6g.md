### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.GetMethod(this object, string, MethodInfoFilter) Method

Finds the first method by the provided name and returns its MethodInfo

```csharp
public static System.Reflection.MethodInfo GetMethod(this object self, string name, Jcd.Reflection.MethodInfoFilter settings);
```
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string,Jcd.Reflection.MethodInfoFilter).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance to find the method on

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string,Jcd.Reflection.MethodInfoFilter).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the method name.

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string,Jcd.Reflection.MethodInfoFilter).settings'></a>

`settings` [MethodInfoFilter](MethodInfoFilter.md 'Jcd.Reflection.MethodInfoFilter')

settings that control method
selection. [AllInstanceMethodsFilter](MethodInfoFilter.AllInstanceMethodsFilter.md 'Jcd.Reflection.MethodInfoFilter.AllInstanceMethodsFilter')

#### Returns

[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')
null if none found