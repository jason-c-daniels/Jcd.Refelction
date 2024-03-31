#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Jcd.Reflection.Tests.Fakes;

using Xunit;

// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable InconsistentNaming
// ReSharper disable HeapView.ObjectAllocation.Evident

#endregion

namespace Jcd.Reflection.Tests;

public class TypeDiscoveryExtensionsTests
{
   [Fact]
   public void FindImplementationsOf_On_A_Single_Assembly_Returns_The_Expected_Types()
   {
      var expectedTypes1 = new List<Type>(new[]
                                          {
                                             typeof(Poii)
                                           , typeof(Poii2)
                                           , typeof(Poii3)
                                           , typeof(Poii4)
                                           , typeof(PlainOldImplementation1)
                                           , typeof(PlainOldImplementation2<>)
                                           , typeof(Poi21<>)
                                          }
                                         );
      expectedTypes1.Sort((x, y) => string.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
      var result1 = typeof(IPlainOldInterface).Assembly.FindImplementationsOf<IPlainOldInterface>().ToList();
      result1.Sort((x, y) => string.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
      Assert.Equal(expectedTypes1, result1);
   }

   [Fact]
   public void FindImplementationsOf_On_Multiple_Assemblies_Returns_The_Expected_Types()
   {
      var expectedTypes1 = new List<Type>(new[]
                                          {
                                             typeof(Poii)
                                           , typeof(Poii2)
                                           , typeof(Poii3)
                                           , typeof(Poii4)
                                           , typeof(Poi21<>)
                                           , typeof(PlainOldImplementation1)
                                           , typeof(PlainOldImplementation2<>)
                                          }
                                         );
      expectedTypes1.Sort((x, y) => string.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
      var result1 = new[] { typeof(IPlainOldInterface).Assembly, Assembly.GetExecutingAssembly() }
                   .FindImplementationsOf<IPlainOldInterface>()
                   .ToList();
      result1.Sort((x, y) => string.Compare(x.FullName, y.FullName, StringComparison.InvariantCulture));
      Assert.Equal(expectedTypes1, result1);
   }

   [Fact]
   public void FindImplementationsOf_On_Assembly_Throws_When_Assembly_Is_Null()
   {
      Assembly assembly = null;

      // ReSharper disable once ExpressionIsAlwaysNull
      Assert.Throws<ArgumentNullException>(() => assembly.FindImplementationsOf<IPlainOldInterface>());
   }

   [Fact]
   public void FindImplementationsOf_On_Assembly_Throws_When_Type_Is_Null()
   {
      var assembly = Assembly.GetExecutingAssembly();
      Assert.Throws<ArgumentNullException>(() => assembly.FindImplementationsOf(null));
   }

   [Fact]
   public void FindImplementationsOf_On_Assemblies_Throws_When_Assembly_Is_Null()
   {
      IEnumerable<Assembly> assemblies = null;

      // ReSharper disable once ExpressionIsAlwaysNull
      Assert.Throws<ArgumentNullException>(() => assemblies.FindImplementationsOf<IPlainOldInterface>().ToList());
   }

   [Fact]
   public void FindImplementationsOf_On_Assemblies_Throws_When_Type_Is_Null()
   {
      Assembly[] assemblies = [Assembly.GetExecutingAssembly(), Assembly.GetExecutingAssembly()];
      Assert.Throws<ArgumentNullException>(() => assemblies.FindImplementationsOf(null).ToList());
   }
}