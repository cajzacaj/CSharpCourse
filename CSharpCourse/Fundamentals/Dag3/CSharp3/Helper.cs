﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CsharpCourse.Dag3
{
    class ConsoleHelper
    {
        public int ColumnSize { get; set; } = 20;

        public void Init(int width = 60, int height = 20)
        {
            SetStandardColor();

            Console.WindowWidth = width;
            Console.WindowHeight = height;

            Console.BufferWidth = width;

            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
        }




        public void End()
        {
            Console.WriteLine();
            SetStandardColor();
            Console.ReadKey();
        }

        public void Write(object message)
        {
            SetStandardColor();
            Console.Write(message);
        }

        public void WriteLine(object message)
        {
            SetStandardColor();
            Console.WriteLine(message);
        }

        public void WriteLineDark(object message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(message);
        }

        public void Space()
        {
            Console.WriteLine();
        }

        public void WriteLineGreen(object message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public void WriteLineRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void Columns(params object[] cols)
        {
            string s = "";
            foreach (object col in cols)
            {
                if (col is ConsoleColor)
                {
                    Console.ForegroundColor = (ConsoleColor)col;
                    continue;
                }
                s += col.ToString().PadRight(ColumnSize);
            }
            WriteLine(s);
        }

        public double AskForNumber(string question)
        {
            while (true)
            {
                string x = AskForString(question);
                if (double.TryParse(x, out double answer))
                    return answer;
            }
        }

        public int AskForInteger(string question)
        {
            while (true)
            {
                string x = AskForString(question);
                if (int.TryParse(x, out int answer))
                    return answer;
            }
        }

        public string AskForString(string question, string defaultAnswer = null)
        {
            Write($"{question} ");
            string answer = ReadLineGreen();

            if (defaultAnswer != null && string.IsNullOrWhiteSpace(answer))
                return defaultAnswer;

            return answer;
        }

        public string AskForStringRegex(string question, string regex, bool addStartAndEndSign = true)
        {
            while (true)
            {
                Write($"{question} ");
                string answer = ReadLineGreen();

                string pattern = addStartAndEndSign ? "^" + regex + "$" : regex;

                if (Regex.IsMatch(answer, pattern))
                    return answer;
            }
        }

        public char AskForKey(string question, char[] validKeys = null)
        {
            while (true)
            {
                Write($"{question} ");

                char answer = ReadCharGreen().KeyChar;

                answer = CharToUpper(answer);

                if (validKeys == null || validKeys.Contains(answer))
                    return answer;
            }
        }

        private void SetStandardColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        private string ReadLineGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return Console.ReadLine();
        }

        private ConsoleKeyInfo ReadCharGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return Console.ReadKey();
        }

        private char CharToUpper(char c)
        {
            if (!char.IsLetter(c))
                return c;

            return c.ToString().ToUpper()[0];
        }
        public void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + text.ToUpper() + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
