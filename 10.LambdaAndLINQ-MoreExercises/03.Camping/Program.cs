using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> vans = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string name = tokens[0];
                string vanType = tokens[1];
                int timeToStay = int.Parse(tokens[2]);

                if (! vans.ContainsKey(name))
                {
                    vans.Add(name, new Dictionary<string, int>());
                }
                else
                {
                    if (! vans[name].ContainsKey(vanType))
                    {
                        vans[name].Add(vanType, timeToStay);
                    }
                }

                if (! vans[name].ContainsKey(vanType))
                {
                    vans[name].Add(vanType, timeToStay);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> personNameAndVan in vans.OrderByDescending(x => x.Value.Count).ThenBy(names => names.Key.Length))
            {
                int totalStay = 0;

                Console.WriteLine($"{personNameAndVan.Key}: {vans[personNameAndVan.Key].Count}");

                foreach (KeyValuePair<string, int> vanAndNights in personNameAndVan.Value)
                {
                    
                    Console.WriteLine($"***{vanAndNights.Key}");
                    totalStay += vanAndNights.Value;
                }

                Console.WriteLine($"Total stay: {totalStay} nights");
            }

        }
    }
}
