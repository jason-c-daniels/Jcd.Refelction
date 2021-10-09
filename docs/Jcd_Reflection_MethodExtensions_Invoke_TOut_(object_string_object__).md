### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd_Reflection_MethodExtensions.md 'Jcd.Reflection.MethodExtensions')
## MethodExtensions.Invoke&lt;TOut&gt;(object, string, object[]) Method
Invoke the method on the specified object using the provided parameters  
```csharp
public static TOut Invoke<TOut>(this object self, string name, params object[] @params);
```
#### Type parameters
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_string_object__)_TOut'></a>
`TOut`  
result type
  
#### Parameters
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_string_object__)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The instance to invoke the method on
  
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_string_object__)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
the name of the method to invoke
  
<a name='Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_string_object__)_params'></a>
`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
the params for the method
  
#### Returns
[TOut](Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_string_object__).md#Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_string_object__)_TOut 'Jcd.Reflection.MethodExtensions.Invoke&lt;TOut&gt;(object, string, object[]).TOut')  
the result, if any
