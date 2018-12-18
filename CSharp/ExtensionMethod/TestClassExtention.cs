namespace ExtensionMethod
{
    public static class TestClassExtention
    {
        public static void SetField(this TestClass testClass)
        {
            testClass.Field = 9;
        }

        public static void SetField2(this TestClass testClass, int value)
        {
            testClass.Field = value;
        }


    }
}
