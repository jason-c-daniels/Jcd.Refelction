### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[TypeExtensions](TypeExtensions.md 'Jcd.Reflection.TypeExtensions')

## TypeExtensions.InheritsFrom(this Type, Type, bool) Method

Checks if one type inherits from another. This will match generic inheritance as well.

```csharp
public static bool InheritsFrom(this System.Type derivedType, System.Type parentType, bool allowSelfToCompareToTrueIfConcrete=false);
```
#### Parameters

<a name='Jcd.Reflection.TypeExtensions.InheritsFrom(thisSystem.Type,System.Type,bool).derivedType'></a>

`derivedType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to check inheritance on.

<a name='Jcd.Reflection.TypeExtensions.InheritsFrom(thisSystem.Type,System.Type,bool).parentType'></a>

`parentType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to check for inheritance against.

<a name='Jcd.Reflection.TypeExtensions.InheritsFrom(thisSystem.Type,System.Type,bool).allowSelfToCompareToTrueIfConcrete'></a>

`allowSelfToCompareToTrueIfConcrete` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if type inherits
from [parentType](TypeExtensions.InheritsFrom.prelIE42SzV2rQdsVlEfJA.md#Jcd.Reflection.TypeExtensions.InheritsFrom(thisSystem.Type,System.Type,bool).parentType 'Jcd.Reflection.TypeExtensions.InheritsFrom(this System.Type, System.Type, bool).parentType')

### Remarks

The [Scrutor](https://github.com/khellang/Scrutor 'https://github.com/khellang/Scrutor') project, on GitHub, by Kristian
Hellang   
provided the inspiration and overall algorithm for determining if a type was derived from another  
regardless of the genericity of the types being compared.