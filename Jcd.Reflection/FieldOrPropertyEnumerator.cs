using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Jcd.Reflection
{
   /// <summary>
   /// 
   /// </summary>
   public class FieldOrPropertyEnumerator : IEnumerable<FieldOrPropertyInfo>
   {
      private readonly MemberInfoEnumerator _innerEnumerator;
      /// <summary>
      /// 
      /// </summary>
      public struct Settings
      {
         public BindingFlags? Flags;
         public Func<FieldOrPropertyInfo, bool> Skip;
      }
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
      public FieldOrPropertyEnumerator(Type type, Settings settings = default(Settings))
      {
         Type = type;
         EnumerationSettings = settings;
         _innerEnumerator = new MemberInfoEnumerator(Type, new MemberInfoEnumerator.Settings { Flags = settings.Flags, Skip = MemberInfoEnumerator.SkipSystemAndNonDataMembers });
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="item"></param>
      /// <param name="settings"></param>
      public FieldOrPropertyEnumerator(object item, Settings settings = default(Settings)) 
         : this((Type)(item is Type || item is null ? item : item.GetType()), settings)
      {

      }

      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
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
      /// 
      /// </summary>
      /// <returns></returns>
      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
