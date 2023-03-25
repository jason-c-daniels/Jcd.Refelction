using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Jcd.Reflection
{
    /// <summary>
    /// Some extension methods used for finding types within one or more assemblies.
    /// </summary>
    public static class TypeDiscoveryExtensions
    {
        /// <summary>
        /// Gets implementations of the specified type from an assembly.
        /// </summary>
        /// <param name="assembly">the assembly to search.</param>
        /// <param name="returnTargetTypeIfConcrete">If <see cref="T"/> is in the target assembly, and it's a concrete, return it as well.</param>
        /// <returns>An <see cref="IEnumerable{Type}"/> of the implementations of <typeparam name="T"></typeparam></returns>
        /// <exception cref="ArgumentNullException">When <see cref="assembly"/> is null.</exception>
        public static IEnumerable<Type> FindImplementationsOf<T>(this Assembly assembly, 
                                                                 bool returnTargetTypeIfConcrete=false) =>
            FindImplementationsOf(assembly, typeof(T), returnTargetTypeIfConcrete);

        /// <summary>
        /// Gets implementations of the specified type from an assembly.
        /// </summary>
        /// <param name="assembly">the assembly to search.</param>
        /// <param name="type">The type to find implementations of.</param>
        /// <param name="returnTargetTypeIfConcrete">If <see cref="type"/> is in the target assembly, and it's a concrete, return it as well.</param>
        /// <returns>An <see cref="IEnumerable{Type}"/> of the implementations of <paramref name="type"/></returns>
        /// <exception cref="ArgumentNullException">When either <see cref="assembly"/> or <see cref="type"/> is null.</exception>
        public static IEnumerable<Type> FindImplementationsOf(this Assembly assembly, 
                                                              Type type, 
                                                              bool returnTargetTypeIfConcrete=false)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));
            if (type == null) throw new ArgumentNullException(nameof(type));
            return from t in assembly.GetTypes()
                   where t.IsConcreteType()
                         && t.InheritsFrom(type,returnTargetTypeIfConcrete)
                   select t;
        }

        /// <summary>
        /// Gets implementations of the specified type from a collection of assemblies.
        /// </summary>
        /// <param name="assemblies">The collection of assemblies to search.</param>
        /// <param name="returnTargetTypeIfConcrete">If <see cref="T"/> is in the target assembly, and it's a concrete, return it as well.</param>
        /// <returns>An <see cref="IEnumerable{Type}"/> of the implementations of <typeparamref name="T"/></returns>
        /// <exception cref="ArgumentNullException">When <see cref="assemblies"/> is null.</exception>
        public static IEnumerable<Type> FindImplementationsOf<T>(this IEnumerable<Assembly> assemblies, bool returnTargetTypeIfConcrete=false)
            => FindImplementationsOf(assemblies, typeof(T), returnTargetTypeIfConcrete);
        
        /// <summary>
        /// Gets implementations of the specified type from a collection of assemblies.
        /// </summary>
        /// <param name="assemblies">The collection of assemblies to search.</param>
        /// <param name="type">The type to find implementations of.</param>
        /// <param name="returnTargetTypeIfConcrete">If <see cref="type"/> is in the target assembly, and it's a concrete, return it as well.</param>
        /// <returns>An <see cref="IEnumerable{Type}"/> of the implementations of <paramref name="type"/></returns>
        /// <exception cref="ArgumentNullException">When either assembly or type is null.</exception>
        public static IEnumerable<Type> FindImplementationsOf(this IEnumerable<Assembly> assemblies, 
                                                              Type type, 
                                                              bool returnTargetTypeIfConcrete=false)
        {
            if (assemblies == null) throw new ArgumentNullException(nameof(assemblies));
            if (type == null) throw new ArgumentNullException(nameof(type));
            HashSet<Assembly> set = new HashSet<Assembly>();
            foreach (var assembly in assemblies)
            {
                if (!set.Add(assembly)) continue;
                foreach (var implementationType in assembly.FindImplementationsOf(type, returnTargetTypeIfConcrete))
                    yield return implementationType;
            }
        }
    }
}