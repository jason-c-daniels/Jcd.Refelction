#region

#endregion

namespace Jcd.Reflection.Tests.Fakes;

public struct Poii : IPlainOldInterface<string>
{
   public Poii() { }

   #region Implementation of IPlainOldInterface

   /// <inheritdoc />
   public string Name { get; } = nameof(Poii);

   #endregion

   #region Implementation of IPlainOldInterface<out string>

   /// <inheritdoc />
   public string Data { get; } = string.Empty;

   #endregion
}