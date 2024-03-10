namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public interface IDerivedFromIGenericBase<out T> : IGenericBase<T>
{
   T MoreData { get; }
}