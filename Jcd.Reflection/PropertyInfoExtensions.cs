using System;
using System.Collections.Generic;
using System.Reflection;

namespace Jcd.Reflection
{
   /// <summary>
   /// A set of reflection extensions to aid in manipulating properties.
   /// </summary>
   public static class PropertyInfoExtensions
   {
      /// <summary>
      /// Enumerate the PropertyInfo entries for a given type 
      /// </summary>
      /// <param name="type">The data type to reflect on</param>
      /// <param name="flags">The BindingFlags</param>
      /// <param name="skip">a predicate for skipping certain entries (e.g. System...)</param>
      /// <returns>An enumerable across PropertyInfo s</returns>
      public static IEnumerable<PropertyInfo> EnumerateProperties(this Type type, BindingFlags? flags = null,
                                                                  Func<PropertyInfo, bool> skip = null)
      {
         IEnumerable<PropertyInfo> props = flags.HasValue ? type.GetProperties(flags.Value) : type.GetProperties();
         foreach (var pi in props)
         {
            if (!pi.CanRead) continue;
            if (pi.DeclaringType?.Namespace != null && pi.DeclaringType.Namespace.StartsWith("System")) continue;
            var skipped = skip?.Invoke(pi);
            if (skipped.HasValue && skipped.Value) continue;
            yield return pi;
         }
      }

      /// <summary>
      /// Enumerate the PropertyInfo entries for a given type 
      /// </summary>
      /// <param name="self">The data instance to reflect on</param>
      /// <param name="flags">The BindingFlags</param>
      /// <param name="skip">a predicate for skipping certain entries (e.g. System...)</param>
      /// <returns>An enumerable across PropertyInfo s</returns>
      public static IEnumerable<PropertyInfo> EnumerateProperties(this object self, BindingFlags? flags = null,
                                                                  Func<PropertyInfo, bool> skip = null)
      {
         return self.IsScalar() ? null : self.GetType().EnumerateProperties(flags, skip);
      }
   }
}