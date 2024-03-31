### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.GetMethod(this object, string) Method

Finds the first method by the provided name and returns its MethodInfo

```csharp
public static System.Reflection.MethodInfo GetMethod(this object self, string name);
```
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance to find the method on

<a name='Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the method name.

#### Returns
[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')
null if none found