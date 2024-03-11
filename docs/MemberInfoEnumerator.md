### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## MemberInfoEnumerator Class

Enumerated MemberInfos for a given object or type.

```csharp
public class MemberInfoEnumerator :
System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MemberInfoEnumerator

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                  |                                                                  |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------|
| [MemberInfoEnumerator(object, MemberInfoFilter)](MemberInfoEnumerator..ctor.B1s+Sa36Nz5RqSrSTQy0mQ.md 'Jcd.Reflection.MemberInfoEnumerator.MemberInfoEnumerator(object, Jcd.Reflection.MemberInfoFilter)')    | Constructs a MemberInfoEnumerator from an instance and settings. |
| [MemberInfoEnumerator(Type, MemberInfoFilter)](MemberInfoEnumerator..ctor./buf3eLxDunMMRFvfX9/Ow.md 'Jcd.Reflection.MemberInfoEnumerator.MemberInfoEnumerator(System.Type, Jcd.Reflection.MemberInfoFilter)') | Constructs a MemberInfoEnumerator from a type and settings.      |

| Fields | |
| :--- | :--- |
| [SkipSystemAndNonDataMembers](MemberInfoEnumerator.SkipSystemAndNonDataMembers.md 'Jcd.Reflection.MemberInfoEnumerator.SkipSystemAndNonDataMembers') | Predefined skip predicate for skipping system members. |
| [SkipSystemMembers](MemberInfoEnumerator.SkipSystemMembers.md 'Jcd.Reflection.MemberInfoEnumerator.SkipSystemMembers') | Predefined skip predicate for skipping system members. |

| Properties                                                                            |                                                               |
|:--------------------------------------------------------------------------------------|:--------------------------------------------------------------|
| [Filter](MemberInfoEnumerator.Filter.md 'Jcd.Reflection.MemberInfoEnumerator.Filter') | Gets or sets the settings controlling member info enumeration |
| [Type](MemberInfoEnumerator.Type.md 'Jcd.Reflection.MemberInfoEnumerator.Type')       | The type whose members are enumerated.                        |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](MemberInfoEnumerator.GetEnumerator().md 'Jcd.Reflection.MemberInfoEnumerator.GetEnumerator()') | Gets the enumerator |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](MemberInfoEnumerator.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.Reflection.MemberInfoEnumerator.System.Collections.IEnumerable.GetEnumerator()') | Gets an enumerator |
