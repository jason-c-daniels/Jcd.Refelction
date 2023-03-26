### [Jcd.Reflection](Jcd.Reflection.md 'Jcd.Reflection')

## MethodExtensions Class

Extension methods to help invoke methods via reflection.

```csharp
public static class MethodExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MethodExtensions

| Fields | |
| :--- | :--- |
| [AllInstanceMethodsFilter](Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter.md 'Jcd.Reflection.MethodExtensions.AllInstanceMethodsFilter') | A pre-filter to select all, including inherited, instance methods. |
| [AllStaticMethodsFilter](Jcd.Reflection.MethodExtensions.AllStaticMethodsFilter.md 'Jcd.Reflection.MethodExtensions.AllStaticMethodsFilter') | A pre-filter to select all, including inherited, static methods. |
| [DirectInstanceMethodsFilter](Jcd.Reflection.MethodExtensions.DirectInstanceMethodsFilter.md 'Jcd.Reflection.MethodExtensions.DirectInstanceMethodsFilter') | A pre-filter to select all but inherited instance methods. |
| [DirectStaticMethodsFilter](Jcd.Reflection.MethodExtensions.DirectStaticMethodsFilter.md 'Jcd.Reflection.MethodExtensions.DirectStaticMethodsFilter') | A pre-filter to select all but inherited static methods. |

| Methods | |
| :--- | :--- |
| [FilterMethods(this object, Func&lt;MethodInfo,bool&gt;, Settings)](Jcd.Reflection.MethodExtensions.FilterMethods(thisobject,System.Func_System.Reflection.MethodInfo,bool_,Jcd.Reflection.MethodInfoEnumerator.Settings).md 'Jcd.Reflection.MethodExtensions.FilterMethods(this object, System.Func<System.Reflection.MethodInfo,bool>, Jcd.Reflection.MethodInfoEnumerator.Settings)') | Given a filter return an array of matching MethodInfo's |
| [FilterMethods(this object, Func&lt;MethodInfo,bool&gt;)](Jcd.Reflection.MethodExtensions.FilterMethods(thisobject,System.Func_System.Reflection.MethodInfo,bool_).md 'Jcd.Reflection.MethodExtensions.FilterMethods(this object, System.Func<System.Reflection.MethodInfo,bool>)') | Given a filter return an array of matching MethodInfo's |
| [GetMethod(this object, string, Settings)](Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings).md 'Jcd.Reflection.MethodExtensions.GetMethod(this object, string, Jcd.Reflection.MethodInfoEnumerator.Settings)') | Finds the first method by the provided name and returns its MethodInfo |
| [GetMethod(this object, string)](Jcd.Reflection.MethodExtensions.GetMethod(thisobject,string).md 'Jcd.Reflection.MethodExtensions.GetMethod(this object, string)') | Finds the first method by the provided name and returns its MethodInfo |
| [GetMethod(this Type, string, Settings)](Jcd.Reflection.MethodExtensions.GetMethod(thisSystem.Type,string,Jcd.Reflection.MethodInfoEnumerator.Settings).md 'Jcd.Reflection.MethodExtensions.GetMethod(this System.Type, string, Jcd.Reflection.MethodInfoEnumerator.Settings)') | Gets a methodInfo by name from a type. |
| [GetMethod(this Type, string)](Jcd.Reflection.MethodExtensions.GetMethod(thisSystem.Type,string).md 'Jcd.Reflection.MethodExtensions.GetMethod(this System.Type, string)') | Gets a methodInfo by name from a type. |
| [Invoke(this object, string, Settings, object[])](Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke(this object, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[])') | Invoke the method on the specified object using the provided parameters |
| [Invoke(this object, string, object[])](Jcd.Reflection.MethodExtensions.Invoke(thisobject,string,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke(this object, string, object[])') | Invoke the method on the specified object using the provided parameters |
| [Invoke(this object, MethodInfo, object[])](Jcd.Reflection.MethodExtensions.Invoke(thisobject,System.Reflection.MethodInfo,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke(this object, System.Reflection.MethodInfo, object[])') | Invoke the method on the specified object using the provided parameters |
| [Invoke(this Type, string, Settings, object[])](Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke(this System.Type, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[])') | Invokes a static method on a type |
| [Invoke(this Type, string, object[])](Jcd.Reflection.MethodExtensions.Invoke(thisSystem.Type,string,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke(this System.Type, string, object[])') | Invokes a static method on a type |
| [Invoke&lt;TOut&gt;(this object, string, Settings, object[])](Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisobject,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke<TOut>(this object, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[])') | Invoke the method on the specified object using the provided parameters |
| [Invoke&lt;TOut&gt;(this object, string, object[])](Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisobject,string,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke<TOut>(this object, string, object[])') | Invoke the method on the specified object using the provided parameters |
| [Invoke&lt;TOut&gt;(this object, MethodInfo, object[])](Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisobject,System.Reflection.MethodInfo,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke<TOut>(this object, System.Reflection.MethodInfo, object[])') | |
| [Invoke&lt;TOut&gt;(this Type, string, Settings, object[])](Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,Jcd.Reflection.MethodInfoEnumerator.Settings,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke<TOut>(this System.Type, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[])') | Invokes a static method on a type, coercing the return type |
| [Invoke&lt;TOut&gt;(this Type, string, object[])](Jcd.Reflection.MethodExtensions.Invoke_TOut_(thisSystem.Type,string,object[]).md 'Jcd.Reflection.MethodExtensions.Invoke<TOut>(this System.Type, string, object[])') | Invokes a static method on a type, coercing the return type |
