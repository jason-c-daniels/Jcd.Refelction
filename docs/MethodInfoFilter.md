### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## MethodInfoFilter Struct

The settings controlling how to enumerate (e.g. what binding flags to use, special predicate for skipping?)

```csharp
public struct MethodInfoFilter
```

| Fields | |
| :--- | :--- |
| [AllInstanceMethodsFilter](MethodInfoFilter.AllInstanceMethodsFilter.md 'Jcd.Reflection.MethodInfoFilter.AllInstanceMethodsFilter') | Selects all public instance methods including inherited methods. |
| [AllStaticMethodsFilter](MethodInfoFilter.AllStaticMethodsFilter.md 'Jcd.Reflection.MethodInfoFilter.AllStaticMethodsFilter') | Selects all static methods including inherited static. |
| [DirectInstanceMethodsFilter](MethodInfoFilter.DirectInstanceMethodsFilter.md 'Jcd.Reflection.MethodInfoFilter.DirectInstanceMethodsFilter') | Selects all directly declared instance methods. |
| [DirectStaticMethodsFilter](MethodInfoFilter.DirectStaticMethodsFilter.md 'Jcd.Reflection.MethodInfoFilter.DirectStaticMethodsFilter') | Selects all directly declared static methods. |

| Properties | |
| :--- | :--- |
| [Flags](MethodInfoFilter.Flags.md 'Jcd.Reflection.MethodInfoFilter.Flags') | The BindingFlags for the member lookup. |
| [Skip](MethodInfoFilter.Skip.md 'Jcd.Reflection.MethodInfoFilter.Skip') | A predicate for skipping certain members. |
