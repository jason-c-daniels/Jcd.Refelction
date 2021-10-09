### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection').[ExpandoObjectExtensions](Jcd_Reflection_ExpandoObjectExtensions.md 'Jcd.Reflection.ExpandoObjectExtensions')
## ExpandoObjectExtensions.AppendObject&lt;TNode&gt;(object, HashSet&lt;object&gt;, Func&lt;string,string&gt;, Func&lt;string,object,bool&gt;, TNode) Method
```csharp
private static void AppendObject<TNode>(object self, System.Collections.Generic.HashSet<object> visited, System.Func<string,string> keyRenamingStrategy, System.Func<string,object,bool> valueRetentionStrategy, TNode root)
    where TNode : System.Collections.Generic.IDictionary<string, object>, new();
```
#### Type parameters
<a name='Jcd_Reflection_ExpandoObjectExtensions_AppendObject_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool__TNode)_TNode'></a>
`TNode`  
  
#### Parameters
<a name='Jcd_Reflection_ExpandoObjectExtensions_AppendObject_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool__TNode)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
  
<a name='Jcd_Reflection_ExpandoObjectExtensions_AppendObject_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool__TNode)_visited'></a>
`visited` [System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')  
  
<a name='Jcd_Reflection_ExpandoObjectExtensions_AppendObject_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool__TNode)_keyRenamingStrategy'></a>
`keyRenamingStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
  
<a name='Jcd_Reflection_ExpandoObjectExtensions_AppendObject_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool__TNode)_valueRetentionStrategy'></a>
`valueRetentionStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
  
<a name='Jcd_Reflection_ExpandoObjectExtensions_AppendObject_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool__TNode)_root'></a>
`root` [TNode](Jcd_Reflection_ExpandoObjectExtensions_AppendObject_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool__TNode).md#Jcd_Reflection_ExpandoObjectExtensions_AppendObject_TNode_(object_System_Collections_Generic_HashSet_object__System_Func_string_string__System_Func_string_object_bool__TNode)_TNode 'Jcd.Reflection.ExpandoObjectExtensions.AppendObject&lt;TNode&gt;(object, System.Collections.Generic.HashSet&lt;object&gt;, System.Func&lt;string,string&gt;, System.Func&lt;string,object,bool&gt;, TNode).TNode')  
  
