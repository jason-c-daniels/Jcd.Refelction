namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public interface IDerivedFromIGenericBase<out T> : IGenericBase<T>
{
    T MoreData { get; }
}