using System;

namespace Interface
{
    class Program
    {
        interface InterfaceOne
        {
            void Int1Func();
            void Func();
        }

        interface InterfaceTwo
        {
            void Int2Func();
            void Func();
        }

        public class MyClass : InterfaceOne, InterfaceTwo
        {
            public void Func()
            {
                Console.WriteLine("Func");
            }

            void InterfaceTwo.Func()
            {
                Console.WriteLine("InterfaceTwo.Func");
            }

            public void Int1Func()
            {
                Console.WriteLine("Int1Func");
            }

            public void Int2Func()
            {
                Console.WriteLine("Int2Func");
            }
        }

        static void Main(string[] args)
        {
            var MyClass = new MyClass();
            MyClass.Int1Func();
            MyClass.Int2Func();
            MyClass.Func();
            ((InterfaceTwo)MyClass).Func();

            Console.Read();
        }
    }
}
