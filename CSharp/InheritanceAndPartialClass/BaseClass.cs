using System;

#pragma warning disable

namespace PartialClass
{
    public class BaseClass
    {
        public virtual void GetName()
        {
            Console.WriteLine("BaseСlass");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void GetName()
        {
            Console.WriteLine("DerivedClass Override");
        }
    }

    public class DerivedNew : BaseClass
    {
        public new void GetName()
        {
            Console.WriteLine("Derived New");
        }
    }

    public class DerivedOverwrite : BaseClass
    {
        public void GetName()
        {
            Console.WriteLine("Derived Overwrite");
        }
    }
}
