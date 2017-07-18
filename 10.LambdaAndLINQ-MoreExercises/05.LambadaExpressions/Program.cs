using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LambadaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> lambadaDict = new Dictionary<string, string>();

            while (input != "lambada")
            {
                string[] tokens = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "dance")
                {
                    var temp = lambadaDict.ToDictionary(pair => pair.Key, pair => pair.Value);

                    foreach (KeyValuePair<string, string> pair in temp)
                    {
                        string[] value = temp[pair.Key].Split('.');
                        string selectorObject = value[0];
                        string modifiedText = selectorObject + ".";

                        lambadaDict[pair.Key] = modifiedText + lambadaDict[pair.Key];
                    }
                }
                else
                {
                    string selector = tokens[0];
                    string objectAndProperty = tokens[1];

                    if (!lambadaDict.ContainsKey(selector))
                    {
                        lambadaDict.Add(selector, objectAndProperty);
                    }
                    else
                    {
                        lambadaDict[selector] = objectAndProperty;
                    }

                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> pair in lambadaDict)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
