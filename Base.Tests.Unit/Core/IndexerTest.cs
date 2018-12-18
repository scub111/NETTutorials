using System;
using System.Collections.ObjectModel;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class IndexerTest
    {
        public class Person
        {
            public string Name { get; set; }

            public string Surname { get; set; }

            public override string ToString()
            {
                return string.Format("{0} - {1}", Name, Surname);
            }
        }

        public class Persons
        {
            public Persons()
            {
                _persons = new Collection<Person>();
            }

            readonly Collection<Person> _persons;

            public void Add(Person person)
            {
                _persons.Add(person);
            }

            /// <summary>
            /// Common indexer syntax.
            /// </summary>
            public Person this[int index]
            {
                get => _persons[index];
                set => _persons[index] = value;
            }

            public int Count => _persons.Count;
        }

        [Test]
        public void TestCase()
        {
            var persons = new Persons();
            persons.Add(new Person { Name = "heelo", Surname = "dfds" });
            persons.Add(new Person { Name = "sdf", Surname = "2233" });
            persons.Add(new Person { Name = "111", Surname = "111" });
            persons.Count.Should().Be(3);

            for (var i = 0; i < persons.Count; i++)
                Console.WriteLine(persons[i]);

            persons[0] = new Person { Name = "11", Surname = "2" };
            persons[0].Name.Should().Be("11");
            persons[0].Surname.Should().Be("2");
            Console.WriteLine(persons[0]);

        }
    }
}
