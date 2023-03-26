#region

using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using Jcd.Reflection.Tests._Fakes.AssemblyTest;
using Xunit;

#endregion

namespace Jcd.Reflection.Tests;

public class FieldOrPropertyEnumeratorTests
{
    /// <summary>
    /// Validate that Enumerate Enumerates AllPublicFieldsAndProperties When GivenAnObjectWithFieldsAndProperties.
    /// </summary>
    [Fact]
    public void Enumerate_WhenGivenAnObjectWithFieldsAndProperties_EnumeratesAllPublicFieldsAndProperties()
    {
        var obj = new TestClassB();
        var sut = new FieldOrPropertyEnumerator(obj);
        var list = sut.ToList();
        Assert.Equal(6, list.Count);
    }

    /// <summary>
    /// Validate that Enumerate Enumerates AllPublicFieldsAndProperties When GivenAnObjectWithFieldsAndProperties.
    /// </summary>
    [Fact]
    public void
        Enumerate_WhenGivenAnObjectWithFieldsAndPropertiesAndBingingFlags_EnumeratesAllSpecifiedFieldsAndProperties()
    {
        var obj = new TestClassB();
        var sut = new FieldOrPropertyEnumerator(obj,
            new FieldOrPropertyEnumerator.Settings
                { Flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public });
        var list = sut.ToList();
        Assert.Equal(15, list.Count);
    }
    
    [Theory]
    [InlineData(typeof(Poii),BindingFlags.ExactBinding,true)]
    [InlineData(typeof(Poii2),BindingFlags.Static | BindingFlags.Instance,false)]
    [InlineData(typeof(Poii3),BindingFlags.ExactBinding,true)]
    [InlineData(typeof(Poii4),null,true)]
    public void Constructor_Creates_An_Instance_With_The_Expected_Values(Type type, BindingFlags? flags, bool includeSkipFunc)
    {
        bool SkipFunc(FieldOrPropertyInfo mi) => false;
        var settings = flags.HasValue 
            ? new FieldOrPropertyEnumerator.Settings
            {
                Flags = flags.Value, 
                Skip = includeSkipFunc ? SkipFunc : null
            } 
            : default;
        var sut = new FieldOrPropertyEnumerator(type, settings);
        Assert.Equal(type,sut.Type);
        Assert.Equal(settings,sut.EnumerationSettings);
        
        var sut2 = new FieldOrPropertyEnumerator((object)type, settings);
        Assert.Equal(type,sut2.Type);
        Assert.Equal(settings,sut2.EnumerationSettings);
    }
    
    
    [Theory]
    [InlineData(typeof(Poii),BindingFlags.ExactBinding,true)]
    [InlineData(typeof(Poii2),BindingFlags.Static | BindingFlags.Instance,false)]
    [InlineData(typeof(Poii3),BindingFlags.ExactBinding,true)]
    [InlineData(typeof(Poii4),null,true)]
    public void GetEnumerator_Does_Not_Throw(Type type, BindingFlags? flags, bool includeSkipFunc)
    {
        bool SkipFunc(FieldOrPropertyInfo mi) => false;
        var settings = flags.HasValue 
            ? new FieldOrPropertyEnumerator.Settings
            {
                Flags = flags.Value, 
                Skip = includeSkipFunc ? SkipFunc : null
            } 
            : default;
        var sut = new FieldOrPropertyEnumerator(type, settings);
        using var enum1 = sut.GetEnumerator();           
        Assert.NotNull(enum1);
        
        var enum2 = ((IEnumerable)sut).GetEnumerator();           
        Assert.NotNull(enum2);
    }

}