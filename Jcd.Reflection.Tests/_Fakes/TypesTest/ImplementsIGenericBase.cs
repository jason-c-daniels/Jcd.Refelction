namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public class ImplementsIGenericBase<T> : IGenericBase<T>
{
   #region Implementation of IGenericBase<out T>

   /// <inheritdoc />
   public T OtherData { get; } = default;

   #endregion
}