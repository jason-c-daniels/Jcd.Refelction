#region

using System;
using System.Linq;
using System.Reflection;

// ReSharper disable UnusedMember.Global

#endregion

// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Reflection;

/// <summary>
/// Various extension methods that assist in getting custom attributes of a specified type.
/// </summary>
public static class HasAttributeExtensions
{
   #region HasAttribute Overloads

   /// <summary>
   /// Determines if an attribute has been applied to a specific enum value in an enum.
   /// </summary>
   /// <param name="value">The enum value to inspect.</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this Enum value, Type attributeType, bool inherit = false)
   {
      return value.GetCustomAttributes(attributeType, inherit).Any();
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific enum value in an enum.
   /// </summary>
   /// <param name="value">The enum value to inspect.</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this Enum value, bool inherit = true)
      where TAttribute : Attribute
   {
      return value.GetCustomAttributes<TAttribute>(inherit).Any();
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific type.
   /// </summary>
   /// <param name="type">The type to inspect</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this Type type, Type attributeType, bool inherit = false)
   {
      return type.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific type.
   /// </summary>
   /// <param name="type">The type to inspect.</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this Type type, bool inherit = false)
      where TAttribute : Attribute
   {
      return type.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="FieldInfo"/>.
   /// </summary>
   /// <param name="fieldInfo">The <see cref="FieldInfo"/> instance to inspect</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this FieldInfo fieldInfo, Type attributeType, bool inherit = false)
   {
      return fieldInfo.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="FieldInfo"/>.
   /// </summary>
   /// <param name="fieldInfo">The <see cref="FieldInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this FieldInfo fieldInfo, bool inherit = false)
   {
      return fieldInfo.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="PropertyInfo"/>.
   /// </summary>
   /// <param name="propertyInfo">The <see cref="PropertyInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this PropertyInfo propertyInfo, Type attributeType, bool inherit = false)
   {
      return propertyInfo.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="PropertyInfo"/>.
   /// </summary>
   /// <param name="propertyInfo">The <see cref="PropertyInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this PropertyInfo propertyInfo, bool inherit = false)
   {
      return propertyInfo.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="MethodInfo"/>.
   /// </summary>
   /// <param name="methodInfo">The <see cref="MethodInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this MethodInfo methodInfo, Type attributeType, bool inherit = false)
   {
      return methodInfo.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="MethodInfo"/>.
   /// </summary>
   /// <param name="methodInfo">The <see cref="MethodInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this MethodInfo methodInfo, bool inherit = false)
   {
      return methodInfo.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="ParameterInfo"/>.
   /// </summary>
   /// <param name="paramInfo">The <see cref="ParameterInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this ParameterInfo paramInfo, Type attributeType, bool inherit = false)
   {
      return paramInfo.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="MethodInfo"/>.
   /// </summary>
   /// <param name="paramInfo">The <see cref="MethodInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this ParameterInfo paramInfo, bool inherit = false)
   {
      return paramInfo.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="Module"/>.
   /// </summary>
   /// <param name="module">The <see cref="Module"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this Module module, Type attributeType, bool inherit = false)
   {
      return module.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="Module"/>.
   /// </summary>
   /// <param name="module">The <see cref="Module"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this Module module, bool inherit = false)
   {
      return module.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="TypeInfo"/>.
   /// </summary>
   /// <param name="typeInfo">The <see cref="TypeInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this TypeInfo typeInfo, Type attributeType, bool inherit = false)
   {
      return typeInfo.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="TypeInfo"/>.
   /// </summary>
   /// <param name="typeInfo">The <see cref="TypeInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this TypeInfo typeInfo, bool inherit = false)
   {
      return typeInfo.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="Assembly"/>.
   /// </summary>
   /// <param name="assembly">The <see cref="Assembly"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this Assembly assembly, Type attributeType, bool inherit = false)
   {
      return assembly.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="Assembly"/>.
   /// </summary>
   /// <param name="assembly">The <see cref="Assembly"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this Assembly assembly, bool inherit = false)
   {
      return assembly.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="EventInfo"/>.
   /// </summary>
   /// <param name="eventInfo">The <see cref="EventInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this EventInfo eventInfo, Type attributeType, bool inherit = false)
   {
      return eventInfo.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="EventInfo"/>.
   /// </summary>
   /// <param name="eventInfo">The <see cref="EventInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this EventInfo eventInfo, bool inherit = false)
   {
      return eventInfo.HasAttribute(typeof(TAttribute), inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="MemberInfo"/>.
   /// </summary>
   /// <param name="memberInfo">The <see cref="MemberInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <param name="attributeType">The type of the attribute to detect.</param>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute(this MemberInfo memberInfo, Type attributeType, bool inherit = false)
   {
      return memberInfo.IsDefined(attributeType, inherit);
   }

   /// <summary>
   /// Determines if an attribute has been applied to a specific <see cref="MemberInfo"/>.
   /// </summary>
   /// <param name="memberInfo">The <see cref="MemberInfo"/> instance to inspect</param>
   /// <param name="inherit">inspect the inheritance hierarchy</param>
   /// <typeparam name="TAttribute">The type of the attribute to detect.</typeparam>
   /// <returns><see langword="true"/> if one or more attributes of the requested type were detected; <see langword="false"/> otherwise.</returns>
   public static bool HasAttribute<TAttribute>(this MemberInfo memberInfo, bool inherit = false)
   {
      return memberInfo.HasAttribute(typeof(TAttribute), inherit);
   }

   #endregion
}