### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[ExpandoObjectExtensions](Jcd.Reflection.ExpandoObjectExtensions.md 'Jcd.Reflection.ExpandoObjectExtensions')

## ExpandoObjectExtensions.ToDictionaryTree<TNode>(this object, HashSet<object>, Func<string,string>, Func<string,object,bool>) Method

```csharp
private static dynamic ToDictionaryTree<TNode>(this object self, System.Collections.Generic.HashSet<object> visited=null, System.Func<string,string> keyRenamingStrategy=null, System.Func<string,object,bool> valueRetentionStrategy=null)
    where TNode : System.Collections.Generic.IDictionary<string, object>, new();
```
#### Type parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.ToDictionaryTree_TNode_(thisobject,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).TNode'></a>

`TNode`
#### Parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.ToDictionaryTree_TNode_(thisobject,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='Jcd.Reflection.ExpandoObjectExtensions.ToDictionaryTree_TNode_(thisobject,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).visited'></a>

`visited` [System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')

<a name='Jcd.Reflection.ExpandoObjectExtensions.ToDictionaryTree_TNode_(thisobject,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).keyRenamingStrategy'></a>

`keyRenamingStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='Jcd.Reflection.ExpandoObjectExtensions.ToDictionaryTree_TNode_(thisobject,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_).valueRetentionStrategy'></a>

`valueRetentionStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

#### Returns
[dynamic](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic 'https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic')