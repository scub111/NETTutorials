using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Task.Tests.Unit
{
    [TestFixture]
    public class BubbleSortTest
    {
        private double[] BubbleSort(double[] array)
        {
            for (var j = 0; j < array.Length; j++)
            {
                for (var i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        [Test]
        public void MainTest()
        {
            var array = new double[] {6, 4, 1, 2, 0, 3, 5};
            var result = BubbleSort(array);
            result[0].Should().Be(0);
            result[1].Should().Be(1);
            result[2].Should().Be(2);
            result[3].Should().Be(3);
            result[4].Should().Be(4);
            result[5].Should().Be(5);
            result[6].Should().Be(6);
        }
    }
}
