using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Jcd.Reflection.Tests._Fakes.AssemblyTest;
using Jcd.Reflection.Tests._Fakes.TypesTest;
using Jcd.Reflection.Tests.Fakes;
using Xunit;
// ReSharper disable InconsistentNaming

namespace Jcd.Reflection.Tests;

public class AssemblyExtensionsTests
{
    [Fact]
    public void FindImplementationsOf_On_A_Single_Assembly_Returns_The_Expected_Types()
    {
        var expectedTypes1 = new List<Type>(new []
        {
            typeof(Poii),
            typeof(Poii2),
            typeof(Poii3),
            typeof(Poii4)
        });
        expectedTypes1.Sort((x,y)=>String.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
        var result1= Assembly.GetExecutingAssembly().FindImplementationsOf<IPlainOldInterface>().ToList();
        result1.Sort((x,y)=>String.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
        Assert.Equal(expectedTypes1,result1);
        
        var expectedTypes2 = new List<Type>(new []
        {
            typeof(PlainOldImplementation2<>),
            typeof(Poi21<>)
        });
        expectedTypes2.Sort((x,y)=>String.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
        var result2= typeof(IPlainOldInterface).Assembly.FindImplementationsOf(typeof(IPlainOldInterface<>)).ToList();
        result2.Sort((x,y)=>String.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
        Assert.Equal(expectedTypes2,result2);
    }
    
    [Fact]
    public void FindImplementationsOf_On_Multiple_Assemblies_Returns_The_Expected_Types()
    {
        var expectedTypes1 = new List<Type>(new []
        {
            typeof(Poii),
            typeof(Poii2),
            typeof(Poii3),
            typeof(Poii4),
            typeof(Poi21<>),
            typeof(PlainOldImplementation1),
            typeof(PlainOldImplementation2<>),
        });
        expectedTypes1.Sort((x,y)=>String.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
        var result1= new[]{ typeof(IPlainOldInterface).Assembly, Assembly.GetExecutingAssembly()}.FindImplementationsOf<IPlainOldInterface>().ToList();
        result1.Sort((x,y)=>String.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
        Assert.Equal(expectedTypes1,result1);
    }

    //[Fact]
    public void Foo()
    {
        var foo = Assembly
            .GetExecutingAssembly()
            .FindImplementationsOf(typeof(GenericBase<>))
            .ToArray();
        
        foo = Assembly
            .GetExecutingAssembly()
            .FindImplementationsOf(typeof(GenericBase<>),true)
            .ToArray();
        
        foo = Assembly
            .GetExecutingAssembly()
            .FindImplementationsOf(typeof(IGenericBase<>))
            .ToArray();

        
        foo = Assembly
            .GetExecutingAssembly()
            .FindImplementationsOf(typeof(AbstractGenericBase<>))
            .ToArray();

        
        foo = Assembly
            .GetExecutingAssembly()
            .FindImplementationsOf(typeof(Object))
            .ToArray();


        foo = Assembly
            .GetExecutingAssembly()
            .FindImplementationsOf(typeof(ValueType))
            .ToArray();

    }
}