#region

using System;
using System.Linq;
using System.Reflection;

#endregion

// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Reflection
{
    /// <summary>
    /// Various extension methods that assist in getting custom attributes of a specified type.
    /// </summary>
    public static class CustomAttributeHandlingExtensions
    {
        #region GetCustomAttributes Overloads
        
        /// <summary>
        /// Gets all attributes of a specified type on an enum value
        /// </summary>
        /// <param name="value">the enum value to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this Enum value, bool inherit = false)
            where TAttribute : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(Enum.GetName(type, value) ?? value.ToString()).FirstOrDefault();
            var attributes = memberInfo?.GetCustomAttributes<TAttribute>(inherit).ToArray();
            if (attributes is null || !attributes.Any()) return Array.Empty<TAttribute>();
            return attributes;
        }

        /// <summary>
        /// Gets all attributes of a specified type on an enum value
        /// </summary>
        /// <param name="value">the enum value to inspect</param>
        /// <param name="attributeType">The type of attributes to retrieve.</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <returns>An array of located <see cref="Attribute"/> instances. If none are found, an empty array is returned.</returns>
        public static Attribute[] GetCustomAttributes(this Enum value, Type attributeType, bool inherit = false)
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(Enum.GetName(type, value) ?? value.ToString()).FirstOrDefault();
            var attributes = memberInfo?.GetCustomAttributes(attributeType,inherit).ToArray();
            if (attributes is null || !attributes.Any()) return Array.Empty<Attribute>();
            return attributes.Select(x=>(Attribute)x).ToArray();
        }
        
        /// <summary>
        /// Gets all attributes of a specified type on a FieldInfo
        /// </summary>
        /// <param name="fieldInfo">the field to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of attributes to retrieve</typeparam>
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this FieldInfo fieldInfo, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = fieldInfo.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this PropertyInfo propertyInfo, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = propertyInfo.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this MethodInfo methodInfo, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = methodInfo.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this Type type, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = type.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this ParameterInfo paramInfo, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = paramInfo.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this Module module, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = module.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this TypeInfo typeInfo, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = typeInfo.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this Assembly assembly, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = assembly.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this EventInfo eventInfo, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = eventInfo.GetCustomAttributes(typeof(TAttribute), inherit);
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
        /// <returns>An array of located <typeparam name="TAttribute"/> instances. If none are found, an empty array is returned.</returns>
        public static TAttribute[] GetCustomAttributes<TAttribute>(this MemberInfo memberInfo, bool inherit = false)
            where TAttribute : Attribute
        {
            var attributes = memberInfo.GetCustomAttributes(typeof(TAttribute), inherit);
            if (attributes.Length == 0) return Array.Empty<TAttribute>();
            return (from attribute in attributes
                    select (TAttribute)attribute).ToArray();
        }

        #endregion
        
        #region HasAttribute  Overloads
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific enum value in an enum.
        /// </summary>
        /// <param name="value">The enum value to inspect.</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this Enum value, Type attributeType, bool inherit=false)=>
            value.GetCustomAttributes(attributeType, inherit).Any();
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific enum value in an enum.
        /// </summary>
        /// <param name="value">The enum value to inspect.</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this Enum value, bool inherit=true) 
            where TAttribute : Attribute => 
            value.GetCustomAttributes<TAttribute>(inherit).Any();

        /// <summary>
        /// Determines if an attribute has been applied to a specific type.
        /// </summary>
        /// <param name="type">The type to inspect</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this Type type, Type attributeType, bool inherit=false) => 
            type.IsDefined(attributeType, inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific type.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this Type type, bool inherit=false) 
            where TAttribute : Attribute => 
            type.HasAttribute(typeof(TAttribute), inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="FieldInfo"/>.
        /// </summary>
        /// <param name="fieldInfo">The <see cref="FieldInfo"/> instance to inspect</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this FieldInfo fieldInfo, Type attributeType, bool inherit=false) => 
            fieldInfo.IsDefined(attributeType, inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="FieldInfo"/>.
        /// </summary>
        /// <param name="fieldInfo">The <see cref="FieldInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this FieldInfo fieldInfo, bool inherit=false) => 
            fieldInfo.HasAttribute(typeof(TAttribute), inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="PropertyInfo"/>.
        /// </summary>
        /// <param name="propertyInfo">The <see cref="PropertyInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this PropertyInfo propertyInfo, Type attributeType, bool inherit=false) => 
            propertyInfo.IsDefined(attributeType, inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="PropertyInfo"/>.
        /// </summary>
        /// <param name="propertyInfo">The <see cref="PropertyInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this PropertyInfo propertyInfo, bool inherit=false) => 
            propertyInfo.HasAttribute(typeof(TAttribute), inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="MethodInfo"/>.
        /// </summary>
        /// <param name="methodInfo">The <see cref="MethodInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this MethodInfo methodInfo, Type attributeType, bool inherit=false) => 
            methodInfo.IsDefined(attributeType, inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="MethodInfo"/>.
        /// </summary>
        /// <param name="methodInfo">The <see cref="MethodInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this MethodInfo methodInfo, bool inherit=false) => 
            methodInfo.HasAttribute(typeof(TAttribute), inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="ParameterInfo"/>.
        /// </summary>
        /// <param name="paramInfo">The <see cref="ParameterInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this ParameterInfo paramInfo, Type attributeType, bool inherit=false) => 
            paramInfo.IsDefined(attributeType, inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="MethodInfo"/>.
        /// </summary>
        /// <param name="paramInfo">The <see cref="MethodInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this ParameterInfo paramInfo, bool inherit=false) => 
            paramInfo.HasAttribute(typeof(TAttribute), inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="Module"/>.
        /// </summary>
        /// <param name="module">The <see cref="Module"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this Module module, Type attributeType, bool inherit=false) => 
            module.IsDefined(attributeType, inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="Module"/>.
        /// </summary>
        /// <param name="module">The <see cref="Module"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this Module module, bool inherit=false) => 
            module.HasAttribute(typeof(TAttribute), inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="TypeInfo"/>.
        /// </summary>
        /// <param name="typeInfo">The <see cref="TypeInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this TypeInfo typeInfo, Type attributeType, bool inherit=false) => 
            typeInfo.IsDefined(attributeType, inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="TypeInfo"/>.
        /// </summary>
        /// <param name="typeInfo">The <see cref="TypeInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this TypeInfo typeInfo, bool inherit=false) => 
            typeInfo.HasAttribute(typeof(TAttribute), inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="Assembly"/>.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this Assembly assembly, Type attributeType, bool inherit=false) => 
            assembly.IsDefined(attributeType, inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="Assembly"/>.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this Assembly assembly, bool inherit=false) => 
            assembly.HasAttribute(typeof(TAttribute), inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="EventInfo"/>.
        /// </summary>
        /// <param name="eventInfo">The <see cref="EventInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this EventInfo eventInfo, Type attributeType, bool inherit=false) => 
            eventInfo.IsDefined(attributeType, inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="EventInfo"/>.
        /// </summary>
        /// <param name="eventInfo">The <see cref="EventInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this EventInfo eventInfo, bool inherit=false) => 
            eventInfo.HasAttribute(typeof(TAttribute), inherit);

        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="MemberInfo"/>.
        /// </summary>
        /// <param name="memberInfo">The <see cref="MemberInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <param name="attributeType">The type of the attribute to detect.</param>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute(this MemberInfo memberInfo, Type attributeType, bool inherit=false) => 
            memberInfo.IsDefined(attributeType, inherit);
        
        /// <summary>
        /// Determines if an attribute has been applied to a specific <see cref="MemberInfo"/>.
        /// </summary>
        /// <param name="memberInfo">The <see cref="MemberInfo"/> instance to inspect</param>
        /// <param name="inherit">inspect the inheritance hierarchy</param>
        /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
        /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
        public static bool HasAttribute<TAttribute>(this MemberInfo memberInfo, bool inherit=false) => 
            memberInfo.HasAttribute(typeof(TAttribute), inherit);

        #endregion
    }
}