using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class AbstractClassTest
    {
        private abstract class AbsClass
        {
            public AbsClass()
            {
                Name = "Name";
            }

            public AbsClass(string name)
            {
                Name = name;
            }

            public string Name { get; set; }
            public abstract void AbstractMethod();

            public abstract int MyProperty { get; set; }
        }

        private class Person : AbsClass
        {
            public Person() : base("John")
            {
                Surname = "Surname";
            }

            public override int MyProperty
            {
                get => 3;

                set
                {
                    ;
                }
            }

            public string Surname { get; set; }

            public override void AbstractMethod()
            {
                Surname = "SurnameChanged";
            }
        }

        [Test]
        public void TestCase()
        {
            var person = new Person();
            person.AbstractMethod();
            person.MyProperty.Should().Be(3);
            person.Surname.Should().Be("SurnameChanged");
        }
    }
}
