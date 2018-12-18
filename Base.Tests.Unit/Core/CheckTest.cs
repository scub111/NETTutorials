using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    [TestFixture]
    public class CheckTest
    {
        //Case when there is casting error however exception doesn't occur 
        [Test]
        public void ErrorCase()
        {
            var i = 256;
            var b = (byte)i;
            b.Should().Be(0);
        }

        //Case correct handling error using checked keyword
        [Test]
        public void CheckCase()
        {
            var i = 256;
            var isOverflowException = false;
            try
            {
                checked
                {
                    var b = (byte) i;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"{ex.Source} - {ex.Message}");
                isOverflowException = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Source} - {ex.Message}");
            }
            isOverflowException.Should().BeTrue();
        }
    }
}
