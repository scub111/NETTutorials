using System;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class ConstructorTest
    {
        public class BaseClass
        {
            public BaseClass()
            {
                Surname = "Smith";
                Console.WriteLine("Surname");
            }

            public BaseClass(string name) : this()
            {
                Name = name;
                Console.WriteLine("Name");
            }

            public string Surname { get; set; }

            public string Name { get; set; }
        }

        public class DerivedClass : BaseClass
        {
            public DerivedClass()
            { }

            public DerivedClass(int salary) : base("Jonh")
            {
                Salary = salary;
                Console.WriteLine("Salary");
            }
            public int Salary { get; set; }
        }

        [Test]
        public void TestCase()
        {
            var derivedClass = new DerivedClass(30);
            derivedClass.Name.Should().Be("Jonh");
        }
    }
}
