#region

using System;
using System.Reflection;
using Jcd.Validations;
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.BoxingAllocation

#endregion

namespace Jcd.Reflection;

/// <summary>
/// 
/// </summary>
public class FieldOrPropertyInfo : MemberInfo
{
    private readonly BindingFlags _flags;
    private readonly MemberInfo _memberInfo;

    /// <summary>
    /// A dual purpose MemberInfo type.
    /// </summary>
    /// <param name="memberInfo">The member info on which this instance is based.</param>
    /// <param name="flags">the binding flags</param>
    public FieldOrPropertyInfo(MemberInfo memberInfo, BindingFlags flags)
    {
        Argument.IsNotNull(memberInfo, nameof(memberInfo));
        Argument.PassesAny(
            new Check.Signature<MemberInfo>[]
            {
                (mi, _, _) => mi.MemberType == MemberTypes.Field,
                (mi, _, _) => mi.MemberType == MemberTypes.Property
            }, memberInfo, nameof(memberInfo),
            $"memberInfo.MemberType must be a Property or Field but was {memberInfo.MemberType}");
        _flags = flags;
        _memberInfo = memberInfo;
    }

    /// <summary>
    /// Gets the type that declares the member.   
    /// </summary>
    public override Type DeclaringType => _memberInfo.DeclaringType;

    /// <summary>
    /// Gets the type of the member
    /// </summary>
    public override MemberTypes MemberType => _memberInfo.MemberType;

    /// <summary>
    /// Gets the name of the member
    /// </summary>
    public override string Name => _memberInfo.Name;

    /// <summary>
    /// gets the reflected type of the member.
    /// </summary>
    public override Type ReflectedType => _memberInfo.ReflectedType;

    /// <summary>
    /// Gets custom attributes for the member.
    /// </summary>
    /// <param name="inherit">Get inherited attributes if true</param>
    /// <returns>an array of custom attributes</returns>
    public override object[] GetCustomAttributes(bool inherit)
    {
        return _memberInfo.GetCustomAttributes(inherit);
    }

    /// <summary>
    /// Gets custom attributes of a specified type for a member.
    /// </summary>
    /// <param name="attributeType">The data type for the custom attribute</param>
    /// <param name="inherit">Get inherited attributes if true</param>
    /// <returns></returns>
    public override object[] GetCustomAttributes(Type attributeType, bool inherit)
    {
        return _memberInfo.GetCustomAttributes(attributeType, inherit);
    }

    /// <summary>
    /// Checks if a custom attribute of the specified type exists for the member. 
    /// </summary>
    /// <param name="attributeType">The data type for the custom attribute</param>
    /// <param name="inherit">Checks inheritance tree if true</param>
    /// <returns></returns>
    public override bool IsDefined(Type attributeType, bool inherit)
    {
        return _memberInfo.IsDefined(attributeType, inherit);
    }

    /// <summary>
    /// Gets the value from the object. 
    /// </summary>
    /// <param name="obj">the object to get the value from</param>
    /// <returns>the retrieved value</returns>
    public object GetValue(object obj)
    {
        return GetValue(obj, out _);
    }

    /// <summary>
    /// Gets a value from an object, and indicates if an error occurred during that process. 
    /// </summary>
    /// <param name="obj">the object to get the value from</param>
    /// <param name="errored">true if an exception occurred during the get.</param>
    /// <returns>The value retrieved</returns>
    public object GetValue(object obj, out bool errored)
    {
        try
        {
            var result = MemberType == MemberTypes.Property
                ? DeclaringType?.GetProperty(Name, _flags)?.GetValue(obj)
                : DeclaringType?.GetField(Name, _flags)?.GetValue(obj);
            errored = false;
            return result;
        }
        catch
        {
            errored = true;
            return
                null; // throwing exceptions from a property is a bad practice. Perhaps I'll ad the ability to bypass the catch block. But i'm not feeling that generous right now.
        }
    }

    /// <summary>
    /// Sets a value on an object. 
    /// </summary>
    /// <param name="obj">The object to manipulate</param>
    /// <param name="value">The value to set.</param>
    public void SetValue(object obj, object value)
    {
        SetValue(obj, value, out _);
    }

    /// <summary>
    /// Sets a value on an object. 
    /// </summary>
    /// <param name="obj">The object to manipulate</param>
    /// <param name="value">The value to set.</param>
    /// <param name="errored">true if an exception occurred during the set.</param>
    public void SetValue(object obj, object value, out bool errored)
    {
        try
        {
            if (MemberType == MemberTypes.Property)
                DeclaringType?.GetProperty(Name, _flags)?.SetValue(obj, value);
            else
                DeclaringType?.GetField(Name, _flags)?.SetValue(obj, value);

            errored = false;
        }
        catch
        {
            errored = true;
        }
    }
}