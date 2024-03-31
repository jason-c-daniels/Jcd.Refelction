#region

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

// ReSharper disable HeapView.ObjectAllocation

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable ArrangeObjectCreationWhenTypeEvident
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBeMadeStatic.Local

#endregion

namespace Jcd.Reflection.Tests.Fakes;

[SuppressMessage("Performance", "CA1822:Mark members as static")]
internal class TestClassC : TestClassB
{
   public Dictionary<string, int> IntDict = new([
                                                   new KeyValuePair<string, int>("Foo", 2)
                                                 , new KeyValuePair<string, int>("Bar", 3)
                                                 , new KeyValuePair<string, int>("Cat", 4)
                                                ]
                                               );

   public List<int> IntList = [1, 2, 3, 4, 5];

   public int ExceptionalProperty
   {
      get => throw new InvalidOperationException();
      set => throw new InvalidOperationException();
   }

   public int Add(int a, int b) { return op_Add(a, b); }

   #pragma warning disable CA1822

   // this is actually called as a member via reflection in a unit test.
   // compiler warning needs to be disabled for it as a result. 
   private int op_Add(int a, int b) { return a + b; }
   #pragma warning restore CA1822

   public static int Sub(int a, int b) { return op_Sub(a, b); }

   private static int op_Sub(int a, int b) { return a - b; }

   public int GetValue() { return 10; }
}