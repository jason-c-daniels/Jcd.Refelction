### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[GetCustomAttributesExtensions](GetCustomAttributesExtensions.md 'Jcd.Reflection.GetCustomAttributesExtensions')

## GetCustomAttributesExtensions.GetCustomAttributes<TAttribute>(this Module, bool) Method

Gets all attributes of a specified type on a module

```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.Module module, bool inherit=false)
    where TAttribute : System.Attribute;
```

#### Type parameters

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.Module,bool).TAttribute'></a>

`TAttribute`

The type of attributes to retrieve

#### Parameters

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.Module,bool).module'></a>

`module` [System.Reflection.Module](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Module 'System.Reflection.Module')

the module to inspect

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.Module,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[TAttribute](GetCustomAttributesExtensions.GetCustomAttributes.HP36Ycg4WkHa2eAgopkxCw.md#Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.Module,bool).TAttribute 'Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes<TAttribute>(this System.Reflection.Module, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of located <typeparamre name="TAttribute"/> instances. If none are found, an empty array is returned.