#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;

#endregion

// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Reflection;

/// <summary>
/// An extension method class providing numeric type information detection.
/// </summary>
public static class NumericExtensions
{
   #region Public Methods

   /// <summary>
   /// Indicates if an object is of an integer data type.
   /// </summary>
   /// <param name="self">The object to check</param>
   /// <returns>true if the object is of an integer data type</returns>
   public static bool IsBigIntegerType(this object self) { return self is BigInteger; }

   /// <summary>
   /// Indicates if an object is of a decimal data type.
   /// </summary>
   /// <param name="self">The object to check</param>
   /// <returns>true if the object is of a decimal data type</returns>
   public static bool IsDecimalType(this object self) { return Type.GetTypeCode(self.GetType()) == TypeCode.Decimal; }

   /// <summary>
   /// Indicates if an object is of a floating point data type.
   /// </summary>
   /// <param name="self">The object to check</param>
   /// <returns>true if the object is of a floating point data type</returns>
   public static bool IsFloatType(this object self)
   {
      // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
      switch (Type.GetTypeCode(self.GetType()))
      {
         case TypeCode.Double:
         case TypeCode.Single:

            return true;

         default:

            return false;
      }
   }

   /// <summary>
   /// Indicates if an object is of an integer data type.
   /// </summary>
   /// <param name="self">The object to check</param>
   /// <returns>true if the object is of an integer data type</returns>
   public static bool IsIntegerType(this object self)
   {
      // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
      switch (Type.GetTypeCode(self.GetType()))
      {
         case TypeCode.Byte:
         case TypeCode.SByte:
         case TypeCode.UInt16:
         case TypeCode.UInt32:
         case TypeCode.UInt64:
         case TypeCode.Int16:
         case TypeCode.Int32:
         case TypeCode.Int64:

            return true;

         default:
            return self is BigInteger;
      }
   }

   /// <summary>
   /// Indicates if an object is of a numeric data type.
   /// </summary>
   /// <param name="self">The object to check</param>
   /// <returns>true if the object is of a numeric data type</returns>
   public static bool IsNumericType(this object self)
   {
      // ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
      switch (Type.GetTypeCode(self.GetType()))
      {
         case TypeCode.Byte:
         case TypeCode.SByte:
         case TypeCode.UInt16:
         case TypeCode.UInt32:
         case TypeCode.UInt64:
         case TypeCode.Int16:
         case TypeCode.Int32:
         case TypeCode.Int64:
         case TypeCode.Decimal:
         case TypeCode.Double:
         case TypeCode.Single:

            return true;

         default:
            return self is BigInteger;
      }
   }

   private static readonly HashSet<Type> signedTypes =
   [
      ..new[]
        {
           typeof(sbyte)
         , typeof(short)
         , typeof(int)
         , typeof(long)
         , typeof(decimal)
         , typeof(float)
         , typeof(double)
         , typeof(BigInteger)
        }
   ];

   private static readonly HashSet<Type> unsignedTypes =
   [
      ..new[]
        {
           typeof(bool)
         , typeof(byte)
         , typeof(char)
         , typeof(DateTime)
         , typeof(string)
         , typeof(uint)
         , typeof(ushort)
         , typeof(ulong)
        }
   ];
   
   /// <summary>
   /// Indicates if an object is of a signed data type.
   /// </summary>
   /// <param name="self">The object to check</param>
   /// <returns>true if the object is of a signed data type</returns>
   public static bool IsSignedType(this object self)
   {
      return signedTypes.Contains(self.GetType());
   }

   /// <summary>
   /// Indicates if an object is of an unsigned data type.
   /// </summary>
   /// <param name="self">The object to check</param>
   /// <returns>true if the object is of an unsigned data type</returns>
   public static bool IsUnsignedType(this object self)
   {
      var type = self.GetType();

      if (unsignedTypes.Contains(type)) return true;
      var tc = Type.GetTypeCode(self.GetType());

      return tc is TypeCode.DBNull or TypeCode.Empty;
   }

   /// <summary>
   ///  
   /// </summary>
   public static readonly HashSet<Type> BuiltInNonPrimitiveScalars = new(new[]
                                                                         {
                                                                            typeof(DateTime)
                                                                          , typeof(DateTimeOffset)
                                                                          , typeof(TimeSpan)
                                                                          , typeof(Uri)
                                                                          , typeof(Guid)
                                                                          , typeof(string)
                                                                          , typeof(BigInteger)
                                                                         }
                                                                        );

   /// <summary>
   /// 
   /// </summary>
   /// <param name="self"></param>
   /// <param name="nonPrimitiveScalars"></param>
   /// <returns></returns>
   public static bool IsScalar(this object self, HashSet<Type> nonPrimitiveScalars = null)
   {
      return self is null or Type || self.GetType().IsScalar(nonPrimitiveScalars);
   }

   /// <summary>
   /// 
   /// </summary>
   /// <param name="type"></param>
   /// <param name="nonPrimitiveScalars"></param>
   /// <returns></returns>
   public static bool IsScalar(this Type type, HashSet<Type> nonPrimitiveScalars = null)
   {
      if (type == typeof(Type)) return true;
      nonPrimitiveScalars = nonPrimitiveScalars == null
                               ? BuiltInNonPrimitiveScalars
                               : new HashSet<Type>(nonPrimitiveScalars.Union(BuiltInNonPrimitiveScalars));

      var ti = type.GetTypeInfo();

      return ti.IsEnum || ti.IsPrimitive || nonPrimitiveScalars.Contains(type);
   }

   #endregion Public Methods
}