using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "chop chop")
            {
                string[] tokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

                string treeType = tokens[0];
                int treeHeight = int.Parse(tokens[1]);

                if (! data.ContainsKey(treeType))
                {
                    data.Add(treeType, new List<int>());
                }
                data[treeType].Add(treeHeight);

                input = Console.ReadLine();
            }

            string typeNeeded = Console.ReadLine();
            int heightNeeded = int.Parse(Console.ReadLine());

            double sumTrees = data.Values.Sum(d => d.Sum());
            int treesCount = 0;
            foreach (var list in data.Values)
            {
                treesCount += list.Count;
            }
            double pricePerMeter = Math.Round(sumTrees / treesCount, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");

            int usedLogs = 0;

            //double temp = data.Values.SelectMany(element => element).ToList().Average();

            foreach (KeyValuePair<string, List<int>> pair in data)
            {
                if (pair.Key == typeNeeded)
                {
                    foreach (int treeH in data[pair.Key])
                    {
                        if (treeH >= heightNeeded)
                        {
                            usedLogs += treeH;
                        }
                    }
                }
            }

            int unusedLogs = (int)sumTrees - usedLogs;

            double usedLogsPrice = Math.Round(usedLogs * pricePerMeter, 2);
            double unusedLogsPrice = Math.Round(unusedLogs * pricePerMeter * 0.25, 2);
            double subTotal = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${subTotal:f2}");
        }
    }
}
