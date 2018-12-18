using System;
using System.Linq;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataBaseEntities();
            //var table = context.Table;
            var table = context.Table.Where(row => row.Id > 3);
            foreach (var row in table)
                Console.WriteLine(string.Format("{0} - {1}", row.Id, row.Name));

            Console.Read();
        }
    }
}
