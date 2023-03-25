namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public class ImplementsIDerivedFromIIDerivedFromIGenericBase<T> : IDerivedFromIDerivedFromIGenericBase<T>
{
    public ImplementsIDerivedFromIIDerivedFromIGenericBase(T otherData=default, T moreData=default, T evenMoreData=default)
    {
        OtherData = otherData;
        MoreData = moreData;
        EvenMoreData = evenMoreData;
    }

    #region Implementation of IGenericBase<out T>

    /// <inheritdoc />
    public T OtherData { get; }

    #endregion

    #region Implementation of IDerivedFromGenericBase<out T>

    /// <inheritdoc />
    public T MoreData { get; }

    #endregion

    #region Implementation of IDerivedFromDerivedFromGenericBase<out T>

    /// <inheritdoc />
    public T EvenMoreData { get; }

    #endregion
}