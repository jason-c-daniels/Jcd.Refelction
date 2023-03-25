// ReSharper disable PropertyCanBeMadeInitOnly.Global
// ReSharper disable UnusedMember.Global

#pragma warning disable 414
namespace Jcd.Reflection.Tests._Fakes.AssemblyTest;

internal class TestClassA
{
    public static string Field5 = "hello3";

    // ReSharper disable once ArrangeTypeMemberModifiers
    // ReSharper disable once InconsistentNaming
    static string Field4 = "hello2";

    // ReSharper disable once ConvertToConstant.Global
    public readonly string Field2 = "hello";

    // ReSharper disable once FieldCanBeMadeReadOnly.Global
    // ReSharper disable once ConvertToConstant.Global
    public int Field1 = 5;
    protected string Field3 = "hello1";

    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public int Prop1 { get; set; } = 5;
    public string Prop2 { get; set; } = "hello";

    // ReSharper disable once UnusedMember.Global
    public static string Prop5 { get; set; } = "hello3";

    protected string Prop3 { get; set; } = "hello1";

    // ReSharper disable once ArrangeTypeMemberModifiers
    // ReSharper disable once UnusedMember.Local
    static string Prop4 { get; set; } = "hello2";
}