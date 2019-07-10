using CSharpCourse.Utilities;
using System;
using System.Collections.Generic;

namespace InterfacesRockstars
{
    class Program
    {
        static ConsoleHelper ch = new ConsoleHelper();
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury" };
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury" };

            DisplayArrayOfRockStars(rockstarsArray);
            ch.Space();
            DisplayListOfRockStars(rockstarsList);
            ch.Space();
            DisplayIEnumerableOfRockStars(rockstarsArray);
            ch.Space();
            DisplayIEnumerableOfRockStars(rockstarsList);
        }

        private static void DisplayArrayOfRockStars(string[] rockstarsArray)
        {
            
            ch.WriteLine("My rockstars: (Array)");
            foreach (var rockstar in rockstarsArray)
            {
                ch.WriteLineDark($"* {rockstar}");
            }
        }

        private static void DisplayListOfRockStars(List<string> rockstarsList)
        {
            ch.WriteLine("My rockstars: (List)");
            foreach (var rockstar in rockstarsList)
            {
                ch.WriteLineDark($"* {rockstar}");
            }
        }
        private static void DisplayIEnumerableOfRockStars(IEnumerable<string> rockstarsList)
        {
            

            ch.WriteLine("My rockstars: (IEnumerable)");
            foreach (var rockstar in rockstarsList)
            {
                ch.WriteLineDark($"* {rockstar}");
            }

        }
    }
}
