using System;

namespace Basic
{
    public class Approach3
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
            private readonly ICar _car;

            public Driver(ICar car)
            {
                _car = car;
            }

            public void RunCar()
            {
                Console.WriteLine($"Running {_car.GetType().Name} - {_car.Run()} miles");
            }
        }
    }
}
