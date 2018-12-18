using System;
using System.Diagnostics;
using System.Threading;

namespace StopwatchClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);

            stopWatch.Reset();
            stopWatch.Start();
            Thread.Sleep(30);
            stopWatch.Stop();

            Console.WriteLine(stopWatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
