#region

using System;

#endregion

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Jcd.Reflection.Examples;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class MyDescriptionAttribute : Attribute
{
    public MyDescriptionAttribute(string description)
    {
        Description = description;
    }

    public string Description { get; }
}