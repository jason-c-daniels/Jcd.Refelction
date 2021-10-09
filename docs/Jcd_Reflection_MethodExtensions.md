### [Jcd.Reflection](Jcd_Reflection.md 'Jcd.Reflection')
## MethodExtensions Class
Extension methods to help invoke methods via reflection.  
```csharp
public static class MethodExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MethodExtensions  

| Methods | |
| :--- | :--- |
| [FilterMethods(object, Func&lt;MethodInfo,bool&gt;, Settings)](Jcd_Reflection_MethodExtensions_FilterMethods(object_System_Func_System_Reflection_MethodInfo_bool__Jcd_Reflection_MethodInfoEnumerator_Settings).md 'Jcd.Reflection.MethodExtensions.FilterMethods(object, System.Func&lt;System.Reflection.MethodInfo,bool&gt;, Jcd.Reflection.MethodInfoEnumerator.Settings)') | Given a filter return an array of matching MethodInfo's<br/> |
| [FilterMethods(object, Func&lt;MethodInfo,bool&gt;)](Jcd_Reflection_MethodExtensions_FilterMethods(object_System_Func_System_Reflection_MethodInfo_bool_).md 'Jcd.Reflection.MethodExtensions.FilterMethods(object, System.Func&lt;System.Reflection.MethodInfo,bool&gt;)') | Given a filter return an array of matching MethodInfo's<br/> |
| [GetMethod(object, string, Settings)](Jcd_Reflection_MethodExtensions_GetMethod(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings).md 'Jcd.Reflection.MethodExtensions.GetMethod(object, string, Jcd.Reflection.MethodInfoEnumerator.Settings)') | Finds the first method by the provided name and returns its MethodInfo<br/> |
| [GetMethod(object, string)](Jcd_Reflection_MethodExtensions_GetMethod(object_string).md 'Jcd.Reflection.MethodExtensions.GetMethod(object, string)') | Finds the first method by the provided name and returns its MethodInfo<br/> |
| [Invoke(object, string, Settings, object[])](Jcd_Reflection_MethodExtensions_Invoke(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__).md 'Jcd.Reflection.MethodExtensions.Invoke(object, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[])') | Invoke the method on the specified object using the provided parameters<br/> |
| [Invoke(object, string, object[])](Jcd_Reflection_MethodExtensions_Invoke(object_string_object__).md 'Jcd.Reflection.MethodExtensions.Invoke(object, string, object[])') | Invoke the method on the specified object using the provided parameters<br/> |
| [Invoke(object, MethodInfo, object[])](Jcd_Reflection_MethodExtensions_Invoke(object_System_Reflection_MethodInfo_object__).md 'Jcd.Reflection.MethodExtensions.Invoke(object, System.Reflection.MethodInfo, object[])') | Invoke the method on the specified object using the provided parameters<br/> |
| [Invoke(Type, string, Settings, object[])](Jcd_Reflection_MethodExtensions_Invoke(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__).md 'Jcd.Reflection.MethodExtensions.Invoke(System.Type, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[])') | Invokes a static method on a type <br/> |
| [Invoke(Type, string, object[])](Jcd_Reflection_MethodExtensions_Invoke(System_Type_string_object__).md 'Jcd.Reflection.MethodExtensions.Invoke(System.Type, string, object[])') | Invokes a static method on a type <br/> |
| [Invoke&lt;TOut&gt;(object, string, Settings, object[])](Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__).md 'Jcd.Reflection.MethodExtensions.Invoke&lt;TOut&gt;(object, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[])') | Invoke the method on the specified object using the provided parameters<br/> |
| [Invoke&lt;TOut&gt;(object, string, object[])](Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_string_object__).md 'Jcd.Reflection.MethodExtensions.Invoke&lt;TOut&gt;(object, string, object[])') | Invoke the method on the specified object using the provided parameters<br/> |
| [Invoke&lt;TOut&gt;(object, MethodInfo, object[])](Jcd_Reflection_MethodExtensions_Invoke_TOut_(object_System_Reflection_MethodInfo_object__).md 'Jcd.Reflection.MethodExtensions.Invoke&lt;TOut&gt;(object, System.Reflection.MethodInfo, object[])') |  |
| [Invoke&lt;TOut&gt;(Type, string, Settings, object[])](Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_Jcd_Reflection_MethodInfoEnumerator_Settings_object__).md 'Jcd.Reflection.MethodExtensions.Invoke&lt;TOut&gt;(System.Type, string, Jcd.Reflection.MethodInfoEnumerator.Settings, object[])') | Invokes a static method on a type, coercing the return type <br/> |
| [Invoke&lt;TOut&gt;(Type, string, object[])](Jcd_Reflection_MethodExtensions_Invoke_TOut_(System_Type_string_object__).md 'Jcd.Reflection.MethodExtensions.Invoke&lt;TOut&gt;(System.Type, string, object[])') | Invokes a static method on a type, coercing the return type <br/> |
