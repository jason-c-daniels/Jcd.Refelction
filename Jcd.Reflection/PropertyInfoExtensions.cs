#region

using System;
using System.Collections.Generic;
using System.Reflection;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.ObjectAllocation.Possible
// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace Jcd.Reflection;

/// <summary>
/// A set of reflection extensions to aid in manipulating properties.
/// </summary>
public static class PropertyInfoExtensions
{
    #region Predefined Skip Methods
    
    /// <summary>
    /// Predefined skip predicate for skipping system members.  
    /// </summary>
    public static readonly Func<PropertyInfo, bool> SkipSystemMembers = pi =>
        pi.DeclaringType?.FullName != null && pi.DeclaringType.FullName.StartsWith("System.");

    /// <summary>
    /// Predefined skip predicate for skipping write only members.  
    /// </summary>
    public static readonly Func<PropertyInfo, bool> SkipWriteOnlyMembers = pi =>
        !pi.CanRead;

    /// <summary>
    /// Predefined skip predicate for skipping read only members.  
    /// </summary>
    public static readonly Func<PropertyInfo, bool> SkipReadOnlyMembers = pi =>
        !pi.CanWrite;
    
    /// <summary>
    /// Predefined skip predicate for skipping read only members.  
    /// </summary>
    public static Func<PropertyInfo, bool> SkipNonReadWrite = pi =>
        SkipReadOnlyMembers(pi) || SkipWriteOnlyMembers(pi);

    /// <summary>
    /// Predefined skip predicate for skipping write only and system members.  
    /// </summary>
    public static readonly Func<PropertyInfo, bool> DefaultSkip = pi =>
        SkipSystemMembers(pi) || SkipWriteOnlyMembers(pi);
    
    #endregion

    /// <summary>
    /// Enumerate the PropertyInfo entries for a given type 
    /// </summary>
    /// <param name="type">The data type to reflect on</param>
    /// <param name="flags">The BindingFlags</param>
    /// <param name="skip">a predicate for skipping certain entries.</param>
    /// <param name="returnSystem">Indicates if properties whose declaring type is in the System. namespace should be returned. Default is <see langword="false"/></param>
    /// <param name="returnWriteOnly">Indicates if properties that are write only should be returned. Default is <see langword="false"/> </param>
    /// <returns>An enumerable across PropertyInfo s</returns>
    public static IEnumerable<PropertyInfo> EnumerateProperties(this Type type, BindingFlags? flags = null,
                                                                Func<PropertyInfo, bool> skip = null,
                                                                bool returnSystem = false, bool returnWriteOnly=false)
    {
        IEnumerable<PropertyInfo> props = flags.HasValue ? type.GetProperties(flags.Value) : type.GetProperties();
        skip = ConfigureSkip(skip,returnSystem,returnWriteOnly);
        foreach (var pi in props)
        {
            var skipped = skip?.Invoke(pi);
            if (skipped.HasValue && skipped.Value) continue;
            yield return pi;
        }
    }

    private static Func<PropertyInfo, bool> ConfigureSkip(Func<PropertyInfo, bool> skip, bool returnSystem,
                                                          bool returnWriteOnly)
    {
        Func<PropertyInfo, bool> configuredSkip = null;
        if (!returnWriteOnly && !returnSystem) configuredSkip = DefaultSkip;
        if (!returnWriteOnly) configuredSkip = SkipWriteOnlyMembers;
        if (!returnSystem) configuredSkip = SkipSystemMembers;
        if (configuredSkip != null && skip != null)
        {
            return (pi) => skip(pi) || configuredSkip(pi);
        }

        return skip ?? configuredSkip;
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