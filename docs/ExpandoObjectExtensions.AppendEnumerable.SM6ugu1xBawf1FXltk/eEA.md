### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[ExpandoObjectExtensions](ExpandoObjectExtensions.md 'Jcd.Reflection.ExpandoObjectExtensions')

## ExpandoObjectExtensions.AppendEnumerable<TNode>(HashSet<object>, Func<string,string>, Func<string,object,bool>, IEnumerable, TNode, dynamic) Method

```csharp
private static bool AppendEnumerable<TNode>(System.Collections.Generic.HashSet<object> visited, System.Func<string,string> keyRenamingStrategy, System.Func<string,object,bool> valueRetentionStrategy, System.Collections.IEnumerable enumerable, TNode root, out dynamic array)
    where TNode : System.Collections.Generic.IDictionary<string, object>, new();
```

#### Type parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IEnumerable,TNode,dynamic).TNode'></a>

`TNode`

#### Parameters

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IEnumerable,TNode,dynamic).visited'></a>

`visited` [System.Collections.Generic.HashSet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1 'System.Collections.Generic.HashSet`1')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IEnumerable,TNode,dynamic).keyRenamingStrategy'></a>

`keyRenamingStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IEnumerable,TNode,dynamic).valueRetentionStrategy'></a>

`valueRetentionStrategy` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IEnumerable,TNode,dynamic).enumerable'></a>

`enumerable` [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IEnumerable,TNode,dynamic).root'></a>

`root` [TNode](ExpandoObjectExtensions.AppendEnumerable.SM6ugu1xBawf1FXltk/eEA.md#Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IEnumerable,TNode,dynamic).TNode 'Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable<TNode>(System.Collections.Generic.HashSet<object>, System.Func<string,string>, System.Func<string,object,bool>, System.Collections.IEnumerable, TNode, dynamic).TNode')

<a name='Jcd.Reflection.ExpandoObjectExtensions.AppendEnumerable_TNode_(System.Collections.Generic.HashSet_object_,System.Func_string,string_,System.Func_string,object,bool_,System.Collections.IEnumerable,TNode,dynamic).array'></a>

`array` [dynamic](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic 'https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic')

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')