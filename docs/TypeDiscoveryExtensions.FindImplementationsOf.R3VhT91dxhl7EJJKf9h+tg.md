### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection').[TypeDiscoveryExtensions](TypeDiscoveryExtensions.md 'Jcd.Reflection.TypeDiscoveryExtensions')

## TypeDiscoveryExtensions.FindImplementationsOf(this Assembly, Type, bool) Method

Gets implementations of the specified type from an assembly.

```csharp
public static System.Collections.Generic.IEnumerable<System.Type> FindImplementationsOf(this System.Reflection.Assembly assembly, System.Type type, bool returnTargetTypeIfConcrete=false);
```

#### Parameters

<a name='Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(thisSystem.Reflection.Assembly,System.Type,bool).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

the assembly to search.

<a name='Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(thisSystem.Reflection.Assembly,System.Type,bool).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type to find implementations of.

<a name='Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(thisSystem.Reflection.Assembly,System.Type,bool).returnTargetTypeIfConcrete'></a>

`returnTargetTypeIfConcrete` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If [type](TypeDiscoveryExtensions.FindImplementationsOf.R3VhT91dxhl7EJJKf9h+tg.md#Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(thisSystem.Reflection.Assembly,System.Type,bool).type 'Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(this System.Reflection.Assembly, System.Type, bool).type')
is in the target assembly, and it's a concrete, return it as well.

#### Returns

[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')
An [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')
of the implementations
of [type](TypeDiscoveryExtensions.FindImplementationsOf.R3VhT91dxhl7EJJKf9h+tg.md#Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(thisSystem.Reflection.Assembly,System.Type,bool).type 'Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(this System.Reflection.Assembly, System.Type, bool).type')

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')
When
either [assembly](TypeDiscoveryExtensions.FindImplementationsOf.R3VhT91dxhl7EJJKf9h+tg.md#Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(thisSystem.Reflection.Assembly,System.Type,bool).assembly 'Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(this System.Reflection.Assembly, System.Type, bool).assembly')
or [type](TypeDiscoveryExtensions.FindImplementationsOf.R3VhT91dxhl7EJJKf9h+tg.md#Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(thisSystem.Reflection.Assembly,System.Type,bool).type 'Jcd.Reflection.TypeDiscoveryExtensions.FindImplementationsOf(this System.Reflection.Assembly, System.Type, bool).type')
is null.