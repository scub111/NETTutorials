using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    public class TestClass
    {
        public int Field { get; set; }
    }

    public static class TestClassExtention
    {
        public static void SetField(this TestClass testClass)
        {
            testClass.Field = 9;
        }

        public static void SetField2(this TestClass testClass, int value)
        {
            testClass.Field = value;
        }
    }


    [TestFixture]
    public class ExtensionTest
    {
        [Test]
        public void TestCase()
        {
            var testClass = new TestClass();
            testClass.Field.Should().Be(0);

            testClass.SetField();
            testClass.Field.Should().Be(9);

            testClass.SetField2(5);
            testClass.Field.Should().Be(5);
        }
    }
}
