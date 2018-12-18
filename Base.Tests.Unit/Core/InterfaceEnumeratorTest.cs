using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    class InterfaceEnumeratorTest
    {
        [DebuggerDisplay("Name = {Name} {Surname}")]
        public class Person
        {
            public Person(string name, string surname)
            {
                Name = name;
                Surname = surname;
            }

            public string Name { get; set; }

            public string Surname { get; set; }

            public override string ToString()
            {
                return string.Format("{0} - {1}", Name, Surname);
            }
        }

        [DebuggerDisplay("Count = {persons.Length}")]
        public class Persons : IEnumerable<Person>
        {
            public Persons(Person[] persons)
            {
                this.persons = persons;
            }

            public IEnumerator<Person> GetEnumerator()
            {
                for (var i = 0; i < persons.Length; i++)
                    yield return persons[i];
            }

            Person[] persons;

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        [Test]
        public void TestCase()
        {
            var list = new List<int> { 233, 23, 239, 78, 99 };

            using (var enumer = list.GetEnumerator())
            {
                while (enumer.MoveNext())
                    Console.WriteLine(enumer.Current);
            }

            var per = new Person("sd", "2332");

            Console.WriteLine("---------------------");

            var persons = new Persons(new[]
            {
                new Person("sd", "2332"),
                new Person("werr", "s324"),
                new Person("dfds", "2339")
            });

            foreach (var person in persons)
                Console.WriteLine(person.ToString());
        }
    }
}
