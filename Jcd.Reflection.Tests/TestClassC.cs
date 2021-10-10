using System;
using System.Collections.Generic;

namespace Jcd.Reflection.Tests
{
    internal class TestClassC : TestClassB
    {
        // ReSharper disable once ArrangeObjectCreationWhenTypeEvident
        // ReSharper disable once UnusedMember.Global
        public List<int> IntList = new List<int>(new[] { 1, 2, 3, 4, 5 });

        // ReSharper disable once FieldCanBeMadeReadOnly.Global
        public Dictionary<string, int> IntDict = new(new[]
            {
                new KeyValuePair<string, int>("Foo", 2),
                new KeyValuePair<string, int>("Bar", 3),
                new KeyValuePair<string, int>("Cat", 4)
            }
        );

        // ReSharper disable once UnusedMember.Global
        public int ExceptionalProperty
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        // ReSharper disable once UnusedMember.Global
        public int Add(int a, int b) => op_Add(a,b);
        // ReSharper disable once MemberCanBeMadeStatic.Local
        #pragma warning disable CA1822
        // this is actually called as a member via reflection in a unit test.
        // compiler warning needs to be disabled for it as a result. 
        private int op_Add(int a, int b) => a + b;
        #pragma warning restore CA1822

        // ReSharper disable once UnusedMember.Global
        public static int Sub(int a, int b) => op_Sub(a, b);

        private static int op_Sub(int a, int b) => a - b;
    }
}