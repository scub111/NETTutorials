using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class PolymorphismTest
    {
        public class A
        {
            public virtual void Print()
            {
                Console.WriteLine("A");
            }
        }

        public class B : A
        {
            public override void Print()
            {
                Console.WriteLine("B");
                base.Print();
            }
        }

        [Test]
        public void TestCase()
        {
            A b = new B();
            b.Print();
        }
    }
}
