
using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class StringListToString
    {
    /*
            *********
            * Hello *
            * World *
            * in    *
            * a     *
            * frame *
            *********
     */
        public string Frame(string[] input)
        {
            string output = "";

            if (input == null)
                throw new ArgumentException("null");
            if (input.Length == 0)
                return output;

            string longestWord = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > longestWord.Length)
                    longestWord = input[i];
            }

            for (int i = 0; i < longestWord.Length + 4; i++)
            {
                output += "*";
            }

            for (int x = 0; x < input.Length; x++)
            {
                output += $"\n* {input[x].PadRight(longestWord.Length)} *";
            }
            output += "\n";
            for (int i = 0; i < longestWord.Length + 4; i++)
            {
                output += "*";
            }
            return output;
        }
    }
}
