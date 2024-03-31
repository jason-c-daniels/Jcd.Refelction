// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection.Tests.Fakes;

public interface IPlainOldInterface
{
   string Name { get; }
}

public interface IPlainOldInterface<out T> : IPlainOldInterface
{
   T Data { get; }
}