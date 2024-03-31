#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Jcd.Validations;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable ConvertIfStatementToReturnStatement
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable UnusedMember.Global

#endregion

namespace Jcd.Reflection;

/// <summary>
/// Provides extension methods for <see cref="Type" /> interactions.
/// </summary>
public static class TypeExtensions
{
   /// <summary>
   /// Checks if one type inherits from another. This will match generic inheritance as well.
   /// </summary>
   /// <param name="derivedType">The type to check inheritance on.</param>
   /// <param name="allowSelfToCompareToTrueIfConcrete"></param>
   /// <typeparam name="T">The type to check inheritance from.</typeparam>
   /// <returns>True if type inherits from <typeparamref name="T" /></returns>
   public static bool InheritsFrom<T>(this Type derivedType, bool allowSelfToCompareToTrueIfConcrete = false)
   {
      return derivedType?.InheritsFrom(typeof(T), allowSelfToCompareToTrueIfConcrete) ?? false;
   }

   /// <summary>
   /// Checks if one type inherits from another. This will match generic inheritance as well.
   /// </summary>
   /// <param name="derivedType">The type to check inheritance on.</param>
   /// <param name="parentType">The type to check for inheritance against.</param>
   /// <param name="allowSelfToCompareToTrueIfConcrete">if </param>
   /// <returns>True if type inherits from <paramref name="parentType" /></returns>
   /// <remarks>
   /// The <see href="https://github.com/khellang/Scrutor">Scrutor</see> project, on GitHub, by Kristian Hellang
   /// provided the inspiration and overall algorithm for determining if a type was derived from another
   /// regardless of the genericity of the types being compared.
   /// </remarks>
   public static bool InheritsFrom(
      this Type derivedType
    , Type      parentType
    , bool      allowSelfToCompareToTrueIfConcrete = false
   )
   {
      Argument.IsNotNull(parentType, nameof(parentType));

      if (parentType.IsGenericTypeDefinition)
      {
         return derivedType?.InheritsFromGenericTypeDefinition(parentType, allowSelfToCompareToTrueIfConcrete) ?? false;
      }

      return allowSelfToCompareToTrueIfConcrete
                ? parentType.IsAssignableFrom(derivedType)
                : derivedType != parentType && parentType.IsAssignableFrom(derivedType);
   }

   /// <summary>
   /// Determines if the <paramref name="derivedType" /> is directly or indirectly derived from the
   /// <paramref name="genericTypeDefinition" />
   /// </summary>
   /// <param name="derivedType">The type to inspect.</param>
   /// <param name="genericTypeDefinition">The generic type definition to compare against.</param>
   /// <param name="allowSelfToCompareToTrueIfConcrete">Allows true to be returned if derivedType is exactly the generic type.</param>
   /// <returns><see langword="true" /> if the derivedType is a direct descendant; <see langword="false" /></returns>
   /// <remarks>
   /// The <see href="https://github.com/khellang/Scrutor">Scrutor</see> project, on GitHub, by Kristian Hellang
   /// provided the inspiration and overall algorithm for determining if a type was derived from another
   /// regardless of the genericity of the types being compared.
   /// </remarks>
   public static bool InheritsFromGenericTypeDefinition(
      this Type derivedType
    , Type      genericTypeDefinition
    , bool      allowSelfToCompareToTrueIfConcrete = false
   )
   {
      return DirectlyInheritsFromGenericTypeDefinition(derivedType
                                                     , genericTypeDefinition
                                                     , allowSelfToCompareToTrueIfConcrete
                                                      )
          || derivedType.GetNonInterfaceBaseTypes()
                        .Any(x => x.DirectlyInheritsFromGenericTypeDefinition(genericTypeDefinition
                                                                            , allowSelfToCompareToTrueIfConcrete
                                                                             )
                            );
   }

   /// <summary>
   /// Determines if the <paramref name="derivedType" /> is directly derived from the
   /// <paramref name="genericTypeDefinition" />
   /// </summary>
   /// <param name="derivedType">The type to inspect.</param>
   /// <param name="genericTypeDefinition">The generic type definition to compare against.</param>
   /// <param name="allowSelfToCompareToTrueIfConcrete">Allows true to be returned if derivedType is exactly the generic type.</param>
   /// <returns><see langword="true" /> if the derivedType is a direct descendant; <see langword="false" /></returns>
   /// <remarks>
   /// The <see href="https://github.com/khellang/Scrutor">Scrutor</see> project by khellang on GitHub
   /// provided the inspiration and overall algorithm for determining if a type was derived from another
   /// regardless of the genericity of the types being compared.
   /// </remarks>
   public static bool DirectlyInheritsFromGenericTypeDefinition(
      this Type derivedType
    , Type      genericTypeDefinition
    , bool      allowSelfToCompareToTrueIfConcrete = false
   )
   {
      if (derivedType is null)
      {
         return false;
      }

      return derivedType.IsGenericType && derivedType.GetGenericTypeDefinition()               == genericTypeDefinition
                ? allowSelfToCompareToTrueIfConcrete || derivedType.GetGenericTypeDefinition() != derivedType
                : (
                     from interfaceType in derivedType.GetInterfaces()
                     where interfaceType.IsGenericType
                     select interfaceType.GetGenericTypeDefinition())
               .Any(genericInterfaceTypeDefinition => genericInterfaceTypeDefinition == genericTypeDefinition);
   }

   /// <summary>
   /// Retrieves an array of the non-interface base types for the
   /// passed in type.
   /// </summary>
   /// <param name="type">the type to retrieve base types from.</param>
   /// <returns>an array of the non-interface base types</returns>
   public static IEnumerable<Type> GetNonInterfaceBaseTypes(this Type type)
   {
      Argument.IsNotNull(type, nameof(type));
      var types       = new List<Type>();
      var currentType = type;

      while (currentType.BaseType != null)
      {
         types.Add(currentType.BaseType);
         currentType = currentType.BaseType;
      }

      return types;
   }

   /// <summary>
   /// Determines if a type is a concrete type.
   /// </summary>
   /// <param name="type">the type to inspect.</param>
   /// <param name="allowCompilerGenerated">Allows types that are compiler generated to return true.</param>
   /// <param name="allowSpecialNames">Allow types with special names to return true.</param>
   /// <returns>true if the type is concrete.</returns>
   /// <remarks>
   /// This method does not account for the public/internal/private nature of the type.
   /// It only answers the concrete question. (Can something, directly instantiate it,
   /// that might be another class in a different assembly. You are using reflection,
   /// after all.)
   /// </remarks>
   public static bool IsConcreteType(
      this Type type
    , bool      allowCompilerGenerated = false
    , bool      allowSpecialNames      = false
   )
   {
      Argument.IsNotNull(type, nameof(type));

      if (type.IsAbstract)
      {
         return false;
      }

      if (!allowSpecialNames && type.IsSpecialName)
      {
         return false;
      }

      if (!allowCompilerGenerated && type.IsCompilerGenerated())
      {
         return false;
      }

      return true;
   }

   /// <summary>
   /// Indicates if the type is compiler generated.
   /// </summary>
   /// <param name="type">The type to inspect.</param>
   /// <returns>true if the type has the <see cref="CompilerGeneratedAttribute" /> attribute applied.</returns>
   public static bool IsCompilerGenerated(this Type type)
   {
      Argument.IsNotNull(type, nameof(type));

      return type.HasAttribute<CompilerGeneratedAttribute>();
   }
}