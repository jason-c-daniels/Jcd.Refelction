### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](Jcd.Reflection.CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.HasAttribute(this EventInfo, Type, bool) Method

Determines if an attribute has been applied to a specific [System.Reflection.EventInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.EventInfo 'System.Reflection.EventInfo').

```csharp
public static bool HasAttribute(this System.Reflection.EventInfo eventInfo, System.Type attributeType, bool inherit=false);
```
#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.EventInfo,System.Type,bool).eventInfo'></a>

`eventInfo` [System.Reflection.EventInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.EventInfo 'System.Reflection.EventInfo')

The [System.Reflection.EventInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.EventInfo 'System.Reflection.EventInfo') instance to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.EventInfo,System.Type,bool).attributeType'></a>

`attributeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of the attribute to detect.

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.HasAttribute(thisSystem.Reflection.EventInfo,System.Type,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if one or more attributes of the requested type were detected; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') otherwise.