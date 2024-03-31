// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToAutoProperty
// ReSharper disable UnusedMember.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable IdentifierTypo
// ReSharper disable ReplaceWithPrimaryConstructorParameter

namespace Jcd.Reflection.Tests.Fakes;

public struct TestStruct(int vfield, int aProp = 0)
{
   private int afield = vfield;
   public  int AProp { get; set; } = aProp;

   private int AFieldAccessor
   {
      get => afield;
      set => afield = value;
   }
}