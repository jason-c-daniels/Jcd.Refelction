using System;
using System.Collections.Generic;

namespace Jcd.Reflection.Tests
{
    class TestClassC : TestClassB
    {
        public List<int> IntList = new List<int>(new[] { 1, 2, 3, 4, 5 });

        public Dictionary<string, int> IntDict = new(new[]
            {
                new KeyValuePair<string, int>("Foo", 2),
                new KeyValuePair<string, int>("Bar", 3),
                new KeyValuePair<string, int>("Cat", 4)
            }
        );

        public int ExceptionalProperty
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}