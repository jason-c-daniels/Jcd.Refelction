### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](Jcd.Reflection.CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.HasAttribute(this MemberInfo, Type, bool) Method

Determines if an attribute has been applied to a
specific [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo').

```csharp
public static bool HasAttribute(this System.Reflection.MemberInfo memberInfo, System.Type attributeType, bool inherit=false);
```

#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.MemberInfo,System.Type,bool).memberInfo'></a>

`memberInfo` [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')

The [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')
instance to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.MemberInfo,System.Type,bool).attributeType'></a>

`attributeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the attribute to detect.

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.MemberInfo,System.Type,bool).inherit'></a>

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