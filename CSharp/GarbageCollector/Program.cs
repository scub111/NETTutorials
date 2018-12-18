using System;
using System.IO;

namespace GarbageCollector
{
    public class ExampleClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Object was disposed.");
        }
    }
    class Program
    {
        static void DoSomething()
        {
            var exam = new ExampleClass();
        }

        static void Main(string[] args)
        {
            // It doesn't work.
            //ExampleClass exam = new ExampleClass();
            //DoSomething();

            // Works.
            using (var exam = new ExampleClass())
            {

            }

            var strOut = new byte[100];
            using (var file = File.Open("test.txt", FileMode.Open))
            {
                file.Read(strOut, 0, 3);
            }
            var file1 = File.Open("test.txt", FileMode.Open);

            // This invokes run-time error.
            var file2 = File.Open("test.txt", FileMode.Open);
            Console.ReadLine();
        }
    }
}
