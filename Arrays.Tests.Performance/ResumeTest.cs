using System;
using System.Diagnostics;
using FluentAssertions;
using NUnit.Framework;

namespace Arrays.Tests.Performance
{
    [TestFixture]
    public class ResumeTest
    {
        [TestCase("ArrayIntTest")]
        [TestCase("ArrayListIntTest")]
        [TestCase("ListIntTest")]
        [TestCase("CollectionIntTest")]
       public void TestCase(string typeName)
        {
            const int count = 1000000;

            var typeNameFull = "Arrays.Tests.Performance." + typeName;
            Console.WriteLine($"{typeName} {count} items");

            var type = Type.GetType(typeNameFull);

            if (type != null)
            {
                var arrayTest = (IArrayIntTest)Activator.CreateInstance(type);

                arrayTest.SetCapacity(count);

                var sw = new Stopwatch();
                sw.Restart();
                for (var i = 0; i < count; i++)
                    arrayTest.Add(i);
                sw.Stop();

                arrayTest.Count.Should().Be(count);

                Console.WriteLine($"Add: {sw.ElapsedMilliseconds:0} ms");

                sw.Restart();
                var res = 0;
                for (var i = 0; i < count; i++)
                    res = arrayTest[i];
                sw.Stop();

                Console.WriteLine($"Read: {sw.ElapsedMilliseconds:0} ms");
            }
        }
    }
}
