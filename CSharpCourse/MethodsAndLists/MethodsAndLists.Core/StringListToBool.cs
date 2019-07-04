using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class StringListToBool
    {
        public bool AllWordsAreFiveLettersOrLonger(IEnumerable<string> list)
        {
            if (list?.Any() != true)
                return false;

            foreach (var word in list)
            {
                if (word.Length < 5)
                    return false;
            }
            return true;
        }

        public bool AllWordsAreFiveLettersOrLonger_Linq(IEnumerable<string> list)
        {
            if (list?.Any() != true)
                return false;
            else
                return list.All(x => x.Length >= 5);
        }
    }
}
