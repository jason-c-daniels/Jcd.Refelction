### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[TypeExtensions](TypeExtensions.md 'Jcd.Reflection.TypeExtensions')

## TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(this Type, Type, bool) Method

Determines if the [derivedType](TypeExtensions.DirectlyInheritsFromGenericTypeDefinition.qE66oTVx3GVuaGUl6VtNHQ.md#Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(thisSystem.Type,System.Type,bool).derivedType 'Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(this System.Type, System.Type, bool).derivedType') is directly derived from the [genericTypeDefinition](TypeExtensions.DirectlyInheritsFromGenericTypeDefinition.qE66oTVx3GVuaGUl6VtNHQ.md#Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(thisSystem.Type,System.Type,bool).genericTypeDefinition 'Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(this System.Type, System.Type, bool).genericTypeDefinition')

```csharp
public static bool DirectlyInheritsFromGenericTypeDefinition(this System.Type derivedType, System.Type genericTypeDefinition, bool allowSelfToCompareToTrueIfConcrete=false);
```
#### Parameters

<a name='Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(thisSystem.Type,System.Type,bool).derivedType'></a>

`derivedType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to inspect.

<a name='Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(thisSystem.Type,System.Type,bool).genericTypeDefinition'></a>

`genericTypeDefinition` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The generic type definition to compare against.

<a name='Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(thisSystem.Type,System.Type,bool).allowSelfToCompareToTrueIfConcrete'></a>

`allowSelfToCompareToTrueIfConcrete` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Allows true to be returned if derivedType is exactly the generic type.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the derivedType is a direct descendant; [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')

### Remarks
The [Scrutor](https://github.com/khellang/Scrutor 'https://github.com/khellang/Scrutor') project by khellang on GitHub
provided the inspiration and overall algorithm for determining if a type was derived from another
regardless of the genericity of the types being compared.