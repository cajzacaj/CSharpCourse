using System;
using System.Text.RegularExpressions;
using CSharpCourse.Utilities;

namespace CSharpCourse.Animals
{
    class Program
    {
        static ConsoleHelper ch = new ConsoleHelper();
        static void Main(string[] args)
        {
            while (true)
            {
                string inputAnimals = ch.AskForString("Enter a list of animals:");

                try
                {
                    string[] listOfAnimals = ParseAnimals(inputAnimals);
                    ch.WriteLineDark($"There are {listOfAnimals.Length} animals in the list");
                    break;
                }
                catch (ArgumentException ex)
                {
                    ch.WriteLineRed(ex.Message);
                }
                catch (Exception)
                {
                    ch.WriteLineRed("Unexpected error");
                }
            }
            
            

        }
        static private string[] ParseAnimals(string animalsString)
        {
            if (animalsString == "")
                throw new ArgumentException("Animal string doesn't contain any letters");

            string[] animals = animalsString.Split(',');

            foreach (var animal in animals)
            {
                if (animal.Length == 0)
                    throw new ArgumentException($"One of the animals didn't contain any letters");
                if (animal.Length > 20)
                    throw new ArgumentException($"This animal: {animal} has too many letters");
                if (!Regex.IsMatch(animal, @"^[a-zåäö ]+$", RegexOptions.IgnoreCase))
                    throw new ArgumentException($"Animal: {animal} contains invalid letters");
            }
            return animals;
        }
    }
}
