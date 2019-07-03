using System;

namespace CSharpCourse.Dag1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;

            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    Console.WriteLine($"A = {x} B = {y}");
                }
                Console.WriteLine();

            }
        }

        private static void GuessingGame()
        {
            Random randomizer = new Random();
            int num = randomizer.Next(1, 101);
            Console.WriteLine("You have 6 chances to guess a number between 1-100");
            int guess;
            int numberOfGuesses = 1;

            while (true)
            {
                Console.Write($"Guess {numberOfGuesses}: ");
                guess = int.Parse(Console.ReadLine());
                if (guess == num || numberOfGuesses == 6)
                    break;
                else if (guess < num)
                    Console.WriteLine("Your guess was to low");
                else
                    Console.WriteLine("Your guess was to high");
                numberOfGuesses++;
            }
            
            if (guess == num)
                Console.WriteLine("You win! The correct number was: " + num);
            else if (numberOfGuesses == 6)
                Console.WriteLine("You lose! The correct number was: " + num);

        }

        private static void ConditionalOperator()
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            string output = (input == 20) ? "Equal to 20" : (input < 20) ? "Lower than 20" : "Higher than 20";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(output);
            Console.ResetColor();

        }

        private static void CheckNumber()
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Enter a number to compare: ");
            int input = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            if (input < value)
                Console.WriteLine($"{input} is lower than {value}");
            else if ( input > value)
                Console.WriteLine($"{input} is higher than {value}");
            else
                Console.WriteLine($"{input} is equal to {value}");

            Console.ResetColor();
        }

        private static void AddLastnameWithBreak()
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string firstNames = Console.ReadLine();
            Console.Write("Enter lastname: ");
            string lastName = Console.ReadLine();

            string[] names = firstNames.Split(',');
            Console.WriteLine();

            int count = 1;
            foreach (string name in names)
            {
                if (name == "Zelda")
                    break;

                Console.WriteLine($"[{count}] {name} {lastName}");
                count++;
            }
        }
        private static void AddLastname()
        {
            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
            string firstNames = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            string[] names = firstNames.Split(',');
            Console.WriteLine();

            int count = 1;
            foreach (string name in names)
            {
                Console.WriteLine($"[{count}] {name} {lastName}");
                count++;
            }
           

        }
        private static void RepeatNameFor()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            Console.Write("Number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Number of times to repeat name: ");
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine();

            char[] array = name.ToCharArray();
            Array.Reverse(array);
            string nameReversed = name + new string(array);

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < rows; i++)
            {
                for (int x = 0; x < columns; x++)
                {
                    for (int y = 0; y < repeat; y++)
                    {
                        Console.Write(name);
                    }
                    Console.Write("      ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        private static void RepeatNameWhile()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Times to repeat: ");
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            int i = 0;
            int x = 0;

            while (true)
            {
                Console.WriteLine($"Your name is {name}");
                i++;
                if (i >= repeat)
                    break;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            while (x < repeat)
            {
                Console.WriteLine($"Your name is {name}");
                x++;
            }
            Console.ResetColor();
        }
        private static void Sleep()
        {
            Console.Write("When did you go to bed yesterday? ");
            int bedTime = int.Parse(Console.ReadLine());
            Console.Write("When did you wake up? ");
            int wakeTime = int.Parse(Console.ReadLine());
            int timeSlept;

            if (bedTime >= wakeTime)
                timeSlept = 24 - bedTime + wakeTime;
            else
                timeSlept = wakeTime - bedTime;

            if (timeSlept < 5)
                Console.WriteLine($"You only slept {timeSlept} hours, go back to bed!");
            else if (timeSlept > 10)
                Console.WriteLine($"You slept {timeSlept} hours, that's too much!");
            else
                Console.WriteLine($"You slept {timeSlept} hours, that's good");

        }
        static void WhatsYourName()
        {
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();
            Console.Write("How old are you? ");
            string age = Console.ReadLine();
            Console.Write("What is your favorite letter? ");
            string letter = Console.ReadLine();
            Console.Write("What is your favorite color? ");
            string colour = Console.ReadLine();

            Console.WriteLine("\nThank you!\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your name is: {firstName} {lastName}");
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine($"Your favorite letter is {letter}");
            Console.WriteLine($"Your favorite color is {colour}");
            Console.ResetColor();
        }
        static void WhatsYourName2()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("What is your favorite character? ");
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine("\nThank you!\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"You have {65 - age} years until retirement");
            if (char.IsNumber(c))
                Console.WriteLine("You like numbers");
            else
                Console.WriteLine("You don't like numbers");

            Console.ResetColor();
        }
        static void Fruits()
        {
            Console.Write("Enter fruit 1: ");
            string fruit1 = Console.ReadLine();
            Console.Write("Enter fruit 2: ");
            string fruit2 = Console.ReadLine();
            Console.Write("Enter fruit 3: ");
            string fruit3 = Console.ReadLine();

            string concatenation = "Your entered these fruits: " + fruit1 + ", " + fruit2 + ", " + fruit3 + "!";
            string placeholder = string.Format("Your entered these fruits: {0}, {1}, {2}!", fruit1, fruit2, fruit3);
            string interpolation = $"Your entered these fruits: {fruit1}, {fruit2}, {fruit3}!";

            Console.WriteLine(concatenation);
            Console.WriteLine(placeholder);
            Console.WriteLine(interpolation);
        }

    }
}
