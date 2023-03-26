### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[TypeExtensions](Jcd.Reflection.TypeExtensions.md 'Jcd.Reflection.TypeExtensions')

## TypeExtensions.IsConcreteType(this Type, bool, bool) Method

Determines if a type is a concrete type.

```csharp
public static bool IsConcreteType(this System.Type type, bool allowCompilerGenerated=false, bool allowSpecialNames=false);
```

#### Parameters

<a name='Jcd.Reflection.TypeExtensions.IsConcreteType(thisSystem.Type,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

the type to inspect.

<a name='Jcd.Reflection.TypeExtensions.IsConcreteType(thisSystem.Type,bool,bool).allowCompilerGenerated'></a>

`allowCompilerGenerated` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Allows types that are compiler generated to return true.

<a name='Jcd.Reflection.TypeExtensions.IsConcreteType(thisSystem.Type,bool,bool).allowSpecialNames'></a>

`allowSpecialNames` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Allow types with special names to return true.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the type is concrete.

### Remarks

This method does not account for the public/internal/private nature of the type.  
It only answers the concrete question. (Can something, directly instantiate it,  
that might be another class in a different assembly. You are using reflection,  
after all.)