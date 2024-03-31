#region

using System.Reflection;

// ReSharper disable HeapView.BoxingAllocation

#endregion

namespace Jcd.Reflection;

/// <summary>
/// GetValue and SetValue implementations.
/// </summary>
public static class ValueExtensions
{
   /// <summary>
   /// Gets a value from a named field or property
   /// </summary>
   /// <param name="self">the instance to retrieve the vale from</param>
   /// <param name="fieldOrPropertyName">the name of the item to get.</param>
   /// <param name="bindingFlags">The binding flags that help control property or field lookup</param>
   /// <returns>The value</returns>
   public static object GetValue(
      this object  self
    , string       fieldOrPropertyName
    , BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
   )
   {
      var t  = self.GetType();
      var pi = t.GetProperty(fieldOrPropertyName, bindingFlags);

      if (pi != null)
      {
         return pi.GetValue(self);
      }

      var fi = t.GetField(fieldOrPropertyName, bindingFlags);

      return fi != null ? fi.GetValue(self) : null;
   }

   /// <summary>
   /// Sets a value on a field or property
   /// </summary>
   /// <param name="self">The instance to set the value on</param>
   /// <param name="fieldOrPropertyName">the name of the field or property to set</param>
   /// <param name="value">The value to set.</param>
   /// <param name="bindingFlags">The binding flags that help control property or field lookup</param>
   /// <typeparam name="T">The type of data being modified.</typeparam>
   public static void SetValue<T>(
      this T       self
    , string       fieldOrPropertyName
    , object       value
    , BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
   )
      where T : class
   {
      var t  = self.GetType();
      var pi = t.GetProperty(fieldOrPropertyName, bindingFlags);
      var fi = t.GetField(fieldOrPropertyName, bindingFlags);

      if (pi != null)
      {
         pi.SetValue(self, value);
      }
      else if (fi != null)
      {
         fi.SetValue(self, value);
      }
   }

   /// <summary>
   /// Sets a value on a field or property.
   /// </summary>
   /// <param name="self">The instance to set the value on</param>
   /// <param name="fieldOrPropertyName">the name of the field or property to set</param>
   /// <param name="value">The value to set.</param>
   /// <param name="bindingFlags">The binding flags that help control property or field lookup</param>
   /// <typeparam name="T">The type of data being modified.</typeparam>
   public static void SetValue<T>(
      this ref T   self
    , string       fieldOrPropertyName
    , object       value
    , BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
   )
      where T : struct
   {
      object data = self; // box it
      var    t    = data.GetType();
      var    pi   = t.GetProperty(fieldOrPropertyName, bindingFlags);
      var    fi   = t.GetField(fieldOrPropertyName, bindingFlags);

      if (pi != null)
      {
         pi.SetValue(data, value);
      }
      else if (fi != null)
      {
         fi.SetValue(data, value);
      }

      self = (T) data; // now capture the modified value
   }
}