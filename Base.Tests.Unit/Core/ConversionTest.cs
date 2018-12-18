using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class ConversionTest
    {
        public class TestClass
        {
            public int Value1 { get; set; }

            public int Value2 { get; set; }

            protected int MyProperty { get; set; }


            public static implicit operator int(TestClass testClass)
            {
                return testClass.Value1 + testClass.Value2;
            }

            public static explicit operator double(TestClass testClass)
            {
                return testClass.Value1 * 3;
            }
        }

        [Test]
        public void TestCase()
        {
            var testClass = new TestClass
            {
                Value1 = 8,
                Value2 = 3
            };

            int intValue = testClass;
            intValue.Should().Be(11);

            var doubleValue = (double)testClass;
            doubleValue.Should().Be(24);
        }
    }
}
