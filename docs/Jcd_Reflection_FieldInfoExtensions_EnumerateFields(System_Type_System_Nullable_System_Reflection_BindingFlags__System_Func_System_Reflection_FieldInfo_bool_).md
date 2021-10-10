### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[FieldInfoExtensions](Jcd_Reflection_FieldInfoExtensions.md 'Jcd.Reflection.FieldInfoExtensions')
## FieldInfoExtensions.EnumerateFields(Type, Nullable&lt;BindingFlags&gt;, Func&lt;FieldInfo,bool&gt;) Method
Enumerate the FieldInfo entries for a given type   
```csharp
public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> EnumerateFields(this System.Type type, System.Nullable<System.Reflection.BindingFlags> flags=null, System.Func<System.Reflection.FieldInfo,bool> skip=null);
```
#### Parameters
<a name='Jcd_Reflection_FieldInfoExtensions_EnumerateFields(System_Type_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_FieldInfo_bool_)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The data type to reflect on
  
<a name='Jcd_Reflection_FieldInfoExtensions_EnumerateFields(System_Type_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_FieldInfo_bool_)_flags'></a>
`flags` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
The BindingFlags
  
<a name='Jcd_Reflection_FieldInfoExtensions_EnumerateFields(System_Type_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_FieldInfo_bool_)_skip'></a>
`skip` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
a predicate for skipping certain entries (e.g. System...)
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An enumerable across FieldInfo s
