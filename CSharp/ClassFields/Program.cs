using System;

namespace ClassFields
{
    class Program
    {
        class TestClass
        {
            public TestClass()
            {
                ReadOnlyField = 7;
                ReadOnlyField = 9;
            }

            public readonly int ReadOnlyField = 19;

            public const int ConstField = 80;
        }

        static void Main(string[] args)
        {
            var testClass = new TestClass();
            Console.ReadKey();
        }
       
    }
}
