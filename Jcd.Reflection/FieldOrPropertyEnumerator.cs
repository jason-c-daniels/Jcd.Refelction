using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Jcd.Reflection
{
   /// <summary>
   /// Enumerates both properties and fields on a given data type.
   /// </summary>
   public class FieldOrPropertyEnumerator : IEnumerable<FieldOrPropertyInfo>
   {
      private readonly MemberInfoEnumerator _innerEnumerator;
      /// <summary>
      /// The settings indicating "how" to enumerate. (i.e. BingindFlgas and a predicate for skipping members)
      /// </summary>
      public struct Settings
      {
         public BindingFlags? Flags;
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
      public FieldOrPropertyEnumerator(Type type, Settings settings = default(Settings))
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
      public FieldOrPropertyEnumerator(object item, Settings settings = default(Settings)) 
         : this((Type)(item is Type || item is null ? item : item.GetType()), settings)
      {

      }

      /// <summary>
      /// Enumerates the FieldOrPropertyInfo entries for the given type.
      /// </summary>
      /// <returns>An enumerator of FieldOrPropertyInfo's</returns>
      public IEnumerator<FieldOrPropertyInfo> GetEnumerator()
      {
         foreach (var mi in _innerEnumerator)
         {
            var fpi=new FieldOrPropertyInfo(mi, EnumerationSettings.Flags ?? BindingFlags.Public | BindingFlags.Instance);
            var skipped = EnumerationSettings.Skip?.Invoke(fpi);
            if (skipped.HasValue && skipped.Value) continue;
            yield return fpi;
         }
      }

      /// <summary>
      /// Enumerates the FieldOrPropertyInfo entries for the given type.
      /// </summary>
      /// <returns>An enumerator for the FieldOrPropertyInfo's</returns>
      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
