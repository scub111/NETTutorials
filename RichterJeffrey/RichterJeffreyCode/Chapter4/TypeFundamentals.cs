using FluentAssertions;
using NUnit.Framework;

namespace RichterJeffreyCode
{
    [TestFixture]
    public class TypeFundamentals
    {
        class Employee { }

        [Test]
        public void IsAsTest()
        {
            object o = new object();
            bool b1 = o is object;
            b1.Should().BeTrue();
            bool b2 = o is Employee;
            b2.Should().BeFalse();

            Employee e = o as Employee;
            e.Should().BeNull();
        }

        [Test]
        public void СheckedTest()
        {
            checked
            {
                SomeMethod();
                byte b = 100;
                b = (byte) (b - 200);
            }
        }

        void SomeMethod()
        {
            byte b = 100;
            b = (byte)(b - 200);
        }
    }
}
