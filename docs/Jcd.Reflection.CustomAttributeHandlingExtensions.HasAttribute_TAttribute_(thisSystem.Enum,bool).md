### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](Jcd.Reflection.CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.HasAttribute<TAttribute>(this Enum, bool) Method

Determines if an attribute has been applied to a specific enum value in an enum.

```csharp
public static bool HasAttribute<TAttribute>(this System.Enum value, bool inherit=true)
    where TAttribute : System.Attribute;
```

#### Type parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Enum,bool).TAttribute'></a>

`TAttribute`

The type of the attribute to detect.

#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Enum,bool).value'></a>

`value` [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum')

The enum value to inspect.

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Enum,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
if one or more attributes of the requested type were
detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
otherwise.

### Remarks

Technique and name adopted from
the [Scrutor Project](https://github.com/khellang/Scrutor 'https://github.com/khellang/Scrutor')
by [Kristian Hellang](https://github.com/khellang 'https://github.com/khellang')