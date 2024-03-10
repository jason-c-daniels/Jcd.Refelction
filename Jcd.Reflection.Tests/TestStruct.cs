// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToAutoProperty
// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection.Tests;

public struct TestStruct
{
   private int afield;

   public int AProp { get; set; }

   private int AFieldAccessor
   {
      get => afield;
      set => afield = value;
   }

   public TestStruct(int afield, int aProp = 0)
   {
      this.afield = afield;
      AProp       = aProp;
   }
}