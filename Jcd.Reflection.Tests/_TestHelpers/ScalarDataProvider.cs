#region

using System;
using System.Numerics;
using System.Reflection;

using Xunit;

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident

#endregion

namespace Jcd.Reflection.Tests._TestHelpers;

/// <summary>
/// An XUnit data provider. This one provides lists of numeric data of a various sorts.
/// </summary>
public class ScalarDataProvider
{
   /// <summary>
   /// Provides a set of BigIntegers
   /// </summary>
   public static TheoryData<object> AllScalars()
   {
      var biMax = new BigInteger(ulong.MaxValue) * 2;
      Uri.TryCreate("http://google.com", UriKind.Absolute, out var uri);

      return new TheoryData<object>([
                                       typeof(int)
                                     , null
                                     , biMax
                                     , BindingFlags.CreateInstance
                                     , sbyte.MaxValue
                                     , short.MaxValue
                                     , int.MaxValue
                                     , long.MaxValue
                                     , byte.MaxValue
                                     , ushort.MaxValue
                                     , uint.MaxValue
                                     , ulong.MaxValue
                                     , DateTime.Now
                                     , DateTimeOffset.Now
                                     , TimeSpan.MaxValue
                                     , uri
                                     , Guid.Empty
                                     , "a string"
                                    ]
                                   );
   }
}