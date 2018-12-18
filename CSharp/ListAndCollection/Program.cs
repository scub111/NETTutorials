using System;
using System.Linq;

namespace ListAndCollection
{
    class Program
    {
        static void Func1()
        {
            var list = new[] { "A", "B", "C", "D", "E", "F" };

            //var half = list.Where(t => IndexOf(t) < 3).ToList();            
        }

        static void DoSomething(int value)
        {
            Console.WriteLine(value);
        }

        static void Func2()
        {
            var list = Enumerable.Range(1, 10).ToList();
            // Correct statement.
            //list.ForEach(value => Console.WriteLine(value));

            // Correct statement.
            //list.ForEach(delegate (int value) { Console.WriteLine(value); });

            list.ForEach(DoSomething);
        }

        static void Func3()
        {
            var list = Enumerable.Range(1, 10).ToList();
            var half = list.Where((value, t) => t > 3).ToList();
            half.ForEach(value => Console.WriteLine(value));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------");
            Func1();
            Console.WriteLine("------");
            Func2();
            Console.WriteLine("------");
            Func3();
            Console.ReadLine();
        }
    }
}
