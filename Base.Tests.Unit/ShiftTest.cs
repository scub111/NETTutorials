using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class ShiftTest
    {
        [Test]
        public void TestCase()
        {
            var b = 8 >> 1;
            b.Should().Be(4);

            b = 8 >> 2;
            b.Should().Be(2);

            b = 8 << 2;
            b.Should().Be(32);
        }
    }
}
