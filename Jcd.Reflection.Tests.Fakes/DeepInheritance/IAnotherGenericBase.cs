// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public interface IAnotherGenericBase<out T>
{
   T SomeOtherData { get; }
}