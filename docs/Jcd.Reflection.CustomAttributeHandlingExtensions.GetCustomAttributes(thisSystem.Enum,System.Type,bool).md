### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](Jcd.Reflection.CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.GetCustomAttributes(this Enum, Type, bool) Method

Gets all attributes of a specified type on an enum value

```csharp
public static System.Attribute[] GetCustomAttributes(this System.Enum value, System.Type attributeType, bool inherit=false);
```

#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes(thisSystem.Enum,System.Type,bool).value'></a>

`value` [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum')

the enum value to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes(thisSystem.Enum,System.Type,bool).attributeType'></a>

`attributeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type of attributes to retrieve.

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes(thisSystem.Enum,System.Type,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of located [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute')
instances. If none are found, an empty array is returned.