using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global

namespace Jcd.Reflection
{
   /// <summary>
   /// Enumerates both properties and fields on a given data type.
   /// </summary>
   public class FieldOrPropertyEnumerator : IEnumerable<FieldOrPropertyInfo>
   {
      private readonly MemberInfoEnumerator _innerEnumerator;
      /// <summary>
      /// The settings indicating "how" to enumerate. (i.e. BindingFlags and a predicate for skipping members)
      /// </summary>
      public struct Settings
      {
         /// <summary>
         /// The BindingFlags for the member lookup.
         /// </summary>
         public BindingFlags? Flags;
         /// <summary>
         /// A predicate for skipping certain members.
         /// </summary>
         // ReSharper disable once UnassignedField.Global
         public Func<FieldOrPropertyInfo, bool> Skip;
      }
      
      /// <summary>
      /// Gets or sets the settings that control enumeration. 
      /// </summary>
      public Settings EnumerationSettings { get; set; }

      /// <summary>
      /// The data type being reflected on. 
      /// </summary>
      public Type Type { get; }

      /// <summary>
      /// Constructs a FieldOrPropertyEnumerator from a type and settings.
      /// </summary>
      /// <param name="type">The data type to reflect on</param>
      /// <param name="settings">the settings controlling enumeration</param>
      public FieldOrPropertyEnumerator(Type type, Settings settings = default)
      {
         Type = type;
         EnumerationSettings = settings;
         _innerEnumerator = new MemberInfoEnumerator(Type, new MemberInfoEnumerator.Settings { Flags = settings.Flags, Skip = MemberInfoEnumerator.SkipSystemAndNonDataMembers });
      }

      /// <summary>
      /// Constructs a FieldOrPropertyEnumerator from an object instance and settings.
      /// </summary>
      /// <param name="item">The object instance to reflect on</param>
      /// <param name="settings">the settings controlling enumeration</param>
      public FieldOrPropertyEnumerator(object item, Settings settings = default) 
         : this((Type)(item is Type || item is null ? item : item.GetType()), settings)
      {

      }

      /// <summary>
      /// Enumerates the FieldOrPropertyInfo entries for the given type.
      /// </summary>
      /// <returns>An enumerator of FieldOrPropertyInfo's</returns>
      public IEnumerator<FieldOrPropertyInfo> GetEnumerator()
      {
         return (from mi in _innerEnumerator 
                 select new FieldOrPropertyInfo(mi, EnumerationSettings.Flags ?? BindingFlags.Public | BindingFlags.Instance) 
                 into fpi 
                 let skipped = EnumerationSettings.Skip?.Invoke(fpi) 
                 where !skipped.HasValue || !skipped.Value 
                 select fpi).GetEnumerator();
      }

      /// <summary>
      /// Enumerates the FieldOrPropertyInfo entries for the given type.
      /// </summary>
      /// <returns>An enumerator for the FieldOrPropertyInfo's</returns>
      IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
   }
}
