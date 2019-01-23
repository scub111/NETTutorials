using System;
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

        abstract class AbstracClass
        {
            public abstract void Greet();

            public void Show()
            {
                Console.WriteLine("Show in abstract class");
            }
        }

        class DirivedClass : AbstracClass
        {
            public override void Greet()
            {
                Console.WriteLine("Greet in dirived class");
            }

            public void NewMethod()
            {
                Console.WriteLine("This is method in dirived method");
            }
        }

        [Test]
        public void AbstractTestCase()
        {
            var dirivedObj = new DirivedClass();
            dirivedObj.Show();
            dirivedObj.Greet();
            dirivedObj.NewMethod();
        }
    }
}
