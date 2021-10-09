### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd_Reflection_MethodExtensions.md 'Jcd.Reflection.MethodExtensions')
## MethodExtensions.GetMethod(Type, string, Settings) Method
Gets a methodInfo by name from a type.   
```csharp
public static System.Reflection.MethodInfo GetMethod(this System.Type type, string name, Jcd.Reflection.MethodInfoEnumerator.Settings settings);
```
#### Parameters
<a name='Jcd_Reflection_MethodExtensions_GetMethod(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
the type to interrogate
  
<a name='Jcd_Reflection_MethodExtensions_GetMethod(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the name of the method
  
<a name='Jcd_Reflection_MethodExtensions_GetMethod(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings)_settings'></a>
`settings` [Settings](Jcd_Reflection_MethodInfoEnumerator_Settings.md 'Jcd.Reflection.MethodInfoEnumerator.Settings')  
  
#### Returns
[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')  
the result of the call, if any
