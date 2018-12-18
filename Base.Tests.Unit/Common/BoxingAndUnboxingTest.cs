using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    internal class BoxingAndUnboxingTest
    {
        /// <summary>
        /// Implement boxing
        /// </summary>
        private static object Boxing()
        {
            const int val = 1;
            object obj = val;
            return obj;
        }

        /// <summary>
        /// Implement unboxing
        /// </summary>
        private static int UnBoxing(object obj)
        {
            return (int)obj;
        }
        
        [Test]
        public void TestCase()
        {
            var box = Boxing();
            var val = UnBoxing(box);
            val.Should().Be(1);
        }
    }
}
