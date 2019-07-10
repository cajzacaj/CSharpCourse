using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static ElevatorProject.Elevator;

namespace ElevatorProject
{
    class Program
    {
        public enum Direction
        {
            Up, Down
        }

        static void Main(string[] args)
        {

            List<Elevator> elevators = LoadElevatorsFromFile();

            while (true)
            {
                Console.Clear();
                DisplayHeader();
                DisplayStatus(elevators);
                DisplayGraphic(elevators);
                Elevator elevator = AskWhichElevatorToMove(elevators);
                Direction direction = AskForDirection();
                int numberOfFloors = AskForNumberOfFloors();
                ElevatorMoveResponse response;

                if (direction == Direction.Up)
                    response = elevator.TryGoUp(numberOfFloors);
                else
                    response = elevator.TryGoDown(numberOfFloors);

                DisplayResponse(response, elevator, direction);
                Console.ReadKey();
            }
        }

        private static void DisplayGraphic(List<Elevator> elevators)
        {
            int maxShaft = 0;
            int minShaft = 0;

            foreach (var item in elevators)
            {
                if (item.HighetstFloor > maxShaft)
                    maxShaft = item.HighetstFloor;

                if (item.LowestFloor < minShaft)
                    minShaft = item.LowestFloor;
            }

            for (int i = 0; i < 2 + 1; i++)
            {
                Console.Write("\t");

                for (int x = 0; x < elevators.Count * 2 + 1; x++)
                {

                    Console.InputEncoding = System.Text.Encoding.Unicode;
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("███");
                }
                Console.WriteLine();
            }

            for (int i = maxShaft; i > minShaft; i--)
            {
                Console.Write("\t");

                for (int x = 0; x < elevators.Count; x++)
                {
                    Console.InputEncoding = System.Text.Encoding.Unicode;
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("███");
                    

                    if (elevators[x].CurrentFloor == i)
                    {
                        if (elevators[x].UntilMaintainance > 5)
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        else if (elevators[x].UntilMaintainance > 0)
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        else if (elevators[x].UntilMaintainance <= 0)
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(" █ ");
                    }
                    else if (elevators[x].HighetstFloor >= i && elevators[x].LowestFloor <= i)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" ╎ ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write("███");
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"███");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write($"  {i}");
                Console.WriteLine();
            }
            for (int i = 0; i < 2 + 1; i++)
            {
                Console.Write("\t");

                for (int x = 0; x < elevators.Count * 2 + 1; x++)
                {
                    Console.InputEncoding = System.Text.Encoding.Unicode;
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("███");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        private static List<Elevator> LoadElevatorsFromFile()
        {
            string[] elevatorsFromFile = File.ReadAllLines("elevator.txt");

            var listOfElevators = new List<Elevator>();

            foreach (string item in elevatorsFromFile)
            {
                List<string> tmp = item.Split(',').ToList();
                string name = tmp[0];

                tmp.RemoveAt(0);

                List<int> intInfo = tmp.Select(x => int.Parse(x)).ToList();

                listOfElevators.Add(new Elevator(name, intInfo[0], intInfo[1], intInfo[2], intInfo[3]));
            }
            return listOfElevators;
        }

        private static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nELEVATOR APP\n");
            Console.ResetColor();
        }

        private static void DisplayStatus(List<Elevator> elevators)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Name".PadRight(15) + "Current".PadRight(15) + "Lowest".PadRight(15) + "Highest".PadRight(15) + "Power".PadRight(15) + "IsOn".PadRight(15));
            Console.ResetColor();

            foreach (var item in elevators)
            {
                string power = "";

                if (item.PowerIsOn == true)
                    power = "On";
                else
                    power = "Off";

                Console.WriteLine(item.Name.PadRight(15) + item.CurrentFloor.ToString().PadRight(15) + item.LowestFloor.ToString().PadRight(15) + item.HighetstFloor.ToString().PadRight(15) + item.UntilMaintainance.ToString().PadRight(15) + power.PadRight(15));

            }
            Console.WriteLine();
        }

        private static Elevator AskWhichElevatorToMove(List<Elevator> elevators)
        {
            while (true)
            {
                Console.Write("Which elevator do you want to move? ");
                string input = Console.ReadLine();

                foreach (var item in elevators)
                {
                    if (item.Name == input)
                        return item;
                }
            }
        }

        private static Direction AskForDirection()
        {
            while (true)
            {
                Console.Write("Go up or down? ");
                string input = Console.ReadLine();

                if (input.ToLower() == "up")
                    return Direction.Up;
                else if (input.ToLower() == "down")
                    return Direction.Down;
            }

        }
        private static int AskForNumberOfFloors()
        {
            while (true)
            {
                Console.Write("How many floors? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                    return result;
            }
        }

        private static void DisplayResponse(ElevatorMoveResponse response, Elevator elevator, Direction direction)
        {
            Console.WriteLine();
            if (response == ElevatorMoveResponse.NoPower)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Elevator needs maintainance");
                Console.ResetColor();
                Console.WriteLine($"\nDo do you want to perform maintainance? (y/n) ");
                string input = Console.ReadLine();

                if (input == "y")
                    elevator.DoMaintainanceOnElevator();

            }
            else if (response == ElevatorMoveResponse.CantGoDown)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Can't move elevator down that far, elevator will move to the lowest floor possible");
                Console.ResetColor();
            }
            else if (response == ElevatorMoveResponse.CantGoUp)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Can't move elevator up that far, elevator will move to the highest floor possible");
                Console.ResetColor();
            }
            else
                Console.WriteLine($"Elevator {elevator.Name} will move {direction} to floor {elevator.CurrentFloor}");
        }
    }
}
