### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[HasAttributeExtensions](HasAttributeExtensions.md 'Jcd.Reflection.HasAttributeExtensions')

## HasAttributeExtensions.HasAttribute<TAttribute>(this Module, bool) Method

Determines if an attribute has been applied to a specific [System.Reflection.Module](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Module 'System.Reflection.Module').

```csharp
public static bool HasAttribute<TAttribute>(this System.Reflection.Module module, bool inherit=false);
```
#### Type parameters

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.Module,bool).TAttribute'></a>

`TAttribute`

The type of the attribute to detect.
#### Parameters

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.Module,bool).module'></a>

`module` [System.Reflection.Module](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Module 'System.Reflection.Module')

The [System.Reflection.Module](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Module 'System.Reflection.Module') instance to inspect

<a name='Jcd.Reflection.HasAttributeExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.Module,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if one or more attributes of the requested type were detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') otherwise.