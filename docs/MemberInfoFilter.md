### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## MemberInfoFilter Struct

The settings controlling how to enumerate (e.g. what binding flags to use, special predicate for skipping?)

```csharp
public struct MemberInfoFilter
```

| Fields                                                                                                                                       |                                                                  |
|:---------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------|
| [AllInstanceMembersFilter](MemberInfoFilter.AllInstanceMembersFilter.md 'Jcd.Reflection.MemberInfoFilter.AllInstanceMembersFilter')          | Selects all public instance methods including inherited methods. |
| [AllStaticMembersFilter](MemberInfoFilter.AllStaticMembersFilter.md 'Jcd.Reflection.MemberInfoFilter.AllStaticMembersFilter')                | Selects all static methods including inherited static.           |
| [DirectInstanceMethodsFilter](MemberInfoFilter.DirectInstanceMethodsFilter.md 'Jcd.Reflection.MemberInfoFilter.DirectInstanceMethodsFilter') | Selects all directly declared instance methods.                  |
| [DirectStaticMembersFilter](MemberInfoFilter.DirectStaticMembersFilter.md 'Jcd.Reflection.MemberInfoFilter.DirectStaticMembersFilter')       | Selects all directly declared static methods.                    |

| Properties                                                                 |                                           |
|:---------------------------------------------------------------------------|:------------------------------------------|
| [Flags](MemberInfoFilter.Flags.md 'Jcd.Reflection.MemberInfoFilter.Flags') | The BindingFlags for the member lookup.   |
| [Skip](MemberInfoFilter.Skip.md 'Jcd.Reflection.MemberInfoFilter.Skip')    | A predicate for skipping certain members. |
