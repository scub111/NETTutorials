using System.Collections.Generic;
using System.Diagnostics;
using ExportToExcel;

namespace OpenXml
{
    class Program
    {
        class Man
        {
            public Man(string surname, string name)
            {
                Suname = surname;
                Name = name;
            }

            public string Name { get; }
            public string Suname { get; }
        }

        static void Main(string[] args)
        {
            /*
            var people = new List<Man>()
            {
                new Man("Biskub", "Konstantin"),
                new Man("Biskub", "Maxim"),
                new Man("Biskub", "Yulia")
            };
            */

            var sw = new Stopwatch();

            var people = new List<Man>();
            for (var i = 0; i < 50000; i++)
                people.Add(new Man($"surname {i}", $"name {i}"));

            sw.Start();
            var excel = CreateExcelFile.CreateExcelDocument(people, "temp.xlsx");
            sw.Stop();
            var time = sw.Elapsed;
        }
    }
}
