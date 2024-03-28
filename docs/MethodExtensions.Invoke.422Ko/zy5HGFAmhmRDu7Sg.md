### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.Invoke<TOut>(this Type, string, object[]) Method

Invokes a static method on a type, coercing the return type

```csharp
public static TOut Invoke<TOut>(this System.Type type, string name, params object[] @params);
```
#### Type parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,object[]).TOut'></a>

`TOut`

The type of the return
#### Parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,object[]).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type containing the static method

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,object[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the method

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,object[]).params'></a>

`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The params to pass

#### Returns
[TOut](MethodExtensions.Invoke.422Ko/zy5HGFAmhmRDu7Sg.md#Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,object[]).TOut 'Jcd.Reflection.MethodExtensions.Invoke<TOut>(this System.Type, string, object[]).TOut')
The result of the call, if any