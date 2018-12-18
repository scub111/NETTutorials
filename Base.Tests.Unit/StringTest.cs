using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class StringTest
    {
        [Test]
        public void TestCase()
        {
            var s1 = "Hello";
            Console.WriteLine($"s1 = {s1}");
            s1 = new string(new [] {'d', '2'});
            var s2 = s1;
            Console.WriteLine($"s2 = {s2}");
            s2 = "---";
            Console.WriteLine($"s2 = {s2}");

            s2 += ", World";

            TryChange(s1);
            Console.WriteLine($"s1 = {s1}");
            Console.WriteLine($"s2 = {s2}");

            Change(ref s1);
            Console.WriteLine($"s1 = {s1}");
        }

        void TryChange(string str)
        {
            str += ", World";
        }

        void Change(ref string str)
        {
            str += ", World";
        }
    }
}
