using System;
using Unity.Attributes;

namespace Basic
{
    public class Approach9
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
            private ICar _car;

            [InjectionMethod]
            public void UseCar(ICar car)
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
