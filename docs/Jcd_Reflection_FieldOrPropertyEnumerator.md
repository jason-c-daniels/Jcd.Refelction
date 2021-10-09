### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection')
## FieldOrPropertyEnumerator Class
Enumerates both properties and fields on a given data type.  
```csharp
public class FieldOrPropertyEnumerator :
System.Collections.Generic.IEnumerable<Jcd.Reflection.FieldOrPropertyInfo>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FieldOrPropertyEnumerator  

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[FieldOrPropertyInfo](Jcd_Reflection_FieldOrPropertyInfo.md 'Jcd.Reflection.FieldOrPropertyInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  

| Constructors | |
| :--- | :--- |
| [FieldOrPropertyEnumerator(object, Settings)](Jcd_Reflection_FieldOrPropertyEnumerator_FieldOrPropertyEnumerator(object_Jcd_Reflection_FieldOrPropertyEnumerator_Settings).md 'Jcd.Reflection.FieldOrPropertyEnumerator.FieldOrPropertyEnumerator(object, Jcd.Reflection.FieldOrPropertyEnumerator.Settings)') | Constructs a FieldOrPropertyEnumerator from an object instance and settings.<br/> |
| [FieldOrPropertyEnumerator(Type, Settings)](Jcd_Reflection_FieldOrPropertyEnumerator_FieldOrPropertyEnumerator(System_Type_Jcd_Reflection_FieldOrPropertyEnumerator_Settings).md 'Jcd.Reflection.FieldOrPropertyEnumerator.FieldOrPropertyEnumerator(System.Type, Jcd.Reflection.FieldOrPropertyEnumerator.Settings)') | Constructs a FieldOrPropertyEnumerator from a type and settings.<br/> |

| Properties | |
| :--- | :--- |
| [EnumerationSettings](Jcd_Reflection_FieldOrPropertyEnumerator_EnumerationSettings.md 'Jcd.Reflection.FieldOrPropertyEnumerator.EnumerationSettings') | Gets or sets the settings that control enumeration. <br/> |
| [Type](Jcd_Reflection_FieldOrPropertyEnumerator_Type.md 'Jcd.Reflection.FieldOrPropertyEnumerator.Type') | The data type being reflected on. <br/> |

| Methods | |
| :--- | :--- |
| [GetEnumerator()](Jcd_Reflection_FieldOrPropertyEnumerator_GetEnumerator().md 'Jcd.Reflection.FieldOrPropertyEnumerator.GetEnumerator()') | Enumerates the FieldOrPropertyInfo entries for the given type.<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [System.Collections.IEnumerable.GetEnumerator()](Jcd_Reflection_FieldOrPropertyEnumerator_System_Collections_IEnumerable_GetEnumerator().md 'Jcd.Reflection.FieldOrPropertyEnumerator.System.Collections.IEnumerable.GetEnumerator()') | Enumerates the FieldOrPropertyInfo entries for the given type.<br/> |
