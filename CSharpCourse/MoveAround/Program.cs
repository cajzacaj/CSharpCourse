using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var seats = new Seats();
            seats.FillFromText(
                "OO ",
                "OOO",
                "OOO",
                " OO",
                "OOO",
                " OO"
                );
            //var seats = new Seats();
            //string[] seatInput = File.ReadAllLines("map.txt");

            // seats.FillFromFile("map.txt");


            var people = new List<string>
                {
                    "Harry",
                    "Minerva",
                    "Albus",
                    "Ron",
                    "Victor",
                    "Draco",
                    "Luna",
                    "Ginny",
                    "Molly",
                    "Fred",
                    "George",
                    "Rubeus",
                    "Sirius",
                    "Remus",
                    "Dean"
                };

            while (true)
            {

                Console.Clear();

                PrintMapWithPeople(seats, people);
                string input = Console.ReadLine();

                if (input != "")
                    break;
            }
        }

        private static void PrintMapWithPeople(Seats seats, List<string> p)
        {
            List<string> people = new List<string>(p);
            var random = new Random();

            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (seats.Map[x,y] == 'O')
                    {
                        int person = random.Next(people.Count);

                        Console.Write($"{ people[person]}\t\t");
                        people.RemoveAt(person);
                    }
                    else if (seats.Map[x, y] == ' ')
                        Console.Write("\t\t");

                }
                Console.WriteLine();
            }
        }
    }
}
