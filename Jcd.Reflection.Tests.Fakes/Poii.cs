#region

// ReSharper disable IdentifierTypo
// ReSharper disable StructCanBeMadeReadOnly
// ReSharper disable UnusedMember.Global

#endregion

namespace Jcd.Reflection.Tests.Fakes;

public struct Poii : IPlainOldInterface<string>
{
   public Poii() { }

   #region Implementation of IPlainOldInterface

   /// <inheritdoc />
   public string Name => nameof(Poii);

   #endregion

   #region Implementation of IPlainOldInterface<out string>

   /// <inheritdoc />
   public string Data => string.Empty;

   #endregion
}