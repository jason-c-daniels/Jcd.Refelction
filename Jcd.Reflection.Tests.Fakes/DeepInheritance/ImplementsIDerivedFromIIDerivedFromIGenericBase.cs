// ReSharper disable MemberCanBeProtected.Global

namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public class ImplementsIDerivedFromIiDerivedFromIGenericBase<T>
(
   T otherData    = default
 , T moreData     = default
 , T evenMoreData = default
)
   : IDerivedFromIDerivedFromIGenericBase<T>
{
   #region Implementation of IGenericBase<out T>

   /// <inheritdoc />
   public T OtherData { get; } = otherData;

   #endregion

   #region Implementation of IDerivedFromGenericBase<out T>

   /// <inheritdoc />
   public T MoreData { get; } = moreData;

   #endregion

   #region Implementation of IDerivedFromDerivedFromGenericBase<out T>

   /// <inheritdoc />
   public T EvenMoreData { get; } = evenMoreData;

   #endregion
}