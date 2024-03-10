### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.GetMethods(this object, Settings, Func<MethodInfo,bool>) Method

Given a filter return an array of matching MethodInfo's

```csharp
public static System.Reflection.MethodInfo[] GetMethods(this object self, Jcd.Reflection.MethodInfoEnumerator.Settings settings, System.Func<System.Reflection.MethodInfo,bool> filter=null);
```
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.GetMethods(thisobject,Jcd.Reflection.MethodInfoEnumerator.Settings,System.Func_System.Reflection.MethodInfo,bool_).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The target object of the method selection.

<a name='Jcd.Reflection.MethodExtensions.GetMethods(thisobject,Jcd.Reflection.MethodInfoEnumerator.Settings,System.Func_System.Reflection.MethodInfo,bool_).settings'></a>

`settings` [Settings](MethodInfoEnumerator.Settings.md 'Jcd.Reflection.MethodInfoEnumerator.Settings')

The method selection settings such as [AllInstanceMethodsFilter](MethodExtensions.AllInstanceMethodsFilter.md 'Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter')

<a name='Jcd.Reflection.MethodExtensions.GetMethods(thisobject,Jcd.Reflection.MethodInfoEnumerator.Settings,System.Func_System.Reflection.MethodInfo,bool_).filter'></a>

`filter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

a predicate to select or exclude specific methods.

#### Returns

[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
an array of matching methods