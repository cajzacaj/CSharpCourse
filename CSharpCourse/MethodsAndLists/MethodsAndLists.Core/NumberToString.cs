using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodsAndLists.Core
{
    public class NumberToString
    {
        public string Triangle(int num)
        {
            if (num < 0)
                throw new ArgumentException("invalid");

            string output = "";
            for (int x = 0; x < num; x++)
            {
                if (x!=0)
                    output += "\n";

                for (int y = 0; y <= x; y++)
                {
                    output += "*";
                }
            }
            return output;
        }


        public string Triangle(int num, char c)
        {
            if (num < 0)
                throw new ArgumentException("invalid");

            string output = "";
            for (int x = 0; x < num; x++)
            {
                if (x != 0)
                    output += "\n";

                for (int y = 0; y <= x; y++)
                {
                    output += $"{c}";
                }
            }
            return output;
        }
        public string TriangleReversed(int num)
        {
            if (num < 0)
                throw new ArgumentException("invalid");

            string output = "";

            for (int x = num; x > 0; x--)
            {
                for (int y = 0; y < x; y++)
                {
                    output += "*";
                }
                if (x > 1)
                    output += "\n";

            }
            return output;
        }

    }
}
