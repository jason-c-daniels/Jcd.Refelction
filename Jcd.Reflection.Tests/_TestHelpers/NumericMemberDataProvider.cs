#region

using System;
using System.Numerics;

using Xunit;

// ReSharper disable HeapView.ObjectAllocation

// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedMember.Global

#endregion

namespace Jcd.Reflection.Tests._TestHelpers;

#pragma warning disable CA2021
/// <summary>
/// An XUnit data provider. This one provides lists of numeric data of a various sorts.
/// </summary>
public class NumericMemberDataProvider
{
   /// <summary>
   /// Provides a set of BigIntegers
   /// </summary>
   public static TheoryData<BigInteger> BigIntegerList()
   {
      return new TheoryData<BigInteger>([
                                           new BigInteger(ulong.MaxValue) * 2, new BigInteger(ulong.MinValue) * 2, 1, 2
                                        ]
                                       );
   }

   /// <summary>
   /// Provides a set of Bytes
   /// </summary>
   public static TheoryData<byte> ByteList() { return new TheoryData<byte>([byte.MaxValue, byte.MinValue, 1, 2]); }

   /// <summary>
   /// Provides a set of Decimals
   /// </summary>
   public static TheoryData<decimal> DecimalList()
   {
      return new TheoryData<decimal>([decimal.MaxValue, decimal.MinValue, 1, 2]);
   }

   /// <summary>
   /// Provides a set of Doubles
   /// </summary>
   public static TheoryData<double> DoublePrecisionFloatList()
   {
      return new TheoryData<double>([double.MaxValue, double.MinValue, 1, 2]);
   }

   /// <summary>
   /// Provides a set of Int16s
   /// </summary>
   public static TheoryData<short> Int16List() { return new TheoryData<short>([short.MaxValue, short.MinValue, 1, 2]); }

   /// <summary>
   /// Provides a set of Int32s
   /// </summary>
   public static TheoryData<int> Int32List() { return new TheoryData<int>([int.MaxValue, int.MinValue, 1, 2]); }

   /// <summary>
   /// Provides a set of Int64s
   /// </summary>
   public static TheoryData<long> Int64List() { return new TheoryData<long>([long.MaxValue, long.MinValue, 1, 2]); }

   /// <summary>
   /// Provides a set of non-numeric data.
   /// </summary>
   public static TheoryData<object> NonNumbersCollection()
   {
      #pragma warning disable CA1861
      return new TheoryData<object>([new object(), new[] { 1, 2, 3 }, new Exception()]);
      #pragma warning restore CA1861
   }

   /// <summary>
   /// Provides a set of signed bytes
   /// </summary>
   public static TheoryData<sbyte> SByteList() { return new TheoryData<sbyte>([sbyte.MaxValue, sbyte.MinValue, 1, 2]); }

   /// <summary>
   /// Provides a set of Singles
   /// </summary>
   public static TheoryData<float> SinglePrecisionFloatList()
   {
      return new TheoryData<float>([float.MaxValue, float.MinValue, 1, 2]);
   }

   /// <summary>
   /// Provides a set of UInt16s
   /// </summary>
   public static TheoryData<ushort> UInt16List()
   {
      return new TheoryData<ushort>([ushort.MaxValue, ushort.MinValue, 1, 2]);
   }

   /// <summary>
   /// Provides a set of UInt32s
   /// </summary>
   public static TheoryData<uint> UInt32List() { return new TheoryData<uint>([uint.MaxValue, uint.MinValue, 1, 2]); }

   /// <summary>
   /// Provides a set of UInt64s
   /// </summary>
   public static TheoryData<ulong> UInt64List()
   {
      return new TheoryData<ulong>([ulong.MaxValue, ulong.MinValue, 1, 2]);
   }

   /// <summary>
   /// Provides a set of BigIntegers from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciBigIntegerList()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(long.MaxValue * (BigInteger) 15));
   }

   /// <summary>
   /// Provides a set of UInt64s from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciUInt64List()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(ulong.MaxValue));
   }

   /// <summary>
   /// Provides a set of Int64s from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciInt64List()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(long.MaxValue));
   }

   /// <summary>
   /// Provides a set of UInt32s from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciUInt32List()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(uint.MaxValue));
   }

   /// <summary>
   /// Provides a set of Int32s from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciInt32List()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(int.MaxValue));
   }

   /// <summary>
   /// Provides a set of UInt16s from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciUInt16List()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(ushort.MaxValue));
   }

   /// <summary>
   /// Provides a set of Int16s from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciInt16List()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(short.MaxValue));
   }

   /// <summary>
   /// Provides a set of Bytes from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciByteList()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(byte.MaxValue));
   }

   /// <summary>
   /// Provides a set of SBytes from the fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> FibonacciSByteList()
   {
      return new TheoryData<BigInteger>(new NaiiveFibonacciGenerator(sbyte.MaxValue));
   }

   /// <summary>
   /// Provides a set of SBytes from the negative fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> NegativeFibonacciSByteList()
   {
      return new TheoryData<BigInteger>(new NegativeNaiiveFibonacciGenerator(sbyte.MinValue));
   }

   /// <summary>
   /// Provides a set of Int16s from the negative fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> NegativeFibonacciInt16List()
   {
      return new TheoryData<BigInteger>(new NegativeNaiiveFibonacciGenerator(short.MinValue));
   }

   /// <summary>
   /// Provides a set of Int32s from the negative fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> NegativeFibonacciInt32List()
   {
      return new TheoryData<BigInteger>(new NegativeNaiiveFibonacciGenerator(int.MinValue));
   }

   /// <summary>
   /// Provides a set of Int64s from the negative fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> NegativeFibonacciInt64List()
   {
      return new TheoryData<BigInteger>(new NegativeNaiiveFibonacciGenerator(long.MinValue));
   }

   /// <summary>
   /// Provides a set of BigIntegers from the negative fibonacci sequence,
   /// </summary>
   public static TheoryData<BigInteger> NegativeFibonacciBigIntegerList()
   {
      return new TheoryData<BigInteger>(new NegativeNaiiveFibonacciGenerator(long.MinValue * (BigInteger) 15));
   }
}
#pragma warning restore CA2021