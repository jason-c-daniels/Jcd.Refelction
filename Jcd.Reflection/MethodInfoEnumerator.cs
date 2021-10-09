using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Jcd.Reflection
{
    /// <summary>
    /// Enumerates the method information for a given type. 
    /// </summary>
    public class MethodInfoEnumerator : IEnumerable<MethodInfo>
    {
        /// <summary>
        /// The settings controlling how to enumerate (e.g. what binding flags to use, special predicate for skipping?)
        /// </summary>
        public struct Settings
        {
            public BindingFlags? Flags;
            public Func<MethodInfo, bool> Skip;
        }
        
        /// <summary>
        /// Gets or sets the settings controlling method info enumeration
        /// </summary>
        public Settings EnumerationSettings { get; set; }

        /// <summary>
        /// The type whose methods are enumerated.
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// Constructs a MethodInfoEnumerator from a type and settings.
        /// </summary>
        /// <param name="type">The type to enumerate</param>
        /// <param name="settings">The settings controlling enumeration</param>
        public MethodInfoEnumerator(Type type,
                                    Settings settings = default(Settings))
        {
            Type = type;
            EnumerationSettings = settings;
        }
        
        /// <summary>
        /// Constructs a MethodInfoEnumerator from an instance and settings.
        /// </summary>
        /// <param name="type">The instance to enumerate</param>
        /// <param name="settings">The settings controlling enumeration</param>
        public MethodInfoEnumerator(object item,
                                    Settings settings = default(Settings)) : this((Type) (item is Type || item is null
                ? item
                : item.GetType()),
            settings)
        {

        }

        /// <summary>
        /// Gets an enumerator for the MethodInfos enumerated
        /// </summary>
        /// <returns>An enumerator</returns>
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
        /// Gets an enumerator for the MethodInfos enumerated
        /// </summary>
        /// <returns>An enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}