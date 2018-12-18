using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    class Program
    {
        class MyClass
        {
            public MyClass()
            {
                value = 0;
            }
            public int value;
        }

        static void Func1()
        {
            var value = 0;
            var myClass = new MyClass();

            var iter = 10000000;

            var task = new Task(() =>
            {
                for (var i = 0; i < iter; i++)
                {
                    value--;
                    myClass.value++;
                }
            });
            task.Start();

            for (var i = 0; i < iter; i++)
            {
                value++;
                myClass.value--;
            }

            task.Wait();

            Console.WriteLine(string.Format("value - {0}", value));
            Console.WriteLine(string.Format("myClass.value - {0}", myClass.value));
        }

        static void Func2()
        {
            var value = 0;
            var myClass = new MyClass();

            var locSync = new object();

            var iter = 10000000;

            var task = new Task(() =>
            {
                for (var i = 0; i < iter; i++)
                {
                    lock (locSync)
                    {
                        value--;
                        myClass.value++;
                    }
                }
            });
            task.Start();

            for (var i = 0; i < iter; i++)
            {
                lock (locSync)
                {
                    value++;
                    myClass.value--;
                }
            }

            task.Wait();

            Console.WriteLine(string.Format("value - {0}", value));
            Console.WriteLine(string.Format("myClass.value - {0}", myClass.value));
        }

        static void Func3()
        {
            var value = 0;
            var myClass = new MyClass();

            var locSync = new object();

            var iter = 10000000;

            var task = new Task(() =>
            {
                for (var i = 0; i < iter; i++)
                {
                    Interlocked.Add(ref value, -1);
                    Interlocked.Add(ref myClass.value, -1);
                }
            });
            task.Start();

            for (var i = 0; i < iter; i++)
            {
                Interlocked.Add(ref value, 1);
                Interlocked.Add(ref myClass.value, 1);
            }

            task.Wait();

            Console.WriteLine(string.Format("value - {0}", value));
            Console.WriteLine(string.Format("myClass.value - {0}", myClass.value));
        }

        static void Main(string[] args)
        {
            Func1();
            Console.WriteLine("---With lock synchronization---");
            Func2();
            Console.WriteLine("---With Interlocked synchronization---");
            Func3();
            Console.ReadKey();
        }
    }
}
