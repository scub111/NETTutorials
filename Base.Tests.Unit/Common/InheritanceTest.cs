using System;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class InheritanceTest
    {
        public class Shape
        {
            public string GetName()
            {
                return "shape";
            }

            public string GetName2()
            {
                return "shape";
            }
        }

        public class Ball : Shape
        {
            public string GetName()
            {
                return "ball";
            }

            public string GetName2()
            {
                return "ball";
            }
        }

        public class Pet
        {
            public virtual string GetName()
            {
                return "pet";
            }
        }

        public class Cat : Pet
        {
            public override string GetName()
            {
                return "cat";
            }

            public int Func2()
            {
                return 32;
            }
        }

        #region https://msdn.microsoft.com/ru-ru/library/ms173153.aspx

        class BaseClass
        {
            public void Method1()
            {
                Console.WriteLine("Base - Method1");
            }

            public void Method2()
            {
                Console.WriteLine("Base - Method2");
            }

            public virtual void Method3()
            {
                Console.WriteLine("Base - Method3");
            }
        }

        class DerivedClass : BaseClass
        {
            public new void Method2()
            {
                Console.WriteLine("Derived - Method2");
            }

            public override void Method3()
            {
                Console.WriteLine("Derived - Method3");
            }
        }

        #endregion

        [Test]
        public void TestCase()
        {
            Pet myPet = new Cat();
            Shape shape = new Ball();
            var johnsCat = new Cat();


            Console.WriteLine("My {0} is playing with a {1}. John's {2} is sleeping"
                , myPet.GetName()
                , shape.GetName(),
                johnsCat.GetName());

            var temp = shape.GetName();
            var temp2 = shape.GetName2();

            var ball = new Ball();
            var temp3 = ball.GetName();
            var temp4 = ball.GetName2();

            var val3 = ((Cat) myPet).Func2();

            Console.WriteLine("-----------------------");

            var bc = new BaseClass();
            var dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            Console.WriteLine("BaseClass bc = new BaseClass()");
            bc.Method1();
            bc.Method2();
            bc.Method3();
            Console.WriteLine("");

            Console.WriteLine("DerivedClass dc = new DerivedClass()");
            dc.Method1();
            dc.Method2();
            dc.Method3();
            Console.WriteLine("");

            Console.WriteLine("BaseClass bcdc = new DerivedClass()");
            bcdc.Method1();
            bcdc.Method2();
            bcdc.Method3();
            Console.WriteLine("---------");

            ((BaseClass) dc).Method2();
        }
    }
}
