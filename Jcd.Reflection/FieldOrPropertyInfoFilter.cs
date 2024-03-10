using System;
using System.Reflection;

namespace Jcd.Reflection;

/// <summary>
/// The settings indicating "how" to enumerate. (i.e. BindingFlags and a predicate for skipping members)
/// </summary>
public class FieldOrPropertyInfoFilter
{
   /// <summary>
   /// The BindingFlags for the member lookup.
   /// </summary>
   public BindingFlags? Flags { get; init; } = null;

   /// <summary>
   /// A predicate for skipping certain members.
   /// </summary>

   // ReSharper disable once UnassignedField.Global
   public Func<FieldOrPropertyInfo, bool> Skip { get; init; } = null;
}