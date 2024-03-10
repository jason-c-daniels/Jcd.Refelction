// ReSharper disable ConvertToAutoProperty
// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection.Examples;

public struct TestStruct
{
   private int hidden;

   public TestStruct(int hidden) { this.hidden = hidden; }

   public int Revealed
   {
      get => hidden;
      set => hidden = value;
   }
}