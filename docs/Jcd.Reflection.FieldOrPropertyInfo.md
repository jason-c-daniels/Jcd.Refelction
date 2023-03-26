### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## FieldOrPropertyInfo Class

Discovers the attributes of a field or property and provides access to the metadata.

```csharp
public class FieldOrPropertyInfo : System.Reflection.MemberInfo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
&#129106; [System.Reflection.MemberInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MemberInfo 'System.Reflection.MemberInfo')
&#129106; FieldOrPropertyInfo

| Constructors                                                                                                                                                                                                                                                                                   |                                 |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------|
| [FieldOrPropertyInfo(MemberInfo, BindingFlags)](Jcd.Reflection.FieldOrPropertyInfo.FieldOrPropertyInfo(System.Reflection.MemberInfo,System.Reflection.BindingFlags).md 'Jcd.Reflection.FieldOrPropertyInfo.FieldOrPropertyInfo(System.Reflection.MemberInfo, System.Reflection.BindingFlags)') | A dual purpose MemberInfo type. |

| Properties                                                                                                              |                                         |
|:------------------------------------------------------------------------------------------------------------------------|:----------------------------------------|
| [DeclaringType](Jcd.Reflection.FieldOrPropertyInfo.DeclaringType.md 'Jcd.Reflection.FieldOrPropertyInfo.DeclaringType') | Gets the type that declares the member. |
| [MemberType](Jcd.Reflection.FieldOrPropertyInfo.MemberType.md 'Jcd.Reflection.FieldOrPropertyInfo.MemberType')          | Gets the type of the member             |
| [Name](Jcd.Reflection.FieldOrPropertyInfo.Name.md 'Jcd.Reflection.FieldOrPropertyInfo.Name')                            | Gets the name of the member             |
| [ReflectedType](Jcd.Reflection.FieldOrPropertyInfo.ReflectedType.md 'Jcd.Reflection.FieldOrPropertyInfo.ReflectedType') | gets the reflected type of the member.  |

| Methods                                                                                                                                                                                    |                                                                                      |
|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-------------------------------------------------------------------------------------|
| [GetCustomAttributes(bool)](Jcd.Reflection.FieldOrPropertyInfo.GetCustomAttributes(bool).md 'Jcd.Reflection.FieldOrPropertyInfo.GetCustomAttributes(bool)')                                | Gets custom attributes for the member.                                               |
| [GetCustomAttributes(Type, bool)](Jcd.Reflection.FieldOrPropertyInfo.GetCustomAttributes(System.Type,bool).md 'Jcd.Reflection.FieldOrPropertyInfo.GetCustomAttributes(System.Type, bool)') | Gets custom attributes of a specified type for a member.                             |
| [GetValue(object, bool)](Jcd.Reflection.FieldOrPropertyInfo.GetValue(object,bool).md 'Jcd.Reflection.FieldOrPropertyInfo.GetValue(object, bool)')                                          | Gets a value from an object, and indicates if an error occurred during that process. |
| [GetValue(object)](Jcd.Reflection.FieldOrPropertyInfo.GetValue(object).md 'Jcd.Reflection.FieldOrPropertyInfo.GetValue(object)')                                                           | Gets the value from the object.                                                      |
| [IsDefined(Type, bool)](Jcd.Reflection.FieldOrPropertyInfo.IsDefined(System.Type,bool).md 'Jcd.Reflection.FieldOrPropertyInfo.IsDefined(System.Type, bool)')                               | Checks if a custom attribute of the specified type exists for the member.            |
| [SetValue(object, object, bool)](Jcd.Reflection.FieldOrPropertyInfo.SetValue(object,object,bool).md 'Jcd.Reflection.FieldOrPropertyInfo.SetValue(object, object, bool)')                   | Sets a value on an object.                                                           |
| [SetValue(object, object)](Jcd.Reflection.FieldOrPropertyInfo.SetValue(object,object).md 'Jcd.Reflection.FieldOrPropertyInfo.SetValue(object, object)')                                    | Sets a value on an object.                                                           |
