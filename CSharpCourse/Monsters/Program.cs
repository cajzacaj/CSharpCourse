using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monsters = LoadMonstersFromFile();
            Header("All monsters");
            DisplayAllInfo(monsters);
            MoreThanTwoLegs(monsters);
            OrdedByEyes(monsters);
            AllScarers(monsters);
        }

        private static void AllScarers(List<Monster> monsters)
        {
            Header("Monsters with more than 2 legs");

            var scarers = new List<Monster>();

            foreach (var monster in monsters.Where(x => x.Job == "Scarer"))
            {
                scarers.Add(monster);
            }
            DisplayAllInfo(scarers);
        }

        private static void MoreThanTwoLegs(List<Monster> monsters)
        {
            Header("Monsters with more than 2 legs");

            var moreThan2Legs = new List<Monster>();

            foreach (var monster in monsters.Where(x => x.NumberOfLegs > 2))
            {
                moreThan2Legs.Add(monster);
            }
            DisplayAllInfo(moreThan2Legs);
        }
        private static void OrdedByEyes(List<Monster> monsters)
        {
            Header("Monsters ordered by number of eyes");

            List<Monster> orderedByEyes = monsters.OrderBy(x => x.NumberOfEyes).ToList();

            DisplayAllInfo(orderedByEyes);
        }

        private static void DisplayAllInfo(List<Monster> monsters)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Name".PadRight(20) + "Job".PadRight(20) + "Color".PadRight(20) + "NumberOfEyes".PadRight(15) + "NumberOfLegs".PadRight(15));

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            for (int i = 0; i < monsters.Count; i++)
            {
                Console.WriteLine(monsters[i].Name.PadRight(20) + monsters[i].Job.PadRight(20) + monsters[i].Color.PadRight(20) + monsters[i].NumberOfEyes.ToString().PadRight(15) + monsters[i].NumberOfLegs.ToString().PadRight(15));
            }
            Console.ResetColor();
        }

        static public List<Monster> LoadMonstersFromFile()
        {
            using (StreamReader r = new StreamReader("monsters.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Monster>>(json);
            }
        }
        static public void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + text.ToUpper() + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public class Monster
        {
            public string Name;
            public string Job;
            public string Color;
            public int NumberOfEyes;
            public int NumberOfLegs;
        }
    }
}
