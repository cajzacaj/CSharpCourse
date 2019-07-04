
using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class StringListToStringList
    {
        public IEnumerable<string> GetEverySecondElement(string[] input)
        {
            if (!input.Any())
                throw new ArgumentException("Input can't be null");

            var newList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                    newList.Add(input[i]);
            }
            return newList;
        }
    }
}
