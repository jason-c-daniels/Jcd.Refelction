#region

using Jcd.Reflection.Tests.Fakes;

#endregion

namespace Jcd.Reflection.Tests._Fakes.AssemblyTest;

public class Poii4 : IPlainOldInterface<int>
{
    #region Implementation of IPlainOldInterface

    /// <inheritdoc />
    public string Name { get; } = nameof(Poii4);

    #endregion

    #region Implementation of IPlainOldInterface<out int>

    /// <inheritdoc />
    public int Data { get; } = 12;

    #endregion
}