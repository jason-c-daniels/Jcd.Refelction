### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd_Reflection_MethodExtensions.md 'Jcd.Reflection.MethodExtensions')
## MethodExtensions.Invoke(object, string, Settings, object[]) Method
Invoke the method on the specified object using the provided parameters  
```csharp
public static object Invoke(this object self, string name, Jcd.Reflection.MethodInfoEnumerator.Settings settings, params object[] @params);
```
#### Parameters
<a name='Jcd_Reflection_MethodExtensions_Invoke(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The instance to invoke the method on
  
<a name='Jcd_Reflection_MethodExtensions_Invoke(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the name of the method to invoke
  
<a name='Jcd_Reflection_MethodExtensions_Invoke(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_settings'></a>
`settings` [Settings](Jcd_Reflection_MethodInfoEnumerator_Settings.md 'Jcd.Reflection.MethodInfoEnumerator.Settings')  
binding flags and skip predicate
  
<a name='Jcd_Reflection_MethodExtensions_Invoke(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_params'></a>
`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
the params for the method
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
the result, if any
