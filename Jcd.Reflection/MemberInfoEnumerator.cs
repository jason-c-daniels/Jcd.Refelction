using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Jcd.Reflection
{
   /// <summary>
   /// Enumerated MemberInfos for a given object or type.
   /// </summary>
   public class MemberInfoEnumerator : IEnumerable<MemberInfo>
   {
      /// <summary>
      /// The settings controlling how to enumerate (e.g. what binding flags to use, special predicate for skipping?)
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
         public Func<MemberInfo, bool> Skip;
      }

      /// <summary>
      /// Predefined skip predicate for skipping system members.  
      /// </summary>
      public static Func<MemberInfo, bool> SkipSystemMembers = mi =>
         mi.DeclaringType?.Namespace != null && mi.DeclaringType.Namespace.StartsWith("System");
      
      /// <summary>
      /// Predefined skip predicate for skipping system members.  
      /// </summary>
      public static Func<MemberInfo, bool> SkipSystemAndNonDataMembers = mi =>
         SkipSystemMembers(mi) || (mi.MemberType != MemberTypes.Field && mi.MemberType != MemberTypes.Property);

      /// <summary>
      /// Gets or sets the settings controlling member info enumeration
      /// </summary>
      public Settings EnumerationSettings { get; set; }

      /// <summary>
      /// The type whose members are enumerated.
      /// </summary>
      public Type Type { get; }

      /// <summary>
      /// Constructs a MemberInfoEnumerator from a type and settings.
      /// </summary>
      /// <param name="type">The type to enumerate</param>
      /// <param name="settings">The settings controlling enumeration</param>
      public MemberInfoEnumerator(Type type,
         Settings settings = default(Settings))
      {
         Type = type;
         EnumerationSettings = settings;
      }

      /// <summary>
      /// Constructs a MemberInfoEnumerator from an instance and settings.
      /// </summary>
      /// <param name="item">The instance to enumerate</param>
      /// <param name="settings">The settings controlling enumeration</param>
      public MemberInfoEnumerator(object item,
                                  Settings settings = default(Settings)) : this((Type) (item is Type || item is null
            ? item
            : item.GetType()),
         settings)
      {

      }

      /// <summary>
      /// Gets the enumerator 
      /// </summary>
      /// <returns>An enumerator</returns>
      public IEnumerator<MemberInfo> GetEnumerator()
      {
         if (Type == null) yield break;
         IEnumerable<MemberInfo> member = EnumerationSettings.Flags.HasValue
            ? Type.GetMembers(EnumerationSettings.Flags.Value)
            : Type.GetMembers();

         foreach (var mi in member)
         {
            var skipped = EnumerationSettings.Skip?.Invoke(mi);
            if (skipped.HasValue && skipped.Value) continue;
            yield return mi;
         }
      }

      /// <summary>
      /// Gets an enumerator
      /// </summary>
      /// <returns>An enumerator</returns>
      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
