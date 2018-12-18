using NUnit.Framework;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Resolution;

namespace Basic
{
    public class UnityTest
    {
        [Test]
        public void ResolveTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach3.ICar, Approach3.BMW>();

            var driver = container.Resolve<Approach3.Driver>();
            driver.RunCar();
        }

        [Test]
        public void ResolverMultipleTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach3.ICar, Approach3.Audi>();
            container.RegisterType<Approach3.ICar, Approach3.BMW>();

            var driver = container.Resolve<Approach3.Driver>();
            driver.RunCar();
        }

        [Test]
        public void ResolverNameTypeTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach3.ICar, Approach3.BMW>();
            container.RegisterType<Approach3.ICar, Approach3.Audi>("LuxuryCar");

            var bmw = container.Resolve<Approach3.ICar>();
            var audi = container.Resolve<Approach3.ICar>("LuxuryCar");
        }

        [Test]
        public void ResolverNameTypeExTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach3.ICar, Approach3.BMW>();
            container.RegisterType<Approach3.ICar, Approach3.Audi>("LuxuryCar2");
            container.RegisterType<Approach3.Driver>("LuxuryCarDriver",
                new InjectionConstructor(container.Resolve<Approach3.ICar>("LuxuryCar2")));

            var driver1 = container.Resolve<Approach3.Driver>("LuxuryCarDriver");
            driver1.RunCar();

            var driver2 = container.Resolve<Approach3.Driver>();
            driver2.RunCar();
        }

        [Test]
        public void RegisterInstanceTest()
        {
            var container = new UnityContainer();
            Approach3.ICar audi = new Approach3.Audi();
            container.RegisterInstance(audi);

            var driver1 = container.Resolve<Approach3.Driver>();
            driver1.RunCar();
            driver1.RunCar();

            var driver2 = container.Resolve<Approach3.Driver>();
            driver2.RunCar();
            driver2.RunCar();
        }

        [Test]
        public void MultipleParametersTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach4.ICar, Approach4.Audi>();
            container.RegisterType<Approach4.ICarKey, Approach4.AudiKey>();

            var driver = container.Resolve<Approach4.Driver>();
            driver.RunCar();
        }

        [Test]
        public void MultipleConstructorTestWithParameter()
        {
            var container = new UnityContainer();
            //container.RegisterType<Approach5.ICar, Approach5.Audi>();
            container.RegisterType<Approach5.Driver>(new InjectionConstructor(new Approach5.Audi(), "Steve"));

            var driver = container.Resolve<Approach5.Driver>();
            driver.RunCar();
            driver.RunCar();
        }

        [Test]
        public void PropertyTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach6.ICar, Approach6.Audi>();

            var driver = container.Resolve<Approach6.Driver>();
            driver.RunCar();
            driver.RunCar();
        }

        [Test]
        public void PropertyTestWithSpecification()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach7.ICar, Approach7.Audi>("LuxuryCar");
            container.RegisterType<Approach7.ICar, Approach7.BMW>();

            var driver = container.Resolve<Approach7.Driver>();
            driver.RunCar();
            driver.RunCar();
        }

        [Test]
        public void PropertyRunTimeTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach8.Driver>(new InjectionProperty("Car", new Approach8.Audi()));

            var driver = container.Resolve<Approach8.Driver>();
            driver.RunCar();
            driver.RunCar();
        }

        [Test]
        public void MethodTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach9.ICar, Approach9.BMW>();

            var driver = container.Resolve<Approach9.Driver>();
            driver.RunCar();
            driver.RunCar();
        }

        [Test]
        public void MethodRunTimeTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach9.Driver>(new InjectionMethod("UseCar", new Approach9.Audi()));

            var driver = container.Resolve<Approach9.Driver>();
            driver.RunCar();
            driver.RunCar();
        }

        [Test]
        public void ParameterOverrideTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach3.ICar, Approach3.Audi>();

            var driver1 = container.Resolve<Approach3.Driver>();
            driver1.RunCar();
            driver1.RunCar();

            var driver2 = container.Resolve<Approach3.Driver>(new ParameterOverride("car", new Approach3.BMW()));
            driver2.RunCar();
            driver2.RunCar();
        }

        [Test]
        public void TransientLifetimeManagerTest()
        {
            var container = new UnityContainer();
            container.RegisterType<Approach3.ICar, Approach3.Audi>(new ContainerControlledLifetimeManager());

            var driver1 = container.Resolve<Approach3.Driver>();
            driver1.RunCar();
            driver1.RunCar();

            var driver2 = container.Resolve<Approach3.Driver>();
            driver2.RunCar();
            driver2.RunCar();
        }
    }
}
