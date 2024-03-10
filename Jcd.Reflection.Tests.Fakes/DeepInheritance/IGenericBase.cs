namespace Jcd.Reflection.Tests.Fakes.DeepInheritance;

public interface IGenericBase<out T>
{
   T OtherData { get; }
}