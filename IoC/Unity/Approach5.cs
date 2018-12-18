using System;
using Unity.Attributes;

namespace Basic
{
    public class Approach5
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
            private readonly string _driverName;

            [InjectionConstructor]
            public Driver(ICar car, string driverName)
            {
                _car = car;
                _driverName = driverName;
            }

            public Driver(string name) { }

            public void RunCar()
            {
                Console.WriteLine($"Running {_car.GetType().Name} name {_driverName} - {_car.Run()} miles");
            }
        }
    }
}
