using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class AddNumberEngine
    {
        public enum Error
        {
            InputIsNotNumber, DontHaveTwoValues, AlreadyHaveTwoValues, SecondValueCantBeLowerThanFirst
        }
        public static Error exceptionType;

        private List<int> result = new List<int>();
        public void Input(string input)
        {
            if (int.TryParse(input, out int output))
            {
                if (result.Count == 2)
                {
                    exceptionType = Error.AlreadyHaveTwoValues;
                    throw new Exception(nameof(Error));
                }
                else if (result.Count == 0)
                    result.Add(output);
                else
                {
                    if (output < result[0])
                    {
                        exceptionType = Error.SecondValueCantBeLowerThanFirst;
                        throw new Exception(nameof(Error));
                    }
                    else
                        result.Add(output);

                }
            }
            else
            {
                exceptionType = Error.InputIsNotNumber;
                throw new Exception(nameof(Error));
            }
        }
        public int Result()
        {
            if (result.Count <2)
            {
                exceptionType = Error.DontHaveTwoValues;
                throw new Exception(nameof(Error));
            }

            int output = 0;

            for (int i = result[0]; i <= result[1]; i++)
            {
                output += i;
            }
            return output;
        }
        //public class Exception : SystemException
        //{
        //    public Error Error { get { return exceptionType; } }
        //    public string Message1 { get; set; }

        //    public
        //    Exception(string message) : base(message)
        //    {
        //    }
        //}
    }
}
