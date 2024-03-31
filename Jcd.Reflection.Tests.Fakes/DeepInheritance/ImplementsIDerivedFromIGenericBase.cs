// ReSharper disable UnusedType.Global

namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public abstract class ImplementsIDerivedFromIGenericBase<T> : IDerivedFromIGenericBase<T>
{
   #region Implementation of IGenericBase<out T>

   /// <inheritdoc />
   public T OtherData => default;

   #endregion

   #region Implementation of IDerivedFromGenericBase<out T>

   /// <inheritdoc />
   public T MoreData => default;

   #endregion
}