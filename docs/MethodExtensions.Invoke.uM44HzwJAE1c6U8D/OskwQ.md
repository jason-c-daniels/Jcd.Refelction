### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.Invoke<TOut>(this object, string, object[]) Method

Invoke the method on the specified object using the provided parameters

```csharp
public static TOut Invoke<TOut>(this object self, string name, params object[] @params);
```
#### Type parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisobject,string,object[]).TOut'></a>

`TOut`

result type
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisobject,string,object[]).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance to invoke the method on

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisobject,string,object[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the name of the method to invoke

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisobject,string,object[]).params'></a>

`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the params for the method

#### Returns
[TOut](MethodExtensions.Invoke.uM44HzwJAE1c6U8D/OskwQ.md#Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisobject,string,object[]).TOut 'Jcd.Reflection.MethodExtensions.Invoke<TOut>(this object, string, object[]).TOut')
the result, if any