namespace Jcd.Reflection.Tests._Fakes.TypesTest;

public abstract class AbstractDerived<T> : AbstractGenericBase<T>
{
   public abstract string Name { get; }
}