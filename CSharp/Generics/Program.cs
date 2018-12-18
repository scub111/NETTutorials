using System;

namespace Generics
{
    class Program
    {
        public class Animal<T> where T : Offspring
        {
            public T Offspring { get; set; }
        }

        public abstract class Offspring { }

        public class Egg : Offspring { }

        public class Piglet : Offspring { }

        enum Dogs { dog1, dog2, dog3}

        static void Main(string[] args)
        {
            var bird = new Animal<Egg>();
            var pig = new Animal<Piglet>();

            var t = 8;

            Console.WriteLine(t == 81 ? "yes" : "No");

            var temp = Dogs.dog3;

            switch (temp)
            {
                case Dogs.dog1:
                case Dogs.dog2:
                    Console.WriteLine("hello");
                    break;

                default:
                    //throw new NotSupportedException();
                    break;
            }

            var str = "temp";

            var outStr = string.Concat(str, "word");

            Console.ReadLine();
        }
    }
}
