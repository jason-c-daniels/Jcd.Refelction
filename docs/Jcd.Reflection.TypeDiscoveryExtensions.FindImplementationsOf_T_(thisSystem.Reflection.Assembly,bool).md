### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[TypeDiscoveryExtensions](Jcd.Reflection.TypeDiscoveryExtensions.md 'Jcd.Reflection.TypeDiscoveryExtensions')

## TypeDiscoveryExtensions.FindImplementationsOf<T>(this Assembly, bool) Method

Gets implementations of the specified type from an assembly.

```csharp
public static System.Collections.Generic.IEnumerable<System.Type> FindImplementationsOf<T>(this System.Reflection.Assembly assembly, bool returnTargetTypeIfConcrete=false);
```

#### Type parameters

<a name='Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf_T_(thisSystem.Reflection.Assembly,bool).T'></a>

`T`

#### Parameters

<a name='Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf_T_(thisSystem.Reflection.Assembly,bool).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

the assembly to search.

<a name='Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf_T_(thisSystem.Reflection.Assembly,bool).returnTargetTypeIfConcrete'></a>

`returnTargetTypeIfConcrete` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If [T](Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf_T_(thisSystem.Reflection.Assembly,bool).md#Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf_T_(thisSystem.Reflection.Assembly,bool).T 'Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf<T>(this System.Reflection.Assembly, bool).T')
is in the target assembly, and it's a concrete, return it as well.

#### Returns

[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')
of the implementations of <typeparam name="T"></typeparam>

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
When [assembly](Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf_T_(thisSystem.Reflection.Assembly,bool).md#Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf_T_(thisSystem.Reflection.Assembly,bool).assembly 'Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf<T>(this System.Reflection.Assembly, bool).assembly')
cref="assembly"/> is null.