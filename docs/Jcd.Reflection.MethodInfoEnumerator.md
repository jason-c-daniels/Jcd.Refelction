### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## MethodInfoEnumerator Class

Enumerates the method information for a given type.

```csharp
public class MethodInfoEnumerator :
System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>,
System.Collections.IEnumerable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106;
MethodInfoEnumerator

Implements [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'), [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')

| Constructors                                                                                                                                                                                                                                                                        |                                                                  |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------|
| [MethodInfoEnumerator(object, Settings)](Jcd.Reflection.MethodInfoEnumerator.MethodInfoEnumerator(object,Jcd.Reflection.MethodInfoEnumerator.Settings).md 'Jcd.Reflection.MethodInfoEnumerator.MethodInfoEnumerator(object, Jcd.Reflection.MethodInfoEnumerator.Settings)')         | Constructs a MethodInfoEnumerator from an instance and settings. |
| [MethodInfoEnumerator(Type, Settings)](Jcd.Reflection.MethodInfoEnumerator.MethodInfoEnumerator(System.Type,Jcd.Reflection.MethodInfoEnumerator.Settings).md 'Jcd.Reflection.MethodInfoEnumerator.MethodInfoEnumerator(System.Type, Jcd.Reflection.MethodInfoEnumerator.Settings)') | Constructs a MethodInfoEnumerator from a type and settings.      |

| Properties                                                                                                                                  |                                                               |
|:--------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------|
| [EnumerationSettings](Jcd.Reflection.MethodInfoEnumerator.EnumerationSettings.md 'Jcd.Reflection.MethodInfoEnumerator.EnumerationSettings') | Gets or sets the settings controlling method info enumeration |
| [Type](Jcd.Reflection.MethodInfoEnumerator.Type.md 'Jcd.Reflection.MethodInfoEnumerator.Type')                                              | The type whose methods are enumerated.                        |

| Methods                                                                                                                         |                                                   |
|:--------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------|
| [GetEnumerator()](Jcd.Reflection.MethodInfoEnumerator.GetEnumerator().md 'Jcd.Reflection.MethodInfoEnumerator.GetEnumerator()') | Gets an enumerator for the MethodInfos enumerated |

| Explicit Interface Implementations                                                                                                                                                                                           |                                                   |
|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------|
| [System.Collections.IEnumerable.GetEnumerator()](Jcd.Reflection.MethodInfoEnumerator.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.Reflection.MethodInfoEnumerator.System.Collections.IEnumerable.GetEnumerator()') | Gets an enumerator for the MethodInfos enumerated |
