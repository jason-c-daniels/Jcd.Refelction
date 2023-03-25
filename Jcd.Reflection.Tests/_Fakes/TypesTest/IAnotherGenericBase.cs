namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public interface IAnotherGenericBase<out T>
{
    T SomeOtherData { get; }
}