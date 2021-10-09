### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[ExpandoObjectExtensions](Jcd_Reflection_ExpandoObjectExtensions.md 'Jcd.Reflection.ExpandoObjectExtensions')
## ExpandoObjectExtensions.ToDictionaryTree&lt;TNode&gt;(object, HashSet&lt;object&gt;, Func&lt;string,string&gt;, Func&lt;string,object,bool&gt;) Method
```csharp
private static dynamic ToDictionaryTree<TNode>(this object self, System.Collections.Generic.HashSet<object> visited=null, System.Func<string,string> keyRenamingStrategy=null, System.Func<string,object,bool> valueRetentionStrategy=null)
    where TNode : System.Collections.Generic.IDictionary<string, object>, new();
```
#### Type parameters
<a name='Jcd_Reflection_ExpandoObjectExtensions_ToDictionaryTree_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool_)_TNode'></a>
`TNode`  
  
#### Parameters
<a name='Jcd_Reflection_ExpandoObjectExtensions_ToDictionaryTree_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool_)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
<a name='Jcd_Reflection_ExpandoObjectExtensions_ToDictionaryTree_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool_)_visited'></a>
`visited` [System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')  
  
<a name='Jcd_Reflection_ExpandoObjectExtensions_ToDictionaryTree_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool_)_keyRenamingStrategy'></a>
`keyRenamingStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
<a name='Jcd_Reflection_ExpandoObjectExtensions_ToDictionaryTree_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool_)_valueRetentionStrategy'></a>
`valueRetentionStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
  
#### Returns
[dynamic](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic 'https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic')  
