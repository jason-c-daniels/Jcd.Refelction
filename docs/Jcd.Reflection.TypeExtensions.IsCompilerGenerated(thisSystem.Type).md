### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[TypeExtensions](Jcd.Reflection.TypeExtensions.md 'Jcd.Reflection.TypeExtensions')

## TypeExtensions.IsCompilerGenerated(this Type) Method

Indicates if the type is compiler generated.

```csharp
public static bool IsCompilerGenerated(this System.Type type);
```
#### Parameters

<a name='Jcd.Reflection.TypeExtensions.IsCompilerGenerated(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to inspect.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the type has the [System.Runtime.CompilerServices.CompilerGeneratedAttribute](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.CompilerGeneratedAttribute 'System.Runtime.CompilerServices.CompilerGeneratedAttribute') attribute applied.