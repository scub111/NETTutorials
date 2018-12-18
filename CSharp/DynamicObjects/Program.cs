using System;
using System.Dynamic;

namespace CSharp_DynamicObjects
{
    class Program
    {
        // https://www.oreilly.com/learning/building-c-objects-dynamically

        static void Dynamic1()
        {
            dynamic obj = new ExpandoObject();
            obj.City = 1;
            obj.City = "New York 1";
            Console.WriteLine(obj.City);
        }

        static void Dynamic2()
        {
            var obj = new { City = "New York 2" };
            Console.WriteLine(obj.City);
        }

        static void Dynamic3()
        {
            dynamic obj = new { City = "New York 3" };
            Console.WriteLine(obj.City);
        }


        // https://www.codeproject.com/Tips/460614/Difference-between-var-and-dynamic-in-Csharp
        static void Dynamic4()
        {
            // var type must be initialized.
            var temp = "23";

            // Meanwhile dynamic type no need to initialized
            dynamic temp2 = 23;

            Console.WriteLine(temp);
            Console.WriteLine(temp2);
        }

        static void SetToTenWithRef(ref int number)
        {
            number += 10;
        }

        static void SetToTenWithOut(out int number)
        {
            number = 10;
        }

        static void Main(string[] args)
        {
            Dynamic1();
            Dynamic2();
            Dynamic3();
            Dynamic4();

            Console.WriteLine("---ref---");
            var t = 10;
            Console.WriteLine(t);
            SetToTenWithRef(ref t);
            Console.WriteLine(t);

            Console.WriteLine("---out---");
            int t2;
            SetToTenWithOut(out t2);
            Console.WriteLine(t2);

            Console.Read();
        }
    }
}
