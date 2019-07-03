using System;
using CSharpCourse.Utilities;

namespace DividingChocolate
{
    class Program
    {
        static ConsoleHelper ch = new ConsoleHelper();
        static void Main(string[] args)
        {
            decimal pieces = 24;
            ch.WriteLine($"The chocolate contains {pieces} pieces");

            while (true)
            {
               
                decimal people = AskForDouble("How many want to share?");

                decimal piecesPerPerson = 0;
                try
                {
                    piecesPerPerson = pieces / people;
                    ch.WriteLineDark($"Everyone gets {piecesPerPerson:.##} pieces of chocolate");
                    break;
                }
                catch (DivideByZeroException)
                {
                    ch.WriteLineRed("Zero people can't share chocolate");
                }
                
                
            }
            
            
        }


        private static decimal AskForDouble(string question)
        {
            decimal num = 0;
            while (true)
            {
                Console.Write(question + " ");
                string input = Console.ReadLine();

                try
                {
                    num = decimal.Parse(input);
                    break;
                }
                catch (ArgumentNullException)
                {
                    ch.WriteLineRed("You have to something");
                }
                catch (FormatException)
                {
                    ch.WriteLineRed("You have to enter a number");
                }

                
            }
            
            

            return num;
        }
    }
}
