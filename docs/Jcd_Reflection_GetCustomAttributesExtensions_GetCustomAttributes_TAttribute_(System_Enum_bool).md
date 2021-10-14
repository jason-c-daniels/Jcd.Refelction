### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[GetCustomAttributesExtensions](Jcd_Reflection_GetCustomAttributesExtensions.md 'Jcd.Reflection.GetCustomAttributesExtensions')
## GetCustomAttributesExtensions.GetCustomAttributes&lt;TAttribute&gt;(Enum, bool) Method
Gets all attributes of a specified type on an enum value  
```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Enum value, bool inherit=false)
    where TAttribute : System.Attribute;
```
#### Type parameters
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Enum_bool)_TAttribute'></a>
`TAttribute`  
The type of attributes to retrieve
  
#### Parameters
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Enum_bool)_value'></a>
`value` [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum')  
the enum value to inspect
  
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Enum_bool)_inherit'></a>
`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
inspect the inheritance hierarchy
  
#### Returns
[TAttribute](Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Enum_bool).md#Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Enum_bool)_TAttribute 'Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes&lt;TAttribute&gt;(System.Enum, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An enumerable 
