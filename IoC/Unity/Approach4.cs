using System;

namespace Basic
{
    public class Approach4
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

        public interface ICarKey{}

        public class BMWKey: ICarKey{}

        public class AudiKey: ICarKey{}

        public class FordKey: ICarKey{}

        public class Driver
        {
            private readonly ICar _car;

            private readonly ICarKey _carKey;

            public Driver(ICar car, ICarKey carKey)
            {
                _car = car;
                _carKey = carKey;
            }

            public void RunCar()
            {
                Console.WriteLine($"Running {_car.GetType().Name} with {_carKey.GetType().Name} - {_car.Run()} miles");
            }
        }
    }
}
