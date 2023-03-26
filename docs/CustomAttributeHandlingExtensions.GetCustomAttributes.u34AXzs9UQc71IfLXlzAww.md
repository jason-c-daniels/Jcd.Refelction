### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this Assembly, bool) Method

Gets all attributes of a specified type on an assembly

```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Reflection.Assembly assembly, bool inherit=false)
    where TAttribute : System.Attribute;
```

#### Type parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.Assembly,bool).TAttribute'></a>

`TAttribute`

The type of attributes to retrieve

#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.Assembly,bool).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

the assembly to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.Assembly,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[TAttribute](CustomAttributeHandlingExtensions.GetCustomAttributes.u34AXzs9UQc71IfLXlzAww.md#Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Reflection.Assembly,bool).TAttribute 'Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this System.Reflection.Assembly, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of located <typeparamre name="TAttribute"/> instances. If none are found, an empty array is returned.