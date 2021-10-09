### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[ReflectionExtensions](Jcd_Reflection_ReflectionExtensions.md 'Jcd.Reflection.ReflectionExtensions')
## ReflectionExtensions.ToFieldInfoValuePairs(IEnumerable&lt;FieldInfo&gt;, object, Func&lt;FieldInfo,bool&gt;) Method
```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Reflection.FieldInfo,object>> ToFieldInfoValuePairs(this System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> items, object item, System.Func<System.Reflection.FieldInfo,bool> skip=null);
```
#### Parameters
<a name='Jcd_Reflection_ReflectionExtensions_ToFieldInfoValuePairs(System_Collections_Generic_IEnumerable_System_Reflection_FieldInfo__object_System_Func_System_Reflection_FieldInfo_bool_)_items'></a>
`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
  
<a name='Jcd_Reflection_ReflectionExtensions_ToFieldInfoValuePairs(System_Collections_Generic_IEnumerable_System_Reflection_FieldInfo__object_System_Func_System_Reflection_FieldInfo_bool_)_item'></a>
`item` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
<a name='Jcd_Reflection_ReflectionExtensions_ToFieldInfoValuePairs(System_Collections_Generic_IEnumerable_System_Reflection_FieldInfo__object_System_Func_System_Reflection_FieldInfo_bool_)_skip'></a>
`skip` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Reflection.FieldInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.FieldInfo 'System.Reflection.FieldInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
