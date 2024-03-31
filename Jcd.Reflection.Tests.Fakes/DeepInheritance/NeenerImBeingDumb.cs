// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public class NeenerImBeingDumb<TY> : Int32ImplementsIGenericBase
{
   public TY Not;
   public TY Cob                 { get; set; }
   public TY GetCorn(TY cobbler) => Cob;
}