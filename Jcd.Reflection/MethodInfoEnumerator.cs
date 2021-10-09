using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Jcd.Reflection
{
    public class MethodInfoEnumerator : IEnumerable<MethodInfo>
    {
        public struct Settings
        {
            public BindingFlags? Flags;
            public Func<MethodInfo, bool> Skip;
        }
        
        public Settings EnumerationSettings { get; set; }

        public Type Type { get; }

        public MethodInfoEnumerator(Type type,
                                    Settings settings = default(Settings))
        {
            Type = type;
            EnumerationSettings = settings;
        }
        
        public MethodInfoEnumerator(object item,
                                    Settings settings = default(Settings)) : this((Type) (item is Type || item is null
                ? item
                : item.GetType()),
            settings)
        {

        }

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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}