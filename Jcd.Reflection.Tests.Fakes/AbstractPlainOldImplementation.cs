namespace Jcd.Reflection.Tests.Fakes;

public abstract class AbstractPlainOldImplementation<T> : IPlainOldInterface<T>
{
   #region Implementation of IPlainOldInterface<T>

   /// <inheritdoc />
   public T Data => default;

   #endregion

   #region Implementation of IPlainOldInterface

   /// <inheritdoc />
   public string Name => nameof(AbstractPlainOldImplementation<T>);

   #endregion
}