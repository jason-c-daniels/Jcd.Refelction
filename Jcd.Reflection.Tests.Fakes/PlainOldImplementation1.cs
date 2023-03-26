// ReSharper disable ReplaceAutoPropertyWithComputedProperty

namespace Jcd.Reflection.Tests.Fakes;

public class PlainOldImplementation1 : IPlainOldInterface
{
    #region Implementation of IPlainOldInterface

    /// <inheritdoc />
    public string Name { get; } = nameof(PlainOldImplementation1);

    #endregion
}