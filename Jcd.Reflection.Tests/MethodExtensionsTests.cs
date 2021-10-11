using Xunit;

namespace Jcd.Reflection.Tests
{
    public class MethodExtensionsTests
    {
        [Fact]
        public void Invoke_On_Type_Executes_Private_Method_With_Result()
        {
            var result = typeof(TestClassC).Invoke("op_Sub", 7, 4);
            Assert.Equal(3,result);
        }
        
        [Fact]
        public void Invoke_On_Type_Executes_Private_Method_With_Result2()
        {
            var result = typeof(TestClassC).Invoke<int>("op_Sub", 7, 4);
            Assert.Equal(3,result);
        }
        
        [Fact]
        public void Invoke_On_Type_Executes_Method_With_Result()
        {
            var result = typeof(TestClassC).Invoke("Sub", 7, 4);
            Assert.Equal(3,result);
        }
        
        [Fact]
        public void Invoke_On_Type_Executes_Method_With_Result2()
        {
            var result = typeof(TestClassC).Invoke<int>("Sub", 7, 4);
            Assert.Equal(3,result);
        }
        
        [Fact]
        public void Invoke_On_Instance_Executes_Private_Method_With_Result()
        {
            var result = new TestClassC().Invoke("op_Add", 7, 4);
            Assert.Equal(11,result);
        }
        
        [Fact]
        public void Invoke_On_Instance_Executes_Private_Method_With_Result2()
        {
            var result = new TestClassC().Invoke<int>("op_Add", 7, 4);
            Assert.Equal(11,result);
        }
        
        [Fact]
        public void Invoke_On_Instance_Executes_Method_With_Result()
        {
            var result = new TestClassC().Invoke("Add", 7, 4);
            Assert.Equal(11,result);
        }

        [Fact]
        public void Invoke_On_Instance_Executes_Method_With_Result2()
        {
            var result = new TestClassC().Invoke<int>("Add", 7, 4);
            Assert.Equal(11,result);
        }
    }
}