namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new TestClass();
            testClass.SetField();
            testClass.SetField2(5);
        }
    }
}
