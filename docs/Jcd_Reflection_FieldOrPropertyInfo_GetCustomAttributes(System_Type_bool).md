### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[FieldOrPropertyInfo](Jcd_Reflection_FieldOrPropertyInfo.md 'Jcd.Reflection.FieldOrPropertyInfo')
## FieldOrPropertyInfo.GetCustomAttributes(Type, bool) Method
Gets custom attributes of a specified type for a member.  
```csharp
public override object[] GetCustomAttributes(System.Type attributeType, bool inherit);
```
#### Parameters
<a name='Jcd_Reflection_FieldOrPropertyInfo_GetCustomAttributes(System_Type_bool)_attributeType'></a>
`attributeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The data type for the custom attribute
  
<a name='Jcd_Reflection_FieldOrPropertyInfo_GetCustomAttributes(System_Type_bool)_inherit'></a>
`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Get inherited attributes if true
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  

Implements [GetCustomAttributes(Type, bool)](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ICustomAttributeProvider.GetCustomAttributes#System_Reflection_ICustomAttributeProvider_GetCustomAttributes_System_Type,System_Boolean_ 'System.Reflection.ICustomAttributeProvider.GetCustomAttributes(System.Type,System.Boolean)')  
