using System;
using System.Linq;
using System.Reflection;
// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Reflection
{
    /// <summary>
    /// Various extension methods that assist in getting custom attributes of a specified type.
    /// </summary>
    public static class GetCustomAttributesExtensions
    {
        /// <summary>
        /// Gets all attributes of a specified type on an enum value
        /// </summary>
        /// <param name="value">the enum value to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this Enum value, bool inherit=false) 
            where TAttribute: Attribute
        {
            var type = value.GetType();
            var memberInfos = type.GetMember(Enum.GetName(type, value) ?? value.ToString()).FirstOrDefault();
            var attributes = memberInfos?.GetCustomAttributes<TAttribute>(inherit).ToArray();
            if (attributes is null || !attributes.Any()) return Array.Empty<TAttribute>();
            return attributes;
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a FieldInfo
        /// </summary>
        /// <param name="fieldInfo">the field to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this FieldInfo fieldInfo, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=fieldInfo.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                   select (TAttribute)attribute).ToArray();
        }

        /// <summary>
        /// Gets all attributes of a specified type on a PropertyInfo
        /// </summary>
        /// <param name="propertyInfo">the property to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this PropertyInfo propertyInfo, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=propertyInfo.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a MethodInfo
        /// </summary>
        /// <param name="methodInfo">the method to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this MethodInfo methodInfo, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=methodInfo.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a type
        /// </summary>
        /// <param name="type">the type to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this Type type, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=type.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a parameter
        /// </summary>
        /// <param name="paramInfo">the parameter to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this ParameterInfo paramInfo, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=paramInfo.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a module
        /// </summary>
        /// <param name="module">the module to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this Module module, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=module.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a TypeInfo
        /// </summary>
        /// <param name="typeInfo">the typeInfo to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this TypeInfo typeInfo, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=typeInfo.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on an assembly
        /// </summary>
        /// <param name="assembly">the assembly to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this Assembly assembly, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=assembly.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a parameter
        /// </summary>
        /// <param name="eventInfo">the eventINfo to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this EventInfo eventInfo, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=eventInfo.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a MemberInfo
        /// </summary>
        /// <param name="memberInfo">the MemberInfo to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An enumerable </returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this MemberInfo memberInfo, bool inherit=false)
            where TAttribute: Attribute
        {
            var attributes=memberInfo.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }
    }
}