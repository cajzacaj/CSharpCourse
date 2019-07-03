using System;
using System.Text.RegularExpressions;

namespace ClassesCars
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Car("blue", 1200);
            var c2 = new Car("red", 800);
            var c3 = new Car();

            Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
            Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
            Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");
        }
    }

    internal class Car
    {

        public string Color { get; }
        public int Weight { get; }

        public Car()
        {
            Color = "pink";
            Weight = 999;
        }
        public Car(string color, int weight)
        {
            Regex regex = new Regex("^(red|blue|yellow|pink|green|white|black)$", RegexOptions.IgnoreCase);

            if (!regex.IsMatch(color))
                throw new ArgumentException("Not a valid color");

            if (weight < 0)
                throw new ArgumentException("The weight can't be negative");

            Color = color;
            Weight = weight;
        }
    }
}
