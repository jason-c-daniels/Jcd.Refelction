#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#endregion

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible
// ReSharper disable HeapView.ObjectAllocation

namespace Jcd.Reflection;

/// <summary>
/// Some extension methods used for finding types within one or more assemblies.
/// </summary>
public static class TypeDiscoveryExtensions
{
    /// <summary>
    /// Gets implementations of the specified type from an assembly.
    /// </summary>
    /// <param name="assembly">the assembly to search.</param>
    /// <param name="returnTargetTypeIfConcrete">If <typeparamref name="T"/> is in the target assembly, and it's a concrete, return it as well.</param>
    /// <returns>An <see cref="IEnumerable{Type}"/> of the implementations of <typeparam name="T"></typeparam></returns>
    /// <exception cref="ArgumentNullException">When <paramref name="assembly"/> cref="assembly"/> is null.</exception>
    public static IEnumerable<Type> FindImplementationsOf<T>(this Assembly assembly,
                                                             bool returnTargetTypeIfConcrete = false)
    {
        return FindImplementationsOf(assembly, typeof(T), returnTargetTypeIfConcrete);
    }

    /// <summary>
    /// Gets implementations of the specified type from an assembly.
    /// </summary>
    /// <param name="assembly">the assembly to search.</param>
    /// <param name="type">The type to find implementations of.</param>
    /// <param name="returnTargetTypeIfConcrete">If <paramref name="type"/> is in the target assembly, and it's a concrete, return it as well.</param>
    /// <returns>An <see cref="IEnumerable{Type}"/> of the implementations of <paramref name="type"/></returns>
    /// <exception cref="ArgumentNullException">When either <paramref name="assembly"/> or <paramref name="type"/> is null.</exception>
    public static IEnumerable<Type> FindImplementationsOf(this Assembly assembly,
                                                          Type type,
                                                          bool returnTargetTypeIfConcrete = false)
    {
        if (assembly == null) throw new ArgumentNullException(nameof(assembly));
        if (type == null) throw new ArgumentNullException(nameof(type));
        return from t in assembly.GetTypes()
               where t.IsConcreteType()
                     && t.InheritsFrom(type, returnTargetTypeIfConcrete)
               select t;
    }

    /// <summary>
    /// Gets implementations of the specified type from a collection of assemblies.
    /// </summary>
    /// <param name="assemblies">The collection of assemblies to search.</param>
    /// <param name="returnTargetTypeIfConcrete">If <typeparamref name="T"/> is in the target assembly, and it's a concrete, return it as well.</param>
    /// <returns>An <see cref="IEnumerable{Type}"/> of the implementations of <typeparamref name="T"/></returns>
    /// <exception cref="ArgumentNullException">When <paramref name="assemblies"/> is null.</exception>
    public static IEnumerable<Type> FindImplementationsOf<T>(this IEnumerable<Assembly> assemblies,
                                                             bool returnTargetTypeIfConcrete = false)
    {
        return FindImplementationsOf(assemblies, typeof(T), returnTargetTypeIfConcrete);
    }

    /// <summary>
    /// Gets implementations of the specified type from a collection of assemblies.
    /// </summary>
    /// <param name="assemblies">The collection of assemblies to search.</param>
    /// <param name="type">The type to find implementations of.</param>
    /// <param name="returnTargetTypeIfConcrete">If <paramref name="type"/> is in the target assembly, and it's a concrete, return it as well.</param>
    /// <returns>An <see cref="IEnumerable{Type}"/> of the implementations of <paramref name="type"/></returns>
    /// <exception cref="ArgumentNullException">When either assembly or type is null.</exception>
    public static IEnumerable<Type> FindImplementationsOf(this IEnumerable<Assembly> assemblies,
                                                          Type type,
                                                          bool returnTargetTypeIfConcrete = false)
    {
        if (assemblies == null) throw new ArgumentNullException(nameof(assemblies));
        if (type == null) throw new ArgumentNullException(nameof(type));
        var set = new HashSet<Assembly>();
        foreach (var assembly in assemblies)
        {
            if (!set.Add(assembly)) continue;
            foreach (var implementationType in assembly.FindImplementationsOf(type, returnTargetTypeIfConcrete))
                yield return implementationType;
        }
    }
}