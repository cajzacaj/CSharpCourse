using System;
using CSharpCourse.Utilities;

namespace shipping
{
    class Program
    {
        static ConsoleHelper ch = new ConsoleHelper();
        static void Main(string[] args)
        {
            var service = new ShippingService();
            Letter letter;

            while (true)
            {
                try
                {
                    bool rek = false;
                    bool bulky = false;

                    int weight = ch.AskForInteger("Enter weight:");

                    string input = ch.AskForString("Recommended (y/n)");
                    if (input == "y")
                        rek = true;

                    input = ch.AskForString("Bulky (y/n)");
                    if (input == "y")
                        bulky = true;

                    letter = new Letter(weight, rek, bulky);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                break;
            }
            Console.WriteLine();
            Console.WriteLine(letter.Weight);
            Console.WriteLine(letter.RecommendedLetter);
            Console.WriteLine(letter.Bulky);

            Console.WriteLine();
            decimal shipping = service.CalculateShipping(letter, "2019");
            Console.WriteLine(shipping);
        }
    }
}
