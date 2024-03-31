// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public abstract class AbstractDerived<T> : AbstractGenericBase<T>
{
   public abstract string Name { get; }
}