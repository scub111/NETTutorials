using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace Base
{
    public static class LinqLikeExtantion
    {
        public static IEnumerable<T> WhereEx<T>(this IEnumerable<T> list, Func<T, bool> condition)
        {
            foreach (var row in list)
            {
                if (condition(row))
                    yield return row;
            }
        }
    }

    public class MusicTitles: IEnumerable<string>
    {
        private string[] names = {"Tubular Bells", "Hergest Ridge", "Ommadawn", "Platinum"};

        public int Count => names.Length;

        public IEnumerator<string> GetEnumerator()
        {
            for (var i = 0; i < names.Length; i++)
                yield return names[i];
        }

        public IEnumerable<string> Reverse()
        {
            for (var i = names.Length - 1; i >= 0; i--)
                yield return names[i];
        }

        public IEnumerable<string> Subset(int index, int length)
        {
            for (var i = index; i < index + length; i++)
                yield return names[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    [TestFixture]
    public class YeildTest
    {
        [Test]
        public void LinqLikeExtantionCase()
        {
            var list = new List<string> {"Kolya"};

            list.ForEach(Console.WriteLine);

            list.Add("Pasha");
            list.Add("Kostya");

            list.ForEach(Console.WriteLine);

            Console.WriteLine("----");
            var filterList = list.WhereEx(i => i.Contains("Kos"));
            foreach (var row in filterList)
                Console.WriteLine(row);

            Console.WriteLine("----");
            list.Add("Kost");
            list.Add("324234");
            list.Add("Kost123");

            foreach (var row in filterList)
                Console.WriteLine(row);
        }

        [Test]
        public void MusicTitlesCase()
        {
            var musicTitles = new MusicTitles();

            var count = 0;
            foreach (var title in musicTitles)
            {
                Console.WriteLine(title);
                count++;
            }
            count.Should().Be(musicTitles.Count);

            Console.WriteLine("---Reverse---");
            count = 0;
            foreach (var title in musicTitles.Reverse())
            {
                Console.WriteLine(title);
                count++;
            }
            count.Should().Be(musicTitles.Count);

            Console.WriteLine("---Subset---");
            count = 0;
            foreach (var title in musicTitles.Subset(1, 2))
            {
                Console.WriteLine(title);
                count++;
            }
            count.Should().Be(2);
        }
    }
}
