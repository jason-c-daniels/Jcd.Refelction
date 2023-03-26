#region

using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using Jcd.Reflection.Tests._Fakes.AssemblyTest;
using Xunit;

#endregion

namespace Jcd.Reflection.Tests;

public class MemberInfoEnumeratorTests
{
    /// <summary>
    /// Validate that Enumerate Enumerates AllPublicFieldsAndProperties When GivenAnObjectWithFieldsAndProperties.
    /// </summary>
    [Fact]
    public void Enumerate_WhenGivenAnObjectWithFieldsAndProperties_EnumeratesAllPublicFieldsAndProperties()
    {
        var obj = new TestClassB();
        var sut = new MemberInfoEnumerator(obj);
        var list = sut.ToList();
        Assert.Equal(20, list.Count);
    }

    /// <summary>
    /// Validate that Enumerate Enumerates AllPublicFieldsAndProperties When GivenAnObjectWithFieldsAndProperties.
    /// </summary>
    [Fact]
    public void
        Enumerate_WhenGivenAnObjectWithFieldsAndPropertiesAndBingingFlags_EnumeratesAllSpecifiedFieldsAndProperties()
    {
        var obj = new TestClassB();
        var sut = new MemberInfoEnumerator(obj,
            new MemberInfoEnumerator.Settings
            {
                Flags = BindingFlags.Instance |
                        BindingFlags.Static |
                        BindingFlags.NonPublic |
                        BindingFlags.Public,
                Skip = MemberInfoEnumerator.SkipSystemMembers
            });
        var list = sut.ToList();
        // this contains all inherited, non-system, members.
        Assert.Equal(33, list.Count);
    }

    [Theory]
    [InlineData(typeof(Poii), BindingFlags.ExactBinding, true)]
    [InlineData(typeof(Poii2), BindingFlags.Static | BindingFlags.Instance, false)]
    [InlineData(typeof(Poii3), BindingFlags.ExactBinding, true)]
    [InlineData(typeof(Poii4), null, true)]
    public void Constructor_Creates_An_Instance_With_The_Expected_Values(
        Type type, BindingFlags? flags, bool includeSkipFunc)
    {
        bool SkipFunc(MemberInfo mi)
        {
            return false;
        }

        var settings = flags.HasValue
            ? new MemberInfoEnumerator.Settings
            {
                Flags = flags.Value,
                Skip = includeSkipFunc ? SkipFunc : null
            }
            : default;
        var sut = new MemberInfoEnumerator(type, settings);
        Assert.Equal(type, sut.Type);
        Assert.Equal(settings, sut.EnumerationSettings);

        var sut2 = new MemberInfoEnumerator((object)type, settings);
        Assert.Equal(type, sut2.Type);
        Assert.Equal(settings, sut2.EnumerationSettings);
    }

    [Theory]
    [InlineData(typeof(Poii), BindingFlags.ExactBinding, true)]
    [InlineData(typeof(Poii2), BindingFlags.Static | BindingFlags.Instance, false)]
    [InlineData(typeof(Poii3), BindingFlags.ExactBinding, true)]
    [InlineData(typeof(Poii4), null, true)]
    public void GetEnumerator_Does_Not_Throw(Type type, BindingFlags? flags, bool includeSkipFunc)
    {
        bool SkipFunc(MemberInfo mi)
        {
            return false;
        }

        var settings = flags.HasValue
            ? new MemberInfoEnumerator.Settings
            {
                Flags = flags.Value,
                Skip = includeSkipFunc ? SkipFunc : null
            }
            : default;
        var sut = new MemberInfoEnumerator(type, settings);
        using var enum1 = sut.GetEnumerator();
        Assert.NotNull(enum1);

        var enum2 = ((IEnumerable)sut).GetEnumerator();
        Assert.NotNull(enum2);
    }
}