using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Base.Common
{
    [TestFixture]
    public class UnsafeTest
    {
        [Test]
        public void TestCase()
        {
            unsafe
            {
                var t = 7;
                var pt = &t;
                var count = 1000000;
                Console.WriteLine($"stackalloc {count} items");
                int* pArr = stackalloc int[count];
                var sw = new Stopwatch();
                sw.Restart();
                for (var i = 0; i < count; i++)
                    *(pArr + i) = i;
                sw.Stop();
                Console.WriteLine($"Add - {sw.ElapsedMilliseconds:0} ms");

                var readVar = 0;
                sw.Restart();
                for (var i = 0; i < count; i++)
                    readVar = *(pArr + i);
                sw.Stop();
                Console.WriteLine($"Read - {sw.ElapsedMilliseconds:0} ms");
                Console.WriteLine($"Last item - {readVar}");
            }
        }
    }
}
