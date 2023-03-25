### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## TypeExtensions Class

Provides extension methods for [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') interactions.

```csharp
public static class TypeExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TypeExtensions

| Methods | |
| :--- | :--- |
| [DirectlyInheritsFromGenericTypeDefinition(this Type, Type, bool)](Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(thisSystem.Type,System.Type,bool).md 'Jcd.Reflection.TypeExtensions.DirectlyInheritsFromGenericTypeDefinition(this System.Type, System.Type, bool)') | Determines if the [derivedType](https://docs.microsoft.com/en-us/dotnet/api/derivedType 'derivedType') is directly derived from the [genericTypeDefinition](https://docs.microsoft.com/en-us/dotnet/api/genericTypeDefinition 'genericTypeDefinition') |
| [GetNonInterfaceBaseTypes(this Type)](Jcd.Reflection.TypeExtensions.GetNonInterfaceBaseTypes(thisSystem.Type).md 'Jcd.Reflection.TypeExtensions.GetNonInterfaceBaseTypes(this System.Type)') | Retrieves an array of the non-interface base types for the<br/>passed in type. |
| [InheritsFrom(this Type, Type, bool)](Jcd.Reflection.TypeExtensions.InheritsFrom(thisSystem.Type,System.Type,bool).md 'Jcd.Reflection.TypeExtensions.InheritsFrom(this System.Type, System.Type, bool)') | Checks if one type inherits from another. This will match generic inheritance as well. |
| [InheritsFrom&lt;T&gt;(this Type, bool)](Jcd.Reflection.TypeExtensions.InheritsFrom_T_(thisSystem.Type,bool).md 'Jcd.Reflection.TypeExtensions.InheritsFrom<T>(this System.Type, bool)') | Checks if one type inherits from another. This will match generic inheritance as well. |
| [InheritsFromGenericTypeDefinition(this Type, Type, bool)](Jcd.Reflection.TypeExtensions.InheritsFromGenericTypeDefinition(thisSystem.Type,System.Type,bool).md 'Jcd.Reflection.TypeExtensions.InheritsFromGenericTypeDefinition(this System.Type, System.Type, bool)') | Determines if the [derivedType](https://docs.microsoft.com/en-us/dotnet/api/derivedType 'derivedType') is directly or indirectly derived from the [genericTypeDefinition](https://docs.microsoft.com/en-us/dotnet/api/genericTypeDefinition 'genericTypeDefinition') |
| [IsCompilerGenerated(this Type)](Jcd.Reflection.TypeExtensions.IsCompilerGenerated(thisSystem.Type).md 'Jcd.Reflection.TypeExtensions.IsCompilerGenerated(this System.Type)') | Indicates if the type is compiler generated. |
| [IsConcreteType(this Type, bool, bool)](Jcd.Reflection.TypeExtensions.IsConcreteType(thisSystem.Type,bool,bool).md 'Jcd.Reflection.TypeExtensions.IsConcreteType(this System.Type, bool, bool)') | Determines if a type is a concrete type. |
