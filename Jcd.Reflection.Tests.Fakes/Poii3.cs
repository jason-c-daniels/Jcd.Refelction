#region

// ReSharper disable IdentifierTypo

#endregion

// ReSharper disable UnusedMember.Global
namespace Jcd.Reflection.Tests.Fakes;

public readonly struct Poii3 : IPlainOldInterface
{
   public Poii3() { }

   #region Implementation of IPlainOldInterface

   /// <inheritdoc />
   public string Name => nameof(Poii3);

   #endregion
}