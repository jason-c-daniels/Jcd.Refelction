// ReSharper disable ConvertToAutoPropertyWhenPossible
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedMember.Global

#region

using System;
using Jcd.Reflection.Tests.TestHelpers;

#endregion

// ReSharper disable EventNeverSubscribedTo.Global

[assembly: MyDescription("A cool assembly you really should check out sometime.")]
[assembly: MyDescription("It's the best ever!")]
[assembly: MyDescription("You'll love it!")]

[module: MyDescription("This module is a great example of something! I'm not sure what tho.")]

namespace Jcd.Reflection.Tests.TestHelpers;

[MyDescription("A Test Class")]
[MyDescription("A useful Class")]
public class AttributesReflectionTestClass
{
    [MyDescription("A useful field")] [MyDescription("No you don't get to know what it's used for.")]
    private int _field;
    #pragma warning disable 169
    // this warning doesn't apply to this, because there is no point in actually
    // using this field. It's here to be a target of reflection, not to be useful. 
    private double _unusedWithNoDescription;
    #pragma warning restore 169

    [MyDescription("Nobody else should access this!")]
    [MyDescription("It's mine all mine!")]
    private int PrivateProperty
    {
        get => _field;
        set => _field = value;
    }

    [MyDescription("A helper method that only I know about.")]
    private int InternalGetField()
    {
        return _field;
    }

    [MyDescription("This is how the world gets to know about the value of _field")]
    [MyDescription("The world isn't ready to do it any other way")]
    public int GetField()
    {
        return InternalGetField();
    }

    #pragma warning disable CA1822
    public void DoSomething([MyDescription("A param")] string param1, int param2)
    {
        // Nope. We're doing nothing.
    }
    #pragma warning restore CA1822

    #pragma warning disable 67
    // disabling event not used as these are here to test reflection.
    [MyDescription("The event is a lie!")]
    [MyDescription("Do not trust the event.")]
    [MyDescription("It will mislead you.")]
    public event EventHandler DidIt;

    // only trust this event.
    public event EventHandler NothingWasDone;
    #pragma warning restore 67
}