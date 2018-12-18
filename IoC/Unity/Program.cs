using System;
using Unity;
using Unity.Injection;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            //Approac1 
            var customerBusinessLogic = new Approach1.CustomerBusinessLogic();
            Console.WriteLine(customerBusinessLogic.GetCustomerName(13));
            */
            /* 
            //Approach2
            var customerService = new Approach2.CustomerService();
            Console.WriteLine(customerService.GetCustomerName(1));
            Console.ReadKey();
            */

            //Approach3



            var container = new UnityContainer();
            container.RegisterType<Approach3.ICar, Approach3.BMW>();
            container.RegisterType<Approach3.ICar, Approach3.Audi>("LuxuryCar2");
            container.RegisterType<Approach3.Driver>("LuxuryCarDriver",
                new InjectionConstructor(container.Resolve<Approach3.ICar>("LuxuryCar2")));

            var driver1 = container.Resolve<Approach3.Driver>("LuxuryCarDriver");
            driver1.RunCar();

            var driver2 = container.Resolve<Approach3.Driver>();
            driver2.RunCar();
            Console.ReadKey();
        }
    }
}
