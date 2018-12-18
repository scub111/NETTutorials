using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Parallels
{
    class Program
    {
        static void Func1()
        {
            Parallel.For(0, 10, new Action<int>((i) =>
            {
                Console.WriteLine(string.Format("Execute parallel {0}", i));
                Thread.Sleep(10000);
            }));
        }

        static void Func2()
        {
            var numbers = Enumerable.Range(0, 100000000);

            var t1 = DateTime.Now;

            var parallelResult1 = numbers.AsParallel()
            .Where(i => i % 2 == 0)
            .ToArray();

            var diff1 = DateTime.Now - t1;

            Console.WriteLine(string.Format("Parallel - {0:0} ms", diff1.TotalMilliseconds));


            var t2 = DateTime.Now;

            var parallelResult2 = numbers
            .Where(i => i % 2 == 0)
            .ToArray();

            var diff2 = DateTime.Now - t2;

            Console.WriteLine(string.Format("Simple - {0:0} ms", diff2.TotalMilliseconds));

            /*
            foreach (int i in parallelResult)
                Console.WriteLine(i);
            */

        }

        static void Main(string[] args)
        {
            Func2();

            Console.ReadKey();
        }
    }
}
