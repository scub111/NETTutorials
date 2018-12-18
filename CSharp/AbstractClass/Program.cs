using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        abstract class AbsClass
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

        class Person: AbsClass
        {
            public Person() : base ("John")
            {
                Surname = "Surname";
            }

            public override int MyProperty
            {
                get
                {
                    return 3;
                }

                set
                {
                    ;
                }
            }

            public string Surname { get; set; }
            public override void AbstractMethod()
            {
                Surname = "sdf";
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person();
        }
    }
}
