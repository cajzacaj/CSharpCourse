
using System;

namespace MethodsAndLists.Core
{
    public class StringListToNumber
    {

        public int ElevatorGoUpAndDown(string[] input)
        {
            int floor = 0;
            foreach (string command in input)
            {
                if (command == "UPP")
                    floor++;
                else if (command == "NER")
                    floor--;
            }
            return floor;
        }
    }
}
