namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public interface IDerivedFromIDerivedFromIGenericBase<out T> : IDerivedFromIGenericBase<T>
{
   T EvenMoreData { get; }
}