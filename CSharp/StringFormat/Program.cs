using System;
using System.Text;

namespace StringFormat
{
    class Program
    {
        static string TrendPointToJs(DateTime date, double val, int stat)
        {
            var stringBuilder = new StringBuilder("{");
            stringBuilder
                .Append(string.Format("\"date\":\"{0}\",\"value\":{1}", date, val))
                .Append("}");
            return stringBuilder.ToString();
        }

        static void Main(string[] args)
        {
            var varI = 32;
            decimal dt = 32;
            var output = $"varI = {varI}";


            var init = "hello world    ";

            var result = init.StartsWith("hello 2");

            var outStr = init.TrimEnd();

            var init2 = new string('s', 10);

            var out2 = TrendPointToJs(DateTime.Now, 2, 1);


            //string output = string.Format("varI = {0}", varI);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
