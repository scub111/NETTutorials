using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Func1()
        {
            var isStarting = true;
            var task = new Task(new Action(() =>
            {
                while (isStarting)
                {
                    Console.WriteLine("Executing task");
                    Thread.Sleep(1000);
                }
            }));

            task.Start();

            task.Wait();

            Console.ReadKey();
            isStarting = false;
            Console.ReadKey();
        }

        static void Func2()
        {
            var task = new Task(new Action(() =>
            {
                for (var i = 0; i < 3; i++)
                {
                    Console.WriteLine("Executing task");
                    Thread.Sleep(1000);
                }
            }));

            task.Start();

            task.Wait();

            Console.ReadKey();
        }

        static void Func3()
        {
            var task = new Task<int>(new Func<int>(() => 
            {
                var result = 0;
                for (var i = 0; i < 3; i++)
                {
                    Console.WriteLine("Executing task");
                    Thread.Sleep(1000);
                    result++;
                }
                return result;
            }));

            task.Start();

            Console.WriteLine(task.Result);

            //Console.ReadKey();    
        }

        static void Func4()
        {
            var tasks = new Task[3];

            tasks[0] = new Task(new Action(() => 
            {
                Console.WriteLine("Task 1 started...");
                Thread.Sleep(1000);
            }));
            tasks[0].Start();

            tasks[1] = new Task(new Action(() =>
            {
                Console.WriteLine("Task 2 started...");
                Thread.Sleep(1000);
            }));
            tasks[1].Start();

            tasks[2] = new Task(new Action(() =>
            {
                Console.WriteLine("Task 3 started...");
                Thread.Sleep(1000);
            }));
            tasks[2].Start();

            //Task.WaitAll(tasks);
            Task.WaitAny(tasks);
        }

        static void Func5()
        {
            var tokenSource = new CancellationTokenSource();
            var tocken = tokenSource.Token;

            var task = new Task(new Action(() => 
            {
                while(!tocken.IsCancellationRequested)
                {
                    Console.WriteLine("Do something...");
                    Thread.Sleep(1000);
                }
            }));
            task.Start();

            Console.ReadKey();

            tokenSource.Cancel();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Func5();
        }
    }
}
