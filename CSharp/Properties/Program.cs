namespace Properties
{
    public class BaseClass
    {
        public int MyProperty
        {
            get;
            protected set;
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            this.MyProperty = 8;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var bc = new BaseClass();
            //bc.MyProperty = 8;
        }
    }
}
