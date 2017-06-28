using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (dict.ContainsKey(numbers[i]))
                {
                    dict[numbers[i]]++;
                }
                else
                {
                    dict.Add(numbers[i], 1);
                }
            }

            List<int> sortedKeys = dict.Keys.ToList();
            sortedKeys.Sort();

            foreach (var key in sortedKeys)
            {
                Console.WriteLine(key + " -> " + dict[key]);
            }

        }
    }
}
