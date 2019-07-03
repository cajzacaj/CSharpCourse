using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CsharpCourse.Dag2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManipulateListNumbers();
        }

        private static void ManipulateListNumbers()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                string input = AskForInputString("Enter a number:");

                if (input.Trim().ToLower() == "quit")
                    break;
                int newNumber = int.Parse(input);
                numbers.Add(newNumber);
            }
         
            numbers.Sort();
            double mean = numbers.Average();
            double median;
            int n = numbers.Count / 2;
            if (numbers.Count % 2 == 0)
            {  
                median = (numbers[n - 1] + numbers[n]) / 2;
            } else
            {
                median = numbers[n];
            }


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Mean: {mean}");
            Console.WriteLine($"Median: {median}");
            Console.ResetColor();
        }
        private static void ManipulateList()
        {
            List<string> names = new List<string>();
            while (true)
            {
                string input = AskForInputString("Enter a name:");

                if (input.Trim().ToLower() == "quit")
                    break;

                names.Add(input);
            }
            names.Sort();
            names.RemoveAt(0);
            names.RemoveAt(names.Count - 1);

            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            foreach (string name in names)
            {
                Console.WriteLine("Name: " + name);
            }
            Console.ResetColor();
        }

        public static void SuperNameWithMethods()
        {
            string[] names;
            char separator = AskUserForSeparator();
            bool displayErrorMessage = AskUserForErrorMessage();
            while (true)
            {
                string inputNames = AskForInputString("Enter a list of names:");
                names = SplitString(inputNames, separator);
                CleanUpArray(names);
                if (ArrayIsValid(names, displayErrorMessage))
                    break;
            }
            PrintSuperName(names);
        }

        public static bool AskUserForErrorMessage()
        {
            bool wantErrorMessage = false;
            while (true)
            {
                Console.Write("Do you want to see error messages? (default is yes) ");
                string answer = Console.ReadLine();

                if (string.IsNullOrEmpty(answer))
                    answer = "yes";

                answer = answer.Trim().ToLower();

                if (answer == "yes")
                {
                    wantErrorMessage = true;
                    break;
                }
                else if (answer == "no")
                    break;
            }
          
            return wantErrorMessage;
        }

        public static char AskUserForSeparator()
        {
            char separator = ',';
            Console.Write("Which separator do you want to use? (default is comma) ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return separator;

            separator = char.Parse(input);
            return separator;
        }

        public static bool ArrayIsValid(string[] names, bool displayErrorMessage)
        {

            if (names.Length == 0)
            {
                if (displayErrorMessage)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No people in the list");
                    Console.ResetColor();
                }
                return false;
            }
            foreach (string name in names)
            {
                if (name.Length < 2 || name.Length > 9)
                {
                    if (displayErrorMessage)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A name can only have 2 to 9 letters");
                        Console.ResetColor();
                    }
                    return false;
                }
                if (!name.All(char.IsLetter))
                {
                    if (displayErrorMessage)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A name can only contain letters");
                        Console.ResetColor();
                    }
                    return false;
                }
            }
            return true;

        }

        public static void CleanUpArray(string[] array)
        {
            char[] trimChars = new char[] { '-', '+', '#', '\'', '\"', '.', ',' };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Trim().Trim(trimChars);
            }
        }

        public static string AskForInputString(string question)
        {
            Console.Write(question + " ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }
        public static int AskForInputInt(string question)
        {
            Console.Write(question + " ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int input = int.Parse(Console.ReadLine());
            Console.ResetColor();
            return input;
        }
        public static string[] SplitString(string listToSeparate, char separator)
        {
            if (string.IsNullOrWhiteSpace(listToSeparate))
                return new string[] { }; 

            string[] list = listToSeparate?.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            return list;
        }

        public static void PrintSuperName(string[] listOfNames)
        {
           
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (string name in listOfNames)
                {
                    if (name != null)
                    {
                        string nameUpper = name.ToUpper();
                        Console.WriteLine($"***SUPER-{nameUpper}***");
                    }
                }
                Console.ResetColor();
           
        }


        private static void SuperName()
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string inputNames = Console.ReadLine();

            string[] names = inputNames.Split(',');

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string name in names)
            {
                string nameUpper = name.ToUpper();
                Console.WriteLine($"***SUPER-{nameUpper}***");
            }
            Console.ResetColor();
        }

        private static void DrawSquare(int side)
        {
            for (int i = 0; i < side; i++)
            {
                for (int x = 0; x < side; x++)
                {
                    Console.InputEncoding = System.Text.Encoding.Unicode;
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.Write("● ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private static void DrawSquare(int side, int margin)
        {
            for (int i = 0; i < side; i++)
            {
                for (int y = 0; y < margin; y++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < side; x++)
                {
                    Console.InputEncoding = System.Text.Encoding.Unicode;
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.Write("● ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        private static void MultiplicationTable(int maxA, int maxB)
        {
            for (int a = 1; a <= maxA; a++)
            {
                Console.InputEncoding = System.Text.Encoding.Unicode;
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine($"┃ Multiplication table for {a} ┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                for (int b = 1 ; b <= maxB; b++)
                {
                    Console.WriteLine($"{a} x {b} = {a * b}");
                }
                Console.WriteLine();
            }
        }
        private static void MultiplicationTable(int maxA)
        {
            for (int a = 1; a <= maxA; a++)
            {
                Console.InputEncoding = System.Text.Encoding.Unicode;
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine($"┃ Multiplication table for {a} ┃");
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                for (int b = 1; b <= 10; b++)
                {
                    Console.WriteLine($"{a} x {b} = {a * b}");
                }
                Console.WriteLine();
            }
        }
    }
}
