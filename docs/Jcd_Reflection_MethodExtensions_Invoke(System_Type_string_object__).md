### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[MethodExtensions](Jcd_Reflection_MethodExtensions.md 'Jcd.Reflection.MethodExtensions')
## MethodExtensions.Invoke(Type, string, object[]) Method
Invokes a static method on a type   
```csharp
public static object Invoke(this System.Type type, string name, params object[] @params);
```
#### Parameters
<a name='Jcd_Reflection_MethodExtensions_Invoke(System_Type_string_object__)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type containing the static method
  
<a name='Jcd_Reflection_MethodExtensions_Invoke(System_Type_string_object__)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the method
  
<a name='Jcd_Reflection_MethodExtensions_Invoke(System_Type_string_object__)_params'></a>
`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The params to pass
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The result of the call, if any
