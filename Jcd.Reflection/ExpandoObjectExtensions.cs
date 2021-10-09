using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Reflection;
using System.Text;
using Jcd.Validations;

namespace Jcd.Reflection
{
    /// <summary>
    /// Extension methods for creating expando objects from POCOs or string object dictionaries
    /// </summary>
    public static class ExpandoObjectExtensions
    {      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="visited"></param>
        /// <param name="keyRenamingStrategy"></param>
        /// <param name="valueRetentionStrategy"></param>
        /// <returns></returns>
        public static IDictionary<string, object> ToDictionaryTree(this object self,
                                                                   HashSet<object> visited = null,
                                                                   Func<string, string> keyRenamingStrategy = null,
                                                                   Func<string, object, bool> valueRetentionStrategy = null)
        {
            return (IDictionary<string, object>)self.ToDictionaryTree<Dictionary<string, object>>(keyRenamingStrategy:keyRenamingStrategy, valueRetentionStrategy:valueRetentionStrategy);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="visited"></param>
        /// <param name="keyRenamingStrategy"></param>
        /// <param name="valueRetentionStrategy"></param>
        /// <returns></returns>
        public static ExpandoObject ToExpandoObject(this object self, HashSet<object> visited = null, Func<string,string> keyRenamingStrategy=null, Func<string, object, bool> valueRetentionStrategy = null)
        {
            string MyKeyRenamingStrategy(string key)
            {
                return DefaultExpandoKeyRenamingStrategy(keyRenamingStrategy != null ? keyRenamingStrategy(key) : key);
            }

            bool MyValueRetentionStrategy(string key, object value)
            {
                return (valueRetentionStrategy == null || valueRetentionStrategy(key, value)) && DefaultExpandoValueRetentionStrategy(value);
            }

            return (ExpandoObject)self.ToDictionaryTree<ExpandoObject>(keyRenamingStrategy: MyKeyRenamingStrategy, valueRetentionStrategy: MyValueRetentionStrategy);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        private static string DefaultExpandoKeyRenamingStrategy(string k)
        {
            var sb = new StringBuilder();
            char pc = '_';
            pc = BuildName(k, sb, pc);
            if (sb.Length == 0)
            {
                BuildName($"__MungedField{k}", sb, pc);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool DefaultExpandoValueRetentionStrategy(object value)
        {
            var retain = false;
            if (value != null)
            {
                retain = true;
                if (value is IDictionary dictionary)
                {
                    retain = dictionary.Count > 0;
                }
                else if (value is IEnumerable collection)
                {
                    var enumerator = collection.GetEnumerator();
                    retain = enumerator.MoveNext();
                    if (enumerator is IDisposable disp) disp.Dispose();
                }
            }

            return retain;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="visited"></param>
        /// <param name="keyRenamingStrategy"></param>
        /// <param name="valueRetentionStrategy"></param>
        /// <typeparam name="TNode"></typeparam>
        /// <returns></returns>
        private static dynamic ToDictionaryTree<TNode>(this object self, HashSet<object> visited = null, Func<string, string> keyRenamingStrategy = null, Func<string, object, bool> valueRetentionStrategy = null)
            where TNode : IDictionary<string, object>, new()
        {
            TNode root = default(TNode);
            if (visited == null) visited = new HashSet<object>();
            if (keyRenamingStrategy == null) keyRenamingStrategy = k => k;
            if (valueRetentionStrategy == null) valueRetentionStrategy = (name, value) => true;
            if (!visited.Contains(self))
            {
                visited.Add(self);
                root = new TNode();
                if (self.IsScalar()) return self;
                try
                {
                    if (self is IDictionary dictionary)
                    {
                        AppendDictionary(visited, keyRenamingStrategy, valueRetentionStrategy, dictionary, root);
                    }
                    else if (self is IEnumerable coll)
                    {
                        if (AppendEnumerable(visited, keyRenamingStrategy, valueRetentionStrategy, coll, root, out var array))
                            return array;
                    }
                    else
                    {
                        AppendObject(self, visited, keyRenamingStrategy, valueRetentionStrategy, root);
                    }
                }
                finally
                {
                    visited.Remove(self);
                }
            }
            return root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visited"></param>
        /// <param name="keyRenamingStrategy"></param>
        /// <param name="valueRetentionStrategy"></param>
        /// <param name="dictionary1"></param>
        /// <param name="root"></param>
        /// <typeparam name="TNode"></typeparam>
        private static void AppendDictionary<TNode>(HashSet<object> visited, Func<string, string> keyRenamingStrategy, Func<string, object, bool> valueRetentionStrategy,
                                                    IDictionary dictionary1, TNode root) where TNode : IDictionary<string, object>, new()
        {
            foreach (var key in dictionary1.Keys)
            {
                root.Append<TNode>(key.ToString(), dictionary1[key], visited, keyRenamingStrategy, valueRetentionStrategy);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="visited"></param>
        /// <param name="keyRenamingStrategy"></param>
        /// <param name="valueRetentionStrategy"></param>
        /// <param name="root"></param>
        /// <typeparam name="TNode"></typeparam>
        private static void AppendObject<TNode>(object self, HashSet<object> visited, Func<string, string> keyRenamingStrategy,
                                                Func<string, object, bool> valueRetentionStrategy, TNode root) where TNode : IDictionary<string, object>, new()
        {
            var type = self.GetType();
            foreach (var kvp in type.EnumerateProperties().ToPropertyInfoValuePairs(self).ToNameValuePairs())
            {
                root.Append<TNode>(kvp.Key, kvp.Value, visited, keyRenamingStrategy, valueRetentionStrategy);
            }

            foreach (var kvp in type.EnumerateFields().ToFieldInfoValuePairs(self).ToNameValuePairs())
            {
                root.Append<TNode>(kvp.Key, kvp.Value, visited, keyRenamingStrategy, valueRetentionStrategy);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visited"></param>
        /// <param name="keyRenamingStrategy"></param>
        /// <param name="valueRetentionStrategy"></param>
        /// <param name="enumerable"></param>
        /// <param name="root"></param>
        /// <param name="array"></param>
        /// <typeparam name="TNode"></typeparam>
        /// <returns></returns>
        private static bool AppendEnumerable<TNode>(HashSet<object> visited, Func<string, string> keyRenamingStrategy, Func<string, object, bool> valueRetentionStrategy,
                                                    IEnumerable enumerable, TNode root, out dynamic array) where TNode : IDictionary<string, object>, new()
        {
            array = null;
            var index = 0;
            bool? isKeyValuePair = null;
            var list = new List<object>();
            foreach (var item in enumerable)
            {
                if (!isKeyValuePair.HasValue)
                {
                    isKeyValuePair = item?.GetType().IsKeyValuePair();
                }

                var key = index.ToString();
                if (isKeyValuePair.HasValue && isKeyValuePair.Value)
                {
                    key = item.GetValue("Key").ToString();
                    var value = item.GetValue("Value");
                    root.Append<TNode>(key, value, visited, keyRenamingStrategy, valueRetentionStrategy);
                }
                else
                {
                    var val = item.IsScalar()
                        ? item
                        : item.ToDictionaryTree<TNode>(visited, keyRenamingStrategy, valueRetentionStrategy);
                    if (valueRetentionStrategy($"{key}:{index}", val))
                    {
                        list.Add(val);
                    }
                }

                index++;
            }

            if (isKeyValuePair.HasValue && isKeyValuePair.Value) return false;
            array = list.ToArray();
            return true;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="sb"></param>
        /// <param name="pc"></param>
        /// <returns></returns>
        private static char BuildName(string k, StringBuilder sb, char pc)
        {
            foreach (var c in k)
            {

                if ((sb.Length > 0 && (Char.IsLetterOrDigit(c) || c == '_')) || // valid member name char.
                    (sb.Length == 0 && (Char.IsLetter(c) || c == '_' || c == '@'))) // valid member name starting char
                {
                    if ((Char.IsLetterOrDigit(pc) && sb.Length > 0) || c == '_' || c == '@')
                        sb.Append(c);
                    else if (sb.Length > 0 || Char.IsLetter(c))
                        sb.Append(Char.ToUpperInvariant(c));
                }
                pc = c;
            }

            return pc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="visited"></param>
        /// <param name="keyRenamingStrategy"></param>
        /// <param name="valueRetentionStrategy"></param>
        /// <typeparam name="TNode"></typeparam>
        private static void Append<TNode>(this IDictionary<string, object> dictionary, string key, object val, HashSet<object> visited, Func<string, string> keyRenamingStrategy, Func<string,object,bool> valueRetentionStrategy)
            where TNode: IDictionary<string, object>, new()
        {
            Argument.IsNotNull(keyRenamingStrategy,nameof(keyRenamingStrategy));
            Argument.IsNotNull(valueRetentionStrategy, nameof(valueRetentionStrategy));
            if (!visited.Contains(val))
            {
                key = keyRenamingStrategy(key);
                var value = val.IsScalar() ? val : val.ToDictionaryTree<TNode>(visited, keyRenamingStrategy,valueRetentionStrategy);
                if (!dictionary.ContainsKey(key) && valueRetentionStrategy(key,value))
                {
                    dictionary.Add(key, value);
                }
            }
        }
        
        /// <summary>
        /// Creates a set of PropertyInfo to (current) value pairs for a given object. 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        public static IEnumerable<KeyValuePair<PropertyInfo, object>> ToPropertyInfoValuePairs(
            this IEnumerable<PropertyInfo> items, object item, Func<PropertyInfo, bool> skip = null)
        {
            Argument.IsNotNull(item, nameof(item));
            // ReSharper disable once PossibleMultipleEnumeration
            Argument.IsNotNull(items, nameof(items));
            // ReSharper disable once PossibleMultipleEnumeration
            foreach (var pi in items)
            {
                var value = (object)null;
                try
                {
                    value = pi.GetValue(item);
                }
                catch
                {
                    /* ignore for now.*/
                }

                yield return new KeyValuePair<PropertyInfo, object>(pi, value);
            }
        }

        /// <summary>
        /// For a set of PropertyInfo to object pairs return a name to value pair. 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        public static IEnumerable<KeyValuePair<string, object>> ToNameValuePairs(
            this IEnumerable<KeyValuePair<PropertyInfo, object>> items)
        {
            // ReSharper disable once PossibleMultipleEnumeration
            Argument.IsNotNull(items, nameof(items));
            // ReSharper disable once PossibleMultipleEnumeration
            foreach (var kvp in items)
            {
                yield return new KeyValuePair<string, object>(kvp.Key.Name, kvp.Value);
            }
        }
                /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="item"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        public static IEnumerable<KeyValuePair<FieldInfo, object>> ToFieldInfoValuePairs(
            this IEnumerable<FieldInfo> items, object item, Func<FieldInfo, bool> skip = null)
        {
            Argument.IsNotNull(item, nameof(item));
            // ReSharper disable once PossibleMultipleEnumeration
            Argument.IsNotNull(items, nameof(items));
            // ReSharper disable once PossibleMultipleEnumeration
            foreach (var fi in items)
            {
                var value = fi.GetValue(item);
                yield return new KeyValuePair<FieldInfo, object>(fi, value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        public static IEnumerable<KeyValuePair<string, object>> ToNameValuePairs(
            this IEnumerable<KeyValuePair<FieldInfo, object>> items)
        {
            // ReSharper disable once PossibleMultipleEnumeration
            Argument.IsNotNull(items, nameof(items));
            // ReSharper disable once PossibleMultipleEnumeration
            foreach (var kvp in items)
            {
                yield return new KeyValuePair<string, object>(kvp.Key.Name, kvp.Value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsKeyValuePair(this Type type)
        {
            var hasKey = type.GetTypeInfo().GetField("Key") != null || type.GetTypeInfo().GetProperty("Key") != null;
            var hasValue = type.GetTypeInfo().GetField("Value") != null || type.GetTypeInfo().GetProperty("Value") != null;
            return hasKey && hasValue;
        }

    }
}