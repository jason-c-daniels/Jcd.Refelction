### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd_Reflection_MethodExtensions.md 'Jcd.Reflection.MethodExtensions')
## MethodExtensions.FilterMethods(object, Func&lt;MethodInfo,bool&gt;, Settings) Method
Given a filter return an array of matching MethodInfo's  
```csharp
public static System.Reflection.MethodInfo[] FilterMethods(this object self, System.Func<System.Reflection.MethodInfo,bool> filter, Jcd.Reflection.MethodInfoEnumerator.Settings settings);
```
#### Parameters
<a name='Jcd_Reflection_MethodExtensions_FilterMethods(object_System_Func_System_Reflection_MethodInfo_bool__Jcd_Reflection_MethodInfoEnumerator_Settings)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
<a name='Jcd_Reflection_MethodExtensions_FilterMethods(object_System_Func_System_Reflection_MethodInfo_bool__Jcd_Reflection_MethodInfoEnumerator_Settings)_filter'></a>
`filter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
<a name='Jcd_Reflection_MethodExtensions_FilterMethods(object_System_Func_System_Reflection_MethodInfo_bool__Jcd_Reflection_MethodInfoEnumerator_Settings)_settings'></a>
`settings` [Jcd.Reflection.MethodInfoEnumerator.Settings](https://docs.microsoft.com/en-us/dotnet/api/Jcd.Reflection.MethodInfoEnumerator.Settings 'Jcd.Reflection.MethodInfoEnumerator.Settings')  
  
#### Returns
[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
