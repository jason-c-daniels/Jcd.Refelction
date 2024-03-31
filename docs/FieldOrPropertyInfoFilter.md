### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## FieldOrPropertyInfoFilter Class

The settings indicating "how" to enumerate. (i.e. BindingFlags and a predicate for skipping members)

```csharp
public class FieldOrPropertyInfoFilter
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FieldOrPropertyInfoFilter

| Fields | |
| :--- | :--- |
| [AllInstanceMethodsFilter](FieldOrPropertyInfoFilter.AllInstanceMethodsFilter.md 'Jcd.Reflection.FieldOrPropertyInfoFilter.AllInstanceMethodsFilter') | Selects all public instance methods including inherited methods. |
| [AllStaticMethodsFilter](FieldOrPropertyInfoFilter.AllStaticMethodsFilter.md 'Jcd.Reflection.FieldOrPropertyInfoFilter.AllStaticMethodsFilter') | Selects all static methods including inherited static. |
| [DirectInstanceMethodsFilter](FieldOrPropertyInfoFilter.DirectInstanceMethodsFilter.md 'Jcd.Reflection.FieldOrPropertyInfoFilter.DirectInstanceMethodsFilter') | Selects all directly declared instance methods. |
| [DirectStaticMethodsFilter](FieldOrPropertyInfoFilter.DirectStaticMethodsFilter.md 'Jcd.Reflection.FieldOrPropertyInfoFilter.DirectStaticMethodsFilter') | Selects all directly declared static methods. |

| Properties | |
| :--- | :--- |
| [Flags](FieldOrPropertyInfoFilter.Flags.md 'Jcd.Reflection.FieldOrPropertyInfoFilter.Flags') | The BindingFlags for the member lookup. |
| [Skip](FieldOrPropertyInfoFilter.Skip.md 'Jcd.Reflection.FieldOrPropertyInfoFilter.Skip') | A predicate for skipping certain members. |
