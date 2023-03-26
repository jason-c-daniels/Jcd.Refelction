### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## PropertyInfoExtensions Class

A set of reflection extensions to aid in manipulating properties.

```csharp
public static class PropertyInfoExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106;
PropertyInfoExtensions

| Fields                                                                                                                                             |                                                                       |
|:---------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------------------|
| [DefaultSkip](Jcd.Reflection.PropertyInfoExtensions.DefaultSkip.md 'Jcd.Reflection.PropertyInfoExtensions.DefaultSkip')                            | Predefined skip predicate for skipping write only and system members. |
| [SkipNonReadWrite](Jcd.Reflection.PropertyInfoExtensions.SkipNonReadWrite.md 'Jcd.Reflection.PropertyInfoExtensions.SkipNonReadWrite')             | Predefined skip predicate for skipping read only members.             |
| [SkipReadOnlyMembers](Jcd.Reflection.PropertyInfoExtensions.SkipReadOnlyMembers.md 'Jcd.Reflection.PropertyInfoExtensions.SkipReadOnlyMembers')    | Predefined skip predicate for skipping read only members.             |
| [SkipSystemMembers](Jcd.Reflection.PropertyInfoExtensions.SkipSystemMembers.md 'Jcd.Reflection.PropertyInfoExtensions.SkipSystemMembers')          | Predefined skip predicate for skipping system members.                |
| [SkipWriteOnlyMembers](Jcd.Reflection.PropertyInfoExtensions.SkipWriteOnlyMembers.md 'Jcd.Reflection.PropertyInfoExtensions.SkipWriteOnlyMembers') | Predefined skip predicate for skipping write only members.            |

| Methods                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |                                                     |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------|
| [EnumerateProperties(this object, Nullable&lt;BindingFlags&gt;, Func&lt;PropertyInfo,bool&gt;)](Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisobject,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_).md 'Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(this object, System.Nullable<System.Reflection.BindingFlags>, System.Func<System.Reflection.PropertyInfo,bool>)')                                           | Enumerate the PropertyInfo entries for a given type |
| [EnumerateProperties(this Type, Nullable&lt;BindingFlags&gt;, Func&lt;PropertyInfo,bool&gt;, bool, bool)](Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(thisSystem.Type,System.Nullable_System.Reflection.BindingFlags_,System.Func_System.Reflection.PropertyInfo,bool_,bool,bool).md 'Jcd.Reflection.PropertyInfoExtensions.EnumerateProperties(this System.Type, System.Nullable<System.Reflection.BindingFlags>, System.Func<System.Reflection.PropertyInfo,bool>, bool, bool)') | Enumerate the PropertyInfo entries for a given type |
