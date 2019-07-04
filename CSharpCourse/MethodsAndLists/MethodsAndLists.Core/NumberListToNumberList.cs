
using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToNumberList
    {
        public List<int> Add100ToEachNumber(List<int> input)
        {
            var output = new List<int>();
            foreach (int i in input)
            {
                output.Add(i + 100);
            }
            return output;
        }
        public List<int> Add100ToEachNumberLinq(List<int> input)
        {
            return input.Select(x => x + 100).ToList();
        }

        public List<int> Add50ToFirstThreeElements(List<int> input)
        {
            var output = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i < 3)
                    output.Add(input[i] + 50);
                else
                    output.Add(input[i]);
            }

            return output;
        }
        public List<int> Add50ToFirstThreeElementsLinq(List<int> input)
        {
            return input.Take(3).Select(x => x + 50).Concat(input.Skip(3)).ToList();
        }
        public List<int> Add70ToEverySecondElement(List<int> input)
        {
            var output = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if ((i +1) % 2 == 0)
                    output.Add(input[i] + 70);
                else
                    output.Add(input[i]);
            }

            return output;
        }
        public List<int> Add70ToEverySecondElementLinq(List<int> input)
        {
            return input.Select((x, i) => i % 2 == 0 ? x : x + 70).ToList();
        }

        public List<int> DivideEachNumberBy100(List<int> input)
        {
            var output = new List<int>();

            foreach (int i in input)
            {
                output.Add(i / 100);
            }
            return output;
        }
        public List<int> DivideEachNumberBy100Linq(List<int> input)
        {
            return input.Select(x => x / 100).ToList();
        }

        public List<int> GetNumbersDividableByFive(List<int> input)
        {
            var output = new List<int>();

            foreach (int i in input)
            {
                if (i % 5 == 0)
                    output.Add(i);
            }
            return output;
        }
        public List<int> GetNumbersDividableByFiveLinq(List<int> input)
        {
            return input.FindAll(x => x % 5 == 0).ToList();
        }

        public List<int> GetNumbersHigherThan1000(List<int> input)
        {
            var output = new List<int>();

            foreach (int i in input)
            {
                if (i >1000)
                    output.Add(i);
            }
            return output;

        }
        public List<int> GetNumbersHigherThan1000Linq(List<int> input)
        {
            return input.FindAll(x => x > 1000).ToList();
        }

        public List<int> NegateEachNumber(List<int> input)
        {
            var output = new List<int>();

            foreach (int i in input)
            {
                output.Add(i * -1);
            }
            return output;
        }
        public List<int> NegateEachNumberLinq(List<int> input)
        {
            return input.Select(x => x * -1).ToList();
        }
    }
}