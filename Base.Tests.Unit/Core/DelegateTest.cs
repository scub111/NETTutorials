using System;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    class DelegateTest
    {
        public delegate int Calculate(int x, int y);

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int c, int d)
        {
            return c * d;
        }

        static void Func1()
        {
            var prog = new DelegateTest();
            Calculate cal = prog.Add;
            Console.WriteLine(cal(2, 10));

            cal = prog.Multiply;
            Console.WriteLine(cal(2, 10));
        }

        public delegate void DoSome();

        static void DoSomething1()
        {
            Console.WriteLine("DoSomething1.");
        }
        static void DoSomething2()
        {
            Console.WriteLine("DoSomething2.");
        }

        static void Func2()
        {
            DoSome doSome = DoSomething1;
            doSome += DoSomething2;
            doSome();

            Console.WriteLine(doSome.GetInvocationList().Length);
        }

        static void Func3()
        {
            Calculate cal = (x, y) => 2 * x + y;
            Console.WriteLine(cal(10, 5));

            cal = (x, y) => x * y + 2;
            Console.WriteLine(cal(10, 5));
        }

        static void Void4(Calculate cal)
        {
            Console.WriteLine(cal(10, 10));
        }

        static void Func4()
        {
            Void4((x, y) => x + y);
            Void4((x, y) => x * y);
        }

        static void FuncAction()
        {
            Action act = () =>
            {
                Console.WriteLine("Done");
            };

            act();

            Action<int> actArg = (x) =>
            {
                Console.WriteLine(x);
            };

            actArg(324);

            Action A1 = delegate { Console.WriteLine("Hello"); };
            Action A2 = delegate () { Console.WriteLine("Hello"); };
            Action A3 = () => Console.WriteLine("Hello");

            Action<int> A4 = delegate (int x) { Console.WriteLine(x); };
            Action<int> A5 = (x) => Console.WriteLine(x);
            Action<int> A6 = (x) => x = x * x;

            Console.ReadKey();
        }

        static void FuncClassic()
        {
            Func<int> func = () =>
            {
                return 32;
            };

            Console.WriteLine(func());

            Func<int, int, int> funcSum = (x, y) =>
            {
                return x + y;
            };

            Console.WriteLine(funcSum(33, 36));

            Func<float, float> F1 = delegate (float x) { return x * x; };
            Func<float, float> F2 = x => { return x * x; };
            Func<float, float> F3 = x => x * x;
            Func<float, float> F4 = (float x) => x * x;
        }

        [Test]
        public void TestCase()
        {
            FuncClassic();
        }
    }
}
