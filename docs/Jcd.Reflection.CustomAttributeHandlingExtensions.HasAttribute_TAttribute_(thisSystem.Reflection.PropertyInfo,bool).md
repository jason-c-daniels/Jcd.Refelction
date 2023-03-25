### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](Jcd.Reflection.CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.HasAttribute<TAttribute>(this PropertyInfo, bool) Method

Determines if an attribute has been applied to a
specific [System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo').

```csharp
public static bool HasAttribute<TAttribute>(this System.Reflection.PropertyInfo propertyInfo, bool inherit=false);
```

#### Type parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.PropertyInfo,bool).TAttribute'></a>

`TAttribute`

The type of the attribute to detect.

#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.PropertyInfo,bool).propertyInfo'></a>

`propertyInfo` [System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')

The [System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')
instance to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.PropertyInfo,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
if one or more attributes of the requested type were
detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
otherwise.