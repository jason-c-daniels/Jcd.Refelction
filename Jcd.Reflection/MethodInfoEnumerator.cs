using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Jcd.Reflection
{
    /// <summary>
    /// 
    /// </summary>
    public class MethodInfoEnumerator : IEnumerable<MethodInfo>
    {
        /// <summary>
        /// 
        /// </summary>
        public struct Settings
        {
            public BindingFlags? Flags;
            public Func<MethodInfo, bool> Skip;
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
        public MethodInfoEnumerator(Type type,
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
        public MethodInfoEnumerator(object item,
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
        public IEnumerator<MethodInfo> GetEnumerator()
        {
            if (Type == null) yield break;
            IEnumerable<MethodInfo> member = EnumerationSettings.Flags.HasValue
                ? Type.GetMethods(EnumerationSettings.Flags.Value)
                : Type.GetMethods();

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