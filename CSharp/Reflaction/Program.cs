using System;

namespace Reflaction
{
    class Program
    {
        public class Dog
        {
            public string Name { get; set; }

            public void Bark()
            {
                Console.WriteLine("Gaff!");
            }
        }

        public class Bird
        {
            public Bird(int weight)
            {
                Weight = weight;
            }
            ~Bird()
            {

            }

            public int Weight { get; private set; }
        }



        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Name = "Jack";
            //Type tDog = typeof(Dog);
            var tDog = dog.GetType();

            var dogRef = Activator.CreateInstance<Dog>();

            Console.WriteLine(tDog.Name);

            var propName = tDog.GetProperty("Name2");
            string value;
            if (propName != null)
                value = (string)propName.GetValue(dog);

            var method = tDog.GetMethod("Bark");

            if (method != null)
                method.Invoke(dog, null);

            // Run-time exception
            //Bird bird = Activator.CreateInstance<Bird>();

            var bird1 = new Bird(2);
            var bird2 = new Bird(3);

            var constructor = typeof(Bird).GetConstructors()[0];
            if (constructor != null)
                bird1 = (Bird)constructor.Invoke(new object[] { 5 });

            var constructor2 = typeof(Bird).GetConstructor(new Type[]{ typeof(int)});
            if (constructor != null)
                bird2 = (Bird)constructor2.Invoke(new object[] { 5 });

            if (bird1.Equals(bird2))
            {
                Console.WriteLine("Equals");
            }

            Console.ReadLine();
        }
    }
}
