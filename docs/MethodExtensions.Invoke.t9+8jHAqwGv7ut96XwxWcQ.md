### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[MethodExtensions](MethodExtensions.md 'Jcd.Reflection.MethodExtensions')

## MethodExtensions.Invoke(this object, MethodInfo, object[]) Method

Invoke the method on the specified object using the provided parameters

```csharp
public static object Invoke(this object self, System.Reflection.MethodInfo methodInfo, params object[] @params);
```

#### Parameters

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,System.Reflection.MethodInfo,object[]).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The instance to invoke the method on

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,System.Reflection.MethodInfo,object[]).methodInfo'></a>

`methodInfo` [System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')

the method to invoke

<a name='Jcd.Reflection.MethodExtensions.Invoke(thisobject,System.Reflection.MethodInfo,object[]).params'></a>

`params` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the params for the method

#### Returns

[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
the result, if any