using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace InterfaceEnumerator
{
    class Program
    {
        [DebuggerDisplay("Name ={Name} {Surname}")]
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

        public class Persons : IEnumerator<Person>
        {
            public Person Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
