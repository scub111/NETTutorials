using System;
using System.Collections.ObjectModel;

namespace Indexer
{
    class Program
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
                persons = new Collection<Person>();
            }
            Collection<Person> persons;

            public void Add(Person person)
            {
                persons.Add(person);
            }

            public Person this[int index]
            {
                get
                {
                    return persons[index];
                }
                set
                {
                    persons[index] = value;
                }
            }

            public int Count
            {
                get { return persons.Count; }
            }
        }

        static void Main(string[] args)
        {
            var persons = new Persons();
            persons.Add(new Person { Name = "heelo", Surname = "dfds" });
            persons.Add(new Person { Name = "sdf", Surname = "2233" });
            persons.Add(new Person { Name = "111", Surname = "111" });

            for (var i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i]);
            }

            persons[0] = new Person { Name = "11", Surname = "2" };
            Console.WriteLine(persons[0]);

            Console.ReadKey();
        }
    }
}
