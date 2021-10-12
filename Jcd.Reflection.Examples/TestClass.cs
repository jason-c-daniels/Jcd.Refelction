// ReSharper disable ConvertToAutoPropertyWhenPossible
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedMember.Global
namespace Jcd.Reflection.Examples
{
    public class TestClass
    {
        private int _field=0;
        private int PrivateProperty { 
            get=>_field;
            set => _field = value;
        }
        private int InternalGetField() => _field;
        public int GetField() => InternalGetField();
    }
}