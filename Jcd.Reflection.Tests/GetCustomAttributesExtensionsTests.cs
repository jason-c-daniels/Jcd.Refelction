#region

using System;
using System.Linq;
using System.Reflection;
using Jcd.Reflection.Tests.TestHelpers;
using Xunit;

#endregion

namespace Jcd.Reflection.Tests;

public class GetCustomAttributesExtensionsTests
{
    [Theory]
    [InlineData(AttributesEnum.First, 0)]
    [InlineData(AttributesEnum.Second, 1)]
    [InlineData(AttributesEnum.Third, 2)]
    public void GetCustomAttributes_For_Enum_Value_Gets_The_Attributes_When_They_Exist(
        AttributesEnum value, int expectedCount)
    {
        var attrs = value.GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs.Length);
    }

    [Theory]
    [InlineData(typeof(AttributesReflectionTestClass), "_field", 2)]
    public void GetCustomAttributes_For_FieldInfo_Gets_The_Attributes_When_They_Exist(
        Type type, string field, int expectedCount)
    {
        var attrs = type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic)
            .GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs.Length);
    }

    [Theory]
    [InlineData(typeof(AttributesReflectionTestClass), "PrivateProperty", 2)]
    public void GetCustomAttributes_For_PropertyInfo_Gets_The_Attributes_When_They_Exist(
        Type type, string propName, int expectedCount)
    {
        var attrs = type.GetProperty(propName, BindingFlags.Instance | BindingFlags.NonPublic)
            .GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs.Length);
    }

    [Theory]
    [InlineData(typeof(AttributesReflectionTestClass), "InternalGetField", 1)]
    [InlineData(typeof(AttributesReflectionTestClass), "GetField", 2)]
    public void GetCustomAttributes_For_MethodInfo_Gets_The_Attributes_When_They_Exist(
        Type type, string methodName, int expectedCount)
    {
        var mi = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        var attrs = mi.GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs.Length);
    }

    [Theory]
    [InlineData(typeof(AttributesReflectionTestClass), 2)]
    [InlineData(typeof(AttributesEnum), 2)]
    public void GetCustomAttributes_For_Type_Gets_The_Attributes_When_They_Exist(Type type, int expectedCount)
    {
        var attrs = type.GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs.Length);
    }

    [Theory]
    [InlineData(typeof(AttributesReflectionTestClass), 2)]
    [InlineData(typeof(AttributesEnum), 2)]
    public void GetCustomAttributes_For_TypeInfo_Gets_The_Attributes_When_They_Exist(Type type, int expectedCount)
    {
        var attrs = type.GetTypeInfo().GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs.Length);
    }

    [Fact]
    public void GetCustomAttributes_For_Assembly_Gets_The_Attributes()
    {
        var attrs = typeof(AttributesReflectionTestClass).Assembly.GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(3, attrs.Length);
    }

    [Theory]
    [InlineData("Jcd.Reflection.Tests.dll", 1)]
    public void GetCustomAttributes_For_Module_Gets_The_Attributes_When_They_Exist(string name, int expectedCount)
    {
        var module = typeof(AttributesReflectionTestClass).Assembly.GetModule(name);
        var attrs = module.GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs.Length);
    }

    [Theory]
    [InlineData(typeof(AttributesReflectionTestClass), "DidIt", 3)]
    [InlineData(typeof(AttributesReflectionTestClass), "NothingWasDone", 0)]
    public void GetCustomAttributes_For_EventInfo_Gets_The_Attributes_When_They_Exist(
        Type type, string methodName, int expectedCount)
    {
        var attrs = type.GetEvent(methodName).GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs.Length);
    }

    [Theory]
    [InlineData(typeof(AttributesReflectionTestClass), "DoSomething", "param1", 1)]
    [InlineData(typeof(AttributesReflectionTestClass), "DoSomething", "param2", 0)]
    public void GetCustomAttributes_For_ParameterInfo_Gets_The_Attributes_When_They_Exist(
        Type type, string methodName, string paramName, int expectedCount)
    {
        var method = type.GetMethod(methodName);
        var param = method?.GetParameters().First(p => p.Name == paramName);
        var attrs = param?.GetCustomAttributes<MyDescriptionAttribute>();
        Assert.Equal(expectedCount, attrs?.Length);
    }
}