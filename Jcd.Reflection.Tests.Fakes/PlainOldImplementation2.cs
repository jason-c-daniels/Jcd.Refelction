namespace Jcd.Reflection.Tests.Fakes;

public class PlainOldImplementation2<T> : PlainOldImplementation1, IPlainOldInterface<T>
{
    #region Implementation of IPlainOldInterface<T>

    /// <inheritdoc />
    public T Data { get; } = default;

    #endregion
}

public class Poi21<Y> : PlainOldImplementation2<Y>
{
}