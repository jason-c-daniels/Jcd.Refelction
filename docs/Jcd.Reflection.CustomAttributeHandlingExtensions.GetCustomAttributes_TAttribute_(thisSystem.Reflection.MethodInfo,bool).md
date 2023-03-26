### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](Jcd.Reflection.CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this MethodInfo, bool) Method

Gets all attributes of a specified type on a MethodInfo

```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.MethodInfo methodInfo, bool inherit=false)
    where TAttribute : System.Attribute;
```
#### Type parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MethodInfo,bool).TAttribute'></a>

`TAttribute`

The type of attributes to retrieve
#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MethodInfo,bool).methodInfo'></a>

`methodInfo` [System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')

the method to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MethodInfo,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns
[TAttribute](Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MethodInfo,bool).md#Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.MethodInfo,bool).TAttribute 'Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this System.Reflection.MethodInfo, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of located <typeparamre name="TAttribute"/> instances. If none are found, an empty array is returned.