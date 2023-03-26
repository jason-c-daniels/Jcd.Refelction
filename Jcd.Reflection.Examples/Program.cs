#region

using System;

// ReSharper disable HeapView.BoxingAllocation

#endregion

namespace Jcd.Reflection.Examples;

internal static class Program
{
    private static void Main()
    {
        var c = new TestClass();
        // set the private field, _field
        c.SetValue("_field", 10);

        // now get its value.
        var val = (int)c.GetValue("_field");
        Console.WriteLine(val);

        // Now set a private property with a backing field.
        c.SetValue("PrivateProperty", 20);

        // Now call a private helper method that returns the value from the backing field. 
        val = c.Invoke<int>("InternalGetField");
        Console.WriteLine(val);

        var s = new TestStruct(15);
        val = (int)s.GetValue("_hidden");
        Console.WriteLine(val);
        s.SetValue("_hidden", 17);
        Console.WriteLine(s.Revealed);

        var r = new TestRecord(10, "foo");
        val = (int)r.GetValue("Prop1");
        Console.WriteLine(val);
        r.SetValue("Prop2", "foo2");
        Console.WriteLine(r.Prop2);
    }
}