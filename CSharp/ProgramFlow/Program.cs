using System;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 7;

            if (a > 10)
            {
                Console.WriteLine("a > 10");
            }
            else if (a <= 10)
            {
                Console.WriteLine("a <= 10");
            }
            else if (a == 7)
            {
                Console.WriteLine("a == 7");
            }
            else
            {
                Console.WriteLine("a else");
            }

            Console.ReadKey();
        }
    }
}
