using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Jcd.Reflection
{
   /// <summary>
   /// 
   /// </summary>
   public class MemberInfoEnumerator : IEnumerable<MemberInfo>
   {
      /// <summary>
      /// 
      /// </summary>
      public struct Settings
      {
         public BindingFlags? Flags;
         public Func<MemberInfo, bool> Skip;
      }

      /// <summary>
      /// 
      /// </summary>
      public static Func<MemberInfo, bool> SkipSystemMembers = mi =>
         mi.DeclaringType?.Namespace != null && mi.DeclaringType.Namespace.StartsWith("System");
      public static Func<MemberInfo, bool> SkipSystemAndNonDataMembers = mi =>
         SkipSystemMembers(mi) || (mi.MemberType != MemberTypes.Field && mi.MemberType != MemberTypes.Property);

      /// <summary>
      /// 
      /// </summary>
      public Settings EnumerationSettings { get; set; }

      /// <summary>
      /// 
      /// </summary>
      public Type Type { get; }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="type"></param>
      /// <param name="settings"></param>
      public MemberInfoEnumerator(Type type,
         Settings settings = default(Settings))
      {
         Type = type;
         EnumerationSettings = settings;
      }
      /// <summary>
      /// 
      /// </summary>
      /// <param name="item"></param>
      /// <param name="settings"></param>
      public MemberInfoEnumerator(object item,
         Settings settings = default(Settings)) : this((Type) (item is Type || item is null
            ? item
            : item.GetType()),
         settings)
      {

      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
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
      /// 
      /// </summary>
      /// <returns></returns>
      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
