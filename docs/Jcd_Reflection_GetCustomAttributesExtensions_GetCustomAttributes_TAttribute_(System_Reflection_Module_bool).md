### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[GetCustomAttributesExtensions](Jcd_Reflection_GetCustomAttributesExtensions.md 'Jcd.Reflection.GetCustomAttributesExtensions')
## GetCustomAttributesExtensions.GetCustomAttributes&lt;TAttribute&gt;(Module, bool) Method
Gets all attributes of a specified type on a module  
```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.Module module, bool inherit=false)
    where TAttribute : System.Attribute;
```
#### Type parameters
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_Module_bool)_TAttribute'></a>
`TAttribute`  
The type of attributes to retrieve
  
#### Parameters
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_Module_bool)_module'></a>
`module` [System.Reflection.Module](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Module 'System.Reflection.Module')  
the module to inspect
  
<a name='Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_Module_bool)_inherit'></a>
`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
inspect the inheritance hierarchy
  
#### Returns
[TAttribute](Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_Module_bool).md#Jcd_Reflection_GetCustomAttributesExtensions_GetCustomAttributes_TAttribute_(System_Reflection_Module_bool)_TAttribute 'Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes&lt;TAttribute&gt;(System.Reflection.Module, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An enumerable 
