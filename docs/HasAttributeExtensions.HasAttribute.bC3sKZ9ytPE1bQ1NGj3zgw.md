### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[HasAttributeExtensions](HasAttributeExtensions.md 'Jcd.Reflection.HasAttributeExtensions')

## HasAttributeExtensions.HasAttribute(this ParameterInfo, Type, bool) Method

Determines if an attribute has been applied to a
specific [System.Reflection.ParameterInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ParameterInfo 'System.Reflection.ParameterInfo').

```csharp
public static bool HasAttribute(this System.Reflection.ParameterInfo paramInfo, System.Type attributeType, bool inherit=false);
```

#### Parameters

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute(thisSystem.Reflection.ParameterInfo,System.Type,bool).paramInfo'></a>

`paramInfo` [System.Reflection.ParameterInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ParameterInfo 'System.Reflection.ParameterInfo')

The [System.Reflection.ParameterInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ParameterInfo 'System.Reflection.ParameterInfo')
instance to inspect

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute(thisSystem.Reflection.ParameterInfo,System.Type,bool).attributeType'></a>

`attributeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the attribute to detect.

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute(thisSystem.Reflection.ParameterInfo,System.Type,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
if one or more attributes of the requested type were
detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
otherwise.