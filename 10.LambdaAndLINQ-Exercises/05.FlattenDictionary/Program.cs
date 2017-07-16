using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> infoDict = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, List<string>> flattened = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string mainKey = tokens[0];
                string innerKey = tokens[1];

                if (tokens.Length == 3)
                {
                    string innerValue = tokens[2];
                    if (!infoDict.ContainsKey(mainKey))
                    {
                        infoDict.Add(mainKey, new Dictionary<string, string>());
                    }

                    if (!infoDict[mainKey].ContainsKey(innerKey))
                    {
                        infoDict[mainKey].Add(innerKey, innerValue);
                    }
                    else
                    {
                        infoDict[mainKey][innerKey] = innerValue;
                    }
                }
                else
                {
                    foreach (var pair in infoDict[innerKey])
                    {
                        string text = pair.Key + pair.Value;
                        if (!flattened.ContainsKey(innerKey))
                        {
                            flattened.Add(innerKey, new List<string>());
                        }
                        flattened[innerKey].Add(text);
                    }
                    infoDict[innerKey] = new Dictionary<string, string>();
                }


                input = Console.ReadLine();
            }

            foreach (var pair in infoDict.OrderByDescending(x => x.Key.Length))
            {
                int count = 1;
                Console.WriteLine($"{pair.Key}");
                var key = pair.Key;
                foreach (var secondPair in pair.Value.OrderBy(x => x.Key.Length))
                {
                    if (secondPair.Value != "null")
                    {
                        Console.WriteLine($"{count}. {secondPair.Key} - {secondPair.Value}");
                        count++;
                    }
                }
                if (flattened.ContainsKey(key))
                {
                    foreach (var flatPair in flattened[key])
                    {
                        Console.WriteLine($"{count}. {flatPair}");
                        count++;
                    }
                }
            }

        }
    }
}
