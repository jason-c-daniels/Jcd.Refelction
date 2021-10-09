### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection')
## MemberInfoEnumerator Class
Enumerated MemberInfos for a given object or type.  
```csharp
public class MemberInfoEnumerator :
System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MemberInfoEnumerator  

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Constructors | |
| :--- | :--- |
| [MemberInfoEnumerator(object, Settings)](Jcd_Reflection_MemberInfoEnumerator_MemberInfoEnumerator(object_Jcd_Reflection_MemberInfoEnumerator_Settings).md 'Jcd.Reflection.MemberInfoEnumerator.MemberInfoEnumerator(object, Jcd.Reflection.MemberInfoEnumerator.Settings)') | Constructs a MemberInfoEnumerator from an instance and settings.<br/> |
| [MemberInfoEnumerator(Type, Settings)](Jcd_Reflection_MemberInfoEnumerator_MemberInfoEnumerator(System_Type_Jcd_Reflection_MemberInfoEnumerator_Settings).md 'Jcd.Reflection.MemberInfoEnumerator.MemberInfoEnumerator(System.Type, Jcd.Reflection.MemberInfoEnumerator.Settings)') | Constructs a MemberInfoEnumerator from a type and settings.<br/> |

| Fields | |
| :--- | :--- |
| [SkipSystemAndNonDataMembers](Jcd_Reflection_MemberInfoEnumerator_SkipSystemAndNonDataMembers.md 'Jcd.Reflection.MemberInfoEnumerator.SkipSystemAndNonDataMembers') | Predefined skip predicate for skipping system members.  <br/> |
| [SkipSystemMembers](Jcd_Reflection_MemberInfoEnumerator_SkipSystemMembers.md 'Jcd.Reflection.MemberInfoEnumerator.SkipSystemMembers') | Predefined skip predicate for skipping system members.  <br/> |

| Properties | |
| :--- | :--- |
| [EnumerationSettings](Jcd_Reflection_MemberInfoEnumerator_EnumerationSettings.md 'Jcd.Reflection.MemberInfoEnumerator.EnumerationSettings') | Gets or sets the settings controlling member info enumeration<br/> |
| [Type](Jcd_Reflection_MemberInfoEnumerator_Type.md 'Jcd.Reflection.MemberInfoEnumerator.Type') | The type whose members are enumerated.<br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_Reflection_MemberInfoEnumerator_GetEnumerator().md 'Jcd.Reflection.MemberInfoEnumerator.GetEnumerator()') | Gets the enumerator <br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_Reflection_MemberInfoEnumerator_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.Reflection.MemberInfoEnumerator.System.Collections.IEnumerable.GetEnumerator()') | Gets an enumerator<br/> |
