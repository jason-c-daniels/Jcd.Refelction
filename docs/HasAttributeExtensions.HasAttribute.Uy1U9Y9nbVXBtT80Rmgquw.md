### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[HasAttributeExtensions](HasAttributeExtensions.md 'Jcd.Reflection.HasAttributeExtensions')

## HasAttributeExtensions.HasAttribute(this TypeInfo, Type, bool) Method

Determines if an attribute has been applied to a
specific [System.Reflection.TypeInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.TypeInfo 'System.Reflection.TypeInfo').

```csharp
public static bool HasAttribute(this System.Reflection.TypeInfo typeInfo, System.Type attributeType, bool inherit=false);
```

#### Parameters

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute(thisSystem.Reflection.TypeInfo,System.Type,bool).typeInfo'></a>

`typeInfo` [System.Reflection.TypeInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.TypeInfo 'System.Reflection.TypeInfo')

The [System.Reflection.TypeInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.TypeInfo 'System.Reflection.TypeInfo')
instance to inspect

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute(thisSystem.Reflection.TypeInfo,System.Type,bool).attributeType'></a>

`attributeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the attribute to detect.

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute(thisSystem.Reflection.TypeInfo,System.Type,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
if one or more attributes of the requested type were
detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
otherwise.