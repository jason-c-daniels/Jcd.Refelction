namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public class DerivedGeneric<T> : AbstractDerived<T>
{
   #region Overrides of AbstractGenericBase<T>

   /// <inheritdoc />
   public override T Data { get; } = default;

   #endregion

   #region Overrides of AbstractDerived<T>

   /// <inheritdoc />
   public override string Name { get; } = nameof(DerivedGeneric<T>);

   #endregion
}