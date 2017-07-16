using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GroupContinentsCountriesCities
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> continentsInfo;
            continentsInfo = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string contName = input[0];
                string countryName = input[1];
                string cityName = input[2];

                if (! continentsInfo.ContainsKey(contName))
                {
                    continentsInfo.Add(contName, new SortedDictionary<string, SortedSet<string>>());
                }

                if (! continentsInfo[contName].ContainsKey(countryName))
                {
                    continentsInfo[contName].Add(countryName, new SortedSet<string>());
                }

                continentsInfo[contName][countryName].Add(cityName);
            }

            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> continentsAndCountries in continentsInfo)
            {
                Console.WriteLine($"{continentsAndCountries.Key}:");

                foreach (var countriesAndCities in continentsAndCountries.Value)
                {
                    SortedSet<string> cityList = countriesAndCities.Value;

                    Console.WriteLine($"  {countriesAndCities.Key} -> {string.Join(", ", cityList)}");
                }

            }
            
        }
    }
}
