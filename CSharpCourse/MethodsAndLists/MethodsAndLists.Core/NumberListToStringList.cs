using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class NumberListToStringList
    {
        public List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> list)
        {
            var output = new List<string>();

            foreach (int i in list)
            {
                if (i == 0)
                    output.Add("BOING");
                else if (i > 0)
                    output.Add($"ZAP");
                else if (i < 0)
                    output.Add($"ZIP");
            }

            return output;
        }

        public List<string> LongOrShort(List<int> list)
        {
            var output = new List<string>();

            foreach (int i in list)
            {
                if (i < 0 || i > 250)
                    continue;
                else if (i >= 160)
                    output.Add($"{i}cm är långt");
                else if (i < 160)
                    output.Add($"{i}cm är kort");
            }

            return output;
        }

        public List<string> AddStars(List<int> list)
        {
            var output = new List<string>();

            foreach (int i in list)
            {
                output.Add($"***{i}***");
            }

            return output;
        }

        public List<string> AddStarsToNumbersHigherThan1000(List<int> list)
        {
            var output = new List<string>();

            foreach (int i in list)
            {
                if (i > 1000)
                    output.Add($"***{i}***");
                else
                    output.Add($"{i}");
            }

            return output;
        }
    }
}