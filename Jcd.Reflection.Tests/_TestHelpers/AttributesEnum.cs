namespace Jcd.Reflection.Tests._TestHelpers;

[MyDescription("A test enumeration, mainly to be used for GetAttributesExtensions testing")]
[MyDescription("It's pretty banal otherwise.")]
public enum AttributesEnum
{
   // First doesn't get a description.
   First
 , [MyDescription("The description for Second")]
   Second

 , [MyDescription("The description for Third")] [MyDescription("Another description for Third")]
   Third
}