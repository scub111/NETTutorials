using System;

namespace CSharp_BoxingAndUnboxing
{
    class Program
    {
        // http://csharp.net-informations.com/language/csharp-boxing-unboxing.htm

        /// <summary>
        /// Implement boxing
        /// </summary>
        static object Boxing()
        {
            var val = 1;
            object obj = val;
            return obj;
        }

        /// <summary>
        /// Implement unboxing
        /// </summary>
        static int UnBoxing(object obj)
        {
            return (int)obj;
        }

        static void Main(string[] args)
        {
            var box = Boxing();
            var val = UnBoxing(box);
        }
    }
}
