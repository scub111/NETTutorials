using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string version = Assembly.GetEntryAssembly().GetName().Version.ToString();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine(version);
            Console.ReadKey();
        }
    }
}
