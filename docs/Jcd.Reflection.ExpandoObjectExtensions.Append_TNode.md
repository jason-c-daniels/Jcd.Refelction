### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[ExpandoObjectExtensions](Jcd.Reflection.ExpandoObjectExtensions.md 'Jcd.Reflection.ExpandoObjectExtensions')

## ExpandoObjectExtensions.Append<TNode>(this IDictionary<string,object>, string, object, HashSet<object>, Func<string,string>, Func<string,object,bool>) Method

```csharp
private static void Append<TNode>(this System.Collections.Generic.IDictionary<string,object> dictionary, string key, object val, System.Collections.Generic.HashSet<object> visited, System.Func<string,string> keyRenamingStrategy, System.Func<string,object,bool> valueRetentionStrategy)
    where TNode : System.Collections.Generic.IDictionary<string, object>, new();
```
#### Type parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.Append_TNode_(thisSystem.Collections.Generic.IDictionary_string,object_,string,object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).TNode'></a>

`TNode`
#### Parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.Append_TNode_(thisSystem.Collections.Generic.IDictionary_string,object_,string,object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).dictionary'></a>

`dictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

<a name='Jcd.Reflection.ExpandoObjectExtensions.Append_TNode_(thisSystem.Collections.Generic.IDictionary_string,object_,string,object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Jcd.Reflection.ExpandoObjectExtensions.Append_TNode_(thisSystem.Collections.Generic.IDictionary_string,object_,string,object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).val'></a>

`val` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='Jcd.Reflection.ExpandoObjectExtensions.Append_TNode_(thisSystem.Collections.Generic.IDictionary_string,object_,string,object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).visited'></a>

`visited` [System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')

<a name='Jcd.Reflection.ExpandoObjectExtensions.Append_TNode_(thisSystem.Collections.Generic.IDictionary_string,object_,string,object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).keyRenamingStrategy'></a>

`keyRenamingStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='Jcd.Reflection.ExpandoObjectExtensions.Append_TNode_(thisSystem.Collections.Generic.IDictionary_string,object_,string,object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).valueRetentionStrategy'></a>

`valueRetentionStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')