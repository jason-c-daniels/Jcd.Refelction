### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.Invoke<TOut>(this Type, string, MethodInfoFilter, object[]) Method

Invokes a static method on a type, coercing the return type

```csharp
public static TOut Invoke<TOut>(this System.Type type, string name, Jcd.Reflection.MethodInfoFilter settings, params object[] @params);
```

#### Type parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).TOut'></a>

`TOut`

The type of the return

#### Parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type containing the static method

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the method

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).settings'></a>

`settings` [MethodInfoFilter](MethodInfoFilter.md 'Jcd.Reflection.MethodInfoFilter')

The method selection settings such
as [AllStaticMethodsFilter](MethodInfoFilter.AllStaticMethodsFilter.md 'Jcd.Reflection.MethodInfoFilter.AllStaticMethodsFilter')

<a name='Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).params'></a>

`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The params to pass

#### Returns

[TOut](MethodExtensions.Invoke.b88hdjbdjdZT0aKfYJWsjg.md#Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,Jcd.Reflection.MethodInfoFilter,object[]).TOut 'Jcd.Reflection.MethodExtensions.Invoke<TOut>(this System.Type, string, Jcd.Reflection.MethodInfoFilter, object[]).TOut')
The result of the call, if any