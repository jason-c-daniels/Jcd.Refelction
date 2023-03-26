### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.HasAttribute<TAttribute>(this EventInfo, bool) Method

Determines if an attribute has been applied to a
specific [System.Reflection.EventInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.EventInfo 'System.Reflection.EventInfo').

```csharp
public static bool HasAttribute<TAttribute>(this System.Reflection.EventInfo eventInfo, bool inherit=false);
```

#### Type parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.EventInfo,bool).TAttribute'></a>

`TAttribute`

The type of the attribute to detect.

#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.EventInfo,bool).eventInfo'></a>

`eventInfo` [System.Reflection.EventInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.EventInfo 'System.Reflection.EventInfo')

The [System.Reflection.EventInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.EventInfo 'System.Reflection.EventInfo')
instance to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute_TAttribute_(thisSystem.Reflection.EventInfo,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
if one or more attributes of the requested type were
detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')
otherwise.