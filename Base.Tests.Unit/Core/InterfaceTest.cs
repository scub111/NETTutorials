using System;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    class InterfaceTest
    {
        private interface INterfaceOne
        {
            void Int1Func();
            void Func();
        }

        private interface INterfaceTwo
        {
            void Int2Func();
            void Func();
        }

        public class MyClass : INterfaceOne, INterfaceTwo
        {
            public void Func()
            {
                Console.WriteLine("Func");
            }

            void INterfaceTwo.Func()
            {
                Console.WriteLine("InterfaceTwo.Func");
            }

            public void Int1Func()
            {
                Console.WriteLine("Int1Func");
            }

            public void Int2Func()
            {
                Console.WriteLine("Int2Func");
            }
        }

        [Test]
        public void TestCase()
        {
            var myClass = new MyClass();
            myClass.Int1Func();
            myClass.Int2Func();
            myClass.Func();
            ((INterfaceTwo)myClass).Func();
        }
    }
}
