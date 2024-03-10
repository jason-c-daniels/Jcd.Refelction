### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[ExpandoObjectExtensions](ExpandoObjectExtensions.md 'Jcd.Reflection.ExpandoObjectExtensions')

## ExpandoObjectExtensions.AppendDictionary<TNode>(HashSet<object>, Func<string,string>, Func<string,object,bool>, IDictionary, TNode) Method

```csharp
private static void AppendDictionary<TNode>(System.Collections.Generic.HashSet<object> visited, System.Func<string,string> keyRenamingStrategy, System.Func<string,object,bool> valueRetentionStrategy, System.Collections.IDictionary dictionary1, TNode root)
    where TNode : System.Collections.Generic.IDictionary<string, object>, new();
```
#### Type parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendDictionary_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IDictionary,TNode).TNode'></a>

`TNode`
#### Parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendDictionary_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IDictionary,TNode).visited'></a>

`visited` [System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendDictionary_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IDictionary,TNode).keyRenamingStrategy'></a>

`keyRenamingStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendDictionary_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IDictionary,TNode).valueRetentionStrategy'></a>

`valueRetentionStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendDictionary_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IDictionary,TNode).dictionary1'></a>

`dictionary1` [System.Collections.IDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IDictionary 'System.Collections.IDictionary')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendDictionary_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IDictionary,TNode).root'></a>

`root` [TNode](ExpandoObjectExtensions.AppendDictionary.TPf7htPdDAwR0dy7Mcv5cA.md#Jcd.Reflection.ExpandoObjectExtensions.AppendDictionary_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IDictionary,TNode).TNode 'Jcd.Reflection.ExpandoObjectExtensions.AppendDictionary<TNode>(System.Collections.Generic.HashSet<object>, System.Func<string,string>, System.Func<string,object,bool>, System.Collections.IDictionary, TNode).TNode')