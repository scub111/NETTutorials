using System;
using System.Diagnostics.Contracts;

namespace Validation
{
    public class Dog
    {
        public string Name { get; private set; }
        public void SetName(string name)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(name), "value is empty");
            Contract.Requires(name.Length < 10, "too long");
            Name = name;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.SetName(null);

            Console.ReadKey();
        }
    }
}
