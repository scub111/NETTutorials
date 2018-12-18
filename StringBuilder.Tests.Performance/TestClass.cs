
using System;
using System.Diagnostics;
using NUnit.Framework;

namespace StringBuilder.Tests.Performance
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestCase()
        {
            const int count = 10000;
            const string append = "12345678";
            var str = "";
            var sw = new Stopwatch();
            sw.Restart();
            for (var i = 0; i < count; i++)
                str += append;
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds: 0} ms");

            sw.Restart();
            var sb = new System.Text.StringBuilder();
            for (var i = 0; i < count; i++)
                sb.Append(append);

            var strOut = sb.ToString();
            sw.Restart();
            Console.WriteLine($"{sw.ElapsedMilliseconds: 0} ms");
        }
    }
}
