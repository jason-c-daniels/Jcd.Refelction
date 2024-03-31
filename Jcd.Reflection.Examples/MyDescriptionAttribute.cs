#region

using System;

// ReSharper disable UnusedMember.Global

#endregion

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Jcd.Reflection.Examples;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public sealed class MyDescriptionAttribute(string description) : Attribute
{
   public string Description { get; set; } = description;
}