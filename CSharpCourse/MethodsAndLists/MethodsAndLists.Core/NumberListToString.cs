using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToString
    {
        public string ReportFirstAndLastValue(List<int> list)
        {
            if(list?.Any() != true)
                throw new ArgumentException("List is null or empty");

            return $"Första siffran är {list[0]} och sista siffran är {list[list.Count - 1]}";
        }

        public string ReportNumberOfNegativeValues(List<int> list)
        {
            var negativeNums = new List<int>();

            foreach (int i in list)
            {
                if (i < 0)
                    negativeNums.Add(i);
            }

            if (negativeNums.Count == 0)
                return "Jippi! Det finns inga negativa tal i listan";
            else if (negativeNums.Count == 1)
                return "Det finns ett negativt tal i listan";
            else 
                return $"Det finns {negativeNums.Count} st negativa tal i listan";

        }
        public string ReportNumberOfNegativeValuesLinq(List<int> list)
        {
            list.Any(x => x < 0);

            var negativeNums = new List<int>();


            if (!list.Any(x => x < 0))
                return "Jippi! Det finns inga negativa tal i listan";
            else if (negativeNums.Count == 1)
                return "Det finns ett negativt tal i listan";
            else
                return $"Det finns {negativeNums.Count} st negativa tal i listan";

        }
    }
}