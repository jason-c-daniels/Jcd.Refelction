### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[ExpandoObjectExtensions](Jcd.Reflection.ExpandoObjectExtensions.md 'Jcd.Reflection.ExpandoObjectExtensions')

## ExpandoObjectExtensions.AppendObject<TNode>(object, HashSet<object>, Func<string,string>, Func<string,object,bool>, TNode) Method

```csharp
private static void AppendObject<TNode>(object self, System.Collections.Generic.HashSet<object> visited, System.Func<string,string> keyRenamingStrategy, System.Func<string,object,bool> valueRetentionStrategy, TNode root)
    where TNode : System.Collections.Generic.IDictionary<string, object>, new();
```
#### Type parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendObject_TNode_(object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,TNode).TNode'></a>

`TNode`
#### Parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendObject_TNode_(object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,TNode).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendObject_TNode_(object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,TNode).visited'></a>

`visited` [System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendObject_TNode_(object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,TNode).keyRenamingStrategy'></a>

`keyRenamingStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendObject_TNode_(object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,TNode).valueRetentionStrategy'></a>

`valueRetentionStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendObject_TNode_(object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,TNode).root'></a>

`root` [TNode](Jcd.Reflection.ExpandoObjectExtensions.AppendObject_TNode_(object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,TNode).md#Jcd.Reflection.ExpandoObjectExtensions.AppendObject_TNode_(object,System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,TNode).TNode 'Jcd.Reflection.ExpandoObjectExtensions.AppendObject<TNode>(object, System.Collections.Generic.HashSet<object>, System.Func<string,string>, System.Func<string,object,bool>, TNode).TNode')