### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## MemberInfoFilter Struct

The settings controlling how to enumerate (e.g. what binding flags to use, special predicate for skipping?)

```csharp
public struct MemberInfoFilter
```

| Fields                                                                                                                                       |                                                                  |
|:---------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------|
| [AllInstanceMethodsFilter](MemberInfoFilter.AllInstanceMethodsFilter.md 'Jcd.Reflection.MemberInfoFilter.AllInstanceMethodsFilter')          | Selects all public instance methods including inherited methods. |
| [AllStaticMethodsFilter](MemberInfoFilter.AllStaticMethodsFilter.md 'Jcd.Reflection.MemberInfoFilter.AllStaticMethodsFilter')                | Selects all static methods including inherited static.           |
| [DirectInstanceMethodsFilter](MemberInfoFilter.DirectInstanceMethodsFilter.md 'Jcd.Reflection.MemberInfoFilter.DirectInstanceMethodsFilter') | Selects all directly declared instance methods.                  |
| [DirectStaticMethodsFilter](MemberInfoFilter.DirectStaticMethodsFilter.md 'Jcd.Reflection.MemberInfoFilter.DirectStaticMethodsFilter')       | Selects all directly declared static methods.                    |

| Properties                                                                 |                                           |
|:---------------------------------------------------------------------------|:------------------------------------------|
| [Flags](MemberInfoFilter.Flags.md 'Jcd.Reflection.MemberInfoFilter.Flags') | The BindingFlags for the member lookup.   |
| [Skip](MemberInfoFilter.Skip.md 'Jcd.Reflection.MemberInfoFilter.Skip')    | A predicate for skipping certain members. |
