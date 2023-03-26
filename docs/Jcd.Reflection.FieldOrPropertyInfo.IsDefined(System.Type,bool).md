### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[FieldOrPropertyInfo](Jcd.Reflection.FieldOrPropertyInfo.md 'Jcd.Reflection.FieldOrPropertyInfo')

## FieldOrPropertyInfo.IsDefined(Type, bool) Method

Checks if a custom attribute of the specified type exists for the member.

```csharp
public override bool IsDefined(System.Type attributeType, bool inherit);
```

#### Parameters

<a name='Jcd.Reflection.FieldOrPropertyInfo.IsDefined(System.Type,bool).attributeType'></a>

`attributeType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The data type for the custom attribute

<a name='Jcd.Reflection.FieldOrPropertyInfo.IsDefined(System.Type,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Checks inheritance tree if true

Implements [IsDefined(Type, bool)](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.InteropServices._MemberInfo.IsDefined#System_Runtime_InteropServices__MemberInfo_IsDefined_System_Type,System_Boolean_ 'System.Runtime.InteropServices._MemberInfo.IsDefined(System.Type,System.Boolean)'), [IsDefined(Type, bool)](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ICustomAttributeProvider.IsDefined#System_Reflection_ICustomAttributeProvider_IsDefined_System_Type,System_Boolean_ 'System.Reflection.ICustomAttributeProvider.IsDefined(System.Type,System.Boolean)')

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')