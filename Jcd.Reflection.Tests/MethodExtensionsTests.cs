#region

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
      result = new TestClassC().Invoke("GetValue", null);
      Assert.Equal(10, result);
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
      var result = typeof(TestClassC).Invoke<int>("Sub"
                                                , new MethodInfoFilter
                                                  {
                                                     Flags = BindingFlags.Static
                                                           | BindingFlags.Public
                                                           | BindingFlags.NonPublic
                                                  }
                                                , 7
                                                , 4
                                                 );
      Assert.Equal(3, result);
   }

   [Fact]
   public void Invoke_On_Instance_Executes_Method_With_Result4()
   {
      var result = typeof(TestClassC).Invoke("Sub"
                                           , new MethodInfoFilter
                                             {
                                                Flags = BindingFlags.Static
                                                      | BindingFlags.Public
                                                      | BindingFlags.NonPublic
                                             }
                                           , 7
                                           , 4
                                            );
      Assert.Equal(3, result);
   }

   [Fact]
   public void Invoke_On_Instance_Executes_Method_With_Result5()
   {
      var result = new TestClassC().Invoke<int>("GetValue");
      Assert.Equal(10, result);
      result = new TestClassC().Invoke<int>("GetValue", null);
      Assert.Equal(10, result);
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
      result = MethodExtensions.GetMethod(typeof(TestClassC), "NotMyMethod");
      Assert.Null(result);
      var o = new TestClassC();
      result = o.GetMethod("NotMyMethod");
      Assert.Null(result);
      var results = o.GetMethods(x => x.Name == "NotMyMethod");
      Assert.Empty(results);
      results = o.GetMethods(MethodInfoFilter.AllInstanceMethodsFilter, x => x.Name == "NotMyMethod");
      Assert.Empty(results);
   }
}