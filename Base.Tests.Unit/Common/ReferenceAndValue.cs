using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    /// <summary>
    /// Test transfer values by references.
    /// </summary>
    [TestFixture]
    public class ReferenceAndValue
    {
        private class A
        {
            public int IntValue;
            public double DoubleValue;
            public string StringValue;
        }

        [Test]
        public void ModifyClassValueByExternalFunction()
        {
            var a = new A {
                IntValue = 3
                , DoubleValue = 7
                , StringValue = "init"};
            ModifyClassValuesByRef(a, 28, 78, "test");
            a.IntValue.Should().Be(28);
            a.DoubleValue.Should().Be(78);
            a.StringValue.Should().Be("test");

            ModifyClassValuesByRefWithTryToReplacePointer(a, 28, 78, "test");
            a.IntValue.Should().Be(28);
            a.DoubleValue.Should().Be(78);
            a.StringValue.Should().Be("test");

            ModifyClassValuesByRefWithReplacePointer(ref a, 28, 78, "test");
            a.IntValue.Should().Be(-1);
            a.DoubleValue.Should().Be(-2);
            a.StringValue.Should().Be("---");

            var intRef = 17;
            ModifyValueByRef(ref intRef, 89);

            intRef.Should().Be(89);

            GetOutValue(78, out var intOut);
            intOut.Should().Be(78);
        }

        #region Transfer class (reference type)
        private static void ModifyClassValuesByRef(A a, int intValue, double doubleValue, string stringValue)
        {
            a.IntValue = intValue;
            a.DoubleValue = doubleValue;
            a.StringValue = stringValue;
        }

        private static void ModifyClassValuesByRefWithTryToReplacePointer(A a, int intValue, double doubleValue, string stringValue)
        {
            a.IntValue = intValue;
            a.DoubleValue = doubleValue;
            a.StringValue = stringValue;

            a = new A
            {
                IntValue = -1,
                DoubleValue = -2,
                StringValue = "---"
            };
        }

        private static void ModifyClassValuesByRefWithReplacePointer(ref A a, int intValue, double doubleValue, string stringValue)
        {
            a.IntValue = intValue;
            a.DoubleValue = doubleValue;
            a.StringValue = stringValue;

            a = new A
            {
                IntValue = -1,
                DoubleValue = -2,
                StringValue = "---"
            };
        }
        #endregion

        #region Transfer integer (value type)
        private static void ModifyValueByRef(ref int value, int newValue)
        {
            value = newValue;
        }

        private static void GetOutValue(int initValue, out int outValue)
        {
            outValue = initValue;
        }
        #endregion
    }
}
