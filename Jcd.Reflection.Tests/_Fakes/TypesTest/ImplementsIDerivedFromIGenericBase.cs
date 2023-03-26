// ReSharper disable ReplaceAutoPropertyWithComputedProperty

namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public abstract class ImplementsIDerivedFromIGenericBase<T> : IDerivedFromIGenericBase<T>
{
    #region Implementation of IGenericBase<out T>

    /// <inheritdoc />
    public T OtherData { get; } = default;

    #endregion

    #region Implementation of IDerivedFromGenericBase<out T>

    /// <inheritdoc />
    public T MoreData { get; } = default;

    #endregion
}