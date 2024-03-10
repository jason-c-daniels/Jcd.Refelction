### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[PropertyInfoExtensions](PropertyInfoExtensions.md 'Jcd.Reflection.PropertyInfoExtensions')

## PropertyInfoExtensions.EnumerateProperties(this Type, Nullable<BindingFlags>, Func<PropertyInfo,bool>) Method

Enumerate the PropertyInfo entries for a given type

```csharp
public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> EnumerateProperties(this System.Type type, System.Nullable<System.Reflection.BindingFlags> flags=null, System.Func<System.Reflection.PropertyInfo,bool> skip=null);
```
#### Parameters

<a name='Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The data type to reflect on

<a name='Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_).flags'></a>

`flags` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The BindingFlags

<a name='Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_).skip'></a>

`skip` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

a predicate for skipping certain entries (e.g. System...)

#### Returns

[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An enumerable across PropertyInfo s