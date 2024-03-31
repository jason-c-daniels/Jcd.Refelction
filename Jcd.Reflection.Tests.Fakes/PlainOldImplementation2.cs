namespace Jcd.Reflection.Tests.Fakes;

public class PlainOldImplementation2<T>
   : PlainOldImplementation1
   , IPlainOldInterface<T>
{
   #region Implementation of IPlainOldInterface<T>

   /// <inheritdoc />
   public T Data => default;

   #endregion
}