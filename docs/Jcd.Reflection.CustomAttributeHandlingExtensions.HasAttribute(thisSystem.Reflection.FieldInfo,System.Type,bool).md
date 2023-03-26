### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](Jcd.Reflection.CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.HasAttribute(this FieldInfo, Type, bool) Method

Determines if an attribute has been applied to a specific [System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo').

```csharp
public static bool HasAttribute(this System.Reflection.FieldInfo fieldInfo, System.Type attributeType, bool inherit=false);
```
#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.FieldInfo,System.Type,bool).fieldInfo'></a>

`fieldInfo` [System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')

The [System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo') instance to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.FieldInfo,System.Type,bool).attributeType'></a>

`attributeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the attribute to detect.

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.FieldInfo,System.Type,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if one or more attributes of the requested type were detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') otherwise.

### Remarks
Technique and name adopted from the [Scrutor Project](https://github.com/khellang/Scrutor 'https://github.com/khellang/Scrutor') by [Kristian Hellang](https://github.com/khellang 'https://github.com/khellang')