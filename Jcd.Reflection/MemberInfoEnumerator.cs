#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

#endregion

namespace Jcd.Reflection;

/// <summary>
/// Enumerated MemberInfos for a given object or type.
/// </summary>
public class MemberInfoEnumerator : IEnumerable<MemberInfo>
{
   /// <summary>
   /// Predefined skip predicate for skipping system members.
   /// </summary>
   public static readonly Func<MemberInfo, bool> SkipSystemMembers = mi =>
                                                                        mi.DeclaringType?.FullName != null
                                                                     && mi.DeclaringType.FullName.StartsWith("System.");

   /// <summary>
   /// Predefined skip predicate for skipping system members.
   /// </summary>
   public static readonly Func<MemberInfo, bool> SkipSystemAndNonDataMembers = mi =>

                                                                                  // ReSharper disable once ArrangeRedundantParentheses
                                                                                  SkipSystemMembers(mi)
                                                                               || (mi.MemberType != MemberTypes.Field
                                                                                && mi.MemberType
                                                                                != MemberTypes.Property);

   /// <summary>
   /// Constructs a MemberInfoEnumerator from a type and settings.
   /// </summary>
   /// <param name="type">The type to enumerate</param>
   /// <param name="settings">The settings controlling enumeration</param>
   public MemberInfoEnumerator(Type type, MemberInfoFilter settings = default)
   {
      Type   = type;
      Filter = settings;
   }

   // ReSharper disable once UnusedMember.Global
   /// <summary>
   /// Constructs a MemberInfoEnumerator from an instance and settings.
   /// </summary>
   /// <param name="item">The instance to enumerate</param>
   /// <param name="settings">The settings controlling enumeration</param>
   public MemberInfoEnumerator(object item, MemberInfoFilter settings = default)
      : this((Type) (item is System.Type or null ? item : item.GetType()), settings)
   {
   }

   // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
   /// <summary>
   /// Gets or sets the settings controlling member info enumeration
   /// </summary>
   public MemberInfoFilter Filter { get; set; }

   /// <summary>
   /// The type whose members are enumerated.
   /// </summary>
   public Type Type { get; }

   /// <summary>
   /// Gets the enumerator
   /// </summary>
   /// <returns>An enumerator</returns>
   public IEnumerator<MemberInfo> GetEnumerator()
   {
      if (Type == null)
      {
         yield break;
      }

      IEnumerable<MemberInfo> memberInfos = Filter.Flags.HasValue
                                               ? Type.GetMembers(Filter.Flags.Value)
                                               : Type.GetMembers();

      foreach (var mi in memberInfos)
      {
         var skipped = Filter.Skip?.Invoke(mi);

         if (skipped.HasValue && skipped.Value)
         {
            continue;
         }

         yield return mi;
      }
   }

   /// <summary>
   /// Gets an enumerator
   /// </summary>
   /// <returns>An enumerator</returns>
   IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
}