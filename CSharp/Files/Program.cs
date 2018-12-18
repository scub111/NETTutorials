using System;
using System.Diagnostics;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = Directory.GetCurrentDirectory();

            const string fileName = "Info.txt";

            File.WriteAllText(fileName, dir);

            var outStr = File.ReadAllText(fileName);

            Trace.Assert(dir.Equals(outStr), "error");

             
            foreach (var item in Directory.GetFiles(dir))
                Console.WriteLine("{0} - {1}", Path.GetFileName(item), new FileInfo(item).Length);

            Console.Read();
        }
    }
}
