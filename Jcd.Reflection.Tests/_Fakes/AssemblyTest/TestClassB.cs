#region

using System;

#endregion

#pragma warning disable 414

namespace Jcd.Reflection.Tests._Fakes.AssemblyTest;

internal class TestClassB : TestClassA
{
    protected static string Field7 = "hello7";

    // ReSharper disable once ArrangeTypeMemberModifiers
    // ReSharper disable once InconsistentNaming
    static string Field8 = "hello8";
    public DateTime Field6 = DateTime.Now;

    // ReSharper disable once UnusedMember.Global
    public DateTime Prop6 { get; set; } = DateTime.Now;

    // ReSharper disable once UnusedMember.Global
    protected static string Prop7 { get; set; } = "hello4";

    // ReSharper disable once ArrangeTypeMemberModifiers
    // ReSharper disable once UnusedMember.Local
    static string Prop8 { get; set; } = "hello5";
}