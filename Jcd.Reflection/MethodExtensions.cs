using System;
using System.Linq;
using System.Reflection;
using Jcd.Validations;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ConvertIfStatementToNullCoalescingAssignment
// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection
{
    /// <summary>
    /// Extension methods to help invoke methods via reflection.
    /// </summary>
    public static class MethodExtensions
    {
        /// <summary>
        /// Finds the first method by the provided name and returns its MethodInfo
        /// </summary>
        /// <param name="self"></param>
        /// <param name="name"></param>
        /// <returns>null if none found</returns>
        public static MethodInfo GetMethod(this object self, string name)
        {
            return GetMethod(self, name, new MethodInfoEnumerator.Settings
                {
                    Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public 
                });
        }

        /// <summary>
        /// Finds the first method by the provided name and returns its MethodInfo
        /// </summary>
        /// <param name="self"></param>
        /// <param name="name"></param>
        /// <param name="settings"></param>
        /// <returns>null if none found</returns>
        public static MethodInfo GetMethod(this object self, string name,
                                                MethodInfoEnumerator.Settings settings)
        {
            Argument.IsNotNull(self,nameof(self));
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
            Argument.IsNotNull(type,nameof(type));
            return type.GetMethod(name, new MethodInfoEnumerator.Settings { Flags = BindingFlags.Static });
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
            Argument.IsNotNull(type,nameof(type));
            return new MethodInfoEnumerator(type, settings).FirstOrDefault(mi => mi.Name == name);
        }

        /// <summary>
        /// Given a filter return an array of matching MethodInfo's
        /// </summary>
        /// <param name="self"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static MethodInfo[] FilterMethods(this object self, Func<MethodInfo, bool> filter)
        {
            return FilterMethods(self, filter, new MethodInfoEnumerator.Settings
            {
                Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public 
            });
        }

        /// <summary>
        /// Given a filter return an array of matching MethodInfo's
        /// </summary>
        /// <param name="self"></param>
        /// <param name="filter"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static MethodInfo[] FilterMethods(this object self, Func<MethodInfo, bool> filter,
                                                    MethodInfoEnumerator.Settings settings)
        {
            Argument.IsNotNull(self,"self");
            return new MethodInfoEnumerator(self.GetType(), settings).Where(mi=> filter==null || filter(mi)).ToArray();
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
            Argument.IsNotNull(self,"self");
            if (@params == null) @params = new object[] { };
            return methodInfo.Invoke(self, @params);
        }

        /// <summary>
        /// Invoke the method on the specified object using the provided parameters
        /// </summary>
        /// <param name="self">The instance to invoke the method on</param>
        /// <param name="name">the name of the method to invoke</param>
        /// <param name="settings">binding flags and skip predicate</param>
        /// <param name="params">the params for the method</param>
        /// <returns>the result, if any</returns>
        public static object Invoke(this object self, string name,
                                          MethodInfoEnumerator.Settings settings,
                                          params object[] @params)
        {
            Argument.IsNotNull(self,"self");
            return self.Invoke(self.GetMethod(name, settings),@params);
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
            Argument.IsNotNull(self,"self");
            return self.Invoke(name, new MethodInfoEnumerator.Settings{Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public },@params);
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
            Argument.IsNotNull(self,"self");
            if (@params == null) @params = new object[] { };
            return (TOut) methodInfo.Invoke(self, @params);
        }

        /// <summary>
        /// Invoke the method on the specified object using the provided parameters
        /// </summary>
        /// <param name="self">The instance to invoke the method on</param>
        /// <param name="name">the name of the method to invoke</param>
        /// <param name="settings">binding flags and skip predicate</param>
        /// <param name="params">the params for the method</param>
        /// <returns>the result, if any</returns>
        /// <typeparam name="TOut">result type</typeparam>
        public static TOut Invoke<TOut>(this object self, string name,
                                              MethodInfoEnumerator.Settings settings,
                                              params object[] @params)
        {
            Argument.IsNotNull(self,"self");
            return self.Invoke<TOut>(self.GetMethod(name, settings),@params);
        }

        /// <summary>
        /// Invoke the method on the specified object using the provided parameters
        /// </summary>
        /// <param name="self">The instance to invoke the method on</param>
        /// <param name="name">the name of the method to invoke</param>
        /// <param name="params">the params for the method</param>
        /// <returns>the result, if any</returns>
        /// <typeparam name="TOut">result type</typeparam>
        public static TOut Invoke<TOut>(this object self, string name,
                                        params object[] @params)
        {
            Argument.IsNotNull(self,"self");
            return self.Invoke<TOut>(name, new MethodInfoEnumerator.Settings{Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public },@params);
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
            return type.GetMethod(name, new MethodInfoEnumerator.Settings {Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public }).Invoke(type,@params);
        }
        
        /// <summary>
        /// Invokes a static method on a type 
        /// </summary>
        /// <param name="type">The type containing the static method</param>
        /// <param name="name">The name of the method</param>
        /// <param name="params">The params to pass</param>
        /// <param name="settings">Thee settings such as BindingFlags</param>
        /// <returns>The result of the call, if any</returns>
        public static object Invoke(this Type type, string name, MethodInfoEnumerator.Settings settings, params object[] @params)
        {
            return type.GetMethod(name, settings).Invoke(type,@params);
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
            return (TOut)type.GetMethod(name, new MethodInfoEnumerator.Settings {Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public }).Invoke(type,@params);
        }
        
        /// <summary>
        /// Invokes a static method on a type, coercing the return type 
        /// </summary>
        /// <param name="type">The type containing the static method</param>
        /// <param name="name">The name of the method</param>
        /// <param name="params">The params to pass</param>
        /// <param name="settings">The settings such as binding flags</param>
        /// <typeparam name="TOut">The type of the return</typeparam>
        /// <returns>The result of the call, if any</returns>
        public static TOut Invoke<TOut>(this Type type, string name, MethodInfoEnumerator.Settings settings, params object[] @params)
        {
            return (TOut)type.GetMethod(name, settings).Invoke(type,@params);
        }
    }
}