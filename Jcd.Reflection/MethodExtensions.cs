#region

using System;
using System.Linq;
using System.Reflection;

using Jcd.Validations;

// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable HeapView.DelegateAllocation

#endregion

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ConvertIfStatementToNullCoalescingAssignment
// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection;

/// <summary>
/// Extension methods to help invoke methods via reflection.
/// </summary>
public static class MethodExtensions
{
    /// <summary>
    /// A pre-filter to select all, including inherited, instance methods.
    /// </summary>
    public static readonly MethodInfoEnumerator.Settings AllInstanceMethodsFilter =
        new()
        {
            Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public |
                    BindingFlags.FlattenHierarchy
        };

    /// <summary>
    /// A pre-filter to select all, including inherited, static methods.
    /// </summary>
    public static readonly MethodInfoEnumerator.Settings AllStaticMethodsFilter =
        new()
        {
            Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public |
                    BindingFlags.FlattenHierarchy
        };

    /// <summary>
    /// A pre-filter to select all but inherited instance methods.
    /// </summary>
    public static readonly MethodInfoEnumerator.Settings DirectInstanceMethodsFilter =
        new()
        {
            Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public |
                    BindingFlags.FlattenHierarchy
        };

    /// <summary>
    /// A pre-filter to select all but inherited static methods.
    /// </summary>
    public static readonly MethodInfoEnumerator.Settings DirectStaticMethodsFilter =
        new()
        {
            Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public |
                    BindingFlags.FlattenHierarchy
        };

    /// <summary>
    /// Finds the first method by the provided name and returns its MethodInfo
    /// </summary>
    /// <param name="self">The instance to find the method on</param>
    /// <param name="name">the method name.</param>
    /// <returns>null if none found</returns>
    public static MethodInfo GetMethod(this object self, string name)
    {
        return GetMethod(self, name, AllInstanceMethodsFilter);
    }

    /// <summary>
    /// Finds the first method by the provided name and returns its MethodInfo
    /// </summary>
    /// <param name="self">The instance to find the method on</param>
    /// <param name="name">the method name.</param>
    /// <param name="settings">settings that control method selection. <see cref="AllInstanceMethodsFilter"/> </param>
    /// <returns>null if none found</returns>
    public static MethodInfo GetMethod(this object                   self, string name,
                                       MethodInfoEnumerator.Settings settings)
    {
        Argument.IsNotNull(self, nameof(self));
        var type = self.GetType();
        return type.GetMethod(name, settings);
    }

    /// <summary>
    /// Gets a methodInfo by name from a type. 
    /// </summary>
    /// <param name="type">the type to interrogate</param>
    /// <param name="name">the name of the method</param>
    /// <returns>the result of the call, if any</returns>
    public static MethodInfo GetMethod(this Type type, string name)
    {
        Argument.IsNotNull(type, nameof(type));
        return type.GetMethod(name, AllStaticMethodsFilter);
    }

    /// <summary>
    /// Gets a methodInfo by name from a type. 
    /// </summary>
    /// <param name="type">the type to interrogate</param>
    /// <param name="name">the name of the method</param>
    /// <param name="settings"></param>
    /// <returns>the result of the call, if any</returns>
    public static MethodInfo GetMethod(this Type type, string name, MethodInfoEnumerator.Settings settings)
    {
        Argument.IsNotNull(type, nameof(type));
        return new MethodInfoEnumerator(type, settings).FirstOrDefault(mi => mi.Name == name);
    }

    /// <summary>
    /// Given a filter return an array of matching MethodInfo's
    /// </summary>
    /// <param name="self">The target object of the method selection.</param>
    /// <param name="filter">a predicate to select or exclude specific methods.</param>
    /// <returns>an array of matching methods</returns>
    public static MethodInfo[] GetMethods(this object self, Func<MethodInfo, bool> filter = null)
    {
       return GetMethods(self, AllInstanceMethodsFilter, filter);
    }

    /// <summary>
    /// Given a filter return an array of matching MethodInfo's
    /// </summary>
    /// <param name="self">The target object of the method selection.</param>
    /// <param name="settings">The method selection settings such as <see cref="AllInstanceMethodsFilter"/></param>
    /// <param name="filter">a predicate to select or exclude specific methods.</param>
    /// <returns>an array of matching methods</returns>
    public static MethodInfo[] GetMethods(
       this object                   self
     , MethodInfoEnumerator.Settings settings
     , Func<MethodInfo, bool>        filter = null
    )
    {
        Argument.IsNotNull(self, nameof(self));
        return new MethodInfoEnumerator(self.GetType(), settings).Where(mi => filter == null || filter(mi))
            .ToArray();
    }

    /// <summary>
    /// Invoke the method on the specified object using the provided parameters
    /// </summary>
    /// <param name="self">The instance to invoke the method on</param>
    /// <param name="methodInfo">the method to invoke</param>
    /// <param name="params">the params for the method</param>
    /// <returns>the result, if any</returns>
    public static object Invoke(this object self, MethodInfo methodInfo, params object[] @params)
    {
        Argument.IsNotNull(self, nameof(self));
        if (@params == null) @params = new object[] { };
        return methodInfo.Invoke(self, @params);
    }

    /// <summary>
    /// Invoke the method on the specified object using the provided parameters
    /// </summary>
    /// <param name="self">The instance to invoke the method on</param>
    /// <param name="name">the name of the method to invoke</param>
    /// <param name="settings">The method selection settings such as <see cref="AllInstanceMethodsFilter"/></param>
    /// <param name="params">the params for the method</param>
    /// <returns>the result, if any</returns>
    public static object Invoke(this object                   self, string name,
                                MethodInfoEnumerator.Settings settings,
                                params object[]               @params)
    {
        Argument.IsNotNull(self, nameof(self));
        return self.Invoke(self.GetMethod(name, settings), @params);
    }

    /// <summary>
    /// Invoke the method on the specified object using the provided parameters
    /// </summary>
    /// <param name="self">The instance to invoke the method on</param>
    /// <param name="name">the name of the method to invoke</param>
    /// <param name="params">the params for the method</param>
    /// <returns>the result, if any</returns>
    public static object Invoke(this object self, string name,
                                params object[] @params)
    {
        Argument.IsNotNull(self, nameof(self));
        return self.Invoke(name, AllInstanceMethodsFilter, @params);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <param name="methodInfo"></param>
    /// <param name="params"></param>
    /// <typeparam name="TOut"></typeparam>
    /// <returns></returns>
    public static TOut Invoke<TOut>(this object self, MethodInfo methodInfo, params object[] @params)
    {
        Argument.IsNotNull(self, nameof(self));
        if (@params == null) @params = new object[] { };
        return (TOut)methodInfo.Invoke(self, @params);
    }

    /// <summary>
    /// Invoke the method on the specified object using the provided parameters
    /// </summary>
    /// <param name="self">The instance to invoke the method on</param>
    /// <param name="name">the name of the method to invoke</param>
    /// <param name="settings">The method selection settings such as <see cref="AllInstanceMethodsFilter"/></param>
    /// <param name="params">the params for the method</param>
    /// <returns>the result, if any</returns>
    /// <typeparam name="TOut">result type</typeparam>
    public static TOut Invoke<TOut>(this   object   self, string name, MethodInfoEnumerator.Settings settings,
                                    params object[] @params)
    {
        Argument.IsNotNull(self, nameof(self));
        return self.Invoke<TOut>(self.GetMethod(name, settings), @params);
    }

    /// <summary>
    /// Invoke the method on the specified object using the provided parameters
    /// </summary>
    /// <param name="self">The instance to invoke the method on</param>
    /// <param name="name">the name of the method to invoke</param>
    /// <param name="params">the params for the method</param>
    /// <returns>the result, if any</returns>
    /// <typeparam name="TOut">result type</typeparam>
    public static TOut Invoke<TOut>(this object self, string name, params object[] @params)
    {
        Argument.IsNotNull(self, nameof(self));
        return self.Invoke<TOut>(name, AllInstanceMethodsFilter, @params);
    }

    /// <summary>
    /// Invokes a static method on a type 
    /// </summary>
    /// <param name="type">The type containing the static method</param>
    /// <param name="name">The name of the method</param>
    /// <param name="params">The params to pass</param>
    /// <returns>The result of the call, if any</returns>
    public static object Invoke(this Type type, string name, params object[] @params)
    {
        return type.GetMethod(name, AllStaticMethodsFilter).Invoke(type, @params);
    }

    /// <summary>
    /// Invokes a static method on a type 
    /// </summary>
    /// <param name="type">The type containing the static method</param>
    /// <param name="name">The name of the method</param>
    /// <param name="params">The params to pass</param>
    /// <param name="settings">The method selection settings such as <see cref="AllStaticMethodsFilter"/></param>
    /// <returns>The result of the call, if any</returns>
    public static object Invoke(this   Type     type, string name, MethodInfoEnumerator.Settings settings,
                                params object[] @params)
    {
        return type.GetMethod(name, settings).Invoke(type, @params);
    }

    /// <summary>
    /// Invokes a static method on a type, coercing the return type 
    /// </summary>
    /// <param name="type">The type containing the static method</param>
    /// <param name="name">The name of the method</param>
    /// <param name="params">The params to pass</param>
    /// <typeparam name="TOut">The type of the return</typeparam>
    /// <returns>The result of the call, if any</returns>
    public static TOut Invoke<TOut>(this Type type, string name, params object[] @params)
    {
        return (TOut)type.GetMethod(name, AllStaticMethodsFilter).Invoke(type, @params);
    }

    /// <summary>
    /// Invokes a static method on a type, coercing the return type 
    /// </summary>
    /// <param name="type">The type containing the static method</param>
    /// <param name="name">The name of the method</param>
    /// <param name="params">The params to pass</param>
    /// <param name="settings">The method selection settings such as <see cref="AllStaticMethodsFilter"/></param>
    /// <typeparam name="TOut">The type of the return</typeparam>
    /// <returns>The result of the call, if any</returns>
    public static TOut Invoke<TOut>(this   Type     type, string name, MethodInfoEnumerator.Settings settings,
                                    params object[] @params)
    {
        return (TOut)type.GetMethod(name, settings).Invoke(type, @params);
    }
}