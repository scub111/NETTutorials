using System;

namespace VarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0.1M;
            var b = 0.2M;
            Console.WriteLine(a + b == 0.3M ? "equals" : "not equals");
        }
    }
}
