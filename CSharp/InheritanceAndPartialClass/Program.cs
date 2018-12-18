using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { FirstName = "Steve", LastName = "Jonson" };
            //person.HasSpoken += Person_HasSpoken;
            Console.WriteLine(person.GetName());

            person.Speak(ducation: 3);

            Console.WriteLine("------------");

            var baseClass = new BaseClass();
            var derivedClass = new DerivedClass();
            var derivedNew = new DerivedNew();
            var derivedOverwrite = new DerivedOverwrite();

            baseClass.GetName();
            derivedClass.GetName();
            derivedNew.GetName();
            derivedOverwrite.GetName();

            Console.WriteLine("((BaseClass)...).GetName()------------");

            baseClass.GetName();
            ((BaseClass)derivedClass).GetName();
            ((BaseClass)derivedNew).GetName();
            ((BaseClass)derivedOverwrite).GetName();

            Console.ReadLine();

        }

        private static void Person_HasSpoken(object sender, EventArgs e)
        {
            Console.WriteLine("person said something");            
        }
    }
}
