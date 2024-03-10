#region

using Jcd.Reflection.Tests.Fakes;

#endregion

namespace Jcd.Reflection.Tests._Fakes.AssemblyTest;

public readonly struct Poii3 : IPlainOldInterface
{
   public Poii3() { }

   #region Implementation of IPlainOldInterface

   /// <inheritdoc />
   public string Name { get; } = nameof(Poii3);

   #endregion
}