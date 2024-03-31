#region

using System;
using System.Reflection;

#endregion

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable UnusedMember.Global

namespace Jcd.Reflection;

/// <summary>
/// The settings controlling how to enumerate (e.g. what binding flags to use, special predicate for skipping?)
/// </summary>
public struct MethodInfoFilter
{
   #region Standard Filters

   /// <summary>
   /// Selects all public instance methods including inherited methods.
   /// </summary>
   public static readonly MethodInfoFilter AllInstanceMethodsFilter =
      new()
      {
         Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all static methods including inherited static.
   /// </summary>
   public static readonly MethodInfoFilter AllStaticMethodsFilter =
      new()
      {
         Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all directly declared instance methods.
   /// </summary>
   public static readonly MethodInfoFilter DirectInstanceMethodsFilter =
      new()
      {
         Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all directly declared static methods.
   /// </summary>
   public static readonly MethodInfoFilter DirectStaticMethodsFilter =
      new()
      {
         Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   #endregion

   /// <summary>
   /// The BindingFlags for the member lookup.
   /// </summary>
   public BindingFlags? Flags { get; init; }

   // ReSharper disable once UnassignedField.Global

   /// <summary>
   /// A predicate for skipping certain members.
   /// </summary>
   public Func<MethodInfo, bool> Skip { get; init; }
}