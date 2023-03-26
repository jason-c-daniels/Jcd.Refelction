#region

using System;
using System.Diagnostics.CodeAnalysis;

// ReSharper disable UnusedMember.Global

#endregion

#pragma warning disable 414

namespace Jcd.Reflection.Tests._Fakes.AssemblyTest;

[SuppressMessage("Performance", "CA1822:Mark members as static")]
internal class TestClassB : TestClassA
{
    protected static string Field7 = "hello7";

    // ReSharper disable once InconsistentNaming
    private static string Field8 = "hello8";
    public DateTime Field6 = DateTime.Now;

    // ReSharper disable once UnusedMember.Global
    public DateTime Prop6 { get; set; } = DateTime.Now;

    // ReSharper disable once UnusedMember.Global
    protected static string Prop7 { get; set; } = "hello4";

    // ReSharper disable once UnusedMember.Local
    private static string Prop8 { get; set; } = "hello5";
    
    // ReSharper disable once UnusedMember.Local
    public void Method1(){}
    
    // ReSharper disable once UnusedMember.Local
    public void Method2(){}
    public static void Method3(){}

    private static void Method4(){}
}