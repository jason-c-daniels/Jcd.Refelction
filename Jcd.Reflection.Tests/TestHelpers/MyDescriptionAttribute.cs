using System;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Jcd.Reflection.Tests.TestHelpers;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class MyDescriptionAttribute : Attribute
{
   public MyDescriptionAttribute(string description) { Description = description; }
   public string Description { get; set; }
}