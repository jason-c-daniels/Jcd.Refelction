using Jcd.Reflection.Tests._Fakes.TypesTest;
using Xunit;

namespace Jcd.Reflection.Tests;

public class TypeExtensionsTests
{
    private class PrivateNestedType{}
    public class NestedType
    {
        public class AnotherNestedType{}
    }
    
    public struct S<T> 
        where T : struct
    {
        public T F;
    }

    struct S2<T> 
        where T : struct
    {
        public T F;
    }

    interface I<T>
    {
        public T F { get; }
    }
    
    struct S3 : I<int>
    {
        public S3()
        {
        }

        #region Implementation of I<int>

        /// <inheritdoc />
        public int F { get; } = default;

        #endregion
    }
    
    enum E
    {
        Foo,
        Bar
    }
    
    [Fact]
    public void IsConcreteType_Returns_True_For_Concrete_Types()
    {
        Assert.True(typeof(IDerivedFromIiDerivedFromIImplementsIDerivedFromIiDerivedFromIGenericBase<>).IsConcreteType());
        Assert.True(typeof(S<>).IsConcreteType());
        Assert.True(typeof(S2<>).IsConcreteType());
        Assert.True(typeof(S<int>).IsConcreteType());
        Assert.True(typeof(S2<int>).IsConcreteType());
        Assert.True(typeof(NestedType).IsConcreteType());
        Assert.True(typeof(NestedType.AnotherNestedType).IsConcreteType());
        Assert.True(typeof(PrivateNestedType).IsConcreteType());
        Assert.True(typeof(NeenerImBeingDumb<>).IsConcreteType());
        Assert.True(typeof(NeenerImBeingDumb<int>).IsConcreteType());
        
    }
    
    [Fact]
    public void InheritsFrom_Returns_True_For_Derived_Types()
    {
        Assert.True(typeof(AbstractDerived<>).InheritsFrom(typeof(AbstractGenericBase<>)));
        Assert.True(typeof(IDerivedFromIiDerivedFromIImplementsIDerivedFromIiDerivedFromIGenericBase<>).InheritsFrom(typeof(IGenericBase<>)));
        Assert.True(typeof(NeenerImBeingDumb<>).InheritsFrom(typeof(IGenericBase<>)));
        Assert.True(typeof(AbstractDerived<int>).InheritsFrom(typeof(AbstractGenericBase<int>)));
        Assert.True(typeof(ImplementsIGenericBase<>).InheritsFrom(typeof(IGenericBase<>)));
        Assert.True(typeof(S3).InheritsFrom(typeof(I<>)));
    }
    
    [Fact]
    public void InheritsFrom_Returns_False_For_Types_Not_Derived_From_Provided_Type()
    {
        Assert.False(typeof(AbstractDerived<>).InheritsFrom(typeof(IGenericBase<>)));
        Assert.False(typeof(IDerivedFromIiDerivedFromIImplementsIDerivedFromIiDerivedFromIGenericBase<>).InheritsFrom(typeof(GenericBase<>)));
        Assert.False(typeof(NeenerImBeingDumb<>).InheritsFrom(typeof(GenericBase<>)));
        Assert.False(typeof(AbstractDerived<int>).InheritsFrom(typeof(IGenericBase<int>)));
        Assert.False(typeof(ImplementsIGenericBase<>).InheritsFrom(typeof(GenericBase<>)));
    }
}