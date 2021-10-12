// ReSharper disable ConvertToAutoProperty
// ReSharper disable UnusedMember.Global
namespace Jcd.Reflection.Examples
{
    public struct TestStruct
    {
        private int _hidden;

        public TestStruct(int hidden)
        {
            _hidden = hidden;
        }
        
        public int Revealed
        {
            get => _hidden;
            set => _hidden = value;
        }
    }
}