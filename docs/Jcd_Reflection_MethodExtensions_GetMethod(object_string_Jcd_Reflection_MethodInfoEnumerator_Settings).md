### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd_Reflection_MethodExtensions.md 'Jcd.Reflection.MethodExtensions')
## MethodExtensions.GetMethod(object, string, Settings) Method
Finds the first method by the provided name and returns its MethodInfo  
```csharp
public static System.Reflection.MethodInfo GetMethod(this object self, string name, Jcd.Reflection.MethodInfoEnumerator.Settings settings);
```
#### Parameters
<a name='Jcd_Reflection_MethodExtensions_GetMethod(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
<a name='Jcd_Reflection_MethodExtensions_GetMethod(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
<a name='Jcd_Reflection_MethodExtensions_GetMethod(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings)_settings'></a>
`settings` [Jcd.Reflection.MethodInfoEnumerator.Settings](https://docs.microsoft.com/en-us/dotnet/api/Jcd.Reflection.MethodInfoEnumerator.Settings 'Jcd.Reflection.MethodInfoEnumerator.Settings')  
  
#### Returns
[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')  
null if none found
