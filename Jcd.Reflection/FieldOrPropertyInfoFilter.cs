#region

using System;
using System.Reflection;

#endregion

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Jcd.Reflection;

/// <summary>
/// The settings indicating "how" to enumerate. (i.e. BindingFlags and a predicate for skipping members)
/// </summary>
public class FieldOrPropertyInfoFilter
{
   /// <summary>
   /// The BindingFlags for the member lookup.
   /// </summary>
   public BindingFlags? Flags { get; init; }

   // ReSharper disable once UnassignedField.Global
   /// <summary>
   /// A predicate for skipping certain members.
   /// </summary>
   public Func<FieldOrPropertyInfo, bool> Skip { get; init; }

   #region Standard Filters

   /// <summary>
   /// Selects all public instance methods including inherited methods.
   /// </summary>
   public static readonly FieldOrPropertyInfoFilter AllInstanceMethodsFilter =
      new()
      {
         Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all static methods including inherited static.
   /// </summary>
   public static readonly FieldOrPropertyInfoFilter AllStaticMethodsFilter =
      new()
      {
         Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all directly declared instance methods.
   /// </summary>
   public static readonly FieldOrPropertyInfoFilter DirectInstanceMethodsFilter =
      new()
      {
         Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all directly declared static methods.
   /// </summary>
   public static readonly FieldOrPropertyInfoFilter DirectStaticMethodsFilter =
      new()
      {
         Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   #endregion
}