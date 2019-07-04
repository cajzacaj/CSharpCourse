
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MethodsAndLists.Core
{
    public class StringToBool
    {
        public bool IsPalindromeLinq(string input)
        {
            return input.SequenceEqual(input.Reverse());

        }
        public bool IsPalindrome(string input)
        {
            if (input == null)
                throw new ArgumentException("Input can't be null");

            char[] tempArray = input.ToCharArray();
            foreach (char c in tempArray)
            {
                if (!char.IsLetter(c))
                    throw new ArgumentException("Not all letters");
            }
            Array.Reverse(tempArray);
            string reversedString = new string(tempArray);

            if (input != reversedString)
                return false;
            else
                return true;
        }

        public bool IsZipCode(string text)
        {
            if (text == null)
                return false;

            return Regex.IsMatch(text, @"^[1-9]{1}[0-9]{2} [1-9]{1}[0-9]{1}$");
        }
    }
}
