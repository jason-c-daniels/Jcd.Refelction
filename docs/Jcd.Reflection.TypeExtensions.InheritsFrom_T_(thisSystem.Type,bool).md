### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[TypeExtensions](Jcd.Reflection.TypeExtensions.md 'Jcd.Reflection.TypeExtensions')

## TypeExtensions.InheritsFrom<T>(this Type, bool) Method

Checks if one type inherits from another. This will match generic inheritance as well.

```csharp
public static bool InheritsFrom<T>(this System.Type derivedType, bool allowSelfToCompareToTrueIfConcrete=false);
```
#### Type parameters

<a name='Jcd.Reflection.TypeExtensions.InheritsFrom_T_(thisSystem.Type,bool).T'></a>

`T`

The type to check inheritance from.
#### Parameters

<a name='Jcd.Reflection.TypeExtensions.InheritsFrom_T_(thisSystem.Type,bool).derivedType'></a>

`derivedType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to check inheritance on.

<a name='Jcd.Reflection.TypeExtensions.InheritsFrom_T_(thisSystem.Type,bool).allowSelfToCompareToTrueIfConcrete'></a>

`allowSelfToCompareToTrueIfConcrete` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if type inherits from [T](Jcd.Reflection.TypeExtensions.InheritsFrom_T_(thisSystem.Type,bool).md#Jcd.Reflection.TypeExtensions.InheritsFrom_T_(thisSystem.Type,bool).T 'Jcd.Reflection.TypeExtensions.InheritsFrom<T>(this System.Type, bool).T')