### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[TypeExtensions](TypeExtensions.md 'Jcd.Reflection.TypeExtensions')

## TypeExtensions.GetNonInterfaceBaseTypes(this Type) Method

Retrieves an array of the non-interface base types for the  
passed in type.

```csharp
public static System.Collections.Generic.IEnumerable<System.Type> GetNonInterfaceBaseTypes(this System.Type type);
```
#### Parameters

<a name='Jcd.Reflection.TypeExtensions.GetNonInterfaceBaseTypes(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

the type to retrieve base types from.

#### Returns

[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
an array of the non-interface base types