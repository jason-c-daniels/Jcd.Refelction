#region

using System.Reflection;
using Jcd.Reflection.Tests._Fakes;
using Jcd.Reflection.Tests._Fakes.AssemblyTest;
using Xunit;

#endregion

namespace Jcd.Reflection.Tests;

public class MethodExtensionsTests
{
    [Fact]
    public void Invoke_On_Type_Executes_Private_Method_With_Result()
    {
        var result = typeof(TestClassC).Invoke("op_Sub", 7, 4);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Invoke_On_Type_Executes_Private_Method_With_Result2()
    {
        var result = typeof(TestClassC).Invoke<int>("op_Sub", 7, 4);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Invoke_On_Type_Executes_Method_With_Result()
    {
        var result = typeof(TestClassC).Invoke("Sub", 7, 4);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Invoke_On_Type_Executes_Method_With_Result2()
    {
        var result = typeof(TestClassC).Invoke<int>("Sub", 7, 4);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Invoke_On_Instance_Executes_Private_Method_With_Result()
    {
        var result = new TestClassC().Invoke("op_Add", 7, 4);
        Assert.Equal(11, result);
    }

    [Fact]
    public void Invoke_On_Instance_Executes_Private_Method_With_Result2()
    {
        var result = new TestClassC().Invoke<int>("op_Add", 7, 4);
        Assert.Equal(11, result);
    }

    [Fact]
    public void Invoke_On_Instance_Executes_Method_With_Result()
    {
        var result = new TestClassC().Invoke("Add", 7, 4);
        Assert.Equal(11, result);
    }

    [Fact]
    public void Invoke_On_Instance_Executes_Method_With_Result2()
    {
        var result = new TestClassC().Invoke<int>("Add", 7, 4);
        Assert.Equal(11, result);
    }

    [Fact]
    public void Invoke_On_Instance_Executes_Method_With_Result3()
    {
        var result = typeof(TestClassC).Invoke<int>("Sub",
            new MethodInfoEnumerator.Settings
                { Flags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic }, 7, 4);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Invoke_On_Instance_Executes_Method_With_Result4()
    {
        var result = typeof(TestClassC).Invoke("Sub",
            new MethodInfoEnumerator.Settings
                { Flags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic }, 7, 4);
        Assert.Equal(3, result);
    }

    [Fact]
    public void GetMethod_For_Existing_Method_On_Instance_Returns_The_MethodInfo()
    {
        var result = new TestClassC().GetMethod("Add");
        Assert.NotNull(result);
    }

    [Fact]
    public void GetMethod_For_NonExistent_Method_On_Instance_Returns_Null()
    {
        var result = new TestClassC().GetMethod("NotMyMethod");
        Assert.Null(result);
    }
}