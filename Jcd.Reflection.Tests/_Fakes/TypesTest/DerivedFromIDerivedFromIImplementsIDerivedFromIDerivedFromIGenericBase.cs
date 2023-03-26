// ReSharper disable UnusedMember.Global
// ReSharper disable ReplaceAutoPropertyWithComputedProperty

namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public class
    DerivedFromIDerivedFromIImplementsIDerivedFromIDerivedFromIGenericBase<T> :
        ImplementsIDerivedFromIDerivedFromIGenericBase<T>
{
    public T SomeData { get; } = default;
}