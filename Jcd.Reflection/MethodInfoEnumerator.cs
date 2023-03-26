#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible

#endregion

// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Reflection;

/// <summary>
/// Enumerates the method information for a given type. 
/// </summary>
public class MethodInfoEnumerator : IEnumerable<MethodInfo>
{
    /// <summary>
    /// Predefined skip predicate for skipping system methods.  
    /// </summary>
    public static readonly Func<MethodInfo, bool> SkipSystemMethods = mi =>
        mi.DeclaringType?.FullName != null && mi.DeclaringType.FullName.StartsWith("System.");

    /// <summary>
    /// Default method enumeration settings. Skips system provided methods.
    /// </summary>
    public static readonly Settings DefaultSettings = new()
        { Flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly, Skip = SkipSystemMethods };

    /// <summary>
    /// Constructs a MethodInfoEnumerator from a type and settings.
    /// </summary>
    /// <param name="type">The type to enumerate</param>
    /// <param name="settings">The settings controlling enumeration</param>
    public MethodInfoEnumerator(Type type,
                                Settings settings = default)
    {
        Type = type;
        EnumerationSettings = settings.IsDefault ? DefaultSettings : settings;
    }

    /// <summary>
    /// Constructs a MethodInfoEnumerator from an instance and settings.
    /// </summary>
    /// <param name="item">The instance to enumerate</param>
    /// <param name="settings">The settings controlling enumeration</param>
    // ReSharper disable once UnusedMember.Global
    public MethodInfoEnumerator(object item,
                                Settings settings = default) : this((Type)(item is System.Type or null
            ? item
            : item.GetType()),
        settings)
    {
    }

    /// <summary>
    /// Gets or sets the settings controlling method info enumeration
    /// </summary>
    // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
    public Settings EnumerationSettings { get; set; }

    /// <summary>
    /// The type whose methods are enumerated.
    /// </summary>
    public Type Type { get; }

    /// <summary>
    /// Gets an enumerator for the MethodInfos enumerated
    /// </summary>
    /// <returns>An enumerator</returns>
    public IEnumerator<MethodInfo> GetEnumerator()
    {
        if (Type == null) yield break;
        IEnumerable<MethodInfo> methods = EnumerationSettings.Flags.HasValue
            ? Type.GetMethods(EnumerationSettings.Flags.Value)
            : Type.GetMethods();

        foreach (var mi in methods)
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

    /// <summary>
    /// The settings controlling how to enumerate (e.g. what binding flags to use, special predicate for skipping?)
    /// </summary>
    public struct Settings
    {
        /// <summary>
        /// The BindingFlags for the member lookup.
        /// </summary>
        public BindingFlags? Flags;

        /// <summary>
        /// A predicate for skipping certain members.
        /// </summary>
        // ReSharper disable once UnassignedField.Global
        public Func<MethodInfo, bool> Skip;

        /// <summary>
        /// Indicates if this is a default (i.e. uninitialized) instance.
        /// </summary>
        public bool IsDefault => !Flags.HasValue && Skip == null;
    }
}