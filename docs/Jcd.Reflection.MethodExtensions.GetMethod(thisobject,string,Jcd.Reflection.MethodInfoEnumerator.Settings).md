### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd.Reflection.MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.GetMethod(this object, string, Settings) Method

Finds the first method by the provided name and returns its MethodInfo

```csharp
public static System.Reflection.MethodInfo GetMethod(this object self, string name, Jcd.Reflection.MethodInfoEnumerator.Settings settings);
```

#### Parameters

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance to find the method on

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the method name.

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings).settings'></a>

`settings` [Settings](Jcd.Reflection.MethodInfoEnumerator.Settings.md 'Jcd.Reflection.MethodInfoEnumerator.Settings')

settings that control method
selection. [AllInstanceMethodsFilter](Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter.md 'Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter')

#### Returns

[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')  
null if none found