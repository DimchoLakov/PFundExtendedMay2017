using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<int>> info = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string[] test = tokens[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int temp;

                if (int.TryParse(test[0], out temp))
                {
                    string name = tokens[0];
                    int[] numbers = tokens[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    if (!info.ContainsKey(name))
                    {
                        info.Add(name, new List<int>());
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            info[name].Add(numbers[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            info[name].Add(numbers[i]);
                        }
                    }
                }
                else
                {
                    string firstName = tokens[0];
                    string secondName = tokens[1];

                    if (info.ContainsKey(secondName))
                    {
                        info.Add(firstName, new List<int>());

                        for (int i = 0; i < info[secondName].Count; i++)
                        {
                            info[firstName].Add(info[secondName][i]);
                        }
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<int>> nameValue in info)
            {
                Console.WriteLine($"{nameValue.Key} === {string.Join(", ", nameValue.Value)}");
            }
        }
    }
}
