using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> database = new Dictionary<string, string>();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string left = tokens[0];
                string right = tokens[1];

                if (!database.ContainsKey(left))
                {
                    database.Add(left, right);
                }
                else
                {
                    database[left] = right;
                }
                
                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();
            
            Dictionary<string, string> notReplaced = new Dictionary<string, string>();
            Dictionary<string, string> replaced = new Dictionary<string, string>();
            foreach (var pair in database)
            {
                if (pair.Value != "null")
                {
                    notReplaced.Add(pair.Key, pair.Value);
                }
                else
                {
                    replaced.Add(pair.Key, defaultValue);
                }
            }

            foreach (var pair in notReplaced.OrderByDescending(x => x.Value.Length))
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");
            }

            foreach (var pair in replaced)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");
            }
        }
    }
}