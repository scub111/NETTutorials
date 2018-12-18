using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace Task.Tests.Unit
{
    [TestFixture]
    public class MathTest
    {
        public int CalculateAngle(int hour, int minute)
        {
            var degreePerHour = 360 / 12;
            var degreePerMinute = 360 / 60;
            var diff1 = Math.Abs(hour * degreePerHour - minute * degreePerMinute);
            var diff2 = 360 - diff1;
            return Math.Min(diff1, diff2);
        }

        [Test]
        public void CalculateAngleTest()
        {
            CalculateAngle(0, 0).Should().Be(0);
            CalculateAngle(1, 0).Should().Be(30);
            CalculateAngle(6, 0).Should().Be(180);
            CalculateAngle(12, 0).Should().Be(0);
            CalculateAngle(0, 5).Should().Be(30);
            CalculateAngle(0, 10).Should().Be(60);
            CalculateAngle(6, 30).Should().Be(0);
            CalculateAngle(3, 45).Should().Be(180);
            CalculateAngle(0, 15).Should().Be(90);
            CalculateAngle(0, 45).Should().Be(90);
        }
    }
}
