### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd.Reflection.MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.FilterMethods(this object, Func<MethodInfo,bool>, Settings) Method

Given a filter return an array of matching MethodInfo's

```csharp
public static System.Reflection.MethodInfo[] FilterMethods(this object self, System.Func<System.Reflection.MethodInfo,bool> filter, Jcd.Reflection.MethodInfoEnumerator.Settings settings);
```

#### Parameters

<a name='Jcd.Reflection.MethodExtensions.FilterMethods(thisobject,System.Func_System.Reflection.MethodInfo,bool_,Jcd.Reflection.MethodInfoEnumerator.Settings).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The target object of the method selection.

<a name='Jcd.Reflection.MethodExtensions.FilterMethods(thisobject,System.Func_System.Reflection.MethodInfo,bool_,Jcd.Reflection.MethodInfoEnumerator.Settings).filter'></a>

`filter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

a predicate to select or exclude specific methods.

<a name='Jcd.Reflection.MethodExtensions.FilterMethods(thisobject,System.Func_System.Reflection.MethodInfo,bool_,Jcd.Reflection.MethodInfoEnumerator.Settings).settings'></a>

`settings` [Settings](Jcd.Reflection.MethodInfoEnumerator.Settings.md 'Jcd.Reflection.MethodInfoEnumerator.Settings')

The method selection settings such
as [AllInstanceMethodsFilter](Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter.md 'Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter')

#### Returns

[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
an array of matching methods