using System;

namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(30000));
            Console.WriteLine(Calculate(10000));
            Console.WriteLine(Calculate(40000));
            Console.WriteLine(Calculate(20000));
        }

        public static long Calculate(int value)
        {
            long result = 0;
            for (var i1 = 0; i1 < value; i1++)
                for (var i2 = 0; i2 < value; i2++)
                   result += value;
            return result;
        }
    }
}
