using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _03.TravelCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> travelInfo = new Dictionary<string, Dictionary<string, int>>();

            string firstInput = Console.ReadLine();

            while (firstInput != "ready")
            {
                string[] tokens = firstInput.Split(':');
                string city = tokens[0];
                string[] typeAndCapacity = tokens[1].Split(new char[] {'-', ','},StringSplitOptions.RemoveEmptyEntries);

                if (! travelInfo.ContainsKey(city))
                {
                    travelInfo.Add(city, new Dictionary<string, int>());
                }

                for (int i = 0; i < typeAndCapacity.Length; i+=2)
                {
                    string vehicleType = typeAndCapacity[i];
                    int vehicleCapacity = int.Parse(typeAndCapacity[i + 1]);

                    if (! travelInfo[city].ContainsKey(vehicleType))
                    {
                        travelInfo[city].Add(vehicleType, vehicleCapacity);
                    }
                    else
                    {
                        travelInfo[city][vehicleType] = vehicleCapacity;
                    }

                }
                
                firstInput = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "travel time!")
            {
                string[] secondTokens = secondInput.Split(' ');
                string cityName = secondTokens[0];
                int peopleCount = int.Parse(secondTokens[1]);
                
                foreach (var cityAndTransport in travelInfo)
                {
                    if (cityAndTransport.Key == cityName)
                    {
                        var totalCapacityInEachCity = travelInfo[cityName].Values.Sum();

                        if (peopleCount <= totalCapacityInEachCity)
                        {
                            Console.WriteLine($"{cityAndTransport.Key} -> all {peopleCount} accommodated");
                        }
                        else
                        {
                            Console.WriteLine($"{cityAndTransport.Key} -> all except {peopleCount - totalCapacityInEachCity} accommodated");
                        }

                    }
                }


                secondInput = Console.ReadLine();
            }
            
        }
    }
}
