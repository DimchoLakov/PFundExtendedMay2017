using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentsInfo = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string continentName = input[0];
                string countryName = input[1];
                string cityName = input[2];

                if (! continentsInfo.ContainsKey(continentName))
                {
                    continentsInfo.Add(continentName, new Dictionary<string, List<string>>());
                }

                if (! continentsInfo[continentName].ContainsKey(countryName))
                {
                    continentsInfo[continentName].Add(countryName, new List<string>());
                }

                continentsInfo[continentName][countryName].Add(cityName);
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> continentCountryPair in continentsInfo)
            {
                Console.WriteLine($"{continentCountryPair.Key}:");
                

                foreach (KeyValuePair<string, List<string>> countryCityPair in continentCountryPair.Value)
                {
                    List<string> cityList = countryCityPair.Value;

                    Console.WriteLine($"{countryCityPair.Key} -> {string.Join(", ", cityList)}");
                }
            }

        }
    }
}
