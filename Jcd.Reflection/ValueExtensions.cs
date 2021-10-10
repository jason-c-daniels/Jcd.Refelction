namespace Jcd.Reflection
{
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
        /// <returns>The value</returns>
        public static object GetValue(this object self, string fieldOrPropertyName)
        {
            var t = self.GetType();
            var pi = t.GetProperty(fieldOrPropertyName);
            if (pi != null) return pi.GetValue(self);
            var fi = t.GetField(fieldOrPropertyName);
            return fi != null ? fi.GetValue(self) : null;
        }

        /// <summary>
        /// Sets a value on a field or property 
        /// </summary>
        /// <param name="self">The instance to set the value on</param>
        /// <param name="fieldOrPropertyName">the name of the field or property to set</param>
        /// <param name="value">The value to set.</param>
        public static void SetValue(this object self, string fieldOrPropertyName, object value)
        {
            var t = self.GetType();
            var pi = t.GetProperty(fieldOrPropertyName);
            var fi = t.GetField(fieldOrPropertyName);
            if (pi != null) pi.SetValue(self, value);
            else if (fi != null) fi.SetValue(self, value);
        }
    }
}