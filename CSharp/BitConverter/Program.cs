using System;

namespace BitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var theDateTime = new DateTime(2010, 1, 1);
            var b = System.BitConverter.GetBytes(theDateTime.Ticks);

            var d = DateTime.FromBinary(System.BitConverter.ToInt64(b, 0));

        }
    }
}
