### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[GetCustomAttributesExtensions](Jcd.Reflection.GetCustomAttributesExtensions.md 'Jcd.Reflection.GetCustomAttributesExtensions')

## GetCustomAttributesExtensions.GetCustomAttributes<TAttribute>(this ParameterInfo, bool) Method

Gets all attributes of a specified type on a parameter

```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.ParameterInfo paramInfo, bool inherit=false)
    where TAttribute : System.Attribute;
```
#### Type parameters

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.ParameterInfo,bool).TAttribute'></a>

`TAttribute`

The type of attributes to retrieve
#### Parameters

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.ParameterInfo,bool).paramInfo'></a>

`paramInfo` [System.Reflection.ParameterInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ParameterInfo 'System.Reflection.ParameterInfo')

the parameter to inspect

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.ParameterInfo,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns
[TAttribute](Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.ParameterInfo,bool).md#Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.ParameterInfo,bool).TAttribute 'Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes<TAttribute>(this System.Reflection.ParameterInfo, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An enumerable