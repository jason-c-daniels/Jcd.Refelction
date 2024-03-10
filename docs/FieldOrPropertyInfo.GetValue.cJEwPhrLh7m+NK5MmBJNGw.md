### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[FieldOrPropertyInfo](FieldOrPropertyInfo.md 'Jcd.Reflection.FieldOrPropertyInfo')

## FieldOrPropertyInfo.GetValue(object, bool) Method

Gets a value from an object, and indicates if an error occurred during that process.

```csharp
public object GetValue(object obj, out bool errored);
```
#### Parameters

<a name='Jcd.Reflection.FieldOrPropertyInfo.GetValue(object,bool).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

the object to get the value from

<a name='Jcd.Reflection.FieldOrPropertyInfo.GetValue(object,bool).errored'></a>

`errored` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true if an exception occurred during the get.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The value retrieved