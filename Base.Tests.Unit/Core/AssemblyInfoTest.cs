using System;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class AssemblyInfoTest
    {
        [Test]
        public void TestCase()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine(version);
            version.Should().Be("1.0.0.0");
        }
    }
}
