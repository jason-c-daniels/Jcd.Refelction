### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## FieldOrPropertyEnumerator Class

Enumerates both properties and fields on a given data type.

```csharp
public class FieldOrPropertyEnumerator :
System.Collections.Generic.IEnumerable<Jcd.Reflection.FieldOrPropertyInfo>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FieldOrPropertyEnumerator

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[FieldOrPropertyInfo](FieldOrPropertyInfo.md 'Jcd.Reflection.FieldOrPropertyInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors | |
| :--- | :--- |
| [FieldOrPropertyEnumerator(object, FieldOrPropertyInfoFilter)](FieldOrPropertyEnumerator..ctor.zDQuZsXqeQ7ezSfEXvoSPg.md 'Jcd.Reflection.FieldOrPropertyEnumerator.FieldOrPropertyEnumerator(object, Jcd.Reflection.FieldOrPropertyInfoFilter)') | Constructs a FieldOrPropertyEnumerator from an object instance and settings. |
| [FieldOrPropertyEnumerator(Type, FieldOrPropertyInfoFilter)](FieldOrPropertyEnumerator..ctor.r4F4sijpVUsOD0YGpglwGA.md 'Jcd.Reflection.FieldOrPropertyEnumerator.FieldOrPropertyEnumerator(System.Type, Jcd.Reflection.FieldOrPropertyInfoFilter)') | Constructs a FieldOrPropertyEnumerator from a type and settings. |

| Properties | |
| :--- | :--- |
| [Filter](FieldOrPropertyEnumerator.Filter.md 'Jcd.Reflection.FieldOrPropertyEnumerator.Filter') | Gets or sets the settings that control enumeration. |
| [Type](FieldOrPropertyEnumerator.Type.md 'Jcd.Reflection.FieldOrPropertyEnumerator.Type') | The data type being reflected on. |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](FieldOrPropertyEnumerator.GetEnumerator().md 'Jcd.Reflection.FieldOrPropertyEnumerator.GetEnumerator()') | Enumerates the FieldOrPropertyInfo entries for the given type. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](FieldOrPropertyEnumerator.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.Reflection.FieldOrPropertyEnumerator.System.Collections.IEnumerable.GetEnumerator()') | Enumerates the FieldOrPropertyInfo entries for the given type. |
