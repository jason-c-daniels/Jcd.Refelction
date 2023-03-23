#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Jcd.Reflection.Tests.TestHelpers;
using Xunit;

#endregion

namespace Jcd.Reflection.Tests;

public class ReflectionExtensionsTests
{
    /// <summary>
    /// Validate that EnumerateProperties enumerates public instance properties, inherited, when called with default parameters.
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
        var props = typeof(TestClassB).EnumerateProperties(BindingFlags.NonPublic | BindingFlags.Static |
                                                           BindingFlags.Public | BindingFlags.Instance |
                                                           BindingFlags.FlattenHierarchy).ToList();
        Assert.Equal(7, props.Count);
    }

    /// <summary>
    /// Validate that EnumerateProperties enumerates public instance properties, inherited, when called with default parameters.
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
        var props = new TestClassB().EnumerateProperties(BindingFlags.NonPublic | BindingFlags.Static |
                                                         BindingFlags.Public | BindingFlags.Instance |
                                                         BindingFlags.FlattenHierarchy).ToList();
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
        var fields = typeof(TestClassB).EnumerateFields(BindingFlags.NonPublic | BindingFlags.Static |
                                                        BindingFlags.Public | BindingFlags.Instance |
                                                        BindingFlags.FlattenHierarchy).ToList();
        // 7 inheritable fields, plus 3 inheritable backing fields.
        Assert.Equal(10, fields.Count);
    }

    /// <summary>
    /// Validate that EnumerateFields Enumerates AllFields When BindingsSetToReturnAll, except private base class, skip backing fields.
    /// </summary>
    [Fact]
    public void EnumerateFieldsOnType_WhenBindingsSetToReturnAll_EnumeratesAllFieldsExceptBacking()
    {
        var fields = typeof(TestClassB)
            .EnumerateFields(
                BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance |
                BindingFlags.FlattenHierarchy, fi => fi.Name[0] == '<').ToList();
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
        var fields = new TestClassB().EnumerateFields(BindingFlags.NonPublic | BindingFlags.Static |
                                                      BindingFlags.Public | BindingFlags.Instance |
                                                      BindingFlags.FlattenHierarchy).ToList();
        // 7 inheritable fields, plus 3 inheritable backing fields.
        Assert.Equal(10, fields.Count);
    }

    /// <summary>
    /// Validate that EnumerateFields Enumerates AllFields When BindingsSetToReturnAll, except private base class, skip backing fields.
    /// </summary>
    [Fact]
    public void EnumerateFieldsOnObject_WhenBindingsSetToReturnAll_EnumeratesAllFieldsExceptBacking()
    {
        var fields = new TestClassB()
            .EnumerateFields(
                BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance |
                BindingFlags.FlattenHierarchy, fi => fi.Name[0] == '<').ToList();
        Assert.Equal(7, fields.Count);
    }

    /// <summary>
    /// Validate that ToPropertyInfoEnumeration returns PropertyInfo enumeration when given an object with public properties. 
    /// </summary>
    [Fact]
    public void ToPropertyInfoValuePairs_WhenGivenAnObjectWithPublicProperties_ReturnsPropertyInfoAndValueEnumeration()
    {
        var a = new TestClassA();
        var d = a.GetType().EnumerateProperties().ToPropertyInfoValuePairs(a)
            .ToDictionary(k => k.Key.Name, v => v.Value);

        Assert.Equal(a.Prop1, d["Prop1"]);
        Assert.Equal(a.Prop2, d["Prop2"]);
    }

    /// <summary>
    /// Validate that ToPropertyInfoValuePairs Throws ArgumentNullException When item is null. 
    /// </summary>
    [Fact]
    public void ToPropertyInfoValuePairs_WhenItemIsNull_ThrowsArgumentNullException()
    {
        var a = new TestClassA();
        Assert.Throws<ArgumentNullException>(() =>
            a.GetType().EnumerateProperties().ToPropertyInfoValuePairs(null).ToList());
    }

    /// <summary>
    /// Validate that ToPropertyInfoValuePairs Throws ArgumentNullException When items is null. 
    /// </summary>
    [Fact]
    public void ToPropertyInfoValuePairs_WhenItemsIsNull_ThrowsArgumentNullException()
    {
        var a = new TestClassA();
        Assert.Throws<ArgumentNullException>(() => ExpandoObjectExtensions.ToPropertyInfoValuePairs(null, a).ToList());
        Assert.Throws<ArgumentNullException>(
            () => ExpandoObjectExtensions.ToPropertyInfoValuePairs(null, null).ToList());
    }

    /// <summary>
    /// Validate that ToFieldInfoEnumeration returns FieldInfo enumeration when given an object with public properties. 
    /// </summary>
    [Fact]
    public void ToFieldInfoValuePairs_WhenGivenAnObjectWithPublicFields_ReturnsFieldInfoAndValueEnumeration()
    {
        var a = new TestClassA();
        var d = a.GetType().EnumerateFields().ToFieldInfoValuePairs(a).ToDictionary(k => k.Key.Name, v => v.Value);

        Assert.Equal(a.Field1, d["Field1"]);
        Assert.Equal(a.Field2, d["Field2"]);
    }

    /// <summary>
    /// Validate that ToFieldInfoValuePairs Throws ArgumentNullException When item is null. 
    /// </summary>
    [Fact]
    public void ToFieldInfoValuePairs_WhenItemIsNull_ThrowsArgumentNullException()
    {
        var a = new TestClassA();
        Assert.Throws<ArgumentNullException>(() => a.GetType().EnumerateFields().ToFieldInfoValuePairs(null).ToList());
    }

    /// <summary>
    /// Validate that ToFieldInfoValuePairs Throws ArgumentNullException When items is null. 
    /// </summary>
    [Fact]
    public void ToFieldInfoValuePairs_WhenItemsIsNull_ThrowsArgumentNullException()
    {
        var a = new TestClassA();
        Assert.Throws<ArgumentNullException>(() => ExpandoObjectExtensions.ToFieldInfoValuePairs(null, a).ToList());
        Assert.Throws<ArgumentNullException>(() => ExpandoObjectExtensions.ToFieldInfoValuePairs(null, null).ToList());
    }

    /// <summary>
    /// Validate that ToNameValuePairs Throws ArgumentNullException When items is null. 
    /// </summary>
    [Fact]
    public void ToNameValuePairs_WhenItemsIsNull_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            ((IEnumerable<KeyValuePair<FieldInfo, object>>)null).ToNameValuePairs().ToList());
        Assert.Throws<ArgumentNullException>(() =>
            ((IEnumerable<KeyValuePair<PropertyInfo, object>>)null).ToNameValuePairs().ToList());
    }

    /// <summary>
    /// Validate that ToNameValuePairs returns IEnumerable of KeyValuePair of string and object when items is populated. 
    /// </summary>
    [Fact]
    public void ToNameValuePairs_WhenItemsIsPopulatedWithFields_ReturnsPopulatedKVPEnumeration()
    {
        var a = new TestClassB();
        var fields = typeof(TestClassB).EnumerateFields().ToFieldInfoValuePairs(a).ToNameValuePairs()
            .ToDictionary(k => k.Key, v => v.Value);
        Assert.Equal(a.Field1, fields["Field1"]);
        Assert.Equal(a.Field2, fields["Field2"]);
        Assert.Equal(a.Field6, fields["Field6"]);
    }

    /// <summary>
    /// Validate that ToNameValuePairs returns IEnumerable of KeyValuePair of string and object when items is populated. 
    /// </summary>
    [Fact]
    public void ToNameValuePairs_WhenItemsIsPopulatedWithProperties_ReturnsPopulatedKVPEnumeration()
    {
        var a = new TestClassB();
        var props = typeof(TestClassB).EnumerateProperties().ToPropertyInfoValuePairs(a).ToNameValuePairs()
            .ToDictionary(k => k.Key, v => v.Value);
        Assert.Equal(a.Field1, props["Prop1"]);
        Assert.Equal(a.Field2, props["Prop2"]);
    }

    /// <summary>
    /// Validate that IsScalar returns true when type is scalar.
    /// </summary>
    [Theory]
    [MemberData(nameof(ScalarDataProvider.AllScalars), MemberType = typeof(ScalarDataProvider))]
    public void IsScalar_WhenTypeIsScalar_ReturnsTrue(object value)
    {
        Assert.True(value.IsScalar());
    }

    /// <summary>
    /// Validate that IsScalar returns false when type is not scalar.
    /// </summary>
    [Fact]
    public void IsScalar_WhenTypeIsNotScalar_ReturnsFalse()
    {
        Assert.False(new TestClassA().IsScalar());
    }

    /// <summary>
    /// Validate that IsScalar returns true when type is not scalar but exists in a custom hashset claiming its scalar.
    /// </summary>
    [Fact]
    public void IsScalar_WhenTypeNotIsScalarButExistsAsCustomScalar_ReturnsTrue()
    {
        Assert.True(new TestClassA().IsScalar(new HashSet<Type>(new[] { typeof(TestClassA) })));
        // Idiot testing to ensure we didn't nuke the other scalar objects. Which might have been the case earlier. Okay it was the case.
        Assert.True(DateTime.Now.IsScalar(new HashSet<Type>(new[] { typeof(TestClassA) })));
    }

    /// <summary>
    /// Validate that IsKeyValuePair Returns False When object is not a KeyValuePair. 
    /// </summary>
    [Fact]
    public void IsKeyValuePair_WhenObjectIsNotAKeyValuePair_ReturnsFalse()
    {
        var kvp = new object();
        Assert.False(kvp.GetType().IsKeyValuePair());
    }

    /// <summary>
    /// Validate that IsKeyValuePair Returns False When object is not a KeyValuePair. 
    /// </summary>
    [Fact]
    public void IsKeyValuePair_WhenObjectIsAKeyValuePair_ReturnsTrue()
    {
        var kvp = new KeyValuePair<string, string>();
        var kvp2 = new { Key = "key", Value = "value", Pair = "Pear" };
        Assert.True(kvp.GetType().IsKeyValuePair());
        Assert.True(kvp2.GetType().IsKeyValuePair());
    }

    /// <summary>
    /// Validate that GetPropertyOrFieldValue Returns the value When object has property or field with the name. 
    /// </summary>
    [Fact]
    public void GetPropertyOrFieldValue_WhenObjectDoesntHavePropertyOrFieldWithTheName_ReturnsNull()
    {
        var kvp = new KeyValuePair<string, string>();
        var _ = new { Key = "key", Value = "value", Pair = "Pear" };
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
    public void ToExpando_Object_Returns_A_Dynamic_Object_With_Accessible_Properties()
    {
        var a = new TestClassC();
        dynamic aeo = a.ToExpandoObject();

        Assert.Equal(a.Field1, aeo.Field1);
        Assert.Equal(a.Field2, aeo.Field2);
        Assert.Equal(a.Prop1, aeo.Prop1);
        Assert.Equal(a.Prop2, aeo.Prop2);
        Assert.Equal(a.IntDict["Foo"], aeo.IntDict.Foo);
    }

    [Fact]
    public void ToDictionaryTree_And_ToExpando_Object_Perform_A_Compatible_RoundTrip()
    {
        var a = new TestClassA();

        dynamic aeo = a.ToExpandoObject();
        var ado = a.ToDictionaryTree();
        Assert.Equal(ado, aeo);
    }

    [Fact]
    public void ToDictionaryTree_Returns_A_String_Object_Dictionary_Tree_Of_The_Object_Without_The_PreVisited_Items()
    {
        //TODO: This is a bit of a hack, but it works. 
        //      Add more in depth tests later. 
        var a = new TestClassA();
        var visited = new HashSet<object>();
        visited.Add(a);
        dynamic aeo = a.ToExpandoObject(visited);
        var ado = a.ToDictionaryTree(visited);
        Assert.Equal(ado, aeo);
        // we expect null because the root was marked as visited
        Assert.Null(ado);
        Assert.Null(aeo);
    }

    [Fact]
    public void IsScalar_When_Given_DataType_of_Type_Returns_True()
    {
        var t = typeof(Type);
        Assert.True(t.IsScalar());
    }

    [Fact]
    public void EnumerateProperties_On_Scalar_Returns_Null()
    {
        Assert.Null(1.EnumerateProperties());
    }

    [Fact]
    public void EnumerateFields_On_Scalar_Returns_Null()
    {
        Assert.Null(1.EnumerateFields());
    }

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
        a.SetValue("_afield", 7);
        Assert.Equal(7, a.GetValue("_afield"));
    }
}