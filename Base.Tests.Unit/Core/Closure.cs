using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class ClosureTest
    {
        [Test]
        public void TestCase()
        {
            var capturedVariable = "";

            Action x = () =>
            {
                capturedVariable = "local variable";
                Console.WriteLine($"act - {capturedVariable}");
            };
            x.Invoke();
            Console.WriteLine($"main - {capturedVariable}");

            capturedVariable.Should().BeEquivalentTo("local variable");

            var counter = 5;
            for (var i = 0; i < 10; i++)
            {
                Action con = () =>
                {
                    Console.WriteLine(counter);
                    counter++;
                };
                con();
            }
        }

        [Test]
        public void RextesterTest()
        {
            var funcs = new List<Action>();

            for (var i = 0; i < 4; i++)
                funcs.Add(() => Console.WriteLine(i));

            foreach (var func in funcs)
                func();
        }
    }
}
