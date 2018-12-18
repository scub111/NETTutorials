using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        // http://csharp-station.com/Tutorial/Linq/Lesson01

        static void Main(string[] args)
        {
            string[] musicalArtists = { "Adele", "Maroon 5", "Avril Lavigne" };


            Console.WriteLine("---1---");
            var aArtists1 =
                from artist in musicalArtists
                where artist.StartsWith("A")
                orderby artist descending
                select artist.ToUpper();
                 

            foreach (var artist in aArtists1)
                Console.WriteLine(artist);

            Console.WriteLine("---2---");

            IEnumerable<string> aArtists2 = musicalArtists
                .Where(p => p.StartsWith("A"))
                .OrderByDescending(p => p);

            foreach (var artist in aArtists2)
                Console.WriteLine(artist);


            Console.Read();
        }
    }
}
