using System;
using Unity.Attributes;

namespace Basic
{
    public class Approach6
    {
        public interface ICar
        {
            int Run();
        }

        public class BMW : ICar
        {
            private int _miles;


            public int Run()
            {
                return ++_miles;
            }
        }

        public class Ford : ICar
        {
            private int _miles;

            public int Run()
            {
                return ++_miles;
            }
        }

        public class Audi : ICar
        {
            private int _miles;

            public int Run()
            {
                return ++_miles;
            }
        }

        public class Driver
        {
            [Dependency]
            public ICar Car { get; set; }

            public void RunCar()
            {
                Console.WriteLine($"Running {Car.GetType().Name} - {Car.Run()} miles");
            }
        }
    }
}
