using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    class GenericTest
    {
        public class Animal<T> where T : Offspring , new()
        {
            public Animal()
            {
                Offspring = new T();
                //Offspring = Activator.CreateInstance<T>();
            }

            public T Offspring { get; set; }
        }

        public abstract class Offspring
        {
            protected Offspring()
            {
                Age = 23;
            }
            public int Age;
        }

        public class Egg : Offspring { }

        public class Piglet : Offspring { }

        [Test]
        public void TestCase()
        {
            var bird = new Animal<Egg>();
            bird.Offspring.Age.Should().Be(23);
            var pig = new Animal<Piglet>();
            pig.Offspring.Age.Should().Be(23);
        }
    }
}
