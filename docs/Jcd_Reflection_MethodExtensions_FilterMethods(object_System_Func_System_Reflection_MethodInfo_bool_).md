### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd_Reflection_MethodExtensions.md 'Jcd.Reflection.MethodExtensions')
## MethodExtensions.FilterMethods(object, Func&lt;MethodInfo,bool&gt;) Method
Given a filter return an array of matching MethodInfo's  
```csharp
public static System.Reflection.MethodInfo[] FilterMethods(this object self, System.Func<System.Reflection.MethodInfo,bool> filter);
```
#### Parameters
<a name='Jcd_Reflection_MethodExtensions_FilterMethods(object_System_Func_System_Reflection_MethodInfo_bool_)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
<a name='Jcd_Reflection_MethodExtensions_FilterMethods(object_System_Func_System_Reflection_MethodInfo_bool_)_filter'></a>
`filter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
