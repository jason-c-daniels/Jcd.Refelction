#region

#endregion

namespace Jcd.Reflection.Tests.Fakes;

public class Poii4 : IPlainOldInterface<int>
{
   #region Implementation of IPlainOldInterface

   /// <inheritdoc />
   public string Name { get; } = nameof(Poii4);

   #endregion

   #region Implementation of IPlainOldInterface<out int>

   /// <inheritdoc />
   public int Data { get; } = 12;

   #endregion
}