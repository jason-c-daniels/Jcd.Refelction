#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Jcd.Reflection.Tests._TestHelpers;
using Jcd.Reflection.Tests.Fakes;

using Xunit;

// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable InconsistentNaming
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.BoxingAllocation

#endregion

namespace Jcd.Reflection.Tests;

public class ReflectionExtensionsTests
{
   /// <summary>
   /// Validate that EnumerateProperties enumerates public instance properties, inherited, when called with default
   /// parameters.
   /// </summary>
   [Fact]
   public void EnumeratePropertiesOnType_WhenCalledWithDefaultParameters_EnumeratesPublicInstanceProperties()
   {
      var props = typeof(TestClassB).EnumerateProperties().ToList();
      Assert.Equal(3, props.Count);
   }

   /// <summary>
   /// Validate that EnumerateProperties enumerates public instance properties and skips according to skip function.
   /// </summary>
   [Fact]
   public void
      EnumeratePropertiesOnType_WhenCalledWithDefaultParameters_EnumeratesPublicInstancePropertiesAndSkipsIndicated()
   {
      var props = typeof(TestClassB).EnumerateProperties(skip: pi => pi.Name == "Prop1").ToList();
      Assert.Equal(2, props.Count);
   }

   /// <summary>
   /// Validate that EnumerateProperties Enumerates AllProperties When BindingsSetToReturnAll, except private base class.
   /// </summary>
   [Fact]
   public void EnumeratePropertiesOnType_WhenBindingsSetToReturnAll_EnumeratesAllProperties()
   {
      var props = typeof(TestClassB)
                 .EnumerateProperties(BindingFlags.NonPublic
                                    | BindingFlags.Static
                                    | BindingFlags.Public
                                    | BindingFlags.Instance
                                    | BindingFlags.FlattenHierarchy
                                     )
                 .ToList();
      Assert.Equal(7, props.Count);
   }

   /// <summary>
   /// Validate that EnumerateProperties enumerates public instance properties, inherited, when called with default
   /// parameters.
   /// </summary>
   [Fact]
   public void EnumeratePropertiesOnObject_WhenCalledWithDefaultParameters_EnumeratesPublicInstanceProperties()
   {
      var props = new TestClassB().EnumerateProperties().ToList();
      Assert.Equal(3, props.Count);
   }

   /// <summary>
   /// Validate that EnumerateProperties enumerates public instance properties and skips according to skip function.
   /// </summary>
   [Fact]
   public void
      EnumeratePropertiesOnObject_WhenCalledWithDefaultParameters_EnumeratesPublicInstancePropertiesAndSkipsIndicated()
   {
      var props = new TestClassB().EnumerateProperties(skip: pi => pi.Name == "Prop1").ToList();
      Assert.Equal(2, props.Count);
   }

   /// <summary>
   /// Validate that EnumerateProperties Enumerates AllProperties When BindingsSetToReturnAll, except private base class.
   /// </summary>
   [Fact]
   public void EnumeratePropertiesOnObject_WhenBindingsSetToReturnAll_EnumeratesAllProperties()
   {
      var props = new TestClassB()
                 .EnumerateProperties(BindingFlags.NonPublic
                                    | BindingFlags.Static
                                    | BindingFlags.Public
                                    | BindingFlags.Instance
                                    | BindingFlags.FlattenHierarchy
                                     )
                 .ToList();
      Assert.Equal(7, props.Count);
   }

   /// <summary>
   /// Validate that EnumerateFields enumerates public instance properties, inherited, when called with default parameters.
   /// </summary>
   [Fact]
   public void EnumerateFieldsOnType_WhenCalledWithDefaultParameters_EnumeratesPublicInstanceFields()
   {
      var fields = typeof(TestClassB).EnumerateFields().ToList();
      Assert.Equal(3, fields.Count);
   }

   /// <summary>
   /// Validate that EnumerateFields enumerates public instance properties, inherited, when called with default parameters.
   /// </summary>
   [Fact]
   public void EnumerateFields_On_Int32_With_Default_Parameters_Returns_Empty_Collection()
   {
      var fields = typeof(int).EnumerateFields().ToList();
      Assert.Empty(fields);
   }

   /// <summary>
   /// Validate that EnumerateFields enumerates public instance properties, inherited, when called with default parameters.
   /// </summary>
   [Fact]
   public void EnumerateFields_On_Null_With_Default_Parameters_Returns_Empty_Collection()
   {
      var fields = ((object) null).EnumerateFields().ToList();
      Assert.Empty(fields);
   }

   /// <summary>
   /// Validate that EnumerateFields enumerates public instance properties, inherited, when called with default parameters.
   /// </summary>
   [Theory]
   [InlineData(null)]
   [InlineData(BindingFlags.Public
             | BindingFlags.Instance
             | BindingFlags.Static
             | BindingFlags.FlattenHierarchy
             | BindingFlags.NonPublic
              )]
   public void EnumerateFields_On_Int32_With_BindingFlags_Returns_Empty_Collection(BindingFlags? flags)
   {
      var fields = typeof(int).EnumerateFields(flags).ToList();
      Assert.Empty(fields);
   }

   /// <summary>
   /// Validate that EnumerateFields enumerates public instance properties and skips according to skip function.
   /// </summary>
   [Fact]
   public void EnumerateFieldsOnType_WhenCalledWithDefaultParameters_EnumeratesPublicInstanceFieldsAndSkipsIndicated()
   {
      var fields = typeof(TestClassB).EnumerateFields(skip: pi => pi.Name == "Field1").ToList();
      Assert.Equal(2, fields.Count);
   }

   /// <summary>
   /// Validate that EnumerateFields Enumerates AllFields When BindingsSetToReturnAll, except private base class.
   /// </summary>
   [Fact]
   public void EnumerateFieldsOnType_WhenBindingsSetToReturnAll_EnumeratesAllFields()
   {
      var fields = typeof(TestClassB)
                  .EnumerateFields(BindingFlags.NonPublic
                                 | BindingFlags.Static
                                 | BindingFlags.Public
                                 | BindingFlags.Instance
                                 | BindingFlags.FlattenHierarchy
                                  )
                  .ToList();

      // 7 inheritable fields, plus 3 inheritable backing fields.
      Assert.Equal(10, fields.Count);
   }

   /// <summary>
   /// Validate that EnumerateFields Enumerates AllFields When BindingsSetToReturnAll, except private base class, skip
   /// backing fields.
   /// </summary>
   [Fact]
   public void EnumerateFieldsOnType_WhenBindingsSetToReturnAll_EnumeratesAllFieldsExceptBacking()
   {
      var fields = typeof(TestClassB)
                  .EnumerateFields(BindingFlags.NonPublic
                                 | BindingFlags.Static
                                 | BindingFlags.Public
                                 | BindingFlags.Instance
                                 | BindingFlags.FlattenHierarchy
                                 , fi => fi.Name[0] == '<'
                                  )
                  .ToList();
      Assert.Equal(7, fields.Count);
   }

   /// <summary>
   /// Validate that EnumerateFields enumerates public instance properties, inherited, when called with default parameters.
   /// </summary>
   [Fact]
   public void EnumerateFieldsOnObject_WhenCalledWithDefaultParameters_EnumeratesPublicInstanceFields()
   {
      var fields = new TestClassB().EnumerateFields().ToList();
      Assert.Equal(3, fields.Count);
   }

   /// <summary>
   /// Validate that EnumerateFields enumerates public instance properties and skips according to skip function.
   /// </summary>
   [Fact]
   public void
      EnumerateFieldsOnObject_WhenCalledWithDefaultParameters_EnumeratesPublicInstanceFieldsAndSkipsIndicated()
   {
      var fields = new TestClassB().EnumerateFields(skip: pi => pi.Name == "Field1").ToList();
      Assert.Equal(2, fields.Count);
   }

   /// <summary>
   /// Validate that EnumerateFields Enumerates AllFields When BindingsSetToReturnAll, except private base class.
   /// </summary>
   [Fact]
   public void EnumerateFieldsOnObject_WhenBindingsSetToReturnAll_EnumeratesAllFields()
   {
      var fields = new TestClassB().EnumerateFields(BindingFlags.NonPublic
                                                  | BindingFlags.Static
                                                  | BindingFlags.Public
                                                  | BindingFlags.Instance
                                                  | BindingFlags.FlattenHierarchy
                                                   )
                                   .ToList();

      // 7 inheritable fields, plus 3 inheritable backing fields.
      Assert.Equal(10, fields.Count);
   }

   /// <summary>
   /// Validate that EnumerateFields Enumerates AllFields When BindingsSetToReturnAll, except private base class, skip
   /// backing fields.
   /// </summary>
   [Fact]
   public void EnumerateFieldsOnObject_WhenBindingsSetToReturnAll_EnumeratesAllFieldsExceptBacking()
   {
      var fields = new TestClassB()
                  .EnumerateFields(BindingFlags.NonPublic
                                 | BindingFlags.Static
                                 | BindingFlags.Public
                                 | BindingFlags.Instance
                                 | BindingFlags.FlattenHierarchy
                                 , fi => fi.Name[0] == '<'
                                  )
                  .ToList();
      Assert.Equal(7, fields.Count);
   }

   /// <summary>
   /// Validate that IsScalar returns true when type is scalar.
   /// </summary>
   [Theory]
   [MemberData(nameof(ScalarDataProvider.AllScalars), MemberType = typeof(ScalarDataProvider))]
   public void IsScalar_WhenTypeIsScalar_ReturnsTrue(object value) { Assert.True(value.IsScalar()); }

   /// <summary>
   /// Validate that IsScalar returns false when type is not scalar.
   /// </summary>
   [Fact]
   public void IsScalar_WhenTypeIsNotScalar_ReturnsFalse() { Assert.False(new TestClassA().IsScalar()); }

   /// <summary>
   /// Validate that IsScalar returns true when type is not scalar but exists in a custom hashset claiming its scalar.
   /// </summary>
   [Fact]
   public void IsScalar_WhenTypeNotIsScalarButExistsAsCustomScalar_ReturnsTrue()
   {
      Assert.True(new TestClassA().IsScalar([typeof(TestClassA)]));

      // Idiot testing to ensure we didn't nuke the other scalar objects. Which might have been the case earlier. Okay it was the case.
      Assert.True(DateTime.Now.IsScalar([typeof(TestClassA)]));
   }

   /// <summary>
   /// Validate that GetPropertyOrFieldValue Returns the value When object has property or field with the name.
   /// </summary>
   [Fact]
   public void GetPropertyOrFieldValue_WhenObjectDoesntHavePropertyOrFieldWithTheName_ReturnsNull()
   {
      var kvp = new KeyValuePair<string, string>();
      _ = new { Key = "key", Value = "value", Pair = "Pear" };
      Assert.Null(kvp.GetValue("Nada"));
   }

   /// <summary>
   /// Validate that GetPropertyOrFieldValue Returns the value When object has property or field with the name.
   /// </summary>
   [Fact]
   public void GetPropertyOrFieldValue_WhenObjectHasPropertyOrFieldWithTheName_ReturnsValue()
   {
      var kvp = new { Key = "key", Value = "value", Pair = "Pear" };
      var val = kvp.GetValue("Key");
      Assert.NotNull(val);
      Assert.Equal(kvp.Key, val);
   }

   [Fact]
   public void IsScalar_When_Given_DataType_of_Type_Returns_True()
   {
      var t = typeof(Type);
      Assert.True(t.IsScalar());
   }

   [Fact]
   public void EnumerateProperties_On_Scalar_Returns_Null() { Assert.Null(1.EnumerateProperties()); }

   [Fact]
   public void EnumerateFields_On_Scalar_Returns_Null() { Assert.Null(1.EnumerateFields()); }

   [Fact]
   public void GetValue_Gets_A_Property()
   {
      var a = new TestClassA();
      var v = a.GetValue("Prop1");
      Assert.Equal(a.Prop1, v);
   }

   [Fact]
   public void GetValue_Gets_A_Field()
   {
      var a = new TestClassA();
      var v = a.GetValue("Field1");
      Assert.Equal(a.Field1, v);
   }

   [Fact]
   public void SetValue_Sets_A_Property()
   {
      var a = new TestClassA();
      a.SetValue("Prop1", 7);
      Assert.Equal(7, a.Prop1);
   }

   [Fact]
   public void SetValue_Sets_A_Field()
   {
      var a = new TestClassA();
      a.SetValue("Field1", 7);
      Assert.Equal(7, a.Field1);
   }

   [Fact]
   public void SetValue_Sets_A_Property_On_A_Struct()
   {
      var a = new TestStruct(10);
      a.SetValue("AProp", 7);
      Assert.Equal(7, a.AProp);
   }

   [Fact]
   public void SetValue_Sets_A_Field_On_A_Struct()
   {
      var a = new TestStruct(5);
      a.SetValue("afield", 7);
      Assert.Equal(7, a.GetValue("afield"));
   }
}