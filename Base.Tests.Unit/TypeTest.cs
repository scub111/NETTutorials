using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class TypeTest
    {
        public class A { }

        public class B : A { }


        public void Print<T>(T t)
        {
            Console.WriteLine(typeof(T).Name);
            Console.WriteLine(t.GetType().Name);
        }

        [Test]
        public void TestCase()
        {
            A b = new B();
            Print(b);
            Console.WriteLine("----");
            Print<A>(b);
            Console.WriteLine("----");
            Print((B)b);
        }
    }
}
