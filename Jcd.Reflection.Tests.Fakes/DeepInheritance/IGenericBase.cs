// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public interface IGenericBase<out T>
{
   T OtherData { get; }
}