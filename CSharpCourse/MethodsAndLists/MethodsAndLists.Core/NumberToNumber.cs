
using System;

namespace MethodsAndLists.Core
{
    public class NumberToNumber
    {
        public int SumNumbers(int from, int to)
        {
            if (from > to)
                throw new ArgumentException("Input can't be 0 or negative");

            int result = 0;

            for (int i = from; i <= to; i++)
            {
                result += i;
            }
            return result;
        }

        public int SumNumbersTo(int input)
        {
            if (input <= 0)
                throw new ArgumentException("Input can't be 0 or negative");

            int result = 0;

            for (int i = 1; i <= input; i++)
            {
                result += i;
            }
            return result;
        }

        public int SumNumbersDividedByThreeOrFive(int input)
        {
            if (input <= 0)
                throw new ArgumentException("Input can't be 0 or negative");

            int result = 0;

            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
            return result;
        }
    }
}
