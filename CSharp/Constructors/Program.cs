using System;

namespace Constructors
{
    class Program
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

            public DerivedClass(int salary) :  base("Jonh")
            {
                Salary = salary;
                Console.WriteLine("Salary");
            }
            public int Salary { get; set; }
        }

        static void Main(string[] args)
        {
            //BaseClass baseClass = new BaseClass("Jonh");

            var derivedClass = new DerivedClass(30);

            Console.ReadKey();

        }
    }
}
