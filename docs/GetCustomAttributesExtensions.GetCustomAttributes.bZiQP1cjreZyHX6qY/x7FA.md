### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[GetCustomAttributesExtensions](GetCustomAttributesExtensions.md 'Jcd.Reflection.GetCustomAttributesExtensions')

## GetCustomAttributesExtensions.GetCustomAttributes<TAttribute>(this TypeInfo, bool) Method

Gets all attributes of a specified type on a TypeInfo

```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.TypeInfo typeInfo, bool inherit=false)
    where TAttribute : System.Attribute;
```

#### Type parameters

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.TypeInfo,bool).TAttribute'></a>

`TAttribute`

The type of attributes to retrieve

#### Parameters

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.TypeInfo,bool).typeInfo'></a>

`typeInfo` [System.Reflection.TypeInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.TypeInfo 'System.Reflection.TypeInfo')

the typeInfo to inspect

<a name='Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.TypeInfo,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[TAttribute](GetCustomAttributesExtensions.GetCustomAttributes.bZiQP1cjreZyHX6qY/x7FA.md#Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.TypeInfo,bool).TAttribute 'Jcd.Reflection.GetCustomAttributesExtensions.GetCustomAttributes<TAttribute>(this System.Reflection.TypeInfo, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
An array of located <typeparamre name="TAttribute"/> instances. If none are found, an empty array is
returned.