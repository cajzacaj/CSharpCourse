using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace CsharpCourse.Dag3
{
    class Program
    {
        static ConsoleHelper ch = new ConsoleHelper();
        static void Main(string[] args)
        {

            ListOfCustomers();
        }

        private static void ListOfCustomers()
        {
            List<Customer> listOfCustomers = CreateListOfCustomers("PersonShort.txt");
            DisplayCustomers(listOfCustomers);
        }

        private static void DisplayCustomers(List<Customer> list)
        {

            ch.Header("Sorted list by name");
            list = list.OrderBy(x => x.Name).ToList();
            foreach (var customer in list)
            {
                ch.WriteLine($"{customer.Name,-20} {customer.Age,-20} {customer.Gender}");
            }

            ch.Header("Sorted list by age");
            list = list.OrderBy(x => x.Age).ToList();
            foreach (var customer in list)
            {
                ch.WriteLine($"{customer.Name, -20} {customer.Age, -20} {customer.Gender}");
            }


            ch.Header("Men older than 35");
            list = list.Where(x => x.Gender == "Male" && x.Age >= 35).ToList();
            foreach (var customer in list)
            {
                ch.WriteLine($"{customer.Name,-20} {customer.Age,-20} {customer.Gender}");
            }

            ch.Header("Manipulated");
            list  = list.Select(x => 
            
                new Customer
                {
                    Name=x.Name.ToUpper(),
                    Age=x.Age + 1000,
                    Gender=x.Gender
                }
            
            ).ToList();

            foreach (var customer in list)
            {
                ch.WriteLine($"{customer.Name,-20} {customer.Age,-20} {customer.Gender}");
            }

        }

        private static List<Customer> CreateListOfCustomers(string fileLocation)
        {
            var listOfCustomers = new List<Customer>();

            string[] allRows = File.ReadAllLines(fileLocation);

            foreach (var row in allRows)
            {
                Customer customer = ParseCustomerFromRow(row);
                listOfCustomers.Add(customer);
            }
            return listOfCustomers;
        }

        private static Customer ParseCustomerFromRow(string row)
        {
            string[] splittedRow = row.Split(',');
            var customer = new Customer
            {
                Name = splittedRow[1],
                Age = int.Parse(splittedRow[5]),
                Gender = splittedRow[4]
            };
            return customer;
        }

        private static void ListOfNames()
        {
            List<string> listOfNames = CreateListOfNames("PersonShort.txt");
            DisplayNames(listOfNames);
            Console.ResetColor();
        }

        private static void DisplayNames(List<string> listOfNames)
        {
            ch.Header("Sorted List");
            listOfNames.Sort();

            foreach (var name in listOfNames)
            {
                ch.WriteLineDark(name);
            }

            ch.Header("Start with J");
            foreach (var name in listOfNames.Where(x => x.StartsWith('J')))
            {
                ch.WriteLineDark(name);
            }

            ch.Header("Start with J and uppercase");
            foreach (var name in listOfNames.Where(x => x.StartsWith('J')))
            {
                ch.WriteLineDark(name.ToUpper());
            }
        }

        private static List<string> CreateListOfNames(string fileLocation)
        {
            var listOfNames = new List<string>();

            string[] allRows = File.ReadAllLines(fileLocation);

            for (int i = 0; i < allRows.Length; i++)
            {
                string[] row = allRows[i].Split(',');
                listOfNames.Add($"{row[1]} {row[2]}");
            }

            return listOfNames;
        }

        private static void ProductList()
        {
            Dictionary<int, string> products = BuildProductDictionary();
            DisplayProductDictionary(products);
        }

        private static Dictionary<int, string> BuildProductDictionary()
        {
            var dic = new Dictionary<int, string>();

            while (true)
            {
                string input = ch.AskForString("Enter product ID and name:");
                input = input.Trim();

                if (input == "")
                    return dic;
                if (!ValidInput(input, @"^\d+,[a-z ]+$"))
                {
                    ch.WriteLineRed("Invalid input");
                    continue;
                }

                int id = int.Parse(input.Split(',')[0]);
                string name = input.Split(',')[1];

                if (dic.ContainsKey(id))
                    ch.WriteLineRed($"The product list already contains the id {id}");
                else
                    dic.Add(id, name);
            } 
        }

        private static bool ValidInput(string input, string regex)
        {
            return Regex.IsMatch(input, regex, RegexOptions.IgnoreCase);
        }

        private static void DisplayProductDictionary(Dictionary<int, string> products)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            foreach (var product in products)
            {
                Console.WriteLine($"Product id: {product.Key} and name: {product.Value}");
            }
        }
    }
}
