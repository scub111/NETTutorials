using System;
using System.Threading;

namespace Thread
{
    class Program
    {
        static void DoSomething()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(string.Format("Thread do something - {0}", i));
                System.Threading.Thread.Sleep(1000);
            }
        }

        public static void DoSomethingEx(object iter)
        {
            var iIter = (int)iter;
            for (var i = 0; i < iIter; i++)
            {
                Console.WriteLine(string.Format("Thread do something - {0}", i));
                System.Threading.Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            //System.Threading.Thread thread = new System.Threading.Thread(DoSomething);
            //thread.IsBackground = true;
            //thread.Start();
            var thread = new System.Threading.Thread(new ParameterizedThreadStart(DoSomethingEx));
            thread.Start(5);

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Format("Main executes - {0}", i));
                System.Threading.Thread.Sleep(1000);
            }

            //Console.Read();

            thread.Join();
        }
    }
}
