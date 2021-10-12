### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[ValueExtensions](Jcd_Reflection_ValueExtensions.md 'Jcd.Reflection.ValueExtensions')
## ValueExtensions.SetValue&lt;T&gt;(T, string, object, BindingFlags) Method
Sets a value on a field or property.   
```csharp
public static void SetValue<T>(this ref T self, string fieldOrPropertyName, object value, System.Reflection.BindingFlags bindingFlags=System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic)
    where T : struct;
```
#### Type parameters
<a name='Jcd_Reflection_ValueExtensions_SetValue_T_(T_string_object_System_Reflection_BindingFlags)_T'></a>
`T`  
The type of data being modified.
  
#### Parameters
<a name='Jcd_Reflection_ValueExtensions_SetValue_T_(T_string_object_System_Reflection_BindingFlags)_self'></a>
`self` [T](Jcd_Reflection_ValueExtensions_SetValue_T_(T_string_object_System_Reflection_BindingFlags).md#Jcd_Reflection_ValueExtensions_SetValue_T_(T_string_object_System_Reflection_BindingFlags)_T 'Jcd.Reflection.ValueExtensions.SetValue&lt;T&gt;(T, string, object, System.Reflection.BindingFlags).T')  
The instance to set the value on
  
<a name='Jcd_Reflection_ValueExtensions_SetValue_T_(T_string_object_System_Reflection_BindingFlags)_fieldOrPropertyName'></a>
`fieldOrPropertyName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the name of the field or property to set
  
<a name='Jcd_Reflection_ValueExtensions_SetValue_T_(T_string_object_System_Reflection_BindingFlags)_value'></a>
`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value to set.
  
<a name='Jcd_Reflection_ValueExtensions_SetValue_T_(T_string_object_System_Reflection_BindingFlags)_bindingFlags'></a>
`bindingFlags` [System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')  
The binding flags that help control property or field lookup
  
