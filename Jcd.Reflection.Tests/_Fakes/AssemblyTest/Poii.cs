#region

using Jcd.Reflection.Tests.Fakes;

// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

#endregion

namespace Jcd.Reflection.Tests._Fakes.AssemblyTest;

public readonly struct Poii : IPlainOldInterface<string>
{
    public Poii()
    {
    }

    #region Implementation of IPlainOldInterface

    /// <inheritdoc />
    public string Name { get; } = nameof(Poii);

    #endregion

    #region Implementation of IPlainOldInterface<out string>

    /// <inheritdoc />
    public string Data { get; } = string.Empty;

    #endregion
}