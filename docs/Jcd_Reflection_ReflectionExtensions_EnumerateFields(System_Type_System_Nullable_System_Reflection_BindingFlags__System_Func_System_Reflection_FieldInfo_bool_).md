### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[ReflectionExtensions](Jcd_Reflection_ReflectionExtensions.md 'Jcd.Reflection.ReflectionExtensions')
## ReflectionExtensions.EnumerateFields(Type, Nullable&lt;BindingFlags&gt;, Func&lt;FieldInfo,bool&gt;) Method
```csharp
public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> EnumerateFields(this System.Type type, System.Nullable<System.Reflection.BindingFlags> flags=null, System.Func<System.Reflection.FieldInfo,bool> skip=null);
```
#### Parameters
<a name='Jcd_Reflection_ReflectionExtensions_EnumerateFields(System_Type_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_FieldInfo_bool_)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
  
<a name='Jcd_Reflection_ReflectionExtensions_EnumerateFields(System_Type_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_FieldInfo_bool_)_flags'></a>
`flags` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
  
<a name='Jcd_Reflection_ReflectionExtensions_EnumerateFields(System_Type_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_FieldInfo_bool_)_skip'></a>
`skip` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
