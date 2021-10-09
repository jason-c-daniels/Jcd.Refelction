### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd_Reflection_MethodExtensions.md 'Jcd.Reflection.MethodExtensions')
## MethodExtensions.Invoke&lt;TOut&gt;(Type, string, Settings, object[]) Method
Invokes a static method on a type, coercing the return type   
```csharp
public static TOut Invoke<TOut>(this System.Type type, string name, Jcd.Reflection.MethodInfoEnumerator.Settings settings, params object[] @params);
```
#### Type parameters
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_TOut'></a>
`TOut`  
The type of the return
  
#### Parameters
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type containing the static method
  
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the method
  
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_settings'></a>
`settings` [Settings](Jcd_Reflection_MethodInfoEnumerator_Settings.md 'Jcd.Reflection.MethodInfoEnumerator.Settings')  
The settings such as binding flags
  
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_params'></a>
`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The params to pass
  
#### Returns
[TOut](Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__).md#Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__)_TOut 'Jcd.Reflection.MethodExtensions.Invoke&lt;TOut&gt;(System.Type, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[]).TOut')  
The result of the call, if any
