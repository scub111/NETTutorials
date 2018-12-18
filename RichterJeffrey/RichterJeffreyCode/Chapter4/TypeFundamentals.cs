using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RichterJeffreyCode
{
    [TestFixture]
    public class TypeFundamentals
    {
        [Test]
        public void IsAsTest()
        {
            object o = new object();
            bool b1 = o is object;
        }

        [Test]
        public void UncheckedTest()
        {

        }
    }
}
