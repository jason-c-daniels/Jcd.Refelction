### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[ValueExtensions](ValueExtensions.md 'Jcd.Reflection.ValueExtensions')

## ValueExtensions.GetValue(this object, string, BindingFlags) Method

Gets a value from a named field or property

```csharp
public static object GetValue(this object self, string fieldOrPropertyName, System.Reflection.BindingFlags bindingFlags=System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.Public|System.Reflection.BindingFlags.NonPublic);
```
#### Parameters

<a name='Jcd.Reflection.ValueExtensions.GetValue(thisobject,string,System.Reflection.BindingFlags).self'></a>

`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

the instance to retrieve the vale from

<a name='Jcd.Reflection.ValueExtensions.GetValue(thisobject,string,System.Reflection.BindingFlags).fieldOrPropertyName'></a>

`fieldOrPropertyName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

the name of the item to get.

<a name='Jcd.Reflection.ValueExtensions.GetValue(thisobject,string,System.Reflection.BindingFlags).bindingFlags'></a>

`bindingFlags` [System.Reflection.BindingFlags](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.BindingFlags 'System.Reflection.BindingFlags')

The binding flags that help control property or field lookup

#### Returns

[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value