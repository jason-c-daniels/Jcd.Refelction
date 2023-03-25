namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public interface IGenericBase<out T>
{
    T OtherData { get; }
}