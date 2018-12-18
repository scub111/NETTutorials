using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace Base
{
    [TestFixture]
    class InterfaceComparableTest
    {
        public class ComparableClass : IComparable<ComparableClass>
        {
            public ComparableClass(string name, DateTime birthday)
            {
                Name = name;
                Birthday = birthday;
            }

            public ComparableClass(string name, DateTime birthday, DateTime marriedDate) : this(name, birthday)
            {
                MarriedDate = marriedDate;
            }

            public string Name { get; set; }

            public DateTime Birthday { get; set; }

            public DateTime MarriedDate { get; set; }

            public int CompareTo(ComparableClass other)
            {
                /*
                if (Birthday > other.Birthday)
                    return 1;
                else if (Birthday == other.Birthday)
                    return 0;
                else
                    return -1;
                */
                return Birthday.CompareTo(other.Birthday);
            }
        }

        public class MarriedDateComparer : IComparer<ComparableClass>
        {
            public int Compare(ComparableClass x, ComparableClass y)
            {
                /*
                if (x.MarriedDate > y.MarriedDate)
                    return 1;
                else if (x.MarriedDate == y.MarriedDate)
                    return 0;
                else
                    return -1;
                */
                return x.MarriedDate.CompareTo(y.MarriedDate);
            }
        }

        [Test]
        public void TesCase()
        {
            var list = new List<int> { 0, -3, 8, 10, -20 };

            list.Sort();

            var compares = new List<ComparableClass>
            {
                new ComparableClass("1", new DateTime(2017, 1, 1), new DateTime(2013, 1, 1)),
                new ComparableClass("2", new DateTime(2016, 1, 1), new DateTime(2017, 1, 1)),
                new ComparableClass("3", new DateTime(2015, 1, 1), new DateTime(2014, 1, 1))
            };

            int[] nums = { 23, 23, 99 };
            var nums2 = new int[5] { 323, 23, 232, 3, 23 };


            compares.Sort();

            compares.Sort(new MarriedDateComparer());

            compares = compares.OrderBy(e => e.Birthday).ToList();
        }
    }
}
