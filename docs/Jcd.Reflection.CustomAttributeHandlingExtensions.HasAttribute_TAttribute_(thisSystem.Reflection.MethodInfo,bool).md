### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](Jcd.Reflection.CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.HasAttribute<TAttribute>(this MethodInfo, bool) Method

Determines if an attribute has been applied to a specific [System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo').

```csharp
public static bool HasAttribute<TAttribute>(this System.Reflection.MethodInfo methodInfo, bool inherit=false);
```
#### Type parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.MethodInfo,bool).TAttribute'></a>

`TAttribute`

The type of the attribute to detect.
#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.MethodInfo,bool).methodInfo'></a>

`methodInfo` [System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')

The [System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo') instance to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.MethodInfo,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if one or more attributes of the requested type were detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') otherwise.

### Remarks
Technique and name adopted from the [Scrutor Project](https://github.com/khellang/Scrutor 'https://github.com/khellang/Scrutor') by [Kristian Hellang](https://github.com/khellang 'https://github.com/khellang')