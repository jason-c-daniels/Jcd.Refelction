### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[ValueExtensions](ValueExtensions.md 'Jcd.Reflection.ValueExtensions')

## ValueExtensions.SetValue<T>(this T, string, object, BindingFlags) Method

Sets a value on a field or property.

```csharp
public static void SetValue<T>(this ref T self, string fieldOrPropertyName, object value, System.Reflection.BindingFlags bindingFlags=System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Jcd.Reflection.ValueExtensions.SetValue_T_(thisT,string,object,System.Reflection.BindingFlags).T'></a>

`T`

The type of data being modified.
#### Parameters

<a name='Jcd.Reflection.ValueExtensions.SetValue_T_(thisT,string,object,System.Reflection.BindingFlags).self'></a>

`self` [T](ValueExtensions.SetValue.2UgzmbCmD0mpsNyQDm+lww.md#Jcd.Reflection.ValueExtensions.SetValue_T_(thisT,string,object,System.Reflection.BindingFlags).T 'Jcd.Reflection.ValueExtensions.SetValue<T>(this T, string, object, System.Reflection.BindingFlags).T')

The instance to set the value on

<a name='Jcd.Reflection.ValueExtensions.SetValue_T_(thisT,string,object,System.Reflection.BindingFlags).fieldOrPropertyName'></a>

`fieldOrPropertyName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the name of the field or property to set

<a name='Jcd.Reflection.ValueExtensions.SetValue_T_(thisT,string,object,System.Reflection.BindingFlags).value'></a>

`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The value to set.

<a name='Jcd.Reflection.ValueExtensions.SetValue_T_(thisT,string,object,System.Reflection.BindingFlags).bindingFlags'></a>

`bindingFlags` [System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')

The binding flags that help control property or field lookup