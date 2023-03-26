### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[PropertyInfoExtensions](Jcd.Reflection.PropertyInfoExtensions.md 'Jcd.Reflection.PropertyInfoExtensions')

## PropertyInfoExtensions.EnumerateProperties(this Type, Nullable<BindingFlags>, Func<PropertyInfo,bool>, bool, bool) Method

Enumerate the PropertyInfo entries for a given type

```csharp
public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> EnumerateProperties(this System.Type type, System.Nullable<System.Reflection.BindingFlags> flags=null, System.Func<System.Reflection.PropertyInfo,bool> skip=null, bool returnSystem=false, bool returnWriteOnly=false);
```

#### Parameters

<a name='Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_,bool,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The data type to reflect on

<a name='Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_,bool,bool).flags'></a>

`flags` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The BindingFlags

<a name='Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_,bool,bool).skip'></a>

`skip` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

a predicate for skipping certain entries.

<a name='Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_,bool,bool).returnSystem'></a>

`returnSystem` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates if properties whose declaring type is in the System. namespace should be returned. Default
is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')

<a name='Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_,bool,bool).returnWriteOnly'></a>

`returnWriteOnly` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Indicates if properties that are write only should be returned. Default
is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')

#### Returns

[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An enumerable across PropertyInfo s