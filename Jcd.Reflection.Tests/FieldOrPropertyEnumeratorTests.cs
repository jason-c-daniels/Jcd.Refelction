#region

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

public class FieldOrPropertyEnumeratorTests
{
   /// <summary>
   /// Validate that Enumerate Enumerates AllPublicFieldsAndProperties When GivenAnObjectWithFieldsAndProperties.
   /// </summary>
   [Fact]
   public void Enumerate_WhenGivenAnObjectWithFieldsAndProperties_EnumeratesAllPublicFieldsAndProperties()
   {
      var obj  = new TestClassB();
      var sut  = new FieldOrPropertyEnumerator(obj);
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
      var sut = new FieldOrPropertyEnumerator(obj
                                            , new FieldOrPropertyInfoFilter
                                              {
                                                 Flags = BindingFlags.Instance
                                                       | BindingFlags.Static
                                                       | BindingFlags.NonPublic
                                                       | BindingFlags.Public
                                              }
                                             );
      var list = sut.ToList();
      Assert.Equal(15, list.Count);
   }
}