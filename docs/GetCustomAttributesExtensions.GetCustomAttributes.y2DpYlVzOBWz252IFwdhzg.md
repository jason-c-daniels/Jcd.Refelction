### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[GetCustomAttributesExtensions](GetCustomAttributesExtensions.md 'Jcd.Reflection.GetCustomAttributesExtensions')

## GetCustomAttributesExtensions.GetCustomAttributes<TAttribute>(this FieldInfo, bool) Method

Gets all attributes of a specified type on a FieldInfo

```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.FieldInfo fieldInfo, bool inherit=false)
    where TAttribute : System.Attribute;
```

#### Type parameters

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.FieldInfo,bool).TAttribute'></a>

`TAttribute`

The type of attributes to retrieve

#### Parameters

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.FieldInfo,bool).fieldInfo'></a>

`fieldInfo` [System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')

the field to inspect

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.FieldInfo,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[TAttribute](GetCustomAttributesExtensions.GetCustomAttributes.y2DpYlVzOBWz252IFwdhzg.md#Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.FieldInfo,bool).TAttribute 'Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes<TAttribute>(this System.Reflection.FieldInfo, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array of located <typeparamre name="TAttribute"/> instances. If none are found, an empty array is
returned.