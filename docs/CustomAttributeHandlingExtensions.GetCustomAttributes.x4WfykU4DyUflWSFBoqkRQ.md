### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this MemberInfo, bool) Method

Gets all attributes of a specified type on a MemberInfo

```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.MemberInfo memberInfo, bool inherit=false)
    where TAttribute : System.Attribute;
```

#### Type parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MemberInfo,bool).TAttribute'></a>

`TAttribute`

The type of attributes to retrieve

#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MemberInfo,bool).memberInfo'></a>

`memberInfo` [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')

the MemberInfo to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MemberInfo,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[TAttribute](CustomAttributeHandlingExtensions.GetCustomAttributes.x4WfykU4DyUflWSFBoqkRQ.md#Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MemberInfo,bool).TAttribute 'Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this System.Reflection.MemberInfo, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of
located [TAttribute](CustomAttributeHandlingExtensions.GetCustomAttributes.x4WfykU4DyUflWSFBoqkRQ.md#Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MemberInfo,bool).TAttribute 'Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this System.Reflection.MemberInfo, bool).TAttribute')
instances. If none are found, an empty array is returned.