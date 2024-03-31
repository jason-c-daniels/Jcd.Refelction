namespace Jcd.Reflection.Tests.Fakes;

public class PlainOldImplementation1 : IPlainOldInterface
{
   #region Implementation of IPlainOldInterface

   /// <inheritdoc />
   public string Name => nameof(PlainOldImplementation1);

   #endregion
}