using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            string firstHalf = tokens[0];

            Dictionary<string, int> namesValues = new Dictionary<string, int>();

            while (firstHalf != "end")
            {
                string secondHalf = tokens[1];
                int number;
                if (int.TryParse(tokens[1], out number))
                {
                    if (!namesValues.ContainsKey(firstHalf))
                    {
                        namesValues.Add(firstHalf, number);
                    }
                    else
                    {
                        namesValues[firstHalf] = number;
                    }
                }
                else
                {
                    int temp;
                    namesValues.TryGetValue(secondHalf, out temp);
                    if (namesValues.ContainsValue(temp))
                    {
                        if (!namesValues.ContainsKey(firstHalf))
                        {
                            namesValues.Add(firstHalf, temp);
                        }
                        else
                        {
                            namesValues[firstHalf] = temp;
                        }
                    }                    
                }

                tokens = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                firstHalf = tokens[0];
            }

            foreach (KeyValuePair<string, int> pair in namesValues)
            {
                Console.WriteLine($"{pair.Key} === {pair.Value}");
            }
        }
    }
}
