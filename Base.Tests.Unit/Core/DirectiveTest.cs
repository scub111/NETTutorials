using System;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    class DirectiveTest
    {
        [Test]
        public void TestCase()
        {
#line hidden
            Console.WriteLine("Hidden");
#line default
            Console.WriteLine("Write something");
        }
    }
}
