### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[GetCustomAttributesExtensions](Jcd_Reflection_GetCustomAttributesExtensions.md 'Jcd.Reflection.GetCustomAttributesExtensions')
## GetCustomAttributesExtensions.GetCustomAttributes&lt;TAttribute&gt;(MemberInfo, bool) Method
Gets all attributes of a specified type on a MemberInfo  
```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.MemberInfo memberInfo, bool inherit=false)
    where TAttribute : System.Attribute;
```
#### Type parameters
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_MemberInfo_bool)_TAttribute'></a>
`TAttribute`  
The type of attributes to retrieve
  
#### Parameters
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_MemberInfo_bool)_memberInfo'></a>
`memberInfo` [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')  
the MemberInfo to inspect
  
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_MemberInfo_bool)_inherit'></a>
`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
inspect the inheritance hierarchy
  
#### Returns
[TAttribute](Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_MemberInfo_bool).md#Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_MemberInfo_bool)_TAttribute 'Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes&lt;TAttribute&gt;(System.Reflection.MemberInfo, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An enumerable 
