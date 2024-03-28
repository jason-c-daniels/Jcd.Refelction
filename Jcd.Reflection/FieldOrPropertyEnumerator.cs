#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

#endregion

namespace Jcd.Reflection;

/// <summary>
/// Enumerates both properties and fields on a given data type.
/// </summary>
public class FieldOrPropertyEnumerator : IEnumerable<FieldOrPropertyInfo>
{
   private readonly MemberInfoEnumerator innerEnumerator;

   /// <summary>
   /// Constructs a FieldOrPropertyEnumerator from a type and settings.
   /// </summary>
   /// <param name="type">The data type to reflect on</param>
   /// <param name="fieldOrPropertyInfoFilter">the settings controlling enumeration</param>
   public FieldOrPropertyEnumerator(Type type, FieldOrPropertyInfoFilter fieldOrPropertyInfoFilter = default)
   {
      Type   = type;
      Filter = fieldOrPropertyInfoFilter;
      innerEnumerator = new MemberInfoEnumerator(Type
                                               , new MemberInfoFilter
                                                 {
                                                    Flags = fieldOrPropertyInfoFilter?.Flags
                                                  , Skip  = MemberInfoEnumerator.SkipSystemAndNonDataMembers
                                                 }
                                                );
   }

   /// <summary>
   /// Constructs a FieldOrPropertyEnumerator from an object instance and settings.
   /// </summary>
   /// <param name="item">The object instance to reflect on</param>
   /// <param name="fieldOrPropertyInfoFilter">the settings controlling enumeration</param>
   public FieldOrPropertyEnumerator(object item, FieldOrPropertyInfoFilter fieldOrPropertyInfoFilter = default)
      : this((Type) (item is System.Type or null ? item : item.GetType()), fieldOrPropertyInfoFilter)
   {
   }

   /// <summary>
   /// Gets or sets the settings that control enumeration. 
   /// </summary>
   public FieldOrPropertyInfoFilter Filter { get; set; }

   /// <summary>
   /// The data type being reflected on. 
   /// </summary>
   public Type Type { get; }

   /// <summary>
   /// Enumerates the FieldOrPropertyInfo entries for the given type.
   /// </summary>
   /// <returns>An enumerator of FieldOrPropertyInfo's</returns>
   public IEnumerator<FieldOrPropertyInfo> GetEnumerator()
   {
      return (
                from mi in innerEnumerator
                select new FieldOrPropertyInfo(mi
                                             , Filter?.Flags ?? BindingFlags.Public | BindingFlags.Instance
                                              )
                into fpi
                let skipped = Filter?.Skip?.Invoke(fpi)
                where !skipped.HasValue || !skipped.Value
                select fpi
             )
        .GetEnumerator();
   }

   /// <summary>
   /// Enumerates the FieldOrPropertyInfo entries for the given type.
   /// </summary>
   /// <returns>An enumerator for the FieldOrPropertyInfo's</returns>
   IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
}