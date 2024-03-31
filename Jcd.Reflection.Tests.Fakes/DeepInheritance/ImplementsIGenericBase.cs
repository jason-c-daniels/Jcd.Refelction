namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public class ImplementsIGenericBase<T> : IGenericBase<T>
{
   #region Implementation of IGenericBase<out T>

   /// <inheritdoc />
   public T OtherData => default;

   #endregion
}