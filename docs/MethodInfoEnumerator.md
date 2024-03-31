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

| Constructors                                                                                                                                                                                                  |                                                                  |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------|
| [MethodInfoEnumerator(object, MethodInfoFilter)](MethodInfoEnumerator..ctor.M5/ctS63XqcySAx2JX+QIg.md 'Jcd.Reflection.MethodInfoEnumerator.MethodInfoEnumerator(object, Jcd.Reflection.MethodInfoFilter)')    | Constructs a MethodInfoEnumerator from an instance and settings. |
| [MethodInfoEnumerator(Type, MethodInfoFilter)](MethodInfoEnumerator..ctor.DMF5wNE6xMdrUQzWV2h+eQ.md 'Jcd.Reflection.MethodInfoEnumerator.MethodInfoEnumerator(System.Type, Jcd.Reflection.MethodInfoFilter)') | Constructs a MethodInfoEnumerator from a type and settings.      |

| Properties                                                                            |                                                               |
|:--------------------------------------------------------------------------------------|:--------------------------------------------------------------|
| [Filter](MethodInfoEnumerator.Filter.md 'Jcd.Reflection.MethodInfoEnumerator.Filter') | Gets or sets the settings controlling method info enumeration |
| [Type](MethodInfoEnumerator.Type.md 'Jcd.Reflection.MethodInfoEnumerator.Type')       | The type whose methods are enumerated.                        |

| Methods                                                                                                          |                                                   |
|:-----------------------------------------------------------------------------------------------------------------|:--------------------------------------------------|
| [GetEnumerator()](MethodInfoEnumerator.GetEnumerator().md 'Jcd.Reflection.MethodInfoEnumerator.GetEnumerator()') | Gets an enumerator for the MethodInfos enumerated |

| Explicit Interface Implementations                                                                                                                                                                            |                                                   |
|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------|
| [System.Collections.IEnumerable.GetEnumerator()](MethodInfoEnumerator.System.Collections.IEnumerable.GetEnumerator().md 'Jcd.Reflection.MethodInfoEnumerator.System.Collections.IEnumerable.GetEnumerator()') | Gets an enumerator for the MethodInfos enumerated |
