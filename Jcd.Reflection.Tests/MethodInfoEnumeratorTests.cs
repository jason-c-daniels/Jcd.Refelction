#region

using System;
using System.Collections;
using System.Linq;
using System.Reflection;

using Jcd.Reflection.Tests.Fakes;

using Xunit;

// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable InconsistentNaming
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident

#endregion

namespace Jcd.Reflection.Tests;

public class MethodInfoEnumeratorTests
{
   /// <summary>
   /// Validate that Enumerate Enumerates AllPublicFieldsAndProperties When GivenAnObjectWithFieldsAndProperties.
   /// </summary>
   [Fact]
   public void Enumerate_WhenGivenAnObjectWithFieldsAndProperties_EnumeratesAllPublicFieldsAndProperties()
   {
      var obj  = new TestClassB();
      var sut  = new MethodInfoEnumerator(obj);
      var list = sut.ToList();
      Assert.Equal(10, list.Count);
   }

   /// <summary>
   /// Validate that Enumerate Enumerates AllPublicFieldsAndProperties When GivenAnObjectWithFieldsAndProperties.
   /// </summary>
   [Fact]
   public void
      Enumerate_WhenGivenAnObjectWithFieldsAndPropertiesAndBingingFlags_EnumeratesAllSpecifiedFieldsAndProperties()
   {
      var obj = new TestClassB();
      var sut = new MethodInfoEnumerator(obj
                                       , new MethodInfoFilter
                                         {
                                            Flags = BindingFlags.Instance
                                                  | BindingFlags.Static
                                                  | BindingFlags.NonPublic
                                                  | BindingFlags.Public
                                         }
                                        );
      var list = sut.ToList();
      Assert.Equal(18, list.Count);
      sut  = new MethodInfoEnumerator(obj, MethodInfoFilter.AllInstanceMethodsFilter);
      list = sut.ToList();
      Assert.Equal(14, list.Count);
      sut  = new MethodInfoEnumerator(obj, MethodInfoFilter.AllStaticMethodsFilter);
      list = sut.ToList();
      Assert.Equal(8, list.Count);
      sut  = new MethodInfoEnumerator(obj, MethodInfoFilter.DirectInstanceMethodsFilter);
      list = sut.ToList();
      Assert.Equal(14, list.Count);
      sut  = new MethodInfoEnumerator(obj, MethodInfoFilter.DirectStaticMethodsFilter);
      list = sut.ToList();
      Assert.Equal(8, list.Count);

      // force coverage on IEnumerable.GetEnumerator
      var       disp    = ((IEnumerable) sut).GetEnumerator();
      using var unknown = disp as IDisposable;
   }
}