// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public interface IDerivedFromIDerivedFromIGenericBase<out T> : IDerivedFromIGenericBase<T>
{
   T EvenMoreData { get; }
}