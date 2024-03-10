### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[FieldOrPropertyInfo](FieldOrPropertyInfo.md 'Jcd.Reflection.FieldOrPropertyInfo')

## FieldOrPropertyInfo.GetCustomAttributes(bool) Method

Gets custom attributes for the member.

```csharp
public override object[] GetCustomAttributes(bool inherit);
```
#### Parameters

<a name='Jcd.Reflection.FieldOrPropertyInfo.GetCustomAttributes(bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Get inherited attributes if true

Implements [GetCustomAttributes(bool)](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.InteropServices._MemberInfo.GetCustomAttributes#System_Runtime_InteropServices__MemberInfo_GetCustomAttributes_System_Boolean_ 'System.Runtime.InteropServices._MemberInfo.GetCustomAttributes(System.Boolean)'), [GetCustomAttributes(bool)](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ICustomAttributeProvider.GetCustomAttributes#System_Reflection_ICustomAttributeProvider_GetCustomAttributes_System_Boolean_ 'System.Reflection.ICustomAttributeProvider.GetCustomAttributes(System.Boolean)')

#### Returns

[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')
an array of custom attributes