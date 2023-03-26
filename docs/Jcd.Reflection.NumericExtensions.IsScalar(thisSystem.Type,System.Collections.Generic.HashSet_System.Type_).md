### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[NumericExtensions](Jcd.Reflection.NumericExtensions.md 'Jcd.Reflection.NumericExtensions')

## NumericExtensions.IsScalar(this Type, HashSet<Type>) Method

Indicates if a type is a scalar type.

```csharp
public static bool IsScalar(this System.Type type, System.Collections.Generic.HashSet<System.Type> nonPrimitiveScalars=null);
```

#### Parameters

<a name='Jcd.Reflection.NumericExtensions.IsScalar(thisSystem.Type,System.Collections.Generic.HashSet_System.Type_).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

the value to test

<a name='Jcd.Reflection.NumericExtensions.IsScalar(thisSystem.Type,System.Collections.Generic.HashSet_System.Type_).nonPrimitiveScalars'></a>

`nonPrimitiveScalars` [System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')

a hashset of non-primitive scalar types to check against

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true
if [type](Jcd.Reflection.NumericExtensions.IsScalar(thisSystem.Type,System.Collections.Generic.HashSet_System.Type_).md#Jcd.Reflection.NumericExtensions.IsScalar(thisSystem.Type,System.Collections.Generic.HashSet_System.Type_).type 'Jcd.Reflection.NumericExtensions.IsScalar(this System.Type, System.Collections.Generic.HashSet<System.Type>).type')
is scalar.