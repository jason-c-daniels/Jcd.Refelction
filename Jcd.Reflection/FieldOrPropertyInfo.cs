using System;
using System.Reflection;
using Jcd.Validations;

namespace Jcd.Reflection
{
   /// <summary>
   /// 
   /// </summary>
   public class FieldOrPropertyInfo : MemberInfo
   {
      private readonly MemberInfo _memberInfo;
      private readonly BindingFlags _flags;
      /// <summary>
      /// 
      /// </summary>
      /// <param name="memberInfo"></param>
      /// <param name="flags"></param>
      public FieldOrPropertyInfo(MemberInfo memberInfo, BindingFlags flags)
      {
         Argument.IsNotNull(memberInfo, nameof(memberInfo));
         Argument.PassesAny(new Check.Signature<MemberInfo>[] { (mi, s, f) => mi.MemberType == MemberTypes.Field, (mi, s, f) => mi.MemberType == MemberTypes.Property }, memberInfo, nameof(memberInfo), $"memberInfo.MemberType must be a Property or Field but was {memberInfo.MemberType}");
         _flags = flags;
         _memberInfo = memberInfo;
      }

      /// <summary>
      /// 
      /// </summary>
      public override Type DeclaringType => _memberInfo.DeclaringType;

      /// <summary>
      /// 
      /// </summary>
      public override MemberTypes MemberType => _memberInfo.MemberType;

      /// <summary>
      /// 
      /// </summary>
      public override string Name => _memberInfo.Name;

      /// <summary>
      /// 
      /// </summary>
      public override Type ReflectedType => _memberInfo.ReflectedType;

      /// <summary>
      /// 
      /// </summary>
      /// <param name="inherit"></param>
      /// <returns></returns>
      public override object[] GetCustomAttributes(bool inherit) => _memberInfo.GetCustomAttributes(inherit);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="attributeType"></param>
      /// <param name="inherit"></param>
      /// <returns></returns>
      public override object[] GetCustomAttributes(Type attributeType, bool inherit) => _memberInfo.GetCustomAttributes(attributeType, inherit);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="attributeType"></param>
      /// <param name="inherit"></param>
      /// <returns></returns>
      public override bool IsDefined(Type attributeType, bool inherit) => _memberInfo.IsDefined(attributeType, inherit);

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      public object GetValue(object obj)
      {
         return GetValue(obj, out _);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="errored"></param>
      /// <returns></returns>
      public object GetValue(object obj, out bool errored)
      {
         try
         {
            var result = MemberType == MemberTypes.Property ? DeclaringType?.GetProperty(Name, _flags)?.GetValue(obj) : DeclaringType?.GetField(Name, _flags)?.GetValue(obj);
            errored = false;
            return result;
         }
         catch
         {
            errored = true;
            return null; // throwing exceptions from a property is a bad practice. Perhaps I'll ad the ability to bypass the catch block. But i'm not feeling that generous right now.
         }
      }
      
      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      public void SetValue(object obj, object value)
      {
         SetValue(obj, value, out _);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="obj"></param>
      /// <param name="value"></param>
      /// <param name="errored"></param>
      public void SetValue(object obj, object value , out bool errored)
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
}
