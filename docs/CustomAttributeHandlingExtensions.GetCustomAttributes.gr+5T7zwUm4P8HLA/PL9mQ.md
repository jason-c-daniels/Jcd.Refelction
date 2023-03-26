### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[CustomAttributeHandlingExtensions](CustomAttributeHandlingExtensions.md 'Jcd.Reflection.CustomAttributeHandlingExtensions')

## CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this Type, bool) Method

Gets all attributes of a specified type on a type

```csharp
public static TAttribute[] GetCustomAttributes<TAttribute>(this System.Type type, bool inherit=false)
    where TAttribute : System.Attribute;
```

#### Type parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Type,bool).TAttribute'></a>

`TAttribute`

The type of attributes to retrieve

#### Parameters

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Type,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

the type to inspect

<a name='Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Type,bool).inherit'></a>

`inherit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

inspect the inheritance hierarchy

#### Returns

[TAttribute](CustomAttributeHandlingExtensions.GetCustomAttributes.gr+5T7zwUm4P8HLA/PL9mQ.md#Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes_TAttribute_(thisSystem.Type,bool).TAttribute 'Jcd.Reflection.CustomAttributeHandlingExtensions.GetCustomAttributes<TAttribute>(this System.Type, bool).TAttribute')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array of located <typeparamre name="TAttribute"/> instances. If none are found, an empty array is returned.