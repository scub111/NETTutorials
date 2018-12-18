using System;
using FluentAssertions;
using NUnit.Framework;


namespace Base
{
    [TestFixture]
    public class BitConverterTest
    {
        [Test]
        public void TestCase()
        {
            var dateTime = new DateTime(2010, 1, 1);
            var bytes = BitConverter.GetBytes(dateTime.Ticks);
            var dateTime2 = DateTime.FromBinary(System.BitConverter.ToInt64(bytes, 0));
            dateTime2.Should().Be(dateTime);
        }
    }
}
