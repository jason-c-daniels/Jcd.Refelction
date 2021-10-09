### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[ReflectionExtensions](Jcd_Reflection_ReflectionExtensions.md 'Jcd.Reflection.ReflectionExtensions')
## ReflectionExtensions.EnumerateProperties(object, Nullable&lt;BindingFlags&gt;, Func&lt;PropertyInfo,bool&gt;) Method
```csharp
public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> EnumerateProperties(this object self, System.Nullable<System.Reflection.BindingFlags> flags=null, System.Func<System.Reflection.PropertyInfo,bool> skip=null);
```
#### Parameters
<a name='Jcd_Reflection_ReflectionExtensions_EnumerateProperties(object_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_PropertyInfo_bool_)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
<a name='Jcd_Reflection_ReflectionExtensions_EnumerateProperties(object_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_PropertyInfo_bool_)_flags'></a>
`flags` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')  
  
<a name='Jcd_Reflection_ReflectionExtensions_EnumerateProperties(object_System_Nullable_System_Reflection_BindingFlags__System_Func_System_Reflection_PropertyInfo_bool_)_skip'></a>
`skip` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.PropertyInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.PropertyInfo 'System.Reflection.PropertyInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
