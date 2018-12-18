namespace Conversions
{
    class TestClass
    {
        public int Value1 { get; set; }

        public int Value2 { get; set; }

        private int _Value;

        protected int MyProperty
        {
            private get { return _Value; }
            set { _Value = value; }
        }


        public static implicit operator int(TestClass testClass)
        {
            return testClass.Value1 + testClass.Value2;
        }

        public static explicit operator double(TestClass testClass)
        {
            return testClass.Value1 * 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new TestClass();
            testClass.Value1 = 8;
            testClass.Value2 = 3;

            int t = testClass;

            var d = (double)testClass;

        }
    }
}
