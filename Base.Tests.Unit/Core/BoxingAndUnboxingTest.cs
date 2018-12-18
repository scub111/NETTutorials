using System;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    internal class BoxingAndUnboxingTest
    {
        /// <summary>
        /// Implement boxing.
        /// </summary>
        private static object Boxing()
        {
            const int val = 1;
            object obj = val;
            return obj;
        }

        /// <summary>
        /// Implement unboxing.
        /// </summary>
        private static int UnBoxing(object obj)
        {
            return (int)obj;
        }
        
        [Test]
        public void TestCase()
        {
            var box = Boxing();
            var val = UnBoxing(box);
            val.Should().Be(1);
        }

        [Test]
        public void ComplexTestCase()
        {
            var val1 = 1;
            var obj = (object) val1;

            Console.WriteLine(val1);
            Console.WriteLine(obj);


            val1 = 2;
            Console.WriteLine(val1);
            Console.WriteLine(obj);

            var val2 = (int) obj;
            Console.WriteLine(val2);

            (val1 != val2).Should().BeTrue();
        }

        public struct A
        {
            public A(int a)
            {
                Val = a;
            }

            public int Val;
        }

        public struct B
        {
            public int Val1;
            public int Val2;

            public B(int val1)
            {
                Val1 = val1;
                Val2 = 0;
            }
        }

        [Test]
        public void ComplexStructTestCase()
        {
            var a = new A(2);
            Console.WriteLine(a.Val);
            B b;
            b.Val1 = 12;
            Console.WriteLine(b.Val1);

        }
    }
}
