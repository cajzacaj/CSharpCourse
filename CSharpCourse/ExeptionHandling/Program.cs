using System;
using System.IO;
using CSharpCourse.Utilities;

namespace ExeptionHandling
{
    class Program
    {
        static ConsoleHelper ch = new ConsoleHelper();
        static void Main(string[] args)
        {
            string filename;
            while (true)
            {
                filename = ch.AskForString("Enter a file name:");

                try
                {
                    var newFile = File.CreateText(filename);
                    ch.WriteLine($"The file \'{filename}\' was created");
                    newFile.Close();
                    break;
                }
                catch (ArgumentException)
                {
                    ch.WriteLineRed("The filename is not valid");
                }
                catch (NotSupportedException)
                {
                    ch.WriteLineRed("Invalid input");
                }
                catch (UnauthorizedAccessException)
                {
                    ch.WriteLineRed("You are not autorrized to create this file");
                }
                catch (DirectoryNotFoundException)
                {
                    ch.WriteLineRed("Can't find the folder");
                }
                catch (Exception)
                {
                    ch.WriteLineRed("Something went wrong");
                }
            }

            string text = ch.AskForString("Enter text to add to your file:");
            File.WriteAllText(filename, text);
            ch.WriteLineGreen("Added text to file");

            
        }
    }
}
