using System;
using System.Reflection;

namespace Jcd.Reflection;

/// <summary>
/// The settings controlling how to enumerate (e.g. what binding flags to use, special predicate for skipping?)
/// </summary>
public struct MemberInfoFilter
{
   #region Standard Filters

   /// <summary>
   /// Selects all public instance methods including inherited methods.
   /// </summary>
   public static readonly MemberInfoFilter AllInstanceMembersFilter =
      new()
      {
         Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all static methods including inherited static.
   /// </summary>
   public static readonly MemberInfoFilter AllStaticMembersFilter =
      new()
      {
         Flags = BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all directly declared instance methods.
   /// </summary>
   public static readonly MemberInfoFilter DirectInstanceMethodsFilter =
      new()
      {
         Flags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy
      };

   /// <summary>
   /// Selects all directly declared static methods.
   /// </summary>
   public static readonly MemberInfoFilter DirectStaticMembersFilter =
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
   public Func<MemberInfo, bool> Skip { get; init; }
}