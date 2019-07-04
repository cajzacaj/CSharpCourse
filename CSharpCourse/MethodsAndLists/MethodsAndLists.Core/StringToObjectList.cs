using System;
using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class StringToObjectList
    {
        string input = "Göteborg,401956;Lomma,13016;Mönsterås,5201;Östra Tommarp,293";
        public List<City> ParseCities(string input)
        {
            if (input == null)
                throw new ArgumentException("Can't be null");
            if (string.IsNullOrWhiteSpace(input))
                return new List<City>();

            var cities = new List<City>();
            string[] splitInput = input.Split(';');

            foreach (string i in splitInput)
            {
                string[] cityInfo = i.Split(',');

                var city = new City();
                city.Name = cityInfo[0].Trim();
                city.Population = int.Parse(cityInfo[1].Trim());

                cities.Add(city);
            }
            return cities;
        }
    }
}
