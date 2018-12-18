using System;

namespace InterfaceFormattable
{
    class Program
    {
        class Point : IFormattable
        {
            public int X { get; set; }

            public int Y { get; set; }

            public override string ToString()
            {
                return ToString(null, null);
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                if (format == null)
                    //return string.Format("x:{0} ; y:{1}", X, Y);
                    return $"{X} ; {Y}";
                else if (format == "x" || format == "X")
                    return string.Format("x:{0}", X);
                else if (format == "y" || format == "Y")
                    return string.Format("y:{0}", Y);
                else
                    throw new FormatException(string.Format("Invalid format {0}", format));
            }
        }


        static void Main(string[] args)
        {
            var point = new Point { X = 1, Y = 34 };
            Console.WriteLine(point.ToString(null, null));
            //Console.WriteLine(string.Format("out - {0:Yx}", point));

            
            Console.ReadKey();
        }
    }
}
